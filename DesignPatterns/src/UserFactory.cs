using System;
using System.Collections.Generic;
namespace DesignPatterns
{
    class UserFactory
    {
        public IUser getUser(string userType)
        {
            var rUser = "RegisteredUser";
            var user = "User";
            var uploader = "Uploader";
            if (userType == null)
            {
                return null;
            }
            if (userType.Equals(rUser, StringComparison.OrdinalIgnoreCase))
            {
                return new RegisteredUser("bla", new DateTime(12, 12, 12), new Photo(12, "blub", 5, 5), new List<Playlist> { }, new List<Video> { });
            }
            else if (userType.Equals(user, StringComparison.OrdinalIgnoreCase))
            {
                return new User();
            }
            else if (userType.Equals(uploader, StringComparison.OrdinalIgnoreCase))
            {
                return new Uploader(new Channel("blabla", new Photo(12, "blibblab", 5, 5)), new List<Video> { new Video("bli", 300, 12, "16:9") });
            }
            return null;
        }
    }
}
