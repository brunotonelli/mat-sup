namespace TP_Superior
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
            this.botonJacobi = new System.Windows.Forms.Button();
            this.botonGauss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonJacobi
            // 
            this.botonJacobi.Image = ((System.Drawing.Image)(resources.GetObject("botonJacobi.Image")));
            this.botonJacobi.Location = new System.Drawing.Point(12, 12);
            this.botonJacobi.Name = "botonJacobi";
            this.botonJacobi.Size = new System.Drawing.Size(202, 242);
            this.botonJacobi.TabIndex = 9;
            this.botonJacobi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonJacobi.UseVisualStyleBackColor = true;
            this.botonJacobi.Click += new System.EventHandler(this.botonJacobi_Click);
            // 
            // botonGauss
            // 
            this.botonGauss.Image = ((System.Drawing.Image)(resources.GetObject("botonGauss.Image")));
            this.botonGauss.Location = new System.Drawing.Point(220, 12);
            this.botonGauss.Name = "botonGauss";
            this.botonGauss.Size = new System.Drawing.Size(215, 242);
            this.botonGauss.TabIndex = 8;
            this.botonGauss.UseVisualStyleBackColor = true;
            this.botonGauss.Click += new System.EventHandler(this.botonGauss_Click);
            // 
            // SeleccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 276);
            this.Controls.Add(this.botonJacobi);
            this.Controls.Add(this.botonGauss);
            this.Name = "SeleccionForm";
            this.Text = "SeleccionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonJacobi;
        private System.Windows.Forms.Button botonGauss;
    }
}