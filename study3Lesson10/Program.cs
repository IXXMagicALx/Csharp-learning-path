using System.Runtime.InteropServices;

namespace Lesson10
{
    class Point
    {
        public int x;
        public int y;

        public static Point operator +(Point p1, Point p2)
        {
            Point p = new Point();//新建对象
            p.x = p1.x + p2.x;
            p.y = p1.y + p2.y;
            return p;
        }
        public static Point operator +(Point p1, int value)//注意顺序
        {
            Point p = new Point();//新建对象
            p.x = p1.x + value;
            p.y = p1.y + value;
            return p;
        }
    }
    struct Position
    {
        public int x;
        public int y;
        public Position(int x,int y)//构造函数
        {
            this.x = x;
            this.y = y;
        }
        public static bool operator ==(Position p1, Position p2)
        {
            if(p1.x == p2.x && p1.y == p2.y)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Position p1, Position p2)
        {
            if (p1.x != p2.x && p1.y != p2.y)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
    class Vector3
    {
        public int x;
        public int y;
        public int z;
        public Vector3(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }
        
        public static Vector3 operator +(Vector3 v1,Vector3 v2)
        {
            return new Vector3(v1.x + v2.x , v1.y + v2.y , v1.z + v2.z);
        }
        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x - v2.x , v1.y - v2.y , v1.z - v2.z);
        }
        public static Vector3 operator *(Vector3 v1, int num)
        {
            return new Vector3(v1.x * num , v1.y * num , v1.z * num );
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Point p1 = new Point();
            //p1.x = 1;
            //p1.y = 1;
            //Point p2 = new Point();
            //p2.x = 2;
            //p2.y = 2;
            //Point p3 = p1 + p2;
            //Point p4 = p1 + 5;
            //Console.WriteLine("p3的坐标是({0},{0})", p3.x, p3.y);
            //Console.WriteLine("p4的坐标是({0},{0})", p4.x, p4.y);
            #endregion
            Position p1 = new Position(2 , 2);
            Position p2 = new Position(2 , 2);
            Console.WriteLine("坐标是否相等：{0}",p1 == p2?"相等":"不相等");
            Vector3 v1 = new Vector3(8,8,8);
            Vector3 v2 = new Vector3(3,3,3);
            Vector3 v3 = v1 + v2;
            Vector3 v4 = v1 - v2;
            Vector3 v5 = v1*8;
            Console.WriteLine("加运算结果是({0},{1},{1})", v3.x, v3.y, v3.z);
            Console.WriteLine("减运算结果是({0},{1},{1})", v4.x, v4.y, v4.z);
            Console.WriteLine("乘运算结果是({0},{1},{1})", v5.x, v5.y, v5.z);
        }
    }
}
