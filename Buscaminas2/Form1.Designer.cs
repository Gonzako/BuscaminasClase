namespace BuscaMinas
{
    partial class Form1
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
            this.nfilasNUD = new System.Windows.Forms.NumericUpDown();
            this.ncolumnasNUD = new System.Windows.Forms.NumericUpDown();
            this.porcentajeMinasNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nfilasNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncolumnasNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeMinasNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // nfilasNUD
            // 
            this.nfilasNUD.Location = new System.Drawing.Point(36, 8);
            this.nfilasNUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nfilasNUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nfilasNUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nfilasNUD.Name = "nfilasNUD";
            this.nfilasNUD.Size = new System.Drawing.Size(34, 20);
            this.nfilasNUD.TabIndex = 0;
            this.nfilasNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ncolumnasNUD
            // 
            this.ncolumnasNUD.Location = new System.Drawing.Point(124, 8);
            this.ncolumnasNUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ncolumnasNUD.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ncolumnasNUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ncolumnasNUD.Name = "ncolumnasNUD";
            this.ncolumnasNUD.Size = new System.Drawing.Size(34, 20);
            this.ncolumnasNUD.TabIndex = 1;
            this.ncolumnasNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // porcentajeMinasNUD
            // 
            this.porcentajeMinasNUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.porcentajeMinasNUD.Location = new System.Drawing.Point(123, 33);
            this.porcentajeMinasNUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.porcentajeMinasNUD.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.porcentajeMinasNUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.porcentajeMinasNUD.Name = "porcentajeMinasNUD";
            this.porcentajeMinasNUD.Size = new System.Drawing.Size(34, 20);
            this.porcentajeMinasNUD.TabIndex = 2;
            this.porcentajeMinasNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Columnas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Porcentaje de Minas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ya!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 61);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.porcentajeMinasNUD);
            this.Controls.Add(this.ncolumnasNUD);
            this.Controls.Add(this.nfilasNUD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BuscaMinas VJ1208";
            ((System.ComponentModel.ISupportInitialize)(this.nfilasNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncolumnasNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeMinasNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nfilasNUD;
        private System.Windows.Forms.NumericUpDown ncolumnasNUD;
        private System.Windows.Forms.NumericUpDown porcentajeMinasNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

