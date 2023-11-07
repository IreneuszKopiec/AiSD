using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int[] arr = covert(textBox1.Text);
            int[] arr2 = insertSort(arr);
            string wynik = toString(arr2);
            label1.Text = wynik;
        }

        static int[] insertSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
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
