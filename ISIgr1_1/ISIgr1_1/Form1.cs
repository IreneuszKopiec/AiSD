namespace ISIgr1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            int liczba = (int)numericUpDown1.Value;
            int wynik = fib(liczba);
            MessageBox.Show(wynik.ToString());
        }

        int fib(int n)
        {
            if(n==0)
            {
                return 0;
            }
            if(n==1)
            {
                return 1;
            }
            return fib(n - 1) + fib(n - 2);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}