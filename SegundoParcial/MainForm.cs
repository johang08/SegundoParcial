using SegundoParcialDanny.UI.Consulta;
using SegundoParcialDanny.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialDanny
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RVendedor rVendedor = new RVendedor();
            rVendedor.Show();
            rVendedor.MdiParent = this;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CVendedor cVendedor = new CVendedor();
            cVendedor.Show();
            cVendedor.MdiParent = this;
        }
    }
}
