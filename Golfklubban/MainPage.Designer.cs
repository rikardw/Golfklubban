﻿namespace Golfklubban
{
    partial class MainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stängToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medlemmarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPlayerChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tävlingarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCompetitionAddPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.lagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTeamView = new System.Windows.Forms.ToolStripMenuItem();
            this.lbMainPagePlayers = new System.Windows.Forms.ListBox();
            this.lbAvailibleTimes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.medlemmarToolStripMenuItem,
            this.tävlingarToolStripMenuItem,
            this.lagToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.stängToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // stängToolStripMenuItem
            // 
            this.stängToolStripMenuItem.Name = "stängToolStripMenuItem";
            this.stängToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.stängToolStripMenuItem.Text = "Stäng";
            this.stängToolStripMenuItem.Click += new System.EventHandler(this.stängToolStripMenuItem_Click);
            // 
            // medlemmarToolStripMenuItem
            // 
            this.medlemmarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPlayerChange});
            this.medlemmarToolStripMenuItem.Name = "medlemmarToolStripMenuItem";
            this.medlemmarToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.medlemmarToolStripMenuItem.Text = "Medlemmar";
            // 
            // tsmPlayerChange
            // 
            this.tsmPlayerChange.Name = "tsmPlayerChange";
            this.tsmPlayerChange.Size = new System.Drawing.Size(184, 22);
            this.tsmPlayerChange.Text = "Hantera medlemmar";
            this.tsmPlayerChange.Click += new System.EventHandler(this.visaMedlemmarToolStripMenuItem_Click);
            // 
            // tävlingarToolStripMenuItem
            // 
            this.tävlingarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCompetitionAddPlayer});
            this.tävlingarToolStripMenuItem.Name = "tävlingarToolStripMenuItem";
            this.tävlingarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.tävlingarToolStripMenuItem.Text = "Tävling";
            // 
            // tsmCompetitionAddPlayer
            // 
            this.tsmCompetitionAddPlayer.Name = "tsmCompetitionAddPlayer";
            this.tsmCompetitionAddPlayer.Size = new System.Drawing.Size(155, 22);
            this.tsmCompetitionAddPlayer.Text = "Hantera tävling";
            this.tsmCompetitionAddPlayer.Click += new System.EventHandler(this.bokaInförTävlingToolStripMenuItem_Click);
            // 
            // lagToolStripMenuItem
            // 
            this.lagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTeamView});
            this.lagToolStripMenuItem.Name = "lagToolStripMenuItem";
            this.lagToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.lagToolStripMenuItem.Text = "Lag";
            // 
            // tsmTeamView
            // 
            this.tsmTeamView.Name = "tsmTeamView";
            this.tsmTeamView.Size = new System.Drawing.Size(114, 22);
            this.tsmTeamView.Text = "Visa lag";
            this.tsmTeamView.Click += new System.EventHandler(this.visaLagToolStripMenuItem_Click);
            // 
            // lbMainPagePlayers
            // 
            this.lbMainPagePlayers.FormattingEnabled = true;
            this.lbMainPagePlayers.Location = new System.Drawing.Point(15, 56);
            this.lbMainPagePlayers.Name = "lbMainPagePlayers";
            this.lbMainPagePlayers.Size = new System.Drawing.Size(230, 394);
            this.lbMainPagePlayers.TabIndex = 2;
            // 
            // lbAvailibleTimes
            // 
            this.lbAvailibleTimes.FormattingEnabled = true;
            this.lbAvailibleTimes.Location = new System.Drawing.Point(338, 81);
            this.lbAvailibleTimes.Name = "lbAvailibleTimes";
            this.lbAvailibleTimes.Size = new System.Drawing.Size(285, 368);
            this.lbAvailibleTimes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spelare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tillgängliga tider";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Genomför bokning";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(338, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Datum:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 498);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAvailibleTimes);
            this.Controls.Add(this.lbMainPagePlayers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "Golfklubban";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stängToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medlemmarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmPlayerChange;
        private System.Windows.Forms.ToolStripMenuItem lagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tävlingarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmTeamView;
        private System.Windows.Forms.ListBox lbMainPagePlayers;
        private System.Windows.Forms.ListBox lbAvailibleTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem tsmCompetitionAddPlayer;


    }
}

