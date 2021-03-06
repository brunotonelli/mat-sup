﻿namespace TP_Superior.Views
{
    partial class Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.botonManual = new System.Windows.Forms.Button();
            this.botonCodigo = new System.Windows.Forms.Button();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonManual
            // 
            this.botonManual.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonManual.Location = new System.Drawing.Point(438, 234);
            this.botonManual.Name = "botonManual";
            this.botonManual.Size = new System.Drawing.Size(314, 64);
            this.botonManual.TabIndex = 2;
            this.botonManual.Text = "Manual de Usuario";
            this.botonManual.UseVisualStyleBackColor = true;
            this.botonManual.Click += new System.EventHandler(this.botonManual_Click);
            // 
            // botonCodigo
            // 
            this.botonCodigo.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCodigo.Location = new System.Drawing.Point(438, 304);
            this.botonCodigo.Name = "botonCodigo";
            this.botonCodigo.Size = new System.Drawing.Size(314, 64);
            this.botonCodigo.TabIndex = 1;
            this.botonCodigo.Text = "Código";
            this.botonCodigo.UseVisualStyleBackColor = true;
            this.botonCodigo.Click += new System.EventHandler(this.botonCodigo_Click);
            // 
            // botonIngresar
            // 
            this.botonIngresar.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIngresar.Location = new System.Drawing.Point(438, 34);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(314, 158);
            this.botonIngresar.TabIndex = 0;
            this.botonIngresar.Text = "Ingresar Sistema";
            this.botonIngresar.UseVisualStyleBackColor = true;
            this.botonIngresar.Click += new System.EventHandler(this.botonIngresar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.Color.Transparent;
            this.botonSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.botonSalir.FlatAppearance.BorderSize = 0;
            this.botonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonSalir.Location = new System.Drawing.Point(773, 2);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(25, 26);
            this.botonSalir.TabIndex = 3;
            this.botonSalir.Text = "X";
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // Intro
            // 
            this.BackgroundImage = global::TP_Superior.Properties.Resources.intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.botonCodigo);
            this.Controls.Add(this.botonManual);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonManual;
        private System.Windows.Forms.Button botonCodigo;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.Button botonSalir;
    }
}