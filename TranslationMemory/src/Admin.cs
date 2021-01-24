using System;
using System.Collections.Generic;
using System.Collections;
namespace TranslationMemory
{
    class Admin : InterfaceUser
    {
        private Gender _gender;
        private Role _role;
        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public Role Role
        {
            get { return _role; }
            set { _role = value; }
        }
        public string _userName { get; private set; }
        public int _password { get; private set; }
        public Admin(Gender gender, Role role, string username, int password)
        {
            Gender = gender;
            Role = role;
            _userName = username;
            _password = password;
        }
        public void DelegateTranslator(Translator translator, Language language)
        {

        }
        public void AddLanguage(Language language)
        {

        }
        public Word WordSearch(string id, string word)
        {
            return null;
        }
    }
}