
namespace TruckerTracking
{
    partial class DFDS
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.getAdress_btn = new System.Windows.Forms.Button();
            this.getAddress_txt = new System.Windows.Forms.RichTextBox();
            this.long_txt = new System.Windows.Forms.TextBox();
            this.lat_txt = new System.Windows.Forms.TextBox();
            this.Longititude_txt = new System.Windows.Forms.Label();
            this.Lattitude_txt = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.beregn_resultat = new System.Windows.Forms.Label();
            this.Beregn_btn = new System.Windows.Forms.Button();
            this.BeregnTil_long = new System.Windows.Forms.TextBox();
            this.BeregnTil_Lat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BeregnFra_long = new System.Windows.Forms.TextBox();
            this.BeregnFra_Lat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CityFinder_btn = new System.Windows.Forms.Button();
            this.calulator = new System.Windows.Forms.Button();
            this.errorFra = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTil = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorFra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTil)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(93, -20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 467);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.getAdress_btn);
            this.tabPage1.Controls.Add(this.getAddress_txt);
            this.tabPage1.Controls.Add(this.long_txt);
            this.tabPage1.Controls.Add(this.lat_txt);
            this.tabPage1.Controls.Add(this.Longititude_txt);
            this.tabPage1.Controls.Add(this.Lattitude_txt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // getAdress_btn
            // 
            this.getAdress_btn.Location = new System.Drawing.Point(326, 39);
            this.getAdress_btn.Name = "getAdress_btn";
            this.getAdress_btn.Size = new System.Drawing.Size(75, 23);
            this.getAdress_btn.TabIndex = 7;
            this.getAdress_btn.Text = "Load city";
            this.getAdress_btn.UseVisualStyleBackColor = true;
            this.getAdress_btn.Click += new System.EventHandler(this.getAdress_btn_Click);
            // 
            // getAddress_txt
            // 
            this.getAddress_txt.Location = new System.Drawing.Point(6, 68);
            this.getAddress_txt.Name = "getAddress_txt";
            this.getAddress_txt.Size = new System.Drawing.Size(688, 150);
            this.getAddress_txt.TabIndex = 6;
            this.getAddress_txt.Text = "";
            // 
            // long_txt
            // 
            this.long_txt.Location = new System.Drawing.Point(171, 40);
            this.long_txt.Name = "long_txt";
            this.long_txt.Size = new System.Drawing.Size(138, 20);
            this.long_txt.TabIndex = 4;
            // 
            // lat_txt
            // 
            this.lat_txt.Location = new System.Drawing.Point(16, 40);
            this.lat_txt.Name = "lat_txt";
            this.lat_txt.Size = new System.Drawing.Size(138, 20);
            this.lat_txt.TabIndex = 3;
            // 
            // Longititude_txt
            // 
            this.Longititude_txt.AutoSize = true;
            this.Longititude_txt.Location = new System.Drawing.Point(168, 24);
            this.Longititude_txt.Name = "Longititude_txt";
            this.Longititude_txt.Size = new System.Drawing.Size(59, 13);
            this.Longititude_txt.TabIndex = 2;
            this.Longititude_txt.Text = "Longititude";
            // 
            // Lattitude_txt
            // 
            this.Lattitude_txt.AutoSize = true;
            this.Lattitude_txt.Location = new System.Drawing.Point(13, 24);
            this.Lattitude_txt.Name = "Lattitude_txt";
            this.Lattitude_txt.Size = new System.Drawing.Size(48, 13);
            this.Lattitude_txt.TabIndex = 1;
            this.Lattitude_txt.Text = "Lattitude";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.beregn_resultat);
            this.tabPage2.Controls.Add(this.Beregn_btn);
            this.tabPage2.Controls.Add(this.BeregnTil_long);
            this.tabPage2.Controls.Add(this.BeregnTil_Lat);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.BeregnFra_long);
            this.tabPage2.Controls.Add(this.BeregnFra_Lat);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(697, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Til";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fra";
            // 
            // beregn_resultat
            // 
            this.beregn_resultat.AutoSize = true;
            this.beregn_resultat.Location = new System.Drawing.Point(361, 47);
            this.beregn_resultat.Name = "beregn_resultat";
            this.beregn_resultat.Size = new System.Drawing.Size(0, 13);
            this.beregn_resultat.TabIndex = 13;
            // 
            // Beregn_btn
            // 
            this.Beregn_btn.Location = new System.Drawing.Point(248, 139);
            this.Beregn_btn.Name = "Beregn_btn";
            this.Beregn_btn.Size = new System.Drawing.Size(84, 31);
            this.Beregn_btn.TabIndex = 4;
            this.Beregn_btn.Text = "Beregn";
            this.Beregn_btn.UseVisualStyleBackColor = true;
            this.Beregn_btn.Click += new System.EventHandler(this.Beregn_btn_Click);
            // 
            // BeregnTil_long
            // 
            this.BeregnTil_long.Location = new System.Drawing.Point(202, 92);
            this.BeregnTil_long.Name = "BeregnTil_long";
            this.BeregnTil_long.Size = new System.Drawing.Size(130, 20);
            this.BeregnTil_long.TabIndex = 12;
            this.BeregnTil_long.Text = "12.527068";
            // 
            // BeregnTil_Lat
            // 
            this.BeregnTil_Lat.Location = new System.Drawing.Point(31, 92);
            this.BeregnTil_Lat.Name = "BeregnTil_Lat";
            this.BeregnTil_Lat.Size = new System.Drawing.Size(144, 20);
            this.BeregnTil_Lat.TabIndex = 11;
            this.BeregnTil_Lat.Text = "55.725604";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Longititude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lattitude";
            // 
            // BeregnFra_long
            // 
            this.BeregnFra_long.Location = new System.Drawing.Point(202, 40);
            this.BeregnFra_long.Name = "BeregnFra_long";
            this.BeregnFra_long.Size = new System.Drawing.Size(130, 20);
            this.BeregnFra_long.TabIndex = 8;
            this.BeregnFra_long.Text = "12.519173";
            // 
            // BeregnFra_Lat
            // 
            this.BeregnFra_Lat.Location = new System.Drawing.Point(31, 40);
            this.BeregnFra_Lat.Name = "BeregnFra_Lat";
            this.BeregnFra_Lat.Size = new System.Drawing.Size(144, 20);
            this.BeregnFra_Lat.TabIndex = 7;
            this.BeregnFra_Lat.Text = "55.732011";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Longititude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lattitude";
            // 
            // CityFinder_btn
            // 
            this.CityFinder_btn.Location = new System.Drawing.Point(3, 49);
            this.CityFinder_btn.Name = "CityFinder_btn";
            this.CityFinder_btn.Size = new System.Drawing.Size(84, 31);
            this.CityFinder_btn.TabIndex = 1;
            this.CityFinder_btn.Text = "City Finder";
            this.CityFinder_btn.UseVisualStyleBackColor = true;
            this.CityFinder_btn.Click += new System.EventHandler(this.CityFinder_btn_Click);
            // 
            // calulator
            // 
            this.calulator.Location = new System.Drawing.Point(3, 96);
            this.calulator.Name = "calulator";
            this.calulator.Size = new System.Drawing.Size(84, 31);
            this.calulator.TabIndex = 2;
            this.calulator.Text = "Calulatior Km";
            this.calulator.UseVisualStyleBackColor = true;
            this.calulator.Click += new System.EventHandler(this.calulator_Click);
            // 
            // errorFra
            // 
            this.errorFra.ContainerControl = this;
            // 
            // errorTil
            // 
            this.errorTil.ContainerControl = this;
            // 
            // DFDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 232);
            this.Controls.Add(this.calulator);
            this.Controls.Add(this.CityFinder_btn);
            this.Controls.Add(this.tabControl1);
            this.Name = "DFDS";
            this.Text = "DFDS";
            this.Load += new System.EventHandler(this.DFDS_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorFra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox long_txt;
        private System.Windows.Forms.TextBox lat_txt;
        private System.Windows.Forms.Label Longititude_txt;
        private System.Windows.Forms.Label Lattitude_txt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button CityFinder_btn;
        private System.Windows.Forms.Button calulator;
        private System.Windows.Forms.RichTextBox getAddress_txt;
        private System.Windows.Forms.Button getAdress_btn;
        private System.Windows.Forms.Button Beregn_btn;
        private System.Windows.Forms.TextBox BeregnTil_long;
        private System.Windows.Forms.TextBox BeregnTil_Lat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BeregnFra_long;
        private System.Windows.Forms.TextBox BeregnFra_Lat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label beregn_resultat;
        private System.Windows.Forms.ErrorProvider errorFra;
        private System.Windows.Forms.ErrorProvider errorTil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

