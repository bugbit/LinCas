using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tests1
{
    class TestSystemsLinearEquations
    {
        static void linsolve<T>(Expression<T> argExpr)
        {

        }
        static void linsolve(LambdaExpression argExpr)
        {

        }
        static void linsolve(Expression<Func<decimal, bool>> argExpr)
        {

        }
        static void Main(string[] args)
        {
            //linsolve(x => x == 1);

            Expression<Func<decimal, bool>> e = x => x == 1;

            linsolve(e);
            linsolve<Func<decimal, bool>>(x => x == 1);

            Func<decimal, decimal, decimal, bool> pList1 =
                (x, y, z) => x + y + z == 20m;
            Func<decimal, decimal, decimal, bool[]> pList2 =
                (x, y, z) => new[]
                {
                    x + y + z == 20m,
                    x+2*y-5*z==100m,
                    3*x+100*y+200*z==900m
                };
        }
    }
}
