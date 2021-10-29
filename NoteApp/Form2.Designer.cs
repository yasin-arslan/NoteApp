
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
            this.btnReturn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Location = new System.Drawing.Point(91, 345);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(125, 28);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return To App";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(222, 345);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 28);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // form2Title
            // 
            this.form2Title.Location = new System.Drawing.Point(89, 45);
            this.form2Title.Multiline = true;
            this.form2Title.Name = "form2Title";
            this.form2Title.Size = new System.Drawing.Size(201, 30);
            this.form2Title.TabIndex = 2;
            this.form2Title.TextChanged += new System.EventHandler(this.form2Title_TextChanged);
            // 
            // form2Note
            // 
            this.form2Note.Location = new System.Drawing.Point(89, 91);
            this.form2Note.Multiline = true;
            this.form2Note.Name = "form2Note";
            this.form2Note.Size = new System.Drawing.Size(201, 248);
            this.form2Note.TabIndex = 3;
            // 
            // selectedTitleLabel
            // 
            this.selectedTitleLabel.AutoSize = true;
            this.selectedTitleLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.selectedTitleLabel.Location = new System.Drawing.Point(5, 44);
            this.selectedTitleLabel.Name = "selectedTitleLabel";
            this.selectedTitleLabel.Size = new System.Drawing.Size(78, 31);
            this.selectedTitleLabel.TabIndex = 4;
            this.selectedTitleLabel.Text = "Title:";
            // 
            // selectedNoteLabel
            // 
            this.selectedNoteLabel.AutoSize = true;
            this.selectedNoteLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.selectedNoteLabel.Location = new System.Drawing.Point(5, 181);
            this.selectedNoteLabel.Name = "selectedNoteLabel";
            this.selectedNoteLabel.Size = new System.Drawing.Size(78, 31);
            this.selectedNoteLabel.TabIndex = 5;
            this.selectedNoteLabel.Text = "Note:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 414);
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