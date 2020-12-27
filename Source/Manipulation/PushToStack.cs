using System.Collections.Generic;

namespace MBT {

    public class PushToStack : BehaviorNode {

        public Stack<object> stack;

        public PushToStack(Stack<object> stack) {
            this.stack = stack;
            if (this.stack == null) this.stack = new Stack<object>();
        }

        public override BehaviorState Evaluate() {
            throw new System.NotImplementedException();
        }
    }

}