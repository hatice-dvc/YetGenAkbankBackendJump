using Spotify_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_App.Services
{
    internal class NotePadService
    {
        public void PlaylistToNotePad(Playlist playlist)
        {
            // Saving the Notepad...
            string directory = @$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\Playlists";
            string saveFile = Path.Combine(directory, $"{playlist.Id}.txt");

            if (!File.Exists(directory))
                Directory.CreateDirectory(directory);

            File.WriteAllText(saveFile, playlist.GetSongs());

            Console.WriteLine("Data succesfully saved to NotePad!");
        }
    }

}
