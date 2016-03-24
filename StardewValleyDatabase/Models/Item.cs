using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace StardewValleyDatabase.Models
{
    [DebuggerDisplay("{nCdItem}: Nome: {sNome} Descricao: {sDescricao}")]
    public class Item : IItem
    {
        #region Properties

        public int nCdItem { get; set; }

        public string sNome { get; set; }

        public string sDescricao { get; set; }

        public string sClasse { get; set; }

        public string sClasseDescricao
        {
            get
            {
                if (sArquivo == "Furniture.yaml")
                {
                    return "Furniture";
                }
                else if (sClasse == "Arch")
                {
                    return "Artifact";
                }
                else
                {
                    var sSubClasseDesc = eSubClasse.GetDescricao();
                    return string.IsNullOrWhiteSpace(sSubClasseDesc) ? null : sSubClasseDesc;
                }
            }
        }

        public Enums.eSubClasse eSubClasse { get; set; }

        public int nPreco { get; set; }

        public int nRaridade { get; set; }

        public string sArquivo { get; set; }

        public bool bIsVisivel { get; set; }

        public string sLinha { get; set; }

        public ICollection<Bundle> lstBundles { get; set; }

        public ICollection<Craft> lstCrafts { get; set; }

        public ICollection<Receita> lstReceitas { get; set; }

        #endregion Properties

        #region Methods

        public void PreencherListas()
        {
            PreencherListaBundles();
            PreencherListaCrafts();
            PreencherListaReceitas();
        }

        public void CalculaPreco()
        {
            var lstFences = new List<int> { 322, 323, 324, 325, 298 };
            if (lstFences.Contains(nCdItem))
            {
                nPreco = 1;
            }
        }

        private void PreencherListaBundles()
        {
            string sJson = File.ReadAllText(HostingEnvironment.MapPath("~/Arquivos/Json/Bundles.json"));

            List<Bundle> lstBundle = JsonConvert.DeserializeObject<List<Bundle>>(sJson);

            lstBundles = new List<Bundle>();

            lstBundle.ForEach(x =>
            {
                if (!lstBundles.Select(y => y.sNome).Contains(x.sNome) && x.lstItens.Select(y => y.sNome).Contains(sNome))
                {
                    lstBundles.Add(x);
                }
            });
        }

        private void PreencherListaCrafts()
        {
            string sJson = File.ReadAllText(HostingEnvironment.MapPath("~/Arquivos/Json/Crafts.json"));

            List<Craft> lstTodosCrafts = JsonConvert.DeserializeObject<List<Craft>>(sJson);

            lstCrafts = new List<Craft>();

            foreach (var oCraft in lstTodosCrafts)
            {
                if (!lstCrafts.Select(x => x.nCdItem).Contains(oCraft.nCdItem) && (oCraft.nCdItem == nCdItem || oCraft.lstItens.Select(x => x.sNome).Contains(sNome)))
                {
                    lstCrafts.Add(oCraft);
                }
            }
        }

        private void PreencherListaReceitas()
        {
            string sJson = File.ReadAllText(HostingEnvironment.MapPath("~/Arquivos/Json/Receitas.json"));

            List<Receita> lstTodasReceitas = JsonConvert.DeserializeObject<List<Receita>>(sJson);

            lstReceitas = new List<Receita>();

            foreach (var oReceita in lstTodasReceitas)
            {
                if (!lstReceitas.Select(x => x.nCdItem).Contains(oReceita.nCdItem) && (oReceita.nCdItem == nCdItem || oReceita.lstItens.Select(x => x.sNome).Contains(sNome)))
                {
                    lstReceitas.Add(oReceita);
                }
            }
        }

        #endregion Methods
    }
}