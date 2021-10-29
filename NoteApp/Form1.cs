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
        DataTable table = new DataTable();
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
            dataGrid.Columns["Notes"].Visible = false;
            dataGrid.Columns["Title"].Width = 175;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(titleTxt.Text, noteTxt.Text);
            titleTxt.Clear();
            noteTxt.Clear();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = dataGrid.CurrentCell.RowIndex;
            if(index == -1)
            {
                btnRead.Enabled = false;
                DialogResult error = MessageBox.Show(" No notes found! ", " Error ", MessageBoxButtons.OK);
                Form1 newForm1 = new Form1();
                newForm1.Show();
            }
            if (index > -1)
            {

                setValueTitle = table.Rows[index].ItemArray[0].ToString();
                setValueNote = table.Rows[index].ItemArray[1].ToString();
                Form2 newForm = new Form2();
                newForm.Show();


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGrid.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }

        private void btnExport_Click(object sender, EventArgs e)
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
                        string[] lines = System.IO.File.ReadAllLines(file.FileName);
                        foreach (var line in lines)
                        {
                            table.Rows.Add(line);
}
                    }}

                catch (Exception ex)
                {
                    MessageBox.Show(" The file could not read!");
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
                        writer.Write("\t" + dataGrid.Columns[column].Name + "\t" + "|");
                    }
                    writer.WriteLine("");
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        for (int j = 0; j < table.Columns.Count; j++)
                        {
                            writer.Write("\t" + dataGrid.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                        writer.WriteLine("");

                    }
                    writer.Close();
                    MessageBox.Show("Data Exported");
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            titleTxt.Clear();
            noteTxt.Clear();
        }

        private void pathText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
