using System;

namespace DesignPatterns
{
    class Subscription
    {
        public RegisteredUser subscriptionUser { get; set; }
        public Channel subscriptionChannel { get; set; }

        public Subscription(RegisteredUser SubscriptionUser, Channel SubscriptionChannel)
        {
            subscriptionUser = SubscriptionUser;
            subscriptionChannel = SubscriptionChannel;
        }
    }
}