using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

using AntlrCSharp;
using static calcParser;

namespace AntlrCSharp {
    public class FUNCS {
        public Dictionary<string, List<Dictionary<string, int>>> f = new Dictionary<string, List<Dictionary<string, int>>>();
    }

    public class CalcUserVisitor : calcBaseVisitor<object>
    { 
        public Dictionary<string, int> VARS = new Dictionary<string, int>();
        
        // list [0] - dictionary for function params
        // list [1] - dictionary for vars in function
        // public Dictionary<string, List<Dictionary<string, int>>> FUNCS = new Dictionary<string, List<Dictionary<string, int>>>(); 
        public List<FUNCS> funcsList = new List<FUNCS>();


        public void showDictionary() {
            foreach (KeyValuePair<string, int> el in VARS) {
                    Console.WriteLine($"{el.Key} = {el.Value}");
                }
        }

        public override object VisitOneLineProg([NotNull] OneLineProgContext context)
        {
            Console.WriteLine("OneLineProg");
            return Visit(context.state());
        }

        public override object VisitMultLineProg([NotNull] MultLineProgContext context)
        {
            Console.WriteLine("MultLineProg");
            Visit(context.prog());
            return Visit(context.state());
        }

        // State variables
        public override object VisitBaseLine([NotNull] BaseLineContext context)
        {
            return Visit(context.let());
        }
        public override object VisitShow([NotNull] ShowContext context)
        {
            return Visit(context.print());
        }
        public override object VisitExpression([NotNull] ExpressionContext context)
        {
            return Visit(context.expr());
        }
        public override object VisitDefinition([NotNull] DefinitionContext context)
        {
            return Visit(context.def());
        }

        //------Base-Line-(Let)-------------------------------------------------------
        public override object VisitIDeqEXPR([NotNull] IDeqEXPRContext context)
        {
            Console.WriteLine("IDeqEXPR");
            string name = context.ID().GetText();
            int val = int.Parse((string)Visit(context.expr()).ToString());

            VARS.Add(name, val);
            return val;
        }
        
        public override object VisitIDeqID([NotNull] IDeqIDContext context)
        {
            Console.WriteLine("IDeqID");
            string firstVar = context.ID(0).GetText();
            string secondVar = context.ID(1).GetText();
            
            int val = 0;
            if (VARS.ContainsKey(secondVar)) val = VARS[secondVar];
            else Console.Error.WriteLine($"Can`t find {secondVar} value");

            if (VARS.ContainsKey(firstVar)) VARS[firstVar] = val;
            else VARS.Add(firstVar, val);

            return val;
        }

        public override object VisitIDeqINT([NotNull] IDeqINTContext context)
        {
            Console.WriteLine("IDeqINT");
            string name = context.ID().GetText();
            int val = int.Parse(context.INT().GetText());

            if (VARS.ContainsKey(name)) VARS[name] = val;
            else VARS.Add(name, val);

            return val;
        }

        //------Expression--------------------------------------------------------
        public int calcOp(char op, int a, int b) {
            switch (op){
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return a / b;
                default: return 0;
            }
        }

        public override object VisitVarsExpression([NotNull] VarsExpressionContext context)
        {
            Console.WriteLine("VarsExpression");
            // Console.WriteLine(context.INT().GetText());
            if (context.INT(0) != null && context.INT(1) != null)
            {
                int firstVal = int.Parse(context.INT(0).GetText());
                int secondVal = int.Parse(context.INT(1).GetText());
                char op = context.op().GetText()[0];

                return calcOp(op, firstVal, secondVal);
            } else if (context.INT(0) != null && context.ID(0) != null)
            {
                int firstVal = int.Parse(context.INT(0).GetText());
                int secondVal = 1;
                char op = context.op().GetText()[0];

                string var = context.ID(0).GetText();
                if (VARS.ContainsKey(var)) secondVal = VARS[var];
                else Console.Error.WriteLine($"Can`t find {var} value");

                return calcOp(op, firstVal, secondVal);
            } else if (context.ID(0) != null && context.INT(0) != null)
            {
                int firstVal = 0;
                int secondVal = int.Parse(context.INT(0).GetText());
                char op = context.op().GetText()[0];

                string var = context.ID(0).GetText();
                if (VARS.ContainsKey(var)) firstVal = VARS[var];
                else Console.Error.WriteLine($"Can`t find {var} value");

                return calcOp(op, firstVal, secondVal);
            } else // if (context.ID(0) != null && context.ID(1) != null)
            {
                int firstVal = 0;
                int secondVal = 1;
                char op = context.op().GetText()[0];

                string firstVar = context.ID(0).GetText();
                string secondVar = context.ID(1).GetText();

                if (VARS.ContainsKey(firstVar)) firstVal = VARS[firstVar];
                else Console.Error.WriteLine($"Can`t find {firstVar} value");

                if (VARS.ContainsKey(firstVar)) secondVal = VARS[secondVar];
                else Console.Error.WriteLine($"Can`t find {secondVar} value");

                return calcOp(op, firstVal, secondVal);
            }
        }

        //------Print--------------------------------------------------------
        public override object VisitPrintIntId([NotNull] PrintIntIdContext context) {
            Console.WriteLine("PrintIntId");
            if (context.INT() != null) 
            {
                Console.WriteLine(context.INT().GetText());
            }
            else {
                // showDictionary();
                string var = (string)context.ID().GetText();

                if (VARS.ContainsKey(var)) Console.WriteLine($"{var} = {VARS[var]}");
                else Console.Error.WriteLine($"Can`t find {var} value");
            }

            return base.VisitPrintIntId(context);
        }
        public override object VisitDef([NotNull] DefContext context)
        {


            return base.VisitDef(context);
        }
    }
}
