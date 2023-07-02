using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Song
    {
        public string Title;
        public List<Artist> Artists;
        public Genre SongGenre;
        private int Duur;

        public Song (string song, List<Artist> artists, int Genre)
        {
            this.Title = song;
            this.Artists = artists;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
