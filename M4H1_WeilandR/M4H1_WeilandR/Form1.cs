using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M4H1_WeilandR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            
        }

        private void displayStatsButton_Click(object sender, EventArgs e)
        {
            Player player = new Player(15, 5, 3, 5, false);
            //player.HP = playerHPLabel.Text;
            NonPlayerCharacter NPC = new NonPlayerCharacter(10, 2, 0, 2, false, NonPlayerCharacter.FactionType.Skylanders);
            
        }
    }
}
