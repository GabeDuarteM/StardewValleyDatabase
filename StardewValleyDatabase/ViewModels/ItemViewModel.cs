using Newtonsoft.Json;
using StardewValleyDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace StardewValleyDatabase.ViewModels
{
    public class ItemViewModel
    {
        public List<Item> lstItens { get; set; }

        public List<string> lstNomeItens { get { return lstItens.Select(x => x.sNome).ToList(); } }

        public List<string> lstNomeItensLowerCase { get { return lstItens.Select(x => x.sNome.ToLower()).ToList(); } }

        public string sJsonItens { get; set; }

        public ItemViewModel()
        {
            sJsonItens = System.IO.File.ReadAllText(HostingEnvironment.MapPath("~/Arquivos/Json/Itens.json"));
            lstItens = JsonConvert.DeserializeObject<List<Item>>(sJsonItens);
            lstItens = lstItens.Where(x => x.bIsVisivel).ToList();
        }
    }
}