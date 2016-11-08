using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8._3_RobertWeiland
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void capitalizeButton_Click(object sender, EventArgs e)
        {
            string sentence = inputTextBox.Text;
            char ch; char[] delim = { '.' };
            string[] tokens = sentence.Split(delim);
            capitalizeLabel.Text = "";
            
            foreach (string s in tokens)
            {
                if(s == "")
                {
                    continue;
                }

                ch = s[0];
                string output;
                output = s;

                if (char.IsLower(ch))
                {
                    ch = char.ToUpper(ch);
                    output = output.Remove(0, 1);
                    output = output.Insert(0, ch.ToString());
                }

                if (char.IsWhiteSpace(ch))
                {
                    output = output.Remove(0, 1);
                    ch = sentence[0];
                    ch = char.ToUpper(ch);
                    output = output.Remove(0, 1);
                    output = output.Insert(0, ch.ToString());
                    output = output.Insert(0, " ");
                }

                capitalizeLabel.Text += output + ".";

            }

            
        }
    }
}