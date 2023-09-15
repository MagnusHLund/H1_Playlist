using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Playlist.Model
{
    /// <summary>
    /// Properties for the song object
    /// </summary>
    internal class Song
    {
        private string _title;
        private string _artist;
        private int _length; // Length in seconds

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }
    }
}
