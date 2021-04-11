using System.Diagnostics;

namespace InterpreterDesignPattern {
    public class NonterminalExpression : AbstractExpression {

        public override void Interpret(Context context) {

            Debug.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}
