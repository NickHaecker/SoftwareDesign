using System;

namespace Lektion_04
{
    class Subscription
    {
        public RegisteredUser subscriptionUser { get; set => null; }
        public Channel subscriptionChannel { get; set => null; }

        public Subscription(RegisteredUser SubscriptionUser, Channel SubscriptionChannel)
        {
            subscriptionUser = SubscriptionUser;
            subscriptionChannel = SubscriptionChannel;
        }
    }
}
