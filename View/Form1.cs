using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class Form1 : Form
    {
        private readonly DataPuller9 _dataPuller;
        public Form1()
        {
            InitializeComponent();
            _dataPuller = new DataPuller9();
        }

        private void btnInitializeRoutes_Click(object sender, EventArgs e)
        {
            _dataPuller.InitializeRoutes();
        }

        private void btnGetRouteDetails_Click(object sender, EventArgs e)
        {
            ultraGrid1.DataSource = _dataPuller.GetDetailRoute().ToList();
            ultraGrid1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = _dataPuller.PrintText();
        }
    }
}
