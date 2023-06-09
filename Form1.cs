﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {   InitializeComponent();
            startingGame(); }
        string[] lines = new string[5];
        int[] arr = new int[5];
        Random rand = new Random();
        int[] Ticket;
        string text = "",text1 = "";
        static string FileName = "C:\\Users\\Ra40k\\source\\repos\\Lottery\\DB.txt", FileName1 = "C:\\Users\\Ra40k\\source\\repos\\Lottery\\GameStatistics.txt";
        bool ActiveCredit = false, ControlGameMODE = false, FIRSTgame = true;
        double Probability;
        int balance = 1000, count = 0, WinningField = 0, debt = 0, GameCount = 0, GambilingMoney = 0, LuckyGame = 0, NoLuckyGame = 0, FirstReuslt,SecondResult, MicroWin, MacroWin, lose, money, ControlGameCount;
        private void button1_Click(object sender, EventArgs e) {System.Diagnostics.Process.Start("https://vk.com/ifpatrick");}
        private void FAQ_SelectedIndexChanged(object sender, EventArgs e){textBox1.Text = "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tДанный раздел предназначен для объяснения работы программы. Игра подразумевает собой лотерею билета с 4 скрытых игровыми полями. В игре присутствует несколько режимов игры: обычный, контрольный, залповый. "; }
        private void button2_Click(object sender, EventArgs e) { textBox1.Text = "В обычном режиме игра начинается при покупке билета за 100 рублей. Изначальный баланс игрока составляет 1000 рублей. Победное поле выделяется буквой 'W', пустое поле автоматически обесценивает билет. При открытии победного поля есть возможность забрать приз 150 рублей, или же попытаться открыть второе победное поле. При открытии второго победного поля счет игрока пополняется на 500 рублей. В случае нехватки денег на покупку билета есть возможность взять кредит, долг которого будет составлять 525 рублей, и покрываться с каждой победы. Малый приз восстанавливает долг на 25 рублей, большой выигрыш на 100 рублей"; }
        private void button3_Click(object sender, EventArgs e) { textBox1.Text = "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tКонтрольный режим подразумевает запись результата игры в базу данных. При первой игре контрольный режим включается автоматически."; }
        private void button4_Click(object sender, EventArgs e){ textBox1.Text = "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tЗалповый режим подразумевает собой анализ игры, расмотренный по двум стратегиям: азартная стратегия, неазартная стратегия. Азартная стратегия подразуемвает собой игру обязательно до двух победных билетов. Неазартная стратегия представляет собой игру до первого победного билета. В конце залпового режима подводятся итоги, включащиеся себя количество побед, проигрышей, вероятность победы и доход игрока"; }


        void buyticketfuntion(){BuyTicketButton.Enabled = false;
            balance -= 100;
            ScoreCount.Text = "" + balance;
            groupBox1.Visible = true;
            List<int> spisok = new List<int> { };
            Ticket = new int[4];
            for (int i = 0; i < 4; i++) Ticket[i] = -1; // clear massive
            bool boolvar = true;
            while (boolvar){ for (int i = 0; i < 4; i++){Ticket[i] = rand.Next(2);
                    spisok.Add(Ticket[i]);}
                foreach (int i in spisok) if (i == 1) count++;
                if (count == 2) boolvar = false;
                else spisok.Clear();
                count = 0;}
            groupBox1.Enabled = true;
            Bu11.Visible = Bu12.Visible = Bu21.Visible = Bu22.Visible = true;
            Bu11.Enabled = Bu12.Enabled = Bu21.Enabled = Bu22.Enabled = true;
            Bu11.Text = Bu12.Text = Bu21.Text = Bu22.Text = "?"; }
        void result()
        {   Bu11.Text = (Ticket[0] == 1) ? "W" : "";
            Bu12.Text = (Ticket[1] == 1) ? "W" : "";
            Bu21.Text = (Ticket[2] == 1) ? "W" : "";
            Bu22.Text = (Ticket[3] == 1) ? "W" : "";
            groupBox1.Enabled = false; }
        void attension(bool x)
        {   if (x){AttensionText1.Visible = true;
                   AttensionText2.Visible = true;
                   AttensionText3.Visible = true; }
            else  {AttensionText1.Visible = false;
                   AttensionText2.Visible = false;
                   AttensionText3.Visible = false;} }
        void statistic() {LuckyGameCount2.Text = "" + LuckyGame;
             NoLuckyGameCount2.Text = "" + NoLuckyGame;
             Income2.Text = "" + GambilingMoney;
             PercentWinning2.Text = "" + Probability; }
        void progressbar() { GameCount = (int)numericUpDown1.Value;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = (int)numericUpDown1.Value;
            progressBar1.Step = 1; }
        void record(){ StreamWriter writer = new StreamWriter(FileName);
            text = "Всего игр: " + ControlGameCount + ";\nПоражений всего: " + lose + ";\nМалых побед всего: " + MicroWin + ";\nБольших побед: " + MacroWin + ";\nДоход: " + money;
            writer.Write(text);
            writer.Close();
            StreamWriter writer1 = new StreamWriter(FileName1);
            text1 = "" + ControlGameCount + "\n" + lose + "\n" + MicroWin + "\n" + MacroWin + "\n" + money;
            writer1.Write(text1);
            writer1.Close();}
        private void startingGame() {for (int i = 0; i < 5; i++) lines[i] = "";
            StreamReader reader = new StreamReader(FileName1);
            string line;
            for(int i =0; i <5; i++){ line = reader.ReadLine();
                lines[i] = line;
                arr[i] = Convert.ToInt32(lines[i]);}
            ControlGameCount = arr[0];
            lose = arr[1];
            MicroWin = arr[2];
            MacroWin = arr[3];
            money = arr[4];
            reader.Close(); }
        private void StartGame_Click(object sender, EventArgs e) { button1.Visible = false;
            ControlGame.Visible = true;
            BuyTicketButton.Enabled = true;
            ScoreText.Visible = true;
            ScoreCount.Text = "" + balance;
            ScoreCount.Visible = true;
            NameOfGame.Visible = false;
            groupBox1.Visible = false;
            ExitButton.Visible = false;
            CancelButton.Visible = true;
            BuyTicketButton.Visible = true;
            StartGame.Visible = false;
            if (FIRSTgame) { attension(true);
                ControlGame.Visible = false;}}
        private void ExitButton_Click(object sender, EventArgs e){Application.Exit();}
        private void CancelButton_Click(object sender, EventArgs e){button1.Visible = true;
            ControlGame.Checked = false;
            attension(false);
            ControlGame.Visible = false;
            ActiveCredit = false;
            debt = 0;
            balance = 1000;
            Bu11.Visible = Bu12.Visible = Bu21.Visible = Bu22.Visible = false;
            groupBox1.Enabled = true;
            NameOfGame.Visible = true;
            groupBox1.Visible = true;
            ExitButton.Visible = true;
            CancelButton.Visible = false;
            BuyTicketButton.Visible = false;
            StartGame.Visible = true;
            ScoreText.Visible = false;
            ScoreCount.Visible = false;}
        private void PlayGambilingMode_Click(object sender, EventArgs e) {PlayNoGambilingMode.Enabled = false;
            progressbar();
            for (int i = 0; i < GameCount; i++){ progressBar1.PerformStep();
                GambilingMoney -= 100;
                FirstReuslt = rand.Next(0, 2);
                SecondResult = rand.Next(0, 2);
                if (FirstReuslt == 0 && SecondResult == 0){GambilingMoney += 500;
                    LuckyGame++;}
                else NoLuckyGame++;}
            Probability = (double)LuckyGame / GameCount;
            PlayNoGambilingMode.Enabled = false;
            System.Threading.Thread.Sleep(150);
            SelectedStrategy2.Text = "Азартный режим";
            statistic();}
        private void Reset_Click(object sender, EventArgs e) { progressBar1.Value = 0;
            PlayGambilingMode.Enabled = true;
            PlayNoGambilingMode.Enabled = true;
            SelectedStrategy2.Text = "----------------------------------------";
            LuckyGameCount2.Text = "----------------------------------------";
            NoLuckyGameCount2.Text = "----------------------------------------";
            Income2.Text = "----------------------------------------";
            PercentWinning2.Text = "----------------------------------------";
            GameCount = 0;
            GambilingMoney = 0;
            LuckyGame = 0;
            NoLuckyGame = 0;}
        private void ControlGame_CheckedChanged(object sender, EventArgs e)
        { if (ControlGameMODE){attension(false);
                ControlGameMODE = false;}
            else {attension(true);
            ControlGameMODE = true; }}
        private void PlayNoGambilingMode_Click(object sender, EventArgs e){PlayGambilingMode.Enabled = false;
            progressbar();
            for (int i = 0; i < GameCount; i++) {progressBar1.PerformStep();
                GambilingMoney -= 100;
                FirstReuslt = rand.Next(0, 2);
                if (FirstReuslt == 0){ GambilingMoney += 150;
                    LuckyGame++; }
                else NoLuckyGame++; }
            Probability = (double)LuckyGame / GameCount;
            PlayNoGambilingMode.Enabled = false;
            System.Threading.Thread.Sleep(150);
            SelectedStrategy2.Text = "Не азартный режим";
            statistic(); }
        private void CreditButton_Click(object sender, EventArgs e) { CreditButton.Visible = false;
            debt = 525;
            ActiveCredit = true;
            BuyTicketButton.Enabled = true;
            balance = 500;
            StartGame_Click(sender, e);}
        private void PickUpButton_Click(object sender, EventArgs e) {if (ControlGameMODE){money += 150;
                MicroWin++;
                ControlGameCount++;
                record();}
            ControlGame.Visible = true;
            if (!ActiveCredit) { WinningField = 0;
                BuyTicketButton.Enabled = true;
                PickUpButton.Visible = false;
                balance += 150;
                ScoreCount.Text = "" + balance;
                result();
                if (FIRSTgame) {ControlGameCount++;
                    attension(false);
                    MicroWin++;
                    money += 150;
                    record();
                    FIRSTgame = false;}}
            else {debt -= 25;
                WinningField = 0;
                BuyTicketButton.Enabled = true;
                PickUpButton.Visible = false;
                balance += 125;
                ScoreCount.Text = "" + balance;
                result();
                if (debt == 0) ActiveCredit = false;}}
        private void BuyTicketButton_Click(object sender, EventArgs e){if (FIRSTgame) money -= 100;
            if (ControlGameMODE){ money -= 100;
                buyticketfuntion();}
            else buyticketfuntion();}
        private void Bu11_Click(object sender, EventArgs e)
        {int i = 0;
            switch ((sender as Button).Name) {case "Bu11": i = 0; break;
                case "Bu12": i = 1; break;
                case "Bu21": i = 2; break;
                case "Bu22": i = 3; break;}
            if (Ticket[i] == 1) {WinningField++;
                (sender as Button).Text = "W";
                (sender as Button).Enabled = false;
                if (WinningField == 1){PickUpButton.Text = "Забрать выигрыш (+150р.)";
                    PickUpButton.Visible = true; }
                if (WinningField == 2)
                {if (ControlGameMODE){money += 500;
                        MacroWin++;
                        ControlGameCount++;
                        record();}
                    ControlGame.Visible = true;
                    if (ActiveCredit) { debt -= 100;
                        balance += 400;
                        ScoreCount.Text = "" + balance;
                        WinningField = 0;
                        PickUpButton.Visible = false;
                        BuyTicketButton.Enabled = true;
                        result(); }
                    else {balance += 500;
                        ScoreCount.Text = "" + balance;
                        WinningField = 0;
                        PickUpButton.Visible = false;
                        BuyTicketButton.Enabled = true;
                        result();
                        if (FIRSTgame){ControlGameCount++;
                            attension(false);
                            MacroWin++;
                            money += 500;
                            record(); } }}}
            else
            { if (ControlGameMODE) {lose++;
                    ControlGameCount++;
                    record(); }
                PickUpButton.Visible = false;
                BuyTicketButton.Enabled = true;
                WinningField = 0;
                (sender as Button).Text = "";
                (sender as Button).Enabled = false;
                (sender as Button).Refresh();
                System.Threading.Thread.Sleep(1000);
                result();
                ControlGame.Visible = true;
                if (balance < 100)
                { if (!ActiveCredit){CreditButton.Visible = true;
                        BuyTicketButton.Enabled = false;}
                    else {MessageBox.Show("G A M E    O V E R");
                        CancelButton_Click(sender, e);
                        balance = 1000;} }
                if (FIRSTgame){attension(false);
                    lose++;
                    ControlGameCount++;
                    record();} }
        }
    }
}