using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StardewValleyDatabase.Models
{
    public interface IItem
    {
        #region Properties

        bool bIsVisivel { get; set; }

        string sNome { get; set; }

        #endregion Properties
    }
}