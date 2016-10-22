using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Six.Sorting
{
    //For description of problem, see https://codility.com/programmers/task/triangle/
    public class TriangleComputer
    {
        public static int Compute(int[] A)
        {
            if (A.Length < 3)
            {
                return 0;
            }

            bool arrayHasTriangle = false;

            for (int i=0; i< A.Length - 2; i++)
            {
                for (int j=i + 1; j< A.Length - 1; j++)
                {
                    for (int k = j + 1; k < A.Length; k++)
                    {
                        Triangle t = new Triangle(A[i], A[j], A[k]);
                        arrayHasTriangle = t.IsTriangle();

                        if (arrayHasTriangle)
                            break;
                    }

                    if (arrayHasTriangle)
                        break;
                }

                if (arrayHasTriangle)
                    break;
            }

            return arrayHasTriangle ? 1 : 0;
        }

    }

    public class Triangle
    {
        private int _a;
        private int _b;
        private int _c;

        public int A { get { return _a; } }
        public int B { get { return _b; } }
        public int C { get { return _c; } }

        public Triangle(int a, int b, int c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        public bool IsTriangle()
        {
            return A + B > C && A + C > B && B + C > A;
        }
    }
}
