﻿namespace TP_Superior
{
    partial class SeleccionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionForm));
            this.labelJacobi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonJacobi = new System.Windows.Forms.Button();
            this.botonGauss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelJacobi
            // 
            this.labelJacobi.AutoSize = true;
            this.labelJacobi.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJacobi.Location = new System.Drawing.Point(24, 175);
            this.labelJacobi.Name = "labelJacobi";
            this.labelJacobi.Size = new System.Drawing.Size(82, 29);
            this.labelJacobi.TabIndex = 10;
            this.labelJacobi.Text = "Jacobi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gauss-Seidel";
            // 
            // botonJacobi
            // 
            this.botonJacobi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonJacobi.Image = ((System.Drawing.Image)(resources.GetObject("botonJacobi.Image")));
            this.botonJacobi.Location = new System.Drawing.Point(12, 12);
            this.botonJacobi.Name = "botonJacobi";
            this.botonJacobi.Size = new System.Drawing.Size(110, 160);
            this.botonJacobi.TabIndex = 1;
            this.botonJacobi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonJacobi.UseVisualStyleBackColor = true;
            this.botonJacobi.Click += new System.EventHandler(this.botonJacobi_Click);
            // 
            // botonGauss
            // 
            this.botonGauss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonGauss.Image = ((System.Drawing.Image)(resources.GetObject("botonGauss.Image")));
            this.botonGauss.Location = new System.Drawing.Point(154, 12);
            this.botonGauss.Name = "botonGauss";
            this.botonGauss.Size = new System.Drawing.Size(110, 160);
            this.botonGauss.TabIndex = 1;
            this.botonGauss.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonGauss.UseVisualStyleBackColor = true;
            this.botonGauss.Click += new System.EventHandler(this.botonGauss_Click);
            // 
            // SeleccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelJacobi);
            this.Controls.Add(this.botonJacobi);
            this.Controls.Add(this.botonGauss);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeleccionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[ SIEL] - Método";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeleccionForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonJacobi;
        private System.Windows.Forms.Button botonGauss;
        private System.Windows.Forms.Label labelJacobi;
        private System.Windows.Forms.Label label1;
    }
}