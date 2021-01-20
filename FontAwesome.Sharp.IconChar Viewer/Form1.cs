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

        int iconSize = 16;
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
            btnClear.Enabled = false;
            LoopThroughIcons(textBox1.Text);
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
            buttonWidth = iconSize + 4 + 132 + 2; // 2px margin left and right of icon, textfield of 50, 2px margin
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

            panelBody.Visible = true;
            lblStatus.Visible = false;
            textBox1.ReadOnly = false;
            if (textBox1.Text.Length > 0)
            {
                btnClear.Enabled = true;
            }
            numIconSize.Enabled = true;
            
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
            if (colCounter>12)
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
    }
}
