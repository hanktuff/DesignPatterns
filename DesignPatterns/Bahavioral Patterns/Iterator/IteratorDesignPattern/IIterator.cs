namespace IteratorDesignPattern {
    public partial class User {
        public interface IIterator<T> {

            T[] Items { get; }
            void MoveFirst();
            bool MoveNext();
            T Current { get; }
        }
    }
}
