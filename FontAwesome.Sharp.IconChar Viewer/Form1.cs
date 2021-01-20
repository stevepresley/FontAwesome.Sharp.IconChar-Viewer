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
       

        public Form1()
        {
            InitializeComponent();
            this.Text = String.Format("FontAwesome.Sharp.IconChar Viewer v{0}", Application.ProductVersion);
            LoopThroughIcons();
        }

        private void numIconSize_ValueChanged(object sender, EventArgs e)
        {
            LoopThroughIcons();
            Application.DoEvents();
        }

        public void LoopThroughIcons()
        {
            // get the list to dispose
            List<IconButton> lst = panelBody.Controls.OfType<IconButton>().ToList();
            // clear the panel
            panelBody.Controls.Clear();
            // dispose of the old IconButtons
            foreach (IconButton uc in lst)
            {
                uc.Dispose();
            }

            rowCounter = 1;
            colCounter = 0;
            iconSize = (int) numIconSize.Value;
            buttonHeight = iconSize + 4; //2 px margin top and bottom
            buttonWidth = iconSize + 4 + 132 + 2; // 2px margin left and right of icon, textfield of 50, 2px margin
            top = buttonHeight + 4; //4px between buttons
            left = buttonWidth + 4; //4px between buttons
            IEnumerable<IconChar> items = Enum.GetValues(typeof(IconChar)).Cast<FontAwesome.Sharp.IconChar>().OrderBy(x => x.ToString()); 
           // items.OrderBy(x => x.ToString());
            items.ForEach(i => AddButtons(i));
           
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
            panelBody.Controls.Add(thisButton); // here
            colCounter++;
            if (colCounter>12)
            {
                rowCounter++;
                colCounter = 0;
            }

        }

        
    }
}
