using System;
using System.ComponentModel.Composition;
using System.Collections.Generic;
using Web_cafe_film.ThuatToan.Contracts;

namespace Web_cafe_film.ThuatToan.Implementation
{
    [Export(typeof(ISorter))]
    class Sorter : ISorter
    {
        string ISorter.Sort(string token)
        {
            char[] tokenArray = token.ToCharArray();
            Array.Sort(tokenArray);
            return new string(tokenArray);
        }
    }
}
