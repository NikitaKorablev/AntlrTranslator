using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AntlrCSharp;
using Antlr4.Runtime;

namespace AntlrCSharpTests
{
    [TestClass]
    public class ParserTest
    {
        private calcParser Setup(string text)
        {
            AntlrInputStream inputStream = new AntlrInputStream(text);
            calcLexer calcLexer = new calcLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(calcLexer);
            calcParser calcParser = new calcParser(commonTokenStream);

            return calcParser;   
        }

        [TestMethod]
        public void TestChat()
        {
            calcParser parser = Setup("5+5; 10 - 6");

            calcParser.ProgContext context = parser.prog();
            CalcUserVisitor visitor = new CalcUserVisitor();
            visitor.Visit(context);

            Assert.AreEqual(2, visitor.res.Count);
        }

        [TestMethod]
        public void TestProg()
        {
            calcParser parser = Setup("5+5; 10 - 6");

            calcParser.ProgContext context = parser.prog();
            CalcUserVisitor visitor = new CalcUserVisitor();
            CalcLine line = (CalcLine) visitor.VisitOneLineProg((OneLineProgContext)context);     
            
            Assert.AreEqual("john", line.Person);
            Assert.AreEqual("hello", line.Text);
        }

        [TestMethod]
        public void TestWrongLine()
        {
            calcParser parser = Setup("john sayan \"hello\" \n");

            var context = parser.line();
            
            Assert.IsInstanceOfType(context, typeof(calcParser.LineContext));            
            Assert.AreEqual("john", context.name().GetText());
            Assert.IsNull(context.SAYS());
            Assert.AreEqual("johnsayan\"hello\"\n", context.GetText());
        }
    }
}