namespace spotify
{
    internal class Playlist
    {
        public Person Owner;

        public Playlist(Person person, string)
        {
            Owner = person;
            //vraag
        }
        public void Add(iPlayable playable)
        {
            //vraag
        }
        public void Remove(iPlayable playable)
        {
            //vraag
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}