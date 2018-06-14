using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;
using Microsoft.ServiceBus;

namespace ServiceBusDemo
{
    public class MessageHandler
    {
        MessagingFactory _factory;
        string _queue = "DemoQueue";
        string _topic = "DemoTopic";
        string _connectionString;

        public MessageHandler(string connectionString)
        {
            _connectionString = connectionString;
            _factory = MessagingFactory.CreateFromConnectionString(_connectionString);
        }

        public void SendMesage(string message)
        {
            CreateQueue(_queue);
            MessageSender testSender = _factory.CreateMessageSender(_queue);
            BrokeredMessage brokeredMessage = new BrokeredMessage(message);
            testSender.Send(brokeredMessage);
            //testSender.Close();
        }

        public string RecieveMesage()
        {
            //Receiving a message
            MessageReceiver testReceiver = _factory.CreateMessageReceiver(_queue);
            BrokeredMessage message = testReceiver.Receive();
            String messageText = message.GetBody<string>();
            message.Complete();

            return messageText;
        }

        public string GetCount()
        {
            var namespaceManager = NamespaceManager.CreateFromConnectionString(_connectionString);
            long count = namespaceManager.GetQueue(_queue).MessageCount;
            return count.ToString();
        }

        public string GetCountTopic(string Subscription)
        {
            var namespaceManager = NamespaceManager.CreateFromConnectionString(_connectionString);
            var subscriptionDesc = namespaceManager.GetSubscription(_topic, Subscription);
            long messageCount = subscriptionDesc.MessageCount;
            return messageCount.ToString();
        }

        public void SendMesageToTopic(string message, int SubscriptionTypeID)
        {
            //CreateTopic(_topic);
            TopicClient Client = TopicClient.CreateFromConnectionString(_connectionString, _topic);
            BrokeredMessage brokeredMessage = new BrokeredMessage(message);
            brokeredMessage.Properties.Add("Type", SubscriptionTypeID);
            Client.Send(brokeredMessage);
        }

        public string RecieveMesageFromTopic(string Subscription)
        {
            String messageText = string.Empty;

            SubscriptionClient Client = SubscriptionClient.CreateFromConnectionString
            (_connectionString, _topic, Subscription);

            var message = Client.Receive();
            messageText = message.GetBody<string>();
            message.Complete();
            // Configure the callback options.
            //OnMessageOptions options = new OnMessageOptions();
            //options.AutoComplete = false;
            //options.AutoRenewTimeout = TimeSpan.FromMinutes(1);
            //Client.OnMessage((message) =>
            //{
            //    try
            //    {
            //        messageText = message.GetBody<string>();

            //        // Remove message from subscription.
            //        message.Complete();
            //    }
            //    catch (Exception)
            //    {
            //        // Indicates a problem, unlock message in subscription.
            //        message.Abandon();
            //    }
            //}, options);

            return messageText;
        }

        public void CreateSubscription(string subscriptionName, int TypeID)
        {
            var namespaceManager =
                NamespaceManager.CreateFromConnectionString(_connectionString);

            if (!namespaceManager.SubscriptionExists(_topic, subscriptionName))
            {
                SqlFilter H1MessagesFilter = new SqlFilter("Type = " + TypeID);

                var description = new SubscriptionDescription(_topic, subscriptionName);
                description.AutoDeleteOnIdle = TimeSpan.FromSeconds(600);
                var sub = namespaceManager.CreateSubscription(description, H1MessagesFilter);
            }
        }

        public bool DeleteQueueifExists(string queueName)
        {
            bool isCreated = false;
            var namespaceManager = NamespaceManager.CreateFromConnectionString(_connectionString);

            if (namespaceManager.QueueExists(queueName))
            {
                namespaceManager.DeleteQueue(queueName);
            }
            return isCreated;
        }

        public bool CreateQueue(string queueName)
        {
            bool isCreated = false;
            var namespaceManager = NamespaceManager.CreateFromConnectionString(_connectionString);

            if (!namespaceManager.QueueExists(queueName))
            {
                var sub = namespaceManager.CreateQueue(queueName);
                if (sub != null)
                {
                    sub.LockDuration = new TimeSpan(0, 0, 1);
                    sub.AutoDeleteOnIdle = new TimeSpan(0, 10, 0);
                    isCreated = true;
                }
            }
            return isCreated;
        }

        public bool CreateTopic()
        {
            bool isCreated = false;
            var namespaceManager = NamespaceManager.CreateFromConnectionString(_connectionString);

            if (!namespaceManager.TopicExists(_topic))
            {
                var sub = namespaceManager.CreateTopic(_topic);
                if (sub != null)
                {
                    sub.AutoDeleteOnIdle = new TimeSpan(0, 10, 0);
                    isCreated = true;
                }
            }
            return isCreated;
        }

        public bool isQueueExists(string queueName)
        {
            var namespaceManager = NamespaceManager.CreateFromConnectionString(_connectionString);
            return namespaceManager.QueueExists(queueName);
        }

        public bool DeleteQueue(string queueName)
        {
            bool isCreated = false;
            var namespaceManager = NamespaceManager.CreateFromConnectionString(_connectionString);

            if (!namespaceManager.QueueExists(queueName))
            {
                QueueDescription qd = namespaceManager.GetQueue(queueName);
                if (qd.MessageCount == 0)
                    namespaceManager.DeleteQueue(queueName);
            }
            return isCreated;
        }
    }
}
