namespace StateDesignPattern {
    public abstract class State {

        protected Context Context;

        public void SetContext(Context context) {

            this.Context = context;
        }

        public abstract void Handle1();

        public abstract void Handle2();
    }
}
