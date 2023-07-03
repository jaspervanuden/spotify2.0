namespace spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song(naam,artiest,hard, 1);
            List<Song> list = new List<Song>();
            list.Add(song);

            Client client = new Client(list);
            client.ShowAllAlbums();
            client.SelectAlbums(0);
        }
    }
}