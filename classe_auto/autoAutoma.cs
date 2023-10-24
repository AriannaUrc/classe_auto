﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_auto
{
    internal class autoAutoma : auto
    {
        

        public autoAutoma() : base() 
        {
            Marcia = 0;
            Velocita = 0;
            GiriMotore = 0;
        }

        public autoAutoma(int marcia, int velocita, int girimotore) : base(marcia, velocita)
        {
            Marcia = marcia;
            Velocita = velocita;
            GiriMotore = girimotore;
        }

        public override void Accelera(int val)
        {
            Velocita += val;
            AutoModMarcia();
            AutoGiri();
        }

        public override int Decelera(int val)
        {
            if (Velocita >= val)
            {
                Velocita -= val;

                AutoModMarcia();
                AutoGiri();

                return 0;
            }

            //la macchina è gia ferma
            AutoModMarcia();
            AutoGiri();
            return 2;
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
                Marcia = 1;
                return;
            }

            if (Velocita > 25 && Velocita <= 50)
            {
                Marcia = 2;
                return;
            }

            if (Velocita > 50 && Velocita <= 75)
            {
                Marcia = 3;
                return;
            }

            if (Velocita > 75 && Velocita <= 100)
            {
                Marcia = 4;
                return;
            }

            if (Velocita > 100)
            {
                Marcia = 5;
                return;
            }
        }


        public void AutoGiri()
        {
            GiriMotore =  Velocita * 100 / Marcia;
        }
    }
}
