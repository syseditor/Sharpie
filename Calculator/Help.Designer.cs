namespace Calculator
{
    partial class Help
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
            this.close = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.LinkLabel();
            this.credits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Silver;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Location = new System.Drawing.Point(260, 424);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(80, 25);
            this.close.TabIndex = 0;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.title.Location = new System.Drawing.Point(215, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(169, 25);
            this.title.TabIndex = 1;
            this.title.Text = "Help Window";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(10, 70);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(42, 18);
            this.text.TabIndex = 2;
            this.text.Text = "Text";
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.credit.Location = new System.Drawing.Point(50, 430);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(48, 13);
            this.credit.TabIndex = 4;
            this.credit.TabStop = true;
            this.credit.Text = "syseditor";
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.Location = new System.Drawing.Point(12, 430);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(42, 13);
            this.credits.TabIndex = 3;
            this.credits.Text = "Credits:";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.text);
            this.Controls.Add(this.title);
            this.Controls.Add(this.close);
            this.Name = "Help";
            this.Text = "Help - C# Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.LinkLabel credit;
        private System.Windows.Forms.Label credits;
    }
}