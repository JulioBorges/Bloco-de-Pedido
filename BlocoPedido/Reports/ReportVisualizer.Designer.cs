namespace BlocoPedido.Reports
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Windows.Forms;
    using Microsoft.Reporting.WinForms;
    using Object;

    partial class ReportVisualizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.PedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PedidoBindingSource
            // 
            this.PedidoBindingSource.DataSource = typeof(BlocoPedido.Object.Pedido);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 29;
            reportDataSource1.Name = "Dados";
            reportDataSource1.Value = this.PedidoBindingSource;
            reportDataSource2.Name = "DadosItens";
            reportDataSource2.Value = this.PedidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BlocoPedido.Reports.Pedido.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(760, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportVisualizer
            // 
            this.ClientSize = new System.Drawing.Size(760, 474);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportVisualizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportVisualizer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReportViewer reportViewer1;
        private BindingSource PedidoBindingSource;

    }
}