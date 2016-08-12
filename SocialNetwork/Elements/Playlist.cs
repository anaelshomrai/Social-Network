using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network
{
    class Playlist
    {
        string singer;
        string song;
        string genre;

        public Playlist(string singer,string song,string genre)
        {
            this.singer = singer;
            this.song = song;
            this.genre = genre;
        }

        public string Singer
        {
            get { return singer; }
            set { singer = value;  }
        }

        public string Song
        {
            get { return song; }
            set
            { song = value;  }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public override string ToString()
        {
            return this.singer + " - " + this.song;
        }
    }
}
