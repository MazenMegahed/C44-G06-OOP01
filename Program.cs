namespace AssignmentOOP_1
{
    internal class Program
    {

        enum WeekDays
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday

        }
        static void Main(string[] args)
        {
            #region Q1

            for (int i = 0; i < 7; i++)
            {
                WeekDays wd = (WeekDays)i;
                Console.WriteLine(wd);
            }
            #endregion
        }
    }
}
