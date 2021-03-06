﻿using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestQueueStorage
{
    /*
     * È una classe POCO perchè ha solo delle proprietà e nessun metodo
     */
    class CustomerEntity : TableEntity
    {
        public CustomerEntity(string lastName, string firstName)
        {
            this.PartitionKey = lastName;
            this.RowKey = firstName;
        }

        public CustomerEntity() { }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public string PartitionKey { get; private set; }
        public string RowKey { get; private set; }
    }
}
