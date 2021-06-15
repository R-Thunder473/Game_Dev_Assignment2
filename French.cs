using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_A_Language_Kids
{
    public partial class Frm3 : Form
    {
        public Frm3()
        {
            InitializeComponent();
            displayLbl();
        }

        private void displayLbl()
        {
            lblQuestion.Text = ("Which one of these is an 'apple'?");
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
