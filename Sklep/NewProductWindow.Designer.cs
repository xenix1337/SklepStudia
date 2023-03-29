
namespace Sklep
{
    partial class NewProductWindow
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
            kodKreskowyTextBox = new System.Windows.Forms.TextBox();
            nazwaKrotkaTextBox = new System.Windows.Forms.TextBox();
            nazwaDlugaTextBox = new System.Windows.Forms.TextBox();
            cenaTextBox = new System.Windows.Forms.TextBox();
            kodKreskowyLabel = new System.Windows.Forms.Label();
            nazwaKrotkaLabel = new System.Windows.Forms.Label();
            nazwaDlugaLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            kategoriaLabel = new System.Windows.Forms.Label();
            kategoriaComboBox = new System.Windows.Forms.ComboBox();
            dostawcaComboBox = new System.Windows.Forms.ComboBox();
            dostawcaLabel = new System.Windows.Forms.Label();
            addProductButton = new System.Windows.Forms.Button();
            scannerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)scannerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // kodKreskowyTextBox
            // 
            kodKreskowyTextBox.Location = new System.Drawing.Point(143, 36);
            kodKreskowyTextBox.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            kodKreskowyTextBox.Name = "kodKreskowyTextBox";
            kodKreskowyTextBox.Size = new System.Drawing.Size(175, 27);
            kodKreskowyTextBox.TabIndex = 0;
            kodKreskowyTextBox.TextChanged += kodKreskowyTextBox_TextChanged;
            // 
            // nazwaKrotkaTextBox
            // 
            nazwaKrotkaTextBox.Location = new System.Drawing.Point(143, 88);
            nazwaKrotkaTextBox.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            nazwaKrotkaTextBox.Name = "nazwaKrotkaTextBox";
            nazwaKrotkaTextBox.Size = new System.Drawing.Size(346, 27);
            nazwaKrotkaTextBox.TabIndex = 2;
            nazwaKrotkaTextBox.TextChanged += nazwaKrotkaTextBox_TextChanged;
            // 
            // nazwaDlugaTextBox
            // 
            nazwaDlugaTextBox.Location = new System.Drawing.Point(143, 140);
            nazwaDlugaTextBox.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            nazwaDlugaTextBox.Name = "nazwaDlugaTextBox";
            nazwaDlugaTextBox.Size = new System.Drawing.Size(346, 27);
            nazwaDlugaTextBox.TabIndex = 3;
            nazwaDlugaTextBox.TextChanged += nazwaDlugaTextBox_TextChanged;
            // 
            // cenaTextBox
            // 
            cenaTextBox.Location = new System.Drawing.Point(143, 192);
            cenaTextBox.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            cenaTextBox.Name = "cenaTextBox";
            cenaTextBox.Size = new System.Drawing.Size(175, 27);
            cenaTextBox.TabIndex = 4;
            cenaTextBox.TextChanged += cenaTextBox_TextChanged;
            // 
            // kodKreskowyLabel
            // 
            kodKreskowyLabel.AutoSize = true;
            kodKreskowyLabel.Location = new System.Drawing.Point(25, 39);
            kodKreskowyLabel.Name = "kodKreskowyLabel";
            kodKreskowyLabel.Size = new System.Drawing.Size(103, 20);
            kodKreskowyLabel.TabIndex = 4;
            kodKreskowyLabel.Text = "Kod kreskowy:";
            // 
            // nazwaKrotkaLabel
            // 
            nazwaKrotkaLabel.AutoSize = true;
            nazwaKrotkaLabel.Location = new System.Drawing.Point(25, 91);
            nazwaKrotkaLabel.Name = "nazwaKrotkaLabel";
            nazwaKrotkaLabel.Size = new System.Drawing.Size(102, 20);
            nazwaKrotkaLabel.TabIndex = 6;
            nazwaKrotkaLabel.Text = "Nazwa krótka:";
            // 
            // nazwaDlugaLabel
            // 
            nazwaDlugaLabel.AutoSize = true;
            nazwaDlugaLabel.Location = new System.Drawing.Point(25, 144);
            nazwaDlugaLabel.Name = "nazwaDlugaLabel";
            nazwaDlugaLabel.Size = new System.Drawing.Size(99, 20);
            nazwaDlugaLabel.TabIndex = 7;
            nazwaDlugaLabel.Text = "Nazwa długa:";
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(25, 196);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(45, 20);
            cenaLabel.TabIndex = 8;
            cenaLabel.Text = "Cena:";
            // 
            // kategoriaLabel
            // 
            kategoriaLabel.AutoSize = true;
            kategoriaLabel.Location = new System.Drawing.Point(25, 249);
            kategoriaLabel.Name = "kategoriaLabel";
            kategoriaLabel.Size = new System.Drawing.Size(77, 20);
            kategoriaLabel.TabIndex = 9;
            kategoriaLabel.Text = "Kategoria:";
            // 
            // kategoriaComboBox
            // 
            kategoriaComboBox.FormattingEnabled = true;
            kategoriaComboBox.Location = new System.Drawing.Point(143, 245);
            kategoriaComboBox.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            kategoriaComboBox.Name = "kategoriaComboBox";
            kategoriaComboBox.Size = new System.Drawing.Size(346, 28);
            kategoriaComboBox.TabIndex = 5;
            // 
            // dostawcaComboBox
            // 
            dostawcaComboBox.FormattingEnabled = true;
            dostawcaComboBox.Location = new System.Drawing.Point(143, 300);
            dostawcaComboBox.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            dostawcaComboBox.Name = "dostawcaComboBox";
            dostawcaComboBox.Size = new System.Drawing.Size(346, 28);
            dostawcaComboBox.TabIndex = 6;
            // 
            // dostawcaLabel
            // 
            dostawcaLabel.AutoSize = true;
            dostawcaLabel.Location = new System.Drawing.Point(25, 304);
            dostawcaLabel.Name = "dostawcaLabel";
            dostawcaLabel.Size = new System.Drawing.Size(77, 20);
            dostawcaLabel.TabIndex = 11;
            dostawcaLabel.Text = "Dostawca:";
            // 
            // addProductButton
            // 
            addProductButton.Location = new System.Drawing.Point(28, 359);
            addProductButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new System.Drawing.Size(461, 52);
            addProductButton.TabIndex = 7;
            addProductButton.Text = "Dodaj produkt";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // scannerPictureBox
            // 
            scannerPictureBox.Location = new System.Drawing.Point(331, 12);
            scannerPictureBox.Name = "scannerPictureBox";
            scannerPictureBox.Size = new System.Drawing.Size(158, 62);
            scannerPictureBox.TabIndex = 12;
            scannerPictureBox.TabStop = false;
            // 
            // NewProductWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(516, 432);
            Controls.Add(scannerPictureBox);
            Controls.Add(addProductButton);
            Controls.Add(dostawcaComboBox);
            Controls.Add(dostawcaLabel);
            Controls.Add(kategoriaComboBox);
            Controls.Add(kategoriaLabel);
            Controls.Add(cenaLabel);
            Controls.Add(nazwaDlugaLabel);
            Controls.Add(nazwaKrotkaLabel);
            Controls.Add(kodKreskowyLabel);
            Controls.Add(cenaTextBox);
            Controls.Add(nazwaDlugaTextBox);
            Controls.Add(nazwaKrotkaTextBox);
            Controls.Add(kodKreskowyTextBox);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "NewProductWindow";
            Text = "Dodawanie produktu";
            FormClosing += NewProductWindow_FormClosing;
            Load += NewProductWindow_Load;
            ((System.ComponentModel.ISupportInitialize)scannerPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox kodKreskowyTextBox;
        private System.Windows.Forms.TextBox nazwaKrotkaTextBox;
        private System.Windows.Forms.TextBox nazwaDlugaTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.Label kodKreskowyLabel;
        private System.Windows.Forms.Label nazwaKrotkaLabel;
        private System.Windows.Forms.Label nazwaDlugaLabel;
        private System.Windows.Forms.Label cenaLabel;
        private System.Windows.Forms.Label kategoriaLabel;
        private System.Windows.Forms.ComboBox kategoriaComboBox;
        private System.Windows.Forms.ComboBox dostawcaComboBox;
        private System.Windows.Forms.Label dostawcaLabel;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.PictureBox scannerPictureBox;
    }
}