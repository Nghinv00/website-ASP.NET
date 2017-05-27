namespace Web_cafe_film.ThuatToan.Entities
{
    using System.Collections.Generic;

    public class Output
    {
        #region Public Properties

        public IList<Rule> StrongRules { get; set; }

        public IList<string> MaximalItemSets { get; set; }

        public Dictionary<string, Dictionary<string, double>> ClosedItemSets { get; set; }

        public ItemsDictionary FrequentItems { get; set; } 

        #endregion
    }
}