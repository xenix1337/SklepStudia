namespace Sklep
{
    partial class SalesReportWindow
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
            chartPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)chartPictureBox).BeginInit();
            this.SuspendLayout();
            // 
            // chartPictureBox
            // 
            chartPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            chartPictureBox.Location = new System.Drawing.Point(0, 0);
            chartPictureBox.Name = "chartPictureBox";
            chartPictureBox.Size = new System.Drawing.Size(1005, 665);
            chartPictureBox.TabIndex = 0;
            chartPictureBox.TabStop = false;
            // 
            // SalesReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 665);
            this.Controls.Add(chartPictureBox);
            this.Name = "SalesReportWindow";
            this.Text = "Sprzedaż w dniach";
            this.Load += this.SalesReportWindow_Load;
            this.SizeChanged += this.SalesReportWindow_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)chartPictureBox).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox chartPictureBox;
    }
}