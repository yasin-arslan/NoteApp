using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome;

namespace NoteApp
{
    public partial class Form2 : Form
    {
        public static bool shouldReturn = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            form2Title.Text = Form1.setValueTitle;
            form2Note.Text = Form1.setValueNote;
            this.Text = ("Note : " + form2Title.Text);
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void form2Title_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
