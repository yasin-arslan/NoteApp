using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FontAwesome;
namespace NoteApp
{
    public partial class Form1 : Form
    {
        public static string setValueTitle = "";
        public static string setValueNote = "";
        public DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
            pathText.Text = " Select a file via browse button! ";
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Notes", typeof(String));
            dataGrid.DataSource = table;
            dataGrid.Columns["Title"].Width = 175;
            dataGrid.Columns["Notes"].Visible = false;
            readChecker();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(titleTxt.Text, noteTxt.Text);
            titleTxt.Clear();
            noteTxt.Clear();
            readChecker();
        }
        // This method used to check if there is a note in grid, if not read button will be deactivated.
        public void readChecker()
        {
           if(dataGrid.CurrentCell != null)
            {
                btnRead.Enabled = true;
            }
            else
            {
                btnRead.Enabled = false;
            }
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (dataGrid.CurrentCell != null) {
                int index = dataGrid.CurrentCell.RowIndex;
                btnRead.Enabled = true;
                setValueTitle = table.Rows[index].ItemArray[0].ToString();
                setValueNote = table.Rows[index].ItemArray[1].ToString();
                this.Hide();
                Form2 newForm = new Form2();
                newForm.ShowDialog();
                newForm = null;
                this.Show();
            }
            else if(dataGrid.CurrentCell == null) {
                DialogResult error = MessageBox.Show(" No notes found! ", " Error ", MessageBoxButtons.OK);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGrid.CurrentCell.RowIndex;
            table.Rows[index].Delete();
            readChecker();
        }
        public void btnExport_Click(object sender, EventArgs e)
        {
            // Exporting from .txt file.
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Dosyası | *.txt";
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            // Incase of returning of null, we will check if file selected.
            if (file.ShowDialog() == DialogResult.OK)
            {
                string fileName = file.FileName;
                string safeFileName = file.SafeFileName;
                // Reading from file and adding each note to data grid.
                try
                {
                    pathText.Text = fileName;
                    using(StreamReader sr = new StreamReader(fileName))
                    {
                        // Header used here so we don't get first line because it contains title and notes headers.
                        string header = sr.ReadLine();
                        string[] lines = System.IO.File.ReadAllLines(file.FileName);
                        foreach (var line in lines)
                        {
                            //skipping header line.
                            if (line != header)
                            {
                                table.Rows.Add(line);
                            }
                        }
                    }
                    readChecker();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File could not read!");
                }

            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFile = new OpenFileDialog();
            saveFile.Filter = "Text Dosyası | *.txt";
            saveFile.RestoreDirectory = true;
            saveFile.CheckFileExists = false;
            // Incase of returning of null, we will check if file selected.
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFile.FileName;
                string safeFileName = saveFile.SafeFileName;
                TextWriter writer = new StreamWriter(fileName);
                if (dataGrid.RowCount == 0)
                {
                    MessageBox.Show(" There is no notes to add!");
                }
                else if (dataGrid.RowCount > -1)
                {
                    for (int column = 0; column < table.Columns.Count;column++)
                    {
                        writer.Write(dataGrid.Columns[column].Name + "\t" + "|"+ " ");
                    }
                    writer.WriteLine("");
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        for (int j = 0; j < table.Columns.Count; j++)
                        {
                            writer.Write(dataGrid.Rows[i].Cells[j].Value.ToString() + "\t" + "|" + " ");
                        }
                        writer.WriteLine("");
                    }
                    writer.Close();
                    MessageBox.Show("Data Exported");
                    readChecker();
                }
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            titleTxt.Clear();
            noteTxt.Clear();
            table.Rows.Clear();
        }
        private void pathText_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
