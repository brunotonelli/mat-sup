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
            this.matrizT = new System.Windows.Forms.DataGridView();
            this.matrizC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMetodo = new System.Windows.Forms.Label();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matrizX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizC)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(558, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Decimales";
            // 
            // decimalesTextBox
            // 
            this.decimalesTextBox.Location = new System.Drawing.Point(428, 272);
            this.decimalesTextBox.Name = "decimalesTextBox";
            this.decimalesTextBox.Size = new System.Drawing.Size(124, 20);
            this.decimalesTextBox.TabIndex = 22;
            this.decimalesTextBox.Text = "7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cota de error";
            // 
            // cotaErrorTextBox
            // 
            this.cotaErrorTextBox.Location = new System.Drawing.Point(428, 246);
            this.cotaErrorTextBox.Name = "cotaErrorTextBox";
            this.cotaErrorTextBox.Size = new System.Drawing.Size(124, 20);
            this.cotaErrorTextBox.TabIndex = 20;
            this.cotaErrorTextBox.Text = "0,1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 182);
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
            this.matrizX.Location = new System.Drawing.Point(428, 205);
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
            this.botonResolver.Location = new System.Drawing.Point(654, 246);
            this.botonResolver.Name = "botonResolver";
            this.botonResolver.Size = new System.Drawing.Size(107, 73);
            this.botonResolver.TabIndex = 24;
            this.botonResolver.Text = "Resolver";
            this.botonResolver.UseVisualStyleBackColor = true;
            this.botonResolver.Click += new System.EventHandler(this.botonResolver_Click);
            // 
            // matrizT
            // 
            this.matrizT.AllowUserToAddRows = false;
            this.matrizT.AllowUserToDeleteRows = false;
            this.matrizT.AllowUserToResizeColumns = false;
            this.matrizT.AllowUserToResizeRows = false;
            this.matrizT.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.matrizT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizT.ColumnHeadersVisible = false;
            this.matrizT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.matrizT.Enabled = false;
            this.matrizT.Location = new System.Drawing.Point(12, 39);
            this.matrizT.MultiSelect = false;
            this.matrizT.Name = "matrizT";
            this.matrizT.ReadOnly = true;
            this.matrizT.RowHeadersVisible = false;
            this.matrizT.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.matrizT.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.matrizT.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.matrizT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrizT.ShowEditingIcon = false;
            this.matrizT.Size = new System.Drawing.Size(333, 333);
            this.matrizT.TabIndex = 25;
            // 
            // matrizC
            // 
            this.matrizC.AllowUserToAddRows = false;
            this.matrizC.AllowUserToDeleteRows = false;
            this.matrizC.AllowUserToResizeColumns = false;
            this.matrizC.AllowUserToResizeRows = false;
            this.matrizC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizC.ColumnHeadersVisible = false;
            this.matrizC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.matrizC.Enabled = false;
            this.matrizC.Location = new System.Drawing.Point(351, 39);
            this.matrizC.MultiSelect = false;
            this.matrizC.Name = "matrizC";
            this.matrizC.ReadOnly = true;
            this.matrizC.RowHeadersVisible = false;
            this.matrizC.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.matrizC.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.matrizC.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.matrizC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrizC.ShowEditingIcon = false;
            this.matrizC.Size = new System.Drawing.Size(33, 333);
            this.matrizC.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "T";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "C";
            // 
            // labelMetodo
            // 
            this.labelMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetodo.Location = new System.Drawing.Point(428, 39);
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
            this.comboBoxCriterio.Location = new System.Drawing.Point(428, 298);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(124, 21);
            this.comboBoxCriterio.TabIndex = 30;
            this.comboBoxCriterio.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCriterio_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Criterio de paro";
            // 
            // MetodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 381);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCriterio);
            this.Controls.Add(this.labelMetodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrizC);
            this.Controls.Add(this.matrizT);
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
            ((System.ComponentModel.ISupportInitialize)(this.matrizX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizC)).EndInit();
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
        private System.Windows.Forms.DataGridView matrizT;
        private System.Windows.Forms.DataGridView matrizC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMetodo;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.Label label3;
    }
}