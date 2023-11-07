using System.Globalization;

namespace ISIgr1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string napis = textBox1.Text;
            int[] arr = covert(napis);
            int[] arr2 = selectionSort(arr);
            string wynik = toString(arr2);
            label1.Text = wynik;
            
            
        }

        public static int[] selectionSort(int[] arr)
        {
            int d = arr.Length;
            int min, help;
            for(int i=0;i<d;i++)
            {
                min = i;
                for(int j=i+1;j<d;j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                help = arr[i];
                arr[i] = arr[min];
                arr[min] = help;


            }
            return arr;
        }
        public static void sort(int[] arr)
        {
            int help;
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
            } while (kolejnosc(arr) == 1);

        }

        public static int kolejnosc(int[] arr)
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



        public static string toString(int[] arr)
        {
            string wynik = "";
            for (int i = 0; i < arr.Length; i++)
            {
                wynik += arr[i] + " ";
            }
            return wynik;
        }

        public static int[] covert(string text)
        {
            var liczbyS = text.Trim().Split(' ');
            int[] liczby = new int[liczbyS.Length];
            for (int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = int.Parse(liczbyS[i]);
            }
            return liczby;
        }
    }
}