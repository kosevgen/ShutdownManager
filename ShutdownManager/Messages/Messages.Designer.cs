namespace ShutdownManager.Messages
{
    partial class MessagesForm
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
            this.MessageOKButton = new System.Windows.Forms.Button();
            this.MessageSkipButton = new System.Windows.Forms.Button();
            this.MessageCancelButton = new System.Windows.Forms.Button();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessageOKButton
            // 
            this.MessageOKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MessageOKButton.Location = new System.Drawing.Point(25, 198);
            this.MessageOKButton.Name = "MessageOKButton";
            this.MessageOKButton.Size = new System.Drawing.Size(75, 23);
            this.MessageOKButton.TabIndex = 0;
            this.MessageOKButton.Text = "OK";
            this.MessageOKButton.UseVisualStyleBackColor = true;
            this.MessageOKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // MessageSkipButton
            // 
            this.MessageSkipButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MessageSkipButton.Location = new System.Drawing.Point(157, 198);
            this.MessageSkipButton.Name = "MessageSkipButton";
            this.MessageSkipButton.Size = new System.Drawing.Size(75, 23);
            this.MessageSkipButton.TabIndex = 1;
            this.MessageSkipButton.Text = "Пропустить";
            this.MessageSkipButton.UseVisualStyleBackColor = true;
            this.MessageSkipButton.Click += new System.EventHandler(this.SkipButton_Click);
            // 
            // MessageCancelButton
            // 
            this.MessageCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageCancelButton.Location = new System.Drawing.Point(288, 198);
            this.MessageCancelButton.Name = "MessageCancelButton";
            this.MessageCancelButton.Size = new System.Drawing.Size(75, 23);
            this.MessageCancelButton.TabIndex = 2;
            this.MessageCancelButton.Text = "Отмена";
            this.MessageCancelButton.UseVisualStyleBackColor = true;
            this.MessageCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorMessageLabel.Location = new System.Drawing.Point(25, 34);
            this.ErrorMessageLabel.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.ErrorMessageLabel.MaximumSize = new System.Drawing.Size(500, 600);
            this.ErrorMessageLabel.MinimumSize = new System.Drawing.Size(350, 150);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(350, 150);
            this.ErrorMessageLabel.TabIndex = 3;
            this.ErrorMessageLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // MessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(437, 236);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.MessageCancelButton);
            this.Controls.Add(this.MessageSkipButton);
            this.Controls.Add(this.MessageOKButton);
            this.Name = "MessagesForm";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.MessagesForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MessageOKButton;
        private System.Windows.Forms.Button MessageSkipButton;
        private System.Windows.Forms.Button MessageCancelButton;
        private System.Windows.Forms.Label ErrorMessageLabel;
    }
}