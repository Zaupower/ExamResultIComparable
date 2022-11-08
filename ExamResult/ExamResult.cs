using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamResult
{
    public class ExamResult : IComparable<ExamResult>
    {
        int ID;
        string Name;
        Exams exam;
        Score score;
        DateTime date;

        public int CompareTo(ExamResult other)
        {
            throw new NotImplementedException();
        }
    }
}
