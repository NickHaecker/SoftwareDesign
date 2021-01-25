using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

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
        private string TRANSLATION_PATH = "./db/translation/translator.json";
        private string USER_PATH = "./db/user";
        private string TRANSLATOR_PATH = "./db/user/translator.json";
        private string ADMIN_PATH = "./db/user/admin.json";
        private string WORD_PATH = "./db/word";
        private string LANGUAGE_PATH = "./db/language";

        public InterfaceUser GetUser(string username, int password)
        {
            return null;
        }
        public void SaveUser(InterfaceUser user)
        {
            string jsonString = JsonSerializer.Serialize(user);
            string file = USER_PATH + "/" + user.UUID + ".json";
            File.WriteAllText(file, jsonString);
        }
        // public void AddTranslator()
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
