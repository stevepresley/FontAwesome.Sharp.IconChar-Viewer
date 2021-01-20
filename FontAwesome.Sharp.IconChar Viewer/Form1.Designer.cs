namespace FontAwesome.Sharp.IconChar_Viewer
{
    partial class Form1
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTextSearch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numIconSize = new System.Windows.Forms.NumericUpDown();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIconSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTextSearch);
            this.panelTop.Controls.Add(this.textBox1);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.numIconSize);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1781, 50);
            this.panelTop.TabIndex = 0;
            // 
            // lblTextSearch
            // 
            this.lblTextSearch.AutoSize = true;
            this.lblTextSearch.Location = new System.Drawing.Point(168, 20);
            this.lblTextSearch.Name = "lblTextSearch";
            this.lblTextSearch.Size = new System.Drawing.Size(40, 16);
            this.lblTextSearch.TabIndex = 3;
            this.lblTextSearch.Text = "Filter:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(623, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(889, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Icon Size:";
            // 
            // numIconSize
            // 
            this.numIconSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numIconSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIconSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numIconSize.Location = new System.Drawing.Point(1698, 18);
            this.numIconSize.Margin = new System.Windows.Forms.Padding(4);
            this.numIconSize.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numIconSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numIconSize.Name = "numIconSize";
            this.numIconSize.Size = new System.Drawing.Size(67, 22);
            this.numIconSize.TabIndex = 0;
            this.numIconSize.Value = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.numIconSize.ValueChanged += new System.EventHandler(this.numIconSize_ValueChanged);
            // 
            // panelBody
            // 
            this.panelBody.AutoScroll = true;
            this.panelBody.AutoSize = true;
            this.panelBody.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 50);
            this.panelBody.Margin = new System.Windows.Forms.Padding(4);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1781, 1036);
            this.panelBody.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1781, 1086);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "FontAwesome.Sharp.IconChar Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIconSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTextSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numIconSize;
        private System.Windows.Forms.Panel panelBody;
    }
}

