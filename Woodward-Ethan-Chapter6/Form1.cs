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

        /* Private Constant Class Variables */
        private const double OIL_CHANGE_COST      = 26.00;
        private const double LUBE_JOB_COST        = 18.00;
        private const double RAD_FLUSH_COST       = 30.00;
        private const double TRANS_FLUSH_COST     = 80.00;
        private const double INSPECTION_COST     = 15.00;
        private const double REPLACE_MUFFLER_COST = 100.00;
        private const double TIRE_ROT_COST        = 20.00;
        
        /* Private Class Variables */
        private double partsCost = 0.00;
        private double laborCost = 0.00;

        public Form1()
        {
            InitializeComponent();
        }

        /* Returns Cost of Oil and Lub Change (if applicable) */
        public double OilLubCharges()
        {
            double charges = 0.0;

            charges += chkbxOilChange.Checked ? OIL_CHANGE_COST : 0.0;
            charges += chkbxLubeJob.Checked ? LUBE_JOB_COST : 0.0;

            return charges;
        }

        /* Returns Cost of Radiator and Transmission Flushes (if applicable) */
        public double FlushCharges()
        {
            double charges = 0.0;

            charges += chkbxRadFlush.Checked ? RAD_FLUSH_COST : 0.0;
            charges += chkbxTransFlush.Checked ? TRANS_FLUSH_COST : 0.0;

            return charges;
        }

        /* Returns Cost of Misc. Services (if applicable) */
        public double MiscCharges()
        {
            double charges = 0.0;

            charges += chkbxInspection.Checked ? INSPECTION_COST : 0.0;
            charges += chkbxReplaceMuffler.Checked ? REPLACE_MUFFLER_COST : 0.0;
            charges += chkbxTireRot.Checked ? TIRE_ROT_COST : 0.0;

            return charges;
        }

        /* Returns Cost of Charges Related To Order Parts and Additional Labor (if applicable) */
        public double OtherCharges()
        {
            return partsCost + laborCost;
        }

        /* Returns Cost of Tax on Ordered Parts (if applicable) */
        public double TaxCharges()
        {
            return partsCost * 0.06;
        }

        /* Returns Total Cost of ALL services and parts provided */
        public double TotalCharges()
        {
            return OilLubCharges() + FlushCharges() + MiscCharges() + OtherCharges() + TaxCharges();
        }

        /*** FORM CLEARING METHODS ***/

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

        /* Calculates and Populates appropriate fields of form */
        private void Calculate()
        {
            try
            {
                partsCost = Double.Parse(txtbxParts.Text);
                laborCost = Double.Parse(txtbxLabor.Text);

                txtbxServicesAndLabor.Text = (OilLubCharges() + FlushCharges() + MiscCharges()).ToString("C");
                txtbxPartsSummary.Text      = OtherCharges().ToString("C");
                txtbxTax.Text               = TaxCharges().ToString("C");
                txtbxTotal.Text             = TotalCharges().ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("One or both Textboxes empty/contain invalid values");
                ClearOther();
                txtbxParts.Focus();
            }
        }

        /*** EVENT METHODS ***/
        private void btnCalc_Click(object sender, EventArgs e)
        {
            Calculate();
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
            Calculate();
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
