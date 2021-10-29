
namespace NoteApp
{
    partial class Form2
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.form2Title = new System.Windows.Forms.TextBox();
            this.form2Note = new System.Windows.Forms.TextBox();
            this.selectedTitleLabel = new System.Windows.Forms.Label();
            this.selectedNoteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(58, 393);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(128, 28);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return To App";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(310, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // form2Title
            // 
            this.form2Title.Location = new System.Drawing.Point(91, 55);
            this.form2Title.Name = "form2Title";
            this.form2Title.Size = new System.Drawing.Size(316, 22);
            this.form2Title.TabIndex = 2;
            // 
            // form2Note
            // 
            this.form2Note.Location = new System.Drawing.Point(91, 83);
            this.form2Note.Multiline = true;
            this.form2Note.Name = "form2Note";
            this.form2Note.Size = new System.Drawing.Size(316, 251);
            this.form2Note.TabIndex = 3;
            // 
            // selectedTitleLabel
            // 
            this.selectedTitleLabel.AutoSize = true;
            this.selectedTitleLabel.Location = new System.Drawing.Point(39, 55);
            this.selectedTitleLabel.Name = "selectedTitleLabel";
            this.selectedTitleLabel.Size = new System.Drawing.Size(35, 17);
            this.selectedTitleLabel.TabIndex = 4;
            this.selectedTitleLabel.Text = "Title";
            // 
            // selectedNoteLabel
            // 
            this.selectedNoteLabel.AutoSize = true;
            this.selectedNoteLabel.Location = new System.Drawing.Point(36, 83);
            this.selectedNoteLabel.Name = "selectedNoteLabel";
            this.selectedNoteLabel.Size = new System.Drawing.Size(38, 17);
            this.selectedNoteLabel.TabIndex = 5;
            this.selectedNoteLabel.Text = "Note";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 498);
            this.Controls.Add(this.selectedNoteLabel);
            this.Controls.Add(this.selectedTitleLabel);
            this.Controls.Add(this.form2Note);
            this.Controls.Add(this.form2Title);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturn);
            this.Name = "Form2";
            this.Text = "Your Note";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox form2Title;
        private System.Windows.Forms.TextBox form2Note;
        private System.Windows.Forms.Label selectedTitleLabel;
        private System.Windows.Forms.Label selectedNoteLabel;
    }
}