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
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelCurrWidth = new System.Windows.Forms.Label();
            this.labelNewWidth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numColumns = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.lblTextSearch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numIconSize = new System.Windows.Forms.NumericUpDown();
            this.panelBody = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDonate2 = new FontAwesome.Sharp.IconButton();
            this.panelBrowser = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIconSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnDonate2);
            this.panelTop.Controls.Add(this.labelCurrWidth);
            this.panelTop.Controls.Add(this.labelNewWidth);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.numColumns);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.lblStatus);
            this.panelTop.Controls.Add(this.btnClear);
            this.panelTop.Controls.Add(this.lblTextSearch);
            this.panelTop.Controls.Add(this.textBox1);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.numIconSize);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1872, 81);
            this.panelTop.TabIndex = 0;
            // 
            // labelCurrWidth
            // 
            this.labelCurrWidth.AutoSize = true;
            this.labelCurrWidth.Location = new System.Drawing.Point(741, 47);
            this.labelCurrWidth.Name = "labelCurrWidth";
            this.labelCurrWidth.Size = new System.Drawing.Size(45, 20);
            this.labelCurrWidth.TabIndex = 13;
            this.labelCurrWidth.Text = "2222";
            // 
            // labelNewWidth
            // 
            this.labelNewWidth.AutoSize = true;
            this.labelNewWidth.Location = new System.Drawing.Point(692, 47);
            this.labelNewWidth.Name = "labelNewWidth";
            this.labelNewWidth.Size = new System.Drawing.Size(45, 20);
            this.labelNewWidth.TabIndex = 12;
            this.labelNewWidth.Text = "1111";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(810, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Columns:";
            // 
            // numColumns
            // 
            this.numColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numColumns.Location = new System.Drawing.Point(901, 47);
            this.numColumns.Margin = new System.Windows.Forms.Padding(4);
            this.numColumns.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numColumns.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numColumns.Name = "numColumns";
            this.numColumns.Size = new System.Drawing.Size(59, 26);
            this.numColumns.TabIndex = 10;
            this.numColumns.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numColumns.ValueChanged += new System.EventHandler(this.numColumns_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(119, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Click button to add name to clipboard";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStatus.Location = new System.Drawing.Point(577, 49);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Loading...";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
            this.btnClear.IconColor = System.Drawing.Color.Black;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 30;
            this.btnClear.Location = new System.Drawing.Point(754, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(32, 35);
            this.btnClear.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnClear, "Clear Search Text (or press ESC)");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTextSearch
            // 
            this.lblTextSearch.AutoSize = true;
            this.lblTextSearch.Location = new System.Drawing.Point(66, 15);
            this.lblTextSearch.Name = "lblTextSearch";
            this.lblTextSearch.Size = new System.Drawing.Size(52, 20);
            this.lblTextSearch.TabIndex = 3;
            this.lblTextSearch.Text = "Filter:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(623, 26);
            this.textBox1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox1, "Filter Icon names containing this text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(810, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Icon Size:";
            // 
            // numIconSize
            // 
            this.numIconSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIconSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numIconSize.Location = new System.Drawing.Point(901, 12);
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
            this.numIconSize.Size = new System.Drawing.Size(59, 26);
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
            this.panelBody.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.panelBody.AutoSize = true;
            this.panelBody.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 81);
            this.panelBody.Margin = new System.Windows.Forms.Padding(4);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1872, 1182);
            this.panelBody.TabIndex = 1;
            // 
            // btnDonate2
            // 
            this.btnDonate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.btnDonate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.btnDonate2.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.btnDonate2.IconColor = System.Drawing.Color.Lime;
            this.btnDonate2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDonate2.IconSize = 42;
            this.btnDonate2.Location = new System.Drawing.Point(12, 15);
            this.btnDonate2.Name = "btnDonate2";
            this.btnDonate2.Size = new System.Drawing.Size(48, 49);
            this.btnDonate2.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnDonate2, "Donate");
            this.btnDonate2.UseVisualStyleBackColor = false;
            this.btnDonate2.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // panelBrowser
            // 
            this.panelBrowser.AutoScroll = true;
            this.panelBrowser.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.panelBrowser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBrowser.Location = new System.Drawing.Point(0, 81);
            this.panelBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.panelBrowser.Name = "panelBrowser";
            this.panelBrowser.Size = new System.Drawing.Size(1872, 1182);
            this.panelBrowser.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 1263);
            this.Controls.Add(this.panelBrowser);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "FontAwesome.Sharp.IconChar Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColumns)).EndInit();
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
        private IconButton btnClear;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numColumns;
        private System.Windows.Forms.Label labelCurrWidth;
        private System.Windows.Forms.Label labelNewWidth;
        private IconButton btnDonate2;
        private System.Windows.Forms.Panel panelBrowser;
    }
}

