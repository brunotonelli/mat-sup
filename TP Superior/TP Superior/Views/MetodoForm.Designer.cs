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
            this.label8 = new System.Windows.Forms.Label();
            this.decimalesTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cotaErrorTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.matrizX = new System.Windows.Forms.DataGridView();
            this.botonResolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrizX)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Decimales";
            // 
            // decimalesTextBox
            // 
            this.decimalesTextBox.Location = new System.Drawing.Point(12, 98);
            this.decimalesTextBox.Name = "decimalesTextBox";
            this.decimalesTextBox.Size = new System.Drawing.Size(124, 20);
            this.decimalesTextBox.TabIndex = 22;
            this.decimalesTextBox.Text = "7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cota de error";
            // 
            // cotaErrorTextBox
            // 
            this.cotaErrorTextBox.Location = new System.Drawing.Point(12, 72);
            this.cotaErrorTextBox.Name = "cotaErrorTextBox";
            this.cotaErrorTextBox.Size = new System.Drawing.Size(124, 20);
            this.cotaErrorTextBox.TabIndex = 20;
            this.cotaErrorTextBox.Text = "0,1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
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
            this.matrizX.Location = new System.Drawing.Point(12, 31);
            this.matrizX.Name = "matrizX";
            this.matrizX.RowHeadersVisible = false;
            this.matrizX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrizX.Size = new System.Drawing.Size(333, 33);
            this.matrizX.TabIndex = 18;
            // 
            // botonResolver
            // 
            this.botonResolver.Location = new System.Drawing.Point(251, 91);
            this.botonResolver.Name = "botonResolver";
            this.botonResolver.Size = new System.Drawing.Size(75, 23);
            this.botonResolver.TabIndex = 24;
            this.botonResolver.Text = "Resolver";
            this.botonResolver.UseVisualStyleBackColor = true;
            this.botonResolver.Click += new System.EventHandler(this.botonResolver_Click);
            // 
            // MetodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 334);
            this.Controls.Add(this.botonResolver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.decimalesTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cotaErrorTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.matrizX);
            this.Name = "MetodoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MetodoForm";
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
    }
}