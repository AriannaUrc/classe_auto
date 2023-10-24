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

            string promptValue = Prompt.ShowDialog("Inserisci", "Vuoi un'auto a cambio automatico? (SI/NO)");

            if(promptValue.ToLower() == "si") 
            {
                Car = new autoAutoma();
                marcia_add_button.Enabled = false;
                marcia_sub_button.Enabled = false;
            }
            else
            {
                Car = new auto();
            }

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
            SetGearScreen();
        }


        private void acceleratore_button_Click(object sender, EventArgs e)
        {
            Car.Accelera(5);
            SetVelocityScreen();
            SetGearScreen();
        }


        private void SetVelocityScreen()
        {
            listView1.Items.Clear();
            if (!Car.Accesa())
            {
                listView1.Items.Add("spenta");
            }
            else
            {
                listView1.Items.Add(Car.Velocita.ToString() + " Km/h");
            }

            //MessageBox.Show (Car.GetType().ToString());
            if(Car.GetType().ToString() == "classe_auto.autoAutoma")
            {
                
                listView3.Items.Clear();
                listView3.Items.Add(Car.GiriMotore.ToString());
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

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 410,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 300 };
            Button confirmation = new Button() { Text = "Ok", Left = 250, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            
            
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

    }

    

}

