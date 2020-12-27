namespace MBT {

    public class Exists : BehaviorNode {

        string key;

        public Exists(string key) {
            this.key = key;
        }

        public override BehaviorState Evaluate() {
            if (data.Get<object>(key) != null) {
                state = BehaviorState.Success;
            } else {
                state = BehaviorState.Failure;
            }
            return state;
        }
    }

}