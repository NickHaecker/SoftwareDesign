namespace TranslationMemory
{
    abstract class AbstractTranslation
    {
        protected Language LANGUAGE { get; set; }
        protected string Translation { get; set; }
        protected string WORD_ID { get; set; }
        protected string AUTHOR { get; set; }

        protected AbstractTranslation(Language language, string translation, string wordID, string author)
        {
            LANGUAGE = language;
            Translation = translation;
            WORD_ID = wordID;
            AUTHOR = author;
        }
        public abstract void SetTranslation(string translation);
    }
}