using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace LibraryTrainingApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        class archary
        {
            string a;
            string b;
            public archary()
            {

            }

            public archary(string a, string b)
            {
                this.a = a;
                this.b = b;
            }
        }

        //NODES NEED TO BE CREATED HERE SO THAT THEY ARE ACCESSABLE BY ALL BUTTONS


        private void btnStart_Click(object sender, EventArgs e)
        {
            List<string> listNum = new List<string>();
            List<string> listCall = new List<string>();
            List<archary> ar = new List<archary>();
            
            List<string> lev1 = new List<string>();
            List<string> lev2 = new List<string>();
            List<string> lev3 = new List<string>();

            List<string> desclv3 = new List<string>();
            List<string> desclv1 = new List<string>();

            List<string> callDesc = new List<string>();



            //THE CODE BELOW ALONG WITH THE LISTS NEED TO BE ADDED UNDER EVERY BUTTON
            //THIS IS SO THAT THE APPROPRIATE LEVEL OF ITEMS CAN BE POPULATED WHEN THE USER GETS THE ANSWER CORRECT

            using (StreamReader r = new StreamReader(@"..\DEWEY.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    listNum.Add(line);
                    listCall.Add(line);
                }
            }
            
            foreach(string line in listNum)
            {
                string stringBeforeChar = line.Substring(0, line.IndexOf("-"));
                string stringAfterChar = line.Substring(line.IndexOf("-") + 1);
                string stringAfterChar2 = line.Substring(line.IndexOf("-") + 1);
                string wholeLine = line;

                callDesc.Add(wholeLine);


                archary archary = new archary(stringBeforeChar, stringAfterChar);
                ar.Add(archary);

                string digit1 = stringBeforeChar.Substring(0, 1);

                string digit2 = stringBeforeChar.Substring(1, 1);

                string digit3 = stringBeforeChar.Substring(2, 1);

                

                //Level 1
                if (digit2 == "0" && digit3 == "0")
                {
                    lev1.Add(stringBeforeChar);
                    desclv1.Add(stringAfterChar2);
                    //MessageBox.Show("level 1 - " + stringBeforeChar);
                }
                //Level 2
                if (digit3 == "0" && digit2 != "0")
                {
                    lev2.Add(stringBeforeChar);
                    //MessageBox.Show("level 2 - " + stringBeforeChar);
                }
                //Level 3
                if (digit3 != "0")
                {
                    
                    lev3.Add(stringBeforeChar);
                    desclv3.Add(stringAfterChar);
                }

                //you can find a random level 3 already. you then know what its level 2 is by the 1st and 2nd digit
                //WATCH THE VIDEO


            }
            
            
            //CREATES A RANDOOM
            Random rnd = new Random();

            //FINDS A RANDOM LEVEL 3 ITEM FROM THE LIST OF LEVEL 3'S
            //THIS IS USED TO GIVE THE USER THEIR QUESTION TO WORK TOWARDS FINDING
            string question = desclv3[rnd.Next(90)];

            label1.Text = question;


            //ADDS 3 RANDOM LEVEL 1'S TO THE LIST BOX
            //THE 4TH NEEDS TO BE THE CORRECT LEVEL 1
            //NEED TO DO THIS FOR ALL LEVELS UNDER THE APPROPRIATE BUTTONS
            for (int i = 0; i < 3; i++)
            {
                lsbDewey.Items.Add(desclv1[rnd.Next(10)]);
            }
            //lsbDewey.Items.Add()
            

            //GOES THROUGH EACH LINE OF THE TEXT FILE THAT IS STORED IN THE LIST
            foreach(string full in callDesc)
            {   
                //GETS THE ITEM IN THE LIST TO A STRING
                string fullLine = full.Substring(0);

                string fulldigit1 = fullLine.Substring(0, 1);

                string fulldigit2 = fullLine.Substring(1, 1);

                string fulldigit3 = fullLine.Substring(2, 1);


                //IF THE STRING MATCHES THE RANDOM LEVEL 3 QUESTION WHICH HAS BEEN CHOSEN FOR THE USER
                if (fullLine.Contains(question))
                {
                    //THEN SEARCHES EACH STRING IN THE LIST TO FIND THE LEVEL 2 AND LEVEL 1 PARENTS OF THE RANDOM LEVEL 3 QUESTION
                    foreach(string search in callDesc)
                    {
                        string searchDigit1 = full.Substring(0, 1);
                        string searchDigit2 = full.Substring(1, 1);
                        string searchDigit3 = full.Substring(2, 1);

                        string matchDigit1 = search.Substring(0, 1);
                        string matchDigit2 = search.Substring(1, 1);
                        string matchDigit3 = search.Substring(2, 1);

                        //THIS FINDS THE LEVEL 1
                        if (matchDigit1 == searchDigit1 && matchDigit2 == "0" && matchDigit3 == "0")
                        {
                            MessageBox.Show("Level 1 is - " + search);
                        }

                        //THIS FINDS THE LEVEL 2
                        if (matchDigit1 == searchDigit1 && matchDigit2 == searchDigit2 && matchDigit3 == "0")
                        {
                            MessageBox.Show("Level 2 is - " + search);
                        }
                    }
                    
                    
                    //THIS IS THE LEVEL 3
                    MessageBox.Show("Level 3 is - " + fullLine);
                }

            }
            //NOW ADD TO NODES

            


            string lvl1ans = lev1.ToString() + desclv1.ToString();


            lsbDewey.Items.Add(desclv1);

            //var output = File.ReadLines(@"..\DEWEY.txt").Where(line => line.Split(',')[1] == question).FirstOrDefault();

            //MessageBox.Show("working - " + output);

            //MessageBox.Show("" + fullLine);
            //MessageBox.Show("" + fulldigit1);
            //MessageBox.Show("" + fulldigit2);
            //MessageBox.Show("" + fulldigit3);


            //lsbDewey.Items.Add(lev2[rnd.Next(90)]);

            //lsbDewey.Items.Add(lev3[rnd.Next(90)]);

            //lsbDewey.Items.Add(list[rnd.Next(198)]);
        }




        private void btnSub1_Click(object sender, EventArgs e)
        {
            HashSet<string> strings = new HashSet<string>(File.ReadAllLines(@"..\DEWEY.txt"));


            if (strings.Contains("00"))
            {
                MessageBox.Show("Found");
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }

        private void btnSub2_Click(object sender, EventArgs e)
        {

        }

        private void btnSub3_Click(object sender, EventArgs e)
        {

        }
    }
}
