using System;
using System.Windows.Forms;

namespace Eve_Market_Data
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //TODO: implement timer to repeat the following on specific intervals
            
            //TODO: create API request

            //TODO: store API response as list of dictionaries

            //TODO: get name from TypeID

            //TODO: get buy orders for item

            //TODO: find highest buy order by price

            //TODO: get sell orders for item

            //TODO: get lowest sell order by price

            //TODO: calculate margin, output to data grid

            //TODO: get volume for item, output to data grid

        }

        private void itemsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO: implement secondary form for item details with order history
        }
    }
}
