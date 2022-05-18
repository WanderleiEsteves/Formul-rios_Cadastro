using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_Wanderlei
{
    public partial class FrmAlimento : Form
    {
        public FrmAlimento()
        {
            InitializeComponent();
        }

        private void tsmiLoja_Click(object sender, EventArgs e)
        {
            var Frm = new FrmLoja();
            this.Hide();
            Frm.ShowDialog();
        }

        private void tsmiPrefeito_Click(object sender, EventArgs e)
        {
            var Frm = new FrmPrefeito();
            this.Hide();
            Frm.ShowDialog();
        }
    }
}
