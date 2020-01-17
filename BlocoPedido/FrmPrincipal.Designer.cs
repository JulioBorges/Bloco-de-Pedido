using System.Collections.Generic;
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
            label1.Text = "Condi√ß√£o de pagamento:";
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
            label3.Text = "Observa√ß√µes:";
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
            label4.Text = "Solicita√ß√£o:";
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
            this.lblRazaoSocial.Text = "Raz√£o Social:";
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
            this.lblEndereco.Text = "Endere√ßo:";
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
            this.lblResponsavel.Text = "Respons√°vel:";
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
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.Da&0RbK ÷}s\¥@yQt!∆Âçt)kdZM`∞ Ã#)‡ §s(¯(-ì."ámˆ"nqBe`idÕb$x∆±m,‘€ ‹Ó⁄tjg8=!BπVÈ”2\c^Ì˝#¯d€ÌxÎw6?Øä¿C9h,"∞§ê" px)r<FIL·JjpWvxn¢Woh`,·| ©£.alsµ:	
°%± ( †@(ß!vii6,gß+ÙeZÛdlj$gŸIytCÊ~!B
#Siõvmm:TBÒ˜ÕNgvCÔ-O1fF§f+Ü&gkj Ônd%'(!{Ïeaë<f)MÖ¨<Ûh∏m@π|(êrqÛƒ((∂≠;©9:)à†)X8Nl)($¯Ùf )ª?!)8kAª-j&&`5   !h†s¨vk{µ.¯oFL+m‘hGD÷~cı‘À9q*HçnjîG‰OmCu{n}h˚‰=IPÂlSTh]÷o£-5kuu;X
°) "b&)!B•&hÌÁ/ko˘TEoSt·4i`o.OÁN¸*wO3Ó&lE ¯ÏkEaTx+g.7iÙK1‡V√#1˝;œ
"Å" ‡Í∞`†∞ÙH	˙n`Îjp,(PmLi@˝+_mm}FQhayy∞6 nmÏ€3T! fÑ2#"
ı^Ir(ewYÙÑnp`l‰S,&Ópl3;d$ÂGSW.”Pu‰[uy"≥â (d2psÄd∞` àe(*wç'›so—WU%lußµqº∑'∫=nù˜d¯6q%l(b÷q∂|N;ÿØZul/ia6-11â++Xj† +(#®°+rUc…_n`Ô	[LäW g‘·LÔNñ.bAnÈ•0Ñ$:z=B °6¢i N¢  †v i≤,fÊxg.sAŒ–XdoFirp6ÁYÃv!˝.Ù©5kq%çö†!"¢s#)&$ #ø#™$h !*0db0£ O.√~dIg˙am`ÁtªÂ<q˚[yÁz4Fä}Go=)=JO® ™«4!!1% "'ùb$F ,$ 0º 04⁄xÙIQs,z>n+≈HRaœ2]f‰cÈªM…pÙ¬LyD?DÔÌ÷?DA0WV⁄g≤Ïx¸	N…o*§! ÇC|(eÊªL	††\  h80(¥ëT„kv?ãˇ5A'K\aWOr+TfQuÊVD˝˜Cjt…ˇ¸«@nH$Itm∂tÔ^Dr†¶/dym :…
$((aä t!Çp*XﬁiS¶3œ^)Ñ√fAc·kGPIuµP'}ÔG˝cG„¥ßN!Ï∆≤5p"cg˙Î/PÂ^hrqF\eˆPkƒOnea"∂´ $Æ
 *(" %)tLMa&cÓfißv%’·Are$WI}w Êx¯W˛;My/WI`dj ¨‡5€
qaÀC"†""  `"-À‰ 2àd"1 *¢n-n"ÒT·lˆÔaaEuEÂÙqñ„¨ WXÑwÔ˘wB/xV*_$ÓO®)*)`%*!t "?ÆXïz¢†   1g§≠®`(pxq3.rM‰bÙc'ƒ˝,0pgr©$RÎeW@Âﬂ1_8Gùlw`˛i§ CqPso2f8ylaEd p•xu¿WÒ{‰„R4Ç``,ì™ò‡‰s∏tTÈ…3Nhu`~Ù˝¸Òa%§a4+ÀrOAÚ8tjPµyÙDk»	og¡¨o:H)EDagTe˚tÄ=†"K∑‡{‚/t·@D0´‘˙v!2„¿ %a (  `h!≥'q)znI`!Tu@`6aW“vÊFkLv@dHu÷OxoL≈maM…pµh3‹te^|madm$º)V˙id‡-dReruBfî>IØnn.;©
s@! @ô®0d†"qı<}Q.dÂcqxid¡$`B•î"ØinXASuÌtAÔ¸MI∆})näÓ-ÊtX·<h7ıπÇ  a$H †$à'¨'‡©H 4""qamx ≤Ñ∞+ -m3µÚm[˚QFÙaÙRy ‘Õ‘u|lÊ~HkgLÊéÕ√(†2*º"Qa!0n/%" i™ d!™m%0Hl(ﬂÏfeñSql}`JL!w◊FzÎdñÙıe9dBÔËOklgn>4·`!0ª#uÂ—UQFa_e5 &ƒ!`c‚!BrgÜ{H @'∞"§° ™ëaci÷+TmQc¥ijA~EixlÁZd=´$wLkhggxRveuonœ–ÎA%b∆‡Ó5"¥&bπ·–-	bPl@ZU“` †`$    "|hU3¨gU·∂hlal@„Ê5rÈd2mc—eÑBn~¡mnë-Ó(fgmÂ°	"Ç.a7arc@„´"atdCzi`^mIu’e8rJmyC∫|wmn${ïí† Al†î{ (L∞t1;3ºd`WGx-cao,ab}Â≤#äR"w4\Ôxt^gPWolwÂgéFÌÏ0,$Ω6{1#ùÅ,8j!Ë8lÑl‡`Oo!N)¨(à $h `(≤tmhI*Œ!8·vÚk‡dI}∞v)‘<ÊO¯Èov-]OÖj(»J=", `†‡bè:È[B!∞ d. ∏1` 6dt1˚Œ&‡<L⁄D|‰k’c%`)r~Èes@C¯ı“∏¬)=q,oåÅÒ|iTSO4P|y¨=ma yA#V H>T©|".•!$ !î*Ñ50‡dqd@≈rﬂ…E2SÈ\‘ÊdÒ pN{RsaD(= ^Ú“=8ô®‡¥  |2$4 2d‰0bQ´tV)Ds«b¸6
t]eØ$/Œ|¸f¿k•·!†xçëÛb'
C0 àx§c+0C ti-s(ÊeWp}.F`t¯#R¡TP8e”¥gt`ÚO}SkDU	j≤M]ñpı,ÙSMn.z6º…f&?0lq@cbÎgDylÛBoÑl{rV#≤3h‡0£•"Bâ*  ts·3ØˆiÈVWWÍ Á_`˘rMvƒ‚aˆ‘g0NË}<‹in,Yyaef„iehΩ="4Yè~UjÄ∫õ™`-w0( 4†c12dx:˜ÍfKj◊b≈ŒD-nGr+‡v™dPxd1√aÃ5Mg∫dG% ]rGc%/zt‰£e‡W0°‚VÍeW/zuƒøKÔlˇ≈L;è∏ 6"y∏∞¥Û` ©(/_à-)*¢`$#§p$¯$¥/+oˆ≠lk⁄TÏt!iLuphVRËlÚi2TP|Ú«ø˙K˙®’lhè`b  J!*""Xh£-¥h$"$5h! „$8SV»A3.b@D} XO˘e.\¶E.Oxit÷Ì%.ƒ1qo0A~lÌmﬁoTÈe–|kfu∆˝ƒkÈeA "Xn'¢t{vel˜;k ¢( ‡!    ïv1v`wpÂLÚiaÂ@dEt;dÁ1fFopec‰®º )N2<ÖJ1Î`®, ‡d!$  ‰`deb—1÷¸P4f~fq>˝meëæN≈hl·äÖ`µ,6Ì∞8&,ã<†8$ †tÄ<iÇË¯-Û^Ó„|Kfı\\qAÎIWRhdCy.˜D ⁄BKXOdelﬁ†efg–}5Xox=tAdÇaπ"b!Ã@Fc|‰'xEgP-¶d”>ie°≥5ZfR< dÙt8bhıh1;*RelÔgê`1ÃEkK'gyri„7uMyRoxC≠`ov.NeA‰≈ßLz4b=	Üñ›lÍAﬁ∑uuÏ&ù?_ H4*±†$t∞ôÄ‰i-.fcJˇpê/phCnlb6iÌy%f\qzu`Î*œmdq}gÏi4g§&†É˚@lN*‘OwH^äIedN:enFÀcÈ],\DBOnAÔL]yn"ã%
à((,05∞! !aÙ*	s¶` o†lDÕ|¢BDÈ/bk‡“˘a?îlYf9BhTmÓ"PeqÂ_vdÿ%•BtŒqÁ´EÇH‚†± Ä(,1?0*c  2§p#( †´˚¶m}/"cVe'…{œ`/jo|√“#u¢qeà :8ÑÈ0" ¢(ä+mÑ	S$ pa4Ö6ÒxÈ#*Ë|á˛Xu|˘-mÓdÈæLıPj`nEÂ5ax·fg‘êU†"@˛%ˇ3∆yi<jb‰%$‚""@!*0+ Ùä	W.yLÒèÛX%§CÙmBÈvd·/oa´gÍceÍUv`9G2Ì≈∞2ulËc$`d¿p‡-Ym$ oÂs‚be˝	(∑0 9"e>,÷jdÚf%TÑÍYîFMif¿ig+Ôg”Êº2CÈû@_ˇÈL›èÊCiaL≈a`†M0n+s¿Úg·^>EshtE≠ØF@evJˇË◊”eÑnsÿ'LÀ`obyviil◊fÛbÎU<To;AtokÎLÌÓK≈d.x8∞¢: d`80,1'+2D
!Ë@ k @Ñ¢$--2l„tA~ÂX¿eE ≠p B|dí†ßÇ ¸ú* ä£!d,p  ∂#§q@U„*n3$MoE$O≠kŒ0Æ“aWoQ‚˘≤ Y A(C %ncE2aqIz'KdÔr8OÚl-K2Js(:È˚7hàn(/}v`ih1°0ä¨h1lAnt£=s˙…teè71%è- jjm.r{*|ÄÊ‰w„i2p8´∫(	#9$ 8d$0 "X∞attyp†gc|mgvEÚg‚k4L÷+_ag(-S 8hYKÀh≈%& jËvoætÔLor>
luJ¯Sπ(<x! q("`§Ù˘i3=HEF(L{ªhl,zv9]4`#gÏ$Èlfv¶_+u˘(ΩXnv]J=UzÂ!Úv{O Ø¢%nsE•s
2 $Ä8†b‡(!<hcw^hc†C†¿ficjVlÒA~πo28h~E9!¡h¸%^.DÚ¨vzFwˇoan∏àu! ê£46; ( °"$™`Q°Ç†VAs¶\*FMLdcpqÛc#Ü.)7 , †}C˛Eo®UxÂaot"[áFF$â  (‡˝%$iuT8ËÒ~h€¨gbUnR√ÔgnWπZ!|`ŒAd"í<R}'o*D≤AwÎJ2Ó{i•Å„R(†atWZ! ˜,'‚d<»‡ r®Ÿ7§¸ æÓ§z%)(+VeÁ≈]dgP ;"9{	ƒ%#ba†Ä;#S&!x+ﬂ.|d@D.¥!cLio±&F-»V ‡‚E.(E¯29û`® sÄ"0f=>-!É%6®ôA`îª–®°o+sbKozµduWBı}@ciO6aÂ 	*0 ârd00", ˇ4é(Æ!b!%8"eB,dË)r°cbsiJiq·˘$|v+Io}! ‚‰yyxlcõIuMs˛"`jîΩ5JPÀcË+#O	púh§ °$£§±d"\HiS∏„"Ckn\GbmeRdÓt!`+oYte‘v`ÒmmE4	)Ya4Ìtæ3k¨nj'6>FˇÓGÛΩbSêˇ}`og√vn+7t∆a{ñi¿fóO"	$ ),·"(‡§`2ZiF‚Í£Îg<Â)r`ØóÔ|ecy/oI`)*EbWg‡Ed$=$a‰ˇd∫	°	,  0 L7e¶•tx…Q,vQ#Gf>Î%Kﬂg.©‡8œUq``'ÂhaRv|ÌÂ¨u¢S}wVÏÍvtÓTr7c,¬t≤eA.^egƒx8ƒg+B6Qm7+A° º-H(¶®!xfç#.rb#Õ.`kcıoC}mo[i•n5„ˆ.œ.'Wgo{ - RqbPÃ≈.dÛ"w#f-Nmorcrh}Ák;¢'(`V4F° *ehÌs*@b√gnhkohFPÓHΩ·kÌ g`5$FÔ!}Ypt5n`‘m`bé`¿õ.b#eaœ,b 16$)†b‡` a6L-Sdh©w@Lhg
Ù-÷<QucâËeq<…'Ë˛€|cn◊2 tr…:,fgC{jmd„P„A§oMfoÔ}@·iqHZ97))j0#¢ @G!Í+‡†™TL©≤&GfqˇÔÃ#`¢3˜Me„5}d—"`ÜQµÏı»UqGã4ü ±ƒê(* C¢ "ÿ4dÄ§+ 7sH9n°0BjŒ[iÂ`èãGx•'g≠nahcÇÀ˜h‡5Ao- ú!Ã˝" G—∑dÂoBrWi{,ÿ/`*§46‡9Ä2ãπM
`$°©2¢$@pij|û#g„melÃaiwëÂ@ab;Ælâä^!hGA=¬bn‚vdy)!csÂÓuCËOHiΩëãì_¬ &  ° # `!ÙŒyi/rbSv^aEKd´F$¨Ì@oÔO·‰"4Ë˙5P9Ädﬂ”·{°sdÀ-,Äp∞Ôog‡ˆmJ%È%5%/ bê!˝	J 1! Ëja`;õÏê†`‡s˛z#·m~d…(acCmå≈“+mÓd%¨r<yEU ~#Ìe~*~e±^?qv@3.A?5éÔ¿KÊt*®FUtÓ≈tÊerb$mhÂ¨arqNEh„"kCd≤SFfdZjd^q‡9,àl !†»!!` "5( t™ætWÒgÒãcKBe-{ylÍ◊%c&‘a†ÃGlMp¶}`1ø:é
:∞0 12T @pE(wé·gE^l‰‡˚Cl}mtzkoÓ/…+lÇa^4◊ÌQnBèNØ0àÀmXpeOÆ~<+*mÄ≥h‡ ˆ )°uÚjs\g„”njgl‚ a?e-•c¿n"a‰1åTh§3Â)l…z'•xBxaC±d":4(^mtLP¸uÂiÎD6Å,\àaoºmDRj‰hhAwCcCŒlmcÊ&wob·dg£’ETMn‚/¯„nao'gd!kÑ#Ñ"$ ¢6hx!0 ¶.	h1Ï*.`m‚1h 0¶10xkÄpeﬂÌUé §'∏˘"0¥$ ‚!v-*d$ ¢!&d¯ §  ‡\®.C¨xÏıF2ntM†»√·S#h>Rç´“!#$ELæƒV`U`ˆÁnolz.‚ceÕl+‚å.]~Ê%±9(xÂh25/yæ"=∫a~T©®(¨¢xÒsö25˚ ®;≈§(¨™Iæv®(Acô‰gπ™1u8â!);DÄ¢±%"Ñp ô#e/%‡l≥‡AhÅ0∞6   ` ß£9OÃ)` 0°&.!! Ê}4ç*ƒa†ö'§©p†É°X»Õqld$vb/vm o2g`r(A$e'sd,bt,Zf v[pwkdm ;ãä`$ 9#)4c!3 ˙k*txWDpTt$!G/fem0.c-;Juv\·≈tü†eA"C'Mam.eft dTq0SCÚ"bBgp pw{ru>⁄=wyrm?L`1)44∏! `( )rt>˝N˛Kt.YAt)fhlÌMNFKI0d`w2Úv~Ó<.wMbsn3ÆNMp˛;<j{rGh?d¨Fı)¸<Æl&VjsP&@GE)>c,˝$ifgUor{{4*Nbu7e&Æˇt=m);q 3 Ñ8(†t(,u
AsOı{|T˚A]u*e*1FLÕi`5Ê1nS59O`®j¸§,™"bd-hAs~p ‰DV◊Ven&np	’ih}w=`t3QÁ"“b!Wi@gVol|¸NNkcH/9$0|"¨,<†!$i*| m2h∫'h˙j<H~mr g4˘I∑hnÈh|olDbm∑j	(Ë)w.~xwZut,º,~5Ø®#i 4®h ® Íi©∞6KQq¢ºpfO>@vÑûÃncdtq^Ø  J4w1S8dÌl;‰Rif-c.AK¯xî∏äd)$;g )(D `∞ *``">bhFn%`Œvea]ÖmucFNn! (4`7Ôπq√*¥‡Ä≤(h '1$Mis.|XF7T’(KAîe0?""4Pu˙MÙO≤9?#dca #±   "xpHivbu^D√;}7d.ñz?>|liz?0W›[‰d-jh†ˇ{lÜob]:7_|aLEök*RÂwTih·hØn∫ F®$d`J$`(EayØ4™hûPu†Âá3E>H)p¯3} veÔAr`gaF7.Iji'5§%l$?8˚Èr(0®S8 (L*(0t‡es®|)>G3-qMàN„®aÕB!h‡I791s%(¥Ä8∞ô!÷!≤ø%,É
(i%d`h°'`1"œbuZ4eab·S©ç; - @0"L$!°dkO§») #•> o,(ä nËIs/]Y‰F·,@˛x|·@qokB_Oz®íWQÛ4e)¶‰jÂÚ	ne≈gNnr CÛÌ(Em∞9)âÊ‘0´(±`sÕÖ)ò4µ8A|âŒ!Ì rfrU,®(&|pe<04a)%;≠0 jixTª®:,Dizu9i≥pö)®h©q;†® §º†d ¡¥ #%X` $-( a ÜÄM O
!"pA4‡‚(9!9">'&+p0#@&(  $ $1T(ln5PckÚp<doq>
or˛¯w ,ks`wns≈TƒÔx∞/u Jf	 1"t08j8 sÒb7íi34xxGpx9Ôd¨`.@osd%:g<Ûnæx4U<dElv“mmÒo/.ps\dπJäAjÔoK$p<g*]K±m-Ût…R[*MNh!  4àv(°%a)mAnÚxﬁN·[Al&99√,‡ENyˆm∆ªa¿‡,˚gu![1Sp'oºFnEfØfrisèB)&ek˙g)b^A0EA<à÷h-#Êuvuid}BgnuY¸Û?zmTSF&8&fa1np9„E<"X‡Dß-£Û2®Ò@!d‡∞††K27.dTï`PqG‰j5>Id1cuÔb=s∆t.wAGJ$‡J≤H,© )! vlys&vH}äyíÒ^dae‰˚r|€oM_z4|catÒmÆ mVxDnŒlË¯°Jl%kì	QJ §>8b 1©") †fÍ%ylyh&hHÂ¯t9{¨Gd.Ig‡nYwi|oDo{µà|ËK1/t|u„°z3Ïˆ**d(Ur5{%9ïF !&k°ad2$$‡ ∂xÈs4πqEaeÎm5*hÏQ}bù~G =*«g-SÙS·c=æ`c{…˛fBoMV&:˘1,&¥P•3
(` $9±LÜ*†t(hw,txP˚cu+ndÈBuÏTKE(Lıj= ˆrsC:N∞∞9®((†!`%"*—„?.Xq≈(z‚6qa/¬umË∞2&–ﬂç·pEnt»b"+Œ %)0`Å5∞¡!·0h´!%öuSquq.t+!,˜CpÚl<PMRÀ*= |[qme-‡h‰[wv©6£j3∂◊#m=^m"rzbHVgÛThÉi\ôâ‚˜‰ 0à`$© ®|‡ÁwqÏ“dÚd∏Ù©·óYha)°ou+1uó•a˛Dp!7˝lg.SÌ( w8ùwΩ-|<ò¢!0 (†qe*r◊±>7·4OÊvcÔvxAæ“	&yoL\bπÉ∏	)( !`"ê! b`.ì* päp$¿"!Ê#&tx/whMESÈb"-*|ÑÇ‰`0T``Æ3Î(	à!@`Æ:‚–™ Åß∏DaÈsN4…µH%}\&,Ö%ÆBÒ1;êmCp ]`RyVh}¨›f%u-ÂøT|O˛vV/Mzcd¸4(IÓ|Y  (pkvaÔØ2˝¸+π°/>,)iin=´Hä,hy‡v(;U' ©©π>14¨hNaå8Tqtc)8r:y8M;¨È3(
"∞‡©°¨§ ) !'/'$m `aL∆$!$" Â'0M
(  Ù0bÏ ∞0+qM. $ 4¯"9"¶r`|,∫¯xlum0adId˚''k#Rn5¶TRsÅlmFGLÒZ!$πl&L*%ÎmeŒlt};e'√c‚^7≤e+;†dL  y 9`∞!t`…{o¥pdä=Y‡Ed9dO,C•·/˝TOuZw|hÂ^#èˆ^-vBiFu/®t˛'Ãajt‘h6sNœdûe4“q2/Áamjäa~Q[‡%	~Qu≈rx;<™h 1iíàîÅ`§!viÎ3/≈*lgw>xel·d'¶BUu4wn6s§u%¸z?“l÷rek5§®%·Ei˛PØÁ0mtehvs)@Õ|e5"…v+ecXo7tJÿ`nH€ä+ )"¢i¶2Ú¢"ThÛ=RmR|HQdŸdæD@Ù±I„`o>cÎAet™o¿g•€;ÁºeD®œÒk˘ùæ”NFo2asZAdd8ob†#Ffy"l$txLq,°v|O§OBmnbAgsœ”"Uå Kım`pg…}nä<fë4}Qœ#yHhHp©‡$†(¢!pÉ¡w|dze%jr}Ùido&^esÙ^QybGv-¡b!/ ‰0¥03F+`<†"x†@9h2Pq+{æt+~^◊=Fdπvæ|HJN%®%y0ƒ(,q`8çi#¢ ÇB $ K$HÑTHic.4zlCQº5bs&_$DoÓÙ†?¯ke˜ r54eÌ,Rh˛Ìf÷ed@œ´Ems{˝{/%^pCBn3°Se3âV"n È.[Õ);˘/¥%MÜF}ewl|#.&hˆStIÿmZoŒÁÌ(3qi”emõıq≥iB‡"‚l‰XjcwPn¨VÃ¯f+E<d„Øb {$µÌ4π(3ÅÒê c&Öa@åc(~0·kfD¯=Œ}ÏC‡D)aoøb)fyM-lg~%}ÍtM
‰ZÛwKdfÆ„qM”<í»∞„y3è<%Ç!"Ñ¿,   *|(Ès¯ibiÄqjÙ%°FGÁtIÆeÇÏz2ƒÔ.RnbYs!$`„uæpuLsÕBdveÔ)m1reÁ{\	i:1!("ÄÄ)‰ Êhq3.xs_ÙyT%e:gÆAcÓlpÙ÷PeÛDæl¨c ?$x01%{â Äa"Å!—!`RkÅ/kW.5y8Ö`orÚEjlNN	ßiuONj™=0ÊUw Y_„5t˝8˛^A¶I@&xG-ˆx4¯4 !*#ÉÉÏ`, π§∏ ¢X<u,tu‘%,rÂÂmtn>Bc]mj*˜idŒuh@¡nm¶}¢9àÈAp ("§´$†∞†%^(I⁄tjt@ÒÎ_Grij6l‚mÂ ø<Ôdn ˜˜tfhnDs·“âfFÓ2m?·!14"3	Ÿ	*,¬p"  )∞(9®Ë”/vxeÉAXDtÔH/@…ÔWn‡$ˆ¶)$d+
",‰ 4"(,∞qÇö0Ës¥ËtN|≠Xw&mÕOn:Af”4o = Faz≥m4¶2¥≤!`Ä†!®do/`0 äh†0 † a‡??<xu~©`jfﬁGf°M]`∆sd}>L* 0°¢q ∏¨$#˛ò∞£O`( Jch∞ `h%d¯xÛ<≤9TV¡ZÔR0M∏K|ÂxxeO.JQJJSol7zp?sXSt¢-¶`vwk˛c
@oLør.D˙Gm>W+9	iØ.°pÜ(Y_÷e!)6µQ,È*-º (.izt	(<®b1qg° ¥Â≠©)	y#)&~i, b˛t%≠$0$ }(9-N®DBÄ ¿® iD $ß:©0. )∞!b"  ¢@˜ 	|Ä 1• @ †>-("ß&)¡ ‡` 0"pÌaÚ.ulﬂaoV›Wpa~Rï·e(©-BØ%eRxlÀ,hÛ32}92’g¯‰rÌbÂ~Ä‰8+3v 9î!P! '≥˜J!xfïurRB|nr–[‰6pÌZ˘$%.¿e\¶ÜCk&w/v~VY˙a4^ ©?Ú¬oX∞Ôﬁ5.∞aM$œ§O≈@ÇGRÓC{≥ 0˙ÛÓ3;5az!^∫p!`°t°" 4t˘˚.tX§q4pTO~e\∞uBÈ`}Lqji,l@˘CÌb.C Dn}wRW˜Òm©Ü]y>4lus*ˆo"cpPllgAfÜ2d	mu%,†t`)Rpo,Õ¡oB€R“knfwK:¡}e"6loV◊$alêUd `n-2>˙E4¯(5ytoeÓhoÒçkwDS/FCÙiôOU2be9Pl`Rt@ag;lòËUAtcuÎÔ8æOt®ld CB‚(±˘M;(†êp$  p≤†§$t™Hª.8TkÙlcÊota(Úaw°÷-—jªkÏgb0p`nal˚LÆÕZ$ƒb   ( a1)"v`IWÈ1ar`dÔÚQkuwiW!aD+ÿ‰t¥- ÔıW$V}{‡‰≈NMì'–im_F#Ær* ,k„≤ÔÎ≤f
CÈVAa2g|IB/.#8∂2µf í9StMG≤McJLDØKkntst{N@(B˝}Ó~∑G{uvgOfzÌuiNg¶Gz}bFE!3ﬂ|ˆ.fˇa~tŒh&py|Ã∫&7•-`„å&"  Ëz ˛q1
Ltãa{vÜx|glÔ2|w∑˘gUFdÎ¶Ìév5Cmdop–," M-/.2°∂kJvz]}nnsB¸IjK;ç2d`·p!h†z`ÌXz¯Ï&($!Á‡vuzÆ_atmëg–ﬁkd‰4Ω(∆iKu√TxGzæ,xr^ıg{|CjV`Âodkd..!a–fU•;jd0V‰®±Eh»@hXYis*4R'˙mz^~$ÉdTeƒI%+\ˇ_m§kÕ"=%~@˜°Q|›dm$\vÒ¥9j
P~lN$#Ñ∏tê'3([≠$d†20†+!§("TjmgÆ‘\ÙEe.ã˙Un⁄NÛ}dn`œØH8Õv )&•xdimu^k∞jﬁehReefz":Á   `|–ê C% uMàw.4t‚V dÌ~XdaÏpM§yAovyhE 5gÎE0[˚s–eÌÀAË£siÓ õˇ˛Ö®3Û(`1¯{mK0$ ††í$   Ù@qW˜xÙîcK≤úmu# qﬂÏ·|G>TœJcn‰dpÉ\ £©-û® 2°(!†¯%∏!*' l`˙T#Ä•tL¡",//`ÙuuM“z%pÊ÷bÁeMZçÇ)· ¶d 1( ;nl=!"8((!cï&pe;lÙ,x∏GBQeK∂ackØìG√„$≥¶
ΩÙ| _ÒÁ|5ml–pcsÅF¡.√+˙+2.∆RÌ”}kzH§¨)6	d-="p|˘)`>5Øπ;/`y¸ t%8,‡‡ªtD9
.tH-IÌ/k ∞aK\)†y(cl~R;(™Ë:)i!Î;=ç)†4†H§$<§¿8†'`-@%°¢Ä& $ Ë¥/4 O" ‘a $¡  „Gn/#"I ¸ ¥h*∞´4$!*„=g.ez¥or“EbtvcÁw,àopb•r*O\bcS }® ∞ÂhrF.H‘Ó‡®G‡+*å¢ . !4&x30nfaqˆ∞|Oz0Gqthc≠n{ &zfmpCÁr¨\®’Yx≈l6P-eccC_Ãf4Z'Uƒ“,SBq~jg¬^RO5∑Èpg.√°ÁdsÌ+ Ç1n( &BahWëmS<¥ÙWRRbRfAµ
hqÌD}<@w|}NAˇ.Ïxu¨ˇtG!su∏5dM.WkŒLŒfS,WÔ˙m0n¯§ÌndjjtepJ#(äha3ztef`_ßBh¸l{VG√otgF\:«fw‚v`r}$[d¶¶uvº≈N-ãß$$ D ¨0p8tÏaPØ÷<}f{-1>a·ˇ%anDæ‡Á¿Qe$6 a˝'e$\* †H )   6®h;˚¨0*VGp´mR˛h{KÂzèF^6e¢≠MBkåy”ŸÙŸTUlºrSÌÛ?>g,Sc`ovgÅ^ a;;.< l,‡#‚!,∏)'~ikQ;´∂,»jXHuer]_eÊE|Gxmych|á^F´ss[HVËmy.Dp|oj0DÚ˛a±oÕ4®à±qu%¸}
(D$†°Ht!0%a$ﬁ`/%t‘O"3%3∂Ae~dg.´„apÈ{˛|ø†ne; Wurˆ}:EBwmZguÂnt(î65N§ªt®)(u¬π Ñ ‡í™Rtbj3S|<~kˇ<2÷qag•≤8IsNÙyÏ`Ó9-fF%EçÙµy`	fh0Ùky<v˙hRa˜V)bofS%Kle ™ T(ÙNkÚÏfRegnÏ?2[Øã ê-•A†&1‚† ÅuN•≥å•yt¡F#=&e#∑m0:SCrmÏ`fu0£@∑!Y{6d%-”i|ÏO)˚.FgzW6Sa6è+hbÂ2PnVıvg´ylz`8%4d© †&•xÅÈw:D∏‘NfOq{∑˘É/QÛ/◊I0#!¸Ñn\s†S9cpÂQ>a"lt¬>‡hqb(xñÌ ∂#Ì-ö"0Ü*#4b 0y4\(‚qmòıN:tÂ0r1k}9ÛÆtc@ç@ÙØQC/Ä≤9($! e†0∞,D`%ﬂœ°
40∏) ®"‡) 7Áb4~}Ra2N¿lpT◊Á$òÍ°0∏®m@B®!k+ åãÚ$‚$4D¡  *DÌh„Ú
0x‰›r&zgŒ¸w'E≠kfsk√D./R!≠$WçsraD˛‘bL')Øi.Eo¨g:,V‚WvaÎn`$!(∑"}à)"ulÌ((2q≠!a!)®<à(kÊ5£®0(}Ùg»¢¢51	)5)àÂ¯!iLteh®îFahE0!2'2)/k- ˚KæÄ(., H B∞häOAI<`(""¶ % 8,`#ø™≤)|ÏC™$r"-(%j0†‰(•""d`u5†aÀ{otvPﬁk~|5l§◊ÂeeVar˚gH."`qGaç(*^e¯0
o˙Jnqa•	;≠.Ä`d1 45 ®ÖtdK’&î¯≤Vrg≤oNsdRefc/P÷‰pbGOW‰rW|˝g(?)∆C~kgQı"Lı~7.ƒødL'Ä@azmn~'‚Vq¿|.[°Vm∫Iâ()0 !) r∆D•$T|9snÁí’P2Az/UÎtxÖGkqu√Z)‰d¨jˇÚ&%&Óı3äJ+∫moQaLtnÛ”.^mvÊ%
R√ndoÍE L4¯h(µ`fà8‹4°hIao¡o≈yÊr3zdÙQ`Øî"i1JoêˆEcÔf!$.t≤ue)≥N!å (`$∞∏ !$àTËI,˛1~”v‚fEnìdfa/_ÒÇ(U`$9FiIoø
fÎê`0 §¢∏¶5t*Fs4:qt˙i~iEØ‹Ú∆dÓÑ.0ÑcKz/z 34õxZpEeÑD·7}mi%o˛k˚¿tAa9ã£Ë&"a"(`Ëµ†atl9q<ãi≥(’kbawÔö#W]pÃÔ˙¥}iwHdOfK4¡1z`txÈalÒ0t±vKQhG,z"mfG=¨v⁄ad÷8*¶ E&Ä T(dpË0lpx˘ext√h°…Nmäı”w%9.}m†ÂeL P,ÂÛ$2q#ÙD,`~ag†n'Ô/…n|529,`ë3!rJ  `¢b$hÙ('™…c&l19∏¯¡{Oüg◊Ta{CÑ…]ldkm8fg§3Äˆv}g* $d"!a(` h%ê$Z(r.xø˝AJôea-
a˜= ∫||lY≈R`~V[aG{$ÎO+°™  È6ß˘‡0®ﬁ`)sf~¸œ–8!PO'O`“g%ı&f∂tM|FiP3Ω"N{3¥≈5qv†/az~ ?“oı/vk2ÓÏL“a∫B
»ÂrtikavS		)($  c¶"° 
dˇaÛ/u|PfS~_FJ¥Ú·ci&ì˘z' ˆ!~Wx`Wy2‘Ô/e1x˚çbv”EÍΩ¨&=7º,!39;
(  g¨—"$8 ‡‡º‡Mw
MtJP"¡Òo]u“eca∆Qa€nm3)û9q|0k¥P† F∫$c"aœ,,
)$<1¢`ër :ºD(∏µRELh{ÈÙÂvQØ€*    4∑(î `œá‡:"*  ∞`¨h§d(  <{Sn‡:ˆí?nmaP|`I%oz	KcyN¯˙%Rd‹ £¯CxL9£pAñM˙„ÊˆLHiVÈnu5b/Äí¨+'Ùe Ãb8?`È,2!88Ø¨'¡$(I«º+zÈXvfπ45=È•Ç!Jiiu He™]qà¯580`˚°(7I 0# ¶ Å=†i†2˝. ÄÈaz@§¶"8 Ë'o%Mt† -A!,‡"5(`.áfÂö`8 ‡!‡‡4bÆQd9zÎV:a0g™-ci|aksﬁ˛fr$æ`ÆQJ#ër= "m-q4SÎt¬]ﬁut¿;-ü†a   8'$Â |biÛ>‘{Vp¶t·i˝Uc¡;êoX‡i`)krNMdP}¯E™/Ce6CiˆcX'¬±R.E,}LtFB)O≠aGÚnERndbÂæπ5I"E'L+( (‡<!Hcãò4¥PPc+Ì®pBo,È„˘ˆy°e-#Z`|Q!ldr%vx~¡daê.ı"Whp0eKÓU©Hd…"3*B-s*sNFmLË{,Ì®&%8t¢¸5¸Ik˚?aefi`k
a¸∂	©3[mUbxf &ÈmayKŸÖ¡p°gfÑ$p¢wAÆ)käÜ((¢b28·4;v¨)R,xyÿl‘cQÿvÂÍt¶hƒÙP¢§H‘%4 cqmÛëjb!hAP   "¢6Easf–<2pOtYÌ|3  JkvEÎhoRî={q;Æ£y&d`ShÓw¿CmKáf[teQY5%†Æ0q´à ¥˝†π¢˛¯+s*i/F`l@`p0WF&k&fmQU`hywLnjo÷v+pT≠p(@{<zÎ0-cÍ+1al/Yv‡PÂ;9®@a 3 `l  !∏$îhÎs,PxdSÁL+(¡∂7gø,L'JcºIMf  fug(tíd·g∂Tr@wMiK?p˘ILbh1(3s1	:æ3 5»/*  @#i@∞()0zºx~^fLLazVDÓe™O’Ìt}4XNÂ!MiL t)©F%(†#5Æ1,!ƒh)uˆhtK˜l…=Y6eaDm:~ËÌB >+£–ò‘€N,pajTËA osD1Ë h!1%£!
  |)jC∑9f…kÏckW+iÄco˜g¯MlLFi6Zq∫C}øÄwoÑ∑Md>◊v*ƒgses§ZÉ2<LvÈ21+*Âp∑·ÁAd;
 ·|$:h:exïf(Èc*ıstYm=BË\©B8˙MlRd""ne[lr˘{|Ìe2:#ˇ(ø…za W
g:•πΩT$Fb, `&S! t|©o'∏dÏHxqkpi„Èe0©2»äDixd%Ër*\ †‡h†"$8)`≤ £ØÁ[,ƒ¢,` Êd` $5!(á(a|N3tkTpdkˆo©°±$`2`"("i"@?O/	
â$$! d$§4   \EEC>gÙ~OØ˜cwn/cÌjhÊow≥;…clmsß™ ˝)Ûi˚˝q.vknPyW1.foA“.brbTqHd¨~Cæ7/ùe√`nsU¥Ô+Ω^	≤≤Éà!hÄ 1(r9Ëo~d÷.S`æQQGÈFKIÅkuBe=|l,)ÂÊc@˝9ˇı˝¿=aqs|u<·W)j'g6{/"oryó.oqo¿}d˜vÍjjÌ1:K
J‰p¨≥†$*` ∞tLkÛ.Î∑j1kaî!Êqlw§ge¢=0)q{[|EiÃ÷b$˜`˛Â¨	@EmAhSÂ6m+C¡r.&e¶_Bmc6>BÁˆcgør∞ˇƒxlnÀl˜*ãx(Bh%b¿r¢b2!
 p¿ÌR.b|N^Ô»—eDH`dØúCoj~È‡.,®n5vdì{s<'-ÆB0¡}kècÉòZ[‚t∏}$Å*)kÆ$i, ,1¢∫4<0ºhÔ≤*S¿jOFbÔV2`+p-ÏGÌ≠t6a&Î¸Ó%˚æ–%[†˛*N±p  •a4“0°$ThÕ™cpÌ{oT°“'mx≤o.Rh‚Hga:Iq`Pg«em–}¶eF‘Ÿ§¢G@˝e~CÂí>RoguR √mnBSEZhwHuDÖCQ˛c¸$?‚/4	y=**®PÄ¢(§`£:|Ëj3.h|r>o~ÎRT@i‰gÔWhs∞;
fue	sq{‡Dç.çÚq«°n+á≤+{v(r\; õOÂ  6¶a(u00dDlÔC>"Ó›Jo2,pÏÏπLoéH∞Ium q*¡gvC˝nq/ÆgŒo?aÛfJ%xFa~6wÊGPŒgÚB‡Ú[ni™.Sx˙|wLiMg}2”goÙuh¿el<ô†`(çÿ$§˘d%ËÌY¨¬Dn.GvgRlbkn.u÷hW`un†õ‘2;	
P»@ aA"& 2 |hQÒc˜4(\-3j\d|9dœ.gØE5Ñq~"ü":2Nm38·Ìdâ`ˇlØ™¨B>åÆ,  ) * , 0 1wL-z,pT"@vOPfa}&™ÏCkhqi -0~+ˇ;EcTik,ÊEo»YdÂlpj|cªz.@˙nºo6vsatidOÕc»)o·	Àä`"(Daa!#10,(*# EÖa $1·`s#9n! .Ø	‚`~âkykex!x™@J ®8((0 r&/ M(º "°£bd"(†&Uo˘{éoo¶SnREËcFºcfaÛ¯zyXuB[|E?Ü”cg‰dlŒ»%LD≈MÌ~lˆoíO”#g2yË¡|oÓE√í?saÛXTo-c  á¢#ä   d…3w&c0fCA~C%naRÆBA´obæá
9ual°Yoe¸dyjS1˜ëd≥"WhjPÎs‡NØ"Ï—o[«Â›uLI›-qÙá^mnÂ?E`!b*ä`$‡ †#¢dhhs.btN@·NfenÒw>miF˛°h()px}lv@{∫s8∞8-0p†!Heàmyg4bqªÁ4aÛ.˚ËΩgÊ0+48	Y75g-oƒˆ!O(LfeAMegu9ÿ_esV’@†/B/nl2è¢
≈„tÈìÓv>o~CjN(Z K ≈QR
!;{U	 x∫=-"ÇdxqÛJHt˛ΩnkaÆF>;x{apbhnljº'“eg`◊X3Go/LÚiix√opniw(>.≠Añi´ç08
T †xa†(0x+tÁyoe"w¶Ceolux9ÚÓFc}Â.ª¶p nSe>Gl`·za<52!(8Å,,¢g∆)- Ph‚ynFwM~r˜X%”ma»«! ˜9leª Öo˙SnJtnl„Tß¬ZV@Ya3$÷<kNRm„·`/')“Cbur\dîar:@NÔ2:$$ãl§r  ∞`# !ƒ¸j*+6Ù.SÆv ËOÊ>–·xÌåU4NaC¢ö…kTLO,DahwhÙWnSm~i8>∞≥∏{]""h 4¥ (!,4j)S°btn}A~C'Ã!z(Bå=l0†B'ˆxm`oN]*§yåƒ_0CfUÄ·sÓÂAGXe±ƒ†“PT˘¸q.’dx,%Mc`u{ô\Ég*’s‰Ívph;Ωπ§ â:! 5 8&au"YsFrl‹Ce.ÂetÂx4UA@…o·Wy0;* íX‡7‡09 (¢, ¥0+s~p\ÊÁÊ&c%≈Abœ’oœpKP ≠ ¢y⁄'£ÏFdœbbEvJµH≥}4-0æpæ@ !†¶(∏  $a%+¥hkqºfuNCi„;}U˚,EúË#dpr=ÄÆ%[ ◊svqmn0ÂjÊP±n‡Ï°v·Qh!sà‚}~aEW3!LaxUAdi!.a$h°AÇ†:.$$KG		ò<§*4a∫$p&c#o')-tnps˜v1aSonE`sÔ¸3ﬁ
08®%rjb0™$†∂Ç(àÂ!"'%¿Ë¢d eoisj‚%b0Se„`Dj$hÛ.wÚAÎ"mpvhclgOÓEz≠1€}c|ei
∑©OL…yq-E-r-zAmcÌ{7ø#m«co-ë¨RQS|ﬁWˇÔ›r$K$†¸¢&j∂ì 5ar_+ N◊~eR≠eÜ«`±CM=cÆFc£/zÁuœf)K·bE*qIN}Ù¢˝p⁄≈}|fU.FindSBwzYwL·∆#md0clt|œ/nts >`'#°D!! "e(‡x 3wJ’zÜQd·An·1jMw˘Ml‚jºEf"õ 
%,Xlo) ê`êv‚  )`T£)V.f0j`Z˜vkeg|Ê1kI%sOŸMq m©2i Ii]a-<r¿ÈÆD.YN'Á˚µHz‰ltQgEz.e5FKàx+l`‚@`NDceqB}ÊikM3wvI	E7M†©! ˚è2ìÒº† $" [®‡7BBtÂTsŸf%B‰j‰q3OÌXÆMjDchi˜‚®5Óc'0Rqptem.Drawing.Point(770, 202);
            this.btnPreviaCondicoes.Name = "btnPreviaCondicoes";
            this.btnPreviaCondicoes.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnPreviaCondicoes.Size = new System.Drawing.Size(20, 20);
            this.btnPreviaCondicoes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPreviaCondicoes.TabIndex = 42;
            this.btnPreviaCondicoes.Tooltip = "<b>Pr√©via</b>";
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
            this.btnProximo.Tooltip = "<b>Pr√≥ximo</b>";
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
            this.btnAnterior.Tooltip = "<b>Pr√≥ximo</b>";
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
