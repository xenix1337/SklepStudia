
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
            components = new System.ComponentModel.Container();
            barCodeTextBox = new System.Windows.Forms.TextBox();
            AddProductButton = new System.Windows.Forms.Button();
            finalizationButton = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            BarCodeLabel = new System.Windows.Forms.Label();
            menuStrip = new System.Windows.Forms.MenuStrip();
            programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            produktyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            zarejestrujNowyProduktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listaProduktówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            zarejestrujGrupęProduktówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listaGrupProduktówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            raportyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            inwenatrzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            stanMagazynuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            historiaZmianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            changeStateToolStipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip = new System.Windows.Forms.StatusStrip();
            statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            barcodeScannerBindingSource = new System.Windows.Forms.BindingSource(components);
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            listOfProducts = new System.Windows.Forms.FlowLayoutPanel();
            sumLabel = new System.Windows.Forms.Label();
            sumOfProductPricesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)barcodeScannerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // barCodeTextBox
            // 
            barCodeTextBox.Location = new System.Drawing.Point(77, 50);
            barCodeTextBox.Name = "barCodeTextBox";
            barCodeTextBox.Size = new System.Drawing.Size(347, 27);
            barCodeTextBox.TabIndex = 1;
            barCodeTextBox.KeyDown += AddProductButton_KeyDown;
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
            finalizationButton.Click += finalizationButton_Click;
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
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { programToolStripMenuItem, produktyToolStripMenuItem, raportyToolStripMenuItem, inwenatrzToolStripMenuItem });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            menuStrip.Size = new System.Drawing.Size(1061, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ustawieniaToolStripMenuItem });
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            programToolStripMenuItem.Text = "Program";
            // 
            // ustawieniaToolStripMenuItem
            // 
            ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            ustawieniaToolStripMenuItem.Text = "Ustawienia";
            ustawieniaToolStripMenuItem.Click += ustawieniaToolStripMenuItem_Click;
            // 
            // produktyToolStripMenuItem
            // 
            produktyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { zarejestrujNowyProduktToolStripMenuItem, listaProduktówToolStripMenuItem, zarejestrujGrupęProduktówToolStripMenuItem, listaGrupProduktówToolStripMenuItem });
            produktyToolStripMenuItem.Name = "produktyToolStripMenuItem";
            produktyToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            produktyToolStripMenuItem.Text = "Produkty";
            // 
            // zarejestrujNowyProduktToolStripMenuItem
            // 
            zarejestrujNowyProduktToolStripMenuItem.Name = "zarejestrujNowyProduktToolStripMenuItem";
            zarejestrujNowyProduktToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            zarejestrujNowyProduktToolStripMenuItem.Text = "Zarejestruj nowy produkt";
            zarejestrujNowyProduktToolStripMenuItem.Click += zarejestrujNowyProduktToolStripMenuItem_Click;
            // 
            // listaProduktówToolStripMenuItem
            // 
            listaProduktówToolStripMenuItem.Name = "listaProduktówToolStripMenuItem";
            listaProduktówToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            listaProduktówToolStripMenuItem.Text = "Lista produktów";
            listaProduktówToolStripMenuItem.Click += listaProduktówToolStripMenuItem_Click;
            // 
            // zarejestrujGrupęProduktówToolStripMenuItem
            // 
            zarejestrujGrupęProduktówToolStripMenuItem.Name = "zarejestrujGrupęProduktówToolStripMenuItem";
            zarejestrujGrupęProduktówToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            zarejestrujGrupęProduktówToolStripMenuItem.Text = "Zarejestruj grupę produktów";
            zarejestrujGrupęProduktówToolStripMenuItem.Click += zarejestrujGrupęProduktówToolStripMenuItem_Click;
            // 
            // listaGrupProduktówToolStripMenuItem
            // 
            listaGrupProduktówToolStripMenuItem.Name = "listaGrupProduktówToolStripMenuItem";
            listaGrupProduktówToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            listaGrupProduktówToolStripMenuItem.Text = "Lista grup produktów";
            listaGrupProduktówToolStripMenuItem.Click += listaGrupProduktówToolStripMenuItem_Click;
            // 
            // raportyToolStripMenuItem
            // 
            raportyToolStripMenuItem.Name = "raportyToolStripMenuItem";
            raportyToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            raportyToolStripMenuItem.Text = "Raporty";
            // 
            // inwenatrzToolStripMenuItem
            // 
            inwenatrzToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { stanMagazynuToolStripMenuItem, historiaZmianToolStripMenuItem, changeStateToolStipMenuItem });
            inwenatrzToolStripMenuItem.Name = "inwenatrzToolStripMenuItem";
            inwenatrzToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            inwenatrzToolStripMenuItem.Text = "Inwentarz";
            inwenatrzToolStripMenuItem.Click += inwentarzToolStripMenuItem_Click;
            // 
            // stanMagazynuToolStripMenuItem
            // 
            stanMagazynuToolStripMenuItem.Name = "stanMagazynuToolStripMenuItem";
            stanMagazynuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            stanMagazynuToolStripMenuItem.Text = "Stan magazynu";
            stanMagazynuToolStripMenuItem.Click += stanMagazynuToolStripMenuItem_Click;
            // 
            // historiaZmianToolStripMenuItem
            // 
            historiaZmianToolStripMenuItem.Name = "historiaZmianToolStripMenuItem";
            historiaZmianToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            historiaZmianToolStripMenuItem.Text = "Historia zmian";
            historiaZmianToolStripMenuItem.Click += historiaZmianToolStripMenuItem_Click;
            // 
            // changeStateToolStipMenuItem
            // 
            changeStateToolStipMenuItem.Name = "changeStateToolStipMenuItem";
            changeStateToolStipMenuItem.Size = new System.Drawing.Size(224, 26);
            changeStateToolStipMenuItem.Text = "Wprowadź zmianę";
            changeStateToolStipMenuItem.Click += changeStateToolStipMenuItem_Click;
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
            // barcodeScannerBindingSource
            // 
            barcodeScannerBindingSource.DataSource = typeof(Utils.BarcodeScanner);
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listOfProducts
            // 
            listOfProducts.Location = new System.Drawing.Point(471, 50);
            listOfProducts.Name = "listOfProducts";
            listOfProducts.Size = new System.Drawing.Size(580, 501);
            listOfProducts.TabIndex = 6;
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Location = new System.Drawing.Point(471, 554);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new System.Drawing.Size(57, 20);
            sumLabel.TabIndex = 0;
            sumLabel.Text = "SUMA: ";
            // 
            // sumOfProductPricesLabel
            // 
            sumOfProductPricesLabel.Location = new System.Drawing.Point(552, 554);
            sumOfProductPricesLabel.Name = "sumOfProductPricesLabel";
            sumOfProductPricesLabel.Size = new System.Drawing.Size(497, 20);
            sumOfProductPricesLabel.TabIndex = 7;
            sumOfProductPricesLabel.Text = "0 PLN";
            sumOfProductPricesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1061, 688);
            Controls.Add(sumOfProductPricesLabel);
            Controls.Add(sumLabel);
            Controls.Add(listOfProducts);
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
            ((System.ComponentModel.ISupportInitialize)barcodeScannerBindingSource).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem listaProduktówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zarejestrujGrupęProduktówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaGrupProduktówToolStripMenuItem;
        private System.Windows.Forms.BindingSource barcodeScannerBindingSource;
        private ReceiptPosition receiptPosition1;
        private System.CodeDom.CodeTypeReference receiptPosition2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel listOfProducts;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label sumOfProductPricesLabel;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inwenatrzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stanMagazynuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaZmianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeStateToolStipMenuItem;
    }
}

