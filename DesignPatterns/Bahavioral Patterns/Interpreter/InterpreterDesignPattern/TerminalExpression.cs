using System.Diagnostics;

namespace InterpreterDesignPattern {
    public class TerminalExpression : AbstractExpression {

        public override void Interpret(Context context) {

            Debug.WriteLine("Called Terminal.Interpret()");
        }
    }
}
