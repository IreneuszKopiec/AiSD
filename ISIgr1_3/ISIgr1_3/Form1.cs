using System.Windows.Forms;

namespace ISIgr1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            

        }
        public static void sort(long[] arr)
        {
            long help;
            do
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        help = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = help;
                    }
                }
            } while (kolejnosc(arr)==1);

        }

        public static int kolejnosc(long[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    return 1;
                }
            }
            return 0;
        }

       

        public static string toString(long[] arr)
        {
            string wynik = "";
            for(int i=0;i<arr.Length;i++)
            {
                wynik += arr[i] + " ";
            }
            return wynik;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            long[] arr = new long[5];
            arr[0] = 7;
            arr[1] = 2;
            arr[2] = 5;
            arr[3] = 4;
            arr[4] = 1;

            sort(arr);
            string wynikKoncowy = toString(arr);
            label1.Text = wynikKoncowy;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}