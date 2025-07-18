namespace AssignmentOOP_1
{
    internal class Program
    {

        enum WeekDays
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday

        }
        enum Season
        {
          None,  Spring,Summer, Autumn, Winter
        }

        [Flags]
        enum permission
        {
            Read=1, write=2, Delete=4, Execute=8
        }
        static void Main(string[] args)
        {
            #region Q1

            //for (int i = 0; i < 7; i++)
            //{
            //    WeekDays wd = (WeekDays)i;
            //    Console.WriteLine(wd);
            //}
            #endregion

            #region Q2
            //Console.WriteLine("Enter Season Name : ");
            //try
            //{
            //    Season season = (Season)Enum.Parse(typeof(Season), Console.ReadLine(), true);
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("march to may");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("june to august");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("December to February)");
            //            break;
            //    }
            //}
            //catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            #endregion

            #region Q4
            permission p = (permission)13;
            Console.WriteLine(p);
            #endregion
        }
    }
}
