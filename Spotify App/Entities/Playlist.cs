﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_App.Entities
{
    internal class Playlist
    {
        public Guid Id { get; set; }

        private List<Song> Songs { get; set; }

        private Random random;


        public Playlist(Song firstSong)
        {
            Id = Guid.NewGuid();
            Songs = new List<Song>();
            random = new Random();
            AddSong(firstSong);
        }

        public void AddSong(Song song)
        {
            if (song != null)
            {
                Songs.Add(song);
            }
        }

        public string GetSongs()
        {
            return string.Join("\n", Songs.Select(song => $"{song.Title} - {song.Composer}"));
        }

        public void ShuffleSongs()
        {
            int songCount = Songs.Count;

            while (songCount > 0)
            {
                songCount--;
                Song song = Songs[songCount];
                int randomIndex = random.Next(songCount);
                Songs[songCount] = Songs[randomIndex];
                Songs[randomIndex] = song;
            }
        }

    }

}
