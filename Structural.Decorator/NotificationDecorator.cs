namespace Structural.Decorator
{
    #region Scenario
    /*
     We want to implement a notification sender, there are multiple possibilities like sending notification by email, by sms 
    even by Call, there is a base interface with SendNotification method, which should be common with all the possible notification mechanism
    implementing classes, possible solution is to create separate sub-classes EmailNotificationSender,TextNotificationSender & CallNotificationSender 
    for implementing differnt notification sending mechanisms, now WHAT if you want to send the notifications by all possible means.
    */
    #endregion
    public interface INotificationSender
    {
        string SendNotification();
    }
    public class BasicPushNotificationSender : INotificationSender
    {
        public string SendNotification() => "Send notification by normal Push";
    }
    /// <summary>
    /// Generic Decorator created with inheriting the base interface.
    /// </summary>
    public class NotificationDecorator : INotificationSender
    {
        private readonly INotificationSender _notificationSender;
        public NotificationDecorator(INotificationSender notificationSender)
        {
            _notificationSender = notificationSender;
        }

        public virtual string SendNotification()
        {
            return _notificationSender.SendNotification();
        }
    }

    /// <summary>
    /// Create Concrete decorator, inherited from base decorator, accepts base interface in constructor, 
    /// same base will be used in SendNotification method later.
    /// </summary>
    public class TextNotificationDecorator : NotificationDecorator
    {
        public TextNotificationDecorator(INotificationSender notificationSender) : base(notificationSender) { }
        public override string SendNotification()
        {
            return base.SendNotification() + Environment.NewLine + ("Send notification by SMS");
        }
    }
    public class EmailNotificationDecorator : NotificationDecorator
    {
        public EmailNotificationDecorator(INotificationSender notificationSender) : base(notificationSender) { }
        public override string SendNotification() => base.SendNotification() + Environment.NewLine + "Send notification by Email";
    }
    public class CallNotificationDecorator : NotificationDecorator
    {
        public CallNotificationDecorator(INotificationSender notificationSender) : base(notificationSender) { }
        public override string SendNotification() => base.SendNotification() + Environment.NewLine + "Send notification by Call";
    }

}