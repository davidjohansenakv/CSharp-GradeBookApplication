using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RangedGradeBook : BaseGradeBook
    {
        public RangedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked; 
        }

    }
}
