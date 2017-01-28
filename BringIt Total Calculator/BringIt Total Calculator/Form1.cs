using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BringIt_Total_Calculator
{
    struct OrderEntry
    {
        public string name;
        public string type;
        public string cost;
    }
    public partial class Main : Form
    {
        //Field to hold a list of orders.
        private List<OrderEntry> orderList =
            new List<OrderEntry>();
        public Main()
        {
            InitializeComponent();
        }

        //The ReadFile method reads of the contents of the
        //Orders.txt file and stores it as Orders
        //objects in the Orders list.
        private void ReadFile()
        {
            try
            {
                StreamReader inputFile; //To read the file.
                string line;            //To hold a line from the file.

                //Create an instance of the PhoneBookEntry structure.
                OrderEntry entry = new OrderEntry();

                //Create a delimiter array.
                char[] delim = { ' ' };

                //Open the PhoneList file.
                inputFile = File.OpenText("Orders.txt");

                //Read the lines from the file.
                while (!inputFile.EndOfStream)
                {
                    //Read a line from the file.
                    line = inputFile.ReadLine();

                    //Tokenize the line
                    string[] tokens = line.Split(delim);

                    //Store the tokens in an entry object.
                    entry.name = tokens[0];
                    entry.type = tokens[1];
                    entry.cost = tokens[2];

                    //Add the entry object to the List.
                    orderList.Add(entry);
                }
            }
            catch (Exception ex)
            {
                //Display an error message.
                MessageBox.Show(ex.Message);
            }
        }
        //The DisplayNames method displays the list of names
        //in the namesListBox control.
        private void DisplayNames()
        {
            foreach (OrderEntry entry in orderList)
            {
                ordersListBox.Items.Add(entry.name);
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            //Read the PhoneList.txt file.
            ReadFile();

            //Display the names.
            DisplayNames();
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal itemCost = 0;
            double countyRate = .0225;
            double stateRate = .0475;

            //Get the index of the selected item.
            int index = ordersListBox.SelectedIndex;

            //Display the corrosponding type.
            itemTypeLabel.Text = orderList[index].type;

            //Display the corrosponding cost.
            itemCostLabel.Text = orderList[index].cost;
            itemCost = orderList[index].cost;

            //Display the corrosponding county tax.
            countyLabel.Text = (orderList[index].cost * countyRate);
        }
    }
}
