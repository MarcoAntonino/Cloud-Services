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
using Microsoft.WindowsAzure.Storage.Table; // Namespace for Table storage types

namespace TestQueueStorage
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }

        private void btnTableName_Click(object sender, EventArgs e)
        {
            // Retrieve the storage account from the connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the table client.
            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

            // Retrieve a reference to the table.
            CloudTable table = tableClient.GetTableReference(txtTableName.Text);

            // Create the table if it doesn't exist.
            table.CreateIfNotExists();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Retrieve the storage account from the connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the table client.
            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

            // Create the CloudTable object that represents the "people" table.
            CloudTable table = tableClient.GetTableReference(txtTableName.Text);

            // Construct the query operation for all customer entities where PartitionKey="Smith".
            TableQuery<CustomerEntity> query = new TableQuery<CustomerEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, txtList.Text));

            StringBuilder sb = new StringBuilder();
            // Print the fields for each customer.
            foreach (CustomerEntity entity in table.ExecuteQuery(query))
            {
                sb.Append("{0}, {1}\t{2}\t{3}\r\n", entity.PartitionKey, entity.RowKey,
                    entity.Email, entity.PhoneNumber);
            }
            txtList.Text = sb.ToString();
        }
    }
}
