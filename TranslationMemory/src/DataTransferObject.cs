using System;
using System.Collections.Generic;
using System.Collections;
namespace TranslationMemory
{
    class DataTransferObject
    {
        private UserFactory _userFactory = null;

        // private string _UUID;

        public DataTransferObject()
        {
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
            return Guid.NewGuid().ToString();
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
        public Word CreateWord(string word)
        {
            Word newWord = new Word(word, GetUUID());
            Database.Instance.SaveWord(newWord);
            return newWord;
        }
        public void CreateTranslation(string wordUuid, string userUuid, bool createInitialTranslation)
        {
            if (createInitialTranslation)
            {
                foreach (Language language in GetLanguages())
                {
                    AbstractTranslation translation = TranslationFactory.GetTranslation(language, "", wordUuid, userUuid);
                    Database.Instance.CreateTranslation(translation);
                }
            }
            else
            {

            }
            // foreach (Language language in GetLanguages())

            // {
            // _translationFactory.
            // }
        }
        public List<AbstractTranslation> GetTranslations()
        {
            List<translation> translations = Database.Instance.GetTranslations();
            List<AbstractTranslation> transLation = new List<AbstractTranslation>();
            foreach (translation trans in translations)
            {
                AbstractTranslation translation = TranslationFactory.GetTranslation(new Language(trans.LANGUAGE._name, trans.LANGUAGE.ID), trans.Translation, trans.WORD_ID, trans.AUTHOR);
                transLation.Add(translation);
            }
            return transLation;
        }
        public List<AbstractTranslation> GetTranslationByWord(Word word)
        {
            List<AbstractTranslation> wordTranslations = new List<AbstractTranslation>();
            foreach (AbstractTranslation translation in GetTranslations())
            {
                if (translation.WORD_ID == word._UUID)
                {
                    wordTranslations.Add(translation);
                }
            }
            return wordTranslations;
        }
    }
}