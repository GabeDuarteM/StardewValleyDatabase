using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace StardewValleyDatabase.Models
{
    [DebuggerDisplay("{nCdItem}: {sNome}")]
    public class Receita
    {
        public int nCdItem { get; set; }

        public string sNome { get; set; }

        public string sSource { get; set; }

        public string sLinha { get; set; }

        public List<ReceitaItem> lstItens { get; set; }
    }
}