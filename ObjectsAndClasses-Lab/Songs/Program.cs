using System;
using System.Collections.Generic;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] songProperty = Console.ReadLine().Split("_");
                Song song = new Song(songProperty[0], songProperty[1], songProperty[2]);
                songs.Add(song);

            }
            string type = Console.ReadLine();
            if (type=="all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                }
                foreach (var song in songs)
                {
                if (song.TypeList == type)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
    class Song
    {
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
