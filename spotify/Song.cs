using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    public class Song : iPlayable
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

        public int Length { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
