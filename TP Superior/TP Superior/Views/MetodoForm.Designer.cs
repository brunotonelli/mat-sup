namespace TP_Superior
{
    partial class MetodoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetodoForm));
            this.label8 = new System.Windows.Forms.Label();
            this.decimalesTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cotaErrorTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.matrizX = new System.Windows.Forms.DataGridView();
            this.botonResolver = new System.Windows.Forms.Button();
            this.labelMetodo = new System.Windows.Forms.Label();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botonTC = new System.Windows.Forms.Button();
            this.botonDLU = new System.Windows.Forms.Button();
            this.botonCambiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrizX)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Decimales";
            // 
            // decimalesTextBox
            // 
            this.decimalesTextBox.Location = new System.Drawing.Point(15, 251);
            this.decimalesTextBox.Name = "decimalesTextBox";
            this.decimalesTextBox.Size = new System.Drawing.Size(124, 20);
            this.decimalesTextBox.TabIndex = 22;
            this.decimalesTextBox.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cota de error";
            // 
            // cotaErrorTextBox
            // 
            this.cotaErrorTextBox.Location = new System.Drawing.Point(15, 225);
            this.cotaErrorTextBox.Name = "cotaErrorTextBox";
            this.cotaErrorTextBox.Size = new System.Drawing.Size(124, 20);
            this.cotaErrorTextBox.TabIndex = 20;
            this.cotaErrorTextBox.Text = "0,001";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Vector inicial";
            // 
            // matrizX
            // 
            this.matrizX.AllowUserToAddRows = false;
            this.matrizX.AllowUserToDeleteRows = false;
            this.matrizX.AllowUserToOrderColumns = true;
            this.matrizX.AllowUserToResizeColumns = false;
            this.matrizX.AllowUserToResizeRows = false;
            this.matrizX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizX.ColumnHeadersVisible = false;
            this.matrizX.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.matrizX.Location = new System.Drawing.Point(15, 184);
            this.matrizX.Name = "matrizX";
            this.matrizX.RowHeadersVisible = false;
            this.matrizX.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.matrizX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrizX.Size = new System.Drawing.Size(333, 33);
            this.matrizX.TabIndex = 18;
            // 
            // botonResolver
            // 
            this.botonResolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonResolver.Location = new System.Drawing.Point(241, 225);
            this.botonResolver.Name = "botonResolver";
            this.botonResolver.Size = new System.Drawing.Size(107, 73);
            this.botonResolver.TabIndex = 24;
            this.botonResolver.Text = "Resolver";
            this.botonResolver.UseVisualStyleBackColor = true;
            this.botonResolver.Click += new System.EventHandler(this.botonResolver_Click);
            // 
            // labelMetodo
            // 
            this.labelMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetodo.Location = new System.Drawing.Point(15, 78);
            this.labelMetodo.Name = "labelMetodo";
            this.labelMetodo.Size = new System.Drawing.Size(333, 49);
            this.labelMetodo.TabIndex = 29;
            this.labelMetodo.Text = "<Nombre Metodo>";
            this.labelMetodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(15, 277);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(124, 21);
            this.comboBoxCriterio.TabIndex = 30;
            this.comboBoxCriterio.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCriterio_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Criterio de paro";
            // 
            // botonTC
            // 
            this.botonTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonTC.Location = new System.Drawing.Point(128, 18);
            this.botonTC.Name = "botonTC";
            this.botonTC.Size = new System.Drawing.Size(107, 30);
            this.botonTC.TabIndex = 32;
            this.botonTC.Text = "Ver TC";
            this.botonTC.UseVisualStyleBackColor = true;
            this.botonTC.Click += new System.EventHandler(this.botonTC_Click);
            // 
            // botonDLU
            // 
            this.botonDLU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDLU.Location = new System.Drawing.Point(15, 18);
            this.botonDLU.Name = "botonDLU";
            this.botonDLU.Size = new System.Drawing.Size(107, 30);
            this.botonDLU.TabIndex = 33;
            this.botonDLU.Text = "Ver DLU";
            this.botonDLU.UseVisualStyleBackColor = true;
            this.botonDLU.Click += new System.EventHandler(this.botonDLU_Click);
            // 
            // botonCambiar
            // 
            this.botonCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCambiar.Location = new System.Drawing.Point(241, 18);
            this.botonCambiar.Name = "botonCambiar";
            this.botonCambiar.Size = new System.Drawing.Size(107, 30);
            this.botonCambiar.TabIndex = 34;
            this.botonCambiar.Text = "Cambiar método";
            this.botonCambiar.UseVisualStyleBackColor = true;
            this.botonCambiar.Click += new System.EventHandler(this.botonCambiar_Click);
            // 
            // MetodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 316);
            this.Controls.Add(this.botonCambiar);
            this.Controls.Add(this.botonDLU);
            this.Controls.Add(this.botonTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCriterio);
            this.Controls.Add(this.labelMetodo);
            this.Controls.Add(this.botonResolver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.decimalesTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cotaErrorTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.matrizX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MetodoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[ SIEL ] - ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MetodoForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.matrizX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox decimalesTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cotaErrorTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView matrizX;
        private System.Windows.Forms.Button botonResolver;
        private System.Windows.Forms.Label labelMetodo;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonTC;
        private System.Windows.Forms.Button botonDLU;
        private System.Windows.Forms.Button botonCambiar;
    }
}