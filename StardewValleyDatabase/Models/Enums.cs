using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;

namespace StardewValleyDatabase.Models
{
    public static class Enums
    {
        public enum eSubClasse
        {
            [Description("")]
            Default = 0,

            [Description("Mineral")]
            Gem = -2,

            [Description("Fish")]
            Fish = -4,

            [Description("Animal Product")]
            Egg = -5,

            [Description("Animal Product")]
            Milk = -6,

            [Description("Cooking")]
            Cooking = -7,

            [Description("Crafting")]
            Crafting = -8,

            [Description("Crafting")]
            BigCraftable = -9,

            [Description("Mineral")]
            Mineral = -12,

            [Description("Animal Product")]
            Meat = -14,

            [Description("Resource")]
            MetalResources = -15,

            [Description("Resource")]
            BuildingResources = -16,

            [Description("")]
            SellAtPierres = -17,

            [Description("Animal Product")]
            SellAtPierresAndMarnies = -18,

            [Description("Fertilizer")]
            Fertilizer = -19,

            [Description("Trash")]
            Junk = -20,

            [Description("Bait")]
            Bait = -21,

            [Description("Fishing Tackle")]
            Tackle = -22,

            [Description("")]
            SellAtFishShop = -23,

            [Description("Decor")]
            Furniture = -24,

            [Description("Cooking")]
            Ingredient = -25,

            [Description("Artisan Goods")]
            ArtisanGood = -26,

            [Description("Artisan Goods")]
            Syrup = -27,

            [Description("Monster Loot")]
            MonsterLoot = -28,

            [Description("Equipment")]
            Equipment = -29,

            [Description("Seed")]
            Seed = -74,

            [Description("Vegetable")]
            Vegetable = -75,

            [Description("Fruit")]
            Fruit = -79,

            [Description("Flower")]
            Flower = -80,

            [Description("Forage")]
            Greens = -81,

            [Description("Hat")]
            Hat = -95,

            [Description("Ring")]
            Ring = -96,

            [Description("Boot")]
            Boot = -97,

            [Description("Weapon")]
            Weapon = -98,

            [Description("Tool")]
            Tool = -99
        }

        public static string GetDescricao(this Enum eTipoEnum)
        {
            //[Description("Padrão")]
            Type oTipo = eTipoEnum.GetType();
            string sNome = Enum.GetName(oTipo, eTipoEnum);
            if (sNome != null)
            {
                FieldInfo oCampo = oTipo.GetField(sNome);
                if (oCampo != null)
                {
                    DescriptionAttribute oAtributo =
                           Attribute.GetCustomAttribute(oCampo,
                             typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (oAtributo != null)
                    {
                        return oAtributo.Description;
                    }
                }
            }
            return eTipoEnum.ToString();
        }
    }
}