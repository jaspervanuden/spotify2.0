namespace spotify
{
    public class Album : SongCollection
    {
        private List<Artist> artists;
        public Album(List<Artist> artists, string album, List<Song> songs)
        {
            this.artists = artists;
            
        }
        public List<Artist> ShowArtists()
        {
            return artists;
        }        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}