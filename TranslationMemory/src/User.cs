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

        private List<Word> _addedWords;
        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public List<Word> AddedWords
        {
            get { return _addedWords; }
            set { _addedWords = value; }
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
        public User(Gender gender, Role role, List<Word> words, string uuid)
        {
            _gender = gender;
            _role = role;
            _UUID = uuid;
            _addedWords = words;

        }
        public void SaveWord(Word word)
        {
            _addedWords.Add(word);
        }
    }
}