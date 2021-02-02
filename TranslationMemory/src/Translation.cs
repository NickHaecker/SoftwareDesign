using System;

namespace TranslationMemory
{
    class Translation : AbstractTranslation
    {
        public Translation(Language language, string translation, string wordID, string author) : base(language, translation, wordID, author) { }

        public override void SetTranslation(string translation)
        {
            Translation = translation;
        }

        // public override translation GetThis()
        // {
        //     return this;
        // }
    }
}
