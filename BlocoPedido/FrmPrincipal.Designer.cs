﻿using System.Collections.Generic;
using BlocoPedido.Object;

namespace BlocoPedido
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.Label valorTotalPedidoLabel;
            System.Windows.Forms.Label numPedidoLabel;
            System.Windows.Forms.Label freteLabel;
            System.Windows.Forms.Label garantiaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.stmManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.txtRazaoSocial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbLogotipo = new System.Windows.Forms.PictureBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblIdentificacao = new System.Windows.Forms.Label();
            this.txtIdentificacao = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.txtResponsavel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCnpj = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new System.Windows.Forms.Label();
            this.txtCEP = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.labelX8 = new System.Windows.Forms.Label();
            this.txtTelefone = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txtFax = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.labelX9 = new System.Windows.Forms.Label();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.txtInscEstadual = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgItensPedido = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblEndereco0 = new System.Windows.Forms.Label();
            this.cbCondicaoSelecionada = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtFrete = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGarantia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNumPedido = new DevComponents.Editors.IntegerInput();
            this.txtValorTotalPedido = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtObservacoes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPrazoEntrega = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSolicitacao = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnNovoPedido = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.btnPreviaCondicoes = new DevComponents.DotNetBar.ButtonX();
            this.dtiDataPedido = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnFinalizar = new DevComponents.DotNetBar.ButtonX();
            this.btnProximo = new DevComponents.DotNetBar.ButtonX();
            this.btnAnterior = new DevComponents.DotNetBar.ButtonX();
            this.btnPrimeiro = new DevComponents.DotNetBar.ButtonX();
            this.btnUltimo = new DevComponents.DotNetBar.ButtonX();
            this.btnEditar = new DevComponents.DotNetBar.ButtonX();
            this.ProgressoDelecao = new DevComponents.DotNetBar.Controls.CircularProgress();
            valorTotalPedidoLabel = new System.Windows.Forms.Label();
            numPedidoLabel = new System.Windows.Forms.Label();
            freteLabel = new System.Windows.Forms.Label();
            garantiaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogotipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItensPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiDataPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // valorTotalPedidoLabel
            // 
            valorTotalPedidoLabel.AutoSize = true;
            valorTotalPedidoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            valorTotalPedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorTotalPedidoLabel.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(valorTotalPedidoLabel, true);
            valorTotalPedidoLabel.Location = new System.Drawing.Point(585, 560);
            valorTotalPedidoLabel.Name = "valorTotalPedidoLabel";
            valorTotalPedidoLabel.Size = new System.Drawing.Size(116, 13);
            valorTotalPedidoLabel.TabIndex = 26;
            valorTotalPedidoLabel.Text = "Valor Total Pedido:";
            // 
            // numPedidoLabel
            // 
            numPedidoLabel.AutoSize = true;
            numPedidoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            numPedidoLabel.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(numPedidoLabel, true);
            numPedidoLabel.Location = new System.Drawing.Point(570, 58);
            numPedidoLabel.Name = "numPedidoLabel";
            numPedidoLabel.Size = new System.Drawing.Size(68, 13);
            numPedidoLabel.TabIndex = 30;
            numPedidoLabel.Text = "Num Pedido:";
            // 
            // freteLabel
            // 
            freteLabel.AutoSize = true;
            freteLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            freteLabel.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(freteLabel, true);
            freteLabel.Location = new System.Drawing.Point(12, 225);
            freteLabel.Name = "freteLabel";
            freteLabel.Size = new System.Drawing.Size(34, 13);
            freteLabel.TabIndex = 32;
            freteLabel.Text = "Frete:";
            // 
            // garantiaLabel
            // 
            garantiaLabel.AutoSize = true;
            garantiaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            garantiaLabel.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(garantiaLabel, true);
            garantiaLabel.Location = new System.Drawing.Point(273, 225);
            garantiaLabel.Name = "garantiaLabel";
            garantiaLabel.Size = new System.Drawing.Size(50, 13);
            garantiaLabel.TabIndex = 34;
            garantiaLabel.Text = "Garantia:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            label1.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(label1, true);
            label1.Location = new System.Drawing.Point(607, 186);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(126, 13);
            label1.TabIndex = 11;
            label1.Text = "Condição de pagamento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            label2.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(label2, true);
            label2.Location = new System.Drawing.Point(537, 225);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 13);
            label2.TabIndex = 37;
            label2.Text = "Prazo de entrega:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            label3.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(label3, true);
            label3.Location = new System.Drawing.Point(402, 304);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 13);
            label3.TabIndex = 39;
            label3.Text = "Observações:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            label4.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(label4, true);
            label4.Location = new System.Drawing.Point(12, 304);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 13);
            label4.TabIndex = 41;
            label4.Text = "Solicitação:";
            // 
            // stmManager
            // 
            this.stmManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.stmManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248))))), System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(170)))), ((int)(((byte)(177))))));
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            // 
            // 
            // 
            this.txtRazaoSocial.Border.Class = "TextBoxBorder";
            this.txtRazaoSocial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRazaoSocial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "RazaoSocial", true));
            this.txtRazaoSocial.Enabled = false;
            this.txtRazaoSocial.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.txtRazaoSocial, true);
            this.txtRazaoSocial.Location = new System.Drawing.Point(12, 118);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(431, 20);
            this.txtRazaoSocial.TabIndex = 6;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataSource = typeof(BlocoPedido.Object.Pedido);
            // 
            // pbLogotipo
            // 
            this.pbLogotipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.pbLogotipo.ForeColor = System.Drawing.Color.Black;
            this.pbLogotipo.Location = new System.Drawing.Point(12, 12);
            this.pbLogotipo.Name = "pbLogotipo";
            this.pbLogotipo.Size = new System.Drawing.Size(463, 84);
            this.pbLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogotipo.TabIndex = 3;
            this.pbLogotipo.TabStop = false;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.lblRazaoSocial.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.lblRazaoSocial, true);
            this.lblRazaoSocial.Location = new System.Drawing.Point(12, 102);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(75, 14);
            this.lblRazaoSocial.TabIndex = 4;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(757, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4);
            this.btnPrint.Size = new System.Drawing.Size(36, 37);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Tooltip = "<b>Imprimir pedido</b>";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.lblEndereco.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.lblEndereco, true);
            this.lblEndereco.Location = new System.Drawing.Point(12, 144);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 14);
            this.lblEndereco.TabIndex = 7;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            // 
            // 
            // 
            this.txtEndereco.Border.Class = "TextBoxBorder";
            this.txtEndereco.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "Endereco", true));
            this.txtEndereco.Enabled = false;
            this.txtEndereco.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.txtEndereco, true);
            this.txtEndereco.Location = new System.Drawing.Point(12, 160);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(321, 20);
            this.txtEndereco.TabIndex = 10;
            // 
            // lblIdentificacao
            // 
            this.lblIdentificacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.lblIdentificacao.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.lblIdentificacao, true);
            this.lblIdentificacao.Location = new System.Drawing.Point(301, 186);
            this.lblIdentificacao.Name = "lblIdentificacao";
            this.lblIdentificacao.Size = new System.Drawing.Size(52, 14);
            this.lblIdentificacao.TabIndex = 9;
            this.lblIdentificacao.Text = "Contato:";
            // 
            // txtIdentificacao
            // 
            this.txtIdentificacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            // 
            // 
            // 
            this.txtIdentificacao.Border.Class = "TextBoxBorder";
            this.txtIdentificacao.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIdentificacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "Identificacao", true));
            this.txtIdentificacao.Enabled = false;
            this.txtIdentificacao.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.txtIdentificacao, true);
            this.txtIdentificacao.Location = new System.Drawing.Point(301, 202);
            this.txtIdentificacao.Name = "txtIdentificacao";
            this.txtIdentificacao.Size = new System.Drawing.Size(300, 20);
            this.txtIdentificacao.TabIndex = 15;
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.lblResponsavel.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.lblResponsavel, true);
            this.lblResponsavel.Location = new System.Drawing.Point(12, 186);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(75, 14);
            this.lblResponsavel.TabIndex = 11;
            this.lblResponsavel.Text = "Responsável:";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            // 
            // 
            // 
            this.txtResponsavel.Border.Class = "TextBoxBorder";
            this.txtResponsavel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtResponsavel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "Responsavel", true));
            this.txtResponsavel.Enabled = false;
            this.txtResponsavel.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.txtResponsavel, true);
            this.txtResponsavel.Location = new System.Drawing.Point(12, 202);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(284, 20);
            this.txtResponsavel.TabIndex = 14;
            // 
            // lblTelefone
            // 
            this.lblTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.lblTelefone.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.lblTelefone, true);
            this.lblTelefone.Location = new System.Drawing.Point(691, 102);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(53, 14);
            this.lblTelefone.TabIndex = 13;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            // 
            // 
            // 
            this.txtCnpj.Border.Class = "TextBoxBorder";
            this.txtCnpj.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "Cnpj", true));
            this.txtCnpj.Enabled = false;
            this.txtCnpj.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.txtCnpj, true);
            this.txtCnpj.Location = new System.Drawing.Point(449, 118);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(115, 20);
            this.txtCnpj.TabIndex = 7;
            // 
            // lblCidade
            // 
            this.lblCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.lblCidade.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.lblCidade, true);
            this.lblCidade.Location = new System.Drawing.Point(453, 144);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(44, 14);
            this.lblCidade.TabIndex = 15;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            // 
            // 
            // 
            this.txtCidade.Border.Class = "TextBoxBorder";
            this.txtCidade.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "Cidade", true));
            this.txtCidade.Enabled = false;
            this.txtCidade.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.txtCidade, true);
            this.txtCidade.Location = new System.Drawing.Point(449, 160);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(236, 20);
            this.txtCidade.TabIndex = 12;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.labelX7, true);
            this.labelX7.Location = new System.Drawing.Point(339, 144);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(34, 14);
            this.labelX7.TabIndex = 17;
            this.labelX7.Text = "CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            // 
            // 
            // 
            this.txtCEP.BackgroundStyle.Class = "TextBoxBorder";
            this.txtCEP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCEP.ButtonClear.Visible = true;
            this.txtCEP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "Cep", true));
            this.txtCEP.Enabled = false;
            this.txtCEP.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.txtCEP, true);
            this.txtCEP.Location = new System.Drawing.Point(339, 160);
            this.txtCEP.Mask = "00000-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(104, 20);
            this.txtCEP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtCEP.TabIndex = 11;
            this.txtCEP.Text = "     -";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.labelX8, true);
            this.labelX8.Location = new System.Drawing.Point(691, 144);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(29, 14);
            this.labelX8.TabIndex = 13;
            this.labelX8.Text = "Fax:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            // 
            // 
            // 
            this.txtTelefone.BackgroundStyle.Class = "TextBoxBorder";
            this.txtTelefone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTelefone.ButtonClear.Visible = true;
            this.txtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "Fone", true));
            this.txtTelefone.Enabled = false;
            this.txtTelefone.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.txtTelefone, true);
            this.txtTelefone.Location = new System.Drawing.Point(692, 118);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(101, 20);
            this.txtTelefone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtTelefone.TabIndex = 9;
            this.txtTelefone.Text = "";
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            // 
            // 
            // 
            this.txtFax.BackgroundStyle.Class = "TextBoxBorder";
            this.txtFax.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFax.ButtonClear.Visible = true;
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "Fax", true));
            this.txtFax.Enabled = false;
            this.txtFax.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.txtFax, true);
            this.txtFax.Location = new System.Drawing.Point(692, 160);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(101, 20);
            this.txtFax.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtFax.TabIndex = 13;
            this.txtFax.Text = "";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.labelX9, true);
            this.labelX9.Location = new System.Drawing.Point(449, 102);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 14);
            this.labelX9.TabIndex = 18;
            this.labelX9.Text = "CNPJ:";
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            // 
            // 
            // 
            this.txtInscEstadual.Border.Class = "TextBoxBorder";
            this.txtInscEstadual.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInscEstadual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "Insc_Estadual", true));
            this.txtInscEstadual.Enabled = false;
            this.txtInscEstadual.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightOnFocus(this.txtInscEstadual, true);
            this.txtInscEstadual.Location = new System.Drawing.Point(570, 118);
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Size = new System.Drawing.Size(116, 20);
            this.txtInscEstadual.TabIndex = 8;
            // 
            // dgItensPedido
            // 
            this.dgItensPedido.AllowUserToOrderColumns = true;
            this.dgItensPedido.AutoGenerateColumns = false;
            this.dgItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItensPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.valorUnDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn});
            this.dgItensPedido.DataSource = this.itensPedidoBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.Da&0RbK �}s\�@yQt!��t)kdZM`� �#)� �s(�(-�."�m�"nqBe`id�b$xƱm,�� ���tjg8=!B�V��2\c^��#�d��x�w6?���C9h,"���" px)r<FIL�JjpWvxn�Woh`,�| ��.als�:	
�%� ( �@(�!vii6,g�+�eZ�dlj$g�IytC�~!B
#Si�vmm:TB���NgvC�-O1fF�f+�&gkj �nd%'(!{��ea�<f)M��<�h�m@�|(�rq��((��;�9:)��)X8Nl)($��f )�?!)8kA�-j&&`5   !h�s�vk{�.�oFL+m�hGD�~c���9q*H�nj�G�OmCu{n}h��=IP�lSTh]�o�-5kuu;X
�) "b&)!B�&h��/ko�TEoSt�4i`o.O�N�*wO3�&lE���kEaTx+g.7i�K1�V�#1�;�
"�" ��`���H	�n`�jp,(PmLi@�+_mm}FQhayy�6 nm��3T! f�2#"
�^Ir(ewY�np`l�S,&�pl3;d$�GSW.�Pu�[uy"�� (d2ps�d�` �e(*w�'�so�WU%lu��q��'�=n��d�6q%l(b�q�|N;دZul/ia6-11�++Xj� +(#��+rUc�_n`�	[L�W g��L�N�.bAn�0�$:z=B �6�i N�  �v i�,f�xg.sA��XdoFirp6�Y�v!�.��5kq%���!"�s#)&$ #�#�$h !*0db0� O.�~dIg�am`�t��<q�[y�z4F�}Go=)=JO� ��4!!1% "'�b$F ,$ 0� 04�x�IQs,z>n+�HRa�2]f�c�M�p��LyD?D���?DA0WV�g��x�	N�o*�! �C|(e��L	��\  h80(��T�kv?��5A'K\aWOr+TfQu�VD��Cjt����@nH$Itm�t�^Dr��/dym :�
$((a� t!�p*X�iS�3�^)��fAc�kGPIu�P'�}�G�cG��N!�Ʋ5p"cg��/P�^hrqF\e�Pk�Onea"�� $�
 *(" %)tLMa&c�fi�v%��Are$WI}w �x�W�;My/WI`dj ��5�
qa�C"�""  `"-�� 2�d"1 *�n-n"�T�l��aaEuE��q�� WX�w��wB/xV*_$�O�)*)`%*!t "?�X�z��   1g���`(pxq3.rM�b�c'��,0pgr�$R�eW@���1_8G�lw`�i� CqPso2f8ylaEd p�xu�W�{��R4�``,�����s�tT��3Nhu`~����a%�a4+�rOA�8tjP�y�Dk�	og��o:H)EDagTe�t�=�"K��{�/t�@D0���v!2�� %a (  `h!�'�q)znI`!Tu@`6aW�v�FkLv@dHu�OxoL�maM�p�h3�te^|madm$�)V�id�-dReruBf�>I�nn.;�
s@! @��0d�"q�<}Q.d�cqxid�$`B��"�inXASu�tA��MI�})n��-�tX�<h7���  a$H �$�'�'�H 4""qamx ���+ -m3��m[�QF�a�Ry ���u|l�~HkgL���(��2*�"Qa!0n/%" i� d!�m%0Hl(��fe�Sql}`JL!w�Fz�d���e9dB��Oklgn>4�`!0�#u��UQFa_e5 &�!`c�!Brg�{H @'�"�� ��aci�+TmQc�ijA~Eixl�Zd=�$wLkhggxRveuon���A%b���5"�&b���-	bPl@ZU�` �`$    "|hU3�gU�hlal@��5r�d2m�c�e�Bn~�mn�-�(fgm�	"�.a7arc@�"atdCzi`^mIu�e8rJmyC�|wmn${��� Al��{ (L�t1;3�d`WGx-cao,ab}�#�R"w4\�xt^gPWolw�g�F��0,$�6{1�#��,8j!�8l�l�`Oo!N)�(� $h `(�tmhI*�!8�v�k�dI}�v)�<�O��ov-]O�j(�J=", `��b�:�[B!� d. �1` 6dt1��&�<L�D|�k�c%`)r~�es@C�����)=q,o���|iTSO4P|y�=ma yA#V H>T�|".�!$ !�*�50�dqd@�r��E2S�\��d� pN{RsaD(= ^��=8���  |2$4 2d�0bQ�tV)Ds�b�6
t]e�$/�|�f��k��!�x���b'
C0 �x�c+0C ti-s(�eWp}.F`t�#R�TP8eӴgt`�O}SkDU	j�M]�p�,�SMn.z6��f&?0lq@cb�gDyl�Bo�l{rV#�3h�0��"B�*  ts�3��i�VWW���_`�rMv��a��g0N�}<�in,Yyaef�ieh�="4Y�~Uj����`-w0( 4�c12dx:��fKj�b��D-nGr+�v�dPxd1�a�5Mg�dG% ]rGc%/zt��e�W0��V�eW/zuĿ�K�l��L;�� 6"y����` �(/_�-)*�`$#�p$�$�/+o��lk�T�t!iLuphVR�l�i2TP|�ǿ�K���lh�`b  J!*""Xh�-�h$"$5h! �$8SV�A3.b@D} XO�e.\�E.Oxit��%.�1qo0A~l�m�oT�e��|kfu���k�eA "Xn'�t{vel�;k �( �!    �v1v`wp�L�ia�@dEt;d�1fFopec䨼 )N2<�J1�`�, �d!$  �`deb�1��P4f~fq>�me��N�hlኅ`�,6�8&,�<�8$ �t�<i���-�^��|Kf�\\qA��IWRhdCy.�D �BKXOdel��efg�}5Xox=tAd�a�"b!�@Fc|�'xEgP-�d�>ie��5ZfR< d�t8bh�h1;*Rel�g�`1�EkK'gy�ri�7uMyRoxC�`ov.NeA���Lz4b=	���l�A޷uu�&�?_ H4*��$t����i-.fcJ�p�/phCnlb6i�y%f\qzu`�*�mdq}g�i4g�&���@lN*�OwH^�IedN:enF�c�],\DBOnA�L]yn"�%
�((,05�! !a�*	s�`�o�lD�|�BD�/bk���a?�lYf9BhTm�"Peq�_vd�%�Bt�q�E�H⠱ �(,1?0*c  2�p#( ����m}/"cVe'�{�`/jo|��#u�qe� :8��0" �(�+m�	S$ pa4�6�x�#*�|��Xu|�-m�d�L�Pj`nE�5ax�fgԐU�"@�%�3�yi<jb�%$�""@!*0+ �	W.yL��X%�C�mB�vd�/oa�g�ce�Uv`9G2�Ű2ul�c$`d�p�-Ym$�o�s�be�	(�0 9"e>,�jd�f%T��Y�FMif�ig+�g��2C�@_��Lݏ�CiaL�a`�M0n+s��g�^>EshtE��F@evJ����e�ns�'L�`obyviil�f�b�U<To;Atok�L��K�d.x8��: d`80,1'+2D
!�@ k @��$--2l�tA~�X�e�Eʭp B|d���� ��* ��!d,p  �#�q@U�*n3$MoE$O�k�0��aWoQ��� Y A(C %ncE2aqIz'Kd�r8O�l-K2Js(:��7h�n(/}v`ih1�0��h1lAnt�=s��te�71%�- jjm.r{*|���w�i2p8��(	#9$ 8d$0 "X�attyp�gc|mgvE�g�k4L�+_ag(-S 8hYK�h�%& j�vo�t�Lor>
luJ�S�(<x! q("`���i3=HEF(L{�hl,zv9]4`#g�$�lfv�_+u�(�Xnv]J=Uz�!�v{O ��%nsE�s
2 $�8�b�(!<hcw^hc�C��ficjVl�A~�o28h~E9!�h�%^.D�vzFw�oan��u! ��46;�( �"$�`Q���VAs�\*FMLdcpq�c#�.)7 , �}C�Eo�Ux�aot"[�FF$�  (��%$iuT8��~h۬gbUnR��gnW�Z!|`�Ad"�<R}'o*D�Aw�J2�{i���R(�atWZ! �,'�d<�� r��7�� ��z%)(+Ve��]dgP ;"9{	�%#ba��;#S&!x+�.|d@D.�!cLio�&F-�V ��E.(E�29�`� s�"0f=>-!�%6��A`��Ш�o+sbKoz�duWB�}@ciO6a� 	*0 �rd00", �4�(�!b!%8"eB,d�)r�cbsiJiq��$|v+Io}! ��yyxlc�IuMs�"`j��5JP�c�+#O	p�h� �$���d"\HiS��"Ckn\GbmeRd�t!`+oYte�v`�mmE4	)Ya4�t�3k�nj'6>F��G�bS��}`og�vn+7t�a{�i�f�O"	$ ),�"(�`2ZiF���g<�)r`���|ecy/oI`)*EbWg�Ed$=$a��d�	�	,  0 L7e��tx�Q,vQ#Gf>�%K�g.��8�Uq``'�haRv|��u�S}wV��vt�Tr7c,�t�eA.^eg�x8�g+B6Qm7+A� �-H(��!xf�#.rb#�.`kc�oC}mo[i�n5��.�.'Wgo{ - RqbP��.d�"w#f-Nmorcrh}�k;�'(`V4F� *eh�s*@b�gnhkohFP�H��k��g`5$F�!}Ypt5n`�m`b�`��.b#ea�,b 16$)�b�` a6L-Sdh�w@Lhg
�-�<Quc��eq<�'���|cn�2 tr�:,fgC{jmd�P�A�oMfo�}@�iqHZ97))j0#� @G!�+ࠪTL��&Gfq���#`�3�Me�5}d�"`�Q����UqG�4� �Đ(* C� "�4d��+ 7sH9n�0Bj�[i�`��Gx�'g�nahc���h�5Ao- �!��" Gѷd�oBrWi{,�/`*�46�9�2��M
`$��2�$@pij|�#g�mel�aiw��@ab;�l��^!hGA=�bn�vdy)!cs��uC�OHi����_� &  � # `!��yi/rbSv^aEKd�F$��@o�O��"4��5P9�d���{�sd�-,�p���og��mJ%�%5%/ b�!�	J 1! �ja`;�쐠`�s�z#�m~d�(acCm���+m�d%�r<yEU ~#�e~*~e�^?qv@3.A?5���K�t*�FUt��t�erb$mh�arqNEh�"kCd�SFfdZjd^q�9,�l !��!!` "5(�t��tW�g�cKBe-{yl��%c&�a��GlMp�}`1�:�
:�0 12T @pE(w��gE^l���Cl}mtzko�/�+l�a^4��QnB�N�0��mXpeO�~<+*m��h� � )�u�js\g��njgl� a?e-�c�n"a�1�Th�3�)l�z'�xBxaC�d":4(^mtLP�u�i�D6�,\�ao�mDRj�hhAwCcC�lmc�&wob�dg��ETMn�/��nao'gd!k�#�"$ �6�hx!0 �.	h1�*.`m�1h 0�10xk�pe��U� �'��"0�$ �!v-*d$ �!&d� �  �\�.C�x��F2ntM����S#h>R���!#$EL��V`U`��nolz.�ce�l+��.]~�%�9(�x�h25/y�"=�a~T��(��x�s�25� �;Ť(��I�v�(Ac��g��1u8�!);D���%"�p �#e/%�l��Ah�0�6   ` ��9O�)` 0�&.!! �}4�*�a��'��p���X��qld$vb/vm o2g`r(A$e'sd,bt,Zf v[pwkdm ;��`$ 9#)4c!3��k*txWDpTt$!G/fem0.c-;Juv\��t��eA"C'Mam.eft dTq0SC�"bBgp pw{ru>�=wyrm?L`1)44�! `( )rt>�N�Kt.YAt)fhl�MNFKI0d`w2�v~�<.wMbsn3�NMp�;<j{rGh?d�F�)�<�l&VjsP&@GE)>c,�$ifgUo�r{{4*Nbu7e&��t=m);q 3 �8(�t(,u
AsO�{|T�A]u*e*1FL�i`5�1nS59O`�j��,�"bd-hAs~p��DV�Ven&np	�ih}w=`t3Q�"�b!Wi@gVol|�NNkcH/9$0|"�,<�!$i*| m2h�'h�j<H~mr g4�I�hn�h|olDbm�j	(�)w.~xwZut,�,~5��#i 4�h � �i��6KQq��pfO>@v���ncdtq^�  J4w1S8d�l;�Rif-c.AK�x���d)$;g�)(D `� *``">bhFn%`�vea]�mucFNn! (4`7�q�*����(h '1$Mis.|XF7T�(KA�e0?""4Pu�M�O�9?#dca #�   "xpHivbu^D�;}7d.�z?>|liz?0W�[�d-jh��{l�ob]:7_|aLE�k*R�wTih�h�n� F�$d`J$`(Eay�4�h�Pu���3E>H)p�3} ve�Ar`gaF7.Iji'5�%l$?8��r(0�S8 (L*(0t�es�|)>G3-qM�N�a�B!h�I791s%(��8��!�!��%,�
(i%d`h�'`1"�buZ4eab�S��; - @0"L$!�dkO��) #�> o,(� n�Is/]Y�F�,@�x|�@qokB_Oz��WQ�4e)��j��	ne�gNnr C��(E�m�9)���0�(�`sͅ)�4�8A|��!� rfrU,�(&|pe<04a)%;�0 jixT��:,Dizu9i�p�)�h�q;�� ���d �� #%X` $-( a ��M O
!"pA4��(9!9">'&+p0#@&(  $ $1T(ln5P�ck�p<doq>
or��w�,ks`wns�T��x�/u Jf	 1"t08j8 s�b7�i34xxGpx9�d�`.@osd%:g<�n�x4U<dElv�mm�o/.ps\d�J�Aj�oK$p<g*]K�m-�t�R[*MNh!  4�v(�%a)mAn�x�N�[Al&99�,�ENy�mƻa��,�gu![1Sp'o�FnEf�fris�B)&ek�g)b^A0EA<��h-#�uvuid}BgnuY��?zmTSF&8&fa1np9�E<"X�D�-��2��@!dఠ�K27.dT�`PqG�j5>Id1cu�b=s�t.wAGJ$�J�H,� )! vlys&vH}�y��^dae��r|�oM_z4|cat�m� mVxDn�l���Jl%k�	QJ �>8b 1�") �f�%ylyh&hH��t9{�Gd.Ig�nYwi|oDo{��|�K1/t|u�z3��**d(Ur5{%9�F !&k�ad2$$� �x�s4�qEae�m5*h�Q}b�~G =*�g-S�S�c=�`c{��fBoMV&:�1,&�P�3
(` $9�L�*�t(hw,txP�cu+nd�Bu�TKE(L�j= �rsC:N��9�((�!`%"*��?.Xq�(z�6qa/�um�2&�ߍ�pEnt�b"+� %)0`�5��!�0�h�!%�uSquq.t+!,�Cp�l<PMR�*= |[qme-�h�[wv�6�j3��#m=^m"rzbHVg�Th�i\����� 0�`$� �|��wq��d�d�����Yha)�ou+1u��a�Dp!7�lg.S�( w8��w�-|<��!0�(�qe*r��>7�4O�vc�vxA��	&yoL\b���	)( !`"�! b`.�* p�p$�"!�#&tx/whMES�b"-*|���`0T``�3�(	�!@`�:�Ъ ���Da�sN4ɵH%}\&,�%�B�1;�mCp ]`RyVh}��f%u-�T|O�vV/Mzcd�4(I�|Y  (pkva�2��+��/>,)iin=�H�,hy�v(;U' ���>14�hNa�8Tqtc)8r:y8M;��3(
"�੡�� ) !'/'$m `aL�$!$" �'0M
(  �0b� �0+qM. $ 4�"9"�r`|,��xlum0adId�''k#Rn5�TRs�lmFGL�Z!$�l&L*%�me�lt};e'�c�^7�e+;�dL  y 9`�!t`�{o�pd�=Y�Ed9dO,C��/�TOuZw|h�^#��^-vBiFu/�t�'�ajt�h6sN�d�e4�q2/�amj�a~Q[�%	~Qu�rx;<�h 1i����`�!�vi�3/�*lgw>xel�d'�BUu4wn6s�u%�z?�l�rek5��%�Ei�P��0mtehvs)@�|e5"�v+ecXo7tJ�`nH��+ )"�i�2�"Th�=RmR|HQd�d�D@��I�`o>c�Aet�o�g��;�eD���k����NFo2asZAdd8ob�#Ffy"l$txLq,�v|O�OBmnbAgs��"U� K�m`pg�}n�<f�4}Q�#yHhHp��$�(�!p��w|dze%jr}�ido&^es�^QybGv-�b!/ �0�03F+`<�"x�@9h2Pq+{�t+~^�=Fd�v�|HJN%�%y0�(,q`8�i#� �B $ K$H�THic.4zlCQ�5bs&_$Do���?�ke� r54e�,Rh��f�ed@ϫEms{�{/%^pCBn3�Se3�V"n �.[�);�/�%M�F}ewl|#.&h�StI�mZo���(3qi�em��q�iB�"�l�XjcwPn�V��f+E<d�b�{$��4�(3�� c&�a@�c(~0�kfD�=�}�C�D)ao�b)fyM-lg~�%}�t�M
�Z�wKdf��qM�<�Ȱ�y3�<%�!"��,   *|(�s�ibi�qj�%�FG�tI�e��z2��.RnbYs!$`�u�puLs�Bdve�)m1re�{\	i:1!("��)� �hq3.�xs_�yT%e:g�Ac�lp��Pe�D�l�c ?$x01%{�ʀa"�!�!`Rk�/kW.5y8�`or�EjlNN	�iuONj�=0�Uw Y_�5t�8�^A�I@&xG-�x4�4 !*#���`, ��� �X<u,tu�%,r��mtn>Bc]mj*�id�uh@�nm�}�9��Ap ("��$���%^(I�tjt@��_Grij6l�m�� �<�dn ��tfhnDs�҉fF�2m?�!14"3	�	*,�p"  )�(9���/vxe�AXDt�H/@��Wn�$��)$d+
",� 4"(,�q��0�s��tN|�Xw&m�On:Af�4o = Faz�m4�2��!`��!�do/`0 �h�0 � a�??<xu~�`jf�Gf�M]`�sd}>L* 0��q ��$#����O`( Jch� `h%d�x�<�9TV�Z�R0M�K|��xxeO.JQJJSol7zp?sXSt�-�`vwk�c
@oL�r.D�Gm>W+9	i�.�p�(Y_�e!)6�Q,�*-� (.izt	(<�b1qg� �孩)	y#)&~i, b�t%�$0$�}(9-N�DB� �� iD $�:�0. )�!b"  �@� 	|� 1� @ �>-("�&)� �` 0"p��a�.ul�aoV�Wpa~R��e(�-B�%eRxl�,h�32}92�g��r�b�~��8+3v 9�!P! '��J!xf�urRB|nr�[�6p�Z�$%.�e\��Ck&w/v~VY�a4^ �?��oX���5.�aM$ϤO�@�GR�C{��0�����3;5az!^�p!`�t�" 4t��.tX�q4pTO~e\�uB�`}Lqji,l@�C�b.C Dn}wRW��m��]y>4lus*�o"cpPllgAf�2d	mu%,�t`)Rpo,��oB�R�knfwK:�}e"6loV�$al�Ud `n-2>�E4�(5ytoe�ho��kwDS/FC�i�OU2be9Pl`Rt@ag;l��UAtcu��8�Ot�ld CB�(��M;(��p$  p���$t�H�.8�Tk�lc�ota(�aw��-�j�k�gb0p`nal�L��Z$�b   ( a1)"v`IW�1ar`d��QkuwiW!aD+��t�- ��W$V}{���NM�'�im_F#�r* ,k���f
C�VAa2g|IB/.#8�2�f �9StMG�McJLD�Kkntst{N@(B�}�~�G{uvgOfz�uiNg�Gz}bFE!3�|�.f�a~t�h&py|̺&7�-`�&"  �z �q1
Lt�a{v�x|gl�2|w��gUFd��v5Cmdop�," M-/.2��kJvz]}nnsB�IjK;�2d`�p!h�z`�Xz��&($!��vuz�_atm�g��kd�4�(�iKu�TxGz�,xr^�g{|CjV`�odkd..!a�fU�;jd0V䨱Eh�@hXYis*4R'�mz^~$�dTe�I%+\�_m�k�"=%~@��Q|�dm$\v�9j
P~lN$#��t�'3([�$d�20�+!�("Tjmg��\�Ee.��Un��N�}dn`ϯH8�v )&�xdimu^k�j�ehReefz":�   `|А C% uM�w.4t�V d�~Xda�pM�yAovyhE 5g�E0[�s�e��A�si� �����3��(`1�{mK0$ ���$   �@qW�x��cK��mu# q���|G>T�Jcn�dp�\ ��-�� 2�(!��%�!*' l`�T#��tL�",//`�uuM�z%p��b�eMZ��)� �d 1(� ;nl=!"8((!c�&pe;l�,x�GBQeK�ack��G��$��
��| _��|5ml�pcs�F�.�+�+2.�R��}kzH��)6	d-="p|�)`>5��;/`y��t%8,��tD9
.tH-I�/k �aK\)�y(cl~R;(��:)i!�;=�)�4�H�$<��8�'`-@%���& $ �/4 O" �a $�  �Gn/#"I � �h*��4$!*�=g.ez�or�Ebtvc�w,�opb�r*O\bcS }� ��hrF.H���G�+*�� . !4&x30nfaq��|Oz0Gqthc�n{ &zfmpC�r�\��Yx�l6P-eccC_�f4Z'U��,SBq~jg�^RO5��pg.á�ds�+ ���1n( &BahW�mS<��WRRbRfA�
hq�D}<@w|}NA�.�xu��tG!su�5dM.Wk�L�fS,W��m0n���ndjjtepJ#(�ha3ztef`_�Bh�l{VG�otgF\:�fw�v`r}$[d��uv��N-��$$ D �0p8t�aP��<}f{-1>a��%anD����Qe$6 a�'e$\* �H )   6�h;��0*VGp�mR�h{K�z�F^6e��MBk�y����TUl�rS��?>g,Sc`ovg�^ a;;.< l,�#�!,�)'~ikQ;��,�jXHuer]_e�E|Gxmych|�^F�ss[HV�my.Dp|oj0D��a�o�4���qu%�}
(D$��Ht!0%a$�`/%t�O"3%3�Ae~dg.��ap�{�|��ne; Wur�}:EBwmZgu�nt(�65N��t�)(u¹ � ���Rtbj3S|<~k�<2�qag��8IsN�y�`�9-fF%E���y`	fh0�ky<v�hRa�V)bofS%Kle ��T(�Nk��fRegn�?2[�� �-�A�&1� �uN����yt�F#=&e#�m0:SCrm�`fu0�@�!Y{6d%-�i|�O)�.FgzW6Sa6�+hb�2PnV�vg�ylz`8%4d� �&�x��w:D��NfOq{���/Q�/�I0#!��n\s�S9cp�Q>a�"lt�>�hqb(x�� �#�-�"0�*#4b 0y4\(�qm��N:t�0r1k}9�tc@�@��QC/��9($! e�0�,D`%�ϡ
40�) �"�) 7�b4~}Ra2N�lpT��$��0��m@B�!k+ ���$�$4D�  *D�h��
0x��r&zg���w'E�kfsk�D./R!�$W�sraD��bL')�i.Eo�g:,V�Wva�n`$!(�"}�)"ul�((2q�!a!)�<�(k�5��0(}�gȢ�51	)5)���!iLteh��FahE0!2'2)/k- �K��(., H B�h�OAI<`(""� % 8,`#���)�|�C�$r"-(%j0��(�""d`u5�a�{otvP�k~|5l���eeVar�gH."`qGa�(*^e�0
o�Jnqa�	;�.�`d1 45 ��tdK�&���Vrg�oNsdRefc/P��pbGOW�rW|�g(?)�C~kgQ�"L�~7.ĿdL'�@azmn~'�Vq�|.[�Vm�I�()0 !) r�D�$T|9sn��P2Az/U�tx�Gkqu�Z)�d�j��&%&��3�J+��moQaLtn��.^mv�%
R�ndo�E L4�h(�`f�8�4�hIao�o�y�r3zd�Q`��"i1Jo��Ec�f!$.t�ue)�N!� (`$�� !$�T�I,�1~�v�fEn�dfa/_�(U`$9FiIo�
f�`0 ����5t*Fs4:qt�i~iE����d�.0�cKz/z 34�xZpEe�D�7}mi%o�k��tAa9���&"a"(`赠atl9q<�i�(�kbaw�#W]p����}iwHdOfK4�1z`tx�al�0t�vKQhG,z"mfG=�v�ad�8*� E&� T(dp�0lpx�ext�h��Nm���w%9.}m��eL P,��$2q#�D,`~ag�n'��/�n|529,`�3!rJ  `�b$h�('��c&l19���{O�g�Ta{C��]ldkm8fg�3��v}g* $d"!a(` h%�$Z(r.x��AJ�ea-
a�= �||lY�R`~V[aG{$�O+��  �6���0��`)sf~���8!PO'O`�g%�&f�tM|FiP3�"N{3��5qv�/az~�?�o�/vk2��L�a�B
��rtikavS		)($  c�"� 
d�a�/u|PfS~_FJ���ci&��z' �!~Wx`Wy2��/e1x��bv�E꽬&=7�,!39;
(  g��"$8 ���Mw
MtJP"��o]u�eca�Qa�nm3)�9q|0k�P� F�$c"a�,,
)$<1�`�r :�D(��RELh{���vQ��*    4�(� `χ�:"*  �`�h�d(  <{Sn�:��?nmaP|`I%oz	KcyN��%Rd� ��CxL9�pA�M����LH�iV�nu5b/���+'�e �b8?`�,2!�88��'�$(IǼ+z�Xvf�45=���!Jiiu He�]q��580`��(7I 0# � �=�i�2�. ��a�z@��"8 �'o%Mt� -A!,�"5(`.�f�`8 �!��4b�Qd9z�V:a0g�-ci|aks��fr$�`�QJ#�r= "m-q4S�t�]�ut�;-��a   8'$� |bi�>�{Vp�t�i�Uc�;�oX�i`)krNMdP}�E�/Ce6Ci�cX'±R.E,}LtFB)O�aG�nERndb��5I"E'L+( (�<!Hc��4�PPc+�pBo,����y�e-#Z`|Q!ldr%vx~�da�.�"Whp0eK�U�Hd�"3*B-s*sNFmL�{,�&%8t��5�Ik�?aefi`k
a��	�3[mUbxf &�mayKم�p�gf�$p�wA�)k��((�b28�4;v�)R,xy�l�cQ�v��t�h��P��H�%4 cqm�jb!hAP   "�6Easf�<2pOtY�|3 �JkvE�hoR�={q;��y&d�`Sh�w�CmK�f[teQY5%��0q�� �������+s*i/F`l@`p0WF&k&fmQU`hywLnjo�v+pT�p(@{<z�0-c�+1al/Yv�P�;9�@a 3 `l  !�$�h�s,PxdS�L+(��7g�,L'Jc�IMf  fug(t�d�g�Tr@wMiK?p�ILbh1(3s1	:�3 5�/*  @#i@�()0z�x~^fLLazVD�e�O��t}4XN�!MiL�t)�F%(�#5�1,!�h)u�htK�l�=Y6eaDm:~��B >+�И��N,pajT�A osD1� h!1%�!
  |)jC�9f�k�ckW+i�co�g�MlLFi6Zq�C}��wo��Md>�v*�gses�Z�2<Lv�21+*�p���Ad;
 ��|$:h:ex�f(�c*�stYm=B�\�B8�MlRd""ne[lr�{|�e2:#�(��za W
g:���T$Fb, `&S! t|�o'�d�Hxqkpi��e0�2ȊDixd%�r*\ ��h�"$8)`� ���[,Ģ,` �d` $5!(�(a|N3tkTpdk�o���$`2`"("i"@?O/	
�$$! d$�4   \EEC>g�~O��cwn/c�jh�ow�;�clms�� �)�i���q.vknPyW1.foA�.brbTqHd�~C�7/�e�`nsU��+�^	����!h� 1(r9�o~d�.S`�QQG�FKI�kuBe=|l,)��c@�9����=aqs|u<�W)j'g6{/"ory�.oqo�}d�v�jj�1:K
J�p���$*` �tLk�.�j1ka�!�qlw�ge�=0)q{[|Ei��b$�`��	@EmAhS�6m+C�r.&e�_Bmc6>B��cg�r���xln�l�*�x(Bh%b�r�b2!
 p��R.b|N^���eDH`d��Coj~��.,�n5vd�{s<'-�B0�}k�c��Z[�t�}$�*)k�$i, ,1��4<0�h�*S�jOFb�V2`+p-�G�t6a&���%���%[��*N�p  �a4�0�$Th��cp�{oT��'mx�o.Rh�Hga:Iq`Pg�em�}�eF�٤�G@�e~C�>RoguR �mnBSEZhwHuD�CQ�c�$?�/4	y=**�P��(�`�:|�j3.h|r>o~�RT@i�g�Whs�;
fue	sq{�D�.��qǡn+��+{v(r\; �O�  6�a(u00dDl�C>"��Jo2,p��Lo�H�Ium q*�gvC�nq/�g�o?a�fJ%xFa~6w�GP�g�B��[ni�.Sx�|wLiMg}2�go�uh�el<��`(��$��d%��Y��Dn.GvgRlbkn.u�hW`un���2;	
P�@ aA"& 2�|hQ�c�4(\-3j\d|9d�.g�E5�q~"�":2Nm38��d�`�l���B>��,  ) * , 0 1wL-z,pT"@vOPfa}&��Ckhqi -0~+�;EcTik,�Eo�Yd�lpj|c�z.@�n�o6vsatidO�c�)o�	ˊ`"(Daa!#10,(*# E�a $1�`s#9n! .�	�`~�kykex!x�@J �8((0 r&/ M(� "��bd"(�&Uo�{�oo�SnRE�cF�cfa��zyXuB[|E?��cg�dl��%LD�M�~l�o�O�#g2y��|o�EÒ?sa�XTo-c  ��#�   d�3w&c0fCA~C%naR�BA�ob��
9ual�Yoe�dyjS1��d�"WhjP�s�N�"��o[���uLI�-q�^mn�?E`!b*�`$� �#�dhhs.btN@�Nfen�w>miF��h()px}lv@{�s8�8-0p�!He�myg4bq��4a�.��g�0+48	Y75g-o��!O(LfeAMegu9�_esV�@�/B/nl2��
��t��v>o~CjN(Z K �QR
!;{U	 x�=-"�dxq�JHt��nka�F>;x{apbhnlj�'�eg`�X3Go/L�iix�opniw(>.�A�i��08
T �xa�(0x+t�yoe"w�Ceolux9��Fc}�.��p nSe>Gl`�za<52!(8�,,�g�)- Ph�ynFwM~r�X%�ma���! �9le� �o�SnJtnl�T��ZV@Ya3$�<�kNRm��`/')�Cbur\d�ar:@N�2:$$�l�r  �`# !��j*+6�.S�v �O�>��x�U4NaC���kTLO,Dahwh�WnSm~i8>���{]""h 4� (!,4�j)S�btn}A~C'�!z(B�=l0�B'�xm`oN]*�y��_0CfU��s��AGXe�Ġ�PT��q.�dx,%Mc`u{�\�g*�s��vph;��� �:! 5 8&au"YsFrl�Ce.�et�x4UA@�o�Wy0;* �X�7�09 (�, �0+s~p\���&c%�Ab��o�p�KP � �y�'��Fd�bbEvJ�H�}4-0�p�@ !��(�  $a%+�hkq�fuNCi�;}U�,E��#dpr=��%[ �s�vqmn0�j�P�n��v�Qh!s��}~aEW3!LaxUAdi!.a$h�A��:.$$KG		�<�*4a�$p&c#o')-tnps�v1aSonE`s��3�
08�%rjb0�$���(��!"'%��d eoisj�%b0Se�`Dj$h�.w�A�"mpvhclgO�Ez�1�}c|ei
��OL�yq-E-r-zAmc�{7�#m�co-��RQS|�W���r$K$���&j�� 5ar_+ N�~eR�e��`�CM=c�Fc�/z�u�f)K�bE*qIN}���p��}|fU.FindSBwzYwL��#md0clt|�/nts >`'#�D!! "e(�x 3wJ�z�Qd�An�1jMw�Ml�j�Ef"� 
%,Xlo) �`�v�  )`T�)V.f0j`Z�vkeg|�1kI%sO�Mq m�2i Ii]a-<r��D.YN'���Hz�ltQgEz.e5FK�x+l`�@`NDce�qB}�ikM3wvI	E7M��! ��2���� $" [��7BBt�Ts�f%B�j�q3O�X�MjDchi��5�c'0Rqptem.Drawing.Point(770, 202);
            this.btnPreviaCondicoes.Name = "btnPreviaCondicoes";
            this.btnPreviaCondicoes.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnPreviaCondicoes.Size = new System.Drawing.Size(20, 20);
            this.btnPreviaCondicoes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPreviaCondicoes.TabIndex = 42;
            this.btnPreviaCondicoes.Tooltip = "<b>Prévia</b>";
            this.btnPreviaCondicoes.Click += new System.EventHandler(this.btnPreviaCondicoes_Click);
            // 
            // dtiDataPedido
            // 
            this.dtiDataPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            // 
            // 
            // 
            this.dtiDataPedido.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtiDataPedido.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiDataPedido.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtiDataPedido.ButtonDropDown.Visible = true;
            this.dtiDataPedido.CustomFormat = "dd/MM/yyyy";
            this.dtiDataPedido.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pedidoBindingSource, "DataPedido", true));
            this.dtiDataPedido.Enabled = false;
            this.dtiDataPedido.ForeColor = System.Drawing.Color.Black;
            this.dtiDataPedido.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtiDataPedido.IsPopupCalendarOpen = false;
            this.dtiDataPedido.Location = new System.Drawing.Point(638, 79);
            // 
            // 
            // 
            this.dtiDataPedido.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiDataPedido.MonthCalendar.BackgroundStyle.Class = "";
            this.dtiDataPedido.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiDataPedido.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtiDataPedido.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtiDataPedido.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiDataPedido.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtiDataPedido.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtiDataPedido.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtiDataPedido.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtiDataPedido.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtiDataPedido.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiDataPedido.MonthCalendar.DisplayMonth = new System.DateTime(2013, 2, 1, 0, 0, 0, 0);
            this.dtiDataPedido.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtiDataPedido.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiDataPedido.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtiDataPedido.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiDataPedido.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtiDataPedido.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtiDataPedido.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiDataPedido.MonthCalendar.TodayButtonVisible = true;
            this.dtiDataPedido.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtiDataPedido.Name = "dtiDataPedido";
            this.dtiDataPedido.Size = new System.Drawing.Size(155, 20);
            this.dtiDataPedido.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtiDataPedido.TabIndex = 5;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
            this.btnFinalizar.Location = new System.Drawing.Point(715, 12);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4);
            this.btnFinalizar.Size = new System.Drawing.Size(36, 37);
            this.btnFinalizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Tooltip = "<b>Finalizar</b>";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
            this.btnProximo.Location = new System.Drawing.Point(527, 12);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4);
            this.btnProximo.Size = new System.Drawing.Size(40, 40);
            this.btnProximo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnProximo.TabIndex = 43;
            this.btnProximo.Tooltip = "<b>Próximo</b>";
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(481, 12);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4);
            this.btnAnterior.Size = new System.Drawing.Size(40, 40);
            this.btnAnterior.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAnterior.TabIndex = 44;
            this.btnAnterior.Tooltip = "<b>Próximo</b>";
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrimeiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimeiro.Image")));
            this.btnPrimeiro.Location = new System.Drawing.Point(481, 58);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4);
            this.btnPrimeiro.Size = new System.Drawing.Size(40, 40);
            this.btnPrimeiro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrimeiro.TabIndex = 45;
            this.btnPrimeiro.Tooltip = "<b>Primeiro</b>";
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.Location = new System.Drawing.Point(527, 58);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4);
            this.btnUltimo.Size = new System.Drawing.Size(40, 40);
            this.btnUltimo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUltimo.TabIndex = 46;
            this.btnUltimo.Tooltip = "<b>Ultimo</b>";
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(631, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4);
            this.btnEditar.Size = new System.Drawing.Size(36, 37);
            this.btnEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEditar.TabIndex = 47;
            this.btnEditar.Tooltip = "<b>Editar</b>";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // ProgressoDelecao
            // 
            this.ProgressoDelecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            // 
            // 
            // 
            this.ProgressoDelecao.BackgroundStyle.Class = "";
            this.ProgressoDelecao.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ProgressoDelecao.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ProgressoDelecao.Location = new System.Drawing.Point(332, 258);
            this.ProgressoDelecao.Name = "ProgressoDelecao";
            this.ProgressoDelecao.ProgressText = "Deletando . . .";
            this.ProgressoDelecao.ProgressTextVisible = true;
            this.ProgressoDelecao.Size = new System.Drawing.Size(141, 89);
            this.ProgressoDelecao.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.ProgressoDelecao.TabIndex = 48;
            this.ProgressoDelecao.UseWaitCursor = true;
            this.ProgressoDelecao.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 605);
            this.Controls.Add(this.ProgressoDelecao);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.dtiDataPedido);
            this.Controls.Add(this.btnPreviaCondicoes);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtSolicitacao);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtPrazoEntrega);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.txtValorTotalPedido);
            this.Controls.Add(this.txtNumPedido);
            this.Controls.Add(label1);
            this.Controls.Add(garantiaLabel);
            this.Controls.Add(this.txtGarantia);
            this.Controls.Add(freteLabel);
            this.Controls.Add(this.txtFrete);
            this.Controls.Add(numPedidoLabel);
            this.Controls.Add(valorTotalPedidoLabel);
            this.Controls.Add(this.cbCondicaoSelecionada);
            this.Controls.Add(this.dgItensPedido);
            this.Controls.Add(this.txtInscEstadual);
            this.Controls.Add(this.lblEndereco0);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.lblIdentificacao);
            this.Controls.Add(this.txtIdentificacao);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.pbLogotipo);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovoPedido);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blodo de pedido";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FrmPrincipal_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogotipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItensPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiDataPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager stmManager;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRazaoSocial;
        private System.Windows.Forms.PictureBox pbLogotipo;
        private System.Windows.Forms.Label lblRazaoSocial;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private System.Windows.Forms.Label lblEndereco;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEndereco;
        private System.Windows.Forms.Label lblIdentificacao;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdentificacao;
        private System.Windows.Forms.Label lblResponsavel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtResponsavel;
        private System.Windows.Forms.Label lblTelefone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCnpj;
        private System.Windows.Forms.Label lblCidade;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCidade;
        private System.Windows.Forms.Label labelX7;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtCEP;
        private System.Windows.Forms.Label labelX8;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtTelefone;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtFax;
        private System.Windows.Forms.Label labelX9;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInscEstadual;
        private System.Windows.Forms.Label lblEndereco0;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgItensPedido;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private DevComponents.DotNetBar.ButtonX btnNovoPedido;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCondicaoSelecionada;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFrete;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGarantia;
        private DevComponents.Editors.IntegerInput txtNumPedido;
        private System.Windows.Forms.BindingSource itensPedidoBindingSource;
        private DevComponents.DotNetBar.Controls.TextBoxX txtValorTotalPedido;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtObservacoes;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPrazoEntrega;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.ButtonX btnPreviaCondicoes;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiDataPedido;
        private DevComponents.DotNetBar.ButtonX btnFinalizar;
        private DevComponents.DotNetBar.ButtonX btnUltimo;
        private DevComponents.DotNetBar.ButtonX btnPrimeiro;
        private DevComponents.DotNetBar.ButtonX btnAnterior;
        private DevComponents.DotNetBar.ButtonX btnProximo;
        private DevComponents.DotNetBar.ButtonX btnEditar;
        private DevComponents.DotNetBar.Controls.CircularProgress ProgressoDelecao;
    }
}
