using System.Windows.Forms;

namespace Client {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.MessagesBox = new System.Windows.Forms.RichTextBox();
            this.MessageSendBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessagesBox
            // 
            this.MessagesBox.BackColor = System.Drawing.SystemColors.Control;
            this.MessagesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessagesBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MessagesBox.Location = new System.Drawing.Point(12, 12);
            this.MessagesBox.Name = "MessagesBox";
            this.MessagesBox.ReadOnly = true;
            this.MessagesBox.Size = new System.Drawing.Size(760, 512);
            this.MessagesBox.TabIndex = 1;
            this.MessagesBox.TabStop = false;
            this.MessagesBox.Text = "";
            // 
            // MessageSendBox
            // 
            this.MessageSendBox.BackColor = System.Drawing.SystemColors.Control;
            this.MessageSendBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageSendBox.Location = new System.Drawing.Point(12, 530);
            this.MessageSendBox.MaxLength = 250;
            this.MessageSendBox.Name = "MessageSendBox";
            this.MessageSendBox.Size = new System.Drawing.Size(760, 20);
            this.MessageSendBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.MessageSendBox);
            this.Controls.Add(this.MessagesBox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Simple IM Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox MessagesBox;
        private TextBox MessageSendBox;
    }
}

