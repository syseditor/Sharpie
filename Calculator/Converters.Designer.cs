namespace Calculator
{
    partial class Converters
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
            this.input = new System.Windows.Forms.RichTextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.mass = new System.Windows.Forms.Button();
            this.velocity = new System.Windows.Forms.Button();
            this.inputList = new System.Windows.Forms.ComboBox();
            this.outputList = new System.Windows.Forms.ComboBox();
            this.conv = new System.Windows.Forms.Button();
            this.area = new System.Windows.Forms.Button();
            this.length = new System.Windows.Forms.Button();
            this.temperature = new System.Windows.Forms.Button();
            this.volume = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.input.Location = new System.Drawing.Point(30, 53);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(150, 40);
            this.input.TabIndex = 0;
            this.input.Text = "0";
            // 
            // output
            // 
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.output.Location = new System.Drawing.Point(400, 53);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(150, 40);
            this.output.TabIndex = 1;
            this.output.Text = "0";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(90, 37);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(31, 13);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Input";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(425, 37);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(101, 13);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Output - Conversion";
            // 
            // mass
            // 
            this.mass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.mass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mass.Location = new System.Drawing.Point(212, 99);
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(75, 23);
            this.mass.TabIndex = 4;
            this.mass.Text = "Mass";
            this.mass.UseVisualStyleBackColor = false;
            // 
            // velocity
            // 
            this.velocity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.velocity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.velocity.Location = new System.Drawing.Point(293, 99);
            this.velocity.Name = "velocity";
            this.velocity.Size = new System.Drawing.Size(75, 23);
            this.velocity.TabIndex = 5;
            this.velocity.Text = "Velocity";
            this.velocity.UseVisualStyleBackColor = false;
            // 
            // inputList
            // 
            this.inputList.FormattingEnabled = true;
            this.inputList.Location = new System.Drawing.Point(45, 101);
            this.inputList.Name = "inputList";
            this.inputList.Size = new System.Drawing.Size(121, 21);
            this.inputList.TabIndex = 6;
            this.inputList.Text = "Select input unit";
            // 
            // outputList
            // 
            this.outputList.FormattingEnabled = true;
            this.outputList.Location = new System.Drawing.Point(416, 101);
            this.outputList.Name = "outputList";
            this.outputList.Size = new System.Drawing.Size(121, 21);
            this.outputList.TabIndex = 7;
            this.outputList.Text = "Select output unit";
            // 
            // conv
            // 
            this.conv.BackColor = System.Drawing.Color.MintCream;
            this.conv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.conv.Location = new System.Drawing.Point(252, 60);
            this.conv.Name = "conv";
            this.conv.Size = new System.Drawing.Size(75, 23);
            this.conv.TabIndex = 8;
            this.conv.Text = "Convert";
            this.conv.UseVisualStyleBackColor = false;
            // 
            // area
            // 
            this.area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.area.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.area.Location = new System.Drawing.Point(212, 128);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(75, 23);
            this.area.TabIndex = 9;
            this.area.Text = "Area";
            this.area.UseVisualStyleBackColor = false;
            // 
            // length
            // 
            this.length.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.length.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.length.Location = new System.Drawing.Point(293, 128);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(75, 23);
            this.length.TabIndex = 10;
            this.length.Text = "Length";
            this.length.UseVisualStyleBackColor = false;
            // 
            // temperature
            // 
            this.temperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.temperature.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.temperature.Location = new System.Drawing.Point(212, 157);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(75, 23);
            this.temperature.TabIndex = 11;
            this.temperature.Text = "Temperature";
            this.temperature.UseVisualStyleBackColor = false;
            // 
            // volume
            // 
            this.volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.volume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.volume.Location = new System.Drawing.Point(293, 157);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(75, 23);
            this.volume.TabIndex = 12;
            this.volume.Text = "Volume";
            this.volume.UseVisualStyleBackColor = false;
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.time.Location = new System.Drawing.Point(212, 186);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(75, 23);
            this.time.TabIndex = 13;
            this.time.Text = "Time";
            this.time.UseVisualStyleBackColor = false;
            // 
            // data
            // 
            this.data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.data.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.data.Location = new System.Drawing.Point(293, 186);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(75, 23);
            this.data.TabIndex = 14;
            this.data.Text = "Data";
            this.data.UseVisualStyleBackColor = false;
            // 
            // Converters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.data);
            this.Controls.Add(this.time);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.length);
            this.Controls.Add(this.area);
            this.Controls.Add(this.conv);
            this.Controls.Add(this.outputList);
            this.Controls.Add(this.inputList);
            this.Controls.Add(this.velocity);
            this.Controls.Add(this.mass);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Converters";
            this.Text = "Converters - C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button mass;
        private System.Windows.Forms.Button velocity;
        private System.Windows.Forms.ComboBox inputList;
        private System.Windows.Forms.ComboBox outputList;
        private System.Windows.Forms.Button conv;
        private System.Windows.Forms.Button area;
        private System.Windows.Forms.Button length;
        private System.Windows.Forms.Button temperature;
        private System.Windows.Forms.Button volume;
        private System.Windows.Forms.Button time;
        private System.Windows.Forms.Button data;
    }
}