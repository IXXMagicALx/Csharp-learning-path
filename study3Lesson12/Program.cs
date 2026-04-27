using System.Runtime.CompilerServices;

namespace Lesson12
{
    class Monster 
    {
        static public Monster[] monsters;
    }
    class Boss:Monster
    {
        public void Skill()
        {
            Console.WriteLine("BOSS释放技能");
        }
    }
    class Goblin:Monster
    {
        public void GoblinAtk()
        {
            Console.WriteLine("哥布林攻击");
        }
    }
    
    class Player
    {
        private Weapon nowHave;
        public Player()
        {
            Weapon nowHave = new Dagger();
        }
        public void PickUP(Weapon weapon)
        {
            nowHave = weapon;
        }
    }
    class Weapon
    {
    }
    class SMG:Weapon
    {

    }
    class SG:Weapon
    {

    }
    class P:Weapon
    {

    }
    class Dagger:Weapon
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("里氏替换原则");
            #region is和as的区别
            //is负责判断是否是对应类型
            //as负责转换成对应类型
            #endregion
            #region 写个Monster类，它派出Boss和Goblin两个类调用他们的攻击方法，如果是boss就释放技能 
            Random r = new Random();
            Monster[] monsters = new Monster[10];
            for (int i = 0; i < monsters.Length; i++)//装入数组中
            {
                int j = r.Next(0, 100);
                if (j >= 0 && j < 20)
                {
                    monsters[i] = new Boss();
                }
                else
                {
                    monsters[i] = new Goblin();
                }
            }
            for (int j = 0; j < 10; j++)
            {
                if (monsters[j] is Goblin)
                {
                    (monsters[j] as Goblin).GoblinAtk();
                }
                if (monsters[j] is Boss)
                {
                    (monsters[j] as Boss).Skill();
                }
            }
            #endregion
            #region FPS游戏模拟
            Player player = new Player();
            SMG smg = new SMG();//冲锋枪对象
            SG sg = new SG();//霰弹枪对象
            P p = new P();//手枪对象
            player.PickUP(smg);
            #endregion
        }
    }
}
