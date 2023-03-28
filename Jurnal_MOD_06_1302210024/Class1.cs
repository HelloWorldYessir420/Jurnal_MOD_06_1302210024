using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_MOD_06_1302210024
{
    internal class SayaTubeVideo
    {
        private int id;
        public string title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            if (title == null || title == "")
            {
                throw new ArgumentNullException("Judul Video Tidak Boleh Kosong");
            }

            if (title.Length > 200)
            {
                throw new ArgumentNullException("Judul Video Tidak Boleh Lebih Dari 200 Karakter");
            }

            this.id = new Random().Next(10000);
            this.title = title;
            this.playCount = 0;
        }
        public void IncreasePlayCount(int playCount)
        {
            if (playCount < 0 || playCount > 25000000)
            {
                throw new ArgumentOutOfRangeException("Input Tidak Boleh Kosong/Lebih Dari 25.000.000");
            }

            try
            {
                checked
                {
                    this.playCount += playCount;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Error " + e.Message);
            }
        }

        public int GetPLayCount()
        {
            return this.playCount;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Film Berjudul : " + title);
            Console.WriteLine("ID Film : " + id);
            Console.WriteLine("Diputar Sebanyak : " + playCount + " Kali");
            Console.WriteLine(" ");
        }

    }
}
