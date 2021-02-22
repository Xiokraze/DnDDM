using System.Drawing;

namespace DnDDM.Classes
{
    public static class DefaultValues
    {
        public static MainWindow mainWindow;

        public static Color DnDBlack = ColorTranslator.FromHtml("#030303"); //3,3,3
        public static Color DnDDark = ColorTranslator.FromHtml("#290000"); //41,0,0
        public static Color DnDRed = ColorTranslator.FromHtml("#930C10"); //147,12,16
        public static Color DnDGold = ColorTranslator.FromHtml("#F7CE65"); //247,206,101
        public static Color DnDLight = ColorTranslator.FromHtml("#FFFEBD"); //255, 254, 189
        public static System.Windows.Media.SolidColorBrush DnDBlackBrush = (System.Windows.Media.SolidColorBrush)(new System.Windows.Media.BrushConverter().ConvertFrom("#030303"));
        public static System.Windows.Media.SolidColorBrush DnDDarkBrush = (System.Windows.Media.SolidColorBrush)(new System.Windows.Media.BrushConverter().ConvertFrom("#290000"));
        public static System.Windows.Media.SolidColorBrush DnDRedBrush = (System.Windows.Media.SolidColorBrush)(new System.Windows.Media.BrushConverter().ConvertFrom("#930C10"));
        public static System.Windows.Media.SolidColorBrush DnDGoldBrush = (System.Windows.Media.SolidColorBrush)(new System.Windows.Media.BrushConverter().ConvertFrom("#F7CE65"));
        public static System.Windows.Media.SolidColorBrush DnDLightBrush = (System.Windows.Media.SolidColorBrush)(new System.Windows.Media.BrushConverter().ConvertFrom("#FFFEBD"));



        public static string Armor = "Armor";
        public static string Art = "Art";
        public static string Gem = "Gems";
        public static string Good = "Goods";
        public static string Trinket = "Trinkets";
        public static string Weapon = "Weapons";

        // Gold Values.
        public static string gp10 = "10 gp";
        public static string gp25 = "25 gp";
        public static string gp50 = "50 gp";
        public static string gp100 = "100 gp";
        public static string gp250 = "250 gp";
        public static string gp500 = "500 gp";
        public static string gp750 = "750 gp";
        public static string gp1000 = "1000 gp";
        public static string gp2500 = "2500 gp";
        public static string gp5000 = "5000 gp";
        public static string gp7500 = "7500 gp";

        // Goods.
        public static string ammunition = "Ammunition";
        public static string arcaneFocus = "Arcane Focus";
        public static string druidicFocus = "Druidic Focus";
        public static string holySymbol = "Holy Symbol";

        // Weapons.
        public static string simpleMelee = "Simple Melee";
        public static string simpleRanged = "Simple Ranged";
        public static string martialMelee = "Martial Melee";
        public static string martialRanged = "Martial Ranged";

        //Armor.
        public static string lightAmor = "Light Armor";
        public static string mediumAmor = "Medium Armor";
        public static string heavyAmor = "Heavy Armor";
        public static string shields = "Shields";
    }
}
