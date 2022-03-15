using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class Weapon
    {
        public int gulletutumu;
        public int gullesayi;
        public double bosalmavaxti;
        public bool autoOrSimple;


        public Weapon(int gulletutumu, int gullesayi, double bosalmavaxti, bool atismodu)
        {
            this.gulletutumu = gulletutumu; this.gullesayi = gullesayi; this.bosalmavaxti = bosalmavaxti; this.autoOrSimple = autoOrSimple;

        }
        public void GetInfo()
        {
            Console.WriteLine("Gulle tutumu:"+ gulletutumu+"  gUlle sayi:"+ gullesayi+"  Bosalma vaxti:"+bosalmavaxti+"   Atis modu:"+ autoOrSimple);
        }

        public void Shoot()
        {
            if (gullesayi > 0)
            {

                int atis = 0;
                atis = gullesayi - 1;
                Console.WriteLine("Ates acildi....Partt " + "qalan gulle sayi: " + atis);
            }


            else
            {
                Console.WriteLine("Gulle yoxdur");

            }
        }
        public void Fire()
        {
            if (gullesayi > 0)
            {
                double vaxt = 3.5;
                int atis = 0;
                atis = gullesayi - gullesayi;
                vaxt = gullesayi * bosalmavaxti / gulletutumu;
                Console.WriteLine("Ates acildi....Partt,Part.. " + "qalan gulle sayi: " + atis + "Nece saniye bitdi :" + vaxt);
            }
            else
            {
                Console.WriteLine("Gulle yoxdur");

            }

        }
        public void GetRemainBulletCount()
        {

            int lazim = 0;
            lazim = gulletutumu - gullesayi;
            Console.WriteLine("Lazim olan gullesayi: " + lazim);
        }

        public void Reload()
        {

            int lazim = gulletutumu - gullesayi;
            int cem = gullesayi + lazim;
            Console.WriteLine("Gulle doldurmagi ucun lazim olan say " + lazim + "  Doldurulduqdan sonra gulle sayi: " + cem);
        }
        public void ChangeFireMode()
        {
            //Console.WriteLine("true auto,false");
            bool secim = bool.Parse(Console.ReadLine());

            if (secim == true)
            {
                autoOrSimple = true;
            }
            else if (secim == false)
            {
                autoOrSimple = false;
            }
            else
            {
                Console.WriteLine("False yada Trueden istifade edin");
            }

        }

    }
}
