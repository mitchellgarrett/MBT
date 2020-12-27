using System.Collections.Generic;

namespace MBT {

    public abstract class Composite : BehaviorNode {

        protected List<BehaviorNode> nodes;

        public Composite(params BehaviorNode[] nodes) : this(new List<BehaviorNode>(nodes)) { }

        public Composite(List<BehaviorNode> nodes) {
            this.nodes = nodes;
        }

    }
}