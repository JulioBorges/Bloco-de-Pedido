using System.Collections.Generic;
using System.Windows.Forms;
using BlocoPedido.Data;
using BlocoPedido.Object;

namespace BlocoPedido
{
    public partial class FrmVisualizaCondicoes : Form
    {
        private readonly List<DadosCondicaoPgto> plstLista;
        public FrmVisualizaCondicoes(List<DadosCondicaoPgto> lstLista)
        {
            InitializeComponent();
            plstLista = lstLista;
            dadosCondicaoPgtoBindingSource.DataSource = plstLista;
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            var frm1 = new FrmEditCondicoes();
            frm1.ShowDialog(this);

            dadosCondicaoPgtoBindingSource.DataSource = GerenciadorDados.GetCondicoes(plstLista[0].ValorTotalPedido);
        }
    }
}
