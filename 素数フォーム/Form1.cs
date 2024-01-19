namespace 素数フォーム
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void PrimeNum_function(int Input_date)
        {
            if (Input_date == 2 || Input_date == 3)
            {
                Output_data.Text = (Input_date + "は素数です");
            }
            else if (Input_date % 6 == 1)
            {
                Output_data.Text = (Input_date + "は素数です");
            }
            else if ((Input_date + 2) % 6 == 1)
            {
                Output_data.Text = (Input_date + "は素数です");
            }
            else if (Input_date == 57)
            {
                Output_data.Text = (Input_date + "はグロタンディーク素数です");
            }
            else
            {
                Output_data.Text = (Input_date + "は素数ではないです。");
            }
        }

        private void Primenum_check_Click(object sender, EventArgs e)
        {
            Int32.TryParse(Input_date.Text, out int Anwer);
            PrimeNum_function(Anwer);
        }
    }
}

