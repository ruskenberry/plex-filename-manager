using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace Plex_Filename_Manager
{
    public partial class Form1 : Form
    {
        public string showName = "";
        public string currentSeason = "";
        public string selectedPath = "";
        public Boolean seasonFormat = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            this.DirSearch(this.selectedPath);
        }

        public void DirSearch(string sDir)
        {
            try
            {
                int count = 0;
                foreach (string f in Directory.GetFiles(sDir))
                {
                    Debug.Print("   Files found: " + f);

                    if (!Path.GetExtension(f).Contains(".jpg"))
                    {
                        if (!Path.GetExtension(f).Contains(".srt"))
                        {
                            count++;
                        }
                        string newfilename = sDir + "\\" + showName + " - s" + currentSeason + "e" + count.ToString("00") + Path.GetExtension(f);
                        Debug.Print(newfilename);
                        System.IO.File.Move(f, newfilename);
                        
                    }

                }


                count = 1;
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    //TODO Look for number after "Season"
                    //Regex re = new Regex(@"(\d+)");
                    //Match result = re.Match(d);
                    //currentSeason = result.Value;

                    Debug.Print("Folders found: " + d);
                    this.currentSeason = count.ToString("00");
                    if (seasonFormatCheckBox.Checked)
                    {
                        Debug.Print("New Folder Name: " + sDir + "\\Season " + this.currentSeason);
                        string destination = sDir + "\\Season " + this.currentSeason;
                        Directory.Move(d, destination);
                        this.DirSearch(destination);
                    }
                    else
                    {
                        this.DirSearch(d);
                    }
                    Debug.Print("{ showName:" + showName + ", seasonNum:" + currentSeason + "}");
                    count++;
                }
            }
            catch (System.Exception excpt)
            {
                Debug.Print("Error: ");
            }
        }

        private void showNameTextBox_TextChanged(object sender, EventArgs e)
        {
            showName = showNameTextBox.Text;
            Debug.Print("   Show Name : " + showName);
        }

        private void showNameLabel_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    string[] folders = Directory.GetDirectories(fbd.SelectedPath);

                    this.selectedPath = fbd.SelectedPath;
                    this.showName = showNameTextBox.Text = new DirectoryInfo(selectedPath).Name;
                    Debug.Print("Show Name : " + showName);
                    Debug.Print("Path Name : " + selectedPath);
                }
            }
        }
    }
}
