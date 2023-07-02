namespace spotify
{
    public class Artist
    {
        private string name;
        private List<Album> albums;
        private List<Song> songs;

        public Artist(string name, List<Album> albums)
        {
            this.name = name;
            this.albums = albums;
        }
        public void AddSong(Song song)
        {
            this.songs.Add(song);
        }
        public void AddAlbum(Album album)
        {
            this.albums.Add(album);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

}