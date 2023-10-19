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

            MessageBox.Show("Vuoi un'auto a cambio automatico? (SI/NO)");
            

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

}
