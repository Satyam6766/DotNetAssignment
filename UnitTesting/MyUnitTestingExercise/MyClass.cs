using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnitTestingExercise
{
    public class MyClass
    {

        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Sub(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Mul(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Div(double num1, double num2)
        {
            return num1 / num2;
        }
        public bool IsEqual(double num1, double num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string AccDebit(double withDrawalAmount)
        {
            string response;
            double accBal = 100000;
            if (withDrawalAmount > accBal)
            {
                response = "Insufficient funds in your account.";
                }
            else
            {
                accBal = accBal - withDrawalAmount;
                accBal -= withDrawalAmount;

                response="Collect Cash" + "And available balance in your account is:" + accBal + ".";
            }
            return response;
        }

    }
}
