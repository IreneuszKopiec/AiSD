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
            long wynik = fib2(liczba);
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

        long fib2(int n)
        {

            if (n == 0 || n == 1)
            {
                return n;

            }

            long[] myarray = new long[n];
            myarray[0] = 0;
            myarray[1] = 1;
            int i;
            for(i=2; i<=myarray.Length-1; i++)
            {
                myarray[i] = myarray[i - 1] + myarray[i - 2];
            }
            return myarray[n - 1] + myarray[n - 2];
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}