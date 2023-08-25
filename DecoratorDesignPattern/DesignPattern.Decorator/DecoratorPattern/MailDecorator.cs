using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class MailDecorator : Decorator
    {
        private readonly INotifier _notifier;

        Context context = new Context();

        public MailDecorator(INotifier notifier) : base(notifier)
        {
        }

        public void SendMailNotify(Notifier notifier)
        {
            notifier.NotifierSubject = "Günlük..";
            notifier.NotifierCreator = "Scrum Master";
            notifier.NotifierChannel = "Gmail-Outlook";
            notifier.NotifierType = "Private";
            context.Notifiers.Add(notifier);
            context.SaveChanges();

        }

        public override void CreateNotify(Notifier notifier)
        {
            base.CreateNotify(notifier);
            SendMailNotify(notifier);
        }

    }
}
