using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndependentProject;

namespace All_Topics_of_C_Sharp.OOPS
{
    public static class ExtensionMethod
    {
        public static void NewExtensionMethod(this IndependentProjectClass obj)
        {

        }
        public static void SealedClassExtensionMethod(this DontInherit obj)
        {
            Console.WriteLine();
        }
    }

    public class UseOfExtensionMethod
    {
        public void Test()
        {
            IndependentProjectClass obj = new IndependentProjectClass();
            obj.NewExtensionMethod();

            DontInherit objIn = new DontInherit();
            objIn.SealedClassExtensionMethod();
        }
    }
    public sealed class DontInherit
    {
        public void SealedClassMethod()
        {

        }
    }


}
