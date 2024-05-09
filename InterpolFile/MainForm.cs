using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private UserControl currentControl;
        FileIndex fileIndex = new FileIndex();

        public MainForm()
        {
            InitializeComponent();
            UC_Home home = new UC_Home();
            addUserControl(home);
        }

        private void addUserControl(UserControl userControl)
        {
            if (currentControl != null && userControl.GetType() == currentControl.GetType())
            {
                return;
            }

            userControl.Dock = DockStyle.Fill;
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(userControl);
            currentControl = userControl;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            UC_Home home = new UC_Home();
            addUserControl(home);
        }

        private void criminalsButton_Click(object sender, EventArgs e)
        {
            UC_Criminals criminals = new UC_Criminals(fileIndex);
            addUserControl(criminals);
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            UC_Archive archive = new UC_Archive();
            addUserControl(archive);
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

        const string PATH_TO_DATA = ".\\criminals.txt";

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fileIndex.SaveCriminals(PATH_TO_DATA);
                MessageBox.Show("Data saved successfully!", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save data. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fileIndex.LoadCriminals(PATH_TO_DATA);
                MessageBox.Show("Data loaded successfully!", "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshCriminalsControl();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The data file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshCriminalsControl()
        {
            if (currentControl is UC_Criminals criminalsControl)
            {
                criminalsControl.RefreshData();
            }
        }
    }
}
