﻿namespace Golfklubban
{
    partial class CompetitionChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegisterCompetition = new System.Windows.Forms.Button();
            this.lbCompetitionChart = new System.Windows.Forms.ListBox();
            this.txtCompetitionName = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtLastBookingDate = new System.Windows.Forms.TextBox();
            this.txtLastUnbookingDate = new System.Windows.Forms.TextBox();
            this.txtClassA = new System.Windows.Forms.TextBox();
            this.txtClassB = new System.Windows.Forms.TextBox();
            this.txtClassC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimeLottery = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.btnDropPlayersDuringComp = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.lbPlayerHasGolfround = new System.Windows.Forms.ListBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.rbLag = new System.Windows.Forms.RadioButton();
            this.rbPar = new System.Windows.Forms.RadioButton();
            this.rbSingel = new System.Windows.Forms.RadioButton();
            this.lbPlayersInCompetition = new System.Windows.Forms.ListBox();
            this.btnDropPlayerFromComp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDeletePlayerFromTeam = new System.Windows.Forms.Button();
            this.lbPlayerInTeam = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.btnAddPlayerToTeam = new System.Windows.Forms.Button();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTeamChart = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddPlayerToCouple = new System.Windows.Forms.Button();
            this.btnDeletePlayerFromCouple = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbPlayers2 = new System.Windows.Forms.ListBox();
            this.lbPlayerInCouple = new System.Windows.Forms.ListBox();
            this.btnCreateCouple = new System.Windows.Forms.Button();
            this.btnDeleteCouple = new System.Windows.Forms.Button();
            this.lbCoupleChart = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCoupleName = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lbPassedCompetitionChart = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.lbSinglePlayers = new System.Windows.Forms.ListBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAddResult = new System.Windows.Forms.Button();
            this.txtAddResult = new System.Windows.Forms.TextBox();
            this.btnGetResult = new System.Windows.Forms.Button();
            this.rbClassC = new System.Windows.Forms.RadioButton();
            this.rbClassB = new System.Windows.Forms.RadioButton();
            this.rbClassA = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.lbGolfPlayers = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegisterCompetition
            // 
            this.btnRegisterCompetition.Location = new System.Drawing.Point(3, 370);
            this.btnRegisterCompetition.Name = "btnRegisterCompetition";
            this.btnRegisterCompetition.Size = new System.Drawing.Size(100, 23);
            this.btnRegisterCompetition.TabIndex = 9;
            this.btnRegisterCompetition.Text = "Registrera";
            this.btnRegisterCompetition.UseVisualStyleBackColor = true;
            this.btnRegisterCompetition.Click += new System.EventHandler(this.btnRegisterCompetition_Click);
            // 
            // lbCompetitionChart
            // 
            this.lbCompetitionChart.FormattingEnabled = true;
            this.lbCompetitionChart.Location = new System.Drawing.Point(165, 45);
            this.lbCompetitionChart.Name = "lbCompetitionChart";
            this.lbCompetitionChart.Size = new System.Drawing.Size(200, 290);
            this.lbCompetitionChart.TabIndex = 1;
            this.lbCompetitionChart.SelectedIndexChanged += new System.EventHandler(this.lbCompetitionChart_SelectedIndexChanged);
            // 
            // txtCompetitionName
            // 
            this.txtCompetitionName.Location = new System.Drawing.Point(6, 123);
            this.txtCompetitionName.Name = "txtCompetitionName";
            this.txtCompetitionName.Size = new System.Drawing.Size(129, 20);
            this.txtCompetitionName.TabIndex = 1;
            // 
            // txtStartDate
            // 
            this.txtStartDate.ForeColor = System.Drawing.Color.Silver;
            this.txtStartDate.Location = new System.Drawing.Point(4, 167);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(131, 20);
            this.txtStartDate.TabIndex = 2;
            this.txtStartDate.Text = "YYYY-MM-DD";
            this.txtStartDate.Click += new System.EventHandler(this.txtStartDate_Click);
            // 
            // txtEndDate
            // 
            this.txtEndDate.ForeColor = System.Drawing.Color.Silver;
            this.txtEndDate.Location = new System.Drawing.Point(6, 212);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(129, 20);
            this.txtEndDate.TabIndex = 3;
            this.txtEndDate.Text = "YYYY-MM-DD";
            this.txtEndDate.Click += new System.EventHandler(this.txtEndDate_Click);
            // 
            // txtLastBookingDate
            // 
            this.txtLastBookingDate.ForeColor = System.Drawing.Color.Silver;
            this.txtLastBookingDate.Location = new System.Drawing.Point(6, 256);
            this.txtLastBookingDate.Name = "txtLastBookingDate";
            this.txtLastBookingDate.Size = new System.Drawing.Size(129, 20);
            this.txtLastBookingDate.TabIndex = 4;
            this.txtLastBookingDate.Text = "YYYY-MM-DD";
            this.txtLastBookingDate.Click += new System.EventHandler(this.txtLastBookingDate_Click);
            // 
            // txtLastUnbookingDate
            // 
            this.txtLastUnbookingDate.ForeColor = System.Drawing.Color.Silver;
            this.txtLastUnbookingDate.Location = new System.Drawing.Point(6, 300);
            this.txtLastUnbookingDate.Name = "txtLastUnbookingDate";
            this.txtLastUnbookingDate.Size = new System.Drawing.Size(129, 20);
            this.txtLastUnbookingDate.TabIndex = 5;
            this.txtLastUnbookingDate.Text = "YYYY-MM-DD";
            this.txtLastUnbookingDate.Click += new System.EventHandler(this.txtLastUnbookingDate_Click);
            // 
            // txtClassA
            // 
            this.txtClassA.Location = new System.Drawing.Point(6, 344);
            this.txtClassA.Name = "txtClassA";
            this.txtClassA.Size = new System.Drawing.Size(39, 20);
            this.txtClassA.TabIndex = 6;
            // 
            // txtClassB
            // 
            this.txtClassB.Location = new System.Drawing.Point(51, 344);
            this.txtClassB.Name = "txtClassB";
            this.txtClassB.Size = new System.Drawing.Size(39, 20);
            this.txtClassB.TabIndex = 7;
            // 
            // txtClassC
            // 
            this.txtClassC.Location = new System.Drawing.Point(96, 342);
            this.txtClassC.Name = "txtClassC";
            this.txtClassC.Size = new System.Drawing.Size(39, 20);
            this.txtClassC.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Startdatum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Slutdatum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sista anmälningsdatum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sista avbokningsdatum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Klass A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Klass B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Klass C";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Ta bort tävling";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Kommande tävlingar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimeLottery);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.btnDropPlayersDuringComp);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.lbPlayerHasGolfround);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.rbLag);
            this.groupBox1.Controls.Add(this.rbPar);
            this.groupBox1.Controls.Add(this.rbSingel);
            this.groupBox1.Controls.Add(this.lbPlayersInCompetition);
            this.groupBox1.Controls.Add(this.btnDropPlayerFromComp);
            this.groupBox1.Controls.Add(this.txtCompetitionName);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnRegisterCompetition);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbCompetitionChart);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtStartDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEndDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLastBookingDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLastUnbookingDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtClassA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtClassB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtClassC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 612);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lägg till tävlingar";
            // 
            // btnTimeLottery
            // 
            this.btnTimeLottery.Location = new System.Drawing.Point(165, 582);
            this.btnTimeLottery.Name = "btnTimeLottery";
            this.btnTimeLottery.Size = new System.Drawing.Size(94, 23);
            this.btnTimeLottery.TabIndex = 35;
            this.btnTimeLottery.Text = "Lotta ut tider";
            this.btnTimeLottery.UseVisualStyleBackColor = true;
            this.btnTimeLottery.Click += new System.EventHandler(this.btnTimeLottery_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(162, 400);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(186, 13);
            this.label24.TabIndex = 34;
            this.label24.Text = "Avboka spelare från markerad tävling ";
            // 
            // btnDropPlayersDuringComp
            // 
            this.btnDropPlayersDuringComp.Location = new System.Drawing.Point(7, 578);
            this.btnDropPlayersDuringComp.Name = "btnDropPlayersDuringComp";
            this.btnDropPlayersDuringComp.Size = new System.Drawing.Size(129, 23);
            this.btnDropPlayersDuringComp.TabIndex = 31;
            this.btnDropPlayersDuringComp.Text = "Ta bort och meddela";
            this.btnDropPlayersDuringComp.UseVisualStyleBackColor = true;
            this.btnDropPlayersDuringComp.Click += new System.EventHandler(this.btnDropPlayersDuringComp_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 426);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "som markerad tävling.";
            // 
            // lbPlayerHasGolfround
            // 
            this.lbPlayerHasGolfround.FormattingEnabled = true;
            this.lbPlayerHasGolfround.Location = new System.Drawing.Point(7, 451);
            this.lbPlayerHasGolfround.Name = "lbPlayerHasGolfround";
            this.lbPlayerHasGolfround.Size = new System.Drawing.Size(129, 121);
            this.lbPlayerHasGolfround.TabIndex = 29;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 413);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(118, 13);
            this.label22.TabIndex = 32;
            this.label22.Text = "en golftid samma datum";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 400);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(117, 13);
            this.label23.TabIndex = 30;
            this.label23.Text = "Obs! Dessa spelare har";
            // 
            // rbLag
            // 
            this.rbLag.AutoSize = true;
            this.rbLag.Location = new System.Drawing.Point(6, 75);
            this.rbLag.Name = "rbLag";
            this.rbLag.Size = new System.Drawing.Size(43, 17);
            this.rbLag.TabIndex = 25;
            this.rbLag.TabStop = true;
            this.rbLag.Text = "Lag";
            this.rbLag.UseVisualStyleBackColor = true;
            // 
            // rbPar
            // 
            this.rbPar.AutoSize = true;
            this.rbPar.Location = new System.Drawing.Point(7, 52);
            this.rbPar.Name = "rbPar";
            this.rbPar.Size = new System.Drawing.Size(41, 17);
            this.rbPar.TabIndex = 24;
            this.rbPar.TabStop = true;
            this.rbPar.Text = "Par";
            this.rbPar.UseVisualStyleBackColor = true;
            // 
            // rbSingel
            // 
            this.rbSingel.AutoSize = true;
            this.rbSingel.Location = new System.Drawing.Point(7, 28);
            this.rbSingel.Name = "rbSingel";
            this.rbSingel.Size = new System.Drawing.Size(54, 17);
            this.rbSingel.TabIndex = 23;
            this.rbSingel.TabStop = true;
            this.rbSingel.Text = "Singel";
            this.rbSingel.UseVisualStyleBackColor = true;
            // 
            // lbPlayersInCompetition
            // 
            this.lbPlayersInCompetition.FormattingEnabled = true;
            this.lbPlayersInCompetition.Location = new System.Drawing.Point(165, 425);
            this.lbPlayersInCompetition.Name = "lbPlayersInCompetition";
            this.lbPlayersInCompetition.Size = new System.Drawing.Size(200, 147);
            this.lbPlayersInCompetition.TabIndex = 19;
            // 
            // btnDropPlayerFromComp
            // 
            this.btnDropPlayerFromComp.Location = new System.Drawing.Point(265, 582);
            this.btnDropPlayerFromComp.Name = "btnDropPlayerFromComp";
            this.btnDropPlayerFromComp.Size = new System.Drawing.Size(100, 23);
            this.btnDropPlayerFromComp.TabIndex = 20;
            this.btnDropPlayerFromComp.Text = "Ta bort spelare";
            this.btnDropPlayerFromComp.UseVisualStyleBackColor = true;
            this.btnDropPlayerFromComp.Click += new System.EventHandler(this.btnDropPlayerFromComp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btnDeletePlayerFromTeam);
            this.groupBox2.Controls.Add(this.lbPlayerInTeam);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbPlayers);
            this.groupBox2.Controls.Add(this.btnAddPlayerToTeam);
            this.groupBox2.Controls.Add(this.btnDeleteTeam);
            this.groupBox2.Controls.Add(this.btnCreateTeam);
            this.groupBox2.Controls.Add(this.txtTeamName);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbTeamChart);
            this.groupBox2.Location = new System.Drawing.Point(437, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 446);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Skapa nytt lag";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Lägg till i tävling";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnDeletePlayerFromTeam
            // 
            this.btnDeletePlayerFromTeam.Location = new System.Drawing.Point(21, 400);
            this.btnDeletePlayerFromTeam.Name = "btnDeletePlayerFromTeam";
            this.btnDeletePlayerFromTeam.Size = new System.Drawing.Size(134, 23);
            this.btnDeletePlayerFromTeam.TabIndex = 18;
            this.btnDeletePlayerFromTeam.Text = "Ta bort vald spelare";
            this.btnDeletePlayerFromTeam.UseVisualStyleBackColor = true;
            this.btnDeletePlayerFromTeam.Click += new System.EventHandler(this.btnDeletePlayerFromTeam_Click);
            // 
            // lbPlayerInTeam
            // 
            this.lbPlayerInTeam.FormattingEnabled = true;
            this.lbPlayerInTeam.Location = new System.Drawing.Point(21, 247);
            this.lbPlayerInTeam.Name = "lbPlayerInTeam";
            this.lbPlayerInTeam.Size = new System.Drawing.Size(134, 147);
            this.lbPlayerInTeam.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Spelare i";
            // 
            // lbPlayers
            // 
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.Location = new System.Drawing.Point(183, 247);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(134, 147);
            this.lbPlayers.TabIndex = 13;
            this.lbPlayers.Tag = "";
            // 
            // btnAddPlayerToTeam
            // 
            this.btnAddPlayerToTeam.Location = new System.Drawing.Point(183, 400);
            this.btnAddPlayerToTeam.Name = "btnAddPlayerToTeam";
            this.btnAddPlayerToTeam.Size = new System.Drawing.Size(134, 23);
            this.btnAddPlayerToTeam.TabIndex = 14;
            this.btnAddPlayerToTeam.Text = "Lägg till vald spelare";
            this.btnAddPlayerToTeam.UseVisualStyleBackColor = true;
            this.btnAddPlayerToTeam.Click += new System.EventHandler(this.btnAddPlayerToTeam_Click);
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.Location = new System.Drawing.Point(228, 167);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(89, 23);
            this.btnDeleteTeam.TabIndex = 12;
            this.btnDeleteTeam.Text = "Ta bort lag";
            this.btnDeleteTeam.UseVisualStyleBackColor = true;
            this.btnDeleteTeam.Click += new System.EventHandler(this.btnDeleteTeam_Click);
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Location = new System.Drawing.Point(125, 167);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(91, 23);
            this.btnCreateTeam.TabIndex = 9;
            this.btnCreateTeam.Text = "Skapa lag";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(21, 37);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(134, 20);
            this.txtTeamName.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(180, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Tillgängliga spelare";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Lagnamn";
            // 
            // lbTeamChart
            // 
            this.lbTeamChart.FormattingEnabled = true;
            this.lbTeamChart.Location = new System.Drawing.Point(21, 67);
            this.lbTeamChart.Name = "lbTeamChart";
            this.lbTeamChart.Size = new System.Drawing.Size(296, 95);
            this.lbTeamChart.TabIndex = 4;
            this.lbTeamChart.Tag = "";
            this.lbTeamChart.SelectedIndexChanged += new System.EventHandler(this.lbTeamChart_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.btnAddPlayerToCouple);
            this.groupBox3.Controls.Add(this.btnDeletePlayerFromCouple);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lbPlayers2);
            this.groupBox3.Controls.Add(this.lbPlayerInCouple);
            this.groupBox3.Controls.Add(this.btnCreateCouple);
            this.groupBox3.Controls.Add(this.btnDeleteCouple);
            this.groupBox3.Controls.Add(this.lbCoupleChart);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtCoupleName);
            this.groupBox3.Location = new System.Drawing.Point(437, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 446);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skapa nytt par";
            this.groupBox3.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Lägg till i tävling";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnAddPlayerToCouple
            // 
            this.btnAddPlayerToCouple.Location = new System.Drawing.Point(183, 400);
            this.btnAddPlayerToCouple.Name = "btnAddPlayerToCouple";
            this.btnAddPlayerToCouple.Size = new System.Drawing.Size(134, 23);
            this.btnAddPlayerToCouple.TabIndex = 10;
            this.btnAddPlayerToCouple.Text = "Lägg till vald spelare";
            this.btnAddPlayerToCouple.UseVisualStyleBackColor = true;
            this.btnAddPlayerToCouple.Click += new System.EventHandler(this.btnAddPlayerToCouple_Click);
            // 
            // btnDeletePlayerFromCouple
            // 
            this.btnDeletePlayerFromCouple.Location = new System.Drawing.Point(21, 400);
            this.btnDeletePlayerFromCouple.Name = "btnDeletePlayerFromCouple";
            this.btnDeletePlayerFromCouple.Size = new System.Drawing.Size(134, 23);
            this.btnDeletePlayerFromCouple.TabIndex = 9;
            this.btnDeletePlayerFromCouple.Text = "Ta bort vald spelare";
            this.btnDeletePlayerFromCouple.UseVisualStyleBackColor = true;
            this.btnDeletePlayerFromCouple.Click += new System.EventHandler(this.btnDeletePlayerFromCouple_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(180, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Tillgängliga spelare";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Spelare i -";
            // 
            // lbPlayers2
            // 
            this.lbPlayers2.FormattingEnabled = true;
            this.lbPlayers2.Location = new System.Drawing.Point(183, 247);
            this.lbPlayers2.Name = "lbPlayers2";
            this.lbPlayers2.Size = new System.Drawing.Size(134, 147);
            this.lbPlayers2.TabIndex = 6;
            // 
            // lbPlayerInCouple
            // 
            this.lbPlayerInCouple.FormattingEnabled = true;
            this.lbPlayerInCouple.Location = new System.Drawing.Point(21, 247);
            this.lbPlayerInCouple.Name = "lbPlayerInCouple";
            this.lbPlayerInCouple.Size = new System.Drawing.Size(134, 147);
            this.lbPlayerInCouple.TabIndex = 5;
            // 
            // btnCreateCouple
            // 
            this.btnCreateCouple.Location = new System.Drawing.Point(125, 167);
            this.btnCreateCouple.Name = "btnCreateCouple";
            this.btnCreateCouple.Size = new System.Drawing.Size(91, 23);
            this.btnCreateCouple.TabIndex = 11;
            this.btnCreateCouple.Text = "Skapa par";
            this.btnCreateCouple.UseVisualStyleBackColor = true;
            this.btnCreateCouple.Click += new System.EventHandler(this.btnCreateCouple_Click);
            // 
            // btnDeleteCouple
            // 
            this.btnDeleteCouple.Location = new System.Drawing.Point(228, 167);
            this.btnDeleteCouple.Name = "btnDeleteCouple";
            this.btnDeleteCouple.Size = new System.Drawing.Size(89, 23);
            this.btnDeleteCouple.TabIndex = 3;
            this.btnDeleteCouple.Text = "Ta bort par";
            this.btnDeleteCouple.UseVisualStyleBackColor = true;
            this.btnDeleteCouple.Click += new System.EventHandler(this.btnDeleteCouple_Click);
            // 
            // lbCoupleChart
            // 
            this.lbCoupleChart.FormattingEnabled = true;
            this.lbCoupleChart.Location = new System.Drawing.Point(21, 67);
            this.lbCoupleChart.Name = "lbCoupleChart";
            this.lbCoupleChart.Size = new System.Drawing.Size(296, 95);
            this.lbCoupleChart.TabIndex = 2;
            this.lbCoupleChart.SelectedIndexChanged += new System.EventHandler(this.lbCoupleChart_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Parnamn";
            // 
            // txtCoupleName
            // 
            this.txtCoupleName.Location = new System.Drawing.Point(21, 37);
            this.txtCoupleName.Name = "txtCoupleName";
            this.txtCoupleName.Size = new System.Drawing.Size(134, 20);
            this.txtCoupleName.TabIndex = 10;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(437, 41);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Visa lag";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(505, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Visa par";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lbPassedCompetitionChart
            // 
            this.lbPassedCompetitionChart.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbPassedCompetitionChart.FormattingEnabled = true;
            this.lbPassedCompetitionChart.Location = new System.Drawing.Point(793, 67);
            this.lbPassedCompetitionChart.Name = "lbPassedCompetitionChart";
            this.lbPassedCompetitionChart.Size = new System.Drawing.Size(200, 173);
            this.lbPassedCompetitionChart.TabIndex = 1;
            this.lbPassedCompetitionChart.SelectedIndexChanged += new System.EventHandler(this.lbPassedCompetitionChart_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(790, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Gamla Tävlingar";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.lbSinglePlayers);
            this.groupBox4.Location = new System.Drawing.Point(437, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(329, 446);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Välj spelare";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Lägg till vald spelare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Tillgängliga spelare";
            // 
            // lbSinglePlayers
            // 
            this.lbSinglePlayers.FormattingEnabled = true;
            this.lbSinglePlayers.Location = new System.Drawing.Point(21, 37);
            this.lbSinglePlayers.Name = "lbSinglePlayers";
            this.lbSinglePlayers.Size = new System.Drawing.Size(296, 355);
            this.lbSinglePlayers.TabIndex = 6;
            this.lbSinglePlayers.SelectedIndexChanged += new System.EventHandler(this.lbSinglePlayers_SelectedIndexChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(568, 41);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(82, 17);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Visa spelare";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lbResults
            // 
            this.lbResults.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(1033, 67);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(200, 394);
            this.lbResults.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1030, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "Resultat:";
            // 
            // btnAddResult
            // 
            this.btnAddResult.Location = new System.Drawing.Point(892, 466);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(101, 23);
            this.btnAddResult.TabIndex = 26;
            this.btnAddResult.Text = "Registrera resultat";
            this.btnAddResult.UseVisualStyleBackColor = true;
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);
            // 
            // txtAddResult
            // 
            this.txtAddResult.Location = new System.Drawing.Point(793, 468);
            this.txtAddResult.Name = "txtAddResult";
            this.txtAddResult.Size = new System.Drawing.Size(88, 20);
            this.txtAddResult.TabIndex = 27;
            // 
            // btnGetResult
            // 
            this.btnGetResult.Location = new System.Drawing.Point(1122, 487);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(103, 23);
            this.btnGetResult.TabIndex = 250;
            this.btnGetResult.Text = "Visa resultat";
            this.btnGetResult.UseVisualStyleBackColor = true;
            this.btnGetResult.Click += new System.EventHandler(this.btnGetResult_Click);
            // 
            // rbClassC
            // 
            this.rbClassC.AutoSize = true;
            this.rbClassC.Location = new System.Drawing.Point(1173, 464);
            this.rbClassC.Name = "rbClassC";
            this.rbClassC.Size = new System.Drawing.Size(60, 17);
            this.rbClassC.TabIndex = 249;
            this.rbClassC.TabStop = true;
            this.rbClassC.Text = "Klass C";
            this.rbClassC.UseVisualStyleBackColor = true;
            // 
            // rbClassB
            // 
            this.rbClassB.AutoSize = true;
            this.rbClassB.Location = new System.Drawing.Point(1107, 464);
            this.rbClassB.Name = "rbClassB";
            this.rbClassB.Size = new System.Drawing.Size(60, 17);
            this.rbClassB.TabIndex = 248;
            this.rbClassB.TabStop = true;
            this.rbClassB.Text = "Klass B";
            this.rbClassB.UseVisualStyleBackColor = true;
            // 
            // rbClassA
            // 
            this.rbClassA.AutoSize = true;
            this.rbClassA.Location = new System.Drawing.Point(1041, 464);
            this.rbClassA.Name = "rbClassA";
            this.rbClassA.Size = new System.Drawing.Size(60, 17);
            this.rbClassA.TabIndex = 247;
            this.rbClassA.TabStop = true;
            this.rbClassA.Text = "Klass A";
            this.rbClassA.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(790, 270);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 13);
            this.label20.TabIndex = 252;
            this.label20.Text = "Golfspelare";
            // 
            // lbGolfPlayers
            // 
            this.lbGolfPlayers.FormattingEnabled = true;
            this.lbGolfPlayers.Location = new System.Drawing.Point(793, 286);
            this.lbGolfPlayers.Name = "lbGolfPlayers";
            this.lbGolfPlayers.Size = new System.Drawing.Size(200, 173);
            this.lbGolfPlayers.TabIndex = 251;
            // 
            // CompetitionChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 673);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lbGolfPlayers);
            this.Controls.Add(this.btnGetResult);
            this.Controls.Add(this.rbClassC);
            this.Controls.Add(this.rbClassB);
            this.Controls.Add(this.rbClassA);
            this.Controls.Add(this.txtAddResult);
            this.Controls.Add(this.btnAddResult);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.lbPassedCompetitionChart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Name = "CompetitionChart";
            this.Text = "Tävlingar";
            this.Load += new System.EventHandler(this.CompetitionChart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterCompetition;
        private System.Windows.Forms.ListBox lbCompetitionChart;
        private System.Windows.Forms.TextBox txtCompetitionName;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtLastBookingDate;
        private System.Windows.Forms.TextBox txtLastUnbookingDate;
        private System.Windows.Forms.TextBox txtClassA;
        private System.Windows.Forms.TextBox txtClassB;
        private System.Windows.Forms.TextBox txtClassC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteTeam;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbTeamChart;
        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.Button btnAddPlayerToTeam;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDeletePlayerFromTeam;
        private System.Windows.Forms.ListBox lbPlayerInTeam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddPlayerToCouple;
        private System.Windows.Forms.Button btnDeletePlayerFromCouple;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox lbPlayers2;
        private System.Windows.Forms.ListBox lbPlayerInCouple;
        private System.Windows.Forms.Button btnCreateCouple;
        private System.Windows.Forms.Button btnDeleteCouple;
        private System.Windows.Forms.ListBox lbCoupleChart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCoupleName;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListBox lbPassedCompetitionChart;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDropPlayerFromComp;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox lbSinglePlayers;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ListBox lbPlayersInCompetition;
        private System.Windows.Forms.RadioButton rbLag;
        private System.Windows.Forms.RadioButton rbPar;
        private System.Windows.Forms.RadioButton rbSingel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnAddResult;
        private System.Windows.Forms.TextBox txtAddResult;
        internal System.Windows.Forms.Button btnGetResult;
        internal System.Windows.Forms.RadioButton rbClassC;
        internal System.Windows.Forms.RadioButton rbClassB;
        internal System.Windows.Forms.RadioButton rbClassA;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.ListBox lbGolfPlayers;
        private System.Windows.Forms.Button btnDropPlayersDuringComp;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox lbPlayerHasGolfround;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnTimeLottery;
    }
}