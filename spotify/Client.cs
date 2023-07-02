using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Client
    {
        public iPlayable CurrentlyPlaying;
        public int CurrentTime;
        public bool Playing;
        public bool Shuffle;
        public bool Repeat;
        private SuperUser ActiveUser;
        private List<Album> AllAlbums;
        private List<Song> AllSongs;
        private List<Person> AllUsers;


        public Client(List<Person> people, List<Album> albums, List<Song> songs)
        {
            AllUsers = people;
            AllAlbums = albums;
            AllSongs = songs;
        }
        public void SetActiveUser(Person person)
        { 

        }
        public void ShowAllAlbums()
        {

        }
        public void SelectAlbums(int index)
        {

        }
        public void ShowAllSongs() {

        }
        public void SelectSongs(int index)
        {

        }
        public void ShowAllUsers()
        {

        }
        public void SelectUsers(int index)
        {

        }
        public void ShowUserPlaylists()
        {

        }
        public void SelectUserPlaylist(int index)
        {

        }

        public void Play()
        {

        }
        public void Pause()
        {

        }
        public void Stop()
        {

        }
        public void NextSong()
        {

        }
        public void SetShuffle(bool index)
        {

        }
        public void SetRepeat(bool index)
        {

        }
        public void CreatePlaylist(string index)
        {

        }
        public void ShowPlaylist()
        {

        }
        public void SelectPlaylist(int index)
        {

        }
        public void RemovePlaylist(int index)
        {

        }
        public void AddToPlaylist(int index)
        {

        }
        public void ShowSongsInPlaylist()
        {

        }
        public void RemoveFromPlaylist()
        {

        }
        public void ShowFriends()
        {

        }
        public void SelectFriend()
        {

        }
        public void AddFriend(int index)
        {

        }
        public void RemoveFriend(int index)
        {

        }
}
}
