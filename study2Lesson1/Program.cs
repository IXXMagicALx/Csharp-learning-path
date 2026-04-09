namespace Lesson1
{
    //在这里声明枚举
    #region 申明枚举
    enum E_monsterType
    {
        Normal,//0
        Boss,//1
    }

    enum E_playerType
    {
        Main = 100,
        Other,//101
    }
    #region 1题枚举
    /// <summary>
    /// QQ状态
    /// </summary>
    enum E_QQstate
    {
        /// <summary>
        /// 离线
        /// </summary>
        off_Line = 0,//离线
        /// <summary>
        /// 在线
        /// </summary>
        on_Line,//在线
        /// <summary>
        /// 忙碌
        /// </summary>
        Busy,//忙碌
        /// <summary>
        /// 勿扰
        /// </summary>
        N_Disturb,//勿扰

    }
    #endregion
    #region 2题枚举
    enum E_coffeeType
    {
        /// <summary>
        /// 中杯
        /// </summary>
        M = 4,
        /// <summary>
        /// 大杯
        /// </summary>
        L,
        /// <summary>
        /// 超大杯
        /// </summary>
        XL,
    }
    #endregion
    #region 3题枚举
    enum E_sex//角色性别
    {
        man = 1,
        woman = 0,
    }
    enum E_role//角色职业
    {
        warrior = 2,
        hunter,
        rabbi,
    }
    #endregion
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("枚举");
            #region 课
            //#region 申明枚举变量
            //E_playerType playerType = E_playerType.Main;
            //E_monsterType monsterType = E_monsterType.Boss;
            //switch (monsterType)
            //{
            //    case E_monsterType.Normal:
            //        Console.WriteLine("普通怪逻辑");
            //        break;
            //    case E_monsterType.Boss:
            //        Console.WriteLine("Boss逻辑");
            //        break;
            //}
            //#endregion
            //#region 枚举的类型转换
            ////枚举转int用括号强转
            //int i = (int)playerType;
            ////int转枚举 直接转但不常用
            //monsterType = 0;//转换的必须是已经申明了的 如0对应的是monsterType里的Normal

            ////难
            ////string转枚举 用Parse
            ////.Parse部分 Enum为目标类型 typeof(E_playerType),"Other"是要转换的字符串
            ////前边括号强转部分 把Enum这个通用类型转换成E_playerType
            //playerType = (E_playerType)Enum.Parse(typeof(E_playerType), "Other");
            //Console.WriteLine(playerType);
            ////枚举转string 打印出的是枚举项的名字
            //string str = monsterType.ToString();
            //Console.WriteLine(str);
            //#endregion
            #endregion
            #region 1.
            //try
            //{
            //    Console.WriteLine("请选择一个在线状态（0=离线，1=在线，2=忙碌，3=勿扰）");
            //    int modeSelect = (Console.ReadKey().KeyChar) - '0';//检测输入字符并隐式转换成整型
            //    Console.WriteLine("");
            //    E_QQstate QQstate = E_QQstate.off_Line;//申明枚举变量

            //    QQstate = (E_QQstate)modeSelect;//括号强转将输入转为枚举
            //    switch (QQstate)
            //    {
            //        case E_QQstate.off_Line:
            //            Console.WriteLine("你当前处于离线模式");
            //            break;
            //        case E_QQstate.on_Line:
            //            Console.WriteLine("你当前处于在线模式");
            //            break;
            //        case E_QQstate.Busy:
            //            Console.WriteLine("你当前处于忙碌状态");
            //            break;
            //        case E_QQstate.N_Disturb:
            //            Console.WriteLine("你当前处于免打扰模式");
            //            break;
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("请输入一个数字");
            //}
            #endregion
            #region 2.
            //Console.WriteLine("咖啡有4=中杯（35元），5=大杯（40元），6=超大杯（43元）。");
            //Console.WriteLine("您想购买哪个");
            //E_coffeeType coffeeType = E_coffeeType.M;
            //int cS = (Console.ReadKey().KeyChar) - '0';//检测输入
            //Console.WriteLine("");//换行
            //coffeeType =(E_coffeeType) cS;
            //switch (coffeeType)
            //{
            //    case E_coffeeType.M:
            //        Console.WriteLine("您购买的是中杯，花费35元");
            //        break;
            //    case E_coffeeType.L:
            //        Console.WriteLine("您购买的是大杯，花费40元");
            //        break;
            //    case E_coffeeType.XL:
            //        Console.WriteLine("您购买的是超大杯，花费43元");
            //        break;
            //}
            #endregion
            #region 3.
            try
            {
                string Sex="", Role="", skill="";//申明变量
                int atk = 0, def = 0;
                E_sex sex = E_sex.man;//申明性别枚举变量
                E_role role = E_role.warrior;//申明职业枚举变量
                Console.WriteLine("请选择性别:(1=男，0=女)");
                int sS = (Console.ReadKey().KeyChar)-'0';
                Console.WriteLine("");//换行
                sex = (E_sex)sS;
                switch (sex)
                {
                    case E_sex.man:
                        Sex = "男性";
                        atk = 50;
                        def = 100;
                        break;
                    case E_sex.woman:
                        Sex = "女性";
                        atk = 150;
                        def = 20;
                        break;
                }
                Console.WriteLine("请选择职业：（2=战士，3=猎人，4=法师）");
                int rS = (Console.ReadKey().KeyChar) - '0';
                Console.WriteLine("");//换行
                role = (E_role)rS;
                switch (role)
                {
                    case E_role.warrior:
                        Role = "战士";
                        atk += 20;
                        def += 100;
                        skill = "冲锋";
                        break;
                    case E_role.hunter:
                        Role = "猎人";
                        atk += 120;
                        def += 30;
                        skill = "假死";
                        break;
                    case E_role.rabbi:
                        Role = "法师";
                        atk += 200;
                        def += 10;
                        skill = "奥术冲击";
                        break;
                }
                Console.WriteLine("你选择了“{0}{1}”，攻击力：{2}，防御力：{3}，职业技能：{4}。",Sex,Role,atk,def,skill);
            }
            catch
            {
                Console.WriteLine("请输入数字");
            }
            
            #endregion
        }
    }
}
