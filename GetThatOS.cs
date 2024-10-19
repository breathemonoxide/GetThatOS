﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using GetThatOS.Menus;

namespace GetThatOS
{
    public partial class GetThatOS : Form
    {
        public GetThatOS()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/breathemonoxide/GetThatOS");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WIndows win = new WIndows();
            win.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Linux lin = new Linux();
            lin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MacOS macOS = new MacOS();
            macOS.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            More more = new More();
            more.Show();
        }
    }
}