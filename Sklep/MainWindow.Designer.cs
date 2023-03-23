
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
            barCodeTextBox = new System.Windows.Forms.TextBox();
            AddProductButton = new System.Windows.Forms.Button();
            finalizationButton = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            BarCodeLabel = new System.Windows.Forms.Label();
            menuStrip = new System.Windows.Forms.MenuStrip();
            programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            produktyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            zarejestrujNowyProduktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            raportyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip = new System.Windows.Forms.StatusStrip();
            statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // barCodeTextBox
            // 
            barCodeTextBox.Location = new System.Drawing.Point(77, 50);
            barCodeTextBox.Name = "barCodeTextBox";
            barCodeTextBox.Size = new System.Drawing.Size(347, 27);
            barCodeTextBox.TabIndex = 1;
            // 
            // AddProductButton
            // 
            AddProductButton.Location = new System.Drawing.Point(11, 82);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new System.Drawing.Size(413, 44);
            AddProductButton.TabIndex = 2;
            AddProductButton.Text = "Dodaj Produkt";
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // finalizationButton
            // 
            finalizationButton.Location = new System.Drawing.Point(471, 601);
            finalizationButton.Name = "finalizationButton";
            finalizationButton.Size = new System.Drawing.Size(580, 36);
            finalizationButton.TabIndex = 3;
            finalizationButton.Text = "Zapłać";
            finalizationButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(11, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(413, 302);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // BarCodeLabel
            // 
            BarCodeLabel.AutoSize = true;
            BarCodeLabel.Location = new System.Drawing.Point(7, 53);
            BarCodeLabel.Name = "BarCodeLabel";
            BarCodeLabel.Size = new System.Drawing.Size(67, 20);
            BarCodeLabel.TabIndex = 5;
            BarCodeLabel.Text = "Barcode:";
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { programToolStripMenuItem, produktyToolStripMenuItem, raportyToolStripMenuItem });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            menuStrip.Size = new System.Drawing.Size(1061, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            programToolStripMenuItem.Text = "Program";
            // 
            // produktyToolStripMenuItem
            // 
            produktyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { zarejestrujNowyProduktToolStripMenuItem });
            produktyToolStripMenuItem.Name = "produktyToolStripMenuItem";
            produktyToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            produktyToolStripMenuItem.Text = "Produkty";
            // 
            // zarejestrujNowyProduktToolStripMenuItem
            // 
            zarejestrujNowyProduktToolStripMenuItem.Name = "zarejestrujNowyProduktToolStripMenuItem";
            zarejestrujNowyProduktToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            zarejestrujNowyProduktToolStripMenuItem.Text = "Zarejestruj nowy produkt";
            zarejestrujNowyProduktToolStripMenuItem.Click += zarejestrujNowyProduktToolStripMenuItem_Click;
            // 
            // raportyToolStripMenuItem
            // 
            raportyToolStripMenuItem.Name = "raportyToolStripMenuItem";
            raportyToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            raportyToolStripMenuItem.Text = "Raporty";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusStripLabel });
            statusStrip.Location = new System.Drawing.Point(0, 662);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            statusStrip.Size = new System.Drawing.Size(1061, 26);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            statusStripLabel.Name = "statusStripLabel";
            statusStripLabel.Size = new System.Drawing.Size(205, 20);
            statusStripLabel.Text = "Trwa łączenie z bazą danych...";
            // 
            // listView1
            // 
            listView1.Location = new System.Drawing.Point(471, 50);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(580, 532);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1061, 688);
            Controls.Add(listView1);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Controls.Add(BarCodeLabel);
            Controls.Add(pictureBox1);
            Controls.Add(finalizationButton);
            Controls.Add(AddProductButton);
            Controls.Add(barCodeTextBox);
            MainMenuStrip = menuStrip;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainWindow";
            Text = "Sklep";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox barCodeTextBox;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button finalizationButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BarCodeLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produktyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zarejestrujNowyProduktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportyToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.ListView listView1;
    }
}

