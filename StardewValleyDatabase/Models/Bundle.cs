using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace StardewValleyDatabase.Models
{
    [DebuggerDisplay("{sLocal} {sNome} ({lstItens.Count} itens)")]
    public class Bundle
    {
        #region Properties

        public int nCdBundle { get; set; }

        public string sNome { get; set; }

        public string sLocal { get; set; }

        public string sRecompensa { get; set; }

        public string sLinha { get; set; }

        public ICollection<BundleItem> lstItens { get; set; }

        #endregion Properties
    }
}