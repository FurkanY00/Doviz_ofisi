namespace Doviz_ofisi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btndolaral = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsatisyap = new System.Windows.Forms.Button();
            this.txtkalan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtkur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btndolarsat = new System.Windows.Forms.Button();
            this.btneuroal = new System.Windows.Forms.Button();
            this.btneurosat = new System.Windows.Forms.Button();
            this.lbldolaralis = new System.Windows.Forms.Label();
            this.lbldolarsatis = new System.Windows.Forms.Label();
            this.lbleuroalis = new System.Windows.Forms.Label();
            this.lbleurosatis = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(55, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(42, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolar Satış:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(61, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Euro Alış:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(48, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Euro Satış:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btndolaral
            // 
            this.btndolaral.Location = new System.Drawing.Point(281, 56);
            this.btndolaral.Name = "btndolaral";
            this.btndolaral.Size = new System.Drawing.Size(36, 29);
            this.btndolaral.TabIndex = 4;
            this.btndolaral.Text = "...";
            this.btndolaral.UseVisualStyleBackColor = true;
            this.btndolaral.Click += new System.EventHandler(this.btndolaral_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnsatisyap);
            this.groupBox1.Controls.Add(this.txtkalan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txttutar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtmiktar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtkur);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(268, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 236);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tutara Göre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsatisyap
            // 
            this.btnsatisyap.Location = new System.Drawing.Point(46, 178);
            this.btnsatisyap.Name = "btnsatisyap";
            this.btnsatisyap.Size = new System.Drawing.Size(166, 36);
            this.btnsatisyap.TabIndex = 8;
            this.btnsatisyap.Text = "Miktara Göre";
            this.btnsatisyap.UseVisualStyleBackColor = true;
            this.btnsatisyap.Click += new System.EventHandler(this.btnsatisyap_Click);
            // 
            // txtkalan
            // 
            this.txtkalan.Location = new System.Drawing.Point(81, 141);
            this.txtkalan.Name = "txtkalan";
            this.txtkalan.Size = new System.Drawing.Size(277, 31);
            this.txtkalan.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Kalan:";
            // 
            // txttutar
            // 
            this.txttutar.Location = new System.Drawing.Point(81, 104);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(277, 31);
            this.txttutar.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tutar:";
            // 
            // txtmiktar
            // 
            this.txtmiktar.Location = new System.Drawing.Point(81, 67);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(277, 31);
            this.txtmiktar.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Miktar:";
            // 
            // txtkur
            // 
            this.txtkur.Location = new System.Drawing.Point(81, 30);
            this.txtkur.Name = "txtkur";
            this.txtkur.Size = new System.Drawing.Size(277, 31);
            this.txtkur.TabIndex = 1;
            this.txtkur.TextChanged += new System.EventHandler(this.txtkur_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kur:";
            // 
            // btndolarsat
            // 
            this.btndolarsat.Location = new System.Drawing.Point(281, 90);
            this.btndolarsat.Name = "btndolarsat";
            this.btndolarsat.Size = new System.Drawing.Size(36, 29);
            this.btndolarsat.TabIndex = 6;
            this.btndolarsat.Text = "...";
            this.btndolarsat.UseVisualStyleBackColor = true;
            this.btndolarsat.Click += new System.EventHandler(this.btndolarsat_Click);
            // 
            // btneuroal
            // 
            this.btneuroal.Location = new System.Drawing.Point(281, 154);
            this.btneuroal.Name = "btneuroal";
            this.btneuroal.Size = new System.Drawing.Size(36, 29);
            this.btneuroal.TabIndex = 7;
            this.btneuroal.Text = "...";
            this.btneuroal.UseVisualStyleBackColor = true;
            this.btneuroal.Click += new System.EventHandler(this.btneuroal_Click);
            // 
            // btneurosat
            // 
            this.btneurosat.Location = new System.Drawing.Point(281, 197);
            this.btneurosat.Name = "btneurosat";
            this.btneurosat.Size = new System.Drawing.Size(36, 29);
            this.btneurosat.TabIndex = 8;
            this.btneurosat.Text = "...";
            this.btneurosat.UseVisualStyleBackColor = true;
            this.btneurosat.Click += new System.EventHandler(this.btneurosat_Click);
            // 
            // lbldolaralis
            // 
            this.lbldolaralis.AutoSize = true;
            this.lbldolaralis.BackColor = System.Drawing.Color.Transparent;
            this.lbldolaralis.Location = new System.Drawing.Point(171, 58);
            this.lbldolaralis.Name = "lbldolaralis";
            this.lbldolaralis.Size = new System.Drawing.Size(24, 25);
            this.lbldolaralis.TabIndex = 9;
            this.lbldolaralis.Text = "0";
            // 
            // lbldolarsatis
            // 
            this.lbldolarsatis.AutoSize = true;
            this.lbldolarsatis.BackColor = System.Drawing.Color.Transparent;
            this.lbldolarsatis.Location = new System.Drawing.Point(171, 94);
            this.lbldolarsatis.Name = "lbldolarsatis";
            this.lbldolarsatis.Size = new System.Drawing.Size(24, 25);
            this.lbldolarsatis.TabIndex = 10;
            this.lbldolarsatis.Text = "0";
            // 
            // lbleuroalis
            // 
            this.lbleuroalis.AutoSize = true;
            this.lbleuroalis.BackColor = System.Drawing.Color.Transparent;
            this.lbleuroalis.Location = new System.Drawing.Point(171, 158);
            this.lbleuroalis.Name = "lbleuroalis";
            this.lbleuroalis.Size = new System.Drawing.Size(24, 25);
            this.lbleuroalis.TabIndex = 11;
            this.lbleuroalis.Text = "0";
            // 
            // lbleurosatis
            // 
            this.lbleurosatis.AutoSize = true;
            this.lbleurosatis.BackColor = System.Drawing.Color.Transparent;
            this.lbleurosatis.Location = new System.Drawing.Point(171, 201);
            this.lbleurosatis.Name = "lbleurosatis";
            this.lbleurosatis.Size = new System.Drawing.Size(24, 25);
            this.lbleurosatis.TabIndex = 12;
            this.lbleurosatis.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(796, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kasa Dolar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(805, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kasa Euro:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(365, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(349, 207);
            this.dataGridView1.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(969, 391);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 25);
            this.label15.TabIndex = 20;
            this.label15.Text = "label15";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(969, 445);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 25);
            this.label16.TabIndex = 21;
            this.label16.Text = "label16";
            this.label16.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 481);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbleurosatis);
            this.Controls.Add(this.lbleuroalis);
            this.Controls.Add(this.lbldolarsatis);
            this.Controls.Add(this.lbldolaralis);
            this.Controls.Add(this.btneurosat);
            this.Controls.Add(this.btneuroal);
            this.Controls.Add(this.btndolarsat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btndolaral);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Döviz Birosu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndolaral;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtkalan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtkur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndolarsat;
        private System.Windows.Forms.Button btneuroal;
        private System.Windows.Forms.Button btneurosat;
        private System.Windows.Forms.Label lbldolaralis;
        private System.Windows.Forms.Label lbldolarsatis;
        private System.Windows.Forms.Label lbleuroalis;
        private System.Windows.Forms.Label lbleurosatis;
        private System.Windows.Forms.Button btnsatisyap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

