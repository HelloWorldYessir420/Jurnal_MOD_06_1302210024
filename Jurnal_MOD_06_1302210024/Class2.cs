using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_MOD_06_1302210024
{
    internal class SayaTubeUser
    {
        private int ID;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string Username)
        {
            if (Username == null || Username == "")
            {
                throw new ArgumentNullException("Username Harus Diisi");
            }

            if (Username.Length > 100)
            {
                throw new ArgumentNullException("Username Tidak Boleh Lebih Dari 200 Karakter");
            }
            
            this.ID = 0;
            this.Username = Username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int totalVideoPlayCount = 0;
            foreach(SayaTubeVideo video in uploadedVideos)
            {
                totalVideoPlayCount+= video.GetPLayCount();
               
            }
            return totalVideoPlayCount;
            
        }

        public void AddVideo(SayaTubeVideo video)
        {
            this.uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            for (int i = 0;i < uploadedVideos.Count;i++)
            {
                Console.WriteLine("Review Film " + (i+1) + " Judul : '" + uploadedVideos[i].title + 
                    "' Play Count : " + uploadedVideos[i].GetPLayCount());
            }
            Console.WriteLine("");
            Console.WriteLine("Oleh User : " + Username);
        }

    }
}
