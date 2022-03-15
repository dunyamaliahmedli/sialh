using System;

namespace ConsoleApp1.Model



{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Xos gelmisiz online atis Merkezine");
            Console.WriteLine("Gulle tutumunu qeyd edin :");
            int gulletutumu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gulle sayini qeyd edin:");
            int gullesayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gulle bosalma vaxtini daxil edin :");
            double bosalmavaxti = double.Parse(Console.ReadLine());
            Console.WriteLine("atis modunu secin:");
            bool atismodu = bool.Parse(Console.ReadLine());

            Weapon Silah = new Weapon(gulletutumu, gullesayi, bosalmavaxti, atismodu);

            if (gulletutumu > gullesayi)
            {
                int key = 0;

                do

                {
                    Console.WriteLine("Zehmet olmasa secim edin(1-6):");
                    key = Convert.ToInt32(Console.ReadLine());

                    switch (key)
                    {
                        case 1:

                            Silah.Shoot();
                            break;
                        case 2:

                            Silah.Fire();
                            break;
                        case 3:

                            Silah.GetRemainBulletCount();
                            break;
                        case 4:

                            Silah.Reload();
                            break;
                        case 5:


                            Silah.ChangeFireMode();
                            break;

                        case 6:
                            Console.WriteLine("Sagolunnn");
                            break;
                        case 0:
                            Silah.GetInfo();
                            break;

                        default:
                            Console.WriteLine("Zehmet olmasa duzgun reqem secin");
                            break;

                    }
                }
                while (key != 6);
                { }



            }
            else
            {
                Console.WriteLine("Gulle sayi tutumdan boyuk ola bilmez");
            }

            }
            }


    }


