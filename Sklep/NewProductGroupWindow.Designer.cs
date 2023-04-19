
namespace Sklep
{
    partial class NewProductGroupWindow
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
            kodKreskowyGrupyTextBox = new System.Windows.Forms.TextBox();
            kodKreskowyProduktuTextBox = new System.Windows.Forms.TextBox();
            kodKreskowyLabel = new System.Windows.Forms.Label();
            nazwaKrotkaLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            addProductGroupButton = new System.Windows.Forms.Button();
            scannerPictureBox = new System.Windows.Forms.PictureBox();
            iloscNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)scannerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iloscNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // kodKreskowyGrupyTextBox
            // 
            kodKreskowyGrupyTextBox.Location = new System.Drawing.Point(213, 89);
            kodKreskowyGrupyTextBox.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            kodKreskowyGrupyTextBox.Name = "kodKreskowyGrupyTextBox";
            kodKreskowyGrupyTextBox.Size = new System.Drawing.Size(279, 27);
            kodKreskowyGrupyTextBox.TabIndex = 0;
            kodKreskowyGrupyTextBox.TextChanged += kodKreskowyGrupyTextBox_TextChanged;
            // 
            // kodKreskowyProduktuTextBox
            // 
            kodKreskowyProduktuTextBox.Location = new System.Drawing.Point(213, 141);
            kodKreskowyProduktuTextBox.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            kodKreskowyProduktuTextBox.Name = "kodKreskowyProduktuTextBox";
            kodKreskowyProduktuTextBox.Size = new System.Drawing.Size(282, 27);
            kodKreskowyProduktuTextBox.TabIndex = 2;
            kodKreskowyProduktuTextBox.TextChanged += kodKreskowyProduktuTextBox_TextChanged;
            // 
            // kodKreskowyLabel
            // 
            kodKreskowyLabel.AutoSize = true;
            kodKreskowyLabel.Location = new System.Drawing.Point(31, 92);
            kodKreskowyLabel.Name = "kodKreskowyLabel";
            kodKreskowyLabel.Size = new System.Drawing.Size(145, 20);
            kodKreskowyLabel.TabIndex = 4;
            kodKreskowyLabel.Text = "Kod kreskowy grupy:";
            // 
            // nazwaKrotkaLabel
            // 
            nazwaKrotkaLabel.AutoSize = true;
            nazwaKrotkaLabel.Location = new System.Drawing.Point(31, 144);
            nazwaKrotkaLabel.Name = "nazwaKrotkaLabel";
            nazwaKrotkaLabel.Size = new System.Drawing.Size(167, 20);
            nazwaKrotkaLabel.TabIndex = 6;
            nazwaKrotkaLabel.Text = "Kod kreskowy produktu:";
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(31, 196);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(42, 20);
            cenaLabel.TabIndex = 8;
            cenaLabel.Text = "Ilość:";
            // 
            // addProductGroupButton
            // 
            addProductGroupButton.Location = new System.Drawing.Point(31, 235);
            addProductGroupButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            addProductGroupButton.Name = "addProductGroupButton";
            addProductGroupButton.Size = new System.Drawing.Size(461, 52);
            addProductGroupButton.TabIndex = 7;
            addProductGroupButton.Text = "Dodaj grupę produktów";
            addProductGroupButton.UseVisualStyleBackColor = true;
            addProductGroupButton.Click += addProductGroupButton_Click;
            // 
            // scannerPictureBox
            // 
            scannerPictureBox.Location = new System.Drawing.Point(31, 12);
            scannerPictureBox.Name = "scannerPictureBox";
            scannerPictureBox.Size = new System.Drawing.Size(464, 62);
            scannerPictureBox.TabIndex = 12;
            scannerPictureBox.TabStop = false;
            // 
            // iloscNumericUpDown
            // 
            iloscNumericUpDown.Location = new System.Drawing.Point(213, 189);
            iloscNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            iloscNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            iloscNumericUpDown.Name = "iloscNumericUpDown";
            iloscNumericUpDown.Size = new System.Drawing.Size(150, 27);
            iloscNumericUpDown.TabIndex = 13;
            iloscNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NewProductGroupWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(516, 300);
            Controls.Add(iloscNumericUpDown);
            Controls.Add(scannerPictureBox);
            Controls.Add(addProductGroupButton);
            Controls.Add(cenaLabel);
            Controls.Add(nazwaKrotkaLabel);
            Controls.Add(kodKreskowyLabel);
            Controls.Add(kodKreskowyProduktuTextBox);
            Controls.Add(kodKreskowyGrupyTextBox);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "NewProductGroupWindow";
            Text = "Dodawanie grup produktów";
            FormClosing += NewProductWindow_FormClosing;
            Load += NewProductWindow_Load;
            ((System.ComponentModel.ISupportInitialize)scannerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)iloscNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox kodKreskowyGrupyTextBox;
        private System.Windows.Forms.TextBox kodKreskowyProduktuTextBox;
        private System.Windows.Forms.TextBox nazwaDlugaTextBox;
        private System.Windows.Forms.Label kodKreskowyLabel;
        private System.Windows.Forms.Label nazwaKrotkaLabel;
        private System.Windows.Forms.Label nazwaDlugaLabel;
        private System.Windows.Forms.Label cenaLabel;
        private System.Windows.Forms.Label kategoriaLabel;
        private System.Windows.Forms.ComboBox kategoriaComboBox;
        private System.Windows.Forms.ComboBox dostawcaComboBox;
        private System.Windows.Forms.Label dostawcaLabel;
        private System.Windows.Forms.Button addProductGroupButton;
        private System.Windows.Forms.PictureBox scannerPictureBox;
        private System.Windows.Forms.NumericUpDown iloscNumericUpDown;
    }
}