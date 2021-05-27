using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AradaSystemManager.Prime_UCs
{
    public partial class UserControl1 : UserControl
    {
        private Color selected = Color.FromArgb(210, 163, 164);
        private Color unselected = Color.FromArgb(245, 248, 250);
        public UserControl1()
        {
            InitializeComponent();
        }

        private void sysOverview_btn_MouseEnter(object sender, EventArgs e)
        {
            sysOverview_btn.BackColor = selected;
        }

        private void sysOverview_btn_MouseLeave(object sender, EventArgs e)
        {
            sysOverview_btn.BackColor = unselected;
        }

        private void gameService_btn_MouseEnter(object sender, EventArgs e)
        {
            gameService_btn.BackColor = selected;
        }

        private void gameService_btn_MouseLeave(object sender, EventArgs e)
        {
            gameService_btn.BackColor = unselected;
        }

        private void advService_btn_MouseEnter(object sender, EventArgs e)
        {
            advService_btn.BackColor = selected;
        }

        private void advService_btn_MouseLeave(object sender, EventArgs e)
        {
            advService_btn.BackColor = unselected;
        }

        private void giftService_btn_MouseEnter(object sender, EventArgs e)
        {
            giftService_btn.BackColor = selected;
        }

        private void giftService_btn_MouseLeave(object sender, EventArgs e)
        {
            giftService_btn.BackColor = unselected;
        }

        private void walletService_btn_MouseEnter(object sender, EventArgs e)
        {
            walletService_btn.BackColor = selected;
        }

        private void walletService_btn_MouseLeave(object sender, EventArgs e)
        {
            walletService_btn.BackColor = unselected;
        }

        private void gebeyaService_btn_MouseEnter(object sender, EventArgs e)
        {
            gebeyaService_btn.BackColor = selected;
        }

        private void gebeyaService_btn_MouseLeave(object sender, EventArgs e)
        {
            gebeyaService_btn.BackColor = unselected;
        }

        private void sysOverview_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
