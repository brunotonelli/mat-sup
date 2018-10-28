namespace TP_Superior
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.matrizA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matrizB = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.matrizX = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cotaErrorTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.decimalesTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dominanteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matrizA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizX)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.matrizA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrizA.Size = new System.Drawing.Size(367, 352);
            this.matrizA.TabIndex = 1;
            this.matrizA.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
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
            this.label2.Location = new System.Drawing.Point(421, 29);
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
            this.matrizB.Location = new System.Drawing.Point(385, 48);
            this.matrizB.Name = "matrizB";
            this.matrizB.RowHeadersVisible = false;
            this.matrizB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrizB.Size = new System.Drawing.Size(124, 352);
            this.matrizB.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(646, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Validar Sistema";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 60);
            this.button3.TabIndex = 6;
            this.button3.Text = "GaussSeidel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(518, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 60);
            this.button4.TabIndex = 7;
            this.button4.Text = "Jacobi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(42, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultado";
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
            this.matrizX.Location = new System.Drawing.Point(12, 440);
            this.matrizX.Name = "matrizX";
            this.matrizX.RowHeadersVisible = false;
            this.matrizX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrizX.Size = new System.Drawing.Size(367, 46);
            this.matrizX.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vector inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // cotaErrorTextBox
            // 
            this.cotaErrorTextBox.Location = new System.Drawing.Point(385, 440);
            this.cotaErrorTextBox.Name = "cotaErrorTextBox";
            this.cotaErrorTextBox.Size = new System.Drawing.Size(124, 20);
            this.cotaErrorTextBox.TabIndex = 14;
            this.cotaErrorTextBox.Text = "0,1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cota de error";
            // 
            // decimalesTextBox
            // 
            this.decimalesTextBox.Location = new System.Drawing.Point(385, 466);
            this.decimalesTextBox.Name = "decimalesTextBox";
            this.decimalesTextBox.Size = new System.Drawing.Size(124, 20);
            this.decimalesTextBox.TabIndex = 16;
            this.decimalesTextBox.Text = "7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(515, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Decimales";
            // 
            // dominanteLabel
            // 
            this.dominanteLabel.AutoSize = true;
            this.dominanteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dominanteLabel.ForeColor = System.Drawing.Color.Red;
            this.dominanteLabel.Location = new System.Drawing.Point(515, 186);
            this.dominanteLabel.Name = "dominanteLabel";
            this.dominanteLabel.Size = new System.Drawing.Size(217, 20);
            this.dominanteLabel.TabIndex = 18;
            this.dominanteLabel.Text = "No diagonalmente dominante";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 498);
            this.Controls.Add(this.dominanteLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.decimalesTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cotaErrorTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.matrizX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.matrizB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrizA);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.matrizA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView matrizA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView matrizB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView matrizX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cotaErrorTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox decimalesTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label dominanteLabel;
    }
}

