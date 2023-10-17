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
            Car.AddMarcia();
            SetGearScreen();
        }

        private void marcia_sub_button_Click(object sender, EventArgs e)
        {
            Car.SubMarcia();
            SetGearScreen();
        }
    }
    class auto
    {

        private int _marcia;
        public int Marcia {
            get { return _marcia; }
            set { 
                
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


        public void Accelera(int val)
        {
            Velocita += val;

        }

        public int Decelera(int val)
        {
            if (Velocita>=val)
            {
                Velocita -= val;
                return 0;
            }

            //la macchina e gia ferma
            return 2;

        }

        public void AddMarcia()
        {
            if(Marcia<5)
            Marcia++;
        }

        public void SubMarcia()
        {
            if (Marcia>-1)
            Marcia--;
        }

        public bool Accesa()
        {
            if(Velocita==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
