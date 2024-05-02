using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using InterpolFile.Controls;
using InterpolFile.Models;

namespace InterpolFile
{
    public partial class MainForm : Form
    {
        FileIndex fileIndex = new FileIndex();

        public MainForm()
        {
            InitializeComponent();
            UC_Home home = new UC_Home();
            addUserControl(home);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(userControl);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            UC_Home home = new UC_Home();
            addUserControl(home);
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            UC_Archive archive = new UC_Archive();
            addUserControl(archive);
        }

        private void criminalsButton_Click(object sender, EventArgs e)
        {
            UC_Criminals criminals = new UC_Criminals(fileIndex);
            addUserControl(criminals);
        }

        private void helpToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                item.ForeColor = Color.Black;
            }
        }

        private void helpToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                item.ForeColor = Color.White;
            }
        }

        private void fileToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                item.ForeColor = Color.Black;
            }
        }

        private void fileToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                item.ForeColor = Color.White;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
