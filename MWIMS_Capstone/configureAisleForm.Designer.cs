
namespace MWIMS_Capstone {
    partial class ConfigureAisleForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.configureAisleListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rowHeightTextbox = new System.Windows.Forms.TextBox();
            this.rowListBox = new System.Windows.Forms.ListBox();
            this.removeRowButton = new System.Windows.Forms.Button();
            this.addRowButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // configureAisleListBox
            // 
            this.configureAisleListBox.FormattingEnabled = true;
            this.configureAisleListBox.ItemHeight = 15;
            this.configureAisleListBox.Location = new System.Drawing.Point(44, 42);
            this.configureAisleListBox.Name = "configureAisleListBox";
            this.configureAisleListBox.Size = new System.Drawing.Size(224, 199);
            this.configureAisleListBox.TabIndex = 2;
            this.configureAisleListBox.SelectedIndexChanged += new System.EventHandler(this.ConfigureAisleListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Row Height (in inches)\r\n";
            // 
            // rowHeightTextbox
            // 
            this.rowHeightTextbox.Location = new System.Drawing.Point(307, 83);
            this.rowHeightTextbox.Name = "rowHeightTextbox";
            this.rowHeightTextbox.Size = new System.Drawing.Size(263, 23);
            this.rowHeightTextbox.TabIndex = 9;
            // 
            // rowListBox
            // 
            this.rowListBox.FormattingEnabled = true;
            this.rowListBox.ItemHeight = 15;
            this.rowListBox.Location = new System.Drawing.Point(600, 42);
            this.rowListBox.Name = "rowListBox";
            this.rowListBox.Size = new System.Drawing.Size(263, 64);
            this.rowListBox.TabIndex = 8;
            // 
            // removeRowButton
            // 
            this.removeRowButton.Location = new System.Drawing.Point(600, 129);
            this.removeRowButton.Name = "removeRowButton";
            this.removeRowButton.Size = new System.Drawing.Size(264, 115);
            this.removeRowButton.TabIndex = 7;
            this.removeRowButton.Text = "Remove Row";
            this.removeRowButton.UseVisualStyleBackColor = true;
            this.removeRowButton.Click += new System.EventHandler(this.RemoveRowButton_Click);
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(306, 129);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(264, 115);
            this.addRowButton.TabIndex = 6;
            this.addRowButton.Text = "Add Row";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Aisles";
            // 
            // ConfigureAisleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rowHeightTextbox);
            this.Controls.Add(this.rowListBox);
            this.Controls.Add(this.removeRowButton);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.configureAisleListBox);
            this.Name = "ConfigureAisleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "configureAisleForm";
            this.Load += new System.EventHandler(this.ConfigureAisleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox configureAisleListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rowHeightTextbox;
        private System.Windows.Forms.ListBox rowListBox;
        private System.Windows.Forms.Button removeRowButton;
        private System.Windows.Forms.Button addRowButton;
        private System.Windows.Forms.Label label1;
    }
}