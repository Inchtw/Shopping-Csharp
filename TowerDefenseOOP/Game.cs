using System;
namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map();

            map.Width = 8;
            map.Height = 5;

            int area = map.Width * map.Height;
            Console.WriteLine(area);
            Tower tower = new Tower();
        }

    }
}