﻿using System;
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
using InterpolFile.Utilities;

namespace InterpolFile
{
    public partial class MainForm : Form
    {
        private UserControl currentControl;
        FileIndex fileIndex = new FileIndex();
        Archive archiveList = new Archive();

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

            if (currentControl is UC_Criminals)
            {
                ((UC_Criminals)currentControl).SetArchive(archiveList);
            }
            else if (currentControl is UC_Archive)
            {
                ((UC_Archive)currentControl).SetArchive(archiveList);
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            UC_Home home = new UC_Home();
            addUserControl(home);
        }

        private void criminalsButton_Click(object sender, EventArgs e)
        {
            UC_Criminals criminals = new UC_Criminals(fileIndex, archiveList);
            addUserControl(criminals);
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            UC_Archive archive = new UC_Archive(archiveList, fileIndex);
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

        const string PATH_TO_LIST_DATA = ".\\criminals.txt";
        const string PATH_TO_ARCHIVE_DATA = ".\\archive.txt";

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fileIndex.SaveCriminals(PATH_TO_LIST_DATA);
                archiveList.SaveCriminals(PATH_TO_ARCHIVE_DATA);
                MessageBox.Show("Данні було успішно збережено!", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження данних. Помилка: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fileIndex.LoadCriminals(PATH_TO_LIST_DATA);
                archiveList.LoadCriminals(PATH_TO_ARCHIVE_DATA);
                RefreshCriminalsControl();
                MessageBox.Show("Дані успішно завантажено!", "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл даних не існує.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося завантажити дані. Помилка: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;
                saveFileDialog.Title = "Save your data file";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    if (currentControl is UC_Criminals)
                    {
                        var currentCriminals = fileIndex.Criminals.ToList();
                        fileIndex.Criminals = GetCurrentSearchResults(fileIndex);
                        fileIndex.SaveCriminals(filePath);
                        fileIndex.Criminals = currentCriminals;
                    }
                    else
                    {
                        var currentCriminals = archiveList.Criminals.ToList();
                        archiveList.Criminals = GetCurrentSearchResults(archiveList);
                        archiveList.SaveCriminals(filePath);
                        archiveList.Criminals = currentCriminals;
                    }
                    MessageBox.Show("Данні було успішно збережено!", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private List<Criminal> GetCurrentSearchResults(object list)
        {
            if (list is FileIndex fileIndex)
            {
                if (string.IsNullOrWhiteSpace(fileIndex.SearchTerm))
                {
                    return fileIndex.Criminals;
                }
                else
                {
                    var searchedCriminals = SearchUtils.SearchCriminals(fileIndex.Criminals, fileIndex.SearchTerm);
                    return CriminalUtils.GetSortedCriminals(searchedCriminals, fileIndex.SortedBy);
                }
            }
            else if (list is Archive archiveList)
            {
                if (string.IsNullOrWhiteSpace(archiveList.SearchTerm))
                {
                    return archiveList.Criminals;
                }
                else
                {
                    var searchedCriminals = SearchUtils.SearchCriminals(archiveList.Criminals, archiveList.SearchTerm);
                    return CriminalUtils.GetSortedCriminals(searchedCriminals, archiveList.SortedBy);
                }
            }
            else
            {
                return null;
            }
        }

        private void openAs_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.DefaultExt = "txt";
                openFileDialog.AddExtension = true;
                openFileDialog.Title = "Open your data file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (currentControl is UC_Criminals)
                    {
                        string filePath = openFileDialog.FileName;
                        fileIndex.LoadCriminals(filePath);
                    }
                    else
                    {

                        string filePath = openFileDialog.FileName;
                        archiveList.LoadCriminals(filePath);
                    }

                    RefreshCriminalsControl();
                    MessageBox.Show("Дані успішно завантажено!", "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void RefreshCriminalsControl()
        {
            if (currentControl is UC_Criminals criminalsControl)
            {
                CriminalUtils.RefreshData(criminalsControl);
            }

            if (currentControl is UC_Archive archiveControl)
            {
                CriminalUtils.RefreshData(archiveControl);
            }
        }

    }
}
