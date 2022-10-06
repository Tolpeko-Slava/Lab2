namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.CulculButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MathSleepForm = new System.Windows.Forms.TextBox();
            this.SKOForm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LamdoExp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.LamdoGamma = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ATreyForm = new System.Windows.Forms.TextBox();
            this.BTreyForm = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.math = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.sko = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.aSimForm = new System.Windows.Forms.TextBox();
            this.bSimForm = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea3.Name = "ChartArea";
            this.Chart.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            this.Chart.Legends.Add(legend3);
            this.Chart.Location = new System.Drawing.Point(0, 0);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(935, 372);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "f distribution",
            "Gays. distribution",
            "exp. distribution",
            "Gamma distribution",
            "Treyt. distribution",
            "Simpson distribution"});
            this.comboBox.Location = new System.Drawing.Point(15, 509);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(185, 24);
            this.comboBox.TabIndex = 3;
            // 
            // CulculButt
            // 
            this.CulculButt.Location = new System.Drawing.Point(226, 509);
            this.CulculButt.Name = "CulculButt";
            this.CulculButt.Size = new System.Drawing.Size(82, 23);
            this.CulculButt.TabIndex = 4;
            this.CulculButt.Text = "Расчетать";
            this.CulculButt.UseVisualStyleBackColor = true;
            this.CulculButt.Click += new System.EventHandler(this.CulculButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "f distribution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "b";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(60, 406);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 22);
            this.a.TabIndex = 9;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(60, 440);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 22);
            this.b.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gays. distribution";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "m";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "б";
            // 
            // MathSleepForm
            // 
            this.MathSleepForm.Location = new System.Drawing.Point(208, 409);
            this.MathSleepForm.Name = "MathSleepForm";
            this.MathSleepForm.Size = new System.Drawing.Size(100, 22);
            this.MathSleepForm.TabIndex = 16;
            // 
            // SKOForm
            // 
            this.SKOForm.Location = new System.Drawing.Point(208, 440);
            this.SKOForm.Name = "SKOForm";
            this.SKOForm.Size = new System.Drawing.Size(100, 22);
            this.SKOForm.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "exp. distribution";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "л";
            // 
            // LamdoExp
            // 
            this.LamdoExp.Location = new System.Drawing.Point(358, 424);
            this.LamdoExp.Name = "LamdoExp";
            this.LamdoExp.Size = new System.Drawing.Size(100, 22);
            this.LamdoExp.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(474, 375);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Gamma distribution";
            // 
            // LamdoGamma
            // 
            this.LamdoGamma.Location = new System.Drawing.Point(494, 409);
            this.LamdoGamma.Name = "LamdoGamma";
            this.LamdoGamma.Size = new System.Drawing.Size(100, 22);
            this.LamdoGamma.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(472, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "л";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(622, 375);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Treyt. distribution";
            // 
            // ATreyForm
            // 
            this.ATreyForm.Location = new System.Drawing.Point(630, 409);
            this.ATreyForm.Name = "ATreyForm";
            this.ATreyForm.Size = new System.Drawing.Size(100, 22);
            this.ATreyForm.TabIndex = 30;
            // 
            // BTreyForm
            // 
            this.BTreyForm.Location = new System.Drawing.Point(630, 437);
            this.BTreyForm.Name = "BTreyForm";
            this.BTreyForm.Size = new System.Drawing.Size(100, 22);
            this.BTreyForm.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(609, 409);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 16);
            this.label16.TabIndex = 34;
            this.label16.Text = "a";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(609, 440);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 16);
            this.label17.TabIndex = 35;
            this.label17.Text = "b";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(747, 375);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 16);
            this.label20.TabIndex = 38;
            this.label20.Text = "Simpson distribution";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(345, 518);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 16);
            this.label21.TabIndex = 39;
            this.label21.Text = "math";
            // 
            // math
            // 
            this.math.AutoSize = true;
            this.math.Location = new System.Drawing.Point(387, 518);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(0, 16);
            this.math.TabIndex = 40;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(527, 518);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 16);
            this.label23.TabIndex = 41;
            this.label23.Text = "D";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(550, 518);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(0, 16);
            this.d.TabIndex = 42;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(708, 517);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(34, 16);
            this.label25.TabIndex = 43;
            this.label25.Text = "SKO";
            // 
            // sko
            // 
            this.sko.AutoSize = true;
            this.sko.Location = new System.Drawing.Point(748, 517);
            this.sko.Name = "sko";
            this.sko.Size = new System.Drawing.Size(0, 16);
            this.sko.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "n";
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(494, 440);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(100, 22);
            this.N.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(622, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Max";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 472);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "n = 6";
            // 
            // aSimForm
            // 
            this.aSimForm.Location = new System.Drawing.Point(763, 409);
            this.aSimForm.Name = "aSimForm";
            this.aSimForm.Size = new System.Drawing.Size(100, 22);
            this.aSimForm.TabIndex = 49;
            // 
            // bSimForm
            // 
            this.bSimForm.Location = new System.Drawing.Point(763, 440);
            this.bSimForm.Name = "bSimForm";
            this.bSimForm.Size = new System.Drawing.Size(100, 22);
            this.bSimForm.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(742, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 16);
            this.label14.TabIndex = 51;
            this.label14.Text = "a";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(742, 443);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 16);
            this.label18.TabIndex = 52;
            this.label18.Text = "b";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bSimForm);
            this.Controls.Add(this.aSimForm);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.N);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sko);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.d);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.math);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.BTreyForm);
            this.Controls.Add(this.ATreyForm);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LamdoGamma);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LamdoExp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SKOForm);
            this.Controls.Add(this.MathSleepForm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CulculButt);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.Chart);
            this.Name = "Form1";
            this.Text = "Lab2";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button CulculButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MathSleepForm;
        private System.Windows.Forms.TextBox SKOForm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LamdoExp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox LamdoGamma;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ATreyForm;
        private System.Windows.Forms.TextBox BTreyForm;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label math;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label sko;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox aSimForm;
        private System.Windows.Forms.TextBox bSimForm;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
    }
}

