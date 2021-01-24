using System;
using System.Collections.Generic;
using System.Collections;
namespace TranslationMemory
{
    class UserFactory
    {
        public InterfaceUser GetUser(Role role, Gender gender, string username, int password)
        {
            string ROLE = role.ToString().ToUpper();
            string USER = "User";
            string TRANSLATOR = "Translator";
            string ADMIN = "Admin";
            if (ROLE == USER.ToUpper())
            {
                return new User(gender, role);
            }
            else if (ROLE == TRANSLATOR.ToUpper())
            {
                return new Translator(gender, role, username, password, null);
            }
            else if (ROLE == ADMIN.ToUpper())
            {
                return new Admin(gender, role, username, password);
            }
            else
            {
                return null;
            }
        }
    }
}