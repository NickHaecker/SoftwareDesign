using System;
using System.Collections.Generic;
using System.Collections;
namespace TranslationMemory
{
    class translator
    {
        public Gender _gender { get; set; }
        public Role _role { get; set; }
        public string _UUID { get; set; }
        public List<Word> _addedWords = new List<Word>();
        public string _userName { get; set; }
        public int _password { get; set; }
        public Language _language { get; set; }
        public List<Translation> _addedTranslations = new List<Translation>();
    }
}