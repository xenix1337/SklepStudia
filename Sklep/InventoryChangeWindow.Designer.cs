namespace Sklep
{
    partial class InventoryChangeWindow
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
            iloscNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ConfirmButton = new System.Windows.Forms.Button();
            cenaLabel = new System.Windows.Forms.Label();
            kodKreskowyLabel = new System.Windows.Forms.Label();
            kodKreskowyProduktuTextBox = new System.Windows.Forms.TextBox();
            typeLabel = new System.Windows.Forms.Label();
            changeTypeComboBox = new System.Windows.Forms.ComboBox();
            scannerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)iloscNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scannerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // iloscNumericUpDown
            // 
            iloscNumericUpDown.Location = new System.Drawing.Point(194, 225);
            iloscNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            iloscNumericUpDown.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            iloscNumericUpDown.Name = "iloscNumericUpDown";
            iloscNumericUpDown.Size = new System.Drawing.Size(282, 27);
            iloscNumericUpDown.TabIndex = 20;
            iloscNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new System.Drawing.Point(12, 295);
            ConfirmButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new System.Drawing.Size(461, 52);
            ConfirmButton.TabIndex = 18;
            ConfirmButton.Text = "Potwierdź";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(12, 232);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(42, 20);
            cenaLabel.TabIndex = 19;
            cenaLabel.Text = "Ilość:";
            // 
            // kodKreskowyLabel
            // 
            kodKreskowyLabel.AutoSize = true;
            kodKreskowyLabel.Location = new System.Drawing.Point(12, 130);
            kodKreskowyLabel.Name = "kodKreskowyLabel";
            kodKreskowyLabel.Size = new System.Drawing.Size(164, 20);
            kodKreskowyLabel.TabIndex = 16;
            kodKreskowyLabel.Text = "Kod kreskowy produktu";
            // 
            // kodKreskowyProduktuTextBox
            // 
            kodKreskowyProduktuTextBox.Location = new System.Drawing.Point(194, 127);
            kodKreskowyProduktuTextBox.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            kodKreskowyProduktuTextBox.Name = "kodKreskowyProduktuTextBox";
            kodKreskowyProduktuTextBox.Size = new System.Drawing.Size(279, 27);
            kodKreskowyProduktuTextBox.TabIndex = 14;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(12, 179);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(103, 20);
            typeLabel.TabIndex = 21;
            typeLabel.Text = "Typ zdarzenia:";
            // 
            // changeTypeComboBox
            // 
            changeTypeComboBox.FormattingEnabled = true;
            changeTypeComboBox.Location = new System.Drawing.Point(194, 176);
            changeTypeComboBox.Name = "changeTypeComboBox";
            changeTypeComboBox.Size = new System.Drawing.Size(279, 28);
            changeTypeComboBox.TabIndex = 22;
            // 
            // scannerPictureBox
            // 
            scannerPictureBox.Location = new System.Drawing.Point(12, 12);
            scannerPictureBox.Name = "scannerPictureBox";
            scannerPictureBox.Size = new System.Drawing.Size(461, 84);
            scannerPictureBox.TabIndex = 23;
            scannerPictureBox.TabStop = false;
            // 
            // InventoryChangeWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(501, 396);
            Controls.Add(scannerPictureBox);
            Controls.Add(changeTypeComboBox);
            Controls.Add(typeLabel);
            Controls.Add(iloscNumericUpDown);
            Controls.Add(ConfirmButton);
            Controls.Add(cenaLabel);
            Controls.Add(kodKreskowyLabel);
            Controls.Add(kodKreskowyProduktuTextBox);
            Name = "InventoryChangeWindow";
            Text = "InventoryChangeForm";
            Load += InventoryChangeForm_Load;
            ((System.ComponentModel.ISupportInitialize)iloscNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)scannerPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown iloscNumericUpDown;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label cenaLabel;
        private System.Windows.Forms.Label kodKreskowyLabel;
        private System.Windows.Forms.TextBox kodKreskowyProduktuTextBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox changeTypeComboBox;
        private System.Windows.Forms.PictureBox scannerPictureBox;
    }
}