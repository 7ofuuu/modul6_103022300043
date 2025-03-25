using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300043
{
    class SayaTubeVideo
    {
        private int id;
        public String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            Debug.Assert(!string.IsNullOrEmpty(title) && title.Length <= 200, "Judul video harus tidak null dan maksimal 200 karakter.");
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count > 25000000)
            {
                throw new ArgumentException("Jumlah play count maksimal adalah 25.000.000 per panggilan.");
            }else if(count < 0)
            {
                throw new ArgumentException("Input tidak boleh negatif");
            }

                try
                {
                    checked
                    {
                        this.playCount += count;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: Play count melebihi batas maksimum integer.");
                }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"Video ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }
}
