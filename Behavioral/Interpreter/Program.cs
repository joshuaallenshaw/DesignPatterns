/* GoF Interpreter Pattern
 * Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language.
 */

using System;
using System.Collections.Generic;

namespace Interpreter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string expression = "w x z - +";
            var evaluator = new Evaluator(expression);
            var sentence = new Dictionary<string, IExpression>();
            sentence["w"] = new Number(5);
            sentence["x"] = new Number(10);
            sentence["z"] = new Number(42);
            var result = evaluator.Interpret(sentence);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}