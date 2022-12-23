using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP
{
    public partial class Beds : Form
    {
        public Beds()
        {
            InitializeComponent();
        }

        private void Beds_Load(object sender, EventArgs e)
        {
            this.pricelistTableAdapter.FillByBed(this.databaseDataSet.Pricelist);
        }     
    }
}
