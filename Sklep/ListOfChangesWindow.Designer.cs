namespace Sklep
{
    partial class ListOfChangesWindow
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
            changesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)changesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // changesDataGridView
            // 
            changesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            changesDataGridView.Location = new System.Drawing.Point(0, 0);
            changesDataGridView.Name = "changesDataGridView";
            changesDataGridView.RowHeadersWidth = 51;
            changesDataGridView.RowTemplate.Height = 29;
            changesDataGridView.Size = new System.Drawing.Size(1134, 567);
            changesDataGridView.TabIndex = 0;
            // 
            // ListOfChangesWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1131, 567);
            Controls.Add(changesDataGridView);
            Name = "ListOfChangesWindow";
            Text = "ListOfChangesWindow";
            Load += ListOfChangesWindow_Load;
            ((System.ComponentModel.ISupportInitialize)changesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView changesDataGridView;
    }
}