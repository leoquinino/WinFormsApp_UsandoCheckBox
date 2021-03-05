using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_UsandoCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLinguasSelecionados_Click(object sender, EventArgs e)
        {
            string txtLing = "";
            if (ckPython.Checked)
            {
                txtLing += ckPython.Text + ", ";
            }

            if (ckPhp.Checked)
            {
                txtLing += ckPhp.Text + ", ";
            }

            if (ckDelphi.Checked)
            {
                txtLing += ckDelphi.Text + ", ";
            }

            if (ckCSharp.Checked)
            {
                txtLing += ckCSharp.Text + ", ";
            }

            MessageBox.Show("Linguagens Selecionadas :"+txtLing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
