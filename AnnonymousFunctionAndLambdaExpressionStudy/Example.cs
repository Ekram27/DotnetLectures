using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonymousFunctionAndLambdaExpressionStudy
{
    public delegate void MyDelegate(string Data);
    
    internal class Example
    {
        //public static void ShowData(string Data)
        //{
        //    Console.WriteLine(Data);

        //}
        public MyDelegate ObjMyDelegate = delegate (string Data)
        {
            Console.WriteLine(Data);
        };
        public Action<string> ObjMyActionDelegate = delegate (string Data)
        {
            Console.WriteLine(Data);
        };

        //Lambda expression 

        public Action<string> ObjMyActionLambda =  (Data)=> // => called lambda expression
        {
            Console.WriteLine(Data);
        };




    }

}
