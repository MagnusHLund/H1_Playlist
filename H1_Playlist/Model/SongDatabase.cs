using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Playlist.Model
{
    /// <summary>
    /// Contains a database of all songs
    /// </summary>
    internal class SongDatabase
    {
        public List<Song> songs = new List<Song>()
        {
            new Song()
            {
                Title = "The Kris song",
                Artist = "The guy who sings your name over and over",
                Length = 77
            },
            new Song()
            {
                Title = "Jump",
                Artist = "Kris kross",
                Length = 198
            },
            new Song()
            {
                Title = "From here to forever",
                Artist = "Kris kristofferson",
                Length = 210
            },
            new Song()
            {
                Title = "In the news",
                Artist = "Kris kristofferson",
                Length = 210
            },
            new Song()
            {
                Title = "Stærke Mikkel",
                Artist = "Magnus Lund",
                Length = 69
            },
            new Song()
            {
                Title = "Camilla-lalala",
                Artist = "Triz",
                Length = 264
            }
        };
    }
}
