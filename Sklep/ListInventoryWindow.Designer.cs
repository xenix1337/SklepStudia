namespace Sklep
{
    partial class ListInventoryWindow
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
            components = new System.ComponentModel.Container();
            inventoryPositionBindingSource = new System.Windows.Forms.BindingSource(components);
            inventoryDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)inventoryPositionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // inventoryPositionBindingSource
            // 
            inventoryPositionBindingSource.DataSource = typeof(Database.Models.InventoryPosition);
            // 
            // inventoryDataGridView
            // 
            inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryDataGridView.Location = new System.Drawing.Point(0, 0);
            inventoryDataGridView.Name = "inventoryDataGridView";
            inventoryDataGridView.RowHeadersWidth = 51;
            inventoryDataGridView.RowTemplate.Height = 29;
            inventoryDataGridView.Size = new System.Drawing.Size(803, 451);
            inventoryDataGridView.TabIndex = 0;
            // 
            // ListInventoryWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(inventoryDataGridView);
            Name = "ListInventoryWindow";
            Text = "ListInventoryWindow";
            Load += ListInventoryWindow_Load;
            ((System.ComponentModel.ISupportInitialize)inventoryPositionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.BindingSource inventoryPositionBindingSource;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
    }
}