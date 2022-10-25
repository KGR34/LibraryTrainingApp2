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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //Create dictionary with String-String KeyValue pair 
        //https://www.tutorialsteacher.com/csharp/csharp-dictionary
        Dictionary<string, string> Descriptions = new Dictionary<string, string>();

        //Declaring strings for dictionary values to be displayed
        string el1;
        string el2;
        string el3;
        string el4;
        string el5;
        string el6;
        string el7;

        string vl1;
        string vl2;
        string vl3;
        string vl4;
        string vl5;
        string vl6;
        string vl7;

        //Declares bool for switching between call numbers and descriptions in each column
        bool switcher;


        private void btnStartIdent_Click(object sender, EventArgs e)
        {
            //Try catch for exception handling
            try
            {

                //Adding items to the dictionary
                Descriptions.Add("315.22", "JJ Hale: The Biography");
                Descriptions.Add("218.25", "Harry Potter and the Goblet of Fire");
                Descriptions.Add("254.35", "Silence of the Lambs");
                Descriptions.Add("948.33", "American Psycho");
                Descriptions.Add("158.64", "Catching Fire");
                Descriptions.Add("648.25", "The Secret");
                Descriptions.Add("365.48", "The Lakehouse");
                Descriptions.Add("548.34", "Astartes");
                Descriptions.Add("514.65", "Dancers");
                Descriptions.Add("341.45", "Dancer of the Boreal Valley");
                Descriptions.Add("849.57", "The Four Kings");
                Descriptions.Add("756.57", "Bed of Chaos");
                Descriptions.Add("347.05", "The Lost Sinner");
                Descriptions.Add("587.32", "Darklurker");
                Descriptions.Add("378.25", "The Burnt Ivory King");
                Descriptions.Add("924.37", "Soul of Cinder");
                Descriptions.Add("519.76", "Black Knife Assassin");
                Descriptions.Add("197.73", "Margit, the Fell Omen");
                Descriptions.Add("116.25", "Red Wolf of the Champion");
                Descriptions.Add("997.98", "Radagon of the Golden Order");
                Descriptions.Add("773.25", "Morgott, the Omen King");

                //Random number generation
                //https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp
                Random rnd = new Random();
                int r1 = rnd.Next(1, 4);
                int r2 = rnd.Next(4, 7);
                int r3 = rnd.Next(7, 10);
                int r4 = rnd.Next(10, 13);
                int r5 = rnd.Next(13, 16);
                int r6 = rnd.Next(16, 19);
                int r7 = rnd.Next(19, 21);


                //Get elements at random indexes of dictionary with no repeats
                var element1 = Descriptions.ElementAt(r1);
                var element2 = Descriptions.ElementAt(r2);
                var element3 = Descriptions.ElementAt(r3);
                var element4 = Descriptions.ElementAt(r4);
                var element5 = Descriptions.ElementAt(r5);
                var element6 = Descriptions.ElementAt(r6);
                var element7 = Descriptions.ElementAt(r7);


                //Assigns Keys to strings
                el1 = element1.Key;
                el2 = element2.Key;
                el3 = element3.Key;
                el4 = element4.Key;
                el5 = element5.Key;
                el6 = element6.Key;
                el7 = element7.Key;

                //Assigns Values to strings
                vl1 = element1.Value;
                vl2 = element2.Value;
                vl3 = element3.Value;
                vl4 = element4.Value;
                vl5 = element5.Value;
                vl6 = element6.Value;
                vl7 = element7.Value;

                //Switches bool on button click to alternate between call numbers and descriptions appearing in each column
                //https://stackoverflow.com/questions/43195375/changing-a-boolean-every-time-i-click-a-button
                switcher = !switcher;
                if (switcher == true)
                {
                    //Populate column A
                    lsbCol1.Items.Add(el3);
                    lsbCol1.Items.Add(el1);
                    lsbCol1.Items.Add(el4);
                    lsbCol1.Items.Add(el2);

                    //Populate column B
                    lsbCol2.Items.Add(vl4);
                    lsbCol2.Items.Add(vl5);
                    lsbCol2.Items.Add(vl1);
                    lsbCol2.Items.Add(vl3);
                    lsbCol2.Items.Add(vl6);
                    lsbCol2.Items.Add(vl7);
                    lsbCol2.Items.Add(vl2);
                }
                else if (switcher == false)
                {
                    //Populate column A
                    lsbCol1.Items.Add(vl3);
                    lsbCol1.Items.Add(vl1);
                    lsbCol1.Items.Add(vl4);
                    lsbCol1.Items.Add(vl2);

                    //Populate column B
                    lsbCol2.Items.Add(el4);
                    lsbCol2.Items.Add(el5);
                    lsbCol2.Items.Add(el1);
                    lsbCol2.Items.Add(el3);
                    lsbCol2.Items.Add(el6);
                    lsbCol2.Items.Add(el7);
                    lsbCol2.Items.Add(el2);
                }


                //Hides all panels
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Complete your current task or exit the application.");
            }


        }

        //variables for list box items and counters for points
        string item1 { get; set; }
        string item2 { get; set; }
        int count = 0;
        int internalCount = 0;


        private void btnSubmitIdent_Click(object sender, EventArgs e)
        {
            //sets strings to text of selected items in list boxes
            item1 = lsbCol1.GetItemText(lsbCol1.SelectedItem);
            item2 = lsbCol2.GetItemText(lsbCol2.SelectedItem);

            //IF statements to check for matching KeyValue pairs and adding/subtracting of points
            if (item1 == el1 && item2 == vl1)
            {
                count++;
                count++;
                count++;
                panel2.Visible = true;
                MessageBox.Show("SUCCESS! Your score is : " + count);
            }
            else if (item1 == el2 && item2 == vl2)
            {
                count++;
                count++;
                count++;
                panel4.Visible = true;
                MessageBox.Show("SUCCESS! Your score is : " + count);
            }
            else if (item1 == el3 && item2 == vl3)
            {
                count++;
                count++;
                count++;
                panel1.Visible = true;
                MessageBox.Show("SUCCESS! Your score is : " + count);
            }
            else if (item1 == el4 && item2 == vl4)
            {
                count++;
                count++;
                count++;
                panel3.Visible = true;
                MessageBox.Show("SUCCESS! Your score is : " + count);
            }
            else if (item1 == el5 && item2 == vl5)
            {
                count++;
                count++;
                count++;
                MessageBox.Show("SUCCESS! Your score is : " + count);
            }
            else if (item1 == el6 && item2 == vl6)
            {
                count++;
                count++;
                count++;
                MessageBox.Show("SUCCESS! Your score is : " + count);
            }
            else if (item1 == el7 && item2 == vl7)
            {
                count++;
                count++;
                count++;
                MessageBox.Show("SUCCESS! Your score is : " + count);
            }
            else if (item1 == vl1 && item2 == el1) //SECOND CONDITIONS
            {
                count++;
                count++;
                count++;
                panel2.Visible = true;
                MessageBox.Show("SUCCESS! Your score is : " + count);
            }
            else if (item1 == vl2 && item2 == el2)
            {
                count++;
                count++;
                count++;
                panel4.Visible = true;
                MessageBox.Show("SUCCESS! Your score is : " + count);
            }
            else if (item1 == vl3 && item2 == el3)
            {
                count++;
                count++;
                count++;
                panel1.Visible = true;
                MessageBox.Show("SUCCESS! Your score is : " + count);
            }
            else if (item1 == vl4 && item2 == el4)
            {
                count++;
                count++;
                count++;
                panel3.Visible = true;
                MessageBox.Show("SUCCESS! Your score is : " + count);
            }
            else if (item1 == vl5 && item2 == el5)
            {
                count++;
                count++;
                count++;
                MessageBox.Show("SUCCESS! Your score is : " + count);
            }
            else if (item1 == vl6 && item2 == el6)
            {
                count++;
                count++;
                count++;
                MessageBox.Show("SUCCESS! Your score is : " + count);
            }
            else if (item1 == vl7 && item2 == el7)
            {
                count++;
                count++;
                count++;
                MessageBox.Show("SUCCESS! Your score is : " + count);
            }
            else
            {
                count--;
                count--;
                MessageBox.Show("INCORRECT! Your score is : " + count);
            }

            //IF statement to check if all 4 column A items have been matched and add to the counter
            //4 visible panels show that all items have been matched and therefore a new game must be started
            if(panel1.Visible == true && panel2.Visible == true && panel3.Visible == true && panel4.Visible == true)
            {
                internalCount++;
            }
            

            //Keeps internal count and clears items for new game every time all correct selections have been made
            if (internalCount == 1)
            {
                lsbCol1.Items.Clear();
                lsbCol2.Items.Clear();
                Descriptions.Clear();
                internalCount--;
                MessageBox.Show("Congratulations you have completed the task!" + "\n" + "Click START to play again");
            }
            
        }
    }
}
