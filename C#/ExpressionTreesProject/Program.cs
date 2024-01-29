using System;
using System.Linq.Expressions;
using static System.Linq.Expressions.Expression;

namespace ExpressionTreesProject
{
    public class AndAlsoModifier : ExpressionVisitor
    {
        public Expression Modify(Expression expression)
        {
            return Visit(expression);
        }

        protected override Expression VisitBinary(BinaryExpression b)
        {
            if (b.NodeType == ExpressionType.AndAlso)
            {
                Expression left = this.Visit(b.Left);
                Expression right = this.Visit(b.Right);

                // Make this binary expression an OrElse operation instead of an AndAlso operation.  
                return Expression.MakeBinary(ExpressionType.OrElse, left, right, b.IsLiftedToNull, b.Method);
            }

            return base.VisitBinary(b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Expression<Func<string, bool>> expr = name => name.Length > 10 && name.StartsWith("G");
            Console.WriteLine(expr);

            AndAlsoModifier treeModifier = new AndAlsoModifier();
            Expression modifiedExpr = treeModifier.Modify((Expression)expr);

            Console.WriteLine(modifiedExpr);

            /*  This code produces the following output:  

                name => ((name.Length > 10) && name.StartsWith("G"))  
                name => ((name.Length > 10) || name.StartsWith("G"))  
            */

            var companyNames = new[] {
                "Consolidated Messenger", "Alpine Ski House", "Southridge Video",
                "City Power & Light", "Coho Winery", "Wide World Importers",
                "Graphic Design Institute", "Adventure Works", "Humongous Insurance",
                "Woodgrove Bank", "Margie's Travel", "Northwind Traders",
                "Blue Yonder Airlines", "Trey Research", "The Phone Company",
                "Wingtip Toys", "Lucerne Publishing", "Fourth Coffee"
            };

            // We're using an in-memory array as the data source, but the IQueryable could have come
            // from anywhere -- an ORM backed by a database, a web request, or any other LINQ provider.
            IQueryable<string> companyNamesSource = companyNames.AsQueryable();
            var fixedQry = companyNames.OrderBy(x => x).ToArray();
            string sortedString = String.Join("", fixedQry);
            Console.WriteLine(sortedString);

            var length = 1;
            var qry = companyNamesSource
                .Select(x => x.Substring(0, length))
                .Distinct();

            Console.WriteLine(string.Join(",", qry));

            length = 2;
            Console.WriteLine(string.Join(",", qry));

            Console.WriteLine("Sort By Length:");
            bool sortByLength = true;
            if (sortByLength)
            {
                qry = qry.OrderBy(x => x.Length);
                Console.WriteLine(string.Join(",", qry));
            }
        }
    }


}


