using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05Ex03
{
    enum orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }
    struct route
    {
        public orientation direction;
        public double distance;
    }

    class Program
    {
        static void Main(string[] args)
        {

            /*Ch05Ex01
             * 
            short shortResult, shortVal = 4;
            int integerVal = 67;
            long longResult;
            float floatVal = 10.5F;
            double doubleResult, doubleVal = 99.999;
            string stringResult, stringVal = "17";
            bool boolVal = true;
            Console.WriteLine("Variable Conversion Examples\n");
            doubleResult = floatVal * shortVal;
            Console.WriteLine("Implicit, -> double: {0} * {1} -> {2}", floatVal,
            shortVal, doubleResult);
            shortResult = (short)floatVal;
            Console.WriteLine("Explicit, -> short: {0} -> {1}", floatVal,
            shortResult);
            stringResult = Convert.ToString(boolVal) +
            Convert.ToString(doubleVal);
            Console.WriteLine("Explicit, -> string: \"{0}\" + \"{1}\" -> {2}",
            boolVal, doubleVal, stringResult);
            longResult = integerVal + Convert.ToInt64(stringVal);
            Console.WriteLine("Mixed, -> long: {0} + {1} -> {2}",
                integerVal, stringVal, longResult);
            Console.ReadKey();
             */

            route myRoute;
            int myDirection = -1;
            double myDistance;
            Console.WriteLine("1) North\n2) South\n3) East\n4) West");
            do
            {
                Console.WriteLine("Select a direction:");
                myDirection = Convert.ToInt32(Console.ReadLine());
            }
            while ((myDirection < 1) || (myDirection > 4));
            Console.WriteLine("Input a distance:");
            myDistance = Convert.ToDouble(Console.ReadLine());
            myRoute.direction = (orientation)myDirection;
            myRoute.distance = myDistance;
            Console.WriteLine("myRoute specifies a direction of {0} and a " +
            "distance of {1}", myRoute.direction, myRoute.distance);
            Console.ReadKey();
        }
    }
}
