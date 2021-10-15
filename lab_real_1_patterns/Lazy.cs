using System;
using System.Collections.Generic;
using System.Text;

namespace lab_real_1_patterns
{

    class Player
    {
       public Lazy<GameBox> gb = new Lazy<GameBox>();
      public Player()
        {
            Console.WriteLine("i was declared!");
        }
        public void PlayBoardGme()
        {
            for (int i = 1; i <= 3; i++)
            {
                gb.Value.GetGame(i);
            }
            Console.WriteLine("- настольная игра из коробки!");
           
        }

        public void PlayBoardGameONCompuer()
        {
            Console.WriteLine(gb);
            Console.WriteLine("Вы зашли в папку своих настольный игр онлайн!"); 
        } 

    }

    class GameBox
    {

        public GameBox()
        {
            Console.WriteLine("i was created!");
            this.Games.Add(1, "Манчкин");
            this.Games.Add(2, "Монополия");
            this.Games.Add(3, "Уно");
        }

        public IDictionary<int, string> Games { get; set; } = new Dictionary<int, string>() ;

        public void GetGame(int number)
        {
            Console.WriteLine($"Мы взяли с полки игру! {Games[number]}");
        }
    }



}
