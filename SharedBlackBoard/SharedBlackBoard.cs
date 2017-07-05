using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ServiceBus.Messaging;

namespace SharedBlackBoard
{
    public partial class SharedBlackBoard : Form
    {
        public SharedBlackBoard()
        {
            InitializeComponent();
        }

        int oldX, oldY;
        string connectionString = "Endpoint=sb://avsbtest.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=W504rGVBUid1FkOSVj3s8eYyO5NT1AhYZm/afvpXEIM=";
        string queueName = "myTestSBqueue";
        /*Queste due ultime variabili sono state fornite da Azure.
         * Bisognerebbe metterle in file di config e magari criptarle
         */
        QueueClient ReceiveClient;
        List<LineEntity> Lines = new List<LineEntity>();         

        private void pictBlckBrd_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DrawLine(e.X, e.Y, oldX, oldY, txtColor.Text);
                

                if (chkSend.Checked)
                {
                    LineEntity le = new LineEntity();
                    le.x1 = e.X;
                    le.y1 = e.Y;
                    le.x2 = oldX;
                    le.y2 = oldY;
                    le.color = txtColor.Text;
                    Lines.Add(le);
                    if (Lines.Count==50)
                    {
                        SendLines(Lines);
                        Lines.Clear();
                    }
                    //SendLine(e.X, e.Y, oldX, oldY, txtColor.Text);
                }
                oldX = e.X;
                oldY = e.Y;

            }
        }

        private void SendLines(List<LineEntity> lines)
        {
            QueueClient client = QueueClient.CreateFromConnectionString(connectionString, queueName);
            StringBuilder sb = new StringBuilder();
            foreach (LineEntity le in lines)
            {
                sb.Append(le.x1.ToString() + ",");
                sb.Append(le.y1.ToString() + ",");
                sb.Append(le.x1.ToString() + ",");
                sb.Append(le.y2.ToString() + ",");
                sb.Append(le.color.ToString() + ";");
            }
            BrokeredMessage message = new BrokeredMessage(sb.ToString());
            client.Send(message);
        }

        private void SendLine(int x1, int y1, int x2, int y2, string color)
        {
            QueueClient client = QueueClient.CreateFromConnectionString(connectionString, queueName);
            //è la coda di service bus. Questo queue client lo useremo andando a prendere una stringa di connessione
            BrokeredMessage message = new BrokeredMessage(x1.ToString() + "," + y1.ToString() + "," + x2.ToString() + "," + y2.ToString() + "," + color);
            client.Send(message);
        }

        private void DrawLine(int x1, int y1, int x2, int y2, string color)
        {
            Color c = System.Drawing.ColorTranslator.FromHtml(color);
            Graphics g = pictBlckBrd.CreateGraphics();
            g.DrawLine(new Pen(c,2), x1, y1, x2, y2);
            g.Dispose();
            /*Se io no nmettessi dispose, la variabile g uscirebbe dal suo scope e diventerebbe garbage e quindi finirebbe nel garbage collector ma data la pigrizia del GC, è meglio sganciare subito la risorsa fisica subito. Se non lo mettessi, sarebbe poi compito dei GC liberare la memoria occupata dall'oggetto ma in un momento determinato a priori. Con il rischio di saturare la memoria grafica.
             * Si potrebbe wrappare nello using anche.
             */
            
        }

        private void chkSend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSend.Checked)
            {
                chkReceive.Checked = false; //fai occhio che l'evento di default, cioè cambia lo status, si scatena
            }
        }

        private void chkReceive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReceive.Checked)
            {
                chkSend.Checked = false;
                ReceiveClient = QueueClient.CreateFromConnectionString(connectionString, queueName);
                ReceiveClient.OnMessage(message =>
                {
                //string msg = message.GetBody<String>();
                //int x1 = int.Parse(msg.Split(',')[0]);
                //int y1 = int.Parse(msg.Split(',')[1]);
                //int x2 = int.Parse(msg.Split(',')[2]);
                //int y2 = int.Parse(msg.Split(',')[3]);
                //string color = msg.Split(',')[4];
                //DrawLine(x1, y1, x2, y2, color);

                string msg = message.GetBody<String>();
                string[] segs = msg.Split(';');
                    foreach (string seg in segs)
                    {
                        if (seg.Length>0)
                        {
                            int x1 = int.Parse(seg.Split(',')[0]);
                            int y1 = int.Parse(seg.Split(',')[1]);
                            int x2 = int.Parse(seg.Split(',')[2]);
                            int y2 = int.Parse(seg.Split(',')[3]);
                            string color = seg.Split(',')[4];
                            DrawLine(x1, y1, x2, y2, color);
                        }
                        
                    }
                    

                });
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = pictBlckBrd.CreateGraphics();
            g.Clear(Color.Black);
            g.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*
            * Due parametri
            * semnder: l'oggetto che ha generato l'evento
            * eventArgs: i dati che quel tipo di eventi che si porta dietro. E sono specifici! Dei mouse eventArgs
            */
        private void pictBlckBrd_MouseDown(object sender, MouseEventArgs e)
           
        {
            if (e.Button == MouseButtons.Left) //.Left è un enum
            {
                oldX = e.X;
                oldY = e.Y;
            }

        }
    }
}
