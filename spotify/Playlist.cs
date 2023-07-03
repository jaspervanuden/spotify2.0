namespace spotify
{
    internal class Playlist
    {
        public Person Owner;

        public Playlist(Person person, string index)
        {
            Owner = person;
            
        }
        public void Add(iPlayable playable)
        {
            
        }
        public void Remove(iPlayable playable)
        {
            
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}