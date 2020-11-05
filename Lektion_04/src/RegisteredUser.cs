using System;
using System.Collections;
namespace Lektion_04
{
    class RegisteredUser : User
    {
        public string username
        {
            get; set => null;
        }
        public DateTime birthday { get; set => null; }
        public Photo userPhoto { get; set => null; }
        public ArrayList<Playlist> userPlaylist { get; set => null; }
        public ArrayList<Video> usersFavouriteVideos { get; set => null; }

        public RegisteredUser(string Username, DateTime Birthday, Photo UserPhoto, ArrayList<Playlist> UserPlaylist, ArrayList<Video> UsersFavouriteVideos)
        {
            username = Username;
            birthday = Birthday;
            userPhoto = UserPhoto;
            userPlaylist = UserPlaylist;
            usersFavouriteVideos = UsersFavouriteVideos;
        }

        public void createPlaylist()
        {

        }

        public void addVideoToFavourites(Video newFavouriteVideo)
        {

        }

        public void uploadUserPhoto(Photo userPhoto)
        {

        }

        public Playlist addVideoToPlaylist(Video newPlaylistVideo, Playlist playlist)
        {

        }

    }
}
