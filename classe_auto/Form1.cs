using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classe_auto
{
    public partial class Form1 : Form
    {
        auto Car;
        public Form1()
        {
            InitializeComponent();

            Car = new auto();

            SetVelocityScreen();
            SetGearScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void freno_button_Click(object sender, EventArgs e)
        {
            Car.Decelera(5);
            SetVelocityScreen();
        }


        private void acceleratore_button_Click(object sender, EventArgs e)
        {
            Car.Accelera(5);
            SetVelocityScreen();
        }


        private void SetVelocityScreen()
        {
            listView1.Items.Clear();
            if (Car.Velocita == 0)
            {
                listView1.Items.Add("spenta");
            }
            else
            {
                listView1.Items.Add(Car.Velocita.ToString());
            }
        }


        private void SetGearScreen()
        {
            listView2.Items.Clear();
            listView2.Items.Add(Car.Marcia.ToString());

            //MessageBox.Show(Car.Marcia.ToString());
        }



        private void marcia_add_button_Click(object sender, EventArgs e)
        {
            Car.ModMarcia(true);
            SetGearScreen();
        }

        private void marcia_sub_button_Click(object sender, EventArgs e)
        {
            Car.ModMarcia(false);
            SetGearScreen();
        }
    }
    class auto
    {

        private int _marcia;
        public int Marcia
        {
            get { return _marcia; }
            set
            {

                if (value >= -1 && value <= 5)
                {
                    _marcia = value;
                }

            }
        }
        public int Velocita { get; set; }

        public auto()
        {
            Marcia = 0;
            Velocita = 0;
        }

        public auto(int marcia, int velocita)
        {
            Marcia = marcia;
            Velocita = velocita;
        }


        public virtual void Accelera(int val)
        {
            Velocita += val;

        }

        public virtual int Decelera(int val)
        {
            if (Velocita >= val)
            {
                Velocita -= val;
                return 0;
            }

            //la macchina è gia ferma
            return 2;

        }


        public void ModMarcia(bool add = true)
        {
            if (add)
            {
                if (Marcia < 5)
                    Marcia++;
            }
            {
                if (Marcia > -1)
                    Marcia--;
            }
        }

        public bool Accesa()
        {
            if (Velocita == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }

    class autoAutoma : auto
    {
        public override void Accelera(int val)
        {
            Velocita += val;

            AutoModMarcia();
            
        }

        public void AutoModMarcia()
        {
            if (Velocita == 0)
            {
                Marcia = 0;
                return;
            }

            if (Velocita > 0 && Velocita <= 25)
            {
                Marcia = -1;
                return;
            }

            if (Velocita > 25 && Velocita <= 50)
            {
                Marcia = 1;
                return;
            }

            if (Velocita > 50 && Velocita <= 75)
            {
                Marcia = 2;
                return;
            }

            if (Velocita > 75 && Velocita <= 100)
            {
                Marcia = 3;
                return;
            }

            if (Velocita > 100 && Velocita <= 125)
            {
                Marcia = 4;
                return;
            }

            if (Velocita > 125)
            {
                Marcia = 5;
                return;
            }
        }
    }
}
