using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

using AntlrCSharp;
using static calcParser;

// namespace AntlrCSharp {
//     public class BasicCalcVisitor : calcBaseVisitor<object>
//     {
//         public List<CalcLine> Lines = new List<CalcLine>();

//         public override object VisitLine(calcParser.LineContext context)
//         {
//             NameContext name = context.name();
//             OpinionContext opinion = context.opinion();

//             CalcLine line = new CalcLine() { Person = name.GetText(), Text = opinion.GetText().Trim('"') };
//             Lines.Add(line);

//             return line;
//         }
//     }
// }

namespace AntlrCSharp {
    public class CalcUserVisitor : calcBaseVisitor<object>
    { 
        public List<int> res = new List<int>();
        public override object VisitOneLineProg([NotNull] OneLineProgContext context)
        {
            Console.WriteLine("OneLineProg");
            int val = (int)Visit(context.expr());
            res.Add(val);

            return val;
        }
        public override object VisitMultLineProg([NotNull] MultLineProgContext context)
        {
            Console.WriteLine("MultLineProg");
            Visit(context.prog());
            int val = (int)Visit(context.expr());
            res.Add(val);

            return res;
        }
        public override object VisitParens([NotNull] ParensContext context)
        {
            Console.WriteLine("Parens");
            return Visit(context.expr());
        }

        public override object VisitMulDiv([NotNull] MulDivContext context)
        {
            int left = (int)Visit(context.expr(0));
            int right = (int)Visit(context.expr(1));

            Console.WriteLine($" T <- {left}{context.op.Text}{right}");

            if (context.op.Type == calcParser.MUL) return left * right;
            else return left / right;
        }

        public override object VisitAddSub([NotNull] AddSubContext context)
        {
            int left = (int)Visit(context.expr(0));
            int right = (int)Visit(context.expr(1));

            Console.WriteLine($" T <- {left}{context.op.Text}{right}");

            if (context.op.Type == calcParser.ADD) return left + right;
            else return left - right;
        }

        public override object VisitInt([NotNull] IntContext context)
        {
            return int.Parse(context.INT().GetText());
        }

    }
}
