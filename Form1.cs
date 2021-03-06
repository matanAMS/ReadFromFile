using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadFromFile
{
    public partial class Form1 : Form
    {
        string path = @"../../file.txt";
        string nameOfManager;
        string nameOfBussiness;
        int newEmploee;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string text = sr.ReadToEnd();
                richTextBox1.Text = text;
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inputManagerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            nameOfManager = inputOwnerName.Text;
            // ליצור file reader 
            // לעבור על כל שורה בfile ועבור כל שורה לבדוק האם השם בעלים מכיל name of manager
            // במידה והשם מתאים אני יוצא ומקפיץ הודעת שגיאה למשתמש על שם קיים
            nameOfBussiness += inputNameOfBussiness.Text;
            string temp = nameOfBussiness;
            nameOfBussiness = nameOfBussiness.Replace(nameOfBussiness, temp + nameOfBussiness);
            newEmploee += Convert.ToInt32(inputEmploee.Text);
            string AllInfo = "Owner Name:" + nameOfManager + "\n Bussiness He Own:," +
                nameOfBussiness + "\n Number Of Emploee Added:" + newEmploee + "\n";
            Console.WriteLine("**************************");
            File.AppendAllText(path, AllInfo);
            MessageBox.Show("All Been Added");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string find = updateText.Text.Trim(); //txtFind is textbox and will have the text that we want to find and replace
                string replace = updateTo.Text.Trim(); //txtReplace is text and it will replace the find text with Replace text
                string newText = richTextBox1.Text.Replace(find, replace);
                richTextBox1.Text = newText;

                //Write the new contents of rich text box to file
                File.WriteAllText(path, richTextBox1.Text.Trim());
                MessageBox.Show(find + " Replaced with" + replace);
                
            }
            catch (Exception ex)
            {
                lblEror.Text = ex.Message;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string tempFile = Path.GetTempFileName();
            using (var sr = new StreamReader(path))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (!line.Contains(this.deleteText.Text))
                        sw.WriteLine(line);//remember the string in tempfile.
                    else
                    {
                        sw.WriteLine(line.Replace(this.deleteText.Text, ""));//replace the string with empty string.
                        MessageBox.Show(this.deleteText.Text + " Deleted");
                    }

                }
            }

            File.Delete(path);
            File.Move(tempFile, path);//write back to the file with new data.
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, String.Empty);
            MessageBox.Show("ALL Been Deleted");
        }
    }
}
