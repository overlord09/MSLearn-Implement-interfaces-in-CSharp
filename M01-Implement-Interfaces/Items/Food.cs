﻿namespace M01_Implement_Interfaces.Items
{
    internal class Food : Item, IConsumable
    {
        private readonly bool ingredient = false;

        public Food(string resouceName, Bitmap image) : base(ParseResourceName(resouceName), image)
        {
            ingredient = resouceName.StartsWith("ingredient");
        }

        public bool IsIngredient()
        {
            return ingredient;
        }

        private static new string ParseResourceName(string name)
        {
            if (name.StartsWith("ingredient"))
                name = name[name.IndexOf("_")..].Trim();
            
            return name.Replace("_", " ").Trim();
        }

        public void Consume()
        {
            Consumed=true;
        }

        protected override int InternalSortOrder { get { return 3; } }

        public bool Consumed { get; set; }
    }
  
}
