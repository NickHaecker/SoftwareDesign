using System;
using System.Collections.Generic;
using System.Collections;
namespace TranslationMemory
{
    class translator
    {
        public Gender Gender { get; set; }
        public Role Role { get; set; }
        public string UUID { get; set; }
        public List<Word> AddedWords = new List<Word>();
        public string _userName { get; set; }
        public int _password { get; set; }
        public Language _language { get; set; }
        public List<Translation> _addedTranslations = new List<Translation>();
    }
}