using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace InterpreterDesignPattern {

    [TestClass]
    public class User {

        [TestMethod]
        public void TestMethod1() {

            Context context = new Context();

            var list = new List<AbstractExpression>();

            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (AbstractExpression expression in list) {

                expression.Interpret(context);
            }
        }
    }
}
