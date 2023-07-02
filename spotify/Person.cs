using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Person
    {
        public string Name;
        private List<Person> Friends;
        private List<Playlist> Playlists;

        public Person(string person)
        {
            Name = person;
        }
        public List<Person> person ShowFriends()
        {
            Friends = new List<Person>();
        }
        public List<Playlist> playlist ShowPlaylists()
        {
            Playlists = new List<Playlist>();
        }
        public SelectPlaylist(int playlist)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
