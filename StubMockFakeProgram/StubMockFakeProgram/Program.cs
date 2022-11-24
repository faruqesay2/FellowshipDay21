using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace StubMockFake
{
    class MyException : ApplicationException
    {
        public void MyExceptiona()
        {
            MessageBox.Show("An exception occured");
        }
        public void MyDivideException()
        {
            MessageBox.Show("Exception occured, divisor should not be zero");
        }
    }

    class TestMyException
    {
        public static void Main(String[] arg)
        {
            int d, div, res;
            div = Int32.Parse(Console.ReadLine());
            d = Int32.Parse(Console.ReadLine());
            try
            {
                if (div == 0)
                {
                    throw new MyException();
                }
            }
            catch (MyException e)
            {
                e.MyDivideException();
            }

            res = d / div;
            Console.WriteLine("Result:{0}", res);
        }
    }
}