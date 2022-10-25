using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryTrainingApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //lists needed for various operations
        List<double> sort_list = new List<double>();


        List<string> sort_list2 = new List<string>();


        List<string> output = new List<string>();


        List<string> final = new List<string>();

        // strings
        string SelectedItemText;
        int SelectedIndex;
        int count = 0;

        private void btnStartBookReplace_Click(object sender, EventArgs e)
        {
            //for creating the random double value
            //https://www.softwaretestinghelp.com/csharp-random-number/

            double NextDouble(Random rand, double minValue, double maxValue, int decimalPlaces)
            {
                double randNumber = rand.NextDouble() * (maxValue - minValue) + minValue;
                return Convert.ToDouble(randNumber.ToString("f" + decimalPlaces));
            }

            for (int i = 0; i < 10; i++)
            {
                //creates a random double with 2 decimal places
                //https://www.softwaretestinghelp.com/csharp-random-number/

                Random rand1 = new Random();
                double randNumber = NextDouble(rand1, 100.10, 999.99, 2); // Round to 2 decimal places

                //adds the random double to a list
                sort_list.Add(randNumber);



                //creates a random 3 letter string
                //https://www.softwaretestinghelp.com/csharp-random-number/

                Random rand2 = new Random();

                String b = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                int length = 3;

                String random = "";


                for (int j = 0; j < length; j++)
                {
                    int a = rand2.Next(26);
                    random = random + b.ElementAt(a);
                }

                //adds the random strings to a list
                sort_list2.Add(random);

                //adds the random double and sting into the list
                output.Add(randNumber + " " + random);

            }


            //adds each string in the list to the first listbox
            foreach (string k in output)
            {
                lsbBookReplace.Items.Add((string)k);
            }
        }

        private void btnSubmitBookReplace_Click(object sender, EventArgs e)
        {
            //output is list of random items shown in 1st listbox

            //final is list of user ordered items taken fron 2nd listbox

            //sorts the items in acending order
            output.Sort();


            //adds each item in the listbox to a list
            foreach (string q in lsbUserOrder.Items)
            {
                final.Add(q);
            }
            


            //joins the items in the lists into one string
            string one = string.Join(",", output);
            string two = string.Join(",", final);

            //string three = string.Join(",", sort_list2);



            //Points Gamification feature. Adds 5 points if the users order is correct and deducts 1 point if they are incorrect.
            //https://www.codeproject.com/Questions/1230460/Increment-number-per-button-click-form-by-form-Csh

            if (one == two)
            {
                count++;
                count++;
                count++;
                count++;
                count++;
                MessageBox.Show("Congratulations! you have earned a point!" + " Your Points: " + count);
            }
            else
            {
                count--;
                MessageBox.Show("You were incorrect. Please retry. " + " Your Points: " + count);
            }


            //clears all lists and listboxes 
            lsbBookReplace.Items.Clear();
            lsbUserOrder.Items.Clear();
            sort_list.Clear();
            sort_list2.Clear();
            output.Clear();
            final.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                SelectedItemText = lsbBookReplace.SelectedItem.ToString();
                SelectedIndex = lsbUserOrder.SelectedIndex;
                lsbUserOrder.Items.Add(SelectedItemText);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("There is no selected item to add!");
            }
            
        }
    }
}
