using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXT_RPG
{
    public class Monster_1
    {
        public string name = "강민석";
        public int level = 1;
        public int atk_dmg = 5;
        public int def = 1;
        public int max_hp = 10;
        public int current_hp = 10;

        public int drop_gold = 10;
        public int drop_exp = 10;

        public void information()
        {
            Console.WriteLine("==============================================");
            Console.Write(" 몬스터 : 『" + name + "』                  ");
            Console.WriteLine("Lv : " + level);
            Console.Write(" 공격력 : " + atk_dmg + "   ");
            Console.Write(" 방어력 : " + def + "   ");
            Console.WriteLine(" 체력 : " + current_hp + "/" + max_hp + "   ");
            Console.WriteLine("==============================================");
        }
        
        public void itemdrop(Player player)
        {
            player.gold += drop_gold;
            player.current_exp += drop_exp;
            if(player.current_exp >= player.max_exp)
            {
                player.level += 1;
            }

            Console.ReadLine();
            Console.Clear();
        }
    }

  
}
