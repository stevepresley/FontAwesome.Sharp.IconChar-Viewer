using CefSharp;
using CefSharp.WinForms;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontAwesome.Sharp.IconChar_Viewer
{

    

    public partial class Form1 : Form
    {

        private string DonationURL = "http://stevepresley.net/donations-appreciated/";
        public ChromiumWebBrowser browser;
        private bool browserActive = false;


        int iconSize = 16;
        int iconSpacing = 4;
        int buttonHeight = 0;
        int buttonWidth = 0;
        int top = 0;
        int left = 0;
        int rowCounter = 1;
        int colCounter = 0;
        

        IEnumerable<IconChar> items = Enum.GetValues(typeof(IconChar)).Cast<FontAwesome.Sharp.IconChar>().OrderBy(x => x.ToString());


        public Form1()
        {
            InitializeComponent();
            this.Text = String.Format("FontAwesome.Sharp.IconChar Viewer v{0}", Application.ProductVersion);
            Application.DoEvents();
            InitBrowser(DonationURL);
            btnClear.Enabled = false;
            LoopThroughIcons(textBox1.Text);
            this.WindowState = FormWindowState.Normal;
            panelBrowser.Visible = browserActive;
        }

        public void InitBrowser(string URL)
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser(URL);
           // panelBody.Controls.Clear();
            panelBrowser.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        private void numIconSize_ValueChanged(object sender, EventArgs e)
        {
            LoopThroughIcons(textBox1.Text);
            Application.DoEvents();
        }

        public void LoopThroughIcons(string strFilter)
        {
            panelBody.Visible = false;
            lblStatus.Visible = true;
            textBox1.ReadOnly = true;
            btnClear.Enabled = false;
            numIconSize.Enabled = false;
            numColumns.Enabled = false;
            Application.DoEvents();
            // get the list to dispose
            //List<IconButton> lst = panelBody.Controls.OfType<IconButton>().ToList();
            // clear the panel
            panelBody.Controls.Clear();
            //panelBody.Refresh();
            // dispose of the old IconButtons
            //foreach (IconButton uc in lst)
            //{
            //    uc.Dispose();
            //}
            Application.DoEvents();


            rowCounter = 1;
            colCounter = 0;
            iconSize = (int) numIconSize.Value;
            buttonHeight = iconSize + 4; //2 px margin top and bottom
            buttonWidth = iconSize + 4 + 140 + 2; // 2px margin left and right of icon, textfield of 50, 2px margin
            top = buttonHeight + 4; //4px between buttons
            left = buttonWidth + 4; //4px between buttons

            // initalize filterList
            IEnumerable<IconChar> filterList = items;

            // items.OrderBy(x => x.ToString());
            if (textBox1.Text.Length> 0)
            {
                filterList = filterList.Where(item => item.ToString().ToLower().Contains(textBox1.Text.ToLower()));
            }
           
            filterList.ForEach(i => AddButtons(i));

            int intForm1Width = (int)((buttonWidth * numColumns.Value) + (iconSpacing * numColumns.Value) + 52);
            labelNewWidth.Text = intForm1Width.ToString();
            this.Size = new Size(intForm1Width, this.Size.Height);
            //panelBody.Width = intForm1Width;
            
            // flip browseractive to true temporarily so that it toggles off when we run BrowserToggle
            browserActive = true;
            BrowserToggle();

            //
            //panelBody.Visible = true;
            lblStatus.Visible = false;
            textBox1.ReadOnly = false;
            if (textBox1.Text.Length > 0)
            {
                btnClear.Enabled = true;
            }
            numIconSize.Enabled = true;
            numColumns.Enabled = true;

            Application.DoEvents();
        }      

        
           
        public void AddButtons(IconChar thisChar)
        {           
            IconButton thisButton = new FontAwesome.Sharp.IconButton();
            thisButton.Left = left*colCounter+4;
            thisButton.Top = top*rowCounter;
            thisButton.IconChar = thisChar;
            thisButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            thisButton.IconSize = iconSize;
            thisButton.Height = buttonHeight;
            thisButton.Width = buttonWidth;
            thisButton.Text = thisChar.ToString();        
            thisButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            thisButton.Click += new EventHandler(iconButtonClick);
            panelBody.Controls.Add(thisButton); // here
            colCounter++;
            if (colCounter>=numColumns.Value)
            {
                rowCounter++;
                colCounter = 0;
            }            
        }

        private void iconButtonClick(object sender, EventArgs e)
        {
            string btnName = ((IconButton)sender).IconChar.ToString();
            Clipboard.SetText(btnName);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoopThroughIcons(textBox1.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Application.DoEvents();
           // LoopThroughIcons(textBox1.Text);
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            browser.Load(DonationURL);
            BrowserToggle();
        }

        private void BrowserToggle()
        {
            browserActive = !browserActive;
            panelBrowser.Visible = browserActive;
            panelBody.Visible = !browserActive;

        }

        private void numColumns_ValueChanged(object sender, EventArgs e)
        {
            LoopThroughIcons(textBox1.Text);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            labelCurrWidth.Text = this.Width.ToString();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    LoopThroughIcons(textBox1.Text);
                    break;
                case Keys.Escape:
                    textBox1.Text = "";
                    break;
            }
        }
    }
}
