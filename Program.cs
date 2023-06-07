using System;
namespace Type_Conversion
{
    public static class Implicity_Class
    {
        public static void Implicity()
        {
            Console.WriteLine("convert to method");
            Console.WriteLine("-----------------");

            Console.WriteLine("Implicity :" + "\n");

            Console.WriteLine("char to int");
            char A = '2';
            int num = Convert.ToInt32(A);
            Console.WriteLine(num + "\n");


            Console.WriteLine("int to long");
            int B = 100;
            long num1 = Convert.ToInt64(B);
            Console.WriteLine(num1 + "\n");


            Console.WriteLine("long to float");
            long C = 100000;
            float num2 = Convert.ToSingle(C);
            Console.WriteLine(num2 + "\n");

            Console.WriteLine("float to double");
            float D = 2.4F;
            double num3 = Convert.ToDouble(D);
            Console.WriteLine(num3 + "\n");


            Console.WriteLine("int to boolean");
            int E = 0;
            int F = 1;
            bool num4 = Convert.ToBoolean(E);
            bool num5 = Convert.ToBoolean(F);
            Console.WriteLine(num4 + "\n" + num5 + "\n");


            Console.WriteLine("char to bytes");
            char G = 's';
            byte num6 = Convert.ToByte(G);
            Console.WriteLine(num6);


            Console.WriteLine("\n");


        }
        public static void EXplicity()
        {
            Console.WriteLine("EXplicity :" + "\n");
            Console.WriteLine("----------");

            Console.WriteLine("double to float");
            double A = 3.14159;
            float num1 = Convert.ToSingle(A);
            Console.WriteLine(num1 + "\n");


            Console.WriteLine("float to long");
            float B = 2.4F;
            long num2 = Convert.ToInt64(B);
            Console.WriteLine(num2 + "\n");


            Console.WriteLine("long to int");
            long C = 99999999;
            int num3 = Convert.ToInt32(C);
            Console.WriteLine(num3 + "\n");


            Console.WriteLine("int to char");
            int D = 100;
            char num4 = Convert.ToChar(D);
            Console.WriteLine(num4 + "\n");


        }
        public static void Assinging_Type()
        {
            Console.WriteLine("Assinging_Type");
            Console.WriteLine("--------------");

            // Implicit conversion from byte to int
            Console.WriteLine("byte to int");
            byte A = 10;
            int num1 = A;
            Console.WriteLine(num1 + "\n");


            // Implicit conversion from int to double
            Console.WriteLine("int to double");
            int B = 5;
            double num2 = B;
            Console.WriteLine(num2 + "\n");


            // Implicit conversion from float to double
            Console.WriteLine("float to double");
            float C = 3.14f;
            double num3 = C;
            Console.WriteLine(num3 + "\n");


            // Implicit conversion from int to decimal
            Console.WriteLine("int to decimal");
            int D = 10;
            decimal num4 = D;
            Console.WriteLine(num4 + "\n");


            // Implicit conversion from char to int
            Console.WriteLine("char to int");
            char E = 'A';
            int num5 = E;
            Console.WriteLine(num5 + "\n");



            Console.WriteLine("Try parse conversion" + "\n");
            Console.WriteLine("--------------------");

            string strNumber = "123";
            int number;
            bool success = int.TryParse(strNumber, out number);

            if (success)
            {
                Console.WriteLine("Conversion successful. Number: " + number);
            }
            else
            {
                Console.WriteLine("Conversion failed.");

            }


            string strValue = "3.14";
            double value;
            bool success1 = double.TryParse(strValue, out value);

            if (success1)
            {
                Console.WriteLine("Conversion successful. Value: " + value);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }



           



            Console.WriteLine("paranthesis method" + "\n");

            // cast double to int.

            Console.WriteLine("double to int");
            double d = 5673.74;
            int i;
            i = (int)d;
            Console.WriteLine(i + "\n");


            Console.WriteLine("double to float");
            double A1 = 3.14159;
            float num6 = (float)(A1);
            Console.WriteLine(num6 + "\n");


            Console.WriteLine("float to long");
            float B1 = 2.4F;
            long num7 = (long)(B1);
            Console.WriteLine(num7 + "\n");



            Console.WriteLine("long to int");
            long C1 = 99999999;
            int num8 = (int)(C1);
            Console.WriteLine(num8 + "\n");



            Console.WriteLine("int to char");
            int D1 = 100;
            char num9 = Convert.ToChar(D1);
            Console.WriteLine(num9 + "\n");



        }

    }

    public class main
    {
        public static void Main(string[] args)
        {
            Implicity_Class.Implicity();
            Implicity_Class.EXplicity();
            Implicity_Class.Assinging_Type();
        }

    }
}