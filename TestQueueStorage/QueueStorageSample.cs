using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Queue; // Namespace for Queue storage types

namespace TestQueueStorage
{
    public partial class QueueStorageSample : Form
    {
        public QueueStorageSample()
        {
            InitializeComponent();
        }

        private void btnQueueName_Click(object sender, EventArgs e)
        {
            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the queue client.
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient(); 
            //stiamo creando una classe che rappresenterà il client sui cui ci appoggeremo

            // Retrieve a reference to a container.
            CloudQueue queue = queueClient.GetQueueReference(txtQueueName.Text);

            // Create the queue if it doesn't already exist
            queue.CreateIfNotExists();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the queue client.
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            // Retrieve a reference to a queue.
            CloudQueue queue = queueClient.GetQueueReference(txtQueueName.Text);

            // Create the queue if it doesn't already exist.
            queue.CreateIfNotExists();

            // Create a message and add it to the queue.
            CloudQueueMessage message = new CloudQueueMessage(txtMessage.Text);
            queue.AddMessage(message);
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            // Retrieve storage account from connection string
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the queue client
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            // Retrieve a reference to a queue
            CloudQueue queue = queueClient.GetQueueReference(txtQueueName.Text);

            // Peek at the next message
            CloudQueueMessage peekedMessage = queue.PeekMessage();

            if (peekedMessage == null)
            {
                MessageBox.Show("The queue is empty!");
                return;
            }

            // Display message.
            Console.WriteLine(peekedMessage.AsString);
            MessageBox.Show(peekedMessage.AsString);
        }

        private void btnGetMessage_Click(object sender, EventArgs e)
        {
            // Retrieve storage account from connection string
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
            CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the queue client
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            // Retrieve a reference to a queue
            CloudQueue queue = queueClient.GetQueueReference(txtQueueName.Text);

            // Get the next message
            CloudQueueMessage retrievedMessage = queue.GetMessage();

            if (retrievedMessage == null)
            {
                MessageBox.Show("The queue is empty!");
                return;
            }

            //Process the message in less than 30 seconds, and then delete the message
            queue.DeleteMessage(retrievedMessage);
            MessageBox.Show("Message deleted");
            

        }

        private void btnOpenF2_Click(object sender, EventArgs e)
        {
            TableForm tf = new TableForm();
            tf.ShowDialog();
        }
    }
}
