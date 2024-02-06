using System;
using System Collections.Generic;
using System.Linq;

namespace Workshop_2 {
    internal class Program {
        static void Main(string[] args) {
            temperatureConverter tc = new temperatureConverter();
            double c_temp = (tc.F - 32) * (5.0 / 9.0);
            double f_temp = (tc.F * 9.0 / 5.0) + 32;
            Console.WriteLine($"Celsius = {tc.C} and Farenheir = {tc.CtoF}");
            double value = CalculateAbsoluteDifference(2, 12);
            Console.WriteLine($"The result is: {value}");
            Console.ReadKey();
        }

        public static double CalculateAbsoluteDifference (double num1, double num2) {
            if (num1 > num2) {
                double result = 2 * (Math.Abs(num1 - num2));
                return result;
            }
        }
    }
}

public class temperatureConverter {
    private double _C = 0.0;
    private double _F = 32.0;

    public double C {
        get {
            return _C;
        } set {
            _C = value;
        }
    }

    public double F {
        get {
            return _F;
        } set {
            _F = value;
        }
    }

    public double CtoF {
        get {
            return (_C * 9.0 / 5.0) + 32;
        }
    }
}

