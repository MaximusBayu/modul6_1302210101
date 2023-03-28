using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210101
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string username)
        {
            this.id = id;
            this.uploadedVideos = new List<SayaTubeVideo>();
            Username = username;
        }

        public int getTotalVideoCount() {
            int total = 0;
            foreach (SayaTubeVideo sayaTubeVideo in uploadedVideos) {
                total += sayaTubeVideo.GetPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo vids) { 
            uploadedVideos.Add(vids);
        }

        public void PrintAllVideocount() {
            Console.WriteLine("User\t:"+Username);
            int i = 1;
            foreach (SayaTubeVideo sayaTubeVideo in uploadedVideos)
            {
                Console.WriteLine("Video "+i+" judul: " + sayaTubeVideo.getTitle());
                i++;
            }
        }

    }
}
