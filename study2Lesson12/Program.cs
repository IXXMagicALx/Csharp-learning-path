using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace Lesson12
{
    #region 学生
    struct Student
    {
        //变量
        //变量类型可以是任意变量类型包括结构体，但是不能是自己这个结构体，可以是其他的
        public int age, classes;//在结构体中声明的变量不能初始化
        public bool sex;
        public string name, major;
        //构造函数
        //构造函数中的变量必须初始化
        public Student(int age, int classes, bool sex, string name, string major)
        {
            this.age = age;
            this.classes = classes;
            this.sex = sex;
            this.name = name;
            this.major = major;
        }
        //构造函数
        //函数
        //目前在结构体中的函数申明时不需要加static
        public void Speak()
        {
            Console.WriteLine("学生：{0}，性别：{1} ，班级：{2}，年龄：{3}，专业：{4}", name, sex ? "男" : "女", classes, age, major);
        }
    }
    #endregion
    #region 矩形
    struct Square
    {
        //变量
        public int length, width;
        //构造函数

        //函数
        public void S()
        {
            int s = length * width; //必须在这初始化
            Console.WriteLine("矩形的面积是" + s);
        }
        public void L()
        {
            int l = 2 * (length + width);//必须在这初始化
            Console.WriteLine("矩形的周长是" + l);
        }

    }
    #endregion
    #region 玩家
    struct PlayerInfo
    {
        //变量
        public string name;
        public E_occupation occupation;
        //构造函数
        public PlayerInfo(string name, E_occupation occupation)
        {
            this .name = name;
            this .occupation = occupation;
        }
        //函数
        public  void Act()
        {
            string oc = "";//职业
            string sk = "";//技能
            switch (occupation)
            {
                case E_occupation.Warrior:
                    oc = "战士";
                    sk = "冲锋";
                    break;
                case E_occupation.Hunter:
                    oc = "猎人";
                    sk = "假死";
                    break;
                case E_occupation.Master:
                    oc = "法师";
                    sk = "奥术攻击";
                    break;
            }
            Console.WriteLine("{0}{1}释放了{2}",oc,name,sk);
        }
    }
    //枚举
    enum E_occupation
    {
        //不写等于几第一个默认等于0
        //之后累加
        Warrior = 0,
        Hunter,
        Master,
    }
    #endregion
    #region 怪物
    struct Monster
    {
        //变量
        public string name;
        public int hp, atk;
        //构造函数
        public Monster(string name)
        {
            this.name = name;
            Random r = new Random();
            this.hp = r.Next(200,401);//初始化怪物生命值
            this.atk = r.Next(100, 151);//初始化怪物攻击力
        }
        //函数
        public void Print()
        {
            Console.WriteLine("{0} 它的攻击力是{1}", name, atk);
        }
    }
    #endregion
    #region 奥特曼
    struct Ultraman
    {
        //变量
        public string name;
        public int atk, hp;
        //构造函数
        public Ultraman(string name,int atk,int hp)
        {
            this.name = name;
            this.atk = atk;
            this.hp = hp;
        } 
        //函数
        //奥特曼攻击怪物
        public void Uatk(ref Boss monster)
        {
            monster.hp -= (atk-monster.def); 
        Console.WriteLine("{0}攻击了{1}，对ta造成了{2}点伤害，它还剩余{3}点血量",name,monster.name, atk - monster.def, monster.hp);
        }
    }
    struct Boss
    {
        //变量
        public string name;
        public int atk, hp,def;
        //构造函数
        public Boss(string name,int atk,int hp,int def)
        {

            this.name = name;
            this.atk =atk;
            this.hp = hp;
            this.def = def;
        }
        //函数
        //怪兽打奥特曼
        public void Batk( ref Ultraman ultraman)
        {
            ultraman.hp -= atk; 
        Console.WriteLine("{0}攻击了{1}，对ta造成了{2}点伤害，它还剩余{3}点血量",name,ultraman.name, atk , ultraman.hp);
        }
}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("结构体");
            #region 1.
            //Student s1 = new Student(20,3,false,"Tifa","电子信息工程");
            //s1.Speak();
            //Student s2 = new Student(18,2, false, "Alice", "计算机技术");
            //s2.Speak();
            #endregion
            #region 2.private和public访问修饰符
            //修饰结构体的变量与函数
            //private,私有的,只能在结构体中使用。如果没有访问修饰符，则默认private。
            //public,公开的,能在结构体外使用，如在结构体外为结构体中的变量赋值和函数的使用。
            #endregion
            #region 3.
            //Square sq1;//申明结构体
            //Console.WriteLine("请输入矩形的长：");
            //sq1.length = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入矩形的宽：");
            //sq1.width  = int.Parse(Console.ReadLine());
            //sq1.S();//调用函数
            //sq1.L();//调用函数
            #endregion
            #region 4.打印 职业 玩家 释放了 技能
            //bool isContinue = false;
            //PlayerInfo p1;
            //Console.WriteLine("请输入玩家名字：");
            //p1.name = Console.ReadLine();//存储玩家名字
            //do
            //{
            //    Console.WriteLine("请选择想要的职业(0.战士，1.猎人，2.法师)");
            //    try
            //    {
            //        p1.occupation = (E_occupation)int.Parse(Console.ReadLine());
            //        //输入的字符串先Parse转成int类型再从int类型括号强转转成E_occupation枚举类型
            //        p1.Act();
            //        isContinue = false;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("请输入每个职业对应的数字");
            //        isContinue = true;
            //    }
            //}
            //while (isContinue);
            #endregion
            #region 5. 用结构体描述怪兽
            //见上
            #endregion
            #region 6. 定义数组存储十个上面描述的小怪兽
            Monster[] monsters = new Monster[10];//申明一个结构体Monster类型的数组存十个怪物
            for (int i = 0; i < monsters.Length; i++)
            {
                monsters[i] = new Monster("小怪兽"+i);
                monsters[i].Print();//调用函数
            }
            #endregion
            #region 7.奥特曼打小怪兽
            //一定要先申明就算在内部初始化
            Random r = new Random();
            Ultraman ultraman = new Ultraman("奥特曼", r.Next(150, 200), 220);
            Boss boss = new Boss("哥斯拉", r.Next(50, 80), 400, 50);
            while (true)
            {
                Console.WriteLine("**********************************************************************");
                ultraman.Uatk(ref boss);
                Console.WriteLine("**********************************************************************");
                boss.Batk(ref ultraman);
                Console.WriteLine("**********************************************************************");
                Console.WriteLine("按任意键继续");
                Console.ReadKey(true);
                if (ultraman.hp <= 0)
                {
                    Console.WriteLine("很遗憾，奥特曼没能成功，哥斯拉还是太强了");
                    break;
                }
                if (boss.hp <= 0)
                {
                    Console.WriteLine("恭喜，奥特曼成功了");
                    break;

                }
            }
            #endregion
            }
    }
}
