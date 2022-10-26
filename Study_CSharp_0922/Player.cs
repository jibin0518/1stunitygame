using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test0922
{
    public class Player
    {
        public int hp = 100;
        public int at = 10;

  
        public void AddAt(int _at)
        {
            //공격력을 _at올려주기 위한 함수
            at += _at;
        }


    }
}
