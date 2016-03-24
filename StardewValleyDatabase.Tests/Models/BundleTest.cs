using Microsoft.VisualStudio.TestTools.UnitTesting;
using StardewValleyDatabase.Models;
using System;
using System.Collections.Generic;

namespace StardewValleyDatabase.Tests.Models
{
    [TestClass]
    public class BundleTest
    {
        [TestMethod]
        public void CriarBundle()
        {
            var nCdBundle = 1;
            var sLinha = "Linha";
            var sLocal = "Local";
            var sNome = "Nome";
            var sRecompensa = "Recompensa";
            var lstItens = new List<BundleItem>()
            {
                new BundleItem()
            };

            Bundle oBundle = new Bundle()
            {
                nCdBundle = nCdBundle,
                sLinha = sLinha,
                sLocal = sLocal,
                sNome = sNome,
                sRecompensa = sRecompensa,
                lstItens = lstItens
            };

            Assert.AreEqual(nCdBundle, oBundle.nCdBundle);
            Assert.AreEqual(sLinha, oBundle.sLinha);
            Assert.AreEqual(sLocal, oBundle.sLocal);
            Assert.AreEqual(sNome, oBundle.sNome);
            Assert.AreEqual(sRecompensa, oBundle.sRecompensa);
            Assert.AreEqual(lstItens, oBundle.lstItens);
        }
    }
}