using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Woodward_Ethan_Chapter6
{
    public partial class Form1 : Form
    {
        private AutoShop shop = new AutoShop();

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearOilLub()
        {
            chkbxOilChange.Checked  = false;
            chkbxLubeJob.Checked    = false;
        }

        private void ClearFlushes()
        {
            chkbxRadFlush.Checked   = false;
            chkbxTransFlush.Checked = false;
        }

        private void ClearMisc()
        {
            chkbxInspection.Checked     = false;
            chkbxReplaceMuffler.Checked = false;
            chkbxTireRot.Checked        = false;
        }

        private void ClearOther()
        {
            txtbxParts.Clear();
            txtbxLabor.Clear();
        }

        private void ClearFees()
        {
            txtbxServicesAndLabor.Clear();
            txtbxPartsSummary.Clear();
            txtbxTax.Clear();
            txtbxTotal.Clear();
        }

        private void ClearAll()
        {
            ClearOilLub();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();

            chkbxOilChange.Focus();
        }

        private void Calculate()
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(shop.OilLubCharges(chkbxOilChange.Checked, chkbxLubeJob.Checked).ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(shop.OilLubCharges(chkbxOilChange.Checked, chkbxLubeJob.Checked).ToString());
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
