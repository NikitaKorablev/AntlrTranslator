using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

// namespace AntlrCSharp
// {
//     class Program
//     {
//         private static void Main(string[] args)
//         {
//             try
//             {
//                 string input = "";
//                 StringBuilder text = new StringBuilder();
//                 Console.WriteLine("Input the chat.");

//                 // to type the EOF character and end the input: use CTRL+D, then press <enter>
//                 while ((input = Console.ReadLine()) != "\u0004")
//                 {
//                     text.AppendLine(input);
//                 }
                
//                 AntlrInputStream inputStream = new AntlrInputStream(text.ToString());
//                 calcLexer calckLexer = new calcLexer(inputStream);
//                 CommonTokenStream commonTokenStream = new CommonTokenStream(calckLexer);
//                 calcParser calcParser = new calcParser(commonTokenStream);

//                 calcParser.ChatContext chatContext = calcParser.chat();                
//                 BasicCalcVisitor visitor = new BasicCalcVisitor();                
//                 visitor.Visit(chatContext);                

//                 foreach(var line in visitor.Lines)
//                 {
//                     Console.WriteLine("{0} has said {1}", line.Person, line.Text);
//                 }
//             }
//             catch (Exception ex)
//             {                
//                 Console.WriteLine("Error: " + ex);                
//             }
//         }
//     }
// }


namespace AntlrCSharp
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader("./prog.simple");
                string input = sr.ReadToEnd();
                // Console.WriteLine(input);
                StringBuilder text = new StringBuilder();
                text.AppendLine(input);
                
                AntlrInputStream inputStream = new AntlrInputStream(text.ToString());
                calcLexer calckLexer = new calcLexer(inputStream);
                CommonTokenStream commonTokenStream = new CommonTokenStream(calckLexer);
                calcParser parser = new calcParser(commonTokenStream);

                CalcUserVisitor visitor = new CalcUserVisitor();
                visitor.Visit(parser.prog());                
            }
            catch (Exception ex)
            {                
                Console.WriteLine("Error: " + ex);                
            }
        }
    }
}

