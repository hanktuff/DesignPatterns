namespace MediatorDesignPattern {
    public abstract class Component {

        protected IMediator Mediator;

        public Component(IMediator mediator = null) {
            this.Mediator = mediator;
        }

        public void SetMediator(IMediator mediator) {

            this.Mediator = mediator;
        }
    }
}
