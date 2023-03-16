
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
            this.kodKreskowyTextBox = new System.Windows.Forms.TextBox();
            this.nazwaKrotkaTextBox = new System.Windows.Forms.TextBox();
            this.nazwaDlugaTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.kodKreskowyLabel = new System.Windows.Forms.Label();
            this.scanCodeButton = new System.Windows.Forms.Button();
            this.nazwaKrotkaLabel = new System.Windows.Forms.Label();
            this.nazwaDlugaLabel = new System.Windows.Forms.Label();
            this.cenaLabel = new System.Windows.Forms.Label();
            this.kategoriaLabel = new System.Windows.Forms.Label();
            this.kategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.dostawcaComboBox = new System.Windows.Forms.ComboBox();
            this.dostawcaLabel = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kodKreskowyTextBox
            // 
            this.kodKreskowyTextBox.Location = new System.Drawing.Point(143, 29);
            this.kodKreskowyTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.kodKreskowyTextBox.Name = "kodKreskowyTextBox";
            this.kodKreskowyTextBox.Size = new System.Drawing.Size(175, 22);
            this.kodKreskowyTextBox.TabIndex = 0;
            this.kodKreskowyTextBox.TextChanged += new System.EventHandler(this.kodKreskowyTextBox_TextChanged);
            // 
            // nazwaKrotkaTextBox
            // 
            this.nazwaKrotkaTextBox.Location = new System.Drawing.Point(143, 70);
            this.nazwaKrotkaTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.nazwaKrotkaTextBox.Name = "nazwaKrotkaTextBox";
            this.nazwaKrotkaTextBox.Size = new System.Drawing.Size(346, 22);
            this.nazwaKrotkaTextBox.TabIndex = 2;
            this.nazwaKrotkaTextBox.TextChanged += new System.EventHandler(this.nazwaKrotkaTextBox_TextChanged);
            // 
            // nazwaDlugaTextBox
            // 
            this.nazwaDlugaTextBox.Location = new System.Drawing.Point(143, 112);
            this.nazwaDlugaTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.nazwaDlugaTextBox.Name = "nazwaDlugaTextBox";
            this.nazwaDlugaTextBox.Size = new System.Drawing.Size(346, 22);
            this.nazwaDlugaTextBox.TabIndex = 3;
            this.nazwaDlugaTextBox.TextChanged += new System.EventHandler(this.nazwaDlugaTextBox_TextChanged);
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.Location = new System.Drawing.Point(143, 154);
            this.cenaTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(175, 22);
            this.cenaTextBox.TabIndex = 4;
            this.cenaTextBox.TextChanged += new System.EventHandler(this.cenaTextBox_TextChanged);
            // 
            // kodKreskowyLabel
            // 
            this.kodKreskowyLabel.AutoSize = true;
            this.kodKreskowyLabel.Location = new System.Drawing.Point(25, 31);
            this.kodKreskowyLabel.Name = "kodKreskowyLabel";
            this.kodKreskowyLabel.Size = new System.Drawing.Size(99, 17);
            this.kodKreskowyLabel.TabIndex = 4;
            this.kodKreskowyLabel.Text = "Kod kreskowy:";
            // 
            // scanCodeButton
            // 
            this.scanCodeButton.Location = new System.Drawing.Point(324, 25);
            this.scanCodeButton.Name = "scanCodeButton";
            this.scanCodeButton.Size = new System.Drawing.Size(165, 29);
            this.scanCodeButton.TabIndex = 1;
            this.scanCodeButton.Text = "Skanuj";
            this.scanCodeButton.UseVisualStyleBackColor = true;
            // 
            // nazwaKrotkaLabel
            // 
            this.nazwaKrotkaLabel.AutoSize = true;
            this.nazwaKrotkaLabel.Location = new System.Drawing.Point(25, 73);
            this.nazwaKrotkaLabel.Name = "nazwaKrotkaLabel";
            this.nazwaKrotkaLabel.Size = new System.Drawing.Size(97, 17);
            this.nazwaKrotkaLabel.TabIndex = 6;
            this.nazwaKrotkaLabel.Text = "Nazwa krótka:";
            // 
            // nazwaDlugaLabel
            // 
            this.nazwaDlugaLabel.AutoSize = true;
            this.nazwaDlugaLabel.Location = new System.Drawing.Point(25, 115);
            this.nazwaDlugaLabel.Name = "nazwaDlugaLabel";
            this.nazwaDlugaLabel.Size = new System.Drawing.Size(93, 17);
            this.nazwaDlugaLabel.TabIndex = 7;
            this.nazwaDlugaLabel.Text = "Nazwa długa:";
            // 
            // cenaLabel
            // 
            this.cenaLabel.AutoSize = true;
            this.cenaLabel.Location = new System.Drawing.Point(25, 157);
            this.cenaLabel.Name = "cenaLabel";
            this.cenaLabel.Size = new System.Drawing.Size(45, 17);
            this.cenaLabel.TabIndex = 8;
            this.cenaLabel.Text = "Cena:";
            // 
            // kategoriaLabel
            // 
            this.kategoriaLabel.AutoSize = true;
            this.kategoriaLabel.Location = new System.Drawing.Point(25, 199);
            this.kategoriaLabel.Name = "kategoriaLabel";
            this.kategoriaLabel.Size = new System.Drawing.Size(73, 17);
            this.kategoriaLabel.TabIndex = 9;
            this.kategoriaLabel.Text = "Kategoria:";
            // 
            // kategoriaComboBox
            // 
            this.kategoriaComboBox.FormattingEnabled = true;
            this.kategoriaComboBox.Location = new System.Drawing.Point(143, 196);
            this.kategoriaComboBox.Margin = new System.Windows.Forms.Padding(10);
            this.kategoriaComboBox.Name = "kategoriaComboBox";
            this.kategoriaComboBox.Size = new System.Drawing.Size(346, 24);
            this.kategoriaComboBox.TabIndex = 5;
            // 
            // dostawcaComboBox
            // 
            this.dostawcaComboBox.FormattingEnabled = true;
            this.dostawcaComboBox.Location = new System.Drawing.Point(143, 240);
            this.dostawcaComboBox.Margin = new System.Windows.Forms.Padding(10);
            this.dostawcaComboBox.Name = "dostawcaComboBox";
            this.dostawcaComboBox.Size = new System.Drawing.Size(346, 24);
            this.dostawcaComboBox.TabIndex = 6;
            // 
            // dostawcaLabel
            // 
            this.dostawcaLabel.AutoSize = true;
            this.dostawcaLabel.Location = new System.Drawing.Point(25, 243);
            this.dostawcaLabel.Name = "dostawcaLabel";
            this.dostawcaLabel.Size = new System.Drawing.Size(73, 17);
            this.dostawcaLabel.TabIndex = 11;
            this.dostawcaLabel.Text = "Dostawca:";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(28, 287);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(461, 42);
            this.addProductButton.TabIndex = 7;
            this.addProductButton.Text = "Dodaj produkt";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // NewProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 346);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.dostawcaComboBox);
            this.Controls.Add(this.dostawcaLabel);
            this.Controls.Add(this.kategoriaComboBox);
            this.Controls.Add(this.kategoriaLabel);
            this.Controls.Add(this.cenaLabel);
            this.Controls.Add(this.nazwaDlugaLabel);
            this.Controls.Add(this.nazwaKrotkaLabel);
            this.Controls.Add(this.scanCodeButton);
            this.Controls.Add(this.kodKreskowyLabel);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(this.nazwaDlugaTextBox);
            this.Controls.Add(this.nazwaKrotkaTextBox);
            this.Controls.Add(this.kodKreskowyTextBox);
            this.Name = "NewProductWindow";
            this.Text = "Dodawanie produktu";
            this.Load += new System.EventHandler(this.NewProductWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kodKreskowyTextBox;
        private System.Windows.Forms.TextBox nazwaKrotkaTextBox;
        private System.Windows.Forms.TextBox nazwaDlugaTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.Label kodKreskowyLabel;
        private System.Windows.Forms.Button scanCodeButton;
        private System.Windows.Forms.Label nazwaKrotkaLabel;
        private System.Windows.Forms.Label nazwaDlugaLabel;
        private System.Windows.Forms.Label cenaLabel;
        private System.Windows.Forms.Label kategoriaLabel;
        private System.Windows.Forms.ComboBox kategoriaComboBox;
        private System.Windows.Forms.ComboBox dostawcaComboBox;
        private System.Windows.Forms.Label dostawcaLabel;
        private System.Windows.Forms.Button addProductButton;
    }
}