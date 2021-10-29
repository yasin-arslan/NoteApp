using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Notes", typeof(String));
            dataGrid.DataSource = table;
            dataGrid.Columns["Notes"].Visible = false;
            dataGrid.Columns["Title"].Width = 175;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            titleTxt.Clear();
            noteTxt.Clear();
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
            if (index > -1)
            {
                setValueTitle = table.Rows[index].ItemArray[0].ToString();
                setValueNote = table.Rows[index].ItemArray[1].ToString();
                Form2 newForm = new Form2();
                newForm.Show();
                this.Close();
            }
            if(index <= -1)
            {
                btnRead.Enabled = false;
                /*DialogResult error = MessageBox.Show(" No notes found! "," Error ",MessageBoxButtons.OK);
                Form1 newForm1 = new Form1();
                newForm1.Show();*/

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGrid.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }


    }
}
