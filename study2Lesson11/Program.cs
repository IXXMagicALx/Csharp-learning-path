using System.Data;

namespace Lesson11
{
    internal class Program
    {
        static void Func(int a)
        {
            Console.Write(a);//2.实现打印效果
            a++;//3.完成一个递归变化，用于条件判断
            if (a>10)
            {
                return;//4.完成递归
            }
            Func(a);//1.构造递归
        }
        //传入一个值，递归求该值的阶乘并返回
        static int Func1(int a)
        {
            if(a==1)//a1==1时返回给Func(2)“Func(1)==1”,使得递归终止并且终止了就会从末尾往回算
                //2*1
                //3*2*1
                //4*3*2*1
                //5*4*3*2*1
            {
                return 1;//4.完成递归
            }
            //5!=5*4*3*2*1
            return a*Func1(a-1);//1.构造递归，2.实现阶乘效果，3.完成一个递归变化，用于条件判断
            //5*Func1(4)
            //Func1(4)=4*Func1(3)
            //Func1(3)=3*Func1(2)
            //Func1(2)=2*Func1(1)
            //Func1(1)=1
        }
        //递归求1~10的阶乘之和
        //方法1：递归算阶乘，再通过for循环累加调用函数
        static int Func2(int a)
        {
            if (a==1)
            {
                return 1;//4.完成递归
            }
             return a* Func2(a-1);//1.构造递归，2.实现阶乘效果，3.完成递归变化用于条件判断
        }
        //方法2：
        static int Func2_2(int a)
        {
            if (a==1)
            {
                return Func1(1);//其实就是1
              //return 1;
            }
            return Func1(a) + Func2_2(a - 1);
        }
        //100m每天砍1/2，求第10天的长度
        static void Func3(ref double a,int d=0)//不能用int而是用double不然每次取整数最后会归于0
        {
            if (d==10)//第十天还没砍
            {
                return;
            }
            a /= 2;//砍一半
            d++;//天数
            Func3(ref a,d);//1.构造递归
        }
        static bool Func4(int a)//bool类型
        {
            //函数的实际内容就是打印，其他都是用于递归
            Console.WriteLine(a);//2.实现打印效果
            //
            return a==200||Func4(a+1);//1.构造递归,3.使改变，位于结束判断，4.完成递归
            //用到了短路。
            //&&和||这种逻辑运算符，只要左边满足条件右边不进行运算
            //如：&&左边为false的时候最终结果肯定为false，所以右边不进行运算
            //||左边为true的时候最终结果肯定为true，所以右边不进行运算
            //如题当a==200时为true时不继续递归
        }
        static void Main(string[] args)
        {
            Console.WriteLine("递归函数");
            int a = 0;
            Func(a);
            Console.WriteLine("");//用于换行
            Console.WriteLine("**********************");

            int a2 = 5;//传入5
            Console.WriteLine(Func1(a2));//打印最终结果
            Console.WriteLine("**********************");

            int [] arr = {1,2,3,4,5,6,7,8,9,10};
            int sum =0;
            int a3 = 10;
            for(int i=0 ;i < arr.Length;i++)
            {
                sum += Func2(arr[i]);
            }
            Console.WriteLine("1~10的阶乘之和是" + sum);
            Console.WriteLine("1~10的阶乘之和是"+Func2_2(10));
            Console.WriteLine("**********************");

            double a4 = 100;
            int d4 = 0;
            Func3(ref a4);
            Console.WriteLine("竹竿第十天的长度是：" + a4);//正确值为：0.09765625
            Console.WriteLine("**********************");

            int a5 = 1;
            Func4(a5);

        }
    }
}
