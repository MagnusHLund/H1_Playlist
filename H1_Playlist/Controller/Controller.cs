using H1_Playlist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Playlist.Controller
{
    internal class Controller
    {
        public void StartController()
        {
            SongDatabase database = new SongDatabase();
            View.View view = new View.View();

            // Creates 2 playlists, inside a list
            List<Playlist> playlists = new List<Playlist>();
            for (int i = 0; i < 2; i++)
            {
                playlists.Add(new Playlist());
            }

            // Gives the name to the 2 playlists
            playlists.Last().Name = "Kris";
            playlists.First().Name = "Other";

            // Runs through both playlists and all songs in the database
            foreach (Playlist playlist in playlists)
            {
                foreach (Song song in database.songs)
                {
                    // If the playlist is named "Kris" and the songs artist or title, to lower, contains "kris".
                    // If it does, then it adds the songs to the Kris playlist.
                    // If the playlist is not named Kris and the songs aren't related to kris, then it adds it to the "other" playlist
                    if (playlist.Name == "Kris")
                    {
                        if (song.Title.ToLower().Contains("kris") || song.Artist.ToLower().Contains("kris"))
                        {
                            playlist.songs.AddLast(song);
                            view.Message($"Added: '{song.Title}' by '{song.Artist}' to '{playlist.Name}'");
                        }
                    }
                    else
                    {
                        if (!song.Title.ToLower().Contains("kris") && !song.Artist.ToLower().Contains("kris"))
                        {
                            playlist.songs.AddLast(song);
                            view.Message($"Added: '{song.Title}' by '{song.Artist}' to '{playlist.Name}'");
                        }
                    }
                }
            }
        }
    }
}
