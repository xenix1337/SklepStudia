
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produktyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zarejestrujNowyProduktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // barCodeTextBox
            // 
            this.barCodeTextBox.Location = new System.Drawing.Point(87, 50);
            this.barCodeTextBox.Name = "barCodeTextBox";
            this.barCodeTextBox.Size = new System.Drawing.Size(390, 26);
            this.barCodeTextBox.TabIndex = 1;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(12, 82);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(465, 44);
            this.AddProductButton.TabIndex = 2;
            this.AddProductButton.Text = "Dodaj Produkt";
            this.AddProductButton.UseVisualStyleBackColor = true;
            // 
            // finalizationButton
            // 
            this.finalizationButton.Location = new System.Drawing.Point(530, 601);
            this.finalizationButton.Name = "finalizationButton";
            this.finalizationButton.Size = new System.Drawing.Size(652, 36);
            this.finalizationButton.TabIndex = 3;
            this.finalizationButton.Text = "Zapłać";
            this.finalizationButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 302);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BarCodeLabel
            // 
            this.BarCodeLabel.AutoSize = true;
            this.BarCodeLabel.Location = new System.Drawing.Point(8, 53);
            this.BarCodeLabel.Name = "BarCodeLabel";
            this.BarCodeLabel.Size = new System.Drawing.Size(73, 20);
            this.BarCodeLabel.TabIndex = 5;
            this.BarCodeLabel.Text = "Barcode:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(530, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 526);
            this.panel1.TabIndex = 8;
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.produktyToolStripMenuItem,
            this.raportyToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1194, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // produktyToolStripMenuItem
            // 
            this.produktyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zarejestrujNowyProduktToolStripMenuItem});
            this.produktyToolStripMenuItem.Name = "produktyToolStripMenuItem";
            this.produktyToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.produktyToolStripMenuItem.Text = "Produkty";
            // 
            // zarejestrujNowyProduktToolStripMenuItem
            // 
            this.zarejestrujNowyProduktToolStripMenuItem.Name = "zarejestrujNowyProduktToolStripMenuItem";
            this.zarejestrujNowyProduktToolStripMenuItem.Size = new System.Drawing.Size(312, 34);
            this.zarejestrujNowyProduktToolStripMenuItem.Text = "Zarejestruj nowy produkt";
            this.zarejestrujNowyProduktToolStripMenuItem.Click += new System.EventHandler(this.zarejestrujNowyProduktToolStripMenuItem_Click);
            // 
            // raportyToolStripMenuItem
            // 
            this.raportyToolStripMenuItem.Name = "raportyToolStripMenuItem";
            this.raportyToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.raportyToolStripMenuItem.Text = "Raporty";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 656);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1194, 32);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(243, 25);
            this.statusStripLabel.Text = "Trwa łączenie z bazą danych...";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 688);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarCodeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.finalizationButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.barCodeTextBox);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "Sklep";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox barCodeTextBox;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button finalizationButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BarCodeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produktyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zarejestrujNowyProduktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportyToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
    }
}

