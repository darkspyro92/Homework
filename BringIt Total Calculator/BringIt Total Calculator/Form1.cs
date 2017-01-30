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
        public string name;                     //For holding an entry's name.
        public string type;                     //For holding an entry's type.
        public string cost;                     //For holding an entry's cost.
    }
    public partial class Main : Form
    {
        public double itemCost;                 //For holding the cost of the item.
        public double countyTax, stateTax;      //For holding the price of the tax after calculation.
        public double tips = 0;                 //For holding the amount of tips.        
        public double delivery = 0;             //For holding the BringIt charge.
        public double total = 0;                //For holding the total price of the order.
        
        private List<OrderEntry> orderList =    //Field to hold a list of orders.
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
            double price = 0;   //This is to determine if the price is more than $10.
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

                    //Determine if an item is less than $10.
                    price = Double.Parse(entry.cost);
                    if (price < 10)
                    {
                        //If it is less than $10, remove it from the list.
                        //Do not remove it from the text file, though. The parameters may change.
                        orderList.Remove(entry);
                    }

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

        public void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cost;                    //For holding the cost of the item.
            string type;                    //For holding the type of item (RETAIL or FOOD).
            double countyRate = .0225;      //For holding the county tax rate.
            double stateRate = .0475;       //For holding the state tax rate.


            //Get the index of the selected item.
            int index = ordersListBox.SelectedIndex;

            //Display the corrosponding type.
            itemTypeLabel.Text = orderList[index].type;

            //Display the corrosponding cost.
            cost = orderList[index].cost;
            itemCost = Double.Parse(cost);
            itemCostLabel.Text = orderList[index].cost;

            //Calculate and display the corrosponding county tax.
            countyTax = itemCost * countyRate;
            countyLabel.Text = countyTax.ToString();

            //Calculate and display the corrosponding state tax.
            stateTax = itemCost * stateRate;
            stateLabel.Text = stateTax.ToString();


            //Determine if it is RETAIL or FOOD and add tax accordingly.
            //Then display the delivery cost and the item type..
            type = orderList[index].type;
            if (type == "RETAIL")
            {
                delivery = itemCost * .05;
            }
            else if (type == "FOOD")
            {
                delivery = itemCost * .2;
            }
            itemTypeLabel.Text = orderList[index].type;
            deliveryLabel.Text = delivery.ToString();

            //Display the total without tips. We'll add the tips next.
            total = itemCost + countyTax + stateTax + delivery;
            totalLabel.Text = total.ToString();

            
        }
        private void tipButton_Click(object sender, EventArgs e)
        {
            //The tips must not be more than 20% of the cost. Otherwise it is considered a service charge.
            //Calculate and determine if they are.
            tips = Double.Parse(tipsTextBox.Text);
            if (tips > (itemCost * .2))
            {
                MessageBox.Show("Error. Tips must not be more than 20% of the cost. This turns it into a service charge.");
            }
            //If it is less than 20%, continue to add all of the data together and display the total.
            else
            {
                total = itemCost + tips + countyTax + stateTax + delivery;
                totalLabel.Text = total.ToString();
            }
            
        }
    }
}
