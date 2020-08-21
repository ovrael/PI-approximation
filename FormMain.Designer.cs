namespace LiczeniePI_WindowsForms
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Info = new System.Windows.Forms.Label();
            this.rbMonteCarlo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbProstokaty = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.lblInfoPunkty = new System.Windows.Forms.Label();
            this.tbIloscPunktow = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBladBezwzgledny = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBlad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWartoscInfo = new System.Windows.Forms.Label();
            this.tbMathPI = new System.Windows.Forms.TextBox();
            this.tbWartoscPI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cWykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblWspolrzedneInfo = new System.Windows.Forms.Label();
            this.dgvPunkty = new System.Windows.Forms.DataGridView();
            this.lblInfoDod = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pbCalculation = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cWykres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPunkty)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.AccessibleName = "lblInfo";
            this.Info.AutoSize = true;
            this.Info.CausesValidation = false;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Info.Location = new System.Drawing.Point(12, 9);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(204, 37);
            this.Info.TabIndex = 0;
            this.Info.Text = "Obliczanie PI";
            // 
            // rbMonteCarlo
            // 
            this.rbMonteCarlo.AutoSize = true;
            this.rbMonteCarlo.Checked = true;
            this.rbMonteCarlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbMonteCarlo.Location = new System.Drawing.Point(132, 10);
            this.rbMonteCarlo.Name = "rbMonteCarlo";
            this.rbMonteCarlo.Size = new System.Drawing.Size(153, 21);
            this.rbMonteCarlo.TabIndex = 3;
            this.rbMonteCarlo.TabStop = true;
            this.rbMonteCarlo.Text = "Metoda Monte Carlo";
            this.rbMonteCarlo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AccessibleName = "lblInfo";
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Metoda liczenia:";
            // 
            // rbProstokaty
            // 
            this.rbProstokaty.AutoSize = true;
            this.rbProstokaty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbProstokaty.Location = new System.Drawing.Point(311, 10);
            this.rbProstokaty.Name = "rbProstokaty";
            this.rbProstokaty.Size = new System.Drawing.Size(153, 21);
            this.rbProstokaty.TabIndex = 5;
            this.rbProstokaty.Text = "Metoda prostokątów";
            this.rbProstokaty.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbCalculation);
            this.panel1.Controls.Add(this.btnOblicz);
            this.panel1.Controls.Add(this.rbMonteCarlo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbProstokaty);
            this.panel1.Controls.Add(this.lblInfoPunkty);
            this.panel1.Controls.Add(this.tbIloscPunktow);
            this.panel1.Location = new System.Drawing.Point(19, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 132);
            this.panel1.TabIndex = 6;
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(7, 80);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(137, 30);
            this.btnOblicz.TabIndex = 7;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // lblInfoPunkty
            // 
            this.lblInfoPunkty.AutoSize = true;
            this.lblInfoPunkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfoPunkty.Location = new System.Drawing.Point(3, 48);
            this.lblInfoPunkty.Name = "lblInfoPunkty";
            this.lblInfoPunkty.Size = new System.Drawing.Size(167, 20);
            this.lblInfoPunkty.TabIndex = 15;
            this.lblInfoPunkty.Text = "Podaj liczbę punktów*:";
            // 
            // tbIloscPunktow
            // 
            this.tbIloscPunktow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIloscPunktow.Location = new System.Drawing.Point(174, 45);
            this.tbIloscPunktow.Name = "tbIloscPunktow";
            this.tbIloscPunktow.Size = new System.Drawing.Size(204, 26);
            this.tbIloscPunktow.TabIndex = 16;
            this.tbIloscPunktow.Text = "100";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBladBezwzgledny);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbBlad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblWartoscInfo);
            this.groupBox1.Controls.Add(this.tbMathPI);
            this.groupBox1.Controls.Add(this.tbWartoscPI);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(16, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 340);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyniki";
            // 
            // tbBladBezwzgledny
            // 
            this.tbBladBezwzgledny.Enabled = false;
            this.tbBladBezwzgledny.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbBladBezwzgledny.Location = new System.Drawing.Point(22, 286);
            this.tbBladBezwzgledny.Name = "tbBladBezwzgledny";
            this.tbBladBezwzgledny.ReadOnly = true;
            this.tbBladBezwzgledny.Size = new System.Drawing.Size(205, 30);
            this.tbBladBezwzgledny.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(18, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Błąd bezwzględny";
            // 
            // tbBlad
            // 
            this.tbBlad.Enabled = false;
            this.tbBlad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbBlad.Location = new System.Drawing.Point(22, 206);
            this.tbBlad.Name = "tbBlad";
            this.tbBlad.ReadOnly = true;
            this.tbBlad.Size = new System.Drawing.Size(205, 30);
            this.tbBlad.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(18, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Błąd obliczeń";
            // 
            // lblWartoscInfo
            // 
            this.lblWartoscInfo.AutoSize = true;
            this.lblWartoscInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWartoscInfo.Location = new System.Drawing.Point(18, 30);
            this.lblWartoscInfo.Name = "lblWartoscInfo";
            this.lblWartoscInfo.Size = new System.Drawing.Size(209, 20);
            this.lblWartoscInfo.TabIndex = 5;
            this.lblWartoscInfo.Text = "Przybliżona wartość liczby PI";
            // 
            // tbMathPI
            // 
            this.tbMathPI.Enabled = false;
            this.tbMathPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMathPI.Location = new System.Drawing.Point(22, 131);
            this.tbMathPI.Name = "tbMathPI";
            this.tbMathPI.ReadOnly = true;
            this.tbMathPI.Size = new System.Drawing.Size(205, 30);
            this.tbMathPI.TabIndex = 12;
            // 
            // tbWartoscPI
            // 
            this.tbWartoscPI.Enabled = false;
            this.tbWartoscPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbWartoscPI.Location = new System.Drawing.Point(22, 53);
            this.tbWartoscPI.Name = "tbWartoscPI";
            this.tbWartoscPI.ReadOnly = true;
            this.tbWartoscPI.Size = new System.Drawing.Size(205, 30);
            this.tbWartoscPI.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(18, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wartość Math.PI";
            // 
            // cWykres
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.Interval = 0.1D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Interval = 1D;
            chartArea1.AxisX.MajorTickMark.Size = 2F;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisX.Maximum = 1D;
            chartArea1.AxisX.MaximumAutoSize = 5F;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.Interval = 0.1D;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Interval = 1D;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Interval = 0.1D;
            chartArea1.AxisY.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisY.MajorTickMark.Interval = 1D;
            chartArea1.AxisY.MajorTickMark.Size = 2F;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.MaximumAutoSize = 5F;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "Y";
            chartArea1.Name = "ChartArea1";
            this.cWykres.ChartAreas.Add(chartArea1);
            this.cWykres.Location = new System.Drawing.Point(14, 42);
            this.cWykres.Name = "cWykres";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.CustomProperties = "EmptyPointValue=Zero";
            series1.IsVisibleInLegend = false;
            series1.MarkerSize = 1;
            series1.Name = "Series1";
            dataPoint1.IsEmpty = true;
            dataPoint1.IsVisibleInLegend = false;
            dataPoint1.Label = "";
            dataPoint1.ToolTip = "";
            series1.Points.Add(dataPoint1);
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No;
            series1.SmartLabelStyle.Enabled = false;
            series1.XValueMember = "X";
            series1.YValueMembers = "Y";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.MarkerSize = 2;
            series2.Name = "Series2";
            this.cWykres.Series.Add(series1);
            this.cWykres.Series.Add(series2);
            this.cWykres.Size = new System.Drawing.Size(350, 350);
            this.cWykres.TabIndex = 21;
            this.cWykres.Text = "Przedstawienie graficzne";
            // 
            // lblWspolrzedneInfo
            // 
            this.lblWspolrzedneInfo.AutoSize = true;
            this.lblWspolrzedneInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWspolrzedneInfo.Location = new System.Drawing.Point(7, 15);
            this.lblWspolrzedneInfo.Name = "lblWspolrzedneInfo";
            this.lblWspolrzedneInfo.Size = new System.Drawing.Size(209, 24);
            this.lblWspolrzedneInfo.TabIndex = 20;
            this.lblWspolrzedneInfo.Text = "Współrzędne punktów*";
            // 
            // dgvPunkty
            // 
            this.dgvPunkty.AllowUserToAddRows = false;
            this.dgvPunkty.AllowUserToDeleteRows = false;
            this.dgvPunkty.AllowUserToResizeColumns = false;
            this.dgvPunkty.AllowUserToResizeRows = false;
            this.dgvPunkty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPunkty.Location = new System.Drawing.Point(7, 42);
            this.dgvPunkty.Name = "dgvPunkty";
            this.dgvPunkty.ReadOnly = true;
            this.dgvPunkty.RowHeadersVisible = false;
            this.dgvPunkty.RowTemplate.ReadOnly = true;
            this.dgvPunkty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPunkty.Size = new System.Drawing.Size(200, 350);
            this.dgvPunkty.TabIndex = 19;
            // 
            // lblInfoDod
            // 
            this.lblInfoDod.AutoSize = true;
            this.lblInfoDod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfoDod.Location = new System.Drawing.Point(14, 803);
            this.lblInfoDod.Name = "lblInfoDod";
            this.lblInfoDod.Size = new System.Drawing.Size(237, 20);
            this.lblInfoDod.TabIndex = 18;
            this.lblInfoDod.Text = "*Max 100 by zostały wyświetlone";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPunkty);
            this.panel2.Controls.Add(this.lblWspolrzedneInfo);
            this.panel2.Location = new System.Drawing.Point(19, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 411);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cWykres);
            this.panel3.Location = new System.Drawing.Point(256, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 411);
            this.panel3.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(10, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Przedstawienie graficzne";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(641, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 411);
            this.panel4.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(15, 632);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "*Max 100 by zostały wyświetlone";
            // 
            // pbCalculation
            // 
            this.pbCalculation.Location = new System.Drawing.Point(174, 80);
            this.pbCalculation.Name = "pbCalculation";
            this.pbCalculation.Size = new System.Drawing.Size(204, 23);
            this.pbCalculation.TabIndex = 17;
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(944, 661);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblInfoDod);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Info);
            this.Name = "FormMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cWykres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPunkty)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.RadioButton rbMonteCarlo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbProstokaty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Label lblInfoPunkty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBladBezwzgledny;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBlad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWartoscInfo;
        private System.Windows.Forms.TextBox tbMathPI;
        private System.Windows.Forms.TextBox tbWartoscPI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart cWykres;
        private System.Windows.Forms.Label lblWspolrzedneInfo;
        private System.Windows.Forms.DataGridView dgvPunkty;
        private System.Windows.Forms.Label lblInfoDod;
        private System.Windows.Forms.TextBox tbIloscPunktow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar pbCalculation;
    }
}

