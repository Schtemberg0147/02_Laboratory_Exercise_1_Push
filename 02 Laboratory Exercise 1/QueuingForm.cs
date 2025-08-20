using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Laboratory_Exercise_1
{
    public partial class QueuingForm : Form
    {
        CashierClass cashier;
        CashierWindowQueueForm cashierWindowQueueForm;
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            cashierWindowQueueForm = new CashierWindowQueueForm();
            cashierWindowQueueForm.Show(); //Show the CashierWindowQueueForm when the QueuingForm is initialized
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {

        }

        public class CashierClass //Create Cashier Class
        {
            private int x;
            public static string getNumberInQueue = "";
            public static Queue<string> CashierQueue;

            public CashierClass()
            {
                x = 10000;
                CashierQueue = new Queue<string>();
            }

            public string CashierGeneratedNumber(string CashierNumber)
            {
                x++; //10000 + 1
                CashierNumber = CashierNumber + x.ToString(); //This will be string + "10001"
                return CashierNumber;
            }
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - "); 
            CashierClass.getNumberInQueue = lblQueue.Text; 
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

        }
    }
}
