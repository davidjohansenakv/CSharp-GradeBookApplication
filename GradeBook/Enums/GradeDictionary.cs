using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.Enums
{
    public class GradeDictionary
    {
        Dictionary<int, char> gradeSwitcher = new Dictionary<int, char>
        {
            {5, 'A' },
            {4, 'B' },
            {3, 'C' },
            {2, 'D' },
            {1, 'F' }
        }; 
        public Dictionary<int, char> GradeSwitcher { get; }

        public GradeDictionary()
        {
            GradeSwitcher = gradeSwitcher; 
        }
    }
}
