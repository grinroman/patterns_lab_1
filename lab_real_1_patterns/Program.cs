using System;

namespace lab_real_1_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sh = ShoesFactory.ProduceShoes(ShoesType.Sneakers); //решить вопрос со статиком - secondly
            //var gsh = ShoesFactory.ProduceShoes(ShoesType.Gumshoes);
            //sh.Wear();
            //gsh.Wear();
            //Sneakers s1 = Sneakers.CreateSneakersBrand("adidas"); // firstly
            //Console.WriteLine(s1.brand);
            //Console.WriteLine(s1.color);
            //Sneakers s2 = Sneakers.CreateSneakersColor("red");
            //Console.WriteLine(s2.color);
            //Console.WriteLine(s2.brand);
            //var customFactory = DistinguishFactory.GetFactory( true); //thirdly
            //var crossi = customFactory.ProduceShoes(ShoesType.Sneakers);
            //crossi.Wear();
            //var kedi = customFactory.ProduceShoes(ShoesType.Gumshoes);
            //kedi.Wear();


            //Person p1 = new PersonBiulder()
            //    .SetName("Vasilii")
            //    .SetSurname("Petrov")
            //    .SetAge("0")
            //    .SetAge("0")
            //    .Build();
            //foreach (var prop in p1.GetType().GetProperties())
            //{
            //    Console.WriteLine("{0} = {1}", prop.Name, prop.GetValue(p1, null));
            //}

            Player p1 = new Player();
            p1.PlayBoardGameONCompuer();
            Player p2 = new Player();
            p2.PlayBoardGme();

            //Console.WriteLine(Singleton.Instance.Data1); 

            //LoadBalancer reqObj = new LoadBalancer();
            //for (int i = 1; i <= 10; i++)
            //    reqObj.SericeRequest();



        }

    }
}

