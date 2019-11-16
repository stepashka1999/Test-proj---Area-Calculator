using System;

namespace AreaCalculator
{
    public static class Calculator
    {
        public static float AreaOfCircl(float radius)
        {
            return MathF.PI * MathF.Pow(radius, 2);
        }

        public static float PerimeterOfCircl(float radius)
        {
            return MathF.PI * 2 * radius;
        }

        public static float AreaOfTriangle(float a, float b = 0, float c = 0)
        {
            IsTriangle(a, b, c);

            var semiPerimetr = PerimetrOfTriangle(a, b, c) / 2;

            var dA = semiPerimetr - a;
            var dB = semiPerimetr - b;
            var dC = semiPerimetr - c;

            var res = MathF.Sqrt(semiPerimetr * dA * dB * dC);

            return res;
        }

        public static float PerimetrOfTriangle(float a, float b, float c)
        {
            IsTriangle(a, b, c);

            if (b == 0 && c == 0) b = c = a; // Треугольник равносторонний
            else if (c == 0) b = a; // Треугольник прямоугольный

            return ( a + b + c );
        }

        public static bool TriangleIsRectangular(float a, float b, float c)
        {
            IsTriangle(a, b, c);

            if (a*a + b*b == c*c || a*a + c*c == b*b || b*b + c*c == a*a) return true;
            else return false;
        }

        public static bool TriangleIsEquilateral(float a, float b, float c)
        {
            IsTriangle(a, b, c);

            if (a == b && b == c ) return true;
            else return false;
        }

        static void IsTriangle(float a, float b, float c)
        {
            if ((a + b < c) || (a + c < b) || (c + b < a)) throw new Exception("Треугольника с данными сторонами не существует!");
        }

    }
}
