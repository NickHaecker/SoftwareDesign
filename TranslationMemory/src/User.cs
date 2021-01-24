using System;
using System.Collections.Generic;
using System.Collections;
namespace TranslationMemory
{
    class User : InterfaceUser
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
        public User(Gender gender, Role role)
        {
            _gender = gender;
            _role = role;
        }
        public void SaveWord(Word word)
        {

        }
    }
}