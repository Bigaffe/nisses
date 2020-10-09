using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nisses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bilBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bilBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nissesbilarDataSet);

        }

        private void bilBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bilBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nissesbilarDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nissesbilarDataSet3.uthyrning' table. You can move, or remove it, as needed.
            this.uthyrningTableAdapter.Fill(this.nissesbilarDataSet3.uthyrning);
            // TODO: This line of code loads data into the 'nissesbilarDataSet2.kund' table. You can move, or remove it, as needed.
            this.kundTableAdapter.Fill(this.nissesbilarDataSet2.kund);
            // TODO: This line of code loads data into the 'nissesbilarDataSet1.grupp' table. You can move, or remove it, as needed.
            this.gruppTableAdapter.Fill(this.nissesbilarDataSet1.grupp);
            // TODO: This line of code loads data into the 'nissesbilarDataSet.bil' table. You can move, or remove it, as needed.
            this.bilTableAdapter.Fill(this.nissesbilarDataSet.bil);

        }
    }
}
