using System.Collections.Generic;

namespace MBT {

    public class NodeData {

        NodeData parent;
        Dictionary<string, object> data;

        public NodeData() {
            data = new Dictionary<string, object>();
        }

        public NodeData(NodeData parent) : this() {
            this.parent = parent;
        }

        public NodeData(NodeData parent, NodeData prototype) {
            this.parent = parent;
            data = new Dictionary<string, object>(prototype.data);
        }

        public NodeData(params (string key, object value)[] pairs) {
            data = new Dictionary<string, object>();
            foreach (var (key, value) in pairs) {
                Set(key, value);
            }
        }

        public void Set(string key, object value) {
            data[key] = value;
        }

        public bool Contains(string key) {
            return data.ContainsKey(key);
        }

        public T Get<T>(string key) {
            if (data.TryGetValue(key, out object value)) {
                return (T)value;
            }

            if (parent != null) return parent.Get<T>(key);

            return default;
        }

    }

}