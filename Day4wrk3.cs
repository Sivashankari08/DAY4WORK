using System.IO;
using System;


namespace Day_4
{
    class  MyException:ApplicationException
    {
        public void  MyDivideExecption()
        {
            Console.WriteLine("An Exception Occured");       
        }
        public void MyDivideException()
        {
            Console.Write("Exception Occured,divisor should not be zero");
        }
    }
   class Class4
   {
        public static void Main()
       {
            int x = 5, y =0, z;
            try
            {
                if(y==0)
                {
                    throw new MyException();
                }
            }
            catch(MyException ex)
            {
                ex.MyDivideException();
            }
            Console.ReadLine();
        }
    }
}