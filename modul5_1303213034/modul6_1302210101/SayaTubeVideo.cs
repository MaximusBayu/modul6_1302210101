using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210101
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null);
            Debug.Assert(title.Length <= 200);
            Random random = new Random();
            this.id = random.Next(999,100000);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int play)
        {
            Debug.Assert(playCount > 0 && playCount <= 25000000);
            try
            {
                checked
                {
                    this.playCount += play;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int GetPlayCount()
        {
            return this.playCount;
        }

        public string getTitle() {
            return this.title;
        }

        public void PrintVideoDetails() {
            Console.WriteLine("ID\t\t:"+id);
            Console.WriteLine("Judul\t\t:"+title);
            Console.WriteLine("Jumlah Diputar\t:"+playCount);
        }
    }
}
