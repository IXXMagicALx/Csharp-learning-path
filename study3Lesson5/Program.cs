using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Lesson5
{
    class Student
    {
        public string name;
        public bool sex; //True为男 false为女
        private int age;
        private int cSG;
        private int uG;
        private int sum;
        private int avg;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0 && value < 150)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("外星人入侵了？");
                }

            }
        }
        public int CGrade
        {
            get
            {
                return cSG;
            }
            set
            {
                if (value <= 100 && value >= 0)
                {
                    cSG = value;
                }
            }
        }
        public int UGrade
        {
            get
            {
                return uG;
            }
            set
            {
                if (value <= 100 && value >= 0)
                {
                    uG = value;
                }
            }
        }
        public void Speak()
        {
            Console.WriteLine("我叫{0}，今年{1}岁了，是{2}同学,我的两科总分是{3},平均分是{4}。",name,age,sex?"男":"女",sum,avg); 
        }
        public void Calc()
        {
             sum = cSG + uG;
             avg = sum / 2;
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("成员属性");
                Student s1 = new Student();
                Student s2 = new Student();
            s1.name = "小米";
            s2.name = "小鹏";
            s1.sex = true;
            s2.sex = false;
            s1.Age = 20;
            s2.Age = 18;
            s1.CGrade = 66;
            s2.CGrade = 99;
            s1.UGrade = 88;
            s2.UGrade = 55;
            s1.Calc();
            s2.Calc();
            s1.Speak();
            s2.Speak();

            }
        }
    
}
