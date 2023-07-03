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
        public List<Person> ShowFriends()
        {
            return Friends;
        }
        public List<Playlist> ShowPlaylists()
        {
            return Playlists;
        }
        public Playlist SelectPlaylist(int index) 
        {
            return ;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
