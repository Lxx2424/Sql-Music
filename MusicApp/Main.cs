﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.ShowDialog();
        }
    }
}
