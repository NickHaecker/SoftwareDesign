using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TranslationMemory
{
    class Database
    {
        private static Database _instance;
        public static Database Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Database();
                return _instance;
            }
        }
        public string TRANSLATION_PATH = "../db/translation";
        public string USER_PATH = "../db/user";
        public string WORD_PATH = "../db/qword";
        public string LANGUAGE_PATH = "../db/language";

        public InterfaceUser GetUser(string username, int password)
        {
            return null;
        }
        public void SaveUser(InterfaceUser user)
        {

        }
        public Word GetWord(string id)
        {
            return null;
        }
        public List<Word> GetWords()
        {
            return null;
        }
        public AbstractTranslation GetTranslation(Language language)
        {
            return null;
        }
        public AbstractTranslation GetTranslation(InterfaceUser user)
        {
            return null;
        }
        public void SaveWord(Word word)
        {

        }
        public void SaveWord(InterfaceUser user)
        {

        }
        public void AddLanguage(Language language)
        {

        }
    }
}
