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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        
    }
    class auto
    {
        public int Marcia { get; set; }
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

        public void AddMarcia(int val)
        {
            Marcia += val;
        }

        public void SubMarcia(int val)
        {
            Marcia -= val;
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
