using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
     public class utils
      {
          public static string GetStudNumber(int year, int group, string fio)
          {
              var fullName = fio.Split(' ');
              return $"{year.ToString()}_{group.ToString()}_{fullName[0]} {fullName[1].Substring(0, 1)}.{fullName[2].Substring(0, 1)}.";
          }
        public class Students
        {
            public int group;
            public int year;
            public string fio;
        }
    }
    
    
    }

