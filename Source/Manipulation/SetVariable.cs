namespace MBT {

    public class SetVariable : BehaviorNode {

        readonly string key;
        readonly string value;

        public SetVariable(string key, string value) {
            this.key = key;
            this.value = value;
        }

        public override void Initialize(NodeData data) {
            base.Initialize(data);
            data.Set(key, data.Get<object>(value));
        }

        public override BehaviorState Evaluate() {
            state = BehaviorState.Success;
            return state;
        }
    }

}