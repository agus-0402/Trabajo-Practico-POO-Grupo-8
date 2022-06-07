using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista
{
    public partial class Interfaz_Cliente : Form
    {
        public Interfaz_Cliente()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible=true;
            btnClose.Visible=true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            btnClose.Visible = false;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            btnCloseDos.Visible = true;
        }

        private void btnCloseDos_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            btnCloseDos.Visible =false;
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            btnCloseTre.Visible = true;
        }

        private void btnCloseTre_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;
            btnCloseTre.Visible = false;
        }
    }
}
