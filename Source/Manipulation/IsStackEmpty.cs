using System.Collections.Generic;

namespace MBT {

    public class IsStackEmpty : BehaviorNode {

        public Stack<object> stack;

        public IsStackEmpty(Stack<object> stack) {
            this.stack = stack;
            if (this.stack == null) this.stack = new Stack<object>();
        }

        public override BehaviorState Evaluate() {
            if (stack.Count == 0) { 
                state = BehaviorState.Success;
            } else {
                state = BehaviorState.Failure;
            }
            return state;
        }
    }

}