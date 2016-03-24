using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace StardewValleyDatabase.Models
{
    [DebuggerDisplay("{nCdItem}: {sNome}")]
    public class Craft
    {
        public int nCdItem { get; set; }

        public string sNome { get; set; }

        public int nQtProduzida { get; set; }

        public string sLinha { get; set; }

        public List<CraftItem> lstItens { get; set; }
    }
}