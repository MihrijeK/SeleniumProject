using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiIS
{
    class funksione
    {
            static Random rand = new Random();
           

            public static string GetRandomTelNo()
            {
                StringBuilder telNo = new StringBuilder(12);
                int number = 49;
                telNo = telNo.Append("0" + number.ToString());
                telNo = telNo.Append(" ");
                for (int i = 0; i < 3; i++)
                {
                    number = rand.Next(0, 8); // digit between 0 (incl) and 8 (excl)
                    telNo = telNo.Append(number.ToString());
                }
                telNo = telNo.Append(" ");
                number = rand.Next(0, 743); // number between 0 (incl) and 743 (excl)
                telNo = telNo.Append(String.Format("{0:D3}", number));
                return telNo.ToString();
            }

    }
}
