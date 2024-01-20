namespace 素数フォーム
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         /* 素数判定するメソッド.
 判定3番目の(Input_date + 2) % 6 == 1の"＋２"は(Input_date % 6 == 1　と同じ式にするためにある。*/
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
 // フォームからデータを受け取る.
 //strからintに変換.
        private void Primenum_check_Click(object sender, EventArgs e)
        {
            Int32.TryParse(Input_date.Text, out int Anwer);
            PrimeNum_function(Anwer);
        }
    }
}

