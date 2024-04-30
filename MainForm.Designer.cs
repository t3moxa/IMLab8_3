namespace IMLab83
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            ProbBox1 = new TextBox();
            ProbLabel1 = new Label();
            ProbLabel2 = new Label();
            ProbBox2 = new TextBox();
            ProbLabel3 = new Label();
            ProbBox3 = new TextBox();
            ProbLabel4 = new Label();
            ProbBox4 = new TextBox();
            ProbLabel5 = new Label();
            ProbBox5 = new TextBox();
            ProbLabel6 = new Label();
            ProbBox6 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            NumberOfTrialsLabel = new Label();
            NumberOfTrialsBox = new TextBox();
            StartButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            FillTableButton = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // ProbBox1
            // 
            ProbBox1.Location = new Point(114, 29);
            ProbBox1.Name = "ProbBox1";
            ProbBox1.Size = new Size(100, 23);
            ProbBox1.TabIndex = 0;
            // 
            // ProbLabel1
            // 
            ProbLabel1.AutoSize = true;
            ProbLabel1.Location = new Point(22, 32);
            ProbLabel1.Name = "ProbLabel1";
            ProbLabel1.Size = new Size(85, 15);
            ProbLabel1.TabIndex = 1;
            ProbLabel1.Text = "Вероятность 1";
            // 
            // ProbLabel2
            // 
            ProbLabel2.AutoSize = true;
            ProbLabel2.Location = new Point(22, 61);
            ProbLabel2.Name = "ProbLabel2";
            ProbLabel2.Size = new Size(85, 15);
            ProbLabel2.TabIndex = 3;
            ProbLabel2.Text = "Вероятность 2";
            // 
            // ProbBox2
            // 
            ProbBox2.Location = new Point(114, 58);
            ProbBox2.Name = "ProbBox2";
            ProbBox2.Size = new Size(100, 23);
            ProbBox2.TabIndex = 2;
            // 
            // ProbLabel3
            // 
            ProbLabel3.AutoSize = true;
            ProbLabel3.Location = new Point(22, 90);
            ProbLabel3.Name = "ProbLabel3";
            ProbLabel3.Size = new Size(85, 15);
            ProbLabel3.TabIndex = 5;
            ProbLabel3.Text = "Вероятность 3";
            // 
            // ProbBox3
            // 
            ProbBox3.Location = new Point(114, 87);
            ProbBox3.Name = "ProbBox3";
            ProbBox3.Size = new Size(100, 23);
            ProbBox3.TabIndex = 4;
            // 
            // ProbLabel4
            // 
            ProbLabel4.AutoSize = true;
            ProbLabel4.Location = new Point(22, 119);
            ProbLabel4.Name = "ProbLabel4";
            ProbLabel4.Size = new Size(85, 15);
            ProbLabel4.TabIndex = 7;
            ProbLabel4.Text = "Вероятность 4";
            // 
            // ProbBox4
            // 
            ProbBox4.Location = new Point(114, 116);
            ProbBox4.Name = "ProbBox4";
            ProbBox4.Size = new Size(100, 23);
            ProbBox4.TabIndex = 6;
            // 
            // ProbLabel5
            // 
            ProbLabel5.AutoSize = true;
            ProbLabel5.Location = new Point(22, 148);
            ProbLabel5.Name = "ProbLabel5";
            ProbLabel5.Size = new Size(85, 15);
            ProbLabel5.TabIndex = 9;
            ProbLabel5.Text = "Вероятность 5";
            // 
            // ProbBox5
            // 
            ProbBox5.Location = new Point(114, 145);
            ProbBox5.Name = "ProbBox5";
            ProbBox5.Size = new Size(100, 23);
            ProbBox5.TabIndex = 8;
            // 
            // ProbLabel6
            // 
            ProbLabel6.AutoSize = true;
            ProbLabel6.Location = new Point(22, 177);
            ProbLabel6.Name = "ProbLabel6";
            ProbLabel6.Size = new Size(85, 15);
            ProbLabel6.TabIndex = 11;
            ProbLabel6.Text = "Вероятность 6";
            // 
            // ProbBox6
            // 
            ProbBox6.AutoSize = true;
            ProbBox6.Location = new Point(114, 177);
            ProbBox6.Name = "ProbBox6";
            ProbBox6.Size = new Size(178, 15);
            ProbBox6.TabIndex = 12;
            ProbBox6.Text = "Высчитывается автоматически";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(479, 12);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Частоты";
            chart1.Series.Add(series1);
            chart1.Size = new Size(650, 464);
            chart1.TabIndex = 13;
            chart1.Text = "chart1";
            // 
            // NumberOfTrialsLabel
            // 
            NumberOfTrialsLabel.AutoSize = true;
            NumberOfTrialsLabel.Location = new Point(22, 223);
            NumberOfTrialsLabel.Name = "NumberOfTrialsLabel";
            NumberOfTrialsLabel.Size = new Size(123, 15);
            NumberOfTrialsLabel.TabIndex = 15;
            NumberOfTrialsLabel.Text = "Количество попыток";
            // 
            // NumberOfTrialsBox
            // 
            NumberOfTrialsBox.Location = new Point(151, 220);
            NumberOfTrialsBox.Name = "NumberOfTrialsBox";
            NumberOfTrialsBox.Size = new Size(100, 23);
            NumberOfTrialsBox.TabIndex = 14;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(114, 263);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(75, 23);
            StartButton.TabIndex = 16;
            StartButton.Text = "Начать";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(12, 333);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(412, 143);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // FillTableButton
            // 
            FillTableButton.Location = new Point(151, 482);
            FillTableButton.Name = "FillTableButton";
            FillTableButton.Size = new Size(150, 23);
            FillTableButton.TabIndex = 18;
            FillTableButton.Text = "Заполнить таблицу";
            FillTableButton.UseVisualStyleBackColor = true;
            FillTableButton.Click += FillTableButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 561);
            Controls.Add(FillTableButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(StartButton);
            Controls.Add(NumberOfTrialsLabel);
            Controls.Add(NumberOfTrialsBox);
            Controls.Add(chart1);
            Controls.Add(ProbBox6);
            Controls.Add(ProbLabel6);
            Controls.Add(ProbLabel5);
            Controls.Add(ProbBox5);
            Controls.Add(ProbLabel4);
            Controls.Add(ProbBox4);
            Controls.Add(ProbLabel3);
            Controls.Add(ProbBox3);
            Controls.Add(ProbLabel2);
            Controls.Add(ProbBox2);
            Controls.Add(ProbLabel1);
            Controls.Add(ProbBox1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProbBox1;
        private Label ProbLabel1;
        private Label ProbLabel2;
        private TextBox ProbBox2;
        private Label ProbLabel3;
        private TextBox ProbBox3;
        private Label ProbLabel4;
        private TextBox ProbBox4;
        private Label ProbLabel5;
        private TextBox ProbBox5;
        private Label ProbLabel6;
        private Label ProbBox6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label NumberOfTrialsLabel;
        private TextBox NumberOfTrialsBox;
        private Button StartButton;
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button FillTableButton;
    }
}
