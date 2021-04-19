using System;

namespace DataType
{
    public class ConversionCasting
    {
        int numInt;
        double numDouble;
        float numFloat;

        public void DoubleToFloat(double x)
        {
            numDouble = x;
            numFloat = (float)x;

            Console.WriteLine(numFloat);
        }

        public void FoatToDouble(float x)
        {
            numFloat = x;
            numDouble = (double)x;

            Console.WriteLine(numDouble);
        }

        public void IntToDouble(int x)
        {
            numInt = x;

            numDouble = (double) x;

            Console.WriteLine(numDouble);
        }

        public void IntToFloat(int x)
        {
            numInt = x;

            numFloat = (float)x;

            Console.WriteLine(numFloat);
        }

        public void FloatToInt(float x)
        {
            numFloat = x;

            numInt = (int)x;

            Console.WriteLine(numInt);
        }

        public void DoubleToInt(double x)
        {
            numDouble = x;

            numInt = (int)x;

            Console.WriteLine(numInt);
        }
    }
}
