﻿namespace TP_Superior
{
    partial class MatrizForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrizForm));
            this.botonMas = new System.Windows.Forms.Button();
            this.matrizA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matrizB = new System.Windows.Forms.DataGridView();
            this.botonMenos = new System.Windows.Forms.Button();
            this.botonValidar = new System.Windows.Forms.Button();
            this.botonNorma1 = new System.Windows.Forms.Button();
            this.botonNorma2 = new System.Windows.Forms.Button();
            this.botonNormaInf = new System.Windows.Forms.Button();
            this.botonResolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrizA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizB)).BeginInit();
            this.SuspendLayout();
            // 
            // botonMas
            // 
            this.botonMas.Location = new System.Drawing.Point(12, 19);
            this.botonMas.Name = "botonMas";
            this.botonMas.Size = new System.Drawing.Size(24, 23);
            this.botonMas.TabIndex = 0;
            this.botonMas.Text = "+";
            this.botonMas.UseVisualStyleBackColor = true;
            this.botonMas.Click += new System.EventHandler(this.button1_Click);
            // 
            // matrizA
            // 
            this.matrizA.AllowUserToAddRows = false;
            this.matrizA.AllowUserToDeleteRows = false;
            this.matrizA.AllowUserToOrderColumns = true;
            this.matrizA.AllowUserToResizeColumns = false;
            this.matrizA.AllowUserToResizeRows = false;
            this.matrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizA.ColumnHeadersVisible = false;
            this.matrizA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.matrizA.Location = new System.Drawing.Point(12, 48);
            this.matrizA.Name = "matrizA";
            this.matrizA.RowHeadersVisible = false;
            this.matrizA.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.matrizA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrizA.Size = new System.Drawing.Size(333, 333);
            this.matrizA.TabIndex = 1;
            this.matrizA.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.matrizA_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matriz A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matriz B";
            // 
            // matrizB
            // 
            this.matrizB.AllowUserToAddRows = false;
            this.matrizB.AllowUserToDeleteRows = false;
            this.matrizB.AllowUserToOrderColumns = true;
            this.matrizB.AllowUserToResizeColumns = false;
            this.matrizB.AllowUserToResizeRows = false;
            this.matrizB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizB.ColumnHeadersVisible = false;
            this.matrizB.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.matrizB.Location = new System.Drawing.Point(351, 48);
            this.matrizB.Name = "matrizB";
            this.matrizB.RowHeadersVisible = false;
            this.matrizB.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.matrizB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrizB.Size = new System.Drawing.Size(33, 333);
            this.matrizB.TabIndex = 1;
            // 
            // botonMenos
            // 
            this.botonMenos.Location = new System.Drawing.Point(42, 19);
            this.botonMenos.Name = "botonMenos";
            this.botonMenos.Size = new System.Drawing.Size(24, 23);
            this.botonMenos.TabIndex = 8;
            this.botonMenos.Text = "-";
            this.botonMenos.UseVisualStyleBackColor = true;
            this.botonMenos.Click += new System.EventHandler(this.button5_Click);
            // 
            // botonValidar
            // 
            this.botonValidar.Location = new System.Drawing.Point(390, 293);
            this.botonValidar.Name = "botonValidar";
            this.botonValidar.Size = new System.Drawing.Size(115, 41);
            this.botonValidar.TabIndex = 18;
            this.botonValidar.Text = "Validar Matriz";
            this.botonValidar.UseMnemonic = false;
            this.botonValidar.UseVisualStyleBackColor = true;
            this.botonValidar.Click += new System.EventHandler(this.botonValidar_Click);
            // 
            // botonNorma1
            // 
            this.botonNorma1.Location = new System.Drawing.Point(390, 48);
            this.botonNorma1.Name = "botonNorma1";
            this.botonNorma1.Size = new System.Drawing.Size(115, 35);
            this.botonNorma1.TabIndex = 19;
            this.botonNorma1.Text = "Norma 1";
            this.botonNorma1.UseMnemonic = false;
            this.botonNorma1.UseVisualStyleBackColor = true;
            this.botonNorma1.Click += new System.EventHandler(this.botonNorma1_Click);
            // 
            // botonNorma2
            // 
            this.botonNorma2.Location = new System.Drawing.Point(390, 89);
            this.botonNorma2.Name = "botonNorma2";
            this.botonNorma2.Size = new System.Drawing.Size(115, 35);
            this.botonNorma2.TabIndex = 20;
            this.botonNorma2.Text = "Norma 2";
            this.botonNorma2.UseMnemonic = false;
            this.botonNorma2.UseVisualStyleBackColor = true;
            this.botonNorma2.Click += new System.EventHandler(this.botonNorma2_Click);
            // 
            // botonNormaInf
            // 
            this.botonNormaInf.Location = new System.Drawing.Point(390, 130);
            this.botonNormaInf.Name = "botonNormaInf";
            this.botonNormaInf.Size = new System.Drawing.Size(115, 35);
            this.botonNormaInf.TabIndex = 21;
            this.botonNormaInf.Text = "Norma  ∞";
            this.botonNormaInf.UseMnemonic = false;
            this.botonNormaInf.UseVisualStyleBackColor = true;
            this.botonNormaInf.Click += new System.EventHandler(this.botonNormaInf_Click);
            // 
            // botonResolver
            // 
            this.botonResolver.Enabled = false;
            this.botonResolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonResolver.Location = new System.Drawing.Point(390, 340);
            this.botonResolver.Name = "botonResolver";
            this.botonResolver.Size = new System.Drawing.Size(115, 41);
            this.botonResolver.TabIndex = 22;
            this.botonResolver.Text = "RESOLVER";
            this.botonResolver.UseVisualStyleBackColor = true;
            this.botonResolver.Click += new System.EventHandler(this.botonResolver_Click);
            // 
            // MatrizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 395);
            this.Controls.Add(this.botonResolver);
            this.Controls.Add(this.botonNormaInf);
            this.Controls.Add(this.botonNorma2);
            this.Controls.Add(this.botonNorma1);
            this.Controls.Add(this.botonValidar);
            this.Controls.Add(this.botonMenos);
            this.Controls.Add(this.matrizB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrizA);
            this.Controls.Add(this.botonMas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MatrizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[ SIEL ] - Ingreso del sistema";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MatrizForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.matrizA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonMas;
        private System.Windows.Forms.DataGridView matrizA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView matrizB;
        private System.Windows.Forms.Button botonMenos;
        private System.Windows.Forms.Button botonValidar;
        private System.Windows.Forms.Button botonNorma1;
        private System.Windows.Forms.Button botonNorma2;
        private System.Windows.Forms.Button botonNormaInf;
        private System.Windows.Forms.Button botonResolver;
    }
}

