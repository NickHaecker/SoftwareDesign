using System;

namespace TranslationMemory
{
    class DefaultTranslation : AbstractTranslation
    {
        public DefaultTranslation(Language language, string translation, string wordID, string author) : base(language, translation, wordID, author) { }

        public override void SetTranslation(string translation)
        {
            Translation = translation;
        }
        //         public override translation GetThis()
        //         {
        // translation t = new translation();
        // t.AUTHOR = AUTHOR;
        // t.LANGUAGE = LANGUAGE;
        // t.WORD_ID = WORD_ID;
        // t.
        //             return ;
        //         }
    }
}
