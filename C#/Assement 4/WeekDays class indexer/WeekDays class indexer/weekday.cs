using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekDays_class_indexer
{
     class weekday
    {
        private string[] days = new string[]
        {

             "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"     
        };  
        public string this[int index] 
        {
            get { 
            if(index >= 0 && index <= days.Length)
                {
                    return days[index];
                }

                else
                {

                    return "Invalid day index";
                }
            }
        
        }
    }
}
