using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_25_10_24
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto Produto = new frmProduto();
            Produto.ShowDialog();
        }

        private void movimentoDoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimento movimento = new frmMovimento();
            movimento.ShowDialog();
        }
    }
}
