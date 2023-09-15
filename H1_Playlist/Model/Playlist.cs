using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Playlist.Model
{
    /// <summary>
    /// Contains a linked list, for each added song in the playlist, as well as a property for the playlist name
    /// </summary>
    internal class Playlist
    {
        public LinkedList<Song> songs = new LinkedList<Song>();

        private string _name;

        public string Name 
        { 
            get { return _name; } 
            set { _name = value; } 
        }
    }
}
