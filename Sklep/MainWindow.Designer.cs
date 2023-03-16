
namespace Sklep
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.barCodeTextBox = new System.Windows.Forms.TextBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.finalizationButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarCodeLabel = new System.Windows.Forms.Label();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barCodeTextBox
            // 
            this.barCodeTextBox.Location = new System.Drawing.Point(87, 21);
            this.barCodeTextBox.Name = "barCodeTextBox";
            this.barCodeTextBox.Size = new System.Drawing.Size(280, 26);
            this.barCodeTextBox.TabIndex = 1;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(12, 64);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(355, 44);
            this.AddProductButton.TabIndex = 2;
            this.AddProductButton.Text = "Dodaj Produkt";
            this.AddProductButton.UseVisualStyleBackColor = true;
            // 
            // finalizationButton
            // 
            this.finalizationButton.Location = new System.Drawing.Point(530, 634);
            this.finalizationButton.Name = "finalizationButton";
            this.finalizationButton.Size = new System.Drawing.Size(449, 36);
            this.finalizationButton.TabIndex = 3;
            this.finalizationButton.Text = "Zapłać";
            this.finalizationButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 220);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BarCodeLabel
            // 
            this.BarCodeLabel.AutoSize = true;
            this.BarCodeLabel.Location = new System.Drawing.Point(8, 24);
            this.BarCodeLabel.Name = "BarCodeLabel";
            this.BarCodeLabel.Size = new System.Drawing.Size(73, 20);
            this.BarCodeLabel.TabIndex = 5;
            this.BarCodeLabel.Text = "Barcode:";
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(12, 146);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(355, 28);
            this.cboCamera.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(530, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 604);
            this.panel1.TabIndex = 8;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.BarCodeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.finalizationButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.barCodeTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "Sklep";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox barCodeTextBox;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button finalizationButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BarCodeLabel;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Panel panel1;
    }
}

