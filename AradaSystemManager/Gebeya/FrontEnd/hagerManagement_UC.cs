using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AradaSystemManager.Gebeya.FrontEnd;

namespace AradaSystemManager.Gebeya.FrontEnd
{
    public partial class hagerManagement_UC : UserControl
    {
        public hagerManagement_UC()
        {
            InitializeComponent();            
        }

        private void otherReports_btn_Click(object sender, EventArgs e)
        {
            hagerOtherReportsForm h1 = new hagerOtherReportsForm();
            h1.Show();
        }

        private void giftUser_btn_Click(object sender, EventArgs e)
        {
            giftHagerForm g1 = new giftHagerForm();
            g1.Show();
        }

        private void createHager_btn_Click(object sender, EventArgs e)
        {
            createHagerForm c1 = new createHagerForm();
            c1.Show();
        }
    }
}
