using System;
using System.Collections;
using System.Collections.Generic;
namespace DesignPatterns
{
    class RegisteredUser : IUser
    {
        public string username
        {
            get; set;
        }
        public DateTime birthday { get; set; }
        public APhoto userPhoto { get; set; }
        public List<Playlist> userPlaylist { get; set; }
        public List<Video> usersFavouriteVideos { get; set; }

        public RegisteredUser(string Username, DateTime Birthday, APhoto UserPhoto, List<Playlist> UserPlaylist, List<Video> UsersFavouriteVideos)
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

        public void playVideo()
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
            return playlist;
        }

    }
}
