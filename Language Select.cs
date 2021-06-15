using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_A_Language_Kids
{
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();
            displayLbl();
        }

        private void displayLbl()
        {
            lbl1.Text = "Select a language to learn";
        }

        private void btnFrench_Click(object sender, EventArgs e)
        {
            Frm3 french = new Frm3();
            french.ShowDialog();
        }

        private void btnSpanish_Click(object sender, EventArgs e)
        {
            Frm4 spanish = new Frm4();
            spanish.ShowDialog();
        }
    }
}
