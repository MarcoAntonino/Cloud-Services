using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerVisionAPIsample
{
    public partial class TestComputerVision : Form
    {
        public TestComputerVision()
        {
            InitializeComponent();
        }

        Bitmap picture;

        private void btnProcess_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            MakeRequest(txtFilename.Text);
            picture = new Bitmap(txtFilename.Text);
            picPicture.Image = picture;
        }

        /*
         * La keyword async lo fa diventare come metodo assincrono la cui invocazione può avvenire su un thread parallelo, e chi l'ha lanciato, non aspetta il risultato
         */
        async void MakeRequest(string imageFilePath)
        {
            HttpClient client = new HttpClient();
            /*
             * Ha una serie d imetodi che permette di fare una chiamata http e ottenere una serie di metodi e ritornarli
             */
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key","551f3c06990e4351af7eb53605c71c86");

            string requestParameters ="visualFeatures=Categories,Description,Color&language=en";

            // Assemble the URI for the REST API Call.

            string uri = "https://westeurope.api.cognitive.microsoft.com/vision/v1.0/analyze?"+ requestParameters;

            /*
             * Questo URL inizia con una stringa dal datacenter da cui ho creato la connessione
             */
            HttpResponseMessage response;
            string responseContent;
            byte[] byteData = GetImageAsByteArray(imageFilePath);
            /*
             * Fondamentalmente scrivere using è come dire: quel blocco di codice avrà la garanzia che subisca il dispose quando incontra l'unica graffa. E quindi chiude la connessione.
             * Senza dispose, la connessione resta appesa e prima o poi potrebbe saturarsi.
             * L'using o il dispose è molt oimportante quando utilizzi delle variabili che utilizzano delle risorse fisiche.
             */
            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream"); //sta arrivando uno stream di byte, bisogna specificare sempre cosa mandi
                response = await client.PostAsync(uri, content);
                //in questo caso sto per chiamare un metodo asincrono ma uso la parola chiave await che ne aspetta la risposta
                //se non avessi messo il wait, questa response sarebbe andata avanti
                responseContent = response.Content.ReadAsStringAsync().Result;
            }

            setResultText(responseContent);
        }

        private void setResultText(string txt)
        {
            if (txtResult.InvokeRequired)//propertie che dice se aseonda del contesto, le eventual iazion isu quel soggetto sono dirette o boh...
            {
                txtResult.Invoke(
                    new Action(() => txtResult.Text = txt));
                return;
            }
            txtResult.Text = txt;
        }

        private byte[] GetImageAsByteArray(string imageFilePath)
        {
            FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            return binaryReader.ReadBytes((int)fileStream.Length);
        }
    }
}
