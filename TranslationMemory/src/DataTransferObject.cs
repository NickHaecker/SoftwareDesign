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
        public InterfaceUser CreateNewUser(Role role, Gender gender, string username, int password, List<Word> words, List<AbstractTranslation> translations)
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
        // public Create
        public InterfaceUser LoginUser(string username, int password)
        {
            List<admin> admins = Database.Instance.GetAllAdmins();
            List<translator> translator = Database.Instance.GetAllTranslator();
            InterfaceUser user = null;
            foreach (admin a in admins)
            {
                if (a._userName == username && a._password == password)
                {
                    user = (Admin)_userFactory.GetUser(a.Role, a.Gender, a._userName, a._password, null, null, a.UUID);
                    break;
                }
            }
            foreach (translator t in translator)
            {
                if (t._userName == username && t._password == password)
                {
                    // List<Word> words = new List<Word>();
                    // foreach (word w in t.AddedWords)
                    // {
                    //     words.Add(new Word(w._word, w._UUID));
                    // }
                    user = (Translator)_userFactory.GetUser(t.Role, t.Gender, t._userName, t._password, GetWords(t.AddedWords), GetTranslations(t._addedTranslations), t.UUID);
                    break;
                }
            }
            if (user != null)
            {
                switch (user.Role)
                {
                    case Role.ADMIN:
                        return (Admin)user;
                    default:
                        return (Translator)user;
                }
            }
            else
            {
                return null;
            }
        }
        public InterfaceUser GetTranslator(string username)
        {
            foreach (Translator t in GetAllTranslator())
            {
                if (t._userName == username)
                {
                    return t;
                }
            }
            return null;
        }
        public List<Translator> GetAllTranslator()
        {
            List<translator> translator = Database.Instance.GetAllTranslator();
            List<Translator> translators = new List<Translator>();
            foreach (translator t in translator)
            {
                Translator trans = (Translator)_userFactory.GetUser(t.Role, t.Gender, t._userName, t._password, GetWords(t.AddedWords), GetTranslations(t._addedTranslations), t.UUID);
                translators.Add(trans);
            }
            return translators;
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
        public Language GetLanguage(string language)
        {
            foreach (Language l in GetLanguages())
            {
                if (language == l._name)
                {
                    return l;
                }
            }
            return null;
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
        public List<Word> GetWords(List<word> words)
        {
            List<Word> newwordlist = new List<Word>();
            foreach (word w in words)
            {
                Word word = new Word(w._word, w._UUID);
                newwordlist.Add(word);
            }
            return newwordlist;
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
        }
        public void CreateLanguage(string language)
        {
            Language l = new Language(language, language);
            Database.Instance.AddLanguage(l);
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
        public List<AbstractTranslation> GetTranslations(List<translation> translations)
        {
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
        public int GetWordsInDatabaseLength()
        {
            return GetWords().Count;
        }
        public List<string> GetPercentageOfCorrectTranslatetWords()
        {
            List<string> counts = new List<string>();
            foreach (Word word in GetWords())
            {
                int count = 0;
                foreach (AbstractTranslation translation in GetTranslationByWord(word))
                {
                    if (translation.Translation != "(Keine)")
                    {
                        count++;
                    }
                }
                string wordCount = "Für das Wort " + word._word + " ist die Übersetzung zu " + CalculatePercentage(GetTranslationByWord(word).Count, count) + "%" + " vollstädnig.";
                counts.Add(wordCount);
            }
            return counts;
        }
        private int CalculatePercentage(int length, int count)
        {
            return count / length * 100;
        }
    }
}