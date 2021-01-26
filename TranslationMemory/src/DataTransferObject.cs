using System;
using System.Collections.Generic;
using System.Collections;
namespace TranslationMemory
{
    class DataTransferObject
    {
        private UserFactory _userFactory = null;
        private TranslationFactory _translationFactory = null;
        private string _UUID;

        public DataTransferObject()
        {
            _translationFactory = new TranslationFactory();
            _userFactory = new UserFactory();
        }
        public InterfaceUser CreateNewUser(Role role, Gender gender, string username, int password, List<Word> words, List<Translation> translations)
        {

            switch (role)
            {
                case Role.ADMIN:
                    return (Admin)_userFactory.GetUser(role, gender, username, password, words, translations, GetUUID());
                case Role.TRANSLATOR:
                    return (Translator)_userFactory.GetUser(role, gender, username, password, words, translations, GetUUID());
                default:
                    return (User)_userFactory.GetUser(role, gender, username, password, words, translations, GetUUID());
            }
        }
        public List<Language> GetLanguages()
        {
            List<Language> languages = new List<Language>();
            List<language> lang = Database.Instance.GetLanguages();
            foreach (language l in lang)
            {
                Language language = new Language(l._name, l.ID);
                languages.Add(language);
            }
            return languages;
        }
        public List<Word> GetWords()
        {
            List<Word> words = new List<Word>();
            List<word> wo = Database.Instance.GetWords();
            foreach (word w in wo)
            {
                Word word = new Word(w._word, w._UUID);
                words.Add(word);
            }
            return words;
        }
        public string GetUUID()
        {
            _UUID = Guid.NewGuid().ToString();
            return _UUID;
        }
        public void SaveUser(InterfaceUser user, Role role)
        {
            switch (role)
            {
                case Role.USER:
                    Database.Instance.SaveUser((User)user, Role.USER);
                    break;
                case Role.TRANSLATOR:
                    Database.Instance.SaveUser((Translator)user, Role.TRANSLATOR);
                    break;
                default:
                    Database.Instance.SaveUser((Admin)user, Role.ADMIN);
                    break;
            }
        }
        public Word GetWord(string word)
        {
            foreach (Word w in GetWords())
            {
                if (w._word == word)
                {
                    return w;
                }
            }
            return null;
        }
        public void CreateWord(string word)
        {
            Word newWord = new Word(word, GetUUID());
            
        }
    }
}