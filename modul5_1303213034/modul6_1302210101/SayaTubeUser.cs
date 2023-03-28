using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
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
            Debug.Assert(username != null);
            Debug.Assert(username.Length <=100);
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
            Debug.Assert(!uploadedVideos.Contains(vids));
            Debug.Assert(uploadedVideos.Count >= 0 && uploadedVideos.Count < int.MaxValue);
            uploadedVideos.Add(vids);
        }

        public void PrintAllVideocount() {
            
            Console.WriteLine("User\t:"+Username);
            
            for(int i = 0;i<uploadedVideos.Count && i< 8;i++)
            {
                Console.WriteLine("Video "+(i+1)+" judul: " + uploadedVideos[i].getTitle());
                
            }
        }

    }
}
