using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public GradeBookType Type = Enums.GradeBookType.Standard;

        public StandardGradeBook(string name) : base(name)
        {
            
        }
    }
}
