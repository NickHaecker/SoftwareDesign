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
        private string TRANSLATION_PATH = "./db/translation";
        private string USER_PATH = "./db/user/user";
        private string TRANSLATOR_PATH = "./db/user/translator";
        private string ADMIN_PATH = "./db/user/admin";
        private string WORD_PATH = "./db/word";
        private string LANGUAGE_PATH = "./db/language/";

        public InterfaceUser GetUser(string username, int password)
        {
            return null;
        }
        public void SaveUser(InterfaceUser user, Role role)
        {
            string jsonString;
            string file;
            switch (role)
            {
                case Role.ADMIN:
                    jsonString = JsonSerializer.Serialize((Admin)user);
                    file = ADMIN_PATH + "/" + user.UUID + ".json";
                    break;
                case Role.TRANSLATOR:
                    jsonString = JsonSerializer.Serialize((Translation)user);
                    file = TRANSLATOR_PATH + "/" + user.UUID + ".json";
                    break;
                default:
                    jsonString = JsonSerializer.Serialize((User)user);
                    file = USER_PATH + "/" + user.UUID + ".json";
                    break;
            }
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
            string jsonString = JsonSerializer.Serialize(language);
            string file = LANGUAGE_PATH + "/" + language.ID + ".json";
            File.WriteAllText(file, jsonString);
        }
        public List<Language> GetLanguages()
        {
            List<Language> languages = new List<Language>();
            foreach (string fileName in Directory.GetFiles(LANGUAGE_PATH))
            {
                language l;
                var jsonString = File.ReadAllText(fileName);
                l = JsonSerializer.Deserialize<language>(jsonString);
                Language language = new Language(l._name, l.ID);
                languages.Add(language);
            }

            return languages;
        }
    }
}
