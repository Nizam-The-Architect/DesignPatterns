using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Visitor
{
    public interface ILoanVerifier
    {
        void VerifySalary();
        void VerifyAddress();
    }
    public class PersonalLoanVerifier
}
