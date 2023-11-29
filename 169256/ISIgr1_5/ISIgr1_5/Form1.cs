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
            var d = new DrzewoBinarne(5);
            d.Add(4);
            d.Add(8);
            d.Add(3);
            d.Add(7);
            d.Add(9);
            d.Add(6);





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

            for (int i = 0; i < w.sasiedzi.Count; i++)
            {
                A(w.sasiedzi[i]);
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
        public List<Wezel2> sasiedzi = new List<Wezel2>();

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

            if(!this.sasiedzi.Contains(s))
            {
                this.sasiedzi.Add(s);
               
            }
            if(!s.sasiedzi.Contains(this))
            {
                s.sasiedzi.Add(this);
                
            }

            
        }

        public override string ToString()
        {
            return this.wartosc.ToString();
        }
    }

    public class Wêze³3
    {
        public int wartoœæ;
        public Wêze³3 prawe;
        public Wêze³3 lewe;
        public Wêze³3 rodzic;

        public Wêze³3(int liczba)
        {
            this.wartoœæ = liczba;
        }

        internal void Add(int liczba)
        {
            var dziecko = new Wêze³3(liczba);
            dziecko.rodzic = this;
            if(liczba<this.wartoœæ)
            {
                this.lewe = dziecko;
            }
            else
            {
                this.prawe = dziecko;
            }
        }
    }


    public class DrzewoBinarne
    {
        public Wêze³3 korzeñ;
        public int liczbaWêz³ów;

        public DrzewoBinarne(int liczba)
        {
            this.korzeñ = new Wêze³3(liczba);
            this.liczbaWêz³ów = 1;
        }

        public void Add(int liczba)
        {
            Wêze³3 rodzic = this.ZnajdzRodzica(liczba);
            rodzic.Add(liczba);

            
        }

        private Wêze³3 ZnajdzRodzica(int liczba)
        {
            var w = this.korzeñ;
            while(w != null)
            {
                if(liczba<w.wartoœæ)
                {
                    if(w.lewe==null)
                    {
                        return w;
                    }
                    else
                    {
                        w = w.lewe;
                    }
                }
                else
                {
                    
                     if (w.prawe == null)
                     {
                        return w;
                     }
                     else
                     {
                         w = w.prawe;
                     }
                    
                }
            }
            return null;
        }

        


    }

}