﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXCEL2020
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();

            SubmitButton.Enabled = false;
            CancelButton.Enabled = false;
        }
    }
}
