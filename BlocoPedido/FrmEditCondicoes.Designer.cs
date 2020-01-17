namespace BlocoPedido
{
    partial class FrmEditCondicoes
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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label nrParcelasLabel;
            System.Windows.Forms.Label taxaJurosLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditCondicoes));
            this.condicoesPgtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.condicoesPgtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.condicoesPgtoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.nrParcelasTextBox = new System.Windows.Forms.TextBox();
            this.taxaJurosTextBox = new System.Windows.Forms.TextBox();
            codigoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            nrParcelasLabel = new System.Windows.Forms.Label();
            taxaJurosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.condicoesPgtoBindingNavigator)).BeginInit();
            this.condicoesPgtoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.condicoesPgtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            codigoLabel.ForeColor = System.Drawing.Color.Black;
            codigoLabel.Location = new System.Drawing.Point(-3, 25);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(48, 13);
            codigoLabel.TabIndex = 1;
            codigoLabel.Text = "Codigo:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            descricaoLabel.ForeColor = System.Drawing.Color.Black;
            descricaoLabel.Location = new System.Drawing.Point(-2, 66);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(59, 13);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Descricao:";
            // 
            // nrParcelasLabel
            // 
            nrParcelasLabel.AutoSize = true;
            nrParcelasLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            nrParcelasLabel.ForeColor = System.Drawing.Color.Black;
            nrParcelasLabel.Location = new System.Drawing.Point(354, 66);
            nrParcelasLabel.Name = "nrParcelasLabel";
            nrParcelasLabel.Size = new System.Drawing.Size(66, 13);
            nrParcelasLabel.TabIndex = 5;
            nrParcelasLabel.Text = "Nr Parcelas:";
            // 
            // taxaJurosLabel
            // 
            taxaJurosLabel.AutoSize = true;
            taxaJurosLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            taxaJurosLabel.ForeColor = System.Drawing.Color.Black;
            taxaJurosLabel.Location = new System.Drawing.Point(467, 66);
            taxaJurosLabel.Name = "taxaJurosLabel";
            taxaJurosLabel.Size = new System.Drawing.Size(62, 13);
            taxaJurosLabel.TabIndex = 7;
            taxaJurosLabel.Text = "Taxa Juros:";
            // 
            // condicoesPgtoBindingNavigator
            // 
            this.condicoesPgtoBindingNavigator.AddNewItem = null;
            this.condicoesPgtoBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.condicoesPgtoBindingNavigator.BindingSource = this.condicoesPgtoBindingSource;
            this.condicoesPgtoBindingNavigator.CountItem = null;
            this.condicoesPgtoBindingNavigator.DeleteItem = null;
            this.condicoesPgtoBindingNavigator.ForeColor = System.Drawing.Color.Black;
            this.condicoesPgtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.condicoesPgtoBindingNavigatorSaveItem});
            this.condicoesPgtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.condicoesPgtoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.condicoesPgtoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.condicoesPgtoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.condicoesPgtoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.condicoesPgtoBindingNavigator.Name = "condicoesPgtoBindingNavigator";
            this.condicoesPgtoBindingNavigator.PositionItem = null;
            this.condicoesPgtoBindingNavigator.Size = new System.Drawing.Size(570, 25);
            this.condicoesPgtoBindingNavigator.TabIndex = 0;
            this.condicoesPgtoBindingNavigator.Text = "bindingNavigator1";
            // 
            // condicoesPgtoBindingSource
            // 
            this.condicoesPgtoBindingSource.DataSource = typeof(BlocoPedido.Object.CondicaoPgto);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // condicoesPgtoBindingNavigatorSaveItem
            // 
            this.condicoesPgtoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.condicoesPgtoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("condicoesPgtoBindingNavigatorSaveItem.Image")));
            this.condicoesPgtoBindingNavigatorSaveItem.Name = "condicoesPgtoBindingNavigatorSaveItem";
            this.condicoesPgtoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.condicoesPgtoBindingNavigatorSaveItem.Text = "Save Data";
            this.condicoesPgtoBindingNavigatorSaveItem.Click += new System.EventHandler(this.condicoesPgtoBindingNavigatorSaveItem_Click);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.condicoesPgtoBindingSource, "Codigo", true));
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.ForeColor = System.Drawing.Color.Black;
            this.codigoTextBox.Location = new System.Drawing.Point(0, 41);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(57, 22);
            this.codigoTextBox.TabIndex = 2;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.condicoesPgtoBindingSource, "Descricao", true));
            this.descricaoTextBox.ForeColor = System.Drawing.Color.Black;
            this.descricaoTextBox.Location = new System.Drawing.Point(1, 82);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(350, 22);
            this.descricaoTextBox.TabIndex = 4;
            // 
            // nrParcelasTextBox
            // 
            this.nrParcelasTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.nrParcelasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.condicoesPgtoBindingSource, "NrParcelas", true));
            this.nrParcelasTextBox.ForeColor = System.Drawing.Color.Black;
            this.nrParcelasTextBox.Location = new System.Drawing.Point(357, 82);
            this.nrParcelasTextBox.Name = "nrParcelasTextBox";
            this.nrParcelasTextBox.Size = new System.Drawing.Size(100, 22);
            this.nrParcelasTextBox.TabIndex = 6;
            // 
            // taxaJurosTextBox
            // 
            this.taxaJurosTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.taxaJurosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.condicoesPgtoBindingSource, "TaxaJuros", true));
            this.taxaJurosTextBox.ForeColor = System.Drawing.Color.Black;
            this.taxaJurosTextBox.Location = new System.Drawing.Point(463, 82);
            this.taxaJurosTextBox.Name = "taxaJurosTextBox";
            this.taxaJurosTextBox.Size = new System.Drawing.Size(100, 22);
            this.taxaJurosTextBox.TabIndex = 8;
            // 
            // FrmEditCondicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 116);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(nrParcelasLabel);
            this.Controls.Add(this.nrParcelasTextBox);
            this.Controls.Add(taxaJurosLabel);
            this.Controls.Add(this.taxaJurosTextBox);
            this.Controls.Add(this.condicoesPgtoBindingNavigator);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditCondicoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MetroForm";
            ((System.ComponentModel.ISupportInitialize)(this.condicoesPgtoBindingNavigator)).EndInit();
            this.condicoesPgtoBindingNavigator.ResumeLayout(false);
            this.condicoesPgtoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.condicoesPgtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource condicoesPgtoBindingSource;
        private System.Windows.Forms.BindingNavigator condicoesPgtoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton condicoesPgtoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox nrParcelasTextBox;
        private System.Windows.Forms.TextBox taxaJurosTextBox;

    }
}