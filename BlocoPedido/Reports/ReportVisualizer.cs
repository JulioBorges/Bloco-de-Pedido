using System;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;

namespace BlocoPedido.Reports
{
    using Data;
    using Object;

    public partial class ReportVisualizer : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Pedido PedidoImpressao;
        public ReportVisualizer()
        {
            InitializeComponent();
        }

        private void ReportVisualizer_Load(object sender, EventArgs e)
        {
            var pedidos = new List<Pedido> { PedidoImpressao };

            PedidoBindingSource.DataSource = pedidos;
            reportViewer1.LocalReport.DataSources.Remove(reportViewer1.LocalReport.DataSources["DadosPedido"]);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DadosPedido", pedidos));
            reportViewer1.LocalReport.DataSources.Remove(reportViewer1.LocalReport.DataSources["DadosItens"]);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DadosItens", PedidoImpressao.ItensPedido ?? new List<ItemPedido>()));
            reportViewer1.LocalReport.DataSources.Remove(reportViewer1.LocalReport.DataSources["DadosCondicoes"]);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DadosCondicoes", GerenciadorDados.GetCondicoes(PedidoImpressao.ValorTotalPedido)));
            reportViewer1.RefreshReport();
        }
    }
}
