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
            
            
            foreach (string s in tokens)
            {
                ch = sentence[0];

                if (char.IsLower(ch))
                {
                    ch = char.ToUpper(ch);
                    sentence = sentence.Remove(0, 1);
                    sentence = sentence.Insert(0, ch.ToString());
                }

                if (char.IsWhiteSpace(ch))
                {
                    sentence = sentence.Remove(0, 1);
                    ch = sentence[0];
                    ch = char.ToUpper(ch);
                    sentence = sentence.Remove(0, 1);
                    sentence = sentence.Insert(0, ch.ToString());
                    sentence = sentence.Insert(0, " ");
                }
            }

            sentence = tokens.Concat(tokens).ToString();

            capitalizeLabel.Text = sentence;
        }
    }
}
