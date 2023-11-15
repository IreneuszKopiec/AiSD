using System.Security.Cryptography.X509Certificates;

namespace ISIgr1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            var w1 = new Wezel(5);
            var w2 = new Wezel(3);
            var w3 = new Wezel(1);
            var w4 = new Wezel(2);
            var w5 = new Wezel(6);
            var w6 = new Wezel(4);
            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w1.dzieci.Add(w4);
            w2.dzieci.Add(w5);
            w2.dzieci.Add(w6);

            A(w1);
            */
            var w1 = new Wezel2(1);
            var w2 = new Wezel2(2);
            var w3 = new Wezel2(3);
            var w4 = new Wezel2(4);
            var w5 = new Wezel2(5);
            var w6 = new Wezel2(6);
            w1.dzieci.Add(w2);
            w2.dzieci.Add(w5);
            w2.dzieci.Add(w4);
            w4.dzieci.Add(w6);
            w6.dzieci.Add(w3);
            w3.dzieci.Add(w1);

            A(w1);





        }
        
        void A(Wezel w)
        {
            MessageBox.Show(w.wartosc.ToString());
            //A(w);

            for(int i=0;i<w.dzieci.Count;i++)
            {
                A(w.dzieci[i]);
            }
        }
        void A(Wezel2 w)
        {
            MessageBox.Show(w.wartosc.ToString());
            //A(w);

            for (int i = 0; i < w.dzieci.Count; i++)
            {
                A(w.dzieci[i]);
            }
        }
    }

    class Wezel
    {
        public int wartosc;
        public List<Wezel> dzieci = new List<Wezel>();

        public Wezel(int liczba)
        {
            this.wartosc = liczba;
        }
    }

    class Wezel2
    {
        public int wartosc;
        public List<Wezel2> dzieci = new List<Wezel2>();

        public Wezel2(int liczba)
        {
            this.wartosc = liczba;
            
        }

        public void Add(Wezel2 s)
        {
            
            if(this==s)
            {
                return;
            }

            if(!this.dzieci.Contains(s))
            {
                this.dzieci.Add(s);
               
            }
            if(!s.dzieci.Contains(this))
            {
                s.dzieci.Add(this);
                
            }
        }
    }

}