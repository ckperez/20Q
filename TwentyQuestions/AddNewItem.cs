﻿using System;
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
    public partial class AddNewItem : Form
    {
        public AddNewItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["Form1"] != null)
            {
                (Application.OpenForms["Form1"] as Form1).addQuestion(this.userHintQ.Text, this.userAnswer.Text);
                this.Close(); 
            }
           
        }
    }
}
