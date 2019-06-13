using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public GradeBookType Type = Enums.GradeBookType.Ranked;

        public RankedGradeBook(string name) : base(name)
        {
            
        }
    }
}