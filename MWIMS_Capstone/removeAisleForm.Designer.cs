
namespace MWIMS_Capstone {
    partial class removeAisleForm {
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
            this.removeAisle = new System.Windows.Forms.Button();
            this.removeAisleListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // removeAisle
            // 
            this.removeAisle.Location = new System.Drawing.Point(346, 217);
            this.removeAisle.Name = "removeAisle";
            this.removeAisle.Size = new System.Drawing.Size(130, 92);
            this.removeAisle.TabIndex = 1;
            this.removeAisle.Text = "Remove Selected Aisle";
            this.removeAisle.UseVisualStyleBackColor = true;
            this.removeAisle.Click += new System.EventHandler(this.RemoveAisle_Click);
            // 
            // removeAisleListBox
            // 
            this.removeAisleListBox.FormattingEnabled = true;
            this.removeAisleListBox.ItemHeight = 15;
            this.removeAisleListBox.Location = new System.Drawing.Point(44, 65);
            this.removeAisleListBox.Name = "removeAisleListBox";
            this.removeAisleListBox.Size = new System.Drawing.Size(254, 244);
            this.removeAisleListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aisles";
            // 
            // removeAisleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeAisleListBox);
            this.Controls.Add(this.removeAisle);
            this.Name = "removeAisleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "removeAisleForm";
            this.Load += new System.EventHandler(this.RemoveAisleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button removeAisle;
        private System.Windows.Forms.ListBox removeAisleListBox;
        private System.Windows.Forms.Label label1;
    }
}