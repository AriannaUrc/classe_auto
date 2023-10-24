using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_auto
{
    internal class auto
    {
        private int _marcia;
        private int _velocita;
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
        public int Velocita { get { return _velocita; } set { _velocita = value; } }

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


        public void AddMarcia()
        {

            if (Marcia < 5)
                Marcia++;
        }

        public void SubMarcia()
        {

            if (Marcia > 0)
                Marcia--;
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
}
