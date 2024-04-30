namespace IMLab83
{
    public partial class MainForm : Form
    {
        int[] _statistics = new int[6];
        double[] _probability = new double[6];
        int N = 0;
        Random _rnd = new Random();
        public MainForm()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                _statistics[i] = 0;
            }
        }
        void AssignProbabilities()
        {
            _probability[0] = Double.Parse(ProbBox1.Text);
            _probability[1] = Double.Parse(ProbBox2.Text);
            _probability[2] = Double.Parse(ProbBox3.Text);
            _probability[3] = Double.Parse(ProbBox4.Text);
            _probability[4] = Double.Parse(ProbBox5.Text);
        }
        void Calculate6Probability()
        {
            _probability[5] = 1 - _probability[0] - _probability[1] - _probability[2] - _probability[3] - _probability[4];
            ProbBox6.Text = _probability[5].ToString();
        }
        int GenerateEvent()
        {
            double a = _rnd.NextDouble();
            int k = 0;
            while (a > 0)
            {
                a -= _probability[k];
                k++;
            }
            return k - 1;
        }
        void DrawChart()
        {
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < 6; i++)
            {
                chart1.Series[0].Points.AddXY(i, _statistics[i]);
            }
        }
        Label CreateLabel()
        {
            Label label = new Label();
            label.TextAlign = ContentAlignment.MiddleCenter;
            
            label.Dock = DockStyle.Fill;
            label.Width = 150;
            return label;
        }
        void FilLTable()
        {
            for (int i = 1; i <= 6; i++)
            {
                tableLayoutPanel1.Controls.Add(CreateLabel(), i, 0);
                tableLayoutPanel1.GetControlFromPosition(i, 0).Text = i.ToString();
            }
            for (int i = 1; i < 5; i++)
            {
                tableLayoutPanel1.Controls.Add(CreateLabel(), 0, i);
                tableLayoutPanel1.GetControlFromPosition(0, i).Text = Math.Pow(10,i).ToString();
            }
        }
        void GenerateSelection(int amount)
        {
            AssignProbabilities();
            Calculate6Probability();
            for (int i = 0; i < amount; i++)
            {
                _statistics[GenerateEvent()]++;
            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (_probability[0] + _probability[1] + _probability[2] + _probability[3] + _probability[4] < 1)
            {
                AssignProbabilities();
                Calculate6Probability();
                N = Int32.Parse(NumberOfTrialsBox.Text);
                for (int i = 0; i < N; i++)
                {
                    _statistics[GenerateEvent()]++;
                }
                DrawChart();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            _statistics[GenerateEvent()]++;
            N--;
            if (N == 0)
            {
                timer1.Stop();
                DrawChart();
            }
        }
        void WriteStatistics(int row)
        {
            for (int i = 1; i <= 6; i++)
            {
                tableLayoutPanel1.Controls.Add(CreateLabel(), i, row);
                tableLayoutPanel1.GetControlFromPosition(i, row).Text = _statistics[i-1].ToString();
            }
        }
        private void FillTableButton_Click(object sender, EventArgs e)
        {
            FilLTable();
            for (int i = 1; i < 5; i++)
            {
                GenerateSelection((int)Math.Pow(10, i));
                WriteStatistics(i);
            }
        }
    }
}
