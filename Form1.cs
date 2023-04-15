using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        int[] Ticket;
        bool ActiveCredit = false;
        int balance = 1000, win = 0,count = 0, WinningField = 0, debt = 0;
        void result()
        {
            Bu11.Text = (Ticket[0] == 1) ? "W" : "";
            Bu12.Text = (Ticket[1] == 1) ? "W" : "";
            Bu21.Text = (Ticket[2] == 1) ? "W" : "";
            Bu22.Text = (Ticket[3] == 1) ? "W" : "";
            groupBox1.Enabled = false;
        }
        private void StartGame_Click(object sender, EventArgs e)
        {
            ControlGame.Visible = true;
            BuyTicketButton.Enabled = true;
            ScoreText.Visible = true;
            ScoreCount.Text = "" + balance;
            ScoreCount.Visible = true;
            NameOfGame.Visible = false;
            groupBox1.Visible = false;
            FAQButton.Visible = false;
            ExitButton.Visible = false;
            CancelButton.Visible = true;
            BuyTicketButton.Visible = true;
            StartGame.Visible = false;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            balance = 1000;
            ControlGame.Visible = false;
            Bu11.Visible = Bu12.Visible = Bu21.Visible = Bu22.Visible = false;
            groupBox1.Enabled = true;
            NameOfGame.Visible = true;
            groupBox1.Visible = true;
            FAQButton.Visible = true;
            ExitButton.Visible = true;
            CancelButton.Visible = false;
            BuyTicketButton.Visible = false;
            StartGame.Visible = true;
            ScoreText.Visible = false;
            ScoreCount.Visible = false;

        }
        private void CreditButton_Click(object sender, EventArgs e)
        {
            CreditButton.Visible = false;
            debt = 525;
            ActiveCredit = true;
            BuyTicketButton.Enabled = true;
            balance = 500;
            StartGame_Click(sender, e);
        }
        private void PickUpButton_Click(object sender, EventArgs e)
        {
            if(!ActiveCredit)
            {
                WinningField = 0;
                BuyTicketButton.Enabled = true;
                PickUpButton.Visible = false;
                balance += 150;
                ScoreCount.Text = "" + balance;
                result();
            }
            else
            {
                debt -= 25;
                WinningField = 0;
                BuyTicketButton.Enabled = true;
                PickUpButton.Visible = false;
                balance += 125;
                ScoreCount.Text = "" + balance;
                result();
                if (debt == 0) ActiveCredit = false;
            }

        }
        private void BuyTicketButton_Click(object sender, EventArgs e)
        {
            BuyTicketButton.Enabled = false;
            balance -= 100;
            ScoreCount.Text = "" + balance;
            groupBox1.Visible = true;
            List<int> spisok = new List<int> { };
            Ticket = new int[4];
            for (int i = 0; i < 4; i++) Ticket[i] = -1; // clear massive
            bool boolvar = true;
            while(boolvar)
            {
                for (int i = 0; i < 4; i++)
                {
                    Ticket[i] = rand.Next(2);
                    spisok.Add(Ticket[i]);
                }
                foreach (int i in spisok) if (i == 1) count++;
                if (count == 2) boolvar = false;
                else spisok.Clear();
                count = 0;
            }
            groupBox1.Enabled = true;
            Bu11.Visible = Bu12.Visible = Bu21.Visible = Bu22.Visible = true;
            Bu11.Enabled = Bu12.Enabled = Bu21.Enabled = Bu22.Enabled = true;
            Bu11.Text = Bu12.Text = Bu21.Text = Bu22.Text = "?";
        }
        private void Bu11_Click(object sender, EventArgs e)
        {
            int i = 0;
            switch ((sender as Button).Name)
            {
                case "Bu11": i = 0; break;
                case "Bu12": i = 1; break;
                case "Bu21": i = 2; break;
                case "Bu22": i = 3; break;
            }
            if (Ticket[i] == 1)
            {
                WinningField++;
                (sender as Button).Text = "W";
                (sender as Button).Enabled = false;
                if (WinningField == 1)
                {
                    PickUpButton.Text = "Забрать выигрыш (+150р.)";
                    PickUpButton.Visible = true;
                }
                if (WinningField == 2)
                {
                    if (ActiveCredit)
                    {
                        debt -= 100;
                        balance += 400;
                        ScoreCount.Text = "" + balance;
                        WinningField = 0;
                        PickUpButton.Visible = false;
                        BuyTicketButton.Enabled = true;
                        result();
                    }
                    else
                    {
                        balance += 500;
                        ScoreCount.Text = "" + balance;
                        WinningField = 0;
                        PickUpButton.Visible = false;
                        BuyTicketButton.Enabled = true;
                        result();
                    }
                }
            }
            else
            {
                PickUpButton.Visible = false;
                BuyTicketButton.Enabled = true;
                WinningField = 0;
                (sender as Button).Text = "";
                (sender as Button).Enabled = false;
                (sender as Button).Refresh();
                System.Threading.Thread.Sleep(1000);
                result();
                if (balance < 100)
                {
                    if (!ActiveCredit)
                    {
                        CreditButton.Visible = true;
                        BuyTicketButton.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("G A M E    O V E R");
                        CancelButton_Click(sender, e);
                        balance = 1000;
                    }
                }
            }
        }
    }
}
