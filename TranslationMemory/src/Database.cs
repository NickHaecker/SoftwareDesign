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
                    user = (Admin)user;
                    jsonString = JsonSerializer.Serialize((Admin)user);
                    file = ADMIN_PATH + "/" + user.UUID + ".json";
                    break;
                case Role.TRANSLATOR:
                    user = (Translator)user;
                    jsonString = JsonSerializer.Serialize((Translator)user);
                    file = TRANSLATOR_PATH + "/" + user.UUID + ".json";
                    break;
                default:
                    user = (User)user;
                    jsonString = JsonSerializer.Serialize((User)user);
                    file = USER_PATH + "/" + user.UUID + ".json";
                    break;
            }
            WriteFile(file, jsonString);
        }
        private void WriteFile(string file, string jsonString)
        {
            File.WriteAllText(file, jsonString);
        }
        // public void AddTranslator()
        public Word GetWord(string id)
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
            string jsonString = JsonSerializer.Serialize(word);
            string file = WORD_PATH + "/" + word._UUID + ".json";
            WriteFile(file, jsonString);
            Console.WriteLine("Wort wurde ins System gestellt");
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
        public List<language> GetLanguages()
        {
            List<language> languages = new List<language>();
            foreach (string jsonString in GetFileNames(LANGUAGE_PATH))
            {
                language l;
                l = JsonSerializer.Deserialize<language>(jsonString);
                languages.Add(l);
            }
            return languages;
        }
        public List<word> GetWords()
        {
            List<word> words = new List<word>();
            foreach (string jsonString in GetFileNames(WORD_PATH))
            {
                word w;
                w = JsonSerializer.Deserialize<word>(jsonString);
                words.Add(w);
            }
            return words;
        }
        private List<string> GetFileNames(string path)
        {
            List<string> strings = new List<string>();
            foreach (string fileName in Directory.GetFiles(path))
            {
                string jsonString = File.ReadAllText(fileName);
                strings.Add(jsonString);
            }
            return strings;
        }
    }
}
