using System;
using System.Collections.Generic;
using System.Collections;
namespace TranslationMemory
{
    class User : InterfaceUser
    {
        private Gender _gender;
        private Role _role;
        private string _UUID;

        public List<Word> _addedWords { get; private set; }
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
        public string UUID
        {
            get { return _UUID; }
            set
            {
                UUID = value;
            }
        }
        public User(Gender gender, Role role, List<Word> words)
        {
            _gender = gender;
            _role = role;
            _UUID = Guid.NewGuid().ToString();
            _addedWords = words;

        }
        public void SaveWord(Word word)
        {

        }
    }
}