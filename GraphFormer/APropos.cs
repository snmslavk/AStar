// Copyright 2003 Eric Marchesin - <eric.marchesin@laposte.net>
//
// This source file(s) may be redistributed by any means PROVIDING they
// are not sold for profit without the authors expressed written consent,
// and providing that this notice and the authors name and all copyright
// notices remain intact.
// THIS SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED. USE IT AT YOUR OWN RISK. THE AUTHOR ACCEPTS NO
// LIABILITY FOR ANY DATA DAMAGE/LOSS THAT THIS PRODUCT MAY CAUSE.
//-----------------------------------------------------------------------
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;


namespace GraphFormer
{
	public class APropos : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.TrackBar trackBar;
		private System.Windows.Forms.Button BoutonValider;
		private System.Windows.Forms.Button BoutonAnnuler;
		private System.Windows.Forms.Button BoutonFermer;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button BouttonAppliquer;
		private System.ComponentModel.Container components = null;

		public APropos()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(APropos));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.BoutonFermer = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.BouttonAppliquer = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.BoutonAnnuler = new System.Windows.Forms.Button();
			this.BoutonValider = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.trackBar = new System.Windows.Forms.TrackBar();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Control;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(528, 196);
			this.textBox1.TabIndex = 0;
			this.textBox1.TabStop = false;
			this.textBox1.Text = @"
Application created by Eric Marchesin - Copyright (C) - April 2003
This is an unassuming program that modestly claims to be simple and ergonomic to test the graph structure.

-> First this is an editor to build, modify, save and load graphs made of nodes which are linked with arcs.
-> Then you just have to specify both starting and ending nodes on the current graph to get the best path.

The 'best path' is the one which has the lowest cost (in this case that is to say the shortest distance). The search is performed by an algorithm named A* : the remaining distance for each possible way is estimated and exploration is oriented according to the heuristic. You can see how it works with the 'step by step' mode.


Any feedback can be sent at the following e-mail adress :";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(280, 160);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(144, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "eric.marchesin@laposte.net";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPage1,
																					  this.tabPage2});
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(536, 222);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.BoutonFermer,
																				   this.textBox2,
																				   this.textBox1});
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(528, 196);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Information";
			// 
			// BoutonFermer
			// 
			this.BoutonFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BoutonFermer.Location = new System.Drawing.Point(440, 160);
			this.BoutonFermer.Name = "BoutonFermer";
			this.BoutonFermer.TabIndex = 1;
			this.BoutonFermer.Text = "Close";
			// 
			// tabPage2
			// 
			this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.BouttonAppliquer,
																				   this.label6,
																				   this.label3,
																				   this.label2,
																				   this.BoutonAnnuler,
																				   this.BoutonValider,
																				   this.label5,
																				   this.comboBox,
																				   this.label4,
																				   this.label1,
																				   this.trackBar});
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(528, 196);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Options";
			// 
			// BouttonAppliquer
			// 
			this.BouttonAppliquer.Location = new System.Drawing.Point(224, 160);
			this.BouttonAppliquer.Name = "BouttonAppliquer";
			this.BouttonAppliquer.TabIndex = 4;
			this.BouttonAppliquer.Text = "Apply";
			this.BouttonAppliquer.Click += new System.EventHandler(this.Appliquer_Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(264, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 56);
			this.label6.TabIndex = 10;
			this.label6.Text = "Minimize cost without exploring more nodes than needed";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(400, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 64);
			this.label3.TabIndex = 6;
			this.label3.Text = "Dijkstra only : do not perform estimation, but simply consider the actual current" +
				" cost";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(136, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 64);
			this.label2.TabIndex = 5;
			this.label2.Text = "Heuristic only : minimize the number of explored nodes by estimating the remainin" +
				"g cost";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BoutonAnnuler
			// 
			this.BoutonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BoutonAnnuler.Location = new System.Drawing.Point(312, 160);
			this.BoutonAnnuler.Name = "BoutonAnnuler";
			this.BoutonAnnuler.TabIndex = 5;
			this.BoutonAnnuler.Text = "Cancel";
			// 
			// BoutonValider
			// 
			this.BoutonValider.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.BoutonValider.Location = new System.Drawing.Point(136, 160);
			this.BoutonValider.Name = "BoutonValider";
			this.BoutonValider.Size = new System.Drawing.Size(72, 23);
			this.BoutonValider.TabIndex = 3;
			this.BoutonValider.Text = "Ok";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(296, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(224, 40);
			this.label5.TabIndex = 9;
			this.label5.Text = "This is the way to estimate the cost from the current to the ending node.";
			// 
			// comboBox
			// 
			this.comboBox.Items.AddRange(new object[] {
														  "Euclidian distance",
														  "Manhattan distance",
														  "Maximum distance along axis"});
			this.comboBox.Location = new System.Drawing.Point(104, 16);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(184, 21);
			this.comboBox.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "Heuristic to use :";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Heuristic/Dijkstra balance :";
			// 
			// trackBar
			// 
			this.trackBar.LargeChange = 1;
			this.trackBar.Location = new System.Drawing.Point(184, 56);
			this.trackBar.Maximum = 2;
			this.trackBar.Name = "trackBar";
			this.trackBar.Size = new System.Drawing.Size(288, 45);
			this.trackBar.TabIndex = 2;
			this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// APropos
			// 
			this.AcceptButton = this.BoutonValider;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.BoutonAnnuler;
			this.ClientSize = new System.Drawing.Size(536, 222);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tabControl1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "APropos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About GraphFormer...";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void trackBar_Scroll(object sender, System.EventArgs e)
		{
			comboBox.Enabled = trackBar.Value != trackBar.Maximum;
		}

		private void Appliquer_Click(object sender, System.EventArgs e)
		{
			GraphFormer GF = (GraphFormer)Owner;
			if ( GF==null ) throw new ArgumentException();
			GF.AppliquerChangement(this);
		}

		public double DijkstraHeuristiqueBalance
		{
			set
			{
				if ( value<0 || value>1 ) throw new ArgumentException("Value must belong to [0; 1]");
				trackBar.Value = (int)(trackBar.Maximum*value);
			}
			get { return ((double)trackBar.Value)/trackBar.Maximum; }
		}

		public int HeuristiqueChoisie
		{
			set
			{
				if ( value<0 || value>2 ) throw new ArgumentException("Value must belong to [0; 2]");
				comboBox.SelectedIndex = value;
			}
			get { return comboBox.SelectedIndex; }
		}
	}
}
