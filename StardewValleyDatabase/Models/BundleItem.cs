using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace StardewValleyDatabase.Models
{
    [DebuggerDisplay("{sNome} x{nQuantidade} ({sQualidade})")]
    public class BundleItem : IItem
    {
        #region Properties

        public bool bIsVisivel { get; set; }

        public int nQuantidade { get; set; }

        public string sDescricao { get; set; }

        public string sNome { get; set; }

        public string sQualidade { get; set; }

        #endregion Properties
    }
}