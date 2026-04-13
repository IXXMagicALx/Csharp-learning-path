using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson8
{
    internal class Program
    {
        #region 函数声明
        static void ChangeValue(int value)
        {
            value = 3;//修改不了a0的值,a0还是1 
        }
        /*ref*******************************************/
        static void ChangeValueRef(ref int value)
        {
            value = 3;//能修改a1的值,a1变成3，也可以不修改 
        }
        /*out*******************************************/
        static void ChangeValueOut(out int value)
        {
            value = 3;//能修改a1的值,a1变成3 
        }
        /**********************************************/
        static void ChangeArrayValue(int[] array)
        {
            array[0] = 9;//能修改arr0[0]的值
        }
        /**********************************************/
        static void ChangeArray(int[] array)
        {
            array = new int [] { 99, 88, 77 };//修改不了arr1[0]的值
        }
        /*ref*******************************************/
        static void ChangeArrayRef( ref int[] array)
        {
            array = new int[] { 99, 88, 77 };//能修改arr2[0]的值,arr2[0]的值，变为99|也可以不修改
        }
        /*out*******************************************/
        static void ChangeArrayOut(out int[] array)
        {
            array = new int[] { 99, 88, 77 };//能修改arr2[0]的值,arr2[0]的值，变为99
        }
        static bool Judge(string userName, string passWord, ref string info)
        {
            if (userName=="ixxmagicalx")
            {
                //先判断用户名
                //正确再判断密码
                if (passWord=="VS_123")
                {
                    //密码正确，成功登录
                    info = "密码正确，成功登录";
                    return true;
                }
                else
                {
                    //密码错误，无法登录
                    info = "密码错误，无法登录";
                    return false;
                }
            }
            else
            {
                //用户名错误，无法登录
                info = "用户名错误，无法登录";
                return false;
            }
        } 
        #endregion
        static void Main(string[] args)
        {
            #region 知识点
            Console.WriteLine("ref和out");
            /**********************************************/
            int a0 = 1;
            ChangeValue(a0);
            Console.WriteLine(a0);
            /*ref*******************************************/
            int a1 = 1;//ref需要初始化
            ChangeValueRef(ref a1);
            Console.WriteLine(a1);
            /*out******************************************/
            int a2;//out不需要初始化
            ChangeValueOut(out a2);
            Console.WriteLine(a2);
            /**********************************************/
            int[] arr0 = { 1, 2, 3 };
            ChangeArrayValue(arr0);
            Console.WriteLine("*********************************");
            Console.WriteLine(arr0[0]);//输出9
            /**********************************************/
            int[] arr1 = { 4, 5, 6 };
            ChangeArray(arr1);
            Console.WriteLine("*********************************");
            Console.WriteLine(arr1[0]);//输出4
            /*ref******************************************/
            int[] arr2 = { 4, 5, 6 };
            ChangeArrayRef(ref arr2);
            Console.WriteLine(arr2[0]);//输出99
            /*out******************************************/
            int[] arr3;//out不需要初始化
            ChangeArrayOut(out arr3);
            Console.WriteLine(arr3[0]);//输出99
            /**********************************************/
            //ref与out的区别
            //ref 传入的参数必须进行变量初始化，在函数中可以改变变量的值也可以不改变变量的值
            //out 可以不进行变量初始化，但是无论是否进行了初始化都必须在函数中为变量赋值
            #endregion
            #region 
            string info = "",userName = "",passWord = "";
            while(!Judge(userName, passWord, ref info))
            {
            Console.WriteLine("*********************************");
            Console.WriteLine("请输入用户名：");
            userName = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            passWord = Console.ReadLine();
            Judge(userName, passWord, ref info);
            Console.WriteLine(info);
            }
            #endregion
        }
    }
}
