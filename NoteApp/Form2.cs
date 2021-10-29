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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            form2Title.Text = Form1.setValueTitle;
            form2Note.Text = Form1.setValueNote;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 returnForm = new Form1();
            returnForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
