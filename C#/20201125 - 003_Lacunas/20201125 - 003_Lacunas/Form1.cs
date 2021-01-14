﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20201125___003_Lacunas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = 0;
            string result = "";

            string[] islands = new string[4];
            int[] index = new int[4];

            index[0] = 1;
            index[1] = 3;
            index[2] = 0;
            index[3] = 2;

            islands[0] = "Bermuda";
            islands[1] = "Fiji";
            islands[2] = "Azores";
            islands[3] = "Cozumel";

            int refNum;
            while (y < 4)
            {
                refNum = index[y];

                result += "\nisland = ";
                result += islands[refNum];

                y = y + 1;
            }
            MessageBox.Show(result);
        }
    }
}