namespace Oefening1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(377, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.menuStrip1_KeyPress);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.backgroundToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem1,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem.Text = "Color";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem1
            // 
            this.redToolStripMenuItem1.Name = "redToolStripMenuItem1";
            this.redToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem1.Text = "Red            Ctrl + R";
            this.redToolStripMenuItem1.Click += new System.EventHandler(this.redToolStripMenuItem1_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greenToolStripMenuItem.Text = "Green         Ctrl + G  ";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blueToolStripMenuItem.Text = "Blue            Ctrl + B";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem2,
            this.greenToolStripMenuItem1,
            this.blueToolStripMenuItem1});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backgroundToolStripMenuItem.Text = "Background Color";
            // 
            // redToolStripMenuItem2
            // 
            this.redToolStripMenuItem2.Name = "redToolStripMenuItem2";
            this.redToolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.redToolStripMenuItem2.Text = "Red";
            this.redToolStripMenuItem2.Click += new System.EventHandler(this.redToolStripMenuItem2_Click);
            // 
            // greenToolStripMenuItem1
            // 
            this.greenToolStripMenuItem1.Name = "greenToolStripMenuItem1";
            this.greenToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem1.Text = "Green";
            this.greenToolStripMenuItem1.Click += new System.EventHandler(this.greenToolStripMenuItem1_Click);
            // 
            // blueToolStripMenuItem1
            // 
            this.blueToolStripMenuItem1.Name = "blueToolStripMenuItem1";
            this.blueToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem1.Text = "Blue";
            this.blueToolStripMenuItem1.Click += new System.EventHandler(this.blueToolStripMenuItem1_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.largeToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(328, 42);
            this.smallToolStripMenuItem.Text = "Small             Ctrl + S";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.smallToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(328, 42);
            this.normalToolStripMenuItem.Text = "Normal          Ctrl + N";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(328, 42);
            this.largeToolStripMenuItem.Text = "Large             Ctrl + L";
            this.largeToolStripMenuItem.Click += new System.EventHandler(this.largeToolStripMenuItem_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.fontToolStripMenuItem1});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(171, 70);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem3,
            this.greenToolStripMenuItem2,
            this.blueToolStripMenuItem2});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // redToolStripMenuItem3
            // 
            this.redToolStripMenuItem3.Name = "redToolStripMenuItem3";
            this.redToolStripMenuItem3.Size = new System.Drawing.Size(105, 22);
            this.redToolStripMenuItem3.Text = "Red";
            this.redToolStripMenuItem3.Click += new System.EventHandler(this.redToolStripMenuItem3_Click);
            // 
            // greenToolStripMenuItem2
            // 
            this.greenToolStripMenuItem2.Name = "greenToolStripMenuItem2";
            this.greenToolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem2.Text = "Green";
            this.greenToolStripMenuItem2.Click += new System.EventHandler(this.greenToolStripMenuItem2_Click);
            // 
            // blueToolStripMenuItem2
            // 
            this.blueToolStripMenuItem2.Name = "blueToolStripMenuItem2";
            this.blueToolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem2.Text = "Blue";
            this.blueToolStripMenuItem2.Click += new System.EventHandler(this.blueToolStripMenuItem2_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem4,
            this.greenToolStripMenuItem3,
            this.blueToolStripMenuItem3});
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            // 
            // redToolStripMenuItem4
            // 
            this.redToolStripMenuItem4.Name = "redToolStripMenuItem4";
            this.redToolStripMenuItem4.Size = new System.Drawing.Size(105, 22);
            this.redToolStripMenuItem4.Text = "Red";
            this.redToolStripMenuItem4.Click += new System.EventHandler(this.redToolStripMenuItem4_Click);
            // 
            // greenToolStripMenuItem3
            // 
            this.greenToolStripMenuItem3.Name = "greenToolStripMenuItem3";
            this.greenToolStripMenuItem3.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem3.Text = "Green";
            this.greenToolStripMenuItem3.Click += new System.EventHandler(this.greenToolStripMenuItem3_Click);
            // 
            // blueToolStripMenuItem3
            // 
            this.blueToolStripMenuItem3.Name = "blueToolStripMenuItem3";
            this.blueToolStripMenuItem3.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem3.Text = "Blue";
            this.blueToolStripMenuItem3.Click += new System.EventHandler(this.blueToolStripMenuItem3_Click);
            // 
            // fontToolStripMenuItem1
            // 
            this.fontToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem1,
            this.normalToolStripMenuItem1,
            this.largeToolStripMenuItem1});
            this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            this.fontToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.fontToolStripMenuItem1.Text = "Font";
            // 
            // smallToolStripMenuItem1
            // 
            this.smallToolStripMenuItem1.Name = "smallToolStripMenuItem1";
            this.smallToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.smallToolStripMenuItem1.Text = "Small";
            this.smallToolStripMenuItem1.Click += new System.EventHandler(this.smallToolStripMenuItem1_Click);
            // 
            // normalToolStripMenuItem1
            // 
            this.normalToolStripMenuItem1.Name = "normalToolStripMenuItem1";
            this.normalToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.normalToolStripMenuItem1.Text = "Normal";
            this.normalToolStripMenuItem1.Click += new System.EventHandler(this.normalToolStripMenuItem1_Click);
            // 
            // largeToolStripMenuItem1
            // 
            this.largeToolStripMenuItem1.Name = "largeToolStripMenuItem1";
            this.largeToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.largeToolStripMenuItem1.Text = "Large";
            this.largeToolStripMenuItem1.Click += new System.EventHandler(this.largeToolStripMenuItem1_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(0, 24);
            this.TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(377, 257);
            this.TextBox.TabIndex = 3;
            this.TextBox.Text = "How sharper than a serpent\'s tooth it is to have a buggy program!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 282);
            this.ContextMenuStrip = this.contextMenuStrip3;
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Menus";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem1;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem2;
        private ToolStripMenuItem greenToolStripMenuItem1;
        private ToolStripMenuItem blueToolStripMenuItem1;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem smallToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem largeToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem3;
        private ToolStripMenuItem greenToolStripMenuItem2;
        private ToolStripMenuItem blueToolStripMenuItem2;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem4;
        private ToolStripMenuItem greenToolStripMenuItem3;
        private ToolStripMenuItem blueToolStripMenuItem3;
        private ToolStripMenuItem fontToolStripMenuItem1;
        private ToolStripMenuItem smallToolStripMenuItem1;
        private ToolStripMenuItem normalToolStripMenuItem1;
        private ToolStripMenuItem largeToolStripMenuItem1;
        private TextBox TextBox;
    }
}