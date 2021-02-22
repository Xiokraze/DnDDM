namespace DnDDM.Classes
{
    public class StandardItem
    {
        public string ArmorClass { get; set; }
        public string ItemName { get; set; }
        public string Classification { get; set; }
        public string Damage { get; set; }
        public string Description { get; set; }
        public string Properties { get; set; }
        public string RequiredStrength { get; set; }
        public string StealthImpact { get; set; }
        public string Value { get; set; }
        public string Weight { get; set; }


        // Armor Consctructor.
        public StandardItem(string description, string value, string armorClass, string requiredStrength, string stealthImpact, string weight, string classification)
        {
            this.Description = description;
            this.Value = value;
            this.ArmorClass = armorClass;
            this.RequiredStrength = requiredStrength;
            this.StealthImpact = stealthImpact;
            this.Weight = weight;
            this.Classification = classification;
        }


        // Art Constructor.
        public StandardItem(string description, string value)
        {
            this.Description = description;
            this.Value = value;
            this.Classification = DefaultValues.Art;
        }


        // Gem Constructor.
        public StandardItem(string name, string description, string value)
        {
            this.ItemName = name;
            this.Description = description;
            this.Value = value;
            this.Classification = DefaultValues.Gem;
        }


        // Good Constructor.
        public StandardItem(string description, string value, string weight, string classification)
        {
            this.Description = description;
            this.Value = value;
            this.Weight = weight;
            this.Classification = classification;
        }


        // Trinket Constructor.
        public StandardItem(string description)
        {
            this.Description = description;
            this.Classification = DefaultValues.Trinket;
        }


        // Weapon Constructor.
        public StandardItem(string description, string value, string damage, string weight, string properties, string classification)
        {
            this.Description = description;
            this.Value = value;
            this.Damage = damage;
            this.Weight = weight;
            this.Properties = properties;
            this.Classification = classification;
        }
    }
}
