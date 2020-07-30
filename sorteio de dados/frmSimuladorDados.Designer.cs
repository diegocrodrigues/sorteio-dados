namespace sorteio_de_dados
{
    partial class frmSimuladorDados
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimuladorDados));
            this.picDado = new System.Windows.Forms.PictureBox();
            this.lblNomeDado = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTituloValor = new System.Windows.Forms.Label();
            this.grpboxTipoDeDados = new System.Windows.Forms.GroupBox();
            this.radbtnD100 = new System.Windows.Forms.RadioButton();
            this.radbtnD10 = new System.Windows.Forms.RadioButton();
            this.radbtnD60 = new System.Windows.Forms.RadioButton();
            this.radbtnD8 = new System.Windows.Forms.RadioButton();
            this.radbtnD30 = new System.Windows.Forms.RadioButton();
            this.radbtnD6 = new System.Windows.Forms.RadioButton();
            this.radbtnD4 = new System.Windows.Forms.RadioButton();
            this.radbtnD24 = new System.Windows.Forms.RadioButton();
            this.radbtnD3 = new System.Windows.Forms.RadioButton();
            this.radbtnD10_dezena = new System.Windows.Forms.RadioButton();
            this.radbtnD12 = new System.Windows.Forms.RadioButton();
            this.radbtnD20 = new System.Windows.Forms.RadioButton();
            this.radbtnD16 = new System.Windows.Forms.RadioButton();
            this.lblTipoDeDados = new System.Windows.Forms.Label();
            this.lblJogando = new System.Windows.Forms.Label();
            this.lblDescricaoDado = new System.Windows.Forms.Label();
            this.lblDanoExtremo = new System.Windows.Forms.Label();
            this.lblProbabilidade = new System.Windows.Forms.Label();
            this.lblImagemIlustrativa = new System.Windows.Forms.Label();
            this.lblTituloProbabilidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDado)).BeginInit();
            this.grpboxTipoDeDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDado
            // 
            this.picDado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDado.Image = global::sorteio_de_dados.Properties.Resources.d6;
            this.picDado.Location = new System.Drawing.Point(269, 104);
            this.picDado.Name = "picDado";
            this.picDado.Size = new System.Drawing.Size(200, 188);
            this.picDado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDado.TabIndex = 0;
            this.picDado.TabStop = false;
            // 
            // lblNomeDado
            // 
            this.lblNomeDado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomeDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNomeDado.Location = new System.Drawing.Point(-2, 0);
            this.lblNomeDado.Name = "lblNomeDado";
            this.lblNomeDado.Size = new System.Drawing.Size(735, 36);
            this.lblNomeDado.TabIndex = 1;
            this.lblNomeDado.Text = "D6";
            this.lblNomeDado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnJogar.Location = new System.Drawing.Point(520, 317);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(178, 66);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "&Jogar Dado";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblResult.Location = new System.Drawing.Point(537, 151);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(144, 125);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloValor
            // 
            this.lblTituloValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloValor.Location = new System.Drawing.Point(559, 115);
            this.lblTituloValor.Name = "lblTituloValor";
            this.lblTituloValor.Size = new System.Drawing.Size(107, 36);
            this.lblTituloValor.TabIndex = 4;
            this.lblTituloValor.Text = "Valor:";
            this.lblTituloValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpboxTipoDeDados
            // 
            this.grpboxTipoDeDados.Controls.Add(this.radbtnD100);
            this.grpboxTipoDeDados.Controls.Add(this.radbtnD10);
            this.grpboxTipoDeDados.Controls.Add(this.radbtnD60);
            this.grpboxTipoDeDados.Controls.Add(this.radbtnD8);
            this.grpboxTipoDeDados.Controls.Add(this.radbtnD30);
            this.grpboxTipoDeDados.Controls.Add(this.radbtnD6);
            this.grpboxTipoDeDados.Controls.Add(this.radbtnD4);
            this.grpboxTipoDeDados.Controls.Add(this.radbtnD24);
            this.grpboxTipoDeDados.Controls.Add(this.radbtnD3);
            this.grpboxTipoDeDados.Controls.Add(this.radbtnD10_dezena);
            this.grpboxTipoDeDados.Controls.Add(this.radbtnD12);
            this.grpboxTipoDeDados.Controls.Add(this.radbtnD20);
            this.grpboxTipoDeDados.Controls.Add(this.radbtnD16);
            this.grpboxTipoDeDados.Location = new System.Drawing.Point(28, 77);
            this.grpboxTipoDeDados.Name = "grpboxTipoDeDados";
            this.grpboxTipoDeDados.Size = new System.Drawing.Size(200, 307);
            this.grpboxTipoDeDados.TabIndex = 5;
            this.grpboxTipoDeDados.TabStop = false;
            // 
            // radbtnD100
            // 
            this.radbtnD100.AutoSize = true;
            this.radbtnD100.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnD100.Location = new System.Drawing.Point(59, 261);
            this.radbtnD100.Name = "radbtnD100";
            this.radbtnD100.Size = new System.Drawing.Size(87, 33);
            this.radbtnD100.TabIndex = 9;
            this.radbtnD100.Text = "d100";
            this.radbtnD100.UseVisualStyleBackColor = true;
            this.radbtnD100.CheckedChanged += new System.EventHandler(this.radbtnD100_CheckedChanged);
            // 
            // radbtnD10
            // 
            this.radbtnD10.AutoSize = true;
            this.radbtnD10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnD10.Location = new System.Drawing.Point(6, 183);
            this.radbtnD10.Name = "radbtnD10";
            this.radbtnD10.Size = new System.Drawing.Size(74, 33);
            this.radbtnD10.TabIndex = 4;
            this.radbtnD10.Text = "d10";
            this.radbtnD10.UseVisualStyleBackColor = true;
            this.radbtnD10.CheckedChanged += new System.EventHandler(this.radbtnD10_CheckedChanged);
            // 
            // radbtnD60
            // 
            this.radbtnD60.AutoSize = true;
            this.radbtnD60.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnD60.Location = new System.Drawing.Point(120, 222);
            this.radbtnD60.Name = "radbtnD60";
            this.radbtnD60.Size = new System.Drawing.Size(74, 33);
            this.radbtnD60.TabIndex = 12;
            this.radbtnD60.Text = "d60";
            this.radbtnD60.UseVisualStyleBackColor = true;
            this.radbtnD60.CheckedChanged += new System.EventHandler(this.radbtnD60_CheckedChanged);
            // 
            // radbtnD8
            // 
            this.radbtnD8.AutoSize = true;
            this.radbtnD8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnD8.Location = new System.Drawing.Point(6, 144);
            this.radbtnD8.Name = "radbtnD8";
            this.radbtnD8.Size = new System.Drawing.Size(61, 33);
            this.radbtnD8.TabIndex = 3;
            this.radbtnD8.Text = "d8";
            this.radbtnD8.UseVisualStyleBackColor = true;
            this.radbtnD8.CheckedChanged += new System.EventHandler(this.radbtnD8_CheckedChanged);
            // 
            // radbtnD30
            // 
            this.radbtnD30.AutoSize = true;
            this.radbtnD30.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnD30.Location = new System.Drawing.Point(120, 183);
            this.radbtnD30.Name = "radbtnD30";
            this.radbtnD30.Size = new System.Drawing.Size(74, 33);
            this.radbtnD30.TabIndex = 11;
            this.radbtnD30.Text = "d30";
            this.radbtnD30.UseVisualStyleBackColor = true;
            this.radbtnD30.CheckedChanged += new System.EventHandler(this.radbtnD30_CheckedChanged);
            // 
            // radbtnD6
            // 
            this.radbtnD6.AutoSize = true;
            this.radbtnD6.Checked = true;
            this.radbtnD6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnD6.Location = new System.Drawing.Point(6, 105);
            this.radbtnD6.Name = "radbtnD6";
            this.radbtnD6.Size = new System.Drawing.Size(61, 33);
            this.radbtnD6.TabIndex = 2;
            this.radbtnD6.TabStop = true;
            this.radbtnD6.Text = "d6";
            this.radbtnD6.UseVisualStyleBackColor = true;
            this.radbtnD6.CheckedChanged += new System.EventHandler(this.radbtnD6_CheckedChanged);
            // 
            // radbtnD4
            // 
            this.radbtnD4.AutoSize = true;
            this.radbtnD4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnD4.Location = new System.Drawing.Point(6, 66);
            this.radbtnD4.Name = "radbtnD4";
            this.radbtnD4.Size = new System.Drawing.Size(61, 33);
            this.radbtnD4.TabIndex = 1;
            this.radbtnD4.Text = "d4";
            this.radbtnD4.UseVisualStyleBackColor = true;
            this.radbtnD4.CheckedChanged += new System.EventHandler(this.radbtnD4_CheckedChanged);
            // 
            // radbtnD24
            // 
            this.radbtnD24.AutoSize = true;
            this.radbtnD24.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnD24.Location = new System.Drawing.Point(120, 144);
            this.radbtnD24.Name = "radbtnD24";
            this.radbtnD24.Size = new System.Drawing.Size(74, 33);
            this.radbtnD24.TabIndex = 10;
            this.radbtnD24.Text = "d24";
            this.radbtnD24.UseVisualStyleBackColor = true;
            this.radbtnD24.CheckedChanged += new System.EventHandler(this.radbtnD24_CheckedChanged);
            // 
            // radbtnD3
            // 
            this.radbtnD3.AutoSize = true;
            this.radbtnD3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnD3.Location = new System.Drawing.Point(6, 27);
            this.radbtnD3.Name = "radbtnD3";
            this.radbtnD3.Size = new System.Drawing.Size(61, 33);
            this.radbtnD3.TabIndex = 0;
            this.radbtnD3.Text = "d3";
            this.radbtnD3.UseVisualStyleBackColor = true;
            this.radbtnD3.CheckedChanged += new System.EventHandler(this.radbtnD3_CheckedChanged);
            // 
            // radbtnD10_dezena
            // 
            this.radbtnD10_dezena.AutoSize = true;
            this.radbtnD10_dezena.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnD10_dezena.Location = new System.Drawing.Point(6, 222);
            this.radbtnD10_dezena.Name = "radbtnD10_dezena";
            this.radbtnD10_dezena.Size = new System.Drawing.Size(96, 33);
            this.radbtnD10_dezena.TabIndex = 5;
            this.radbtnD10_dezena.Text = "d10%";
            this.radbtnD10_dezena.UseVisualStyleBackColor = true;
            this.radbtnD10_dezena.CheckedChanged += new System.EventHandler(this.radbtnD10_dezena_CheckedChanged);
            // 
            // radbtnD12
            // 
            this.radbtnD12.AutoSize = true;
            this.radbtnD12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnD12.Location = new System.Drawing.Point(120, 27);
            this.radbtnD12.Name = "radbtnD12";
            this.radbtnD12.Size = new System.Drawing.Size(74, 33);
            this.radbtnD12.TabIndex = 6;
            this.radbtnD12.Text = "d12";
            this.radbtnD12.UseVisualStyleBackColor = true;
            this.radbtnD12.CheckedChanged += new System.EventHandler(this.radbtnD12_CheckedChanged);
            // 
            // radbtnD20
            // 
            this.radbtnD20.AutoSize = true;
            this.radbtnD20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnD20.Location = new System.Drawing.Point(120, 105);
            this.radbtnD20.Name = "radbtnD20";
            this.radbtnD20.Size = new System.Drawing.Size(74, 33);
            this.radbtnD20.TabIndex = 8;
            this.radbtnD20.Text = "d20";
            this.radbtnD20.UseVisualStyleBackColor = true;
            this.radbtnD20.CheckedChanged += new System.EventHandler(this.radbtnD20_CheckedChanged);
            // 
            // radbtnD16
            // 
            this.radbtnD16.AutoSize = true;
            this.radbtnD16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnD16.Location = new System.Drawing.Point(120, 66);
            this.radbtnD16.Name = "radbtnD16";
            this.radbtnD16.Size = new System.Drawing.Size(74, 33);
            this.radbtnD16.TabIndex = 7;
            this.radbtnD16.Text = "d16";
            this.radbtnD16.UseVisualStyleBackColor = true;
            this.radbtnD16.CheckedChanged += new System.EventHandler(this.radbtnD16_CheckedChanged);
            // 
            // lblTipoDeDados
            // 
            this.lblTipoDeDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeDados.Location = new System.Drawing.Point(22, 45);
            this.lblTipoDeDados.Name = "lblTipoDeDados";
            this.lblTipoDeDados.Size = new System.Drawing.Size(218, 38);
            this.lblTipoDeDados.TabIndex = 6;
            this.lblTipoDeDados.Text = "Tipos de Dados";
            this.lblTipoDeDados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJogando
            // 
            this.lblJogando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogando.Location = new System.Drawing.Point(532, 276);
            this.lblJogando.Name = "lblJogando";
            this.lblJogando.Size = new System.Drawing.Size(149, 39);
            this.lblJogando.TabIndex = 7;
            this.lblJogando.Text = "jogando...";
            this.lblJogando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblJogando.Visible = false;
            // 
            // lblDescricaoDado
            // 
            this.lblDescricaoDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoDado.Location = new System.Drawing.Point(269, 48);
            this.lblDescricaoDado.Name = "lblDescricaoDado";
            this.lblDescricaoDado.Size = new System.Drawing.Size(200, 39);
            this.lblDescricaoDado.TabIndex = 8;
            this.lblDescricaoDado.Text = "(dado de 6 lados)";
            this.lblDescricaoDado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDanoExtremo
            // 
            this.lblDanoExtremo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanoExtremo.ForeColor = System.Drawing.Color.Red;
            this.lblDanoExtremo.Location = new System.Drawing.Point(501, 279);
            this.lblDanoExtremo.Name = "lblDanoExtremo";
            this.lblDanoExtremo.Size = new System.Drawing.Size(220, 33);
            this.lblDanoExtremo.TabIndex = 9;
            this.lblDanoExtremo.Text = "Fracasso extremo!";
            this.lblDanoExtremo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDanoExtremo.Visible = false;
            // 
            // lblProbabilidade
            // 
            this.lblProbabilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProbabilidade.Location = new System.Drawing.Point(484, 76);
            this.lblProbabilidade.Name = "lblProbabilidade";
            this.lblProbabilidade.Size = new System.Drawing.Size(237, 39);
            this.lblProbabilidade.TabIndex = 10;
            this.lblProbabilidade.Text = "d6 = 1 / 6 = 1,6%";
            this.lblProbabilidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImagemIlustrativa
            // 
            this.lblImagemIlustrativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemIlustrativa.Location = new System.Drawing.Point(228, 299);
            this.lblImagemIlustrativa.Name = "lblImagemIlustrativa";
            this.lblImagemIlustrativa.Size = new System.Drawing.Size(286, 85);
            this.lblImagemIlustrativa.TabIndex = 11;
            this.lblImagemIlustrativa.Text = "Imagem meramente ilustrativa";
            this.lblImagemIlustrativa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloProbabilidade
            // 
            this.lblTituloProbabilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProbabilidade.Location = new System.Drawing.Point(489, 48);
            this.lblTituloProbabilidade.Name = "lblTituloProbabilidade";
            this.lblTituloProbabilidade.Size = new System.Drawing.Size(232, 36);
            this.lblTituloProbabilidade.TabIndex = 12;
            this.lblTituloProbabilidade.Text = "Probabilidade:";
            this.lblTituloProbabilidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSimuladorDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(730, 407);
            this.Controls.Add(this.lblTituloProbabilidade);
            this.Controls.Add(this.lblImagemIlustrativa);
            this.Controls.Add(this.lblProbabilidade);
            this.Controls.Add(this.lblDanoExtremo);
            this.Controls.Add(this.lblDescricaoDado);
            this.Controls.Add(this.lblJogando);
            this.Controls.Add(this.lblTipoDeDados);
            this.Controls.Add(this.grpboxTipoDeDados);
            this.Controls.Add(this.lblTituloValor);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblNomeDado);
            this.Controls.Add(this.picDado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSimuladorDados";
            this.Text = "Simulador de Dados RPG";
            ((System.ComponentModel.ISupportInitialize)(this.picDado)).EndInit();
            this.grpboxTipoDeDados.ResumeLayout(false);
            this.grpboxTipoDeDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDado;
        private System.Windows.Forms.Label lblNomeDado;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTituloValor;
        private System.Windows.Forms.GroupBox grpboxTipoDeDados;
        private System.Windows.Forms.RadioButton radbtnD60;
        private System.Windows.Forms.RadioButton radbtnD30;
        private System.Windows.Forms.RadioButton radbtnD24;
        private System.Windows.Forms.RadioButton radbtnD100;
        private System.Windows.Forms.RadioButton radbtnD20;
        private System.Windows.Forms.RadioButton radbtnD16;
        private System.Windows.Forms.RadioButton radbtnD12;
        private System.Windows.Forms.RadioButton radbtnD10_dezena;
        private System.Windows.Forms.RadioButton radbtnD10;
        private System.Windows.Forms.RadioButton radbtnD8;
        private System.Windows.Forms.RadioButton radbtnD6;
        private System.Windows.Forms.RadioButton radbtnD4;
        private System.Windows.Forms.RadioButton radbtnD3;
        private System.Windows.Forms.Label lblTipoDeDados;
        private System.Windows.Forms.Label lblJogando;
        private System.Windows.Forms.Label lblDescricaoDado;
        private System.Windows.Forms.Label lblDanoExtremo;
        private System.Windows.Forms.Label lblProbabilidade;
        private System.Windows.Forms.Label lblImagemIlustrativa;
        private System.Windows.Forms.Label lblTituloProbabilidade;
    }
}

