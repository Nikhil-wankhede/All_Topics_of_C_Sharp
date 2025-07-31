using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp.OOPS
{
    internal class AccessModifiers
    {
        private void GetPassword()
        {

        }
        public void CheckPassword()
        {
            GetPassword();
            GetLimitedAccess();
        }

        protected void GetLimitedAccess()
        {

        }
    }
    class CheckModifiers : AccessModifiers
    {
        public CheckModifiers()
        {
            AccessModifiers obj = new AccessModifiers();
            obj.CheckPassword();
            //obj.GetLimitedAccess();          // Not Allowed because of protected keyword in the method  



            //Call only in case of Inheritance
            GetLimitedAccess();

        }
    }
}
