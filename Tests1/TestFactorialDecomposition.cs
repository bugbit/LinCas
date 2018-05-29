using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests1
{
    class TestFactorialDecomposition
    {
        //private static readonly Expression<Func<int, bool>> mIsPrimeExpr = n =>
        //   {
        //       if (n == 1 || n == 2)
        //           return true;

        //       if ((n % 2) == 0)
        //           return false;

        //       for (int i = 3; i < n; i += 2)
        //           if ((n % i) == 0)
        //               return false;

        //       return true;
        //   };

        static bool IsPrime(int n)
        {
            if (n == 1 || n == 2)
                return true;

            if ((n % 2) == 0)
                return false;

            for (int i = 3; i < n; i += 2)
                if ((n % i) == 0)
                    return false;

            return true;
        }
        static bool IsPrime(long n)
        {
            if (n == 1 || n == 2)
                return true;

            if ((n % 2) == 0)
                return false;

            for (int i = 3; i < n; i += 2)
                if ((n % i) == 0)
                    return false;

            return true;
        }
        static bool IsPrimed(dynamic n)
        {
            if (n == 1 || n == 2)
                return true;

            if ((n % 2) == 0)
                return false;

            for (int i = 3; i < n; i += 2)
                if ((n % i) == 0)
                    return false;

            return true;
        }
        static void Main(string[] args)
        {
            //Expression<Func<int, bool>> pExpr1 = mIsPrimeExpr;
            int n = 11;
            var p1 = IsPrime(n);
            var pd1 = IsPrimed(n);
            long l = 11;
            var p2 = IsPrime(l);
            var pd2 = IsPrimed(l);
        }
    }
}
