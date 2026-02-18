using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP02
{
    internal class HireDate
    {
        #region propartey
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; } 
        #endregion

        #region Constructor
        public HireDate(int day, int month, int year)
        {
            if (isValidate(day, month, year))
            {
                Day = day;
                Month = month;
                Year = year;
            }
            else
            {
                Console.WriteLine("Invalid Date :(");
            }

        }
        #endregion

        #region IsValidate
        private bool isValidate(int day, int month, int year)
        {
            return
            DateTime.TryParse($"{year}-{month}-{day}", out _);

        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return
                $"{Day:D2}/{Month:D2}/{Year}";

        }
        #endregion

        #region ToDateTime
        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        } 
        #endregion

    }
}
