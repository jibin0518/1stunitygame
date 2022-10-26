using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0922
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            
            
            Monster monster1 = new Monster();

            player.AddAt(10);

            Console.WriteLine(monster1.at);
            Console.WriteLine(player.at);
            Console.ReadLine();

            
        }
    }

}
