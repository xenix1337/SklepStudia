namespace Sklep
{
    partial class FinalizationDialogForm
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
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            headerLabel = new System.Windows.Forms.Label();
            acceptCashButton = new System.Windows.Forms.Button();
            exitDialogButton = new System.Windows.Forms.Button();
            cancelCartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new System.Drawing.Point(12, 82);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(438, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            headerLabel.Location = new System.Drawing.Point(32, 22);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new System.Drawing.Size(382, 32);
            headerLabel.TabIndex = 4;
            headerLabel.Text = "Wpisz kwotę podaną przez klienta:";
            // 
            // acceptCashButton
            // 
            acceptCashButton.Location = new System.Drawing.Point(12, 172);
            acceptCashButton.Name = "acceptCashButton";
            acceptCashButton.Size = new System.Drawing.Size(119, 55);
            acceptCashButton.TabIndex = 5;
            acceptCashButton.Text = "Zaakceptuj";
            acceptCashButton.UseVisualStyleBackColor = true;
            acceptCashButton.Click += acceptCashButton_Click;
            // 
            // exitDialogButton
            // 
            exitDialogButton.Location = new System.Drawing.Point(169, 172);
            exitDialogButton.Name = "exitDialogButton";
            exitDialogButton.Size = new System.Drawing.Size(119, 55);
            exitDialogButton.TabIndex = 6;
            exitDialogButton.Text = "Cofnij";
            exitDialogButton.UseVisualStyleBackColor = true;
            exitDialogButton.Click += exitDialogButton_Click;
            // 
            // cancelCartButton
            // 
            cancelCartButton.Location = new System.Drawing.Point(331, 172);
            cancelCartButton.Name = "cancelCartButton";
            cancelCartButton.Size = new System.Drawing.Size(119, 55);
            cancelCartButton.TabIndex = 7;
            cancelCartButton.Text = "Anuluj zakupy";
            cancelCartButton.UseVisualStyleBackColor = true;
            cancelCartButton.Click += cancelCartButton_Click;
            // 
            // InputDialogBox
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(462, 249);
            Controls.Add(cancelCartButton);
            Controls.Add(exitDialogButton);
            Controls.Add(acceptCashButton);
            Controls.Add(headerLabel);
            Controls.Add(numericUpDown1);
            Name = "InputDialogBox";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "InputDialogBox";
            Load += InputDialogBox_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acceptCashButton;
        private System.Windows.Forms.Button exitDialogButton;
        private System.Windows.Forms.Button cancelCartButton;
        private System.Windows.Forms.Label headerLabel;
    }
}