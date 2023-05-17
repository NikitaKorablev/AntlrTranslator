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
    public class DICTS {
        public Dictionary<string, int> VARS = new Dictionary<string, int>();
        public int res = 0;
    }

    public class CalcUserVisitor : calcBaseVisitor<object>
    {
        // list [0] - dictionary for function params
        // list [1] - dictionary for vars in function
        public Dictionary<string, DICTS> VarsDict = new Dictionary<string, DICTS>();
        public int nesting = -1;

        public void showDictionary(int i = 0) {
            foreach (KeyValuePair<string, int> el in VarsDict.ElementAt(i).Value.VARS) {
                    Console.WriteLine($"{el.Key} = {el.Value}");
                }
        }
        public void upNest(string name) {
            DICTS d = new DICTS();
            VarsDict.Add(name, d);
            nesting++;
        }
        public void downNest() {
            if (nesting != 0) {
                int res = VarsDict.ElementAt(VarsDict.Count - 1).Value.res;
                string let = VarsDict.ElementAt(VarsDict.Count - 1).Key;
                VarsDict.Remove(let);

                string name = VarsDict.ElementAt(VarsDict.Count - 1).Key;
                VarsDict[name].VARS.Add(let, res);

                nesting--;
            }
        }

        public override object VisitOneLineProg([NotNull] OneLineProgContext context)
        {
            if (VarsDict.Count() == 0) upNest("main");
            // Console.WriteLine("OneLineProg");
            return Visit(context.state());
        }

        public override object VisitMultLineProg([NotNull] MultLineProgContext context)
        {
            // Console.WriteLine("MultLineProg");
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
            // Console.WriteLine("IDeqEXPR");
            string name = context.ID().GetText();
            int val = int.Parse((string)Visit(context.expr()).ToString());

            VarsDict.ElementAt(nesting).Value.VARS.Add(name, val);
            return val;
        }
        
        public override object VisitIDeqID([NotNull] IDeqIDContext context)
        {
            // Console.WriteLine("IDeqID");
            string firstVar = context.ID(0).GetText();
            string secondVar = context.ID(1).GetText();
            
            int val = 0;
            if (VarsDict.ElementAt(nesting).Value.VARS.ContainsKey(secondVar)) val = VarsDict.ElementAt(nesting).Value.VARS[secondVar];
            else Console.Error.WriteLine($"Can`t find {secondVar} value");

            if (VarsDict.ElementAt(nesting).Value.VARS.ContainsKey(firstVar)) VarsDict.ElementAt(nesting).Value.VARS[firstVar] = val;
            else VarsDict.ElementAt(nesting).Value.VARS.Add(firstVar, val);

            return val;
        }

        public override object VisitIDeqINT([NotNull] IDeqINTContext context)
        {
            // Console.WriteLine("IDeqINT");
            string name = context.ID().GetText();
            int val = int.Parse(context.INT().GetText());

            if (VarsDict.ElementAt(nesting).Value.VARS.ContainsKey(name)) VarsDict.ElementAt(nesting).Value.VARS[name] = val;
            else VarsDict.ElementAt(nesting).Value.VARS.Add(name, val);

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
            // Console.WriteLine("VarsExpression");
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
                if (VarsDict.ElementAt(nesting).Value.VARS.ContainsKey(var)) secondVal = VarsDict.ElementAt(nesting).Value.VARS[var];
                else Console.Error.WriteLine($"Can`t find {var} value");

                // Console.WriteLine(firstVal + " " + secondVal);
                return calcOp(op, firstVal, secondVal);
            } 
            // else if (context.ID(0) != null && context.INT(0) != null)
            // {
            //     int firstVal = 0;
            //     int secondVal = int.Parse(context.INT(0).GetText());
            //     char op = context.op().GetText()[0];

            //     string var = context.ID(0).GetText();
            //     if (VarsDict.ElementAt(nesting).Value.VARS.ContainsKey(var)) firstVal = VarsDict.ElementAt(nesting).Value.VARS[var];
            //     else Console.Error.WriteLine($"Can`t find {var} value");

            //     return calcOp(op, firstVal, secondVal);
            // } 
            else // if (context.ID(0) != null && context.ID(1) != null)
            {
                int firstVal = 0;
                int secondVal = 1;
                char op = context.op().GetText()[0];

                string firstVar = context.ID(0).GetText();
                string secondVar = context.ID(1).GetText();

                if (VarsDict.ElementAt(nesting).Value.VARS.ContainsKey(firstVar)) firstVal = VarsDict.ElementAt(nesting).Value.VARS[firstVar];
                else Console.Error.WriteLine($"Can`t find {firstVar} value");

                if (VarsDict.ElementAt(nesting).Value.VARS.ContainsKey(secondVar)) secondVal = VarsDict.ElementAt(nesting).Value.VARS[secondVar];
                else Console.Error.WriteLine($"Can`t find {secondVar} value");

                return calcOp(op, firstVal, secondVal);
            }
        }

        //------Print--------------------------------------------------------
        public override object VisitPrintIntId([NotNull] PrintIntIdContext context) {
            // Console.WriteLine("PrintIntId");
            if (context.INT() != null) 
            {
                Console.WriteLine(context.INT().GetText());
            }
            else {
                // showDictionary();
                string var = (string)context.ID().GetText();
                
                if (VarsDict.ElementAt(nesting).Value.VARS.ContainsKey(var)) Console.WriteLine($"{var} = {VarsDict.ElementAt(nesting).Value.VARS[var]}");
                else Console.Error.WriteLine($"Can`t find {var} value");
            }



            return base.VisitPrintIntId(context);
        }
        public override object VisitDefState([NotNull] DefStateContext context)
        {
            string funName = context.ID(0).GetText();
            upNest(funName);

            string name;
            int val;

            int idCount;
            if (context.expr() == null && context.INT() == null) idCount = context.ID().Count()-1;
            else idCount = context.ID().Count();
            // Console.WriteLine(idCount)

            for (int i = 1; i < idCount; i++) {
                name = context.ID(i).GetText();
                // Console.WriteLine(name);
                val = VarsDict.ElementAt(nesting-1).Value.VARS[name];
                
                VarsDict.ElementAt(nesting).Value.VARS.Add(name, val);
            }

            // Console.WriteLine(context.state().Count());
            for (int i = 0; i < context.state().Count(); i++) {
                Visit(context.state(i));
            }
            
            int res;
            if(context.INT() != null) {
                res = int.Parse(context.INT().GetText());
            } else if (context.expr() != null) {
                res = int.Parse(Visit(context.expr()).ToString());
            } else {
                res = VarsDict[funName].VARS[context.ID(context.ID().Count()-1).GetText()];
            }
            VarsDict[funName].res = res;

            downNest();
            return res;
        }

        public override object VisitDefNoState([NotNull] DefNoStateContext context)
        {
            string funName = context.ID(0).GetText();
            upNest(funName);

            string name;
            int val;

            int idCount;
            if (context.expr() == null && context.INT() == null) idCount = context.ID().Count()-1;
            else idCount = context.ID().Count();

            for (int i = 1; i < idCount; i++) {
                name = context.ID(i).GetText();
                val = VarsDict.ElementAt(nesting-1).Value.VARS[name];
                
                VarsDict.ElementAt(nesting).Value.VARS.Add(name, val);
            }
            
            int res;
            if(context.INT() != null) {
                res = int.Parse(context.INT().GetText());
            } else if (context.expr() != null) {
                res = int.Parse(Visit(context.expr()).ToString());
            } else {
                res = VarsDict[funName].VARS[context.ID(context.ID().Count()-1).GetText()];
            }
            VarsDict[funName].res = res;

            downNest();
            return res;
        }
    }
}
