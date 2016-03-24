using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace StardewValleyDatabase.Models
{
    [DebuggerDisplay("{sNome} x{nQuantidade}")]
    public class ReceitaItem : IItem
    {
        public string sNome { get; set; }

        public int nQuantidade { get; set; }

        public bool bIsVisivel { get; set; }
    }
}