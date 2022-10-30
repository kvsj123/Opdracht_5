namespace Oefening2
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
            this.listBoxWaardes = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gem_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxWaardes
            // 
            this.listBoxWaardes.FormattingEnabled = true;
            this.listBoxWaardes.ItemHeight = 15;
            this.listBoxWaardes.Location = new System.Drawing.Point(302, 12);
            this.listBoxWaardes.Name = "listBoxWaardes";
            this.listBoxWaardes.Size = new System.Drawing.Size(184, 244);
            this.listBoxWaardes.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nieuw Getal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gem_textBox
            // 
            this.gem_textBox.Enabled = false;
            this.gem_textBox.Location = new System.Drawing.Point(302, 390);
            this.gem_textBox.Name = "gem_textBox";
            this.gem_textBox.Size = new System.Drawing.Size(184, 23);
            this.gem_textBox.TabIndex = 2;
            this.gem_textBox.TextChanged += new System.EventHandler(this.gem_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gemiddelde";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gem_textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxWaardes);
            this.Name = "Form2";
            this.Text = "GemiddeldeMDI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxWaardes;
        private Button button1;
        private TextBox gem_textBox;
        private Label label1;
    }
}