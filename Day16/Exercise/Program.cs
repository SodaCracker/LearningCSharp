using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(12);
            Player player = new Player(gun);
            while (true)
            {
                Console.ReadLine();
                player.Fire();
            }
        }
    }

    class Gun
    {
        public int Bullets { get; set; } = 7;

        public Gun()
        {

        }

        public Gun(int bullets)
        {
            Bullets = bullets;
        }

        public void Shoot()
        {
            if (Bullets == 0)
            {
                Console.WriteLine("No bullets.");
                return;
            }
            Console.WriteLine("BANG!");
            Bullets--;
        }

    }

    class Player
    {
        protected Gun gun;

        public Player(Gun gun)
        {
            this.gun = gun;
        }

        public void Fire()
        {
            gun.Shoot();
        }
    }
}
