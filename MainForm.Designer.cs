﻿
namespace SimuladorElectronica
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picBoxResistencia = new System.Windows.Forms.PictureBox();
            this.groupBoxVisual = new System.Windows.Forms.GroupBox();
            this.picBoxBanda4 = new System.Windows.Forms.PictureBox();
            this.picBoxBanda3 = new System.Windows.Forms.PictureBox();
            this.picBoxBanda2 = new System.Windows.Forms.PictureBox();
            this.picBoxBanda1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTolernciaVisual = new System.Windows.Forms.Label();
            this.lblBanda3Visual = new System.Windows.Forms.Label();
            this.lblBanda2Visual = new System.Windows.Forms.Label();
            this.lblBanda1Visual = new System.Windows.Forms.Label();
            this.groupBoxNumerico = new System.Windows.Forms.GroupBox();
            this.comboBoxBanda4 = new System.Windows.Forms.ComboBox();
            this.comboBoxBanda3 = new System.Windows.Forms.ComboBox();
            this.comboBoxBanda2 = new System.Windows.Forms.ComboBox();
            this.comboBoxBanda1 = new System.Windows.Forms.ComboBox();
            this.txtResistencia = new System.Windows.Forms.TextBox();
            this.lblResistencia = new System.Windows.Forms.Label();
            this.lblToleranciaNumerico = new System.Windows.Forms.Label();
            this.lblbanda3Numerico = new System.Windows.Forms.Label();
            this.lblBanda2Numerico = new System.Windows.Forms.Label();
            this.lblBanda1Numerico = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxResistencia)).BeginInit();
            this.groupBoxVisual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanda4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanda3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanda2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanda1)).BeginInit();
            this.groupBoxNumerico.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxResistencia
            // 
            this.picBoxResistencia.Image = ((System.Drawing.Image)(resources.GetObject("picBoxResistencia.Image")));
            this.picBoxResistencia.Location = new System.Drawing.Point(32, 35);
            this.picBoxResistencia.Name = "picBoxResistencia";
            this.picBoxResistencia.Size = new System.Drawing.Size(364, 139);
            this.picBoxResistencia.TabIndex = 0;
            this.picBoxResistencia.TabStop = false;
            // 
            // groupBoxVisual
            // 
            this.groupBoxVisual.Controls.Add(this.picBoxBanda4);
            this.groupBoxVisual.Controls.Add(this.picBoxBanda3);
            this.groupBoxVisual.Controls.Add(this.picBoxBanda2);
            this.groupBoxVisual.Controls.Add(this.picBoxBanda1);
            this.groupBoxVisual.Controls.Add(this.label9);
            this.groupBoxVisual.Controls.Add(this.lblTolernciaVisual);
            this.groupBoxVisual.Controls.Add(this.lblBanda3Visual);
            this.groupBoxVisual.Controls.Add(this.lblBanda2Visual);
            this.groupBoxVisual.Controls.Add(this.lblBanda1Visual);
            this.groupBoxVisual.Controls.Add(this.picBoxResistencia);
            this.groupBoxVisual.Location = new System.Drawing.Point(12, 12);
            this.groupBoxVisual.Name = "groupBoxVisual";
            this.groupBoxVisual.Size = new System.Drawing.Size(431, 210);
            this.groupBoxVisual.TabIndex = 1;
            this.groupBoxVisual.TabStop = false;
            this.groupBoxVisual.Text = "Visual";
            // 
            // picBoxBanda4
            // 
            this.picBoxBanda4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBoxBanda4.Location = new System.Drawing.Point(234, 74);
            this.picBoxBanda4.Name = "picBoxBanda4";
            this.picBoxBanda4.Size = new System.Drawing.Size(14, 46);
            this.picBoxBanda4.TabIndex = 9;
            this.picBoxBanda4.TabStop = false;
            this.picBoxBanda4.Click += new System.EventHandler(this.PicBoxBanda4_Click);
            // 
            // picBoxBanda3
            // 
            this.picBoxBanda3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBoxBanda3.Location = new System.Drawing.Point(201, 77);
            this.picBoxBanda3.Name = "picBoxBanda3";
            this.picBoxBanda3.Size = new System.Drawing.Size(13, 39);
            this.picBoxBanda3.TabIndex = 8;
            this.picBoxBanda3.TabStop = false;
            this.picBoxBanda3.Click += new System.EventHandler(this.PicBoxBanda3_Click);
            // 
            // picBoxBanda2
            // 
            this.picBoxBanda2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBoxBanda2.Location = new System.Drawing.Point(180, 76);
            this.picBoxBanda2.Name = "picBoxBanda2";
            this.picBoxBanda2.Size = new System.Drawing.Size(14, 40);
            this.picBoxBanda2.TabIndex = 7;
            this.picBoxBanda2.TabStop = false;
            this.picBoxBanda2.Click += new System.EventHandler(this.PicBoxBanda2_Click);
            // 
            // picBoxBanda1
            // 
            this.picBoxBanda1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBoxBanda1.Location = new System.Drawing.Point(161, 74);
            this.picBoxBanda1.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxBanda1.Name = "picBoxBanda1";
            this.picBoxBanda1.Size = new System.Drawing.Size(14, 46);
            this.picBoxBanda1.TabIndex = 6;
            this.picBoxBanda1.TabStop = false;
            this.picBoxBanda1.Click += new System.EventHandler(this.PicBoxBanda1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 5;
            // 
            // lblTolernciaVisual
            // 
            this.lblTolernciaVisual.AutoSize = true;
            this.lblTolernciaVisual.Location = new System.Drawing.Point(219, 58);
            this.lblTolernciaVisual.Name = "lblTolernciaVisual";
            this.lblTolernciaVisual.Size = new System.Drawing.Size(57, 13);
            this.lblTolernciaVisual.TabIndex = 4;
            this.lblTolernciaVisual.Text = "Tolerancia";
            // 
            // lblBanda3Visual
            // 
            this.lblBanda3Visual.AutoSize = true;
            this.lblBanda3Visual.Location = new System.Drawing.Point(191, 120);
            this.lblBanda3Visual.Name = "lblBanda3Visual";
            this.lblBanda3Visual.Size = new System.Drawing.Size(47, 13);
            this.lblBanda3Visual.TabIndex = 3;
            this.lblBanda3Visual.Text = "Banda 3";
            // 
            // lblBanda2Visual
            // 
            this.lblBanda2Visual.AutoSize = true;
            this.lblBanda2Visual.Location = new System.Drawing.Point(166, 58);
            this.lblBanda2Visual.Name = "lblBanda2Visual";
            this.lblBanda2Visual.Size = new System.Drawing.Size(47, 13);
            this.lblBanda2Visual.TabIndex = 2;
            this.lblBanda2Visual.Text = "Banda 2";
            // 
            // lblBanda1Visual
            // 
            this.lblBanda1Visual.AutoSize = true;
            this.lblBanda1Visual.Location = new System.Drawing.Point(138, 120);
            this.lblBanda1Visual.Name = "lblBanda1Visual";
            this.lblBanda1Visual.Size = new System.Drawing.Size(47, 13);
            this.lblBanda1Visual.TabIndex = 1;
            this.lblBanda1Visual.Text = "Banda 1";
            // 
            // groupBoxNumerico
            // 
            this.groupBoxNumerico.Controls.Add(this.comboBoxBanda4);
            this.groupBoxNumerico.Controls.Add(this.comboBoxBanda3);
            this.groupBoxNumerico.Controls.Add(this.comboBoxBanda2);
            this.groupBoxNumerico.Controls.Add(this.comboBoxBanda1);
            this.groupBoxNumerico.Controls.Add(this.txtResistencia);
            this.groupBoxNumerico.Controls.Add(this.lblResistencia);
            this.groupBoxNumerico.Controls.Add(this.lblToleranciaNumerico);
            this.groupBoxNumerico.Controls.Add(this.lblbanda3Numerico);
            this.groupBoxNumerico.Controls.Add(this.lblBanda2Numerico);
            this.groupBoxNumerico.Controls.Add(this.lblBanda1Numerico);
            this.groupBoxNumerico.Location = new System.Drawing.Point(465, 12);
            this.groupBoxNumerico.Name = "groupBoxNumerico";
            this.groupBoxNumerico.Size = new System.Drawing.Size(323, 210);
            this.groupBoxNumerico.TabIndex = 2;
            this.groupBoxNumerico.TabStop = false;
            this.groupBoxNumerico.Text = "Númerico";
            // 
            // comboBoxBanda4
            // 
            this.comboBoxBanda4.FormattingEnabled = true;
            this.comboBoxBanda4.Items.AddRange(new object[] {
            "1%",
            "2%",
            "0.5%",
            "0.25%",
            "0.10%",
            "0.05%",
            "5%",
            "10%"});
            this.comboBoxBanda4.Location = new System.Drawing.Point(78, 122);
            this.comboBoxBanda4.Name = "comboBoxBanda4";
            this.comboBoxBanda4.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBanda4.TabIndex = 14;
            this.comboBoxBanda4.SelectedIndexChanged += new System.EventHandler(this.comboBoxBanda4_SelectedIndexChanged);
            // 
            // comboBoxBanda3
            // 
            this.comboBoxBanda3.FormattingEnabled = true;
            this.comboBoxBanda3.Items.AddRange(new object[] {
            "1Ω",
            "10Ω",
            "100Ω",
            "1KΩ",
            "10KΩ",
            "100KΩ",
            "1MΩ",
            "10MΩ",
            "100MΩ",
            "1GΩ",
            "0.1Ω",
            "0.001Ω"});
            this.comboBoxBanda3.Location = new System.Drawing.Point(78, 92);
            this.comboBoxBanda3.Name = "comboBoxBanda3";
            this.comboBoxBanda3.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBanda3.TabIndex = 13;
            this.comboBoxBanda3.SelectedIndexChanged += new System.EventHandler(this.comboBoxBanda3_SelectedIndexChanged);
            // 
            // comboBoxBanda2
            // 
            this.comboBoxBanda2.FormattingEnabled = true;
            this.comboBoxBanda2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxBanda2.Location = new System.Drawing.Point(78, 62);
            this.comboBoxBanda2.Name = "comboBoxBanda2";
            this.comboBoxBanda2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBanda2.TabIndex = 12;
            this.comboBoxBanda2.SelectedIndexChanged += new System.EventHandler(this.comboBoxBanda2_SelectedIndexChanged);
            // 
            // comboBoxBanda1
            // 
            this.comboBoxBanda1.FormattingEnabled = true;
            this.comboBoxBanda1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxBanda1.Location = new System.Drawing.Point(78, 32);
            this.comboBoxBanda1.Name = "comboBoxBanda1";
            this.comboBoxBanda1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBanda1.TabIndex = 10;
            this.comboBoxBanda1.SelectedIndexChanged += new System.EventHandler(this.comboBoxBanda1_SelectedIndexChanged);
            // 
            // txtResistencia
            // 
            this.txtResistencia.Location = new System.Drawing.Point(78, 152);
            this.txtResistencia.Name = "txtResistencia";
            this.txtResistencia.Size = new System.Drawing.Size(47, 20);
            this.txtResistencia.TabIndex = 9;
            this.txtResistencia.Text = "0";
            // 
            // lblResistencia
            // 
            this.lblResistencia.AutoSize = true;
            this.lblResistencia.Location = new System.Drawing.Point(6, 155);
            this.lblResistencia.Name = "lblResistencia";
            this.lblResistencia.Size = new System.Drawing.Size(62, 13);
            this.lblResistencia.TabIndex = 8;
            this.lblResistencia.Text = "Resistencia";
            // 
            // lblToleranciaNumerico
            // 
            this.lblToleranciaNumerico.AutoSize = true;
            this.lblToleranciaNumerico.Location = new System.Drawing.Point(6, 125);
            this.lblToleranciaNumerico.Name = "lblToleranciaNumerico";
            this.lblToleranciaNumerico.Size = new System.Drawing.Size(57, 13);
            this.lblToleranciaNumerico.TabIndex = 7;
            this.lblToleranciaNumerico.Text = "Tolerancia";
            // 
            // lblbanda3Numerico
            // 
            this.lblbanda3Numerico.AutoSize = true;
            this.lblbanda3Numerico.Location = new System.Drawing.Point(6, 95);
            this.lblbanda3Numerico.Name = "lblbanda3Numerico";
            this.lblbanda3Numerico.Size = new System.Drawing.Size(66, 13);
            this.lblbanda3Numerico.TabIndex = 6;
            this.lblbanda3Numerico.Text = "Multiplicador";
            // 
            // lblBanda2Numerico
            // 
            this.lblBanda2Numerico.AutoSize = true;
            this.lblBanda2Numerico.Location = new System.Drawing.Point(6, 65);
            this.lblBanda2Numerico.Name = "lblBanda2Numerico";
            this.lblBanda2Numerico.Size = new System.Drawing.Size(47, 13);
            this.lblBanda2Numerico.TabIndex = 5;
            this.lblBanda2Numerico.Text = "Banda 2";
            // 
            // lblBanda1Numerico
            // 
            this.lblBanda1Numerico.AutoSize = true;
            this.lblBanda1Numerico.Location = new System.Drawing.Point(6, 35);
            this.lblBanda1Numerico.Name = "lblBanda1Numerico";
            this.lblBanda1Numerico.Size = new System.Drawing.Size(47, 13);
            this.lblBanda1Numerico.TabIndex = 0;
            this.lblBanda1Numerico.Text = "Banda 1";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Negro",
            "Café",
            "Rojo",
            "Naranja",
            "Amarillo",
            "Verde",
            "Azul",
            "Violeta",
            "Gris",
            "Blanco",
            "Dorado",
            "Plata"});
            this.comboBoxColor.Location = new System.Drawing.Point(287, 214);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColor.TabIndex = 8;
            this.comboBoxColor.Visible = false;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            this.comboBoxColor.DropDownClosed += new System.EventHandler(this.comboBoxColor_DropDownClosed);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 236);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.groupBoxNumerico);
            this.Controls.Add(this.groupBoxVisual);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxResistencia)).EndInit();
            this.groupBoxVisual.ResumeLayout(false);
            this.groupBoxVisual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanda4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanda3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanda2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBanda1)).EndInit();
            this.groupBoxNumerico.ResumeLayout(false);
            this.groupBoxNumerico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picBoxResistencia;
        private System.Windows.Forms.GroupBox groupBoxVisual;
        private System.Windows.Forms.GroupBox groupBoxNumerico;
        private System.Windows.Forms.Label lblTolernciaVisual;
        private System.Windows.Forms.Label lblBanda3Visual;
        private System.Windows.Forms.Label lblBanda2Visual;
        private System.Windows.Forms.Label lblBanda1Visual;
        private System.Windows.Forms.Label lblToleranciaNumerico;
        private System.Windows.Forms.Label lblbanda3Numerico;
        private System.Windows.Forms.Label lblBanda2Numerico;
        private System.Windows.Forms.Label lblBanda1Numerico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picBoxBanda1;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.PictureBox picBoxBanda2;
        private System.Windows.Forms.PictureBox picBoxBanda3;
        private System.Windows.Forms.PictureBox picBoxBanda4;
        private System.Windows.Forms.Label lblResistencia;
        private System.Windows.Forms.TextBox txtResistencia;
        private System.Windows.Forms.ComboBox comboBoxBanda1;
        private System.Windows.Forms.ComboBox comboBoxBanda2;
        private System.Windows.Forms.ComboBox comboBoxBanda3;
        private System.Windows.Forms.ComboBox comboBoxBanda4;
    }
}

