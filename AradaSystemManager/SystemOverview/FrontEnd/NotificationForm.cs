﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AradaSystemManager.SystemOverview.FrontEnd
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();            
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}