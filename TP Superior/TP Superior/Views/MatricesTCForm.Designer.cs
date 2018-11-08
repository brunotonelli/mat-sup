namespace TP_Superior.Views
{
    partial class MatricesTCForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatricesTCForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.matrizC = new System.Windows.Forms.DataGridView();
            this.matrizT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.matrizC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizT)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "T";
            // 
            // matrizC
            // 
            this.matrizC.AllowUserToAddRows = false;
            this.matrizC.AllowUserToDeleteRows = false;
            this.matrizC.AllowUserToResizeColumns = false;
            this.matrizC.AllowUserToResizeRows = false;
            this.matrizC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizC.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrizC.DefaultCellStyle = dataGridViewCellStyle1;
            this.matrizC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.matrizC.Enabled = false;
            this.matrizC.Location = new System.Drawing.Point(361, 12);
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
            this.matrizC.TabIndex = 30;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrizT.DefaultCellStyle = dataGridViewCellStyle2;
            this.matrizT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.matrizT.Enabled = false;
            this.matrizT.Location = new System.Drawing.Point(12, 12);
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
            this.matrizT.TabIndex = 29;
            // 
            // MatricesTCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 376);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrizC);
            this.Controls.Add(this.matrizT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MatricesTCForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[ SIEL ] - TC";
            ((System.ComponentModel.ISupportInitialize)(this.matrizC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView matrizC;
        private System.Windows.Forms.DataGridView matrizT;
    }
}