//Program 3
//CIS 199-01
//Due: 4-1-2021
//By: R2889

//This program uses arrays and for loops to show the user the different costs associated with their order.
//It takes the area, item, and quantity and calculates how much the user would pay
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] farms = { "NE", "NW", "SE", "SW" }; //array for the different farm areas
        double[] shipmentFee = { 0.06, 0.0717, 0.07, 0.0874 }; //array for the shipment fees
        int[] item = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 }; //array for the item
        double[] costPerPound = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 }; //array for the cost per pound 
        double[] poundsLowLimits = { 0, 6, 11, 21 }; //array for the low limits of the pound of the order
        double[] discount = { 0.00, 0.05, 0.10, 0.15 }; //array for the discount based on the order

        private void calcButton_Click(object sender, EventArgs e)
        {
            double fee = 0; //fee for which area the user ordered from
            double poundCost = 0; //cost per pound ordered
            double poundDiscount = 0; //discount of the order based on how much was ordered

            double initialCost; //inital cost of order
            double discountCost; //discount cost taken out of order
            double totalCost; //total cost of the order
            double shipmentCost; //shipment cost for the order

            bool itemFound = false;//helps break out of item loop when correct array value is found
            bool farmFound = false;//helps break out of farm loop when correct array value is found
            bool poundFound = false;//helps break out of pound loop when correct array value is found
            
            if (farmCombo.SelectedIndex >= 0)
            {
                if (double.TryParse(itemInput.Text, out double itemNumber) && itemNumber >= 10001 && itemNumber  <= 10007) //item input
                {
                    if (double.TryParse(quantInput.Text, out  double quantity) && quantity >= 0) //quantity input
                    {
                        for (int counter = 0; counter < farms.Length && !farmFound; counter++)//finds the fee for the farm
                        {
                            if(farmCombo.Text == farms[counter])//breaks the loop if number is found
                            {
                                farmFound = true;
                                fee = shipmentFee[counter];
                            }
                        }
                        for(int counter = 0; counter < item.Length && !itemFound; counter++)//finds the cost per pound
                        {
                            if(itemNumber == counter)//breaks looop if number is found
                            {
                                itemFound = true;
                                poundCost = costPerPound[counter];
                            }
                        }
                        for(int counter = 0; counter < poundsLowLimits.Length && !poundFound; counter++)//finds the discount for the order
                        {
                            if(quantity == counter)//breaks loop if number is found
                            {
                                poundFound = true;
                                poundDiscount = discount[counter];
                            }
                        }
                        //calculations for the costs
                        initialCost = poundCost * quantity;
                        discountCost = initialCost - (initialCost * poundDiscount);
                        shipmentCost = discountCost * fee;
                        totalCost = discountCost + shipmentCost;
                        //outputs from calculation
                        initialOutput.Text = $"{initialCost:C}";
                        discountOutput.Text = $"{discountCost:C}";
                        shipmentOutput.Text = $"{shipmentCost:C}";
                        totalOutput.Text = $"{totalCost:C}";
                    }
                    //if quantity input is not valid
                    else
                    {
                        MessageBox.Show("Invalid quantity input.");
                    }
                }
                //if the item input is not valid
                else
                {
                    MessageBox.Show("Invalid item input.");
                }
            }
            //if farm input is invalid 
            else
            {
                MessageBox.Show("Invalid farm input.");
            }

        }
    }
}
