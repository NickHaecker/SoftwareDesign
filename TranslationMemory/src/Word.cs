using System;
using System.Collections.Generic;
using System.Collections;

namespace TranslationMemory
{
    class Word
    {
        public string _UUID { get; private set; }
        public string _word { get; private set; }
        public Word(string word, string uuid)
        {
            _UUID = uuid;
            _word = word;
        }
        public void AddTranslation(AbstractTranslation translation)
        {

        }
        public void EditTranslation(AbstractTranslation translation)
        {

        }
        public List<AbstractTranslation> GetTranslations()
        {
            return null;
        }
        public AbstractTranslation GetTranslation(Language language)
        {
            return null;
        }
        public AbstractTranslation GetTranslation(string translation)
        {
            return null;
        }

    }
}
