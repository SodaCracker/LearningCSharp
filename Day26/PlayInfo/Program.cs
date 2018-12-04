using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"d:\playerInfo\1", FileMode.Create, FileAccess.Write);
            Player[] players = new Player[10];
            Random r = new Random();
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player
                    (r.Next(1, 100) * 1.0f, r.Next(1, 100) * 1.0f, r.Next(1, 100), "player" + (i + 1).ToString());
            }

            using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Default))
            {
                for (int i = 0; i < players.Length; i++)
                {
                    bw.Write(players[i].X);
                    bw.Write(players[i].Y);
                    bw.Write(players[i].Hp);
                    bw.Write(players[i].Name);
                }
            }

            FileStream fs2 = new FileStream(@"d:\playerInfo\1", FileMode.Open, FileAccess.Read);
            using (BinaryReader br = new BinaryReader(fs2))
            {
                for (int i = 0; i < players.Length; i++)
                {
                    Console.WriteLine(br.ReadSingle());
                    Console.WriteLine(br.ReadSingle());
                    Console.WriteLine(br.ReadInt32());
                    Console.WriteLine(br.ReadString());
                }
            }
        }
    }

    class Player
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Hp { get; set; }
        public string Name { get; set; }

        public Player(float x, float y, int hp, string name)
        {
            X = x;
            Y = y;
            Hp = hp;
            Name = name;
        }
    }
}
