
namespace MWIMS_Capstone {
    partial class AddAisleForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.addAisleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aisle Length (in feet)";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(70, 85);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(165, 23);
            this.lengthTextBox.TabIndex = 1;
            // 
            // addAisleButton
            // 
            this.addAisleButton.Location = new System.Drawing.Point(70, 114);
            this.addAisleButton.Name = "addAisleButton";
            this.addAisleButton.Size = new System.Drawing.Size(165, 69);
            this.addAisleButton.TabIndex = 2;
            this.addAisleButton.Text = "Add Aisle";
            this.addAisleButton.UseVisualStyleBackColor = true;
            this.addAisleButton.Click += new System.EventHandler(this.AddAisleButton_Click);
            // 
            // AddAisleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 223);
            this.Controls.Add(this.addAisleButton);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddAisleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Button addAisleButton;
    }
}