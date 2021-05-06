using System.Collections.Generic;
using System.Linq;

namespace IteratorDesignPattern {
    public partial class User {
        public sealed class Iterator<T> : IIterator<T> {

            int position;

            public Iterator(IEnumerable<T> items) {

                this.Items = items.ToArray();
                MoveFirst();
            }


            public T[] Items { get; private set; }

            public T Current => Items[this.position < 0 ? 0 : this.position];

            public void MoveFirst() {
                this.position = -1;
            }

            public bool MoveNext() {

                this.position++;

                if (this.position == Items.Count()) {
                    return false;
                }

                return true;
            }
        }
    }
}
