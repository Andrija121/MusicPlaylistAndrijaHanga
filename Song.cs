using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylistAndrijaHanga
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public Genre Genre { get; set; }

        public string TitleArtist
        {
            get { return Title + " - " + Artist; }
        }
    }

    public enum Genre
    {
        Pop = 0,
        Rock = 1,
        Jazz = 2
    }
}
