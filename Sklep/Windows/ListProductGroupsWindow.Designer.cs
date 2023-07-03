namespace Sklep
{
    partial class ListProductGroupsWindow
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
            productDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            SuspendLayout();
            // 
            // productDataGridView
            // 
            productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            productDataGridView.Location = new System.Drawing.Point(0, 0);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.RowHeadersWidth = 20;
            productDataGridView.RowTemplate.Height = 29;
            productDataGridView.Size = new System.Drawing.Size(958, 684);
            productDataGridView.TabIndex = 0;
            productDataGridView.CellValueChanged += productDataGridView_CellValueChanged;
            // 
            // ListProductsWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(958, 684);
            Controls.Add(productDataGridView);
            Name = "ListProductsWindow";
            Text = "Lista produktów";
            FormClosing += ListProductsWindow_FormClosing;
            Load += ListProductGroupsWindow_Load;
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView productDataGridView;
    }
}