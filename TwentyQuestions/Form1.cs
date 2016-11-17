using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwentyQuestions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Question root;
        Question current;

        private void Form1_Load(object sender, EventArgs e)
        {
            root = new Question();
            root.question = "Is it hot?";
            //root.yes = new Question();
            //root.yes.question = "Is it coffee?";
            //root.no = new Question();
            //root.no.question = "Is it tea?";

            current = root;
            QuestionLabel.Text = current.question; 
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            if(current.IsLeaf()) //correct guess, end of the line
            {
                if (MessageBox.Show("I win! Do you want to play again?", "Twenty Q", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //relaunch game?
                    current = root;
                    QuestionLabel.Text = current.question;
                    
                }
                else
                {
                    //shut it down!
                    this.Close();
                }
            }
            else //correct guess, not a leaf
            {
                // move down the yes branch
                current = current.yes;
                QuestionLabel.Text = current.question;
            }
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            if(current.IsLeaf()) //wrong guess, end of the line
            {
                // ask user for answer they were thinking of, and better question
                // collect user data
                // use data to build new question to replace 
                AddNewItem newItem = new AddNewItem();
                if (newItem.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else    
            {
                current = current.no;
                QuestionLabel.Text = current.question;
            }
        }

        public void addQuestion(string userHintQ, string userAnswer)
        {

            // grabbing user input from form 2
            // manipulate tree
            string oldQ = current.question;
            current.question = userHintQ;
            current.no = new Question(oldQ);
            current.yes = new Question(userAnswer);

            QuestionLabel.Text = current.question;

            //////////////////////////////////////
            //Question tmp = new Question(current);




            //////////////////////////////////////
        }
    }
}
