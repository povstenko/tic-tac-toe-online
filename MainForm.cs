using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;

namespace TicTacToe
{

	public class frmTicTacToe : System.Windows.Forms.Form
	{
		#region Form Initialization 

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pic23;
		private System.Windows.Forms.PictureBox pic22;
		private System.Windows.Forms.PictureBox pic33;
		private System.Windows.Forms.PictureBox pic32;
		private System.Windows.Forms.PictureBox pic31;
		private System.Windows.Forms.PictureBox pic11;
		private System.Windows.Forms.PictureBox pic12;
		private System.Windows.Forms.PictureBox pic13;
		private System.Windows.Forms.PictureBox pic21;
		private System.Windows.Forms.PictureBox picWinner;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.StatusBar stbMessage;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem mnNew;
		private System.Windows.Forms.MenuItem mnExit;
		private System.Windows.Forms.MenuItem mnOnePlayer;
		private System.Windows.Forms.MenuItem mnTwoPlayers;
		private System.Windows.Forms.MenuItem mnStartServer;
		private System.Windows.Forms.MenuItem mnConnectServer;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem mnCPUX;
		private System.Windows.Forms.MenuItem mnCPUO;
		private System.Windows.Forms.MenuItem mnDifficultHard;
		private System.Windows.Forms.MenuItem mnDifficultEasy;
		private System.Windows.Forms.MenuItem mnBallRight;
		private System.Windows.Forms.MenuItem mnBallLeft;
		private System.Windows.Forms.MenuItem mnDificuldade;
		private System.Windows.Forms.MenuItem mnRede;
		private System.Windows.Forms.MenuItem mnControles;
		private System.Windows.Forms.MenuItem mnDifficultAverage;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbScoreBall;
		private System.Windows.Forms.Label lbScoreCross;
		private System.Windows.Forms.Label lbScoreDraw;
		private System.Windows.Forms.Label lbMaches;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem mnResetScore;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem mnDisconnect;
		private System.Windows.Forms.ImageList ilBolaXis;
		private System.Windows.Forms.GroupBox gbScore;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private System.ComponentModel.IContainer components;

		public frmTicTacToe()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicTacToe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnNew = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnResetScore = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnExit = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnOnePlayer = new System.Windows.Forms.MenuItem();
            this.mnTwoPlayers = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnCPUX = new System.Windows.Forms.MenuItem();
            this.mnCPUO = new System.Windows.Forms.MenuItem();
            this.mnDificuldade = new System.Windows.Forms.MenuItem();
            this.mnDifficultEasy = new System.Windows.Forms.MenuItem();
            this.mnDifficultAverage = new System.Windows.Forms.MenuItem();
            this.mnDifficultHard = new System.Windows.Forms.MenuItem();
            this.mnControles = new System.Windows.Forms.MenuItem();
            this.mnBallRight = new System.Windows.Forms.MenuItem();
            this.mnBallLeft = new System.Windows.Forms.MenuItem();
            this.mnRede = new System.Windows.Forms.MenuItem();
            this.mnStartServer = new System.Windows.Forms.MenuItem();
            this.mnConnectServer = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.mnDisconnect = new System.Windows.Forms.MenuItem();
            this.stbMessage = new System.Windows.Forms.StatusBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lbScoreBall = new System.Windows.Forms.Label();
            this.lbScoreCross = new System.Windows.Forms.Label();
            this.lbScoreDraw = new System.Windows.Forms.Label();
            this.lbMaches = new System.Windows.Forms.Label();
            this.gbScore = new System.Windows.Forms.GroupBox();
            this.ilBolaXis = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picWinner = new System.Windows.Forms.PictureBox();
            this.pic33 = new System.Windows.Forms.PictureBox();
            this.pic32 = new System.Windows.Forms.PictureBox();
            this.pic31 = new System.Windows.Forms.PictureBox();
            this.pic23 = new System.Windows.Forms.PictureBox();
            this.pic22 = new System.Windows.Forms.PictureBox();
            this.pic21 = new System.Windows.Forms.PictureBox();
            this.pic13 = new System.Windows.Forms.PictureBox();
            this.pic12 = new System.Windows.Forms.PictureBox();
            this.pic11 = new System.Windows.Forms.PictureBox();
            this.gbScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(98, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 212);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(175, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(8, 213);
            this.label2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 11);
            this.label3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 11);
            this.label4.TabIndex = 12;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem5,
            this.mnDificuldade,
            this.mnControles,
            this.mnRede});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnNew,
            this.menuItem3,
            this.mnResetScore,
            this.menuItem4,
            this.mnExit});
            this.menuItem1.Text = "&Game";
            // 
            // mnNew
            // 
            this.mnNew.Index = 0;
            this.mnNew.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.mnNew.Text = "&New";
            this.mnNew.Click += new System.EventHandler(this.mnNew_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "-";
            // 
            // mnResetScore
            // 
            this.mnResetScore.Index = 2;
            this.mnResetScore.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.mnResetScore.Text = "&Reset score";
            this.mnResetScore.Click += new System.EventHandler(this.mnResetScore_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "-";
            // 
            // mnExit
            // 
            this.mnExit.Index = 4;
            this.mnExit.Shortcut = System.Windows.Forms.Shortcut.AltBksp;
            this.mnExit.Text = "&Exit";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnOnePlayer,
            this.mnTwoPlayers,
            this.menuItem2,
            this.mnCPUX,
            this.mnCPUO});
            this.menuItem5.Text = "&Players";
            // 
            // mnOnePlayer
            // 
            this.mnOnePlayer.Checked = true;
            this.mnOnePlayer.Index = 0;
            this.mnOnePlayer.Text = "&One player";
            this.mnOnePlayer.Click += new System.EventHandler(this.mnOnePlayer_Click);
            // 
            // mnTwoPlayers
            // 
            this.mnTwoPlayers.Index = 1;
            this.mnTwoPlayers.Text = "&Two players";
            this.mnTwoPlayers.Click += new System.EventHandler(this.mnTwoPlayers_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "-";
            // 
            // mnCPUX
            // 
            this.mnCPUX.Checked = true;
            this.mnCPUX.Index = 3;
            this.mnCPUX.Text = "CPU - &X";
            this.mnCPUX.Click += new System.EventHandler(this.mnCPUX_Click);
            // 
            // mnCPUO
            // 
            this.mnCPUO.Index = 4;
            this.mnCPUO.Text = "CPU - &O";
            this.mnCPUO.Click += new System.EventHandler(this.mnCPUO_Click);
            // 
            // mnDificuldade
            // 
            this.mnDificuldade.Index = 2;
            this.mnDificuldade.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnDifficultEasy,
            this.mnDifficultAverage,
            this.mnDifficultHard});
            this.mnDificuldade.Text = "&Difficult";
            // 
            // mnDifficultEasy
            // 
            this.mnDifficultEasy.Index = 0;
            this.mnDifficultEasy.Text = "Easy";
            this.mnDifficultEasy.Click += new System.EventHandler(this.mnDifficultEasy_Click);
            // 
            // mnDifficultAverage
            // 
            this.mnDifficultAverage.Index = 1;
            this.mnDifficultAverage.Text = "Average";
            this.mnDifficultAverage.Click += new System.EventHandler(this.mnDifficultAverage_Click);
            // 
            // mnDifficultHard
            // 
            this.mnDifficultHard.Checked = true;
            this.mnDifficultHard.Index = 2;
            this.mnDifficultHard.Text = "Hard";
            this.mnDifficultHard.Click += new System.EventHandler(this.mnDifficultHard_Click);
            // 
            // mnControles
            // 
            this.mnControles.Index = 3;
            this.mnControles.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnBallRight,
            this.mnBallLeft});
            this.mnControles.Text = "&Controls";
            // 
            // mnBallRight
            // 
            this.mnBallRight.Checked = true;
            this.mnBallRight.Index = 0;
            this.mnBallRight.Text = "Ball in the &Right";
            this.mnBallRight.Click += new System.EventHandler(this.mnBallRight_Click);
            // 
            // mnBallLeft
            // 
            this.mnBallLeft.Index = 1;
            this.mnBallLeft.Text = "Ball in the &Left";
            this.mnBallLeft.Click += new System.EventHandler(this.mnBallLeft_Click);
            // 
            // mnRede
            // 
            this.mnRede.Index = 4;
            this.mnRede.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnStartServer,
            this.mnConnectServer,
            this.menuItem6,
            this.mnDisconnect});
            this.mnRede.Text = "&Network";
            // 
            // mnStartServer
            // 
            this.mnStartServer.Index = 0;
            this.mnStartServer.Text = "Start &server";
            this.mnStartServer.Click += new System.EventHandler(this.mnStartServer_Click);
            // 
            // mnConnectServer
            // 
            this.mnConnectServer.Index = 1;
            this.mnConnectServer.Text = "&Connect to server";
            this.mnConnectServer.Click += new System.EventHandler(this.mnConnectServer_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.Text = "-";
            // 
            // mnDisconnect
            // 
            this.mnDisconnect.Enabled = false;
            this.mnDisconnect.Index = 3;
            this.mnDisconnect.Text = "&Disconnect";
            this.mnDisconnect.Click += new System.EventHandler(this.mnDisconnect_Click);
            // 
            // stbMessage
            // 
            this.stbMessage.Location = new System.Drawing.Point(0, 301);
            this.stbMessage.Name = "stbMessage";
            this.stbMessage.ShowPanels = true;
            this.stbMessage.Size = new System.Drawing.Size(287, 22);
            this.stbMessage.SizingGrip = false;
            this.stbMessage.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Score:";
            // 
            // lbScoreBall
            // 
            this.lbScoreBall.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbScoreBall.ForeColor = System.Drawing.Color.Blue;
            this.lbScoreBall.Location = new System.Drawing.Point(50, 39);
            this.lbScoreBall.Name = "lbScoreBall";
            this.lbScoreBall.Size = new System.Drawing.Size(49, 23);
            this.lbScoreBall.TabIndex = 17;
            this.lbScoreBall.Text = "0";
            // 
            // lbScoreCross
            // 
            this.lbScoreCross.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbScoreCross.ForeColor = System.Drawing.Color.Red;
            this.lbScoreCross.Location = new System.Drawing.Point(139, 39);
            this.lbScoreCross.Name = "lbScoreCross";
            this.lbScoreCross.Size = new System.Drawing.Size(49, 23);
            this.lbScoreCross.TabIndex = 19;
            this.lbScoreCross.Text = "0";
            // 
            // lbScoreDraw
            // 
            this.lbScoreDraw.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbScoreDraw.Location = new System.Drawing.Point(235, 39);
            this.lbScoreDraw.Name = "lbScoreDraw";
            this.lbScoreDraw.Size = new System.Drawing.Size(33, 23);
            this.lbScoreDraw.TabIndex = 21;
            this.lbScoreDraw.Text = "0";
            // 
            // lbMaches
            // 
            this.lbMaches.Location = new System.Drawing.Point(202, 14);
            this.lbMaches.Name = "lbMaches";
            this.lbMaches.Size = new System.Drawing.Size(60, 16);
            this.lbMaches.TabIndex = 22;
            this.lbMaches.Text = "0 Matches";
            // 
            // gbScore
            // 
            this.gbScore.Controls.Add(this.pictureBox3);
            this.gbScore.Controls.Add(this.pictureBox2);
            this.gbScore.Controls.Add(this.pictureBox1);
            this.gbScore.Controls.Add(this.lbMaches);
            this.gbScore.Controls.Add(this.lbScoreCross);
            this.gbScore.Controls.Add(this.lbScoreDraw);
            this.gbScore.Controls.Add(this.label5);
            this.gbScore.Controls.Add(this.lbScoreBall);
            this.gbScore.Location = new System.Drawing.Point(6, 267);
            this.gbScore.Name = "gbScore";
            this.gbScore.Size = new System.Drawing.Size(275, 77);
            this.gbScore.TabIndex = 23;
            this.gbScore.TabStop = false;
            // 
            // ilBolaXis
            // 
            this.ilBolaXis.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilBolaXis.ImageStream")));
            this.ilBolaXis.TransparentColor = System.Drawing.Color.Transparent;
            this.ilBolaXis.Images.SetKeyName(0, "Cross.gif");
            this.ilBolaXis.Images.SetKeyName(1, "Circle.gif");
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TicTacToe.Properties.Resources.Draw;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(205, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TicTacToe.Properties.Resources.Cross;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(109, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TicTacToe.Properties.Resources.Circle;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(20, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picWinner
            // 
            this.picWinner.Location = new System.Drawing.Point(0, 0);
            this.picWinner.Name = "picWinner";
            this.picWinner.Size = new System.Drawing.Size(287, 261);
            this.picWinner.TabIndex = 13;
            this.picWinner.TabStop = false;
            this.picWinner.Visible = false;
            this.picWinner.Paint += new System.Windows.Forms.PaintEventHandler(this.picWinner_Paint);
            // 
            // pic33
            // 
            this.pic33.Location = new System.Drawing.Point(187, 170);
            this.pic33.Name = "pic33";
            this.pic33.Size = new System.Drawing.Size(62, 56);
            this.pic33.TabIndex = 9;
            this.pic33.TabStop = false;
            this.pic33.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic32
            // 
            this.pic32.Location = new System.Drawing.Point(110, 170);
            this.pic32.Name = "pic32";
            this.pic32.Size = new System.Drawing.Size(62, 56);
            this.pic32.TabIndex = 8;
            this.pic32.TabStop = false;
            this.pic32.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic31
            // 
            this.pic31.Location = new System.Drawing.Point(34, 170);
            this.pic31.Name = "pic31";
            this.pic31.Size = new System.Drawing.Size(62, 56);
            this.pic31.TabIndex = 7;
            this.pic31.TabStop = false;
            this.pic31.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic23
            // 
            this.pic23.Location = new System.Drawing.Point(187, 99);
            this.pic23.Name = "pic23";
            this.pic23.Size = new System.Drawing.Size(62, 56);
            this.pic23.TabIndex = 6;
            this.pic23.TabStop = false;
            this.pic23.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic22
            // 
            this.pic22.Location = new System.Drawing.Point(110, 97);
            this.pic22.Name = "pic22";
            this.pic22.Size = new System.Drawing.Size(62, 56);
            this.pic22.TabIndex = 5;
            this.pic22.TabStop = false;
            this.pic22.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic21
            // 
            this.pic21.Location = new System.Drawing.Point(34, 98);
            this.pic21.Name = "pic21";
            this.pic21.Size = new System.Drawing.Size(62, 56);
            this.pic21.TabIndex = 4;
            this.pic21.TabStop = false;
            this.pic21.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic13
            // 
            this.pic13.Location = new System.Drawing.Point(187, 27);
            this.pic13.Name = "pic13";
            this.pic13.Size = new System.Drawing.Size(62, 56);
            this.pic13.TabIndex = 3;
            this.pic13.TabStop = false;
            this.pic13.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic12
            // 
            this.pic12.Location = new System.Drawing.Point(109, 27);
            this.pic12.Name = "pic12";
            this.pic12.Size = new System.Drawing.Size(62, 56);
            this.pic12.TabIndex = 2;
            this.pic12.TabStop = false;
            this.pic12.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic11
            // 
            this.pic11.Location = new System.Drawing.Point(34, 27);
            this.pic11.Name = "pic11";
            this.pic11.Size = new System.Drawing.Size(62, 56);
            this.pic11.TabIndex = 0;
            this.pic11.TabStop = false;
            this.pic11.Click += new System.EventHandler(this.pic1_Click);
            // 
            // frmTicTacToe
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(287, 323);
            this.Controls.Add(this.gbScore);
            this.Controls.Add(this.stbMessage);
            this.Controls.Add(this.picWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic33);
            this.Controls.Add(this.pic32);
            this.Controls.Add(this.pic31);
            this.Controls.Add(this.pic23);
            this.Controls.Add(this.pic22);
            this.Controls.Add(this.pic21);
            this.Controls.Add(this.pic13);
            this.Controls.Add(this.pic12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "frmTicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Closed += new System.EventHandler(this.frmTicTacToe_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmTicTacToe_KeyUp);
            this.gbScore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic11)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region Variables/API calls

		//_____________________________________________________________________________________________
		//
		// AI and Network objects
		//_____________________________________________________________________________________________
	
		GameAI objGameAI;
		Network objNetwork;

		//_____________________________________________________________________________________________
		//
		// It indicates if it was a network play,
		// number of player and server´s IP address
		//_____________________________________________________________________________________________
	
		public bool wNetworkPlay=false;
		int wNumberPlayers=1;
		string wServerIP="";

		//_____________________________________________________________________________________________
		//
		// It indicates if it was a client or server turned on for network play
		//_____________________________________________________________________________________________

		public bool wServer=false;
		public bool wClient=false;

		//_____________________________________________________________________________________________
		//
		// SCORE
		//_____________________________________________________________________________________________
	
		int wScoreTotalMatches=0;
		int wScoreBall=0;
		int wScoreCross=0;
		int wScoreDraw=0;

		//_____________________________________________________________________________________________
		//
		// The kind of line to be draw in case of a winner
		//_____________________________________________________________________________________________
	
		private enLineType wLineType=enLineType.Vertical;
		private int wLinePosition;

		//_____________________________________________________________________________________________
		//
		// CPU AI difficulty
		//_____________________________________________________________________________________________

		public enDifficulty wDifficulty=enDifficulty.Hard;

		//_____________________________________________________________________________________________
		//
		// Keyboard control
		//_____________________________________________________________________________________________

		public enum enControl
		{
			BallLeft=0,
			BallRight=1
		}
		private enControl wControl=enControl.BallRight;

		//_____________________________________________________________________________________________
		//
		// Who plays, who won, the kind of player is CPU and human
		//_____________________________________________________________________________________________
		
		public enPlayType wTurn=enPlayType.Ball;
		public enPlayType wWinner=enPlayType.None;

		public enPlayType wTypeCPU=enPlayType.Cross;
		public enPlayType wTypePlayer=enPlayType.Ball;

		//_____________________________________________________________________________________________
		//
		// Board is saved in a matrix
		//_____________________________________________________________________________________________

		public enPlayType[,] wBoard = new enPlayType[4, 4] {{enPlayType.None,enPlayType.None,enPlayType.None,enPlayType.None},
															 {enPlayType.None,enPlayType.None,enPlayType.None,enPlayType.None},
															 {enPlayType.None,enPlayType.None,enPlayType.None,enPlayType.None},
															 {enPlayType.None,enPlayType.None,enPlayType.None,enPlayType.None}};
		
		//_____________________________________________________________________________________________
		//
		// BitBlt for screen capture
		//_____________________________________________________________________________________________

		[DllImport("GDI32.dll")]
		public static extern bool BitBlt(IntPtr hdcDest,int nXDest,int nYDest,
			int nWidth,int nHeight,IntPtr hdcSrc,
			int nXSrc,int nYSrc,int dwRop);

		#endregion

		#region Initializations 

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmTicTacToe());
		}
	
		private void Form1_Load(object sender, System.EventArgs e)
		{
			//_____________________________________________________________________________________________
			//
			// Configures status bar and game for one player vs CPU
			//_____________________________________________________________________________________________

			stbMessage.Panels.Add("");
			stbMessage.Panels[0].AutoSize=StatusBarPanelAutoSize.Spring;
			gbScore.Location=new Point(7,256);

			objNetwork=new Network(this);
			mnOnePlayer_Click(null,null);
			
		}

		#endregion

		#region Game (2 players) 

		public void RestartGame()
		{

			//_____________________________________________________________________________________________
			//
			// Restart the whole game
			//_____________________________________________________________________________________________

			picWinner.Visible=false;
			pic11.Image=null;pic12.Image=null;pic13.Image=null;
			pic21.Image=null;pic22.Image=null;pic23.Image=null;
			pic31.Image=null;pic32.Image=null;pic33.Image=null;

			wTurn=enPlayType.Ball;
			wWinner=enPlayType.None;
			SetStatusMessage("");

			wBoard = new enPlayType[4, 4] {{enPlayType.None,enPlayType.None,enPlayType.None,enPlayType.None},
																{enPlayType.None,enPlayType.None,enPlayType.None,enPlayType.None},
																{enPlayType.None,enPlayType.None,enPlayType.None,enPlayType.None},
																{enPlayType.None,enPlayType.None,enPlayType.None,enPlayType.None}};

			objGameAI=new GameAI(this);

			//_____________________________________________________________________________________________
			//
			// Ball allways begin, if CPU is ball make the computer move
			//_____________________________________________________________________________________________

			if ((wTypeCPU==enPlayType.Ball) && (wNumberPlayers==1))
				objGameAI.MakeComputerMove();

		}

		private void pic1_Click(object sender, System.EventArgs e)
		{
			//_____________________________________________________________________________________________
			//
			// Gets the clicked picture and gets it´s row/column
			//_____________________________________________________________________________________________

			System.Windows.Forms.PictureBox wImage = (System.Windows.Forms.PictureBox)(sender);
			string wNumber=((System.Windows.Forms.Control)(((System.Windows.Forms.PictureBox)(sender)))).Name;
			int wRow =int.Parse(wNumber.Substring(3,1));
			int wColumn =int.Parse(wNumber.Substring(4,1));

			//_____________________________________________________________________________________________
			//
			// Make the move using the row/column of the clicked picure
			//_____________________________________________________________________________________________

			MakeMove(wRow,wColumn);
		}

		public void MakeMove(int pRow, int pColumn)
		{
		
			int wRow=pRow;
			int wColumn=pColumn;

			if ((stbMessage.Panels[0].Text=="Connecting...") ||
				(stbMessage.Panels[0].Text=="Waiting for connection..."))
				return;

			//_____________________________________________________________________________________________
			//
			// Gets the picture object to the changed
			//_____________________________________________________________________________________________

			System.Windows.Forms.PictureBox wImage=pic11;

			if (wRow==1 && wColumn==1) wImage=pic11;
			if (wRow==1 && wColumn==2) wImage=pic12;
			if (wRow==1 && wColumn==3) wImage=pic13;
			if (wRow==2 && wColumn==1) wImage=pic21;
			if (wRow==2 && wColumn==2) wImage=pic22;
			if (wRow==2 && wColumn==3) wImage=pic23;
			if (wRow==3 && wColumn==1) wImage=pic31;
			if (wRow==3 && wColumn==2) wImage=pic32;
			if (wRow==3 && wColumn==3) wImage=pic33;

			//_____________________________________________________________________________________________
			//
			// Move network move
			//_____________________________________________________________________________________________

			if (((wServer==true) && (wTurn==enPlayType.Ball) && (wNetworkPlay==false)) ||
                 ((wClient==true) && (wTurn==enPlayType.Cross) && (wNetworkPlay==false)))
			{
				 objNetwork.SendMove(wRow,wColumn);
			}
			else
			{
				if (((wServer==true) && (wTurn==enPlayType.Cross) && (wNetworkPlay==false)) ||
					((wClient==true) && (wTurn==enPlayType.Ball) && (wNetworkPlay==false)))
					return;
			}

			//_____________________________________________________________________________________________
			//
			// Verify if the position is empty
			//_____________________________________________________________________________________________

			if (wBoard[wRow,wColumn]==enPlayType.None)
			{
				wBoard[wRow,wColumn]=wTurn;

				if (wTurn==enPlayType.Cross)
				{
					//_____________________________________________________________________________________________
					//
					// Places a X
					//_____________________________________________________________________________________________

					wImage.Image=ilBolaXis.Images[0];
					wImage.Refresh();
					wTurn=enPlayType.Ball;
				}
				else
				{
					//_____________________________________________________________________________________________
					//
					// Places an O
					//_____________________________________________________________________________________________

					wImage.Image=ilBolaXis.Images[1];
					wImage.Refresh();
					wTurn=enPlayType.Cross;
				}
			
				if (wWinner==enPlayType.None)
				{
					//_____________________________________________________________________________________________
					//
					// Verify if someone has won
					//_____________________________________________________________________________________________

					VerifyWinner();

					//_____________________________________________________________________________________________
					//
					// Move CPU move (if there is no winner and it is a one player game)
					//_____________________________________________________________________________________________

					if ((wTurn==wTypeCPU) && (wNumberPlayers==1))
						objGameAI.MakeComputerMove();	
				}

			}	//if (wBoard[wRow,wColumn]==enPlayType.None)

			wNetworkPlay=false;
		}


		private void VerifyWinner()
		{
			//_____________________________________________________________________________________________
			//
			// Function to check if someone has won
			//_____________________________________________________________________________________________

			int wSum1=(int)wBoard[1,1]+(int)wBoard[1,2]+(int)wBoard[1,3];
			int wSum2=(int)wBoard[2,1]+(int)wBoard[2,2]+(int)wBoard[2,3];
			int wSum3=(int)wBoard[3,1]+(int)wBoard[3,2]+(int)wBoard[3,3];

			int wSum4=(int)wBoard[1,1]+(int)wBoard[2,1]+(int)wBoard[3,1];
			int wSum5=(int)wBoard[1,2]+(int)wBoard[2,2]+(int)wBoard[3,2];
			int wSum6=(int)wBoard[1,3]+(int)wBoard[2,3]+(int)wBoard[3,3];

			int wSum7=(int)wBoard[1,1]+(int)wBoard[2,2]+(int)wBoard[3,3];
			int wSum8=(int)wBoard[3,1]+(int)wBoard[2,2]+(int)wBoard[1,3];

			//_____________________________________________________________________________________________
			//
			// Show the winner
			//_____________________________________________________________________________________________

			if ((wSum1==3) || (wSum2==3) || (wSum3==3) ||
				(wSum4==3) || (wSum5==3) || (wSum6==3) ||
				(wSum7==3) || (wSum8==3))
			{
				wWinner=enPlayType.Ball;
				SetStatusMessage("The player BALL wins!");
				wScoreTotalMatches++;
				wScoreBall++;
				RefreshScore();
				
				goto winner;
			}

			if ((wSum1==30) || (wSum2==30) || (wSum3==30) || 
				(wSum4==30) || (wSum5==30) || (wSum6==30) ||
				(wSum7==30) || (wSum8==30))
			{
				wWinner=enPlayType.Cross;
				SetStatusMessage("The player CROSS wins!");
				wScoreTotalMatches++;
				wScoreCross++;
				RefreshScore();

				goto winner;
			}

			//_____________________________________________________________________________________________
			//
			// Verify draw
			//_____________________________________________________________________________________________

			bool wDraw=true;
			int e=0;
			int f=0;

			for (e=1;e<=3;e++)
				for (f=1;f<=3;f++)
					if (wBoard[f,e]==enPlayType.None)
					{
						wDraw=false;
						goto winner;
					}
			
			if (wDraw==true)
			{
				SetStatusMessage("DRAW!");
				DrawLine(0,enLineType.Vertical);

				wScoreTotalMatches++;
				wScoreDraw++;
				RefreshScore();

				return;
			}

			winner:

			//_____________________________________________________________________________________________
			//
			// Draw a line where there is 3 of the same kind
			//_____________________________________________________________________________________________

			if ((wSum1==3) || (wSum1==30))
				DrawLine(1,enLineType.Horizontal);
			if ((wSum2==3) || (wSum2==30))
				DrawLine(2,enLineType.Horizontal);
			if ((wSum3==3) || (wSum3==30))
				DrawLine(3,enLineType.Horizontal);
		
			if ((wSum4==3) || (wSum4==30))
				DrawLine(1,enLineType.Vertical);
			if ((wSum5==3) || (wSum5==30))
				DrawLine(2,enLineType.Vertical);
			if ((wSum6==3) || (wSum6==30))
				DrawLine(3,enLineType.Vertical);

			if ((wSum7==3) || (wSum7==30))
				DrawLine(1,enLineType.DiagonalRight);
			
			if ((wSum8==3) || (wSum8==30))
				DrawLine(1,enLineType.DiagonalLeft);
			
		}
		
		private void DrawLine(int pPosition, enLineType pLineType)
		{

			//_____________________________________________________________________________________________
			//
			// Saves position and line type in globals for the 
			// OnPaint routine of picWinner draw the line
			//_____________________________________________________________________________________________

			wLinePosition=pPosition;
			wLineType=pLineType;

			//_____________________________________________________________________________________________
			//
			// Captures game screen (BitBlt)
			//_____________________________________________________________________________________________

			Graphics g1  = this.CreateGraphics();
			Bitmap MyImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, g1);
			Graphics g2   = Graphics.FromImage(MyImage);
			IntPtr dc1   = g1.GetHdc();
			IntPtr dc2  = g2.GetHdc();
			BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
			g1.ReleaseHdc(dc1);
			g2.ReleaseHdc(dc2);
						
			//_____________________________________________________________________________________________
			//
			// Puts game screen in picWinner
			//_____________________________________________________________________________________________
		
			picWinner.Image=MyImage;

			//_____________________________________________________________________________________________
			//
			// Show the picure using Invoke because of socket thread 
			// (locks the game if you set picWinner.Visible=True)
			//_____________________________________________________________________________________________
		
			object[] p = new object[1];
			p[0] = picWinner;
		    picWinner.Invoke(new MakeVisibleHandler(MakeVisible), p);

		}

		public delegate void MakeVisibleHandler(Control control);

		public void MakeVisible(Control control)
		{
			//_____________________________________________________________________________________________
			//
			// Make changes to UI using Invoke because of socket thread
			//_____________________________________________________________________________________________
		
			control.Visible = true;
		}

		private void picWinner_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{

			//_____________________________________________________________________________________________
			//
			// Draw winner line in picWinner
			//_____________________________________________________________________________________________
		
			System.Drawing.Pen myPen=new System.Drawing.Pen(System.Drawing.Color.RoyalBlue,6);

			if (wWinner==enPlayType.Ball)
				myPen.Color=Color.RoyalBlue;

			if (wWinner==enPlayType.Cross)
				myPen.Color=Color.OrangeRed;

			switch(wLineType)
			{
				case enLineType.Horizontal:
				{
					e.Graphics.DrawLine(myPen, 25, 55+(wLinePosition-1)*73, picWinner.Height-10, 55+(wLinePosition-1)*73);
					break;
				}
				case enLineType.Vertical:
				{
					e.Graphics.DrawLine(myPen, 65+(wLinePosition-1)*75, 25, 65+(wLinePosition-1)*75,picWinner.Width-50);
					break;
				}
				case enLineType.DiagonalRight:
				{
					e.Graphics.DrawLine(myPen, 25, 25,  picWinner.Height-10,picWinner.Width-65);
					break;
				}
				case enLineType.DiagonalLeft:
				{
					e.Graphics.DrawLine(myPen, picWinner.Height-10, 25,  25,picWinner.Width-55);
					break;
				}
			}

			myPen.Dispose();
			
		}


		private void RefreshScore()
		{
			//_____________________________________________________________________________________________
			//
			// Refreshes the score (Matches, Ball, Cross, Draws)
			//_____________________________________________________________________________________________

			lbMaches.Text= wScoreTotalMatches.ToString() + " Matches";
			lbScoreBall.Text= wScoreBall.ToString();
			lbScoreCross.Text= wScoreCross.ToString();
			lbScoreDraw.Text= wScoreDraw.ToString();
		}

		public void SetStatusMessage(string pMensagem)
		{
			//_____________________________________________________________________________________________
			//
			// Set status bar message
			//_____________________________________________________________________________________________

			stbMessage.Panels[0].Text=pMensagem;
		}

		#endregion
	
		#region Menu 

		private void mnNew_Click(object sender, System.EventArgs e)
		{
			
			//_____________________________________________________________________________________________
			//
			// If it is a network game, send a message for the other game to restart
			//_____________________________________________________________________________________________

			if ((wClient==true) || (wServer==true))
				objNetwork.SendsRestartPacket();
			
			//_____________________________________________________________________________________________
			//
			// New game
			//_____________________________________________________________________________________________

			RestartGame();
		}

		private void mnExit_Click(object sender, System.EventArgs e)
		{
			//_____________________________________________________________________________________________
			//
			// Exit the game
			//_____________________________________________________________________________________________

			Application.Exit();
		}

		private void mnResetScore_Click(object sender, System.EventArgs e)
		{
			//_____________________________________________________________________________________________
			//
			// Reset score
			//_____________________________________________________________________________________________

			wScoreTotalMatches=0;
			wScoreBall=0;
			wScoreCross=0;
			wScoreDraw=0;
		
			RefreshScore();
		}

		private void mnOnePlayer_Click(object sender, System.EventArgs e)
		{

			//_____________________________________________________________________________________________
			//
			// Disconnect network game
			//_____________________________________________________________________________________________

			mnDisconnect_Click(null,null);

			//_____________________________________________________________________________________________
			//
			// Sets game for one player
			//_____________________________________________________________________________________________

			wNumberPlayers=1;
			mnTwoPlayers.Checked=false;
			mnOnePlayer.Checked=true;

			mnDificuldade.Enabled=true;
			mnControles.Enabled=false;
			mnCPUO.Enabled=true;
			mnCPUX.Enabled=true;
			mnCPUX_Click(null,null);
			mnRede.Enabled=false;

			RestartGame();

		}

		private void mnTwoPlayers_Click(object sender, System.EventArgs e)
		{
			//_____________________________________________________________________________________________
			//
			// Sets game for two players
			//_____________________________________________________________________________________________

			wNumberPlayers=2;
			mnOnePlayer.Checked=false;
			mnTwoPlayers.Checked=true;

			mnDificuldade.Enabled=false;
			mnControles.Enabled=true;
			mnCPUO.Enabled=false;
			mnCPUX.Enabled=false;

			mnRede.Enabled=true;

			RestartGame();
		
		}

		private void mnCPUX_Click(object sender, System.EventArgs e)
		{
		
			//_____________________________________________________________________________________________
			//
			// Sets CPU to play as CROSS (X)
			//_____________________________________________________________________________________________

			wTypeCPU=enPlayType.Cross;
			wTypePlayer=enPlayType.Ball;
			mnCPUO.Checked=false;
			mnCPUX.Checked=true;
			
			RestartGame();

		}

		private void mnCPUO_Click(object sender, System.EventArgs e)
		{
		
			//_____________________________________________________________________________________________
			//
			// // Sets CPU to play as BALL (O)
			//_____________________________________________________________________________________________

			wTypeCPU=enPlayType.Ball;
			wTypePlayer=enPlayType.Cross;
			mnCPUX.Checked=false;
			mnCPUO.Checked=true;

			RestartGame();
		}

		private void mnDifficultHard_Click(object sender, System.EventArgs e)
		{
		
			//_____________________________________________________________________________________________
			//
			// Sets hard difficulty for one player
			//_____________________________________________________________________________________________

			wDifficulty=enDifficulty.Hard;
			mnDifficultEasy.Checked=false;
			mnDifficultAverage.Checked=false;
			mnDifficultHard.Checked=true;
			
			RestartGame();
		}

		private void mnDifficultAverage_Click(object sender, System.EventArgs e)
		{
		
			//_____________________________________________________________________________________________
			//
			// Sets average difficulty for one player
			//_____________________________________________________________________________________________

			wDifficulty=enDifficulty.Average;
			mnDifficultEasy.Checked=false;
			mnDifficultAverage.Checked=true;
			mnDifficultHard.Checked=false;
			
			RestartGame();
		}

		private void mnDifficultEasy_Click(object sender, System.EventArgs e)
		{
		
			//_____________________________________________________________________________________________
			//
			// Sets easy difficulty for one player
			//_____________________________________________________________________________________________

			mnDifficultEasy.Checked=true;
			mnDifficultAverage.Checked=false;
			mnDifficultHard.Checked=false;
			
			wDifficulty=enDifficulty.Easy;
			RestartGame();
		}

		private void mnBallRight_Click(object sender, System.EventArgs e)
		{
			
			//_____________________________________________________________________________________________
			//
			// Configures ball control as the left part of the keyboard
			//_____________________________________________________________________________________________

			mnBallLeft.Checked=false;
			mnBallRight.Checked=true;
			wControl=enControl.BallRight;
		}

		private void mnBallLeft_Click(object sender, System.EventArgs e)
		{

			//_____________________________________________________________________________________________
			//
			// Configures ball control as the right part of the keyboard
			//_____________________________________________________________________________________________

			mnBallRight.Checked=false;
			mnBallLeft.Checked=true;
			wControl=enControl.BallLeft;
		
		}
	
		private void mnStartServer_Click(object sender, System.EventArgs e)
		{

			//_____________________________________________________________________________________________
			//
			// Starts server for network play
			//_____________________________________________________________________________________________

			mnBallRight_Click(null,null);
			mnControles.Enabled=false;
			wServer=true;
			objNetwork.StartServer();
			SetStatusMessage("Waiting for connection...");
			mnConnectServer.Enabled=false;
			mnStartServer.Enabled=false;
			mnDisconnect.Enabled=true;
			
		}
	
		private void mnConnectServer_Click(object sender, System.EventArgs e)
		{
			
			//_____________________________________________________________________________________________
			//
			// Connect to game server
			//_____________________________________________________________________________________________

			DialogResult wDialog=InputBox.ShowInputBox("What is the server Name/IP?","Server name",wServerIP,ref wServerIP);
			if (wDialog==DialogResult.Cancel)
				return;

			mnBallLeft_Click(null,null);
			mnControles.Enabled=false;
			wClient=true;
			objNetwork.ConnectServer(wServerIP);
			SetStatusMessage("Connecting...");
			mnConnectServer.Enabled=false;
			mnStartServer.Enabled=false;
			mnDisconnect.Enabled=true;

		}

		private void frmTicTacToe_Closed(object sender, System.EventArgs e)
		{

			//_____________________________________________________________________________________________
			//
			// Close all connections 
			//_____________________________________________________________________________________________

			if ((wServer==true) || (wClient==true))
				objNetwork.Disconnect();

		}

		public void mnDisconnect_Click(object sender, System.EventArgs e)
		{
			
			//_____________________________________________________________________________________________
			//
			// Disconnect network game
			//_____________________________________________________________________________________________

			objNetwork.Disconnect();
			wServer=false;
			wClient=false;

			mnControles.Enabled=true;
			mnConnectServer.Enabled=true;
			mnStartServer.Enabled=true;
			mnDisconnect.Enabled=false;

			RestartGame();
		}


		#endregion
		
		#region Keyboard control 
 
		public void frmTicTacToe_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{

			//_____________________________________________________________________________________________
			//
			// Keybord control (123,465,789) (ZXC,ASD,QWE)
			//_____________________________________________________________________________________________
				
			bool wNumeric=false;

			if (wNumberPlayers==2)
			{

				//_____________________________________________________________________________________________
				//
				// If it is a network play, server plays with O and client with X
				//_____________________________________________________________________________________________
				
				if ((wServer==true) && (wTurn==enPlayType.Cross))
					return;

				if ((wClient==true) && (wTurn==enPlayType.Ball))
					return;
				
				//_____________________________________________________________________________________________
				//
				// Verify if the keyboard control is correct and
				// if it is its turn to play
				//_____________________________________________________________________________________________

				if (wControl==enControl.BallRight && wTurn==enPlayType.Ball)
					wNumeric=true;

				if (wControl==enControl.BallLeft && wTurn==enPlayType.Cross)
					wNumeric=true;

				if (wNumeric==true)
				{

					//_____________________________________________________________________________________________
					//
					// Control via NumPAD
					//_____________________________________________________________________________________________

					if (e.KeyCode==Keys.NumPad7)
						MakeMove(1,1);
			
					if (e.KeyCode==Keys.NumPad8)
						MakeMove(1,2);

					if (e.KeyCode==Keys.NumPad9)
						MakeMove(1,3);
				
					if (e.KeyCode==Keys.NumPad4)
						MakeMove(2,1);
					
					if (e.KeyCode==Keys.NumPad5)
						MakeMove(2,2);

					if (e.KeyCode==Keys.NumPad6)
						MakeMove(2,3);

					if (e.KeyCode==Keys.NumPad1)
						MakeMove(3,1);
				
					if (e.KeyCode==Keys.NumPad2)
						MakeMove(3,2);

					if (e.KeyCode==Keys.NumPad3)
						MakeMove(3,3);
				}
				else
				{
					//_____________________________________________________________________________________________
					//
					// Control via QWE
					//_____________________________________________________________________________________________

					if (e.KeyCode==Keys.Q)
						MakeMove(1,1);
			
					if (e.KeyCode==Keys.W)
						MakeMove(1,2);

					if (e.KeyCode==Keys.E)
						MakeMove(1,3);
				
					if (e.KeyCode==Keys.A)
						MakeMove(2,1);
					
					if (e.KeyCode==Keys.S)
						MakeMove(2,2);

					if (e.KeyCode==Keys.D)
						MakeMove(2,3);

					if (e.KeyCode==Keys.Z)
						MakeMove(3,1);
				
					if (e.KeyCode==Keys.X)
						MakeMove(3,2);

					if (e.KeyCode==Keys.C)
						MakeMove(3,3);
				}
			}
			else
			{
				//_____________________________________________________________________________________________
				//
				// For one player, both sides of the keyboard work
				//_____________________________________________________________________________________________

				if (e.KeyCode==Keys.NumPad7 || e.KeyCode==Keys.Q)
					MakeMove(1,1);
			
				if (e.KeyCode==Keys.NumPad8 || e.KeyCode==Keys.W)
					MakeMove(1,2);

				if (e.KeyCode==Keys.NumPad9 || e.KeyCode==Keys.E)
					MakeMove(1,3);
				
				if (e.KeyCode==Keys.NumPad4 || e.KeyCode==Keys.A)
					MakeMove(2,1);
					
				if (e.KeyCode==Keys.NumPad5 || e.KeyCode==Keys.S)
					MakeMove(2,2);

				if (e.KeyCode==Keys.NumPad6 || e.KeyCode==Keys.D)
					MakeMove(2,3);

				if (e.KeyCode==Keys.NumPad1 || e.KeyCode==Keys.Z)
					MakeMove(3,1);
				
				if (e.KeyCode==Keys.NumPad2 || e.KeyCode==Keys.X)
					MakeMove(3,2);

				if (e.KeyCode==Keys.NumPad3 || e.KeyCode==Keys.C)
					MakeMove(3,3);
			}

		}

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

