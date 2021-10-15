using System;
using System.Collections.Generic;
using System.Text;

namespace lab_real_1_patterns
{
    interface IShoes 
    {
        void Wear();
    }

    class Sneakers:IShoes
    {
       public string brand { get; set; }
        public string color { get; set; }
        public int size { get; set; }
        public bool waterproof { get; set; }
        public Sneakers ()
        {
            this.size = 35;
            this.color = "white";
            this.waterproof = false;
            this.brand = "none";
        }

        public static Sneakers CreateSneakersColor(string color) 
        { 
            Sneakers snkrs = new Sneakers();
            snkrs.color = color;
            return snkrs;
        }
        public static Sneakers CreateSneakersBrand(string brand)
        {
            Sneakers snkrs = new Sneakers();
            snkrs.brand = brand;
            return snkrs;
        }
        public void Wear() => Console.WriteLine("Вы надели кроссовки!");
    }

    class Gumshoes :IShoes
    {
        public void Wear() => Console.WriteLine("Вы надели кеды!");
    }

    class UnknownShoes:IShoes
    {
        public void Wear() => Console.WriteLine("Вы надели бог знает что!");
    }


    interface IShoesFactory 
    {
        IShoes ProduceShoes(ShoesType type);
    }
    class CustomizeSneakers : IShoes 
    {
        public void Wear() => Console.WriteLine("Вы надели разукрашенные кроссовки!");
    }

    class CustomizeGumshoes : IShoes
    {
        public void Wear() => Console.WriteLine("Вы надели разукрашенные кеды!");
    }

   enum ShoesType
   {
        Sneakers,
        Gumshoes
   }

    class ShoesFactory : IShoesFactory
    {
         public  IShoes ProduceShoes(ShoesType type)
            {
                switch(type)
                {
                case ShoesType.Sneakers: return new Sneakers();
                case ShoesType.Gumshoes: return new Gumshoes();
                default: return new UnknownShoes();
            }
            }
    }

    class CustomShoesFactory : IShoesFactory
    {
        public IShoes ProduceShoes(ShoesType type)
        {
            switch (type)
            {
                case ShoesType.Sneakers: return new CustomizeSneakers();
                case ShoesType.Gumshoes: return new CustomizeGumshoes();
                default: return new UnknownShoes();
            }
        }
    }

    class DistinguishFactory
    {
        public static IShoesFactory GetFactory(bool custom)
        {
            if (custom)
            {
                return new CustomShoesFactory();
            }
            else
            {
                return new ShoesFactory();
            }
        }
    }

}
