using System;

namespace Lektion_04
{
    class PlaylistVideo
    {
        public Video playlistVideo { get; set => null; }
        public RegisteredUser playlistUser { get; set => null; }

        public PlaylistVideo(Video PlaylistVideo, RegisteredUser PlaylistUser)
        {
            playlistVideo = PlaylistVideo;
            playlistUser = PlaylistUser;
        }
    }
}
