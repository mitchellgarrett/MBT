namespace MBT {

    public class Behavior : NodeDataManager {

        public Behavior(BehaviorNode node) : base(node) { }
        public Behavior(NodeData data, BehaviorNode node) : base(node, data) { }

        public void Initialize() {
            base.Initialize(null);
        }

    }

}