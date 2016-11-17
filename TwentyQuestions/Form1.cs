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
            root.yes = new Question();
            root.yes.question = "Is it coffee?";
            root.no = new Question();
            root.no.question = "Is it tea?";

            current = root;
            QuestionLabel.Text = current.question; 
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            if(current.IsLeaf())
            {
                if (MessageBox.Show("I win! Do you want to play again?", "Twenty Q", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                else
                {
                    //relaunch game?   
                }
            }
            else
            {
                current = new Question( )
            }
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            if(current.IsLeaf())
            {

            }
            //am I at a leaf?
            //no: ask the next question
            //yes: new thing... go learn stuff
            // Do you want to play again?

            AddNewItem add = new AddNewItem();
            if(add.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
