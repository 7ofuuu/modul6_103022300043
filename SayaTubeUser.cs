using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300043
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideo;
        private String username;

        public SayaTubeUser( string username)
        {
            Debug.Assert(!string.IsNullOrEmpty(username) && username.Length <= 100, "username harus tidak null dan maksimal 100 karakter.");
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.uploadedVideo = uploadedVideo;
            this.username = username;
            uploadedVideo = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;

            for (int i = 0; i < uploadedVideo.Count; i++)
            {
                totalPlayCount += 1;
            }
                return totalPlayCount;
        }

        public void AddVideo(SayaTubeVideo data)
        {
            uploadedVideo.Add(data);
        }

        public void PrintAllVideoPlayCount()
        {
            for (int i = 0; i < uploadedVideo.Count; i++)
            {
                Console.WriteLine($"User: {username}");
                Console.WriteLine($"Video {i+1} judul: {uploadedVideo[i].title}");
            }
        }
    }
}
