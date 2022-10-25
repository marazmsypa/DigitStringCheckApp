using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCheckLibrary
{
    public class StringCheck
    {
        /// <summary>
        /// метод составления листа из всех цифр в строке без повторений, сортированный по убыванию и включающий цифры не более 5
        /// </summary>
        
        public List<char> GetDigit(string textString)
        {
            List<char> digitList = new List<char>();
            foreach (char stringChar in textString)
            {
                if (!digitList.Contains(stringChar) && Char.IsDigit(stringChar) && Regex.IsMatch(stringChar.ToString(), @"[6-9]"))
                {                    
                    digitList.Add(stringChar);                
                }
            }
            var orederedDigitList = from l in digitList
                                    orderby l descending
                                      select l;
            digitList = orederedDigitList.ToList();
            return digitList;
        }
    }
}
