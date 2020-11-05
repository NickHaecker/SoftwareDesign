using System;
using System.Collections.Generic;
namespace DesignPatterns
{
    class Playlist
    {
        public List<PlaylistVideo> playlistVideos { get; set; }
        public RegisteredUser playlistUser { get; set; }
        public string playlistName { get; set; }

        public Playlist(List<PlaylistVideo> PlaylistVideos, RegisteredUser PlaylistUser, string PlaylistName)
        {
            playlistVideos = PlaylistVideos;
            playlistUser = PlaylistUser;
            playlistName = PlaylistName;
        }
    }
}
