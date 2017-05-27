using System.Collections.ObjectModel;
using System.Collections.Generic;
using Web_cafe_film.ThuatToan.Entities;

namespace Web_cafe_film.ThuatToan
{
    public class ItemsDictionary : KeyedCollection<string, Item>
    {
        protected override string GetKeyForItem(Item item)
        {
            return item.Name;
        }

        internal void ConcatItems(IList<Item> frequentItems)
        {
            foreach (var item in frequentItems)
            {
                this.Add(item);
            }
        }
    }
}