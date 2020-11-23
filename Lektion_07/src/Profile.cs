using System;

namespace Lektion_07
{
    public class Profile
    {
        public static Profile instance = null;
        string name;
        string phoneNumber;
        Profile(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public void CreateInstance(string name, string phoneNumber)
        {
            if (Profile.instance != null)
            {
                Console.WriteLine("Error there is already an instance of Profile");
                return;
            }

            Profile.instance = new Profile(name, phoneNumber);
        }
    }
}
