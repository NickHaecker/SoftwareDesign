using System;
using System.Collections;

namespace DesignPatterns
{
    class PlaylistVideo
    {
        public Video playlistVideo { get; set; }
        public RegisteredUser playlistUser { get; set; }

        public PlaylistVideo(Video PlaylistVideo, RegisteredUser PlaylistUser)
        {
            playlistVideo = PlaylistVideo;
            playlistUser = PlaylistUser;
        }
    }
}
