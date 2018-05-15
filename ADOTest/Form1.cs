using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADOTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'заказыDataSet.Заказы' table. You can move, or remove it, as needed.
            this.заказыTableAdapter.Fill(this.заказыDataSet.Заказы);
            // TODO: This line of code loads data into the 'заказыDataSet.Заказы' table. You can move, or remove it, as needed.
            this.заказыTableAdapter.Fill(this.заказыDataSet.Заказы);
            // TODO: This line of code loads data into the 'заказыDataSet.Вузы' table. You can move, or remove it, as needed.
            this.вузыTableAdapter.Fill(this.заказыDataSet.Вузы);
            // TODO: This line of code loads data into the 'заказыDataSet.Заказы' table. You can move, or remove it, as needed.
            this.заказыTableAdapter.Fill(this.заказыDataSet.Заказы);
            // TODO: This line of code loads data into the 'заказыDataSet.Заказы' table. You can move, or remove it, as needed.
            this.заказыTableAdapter.Fill(this.заказыDataSet.Заказы);
            // TODO: This line of code loads data into the 'заказыDataSet.Предметы' table. You can move, or remove it, as needed.
        }
    }
}