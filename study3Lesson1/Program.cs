namespace Lesson1
{
    class Person//类
    {
        //特征 成员变量
        //行为 成员方法
        //保护特征 成员属性

        //构造函数和析构函数
        //索引器
        //运算符重载
        //静态对象
    }
    
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("类和对象");
            #region 类对象（引用类型）
            //概念：类申明出来的变量

            //语法
            //类名 变量名；
            //类名 变量名 = null ；（null代表空）
            //类名 变量名 = new 类名（）；
            //前两种相当于没有初始化
            //只在栈里分配了空间，栈里的地址指向空，没有指向任何堆中的内存空间
            //第三种 相当于栈里有地址 指向堆里的一个内存空间
            Person p;
            Person p1 = null;
            Person p2 = new Person();//相当于一个人
            Person p3 = new Person();//相当于另一个人
                                     //两个人数据独立，没有任何关系
            #endregion
            #region Homework
            #region 1.
            //生物：人 猫 张阿姨 隔壁老王 向日葵 菊花 荷花
            //非生物： 机器人  机器  汽车 飞机 太阳 星星
            /////////////////////////////////////////
            //地下的 
            //天上的 太阳 星星 飞机
            #endregion
            #region 2.

            #endregion
            #endregion
        }
    }
}
