using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using Newtonsoft.Json;

namespace CosmosDB
{
    public partial class CosmosTest : Form
    {
        private const string EndpointUrl = "https://avcosmostest.documents.azure.com:443/";
        private const string AuthorizationKey = "wd7bJUvyyRUZVBisiHPZqeFxl27NrWUtlfhtMYAM1kSeYwFfsZe8uV0YDEd7awmtx49RIOyZAGCFEtfQzYWssw==";

        public CosmosTest()
        {
            InitializeComponent();
        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            var client = new DocumentClient(new Uri(EndpointUrl), AuthorizationKey);
            // il compilatore inferisce il tipo grazie all'assegnazione ma non influisce sulle prestazioni, se passi sopra col cursore ti dice già che tipo di variabile pensa sia
            var databaseDefinition = new Database
            {
                Id = txtDB.Text
            };
            client.CreateDatabaseAsync(databaseDefinition); //questo è un metodo asincrono nel senso che quando viene eseguito, parte la configurazione asincrona e non viene attesa per andare avanti
        
        }

        private void btnDeleteDB_Click(object sender, EventArgs e)
        {
            var client = new DocumentClient(new Uri(EndpointUrl), AuthorizationKey);
            Database database = client.CreateDatabaseQuery("SELECT * FROM c WHERE c.id = '" + txtDB.Text + "'").AsEnumerable().First();

            client.DeleteDatabaseAsync(database.SelfLink); //il delete db ha bisogno di una stringa 
        }

        private void btnListDB_Click(object sender, EventArgs e)
        {
            var client = new DocumentClient(new Uri(EndpointUrl), AuthorizationKey);
            var databases = client.CreateDatabaseQuery().ToList();
            StringBuilder sb = new StringBuilder();
            foreach (var database in databases)
            {
                sb.Append(String.Format("Datavase Id: {0}, Rid: {1}\r\n", database.Id, database.ResourceId));

            }
            MessageBox.Show(sb.ToString());
        }

        private void btnCreateCllctn_Click(object sender, EventArgs e)
        {
            var client = new DocumentClient(new Uri(EndpointUrl), AuthorizationKey);
            Database database = client.CreateDatabaseQuery("SELECT * FROM c WHERE c.id = '" + txtDB.Text + "'").AsEnumerable().First();

            var collectionDefinition = new DocumentCollection
            {
                Id = txtCollection.Text
        };
            var options = new RequestOptions { OfferType = "S1" };
            client.CreateDocumentCollectionAsync(database.SelfLink, collectionDefinition, options);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCrtDoc_Click(object sender, EventArgs e)
        {
            var client = new DocumentClient(new Uri(EndpointUrl), AuthorizationKey);
            Database database = client.CreateDatabaseQuery("SELECT * FROM c where c.id = @id", Parameters)
        }
    }
}
