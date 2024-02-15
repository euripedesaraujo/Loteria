namespace Loteria
{
    partial class frmSortear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSortear));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageMegaSena = new MetroFramework.Controls.MetroTabPage();
            this.groupBoxMegaSena = new System.Windows.Forms.GroupBox();
            this.metroLinkMegaSenaResultado = new MetroFramework.Controls.MetroLink();
            this.lblMegaApostas = new MetroFramework.Controls.MetroLabel();
            this.comBoBoxMegaAposta = new MetroFramework.Controls.MetroComboBox();
            this.TexBoxMegaSenaAposta = new MetroFramework.Controls.MetroTextBox();
            this.metroLinkMegaSenaCopiar = new MetroFramework.Controls.MetroLink();
            this.btnMegaSenaSortear = new MetroFramework.Controls.MetroButton();
            this.metroTabPageLotoFacil = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLinkLotoFacilResultado = new MetroFramework.Controls.MetroLink();
            this.metroLabelLotoFacil = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxLotoFacil = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxLotoFacil = new MetroFramework.Controls.MetroTextBox();
            this.metroLinkLotoFacil = new MetroFramework.Controls.MetroLink();
            this.metroButtonLotoFacil = new MetroFramework.Controls.MetroButton();
            this.btnSair = new MetroFramework.Controls.MetroButton();
            this.groupBoxRodape = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPageMegaSena.SuspendLayout();
            this.groupBoxMegaSena.SuspendLayout();
            this.metroTabPageLotoFacil.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPageMegaSena);
            this.metroTabControl1.Controls.Add(this.metroTabPageLotoFacil);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(491, 346);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPageMegaSena
            // 
            this.metroTabPageMegaSena.Controls.Add(this.groupBoxMegaSena);
            this.metroTabPageMegaSena.HorizontalScrollbarBarColor = true;
            this.metroTabPageMegaSena.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageMegaSena.HorizontalScrollbarSize = 10;
            this.metroTabPageMegaSena.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageMegaSena.Name = "metroTabPageMegaSena";
            this.metroTabPageMegaSena.Size = new System.Drawing.Size(483, 304);
            this.metroTabPageMegaSena.TabIndex = 0;
            this.metroTabPageMegaSena.Text = "Mega-Sena";
            this.metroTabPageMegaSena.VerticalScrollbarBarColor = true;
            this.metroTabPageMegaSena.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageMegaSena.VerticalScrollbarSize = 10;
            // 
            // groupBoxMegaSena
            // 
            this.groupBoxMegaSena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMegaSena.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMegaSena.Controls.Add(this.metroLinkMegaSenaResultado);
            this.groupBoxMegaSena.Controls.Add(this.lblMegaApostas);
            this.groupBoxMegaSena.Controls.Add(this.comBoBoxMegaAposta);
            this.groupBoxMegaSena.Controls.Add(this.TexBoxMegaSenaAposta);
            this.groupBoxMegaSena.Controls.Add(this.metroLinkMegaSenaCopiar);
            this.groupBoxMegaSena.Controls.Add(this.btnMegaSenaSortear);
            this.groupBoxMegaSena.Location = new System.Drawing.Point(3, 19);
            this.groupBoxMegaSena.Name = "groupBoxMegaSena";
            this.groupBoxMegaSena.Size = new System.Drawing.Size(477, 282);
            this.groupBoxMegaSena.TabIndex = 7;
            this.groupBoxMegaSena.TabStop = false;
            // 
            // metroLinkMegaSenaResultado
            // 
            this.metroLinkMegaSenaResultado.Location = new System.Drawing.Point(12, 236);
            this.metroLinkMegaSenaResultado.Name = "metroLinkMegaSenaResultado";
            this.metroLinkMegaSenaResultado.Size = new System.Drawing.Size(155, 23);
            this.metroLinkMegaSenaResultado.TabIndex = 7;
            this.metroLinkMegaSenaResultado.Text = "Resultado da Mega-Sena";
            this.metroLinkMegaSenaResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkMegaSenaResultado.UseSelectable = true;
            this.metroLinkMegaSenaResultado.Click += new System.EventHandler(this.metroLinkMegaSenaResultado_Click);
            // 
            // lblMegaApostas
            // 
            this.lblMegaApostas.AutoSize = true;
            this.lblMegaApostas.Location = new System.Drawing.Point(6, 27);
            this.lblMegaApostas.Name = "lblMegaApostas";
            this.lblMegaApostas.Size = new System.Drawing.Size(226, 19);
            this.lblMegaApostas.TabIndex = 2;
            this.lblMegaApostas.Text = "Quatidade de números para aposta: ";
            // 
            // comBoBoxMegaAposta
            // 
            this.comBoBoxMegaAposta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comBoBoxMegaAposta.FormattingEnabled = true;
            this.comBoBoxMegaAposta.ItemHeight = 23;
            this.comBoBoxMegaAposta.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comBoBoxMegaAposta.Location = new System.Drawing.Point(12, 61);
            this.comBoBoxMegaAposta.Name = "comBoBoxMegaAposta";
            this.comBoBoxMegaAposta.Size = new System.Drawing.Size(75, 29);
            this.comBoBoxMegaAposta.TabIndex = 3;
            this.comBoBoxMegaAposta.UseSelectable = true;
            // 
            // TexBoxMegaSenaAposta
            // 
            this.TexBoxMegaSenaAposta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TexBoxMegaSenaAposta.CustomButton.Image = null;
            this.TexBoxMegaSenaAposta.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.TexBoxMegaSenaAposta.CustomButton.Name = "";
            this.TexBoxMegaSenaAposta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TexBoxMegaSenaAposta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TexBoxMegaSenaAposta.CustomButton.TabIndex = 1;
            this.TexBoxMegaSenaAposta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TexBoxMegaSenaAposta.CustomButton.UseSelectable = true;
            this.TexBoxMegaSenaAposta.CustomButton.Visible = false;
            this.TexBoxMegaSenaAposta.Enabled = false;
            this.TexBoxMegaSenaAposta.Lines = new string[0];
            this.TexBoxMegaSenaAposta.Location = new System.Drawing.Point(12, 179);
            this.TexBoxMegaSenaAposta.MaxLength = 32767;
            this.TexBoxMegaSenaAposta.Name = "TexBoxMegaSenaAposta";
            this.TexBoxMegaSenaAposta.PasswordChar = '\0';
            this.TexBoxMegaSenaAposta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TexBoxMegaSenaAposta.SelectedText = "";
            this.TexBoxMegaSenaAposta.SelectionLength = 0;
            this.TexBoxMegaSenaAposta.SelectionStart = 0;
            this.TexBoxMegaSenaAposta.ShortcutsEnabled = true;
            this.TexBoxMegaSenaAposta.Size = new System.Drawing.Size(459, 23);
            this.TexBoxMegaSenaAposta.TabIndex = 4;
            this.TexBoxMegaSenaAposta.UseSelectable = true;
            this.TexBoxMegaSenaAposta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TexBoxMegaSenaAposta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLinkMegaSenaCopiar
            // 
            this.metroLinkMegaSenaCopiar.BackColor = System.Drawing.Color.Transparent;
            this.metroLinkMegaSenaCopiar.BackgroundImage = global::Loteria.Properties.Resources.copiar;
            this.metroLinkMegaSenaCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLinkMegaSenaCopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkMegaSenaCopiar.Location = new System.Drawing.Point(9, 144);
            this.metroLinkMegaSenaCopiar.Name = "metroLinkMegaSenaCopiar";
            this.metroLinkMegaSenaCopiar.Size = new System.Drawing.Size(31, 29);
            this.metroLinkMegaSenaCopiar.TabIndex = 6;
            this.metroLinkMegaSenaCopiar.UseSelectable = true;
            this.metroLinkMegaSenaCopiar.Click += new System.EventHandler(this.metroLinkMegaSenaCopiar_Click);
            // 
            // btnMegaSenaSortear
            // 
            this.btnMegaSenaSortear.Location = new System.Drawing.Point(12, 110);
            this.btnMegaSenaSortear.Name = "btnMegaSenaSortear";
            this.btnMegaSenaSortear.Size = new System.Drawing.Size(75, 23);
            this.btnMegaSenaSortear.TabIndex = 5;
            this.btnMegaSenaSortear.Text = "Sortear";
            this.btnMegaSenaSortear.UseSelectable = true;
            this.btnMegaSenaSortear.Click += new System.EventHandler(this.btnMegaSenaSortear_Click);
            // 
            // metroTabPageLotoFacil
            // 
            this.metroTabPageLotoFacil.Controls.Add(this.groupBox1);
            this.metroTabPageLotoFacil.HorizontalScrollbarBarColor = true;
            this.metroTabPageLotoFacil.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageLotoFacil.HorizontalScrollbarSize = 10;
            this.metroTabPageLotoFacil.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageLotoFacil.Name = "metroTabPageLotoFacil";
            this.metroTabPageLotoFacil.Size = new System.Drawing.Size(483, 304);
            this.metroTabPageLotoFacil.TabIndex = 1;
            this.metroTabPageLotoFacil.Text = "Loto Fácil";
            this.metroTabPageLotoFacil.VerticalScrollbarBarColor = true;
            this.metroTabPageLotoFacil.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageLotoFacil.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.metroLinkLotoFacilResultado);
            this.groupBox1.Controls.Add(this.metroLabelLotoFacil);
            this.groupBox1.Controls.Add(this.metroComboBoxLotoFacil);
            this.groupBox1.Controls.Add(this.metroTextBoxLotoFacil);
            this.groupBox1.Controls.Add(this.metroLinkLotoFacil);
            this.groupBox1.Controls.Add(this.metroButtonLotoFacil);
            this.groupBox1.Location = new System.Drawing.Point(3, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 282);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // metroLinkLotoFacilResultado
            // 
            this.metroLinkLotoFacilResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLinkLotoFacilResultado.Location = new System.Drawing.Point(12, 236);
            this.metroLinkLotoFacilResultado.Name = "metroLinkLotoFacilResultado";
            this.metroLinkLotoFacilResultado.Size = new System.Drawing.Size(155, 23);
            this.metroLinkLotoFacilResultado.TabIndex = 7;
            this.metroLinkLotoFacilResultado.Text = "Resultado da Loto Fácil";
            this.metroLinkLotoFacilResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkLotoFacilResultado.UseSelectable = true;
            this.metroLinkLotoFacilResultado.Click += new System.EventHandler(this.metroLinkLotoFacilResultado_Click);
            // 
            // metroLabelLotoFacil
            // 
            this.metroLabelLotoFacil.AutoSize = true;
            this.metroLabelLotoFacil.Location = new System.Drawing.Point(6, 27);
            this.metroLabelLotoFacil.Name = "metroLabelLotoFacil";
            this.metroLabelLotoFacil.Size = new System.Drawing.Size(226, 19);
            this.metroLabelLotoFacil.TabIndex = 2;
            this.metroLabelLotoFacil.Text = "Quatidade de números para aposta: ";
            // 
            // metroComboBoxLotoFacil
            // 
            this.metroComboBoxLotoFacil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.metroComboBoxLotoFacil.FormattingEnabled = true;
            this.metroComboBoxLotoFacil.ItemHeight = 23;
            this.metroComboBoxLotoFacil.Items.AddRange(new object[] {
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.metroComboBoxLotoFacil.Location = new System.Drawing.Point(12, 61);
            this.metroComboBoxLotoFacil.Name = "metroComboBoxLotoFacil";
            this.metroComboBoxLotoFacil.Size = new System.Drawing.Size(75, 29);
            this.metroComboBoxLotoFacil.TabIndex = 3;
            this.metroComboBoxLotoFacil.UseSelectable = true;
            // 
            // metroTextBoxLotoFacil
            // 
            this.metroTextBoxLotoFacil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxLotoFacil.CustomButton.Image = null;
            this.metroTextBoxLotoFacil.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.metroTextBoxLotoFacil.CustomButton.Name = "";
            this.metroTextBoxLotoFacil.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxLotoFacil.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxLotoFacil.CustomButton.TabIndex = 1;
            this.metroTextBoxLotoFacil.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxLotoFacil.CustomButton.UseSelectable = true;
            this.metroTextBoxLotoFacil.CustomButton.Visible = false;
            this.metroTextBoxLotoFacil.Enabled = false;
            this.metroTextBoxLotoFacil.Lines = new string[0];
            this.metroTextBoxLotoFacil.Location = new System.Drawing.Point(12, 179);
            this.metroTextBoxLotoFacil.MaxLength = 32767;
            this.metroTextBoxLotoFacil.Name = "metroTextBoxLotoFacil";
            this.metroTextBoxLotoFacil.PasswordChar = '\0';
            this.metroTextBoxLotoFacil.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLotoFacil.SelectedText = "";
            this.metroTextBoxLotoFacil.SelectionLength = 0;
            this.metroTextBoxLotoFacil.SelectionStart = 0;
            this.metroTextBoxLotoFacil.ShortcutsEnabled = true;
            this.metroTextBoxLotoFacil.Size = new System.Drawing.Size(459, 23);
            this.metroTextBoxLotoFacil.TabIndex = 4;
            this.metroTextBoxLotoFacil.UseSelectable = true;
            this.metroTextBoxLotoFacil.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLotoFacil.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLinkLotoFacil
            // 
            this.metroLinkLotoFacil.BackColor = System.Drawing.Color.Transparent;
            this.metroLinkLotoFacil.BackgroundImage = global::Loteria.Properties.Resources.copiar;
            this.metroLinkLotoFacil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLinkLotoFacil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkLotoFacil.Location = new System.Drawing.Point(9, 144);
            this.metroLinkLotoFacil.Name = "metroLinkLotoFacil";
            this.metroLinkLotoFacil.Size = new System.Drawing.Size(31, 29);
            this.metroLinkLotoFacil.TabIndex = 6;
            this.metroLinkLotoFacil.UseSelectable = true;
            this.metroLinkLotoFacil.Click += new System.EventHandler(this.metroLinkLotoFacil_Click);
            // 
            // metroButtonLotoFacil
            // 
            this.metroButtonLotoFacil.Location = new System.Drawing.Point(12, 110);
            this.metroButtonLotoFacil.Name = "metroButtonLotoFacil";
            this.metroButtonLotoFacil.Size = new System.Drawing.Size(75, 23);
            this.metroButtonLotoFacil.TabIndex = 5;
            this.metroButtonLotoFacil.Text = "Sortear";
            this.metroButtonLotoFacil.UseSelectable = true;
            this.metroButtonLotoFacil.Click += new System.EventHandler(this.metroButtonLotoFacil_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(396, 19);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseSelectable = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBoxRodape
            // 
            this.groupBoxRodape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRodape.Controls.Add(this.metroLabel1);
            this.groupBoxRodape.Controls.Add(this.btnSair);
            this.groupBoxRodape.Location = new System.Drawing.Point(30, 408);
            this.groupBoxRodape.Name = "groupBoxRodape";
            this.groupBoxRodape.Size = new System.Drawing.Size(477, 53);
            this.groupBoxRodape.TabIndex = 7;
            this.groupBoxRodape.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(309, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Desenvolvido por - Euripedes Barsanulfo de Araujo";
            // 
            // frmSortear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 481);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.groupBoxRodape);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSortear";
            this.Resizable = false;
            this.Text = "Loteria - Mega Sena - Loto Fácil";
            this.Shown += new System.EventHandler(this.frmSortear_Shown);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPageMegaSena.ResumeLayout(false);
            this.groupBoxMegaSena.ResumeLayout(false);
            this.groupBoxMegaSena.PerformLayout();
            this.metroTabPageLotoFacil.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRodape.ResumeLayout(false);
            this.groupBoxRodape.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPageMegaSena;
        private MetroFramework.Controls.MetroTabPage metroTabPageLotoFacil;
        private MetroFramework.Controls.MetroComboBox comBoBoxMegaAposta;
        private MetroFramework.Controls.MetroLabel lblMegaApostas;
        private MetroFramework.Controls.MetroButton btnSair;
        private MetroFramework.Controls.MetroTextBox TexBoxMegaSenaAposta;
        private MetroFramework.Controls.MetroButton btnMegaSenaSortear;
        private MetroFramework.Controls.MetroLink metroLinkMegaSenaCopiar;
        private System.Windows.Forms.GroupBox groupBoxRodape;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBoxMegaSena;
        private MetroFramework.Controls.MetroLink metroLinkMegaSenaResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLink metroLinkLotoFacilResultado;
        private MetroFramework.Controls.MetroLabel metroLabelLotoFacil;
        private MetroFramework.Controls.MetroComboBox metroComboBoxLotoFacil;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLotoFacil;
        private MetroFramework.Controls.MetroLink metroLinkLotoFacil;
        private MetroFramework.Controls.MetroButton metroButtonLotoFacil;
    }
}