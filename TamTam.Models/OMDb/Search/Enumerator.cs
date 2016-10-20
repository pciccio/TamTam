namespace TamTam.Models.OMDb.Search
{
    public class Enumerator
    {
        public enum TypeOfResult
        {
            Movie,
            Series,
            Episode
        }

        public enum DataReturnType
        {
            Json,
            Xml
        }

        public enum Plot
        {
            Short,
            Full
        }
    }
}
