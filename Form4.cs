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

        //NODES TO BE USED IN BINARY TREE
        //https://www.csharpstar.com/csharp-program-to-implement-binary-search-tree/
        public class Node
        {
            public string key;
            public Node left, right;

            public Node(string item)
            {
                key = item;
                left = right = null;
            }
        }

        //BINARY TREE OF NODES
        public class BinaryTree
        {

            //ROOT OF BINARY TREE
            public Node root;

            //CONSTRUCTORS
            public BinaryTree(string key)
            {
                root = new Node(key);
            }

            public BinaryTree()
            {
                root = null;
            }

        }

        //STRINGS TO STORE ITEMS SO THAT THEY CAN BE ACCESSED FOR CHECKING UNDER THE SUBMIT BUTTONS
        string item1 { get; set; }
        string item2 { get; set; }
        string item3 { get; set; }

        //INT COUNT FOR GAMIFICATION FEATURE
        int count = 0;

        //LIST OF LEVEL 1, 2 & 3 ITEMS ACCESSIBLE FROM ANY CLASS FOR CHECKING
        List<string> lsb1 = new List<string>();
        List<string> lsb2 = new List<string>();
        List<string> lsb3 = new List<string>();


        private void btnStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I have removed the Call numbers from the list " +
                "\nas it would defeat the purpose of learning. " +
                "\nIf the user can see the call number then the only real difficulty " +
                "\ncomes from selecting the correct level 1 item.");
            
            lsbDewey.Items.Clear();
            label1.Text = "";

            //LISTS OF CALL NUMBERS AND DESCRIPTIONS
            List<string> listNum = new List<string>();
            List<string> listCall = new List<string>();

            //LISTS OF ALL LEVEL 1, 2 & 3 ITEMS
            List<string> lev1 = new List<string>();
            List<string> lev2 = new List<string>();
            List<string> lev3 = new List<string>();

            //LISTS OF DESCRIPTIONS
            List<string> desclv3 = new List<string>();
            List<string> desclv1 = new List<string>();

            List<string> callDesc = new List<string>();

            //CREATE INSTANCE OF BINARY TREE
            BinaryTree tree = new BinaryTree();

            //READING FROM THE TEXT FILE IN ORDER TO POPULATE LISTS AND BINARY TREE NODES
            using (StreamReader r = new StreamReader(@"..\DEWEY.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    listNum.Add(line);
                    listCall.Add(line);
                }
            }


            foreach (string line in listNum)
            {
                string stringBeforeChar = line.Substring(0, line.IndexOf("-"));
                string stringAfterChar = line.Substring(line.IndexOf("-") + 1);
                string stringAfterChar2 = line.Substring(line.IndexOf("-") + 1);
                string wholeLine = line;

                callDesc.Add(wholeLine);

                //GETS FIRST, SECOND AND THIRD DIGIT OF CALL NUMBER
                string digit1 = stringBeforeChar.Substring(0, 1);

                string digit2 = stringBeforeChar.Substring(1, 1);

                string digit3 = stringBeforeChar.Substring(2, 1);


                //IF STATEMENTS TO CHECK IF A DESCRIPTION BELONGS TO LEVEL 1, 2 OR 3
                //Level 1
                if (digit2 == "0" && digit3 == "0")
                {
                    lev1.Add(stringBeforeChar);
                    desclv1.Add(stringAfterChar2);
                    lsb1.Add(stringAfterChar);
                }
                //Level 2
                if (digit3 == "0" && digit2 != "0")
                {
                    lev2.Add(stringBeforeChar);
                    lsb2.Add(stringAfterChar);
                }
                //Level 3
                if (digit3 != "0")
                {
                    lev3.Add(stringBeforeChar);
                    desclv3.Add(stringAfterChar);
                    lsb3.Add(stringAfterChar);
                }

                //MAKE SUBMISSION BUTTON VISIBLE
                panel1.Visible = false;
            }


            //CREATES A RANDOOM
            Random rnd = new Random();

            //FINDS A RANDOM LEVEL 3 ITEM FROM THE LIST OF LEVEL 3'S
            //THIS IS USED TO GIVE THE USER THEIR QUESTION TO WORK TOWARDS FINDING
            string question = desclv3[rnd.Next(90)];

            //SETS THE QUESTION FOR THE USER TO FIND THE ANSWER
            label1.Text = "Your question is : " + question;



            //GOES THROUGH EACH LINE OF THE TEXT FILE THAT IS STORED IN THE LIST
            foreach (string full in callDesc)
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
                    foreach (string search in callDesc)
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
                            //MessageBox.Show("Level 1 is - " + search);
                            tree.root = new Node(search);
                        }

                        //THIS FINDS THE LEVEL 2
                        if (matchDigit1 == searchDigit1 && matchDigit2 == searchDigit2 && matchDigit3 == "0")
                        {
                            //MessageBox.Show("Level 2 is - " + search);
                            tree.root.left = new Node(search);
                        }
                    }


                    //THIS IS THE LEVEL 3
                    //MessageBox.Show("Level 3 is - " + fullLine);
                    tree.root.left.left = new Node(fullLine);
                }

            }

            string lvl1ans = lev1.ToString() + desclv1.ToString();

            //ADDS ITEMS TO THE BINARY TREE
            item1 = tree.root.key;
            item2 = tree.root.left.key;
            item3 = tree.root.left.left.key;


            // THIS WORKS
            //MessageBox.Show("level 1 is " + item1);
            //MessageBox.Show("level 2 is " + item2);
            //MessageBox.Show("level 3 is " + item3);


            string lsbItem1 = item1.Substring(4);
            lsbDewey.Items.Add(lsbItem1);

            //ADDS 3 RANDOM LEVEL 1'S TO THE LIST BOX
            //ADDS THE CORRECT ITEM FROM THE NODE TO THE LIST BOX
            for (int i = 0; i < 3; i++)
            {
                lsbDewey.Items.Add(lsb1[rnd.Next(10)]);
            }
            
        }




        private void btnSub1_Click(object sender, EventArgs e)
        {
            string check1 = lsbDewey.GetItemText(lsbDewey.SelectedItem);
            string checkNode1 = item1.Substring(4);

            Random rnd = new Random();

            if (check1 == checkNode1)
            {
                MessageBox.Show("YOU ARE CORRECT!");
                lsbDewey.Items.Clear();

                for (int i = 0; i < 3; i++)
                {
                    lsbDewey.Items.Add(lsb2[rnd.Next(10)]);
                }
                string lsbItem2 = item2.Substring(4);
                lsbDewey.Items.Add(lsbItem2);
                panel1.Visible = true;
                panel2.Visible = false;
            }
            else
            {
                MessageBox.Show("You are incorrect! Please click 'start' to try again.");
                lsbDewey.Items.Clear();
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
            }
        }

        private void btnSub2_Click(object sender, EventArgs e)
        {
            string check2 = lsbDewey.GetItemText(lsbDewey.SelectedItem);
            string checkNode2 = item2.Substring(4);

            Random rnd = new Random();

            if (check2 == checkNode2)
            {
                MessageBox.Show("YOU ARE CORRECT!");
                lsbDewey.Items.Clear();

                string lsbItem3 = item3.Substring(4);
                lsbDewey.Items.Add(lsbItem3);

                for (int i = 0; i < 3; i++)
                {
                    lsbDewey.Items.Add(lsb3[rnd.Next(10)]);
                }
                
                panel2.Visible = true;
                panel3.Visible = false;
            }
            else
            {
                MessageBox.Show("You are incorrect! Please click 'start' to try again.");
                lsbDewey.Items.Clear();
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
            }
        }

        private void btnSub3_Click(object sender, EventArgs e)
        {
            string check3 = lsbDewey.GetItemText(lsbDewey.SelectedItem);
            string checkNode3 = item3.Substring(4);

            if (check3 == checkNode3)
            {
                count++;
                count++;
                count++;
                lsbDewey.Items.Clear();
                MessageBox.Show("Game won! Your score is : " + count);
                panel3.Visible = true;
            }
            else
            {
                count--;
                count--;
                MessageBox.Show("You are incorrect! Please click 'start' to try again.");
                lsbDewey.Items.Clear();
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
