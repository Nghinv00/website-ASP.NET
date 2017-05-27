using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_cafe_film.ThuatToan.Entities;

namespace Web_cafe_film.ThuatToan.Contracts
{
    public interface IApriori
    {
        Output ProcessTransaction(double minSupport, double minConfidence, IEnumerable<string> items, string[] transactions);
    }


}