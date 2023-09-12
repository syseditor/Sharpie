using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();

            // Button click init
            close.Click += new EventHandler(this.OnCloseButtonClick);

            // Label - text init
            string pretext = @"Keyboard shortcuts: (Button(s) -> output)
                          1) Numbers -> numbers
                          2) -, shift and =, shift and 8, / -> operations
                          3) Space -> =
                          4) Backspace -> delete 1 character
                          5) c or C -> clear
                          6) m or M -> MR (Memory Recall)
                          7) d or D -> MC (Memory Clear)
                          8) a or A -> M+ (Memory Add)
                          9) s or S -> M- (Memory Subtract)";
            text.Text = pretext;
            credit.LinkClicked += new LinkLabelLinkClickedEventHandler(this.OnLinkClick);
        }

        public void OnCloseButtonClick(object sender, EventArgs args) 
        {
            Close();
        }

        public void OnLinkClick(object sender, LinkLabelLinkClickedEventArgs args)
        {
            credit.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/syseditor");
        }
    }
}