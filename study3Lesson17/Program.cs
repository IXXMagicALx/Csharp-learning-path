namespace Lesson17
{
    interface IRegister
    {
        void Register();
    }
    class Person:IRegister
    {
        public void Register()
        {
            Console.WriteLine("派出所登记");
        }
    }
    class Car:IRegister
    {
        public void Register()
        {
            Console.WriteLine("车管所登记");
        }
    }
    class House:IRegister
    {
        public void Register()
        {
            Console.WriteLine("房管局登记");
        }
    }
    interface IFly
    {

    }
    interface ISwim
    {

    }
    interface IWalk
    {

    }
    abstract class Bird:IWalk
    {

    }
    class MaQue:Bird,IFly
    {

    }
    class TuoNiao:Bird
    {

    }
    class Penguin:Bird,ISwim
    {

    }
    class Parrot:Bird,IFly
    {

    }
    class Chopper:IFly
    {

    }
    class Swan:Bird,ISwim,IFly
    {

    }
    interface IInputFile
    {

    }
    interface IOutputFile
    {

    }
    class ExternalHardDrive : IInputFile, IOutputFile
    {

    }
    class UFlashDrive : IInputFile, IOutputFile
    {

    }
    class MP3: IInputFile
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("接口");
            IRegister p = new Person();
            IRegister c = new Car();
            IRegister h = new House();
        }
    }
}
