//namespace Behavioral.Visitor
//{
//    /*
//     Scenario:
//    public interface ILoanVerifier
//    {
//        void VerifyLoan();
//    }
//    public class PersonalLoanVerifier : ILoanVerifier
//    {
//        public void VerifyLoan() => Console.WriteLine("Personal loan verifying mechanism called");
//    }
//    public class HomeLoanVerifier : ILoanVerifier
//    {
//        public void VerifyLoan() => Console.WriteLine("Home loan verifying mechanism called");
//    }
//    public class BusinessLoanVerifier : ILoanVerifier
//    {
//        public void VerifyLoan() => Console.WriteLine("Business loan verifying mechanism called");
//    }
//    This is the structure we're having, what if we want to 
//     */
//    public class LoanVerifier
//    {

//    }
//    public interface IVisitor
//    {
//        string Visit(ILoanVerifier loanVerifier);
//    }
   
//    public interface ILoanVerifier
//    {
//        string VerifyLoan();
//        string Accpet(IVisitor visitor);
//    }
//    public class PersonalLoanVisitor : IVisitor
//    {
//        private ILoanVerifier? _loanVerifier;
//        public string Visit(ILoanVerifier loanVerifier)
//        {
//            _loanVerifier = loanVerifier;
//            return ($"Personal loan visitor called with object type {_loanVerifier.GetType().Name}");
//        }
//    }
//    public class HomeLoanVisitor : IVisitor
//    {
//        public string Visit(ILoanVerifier loanVerifier) => ("Home loan visitor called");
//    }
//    public class BusinessLoanVisitor : IVisitor
//    {
//        public string Visit(ILoanVerifier loanVerifier) => ("Business loan visitor called");

//    }
//    public class PersonalLoanVerifier : ILoanVerifier
//    {
//        public string Accpet(IVisitor visitor)
//        {
//          return  visitor.Visit(this);
//        }

//        public string VerifyLoan() => ("Personal loan verifying mechanism called");
//    }
//    //public class HomeLoanVerifier : ILoanVerifier
//    //{
//    //    public void VerifyLoan() => Console.WriteLine("Home loan verifying mechanism called");
//    //}
//    //public class BusinessLoanVerifier : ILoanVerifier
//    //{
//    //    public void VerifyLoan() => Console.WriteLine("Business loan verifying mechanism called");
//    //}


//}