using System;
using System.Collections.Generic;
using System.Collections;
namespace TranslationMemory
{
    class UserFactory
    {
        public InterfaceUser GetUser(Role role, Gender gender, string username, int password, List<Word> words, List<Translation> translations, string uuid)
        {
            string ROLE = role.ToString().ToUpper();
            string USER = "User";
            string TRANSLATOR = "Translator";
            string ADMIN = "Admin";
            if (ROLE == USER.ToUpper())
            {
                return new User(gender, role, words, uuid);
            }
            else if (ROLE == TRANSLATOR.ToUpper())
            {
                return new Translator(gender, role, username, password, null, translations, words, uuid);
            }
            else if (ROLE == ADMIN.ToUpper())
            {
                return new Admin(gender, role, username, password, uuid);
            }
            else
            {
                return null;
            }
        }
    }
}