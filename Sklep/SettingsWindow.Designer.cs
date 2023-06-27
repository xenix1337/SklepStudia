namespace Sklep
{
    partial class SettingsWindow
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
            tabControl1 = new System.Windows.Forms.TabControl();
            paragonyTabPage = new System.Windows.Forms.TabPage();
            label2 = new System.Windows.Forms.Label();
            stopkaTextBox = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            naglowekTextBox = new System.Windows.Forms.RichTextBox();
            serwerTabPage = new System.Windows.Forms.TabPage();
            portTextBox = new System.Windows.Forms.TextBox();
            ipTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            applyButton = new System.Windows.Forms.Button();
            tabControl1.SuspendLayout();
            paragonyTabPage.SuspendLayout();
            serwerTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(paragonyTabPage);
            tabControl1.Controls.Add(serwerTabPage);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(611, 427);
            tabControl1.TabIndex = 0;
            // 
            // paragonyTabPage
            // 
            paragonyTabPage.Controls.Add(label2);
            paragonyTabPage.Controls.Add(stopkaTextBox);
            paragonyTabPage.Controls.Add(label1);
            paragonyTabPage.Controls.Add(naglowekTextBox);
            paragonyTabPage.Location = new System.Drawing.Point(4, 29);
            paragonyTabPage.Name = "paragonyTabPage";
            paragonyTabPage.Padding = new System.Windows.Forms.Padding(3);
            paragonyTabPage.Size = new System.Drawing.Size(603, 394);
            paragonyTabPage.TabIndex = 0;
            paragonyTabPage.Text = "Paragony";
            paragonyTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 197);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(123, 20);
            label2.TabIndex = 3;
            label2.Text = "Stopka paragonu";
            // 
            // stopkaTextBox
            // 
            stopkaTextBox.Location = new System.Drawing.Point(10, 220);
            stopkaTextBox.Name = "stopkaTextBox";
            stopkaTextBox.Size = new System.Drawing.Size(585, 149);
            stopkaTextBox.TabIndex = 2;
            stopkaTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(144, 20);
            label1.TabIndex = 1;
            label1.Text = "Nagłówek paragonu";
            // 
            // naglowekTextBox
            // 
            naglowekTextBox.Location = new System.Drawing.Point(10, 36);
            naglowekTextBox.Name = "naglowekTextBox";
            naglowekTextBox.Size = new System.Drawing.Size(585, 149);
            naglowekTextBox.TabIndex = 0;
            naglowekTextBox.Text = "";
            // 
            // serwerTabPage
            // 
            serwerTabPage.Controls.Add(portTextBox);
            serwerTabPage.Controls.Add(ipTextBox);
            serwerTabPage.Controls.Add(label4);
            serwerTabPage.Controls.Add(label3);
            serwerTabPage.Location = new System.Drawing.Point(4, 29);
            serwerTabPage.Name = "serwerTabPage";
            serwerTabPage.Padding = new System.Windows.Forms.Padding(3);
            serwerTabPage.Size = new System.Drawing.Size(603, 394);
            serwerTabPage.TabIndex = 1;
            serwerTabPage.Text = "Serwer";
            serwerTabPage.UseVisualStyleBackColor = true;
            // 
            // portTextBox
            // 
            portTextBox.Location = new System.Drawing.Point(139, 49);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new System.Drawing.Size(456, 27);
            portTextBox.TabIndex = 3;
            // 
            // ipTextBox
            // 
            ipTextBox.Location = new System.Drawing.Point(139, 16);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new System.Drawing.Size(456, 27);
            ipTextBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(8, 52);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(90, 20);
            label4.TabIndex = 1;
            label4.Text = "Port serwera";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(8, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 20);
            label3.TabIndex = 0;
            label3.Text = "IP serwera";
            // 
            // applyButton
            // 
            applyButton.Location = new System.Drawing.Point(12, 433);
            applyButton.Name = "applyButton";
            applyButton.Size = new System.Drawing.Size(587, 29);
            applyButton.TabIndex = 1;
            applyButton.Text = "Zapisz";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // SettingsWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(611, 471);
            Controls.Add(applyButton);
            Controls.Add(tabControl1);
            Name = "SettingsWindow";
            Text = "Ustawienia";
            Load += SettingsWindow_Load;
            tabControl1.ResumeLayout(false);
            paragonyTabPage.ResumeLayout(false);
            paragonyTabPage.PerformLayout();
            serwerTabPage.ResumeLayout(false);
            serwerTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage paragonyTabPage;
        private System.Windows.Forms.TabPage serwerTabPage;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox stopkaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox naglowekTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}