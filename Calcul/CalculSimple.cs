using System.ComponentModel.Design;
using System;

namespace Calculatrice.Calcul
{
    public class CalculSimple
    {
        public static int Calcul(string operation, int a, int b)
        {
            switch (operation)
            {
                case "+":
                    return a + b;
                    break;
                
                case "-":
                    return a - b;
                    break;
                
                case "*":
                    return a * b;
                    break;
                
                case "/":
                    return a / b;
                    break;
                default:
                    return 0000000;
                    break;
            }
        }
    }
}