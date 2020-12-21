using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBITIPT.TEST1
{
    public class Program
    {
        static void Main()
        {
            // StudentHelperCustomer studentHelper = new StudentHelperCustomer();
            //studentHelper.Insert("Hello2", "World3", "good1@gmail.com13", "4214");

            //StudentHelperBranch studentHelperbranch = new StudentHelperBranch();
            // studentHelperbranch.Insert("Garden1", "Kk1", "near Blueribbon1", "03356985471");

            //StudentHelperProduct studentHelperproduct = new StudentHelperProduct();
            // studentHelperproduct.Insert("Sneakers", "200g", "300rs");

            StudentHelperOrderStatus studentHelperOrderStatus = new StudentHelperOrderStatus();
            studentHelperOrderStatus.Insert("Delivered", 4 , 1050 , 700);


        }

    }

}
