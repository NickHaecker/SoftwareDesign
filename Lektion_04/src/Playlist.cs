using System;
using System.Collections;
namespace Lektion_04
{
    class Playlist
    {
        public ArrayList<PlaylistVideo> playlistVideos { get; set => null; }
        public RegisteredUser playlistUser { get; set => null; }
        public string playlistName { get; set => null; }

        public Playlist(ArrayList<PlaylistVideo> PlaylistVideos, RegisteredUser PlaylistUser, string PlaylistName)
        {
            playlistVideos = PlaylistVideo;
            playlistUser = PlaylistUser;
            playlistName = PlaylistName;
        }
    }
}
