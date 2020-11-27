using NatsTest.Shared;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NatsTest.Server
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            this.InitializeComponent();
        }

        private void BtnPubSub_Click(object sender, EventArgs e)
        {
            for (var i = 1; i <= 10; i++)
            {
                var message = $"Message{i}";
                this.TxtLog.Text += $"Sending: {message}" + Environment.NewLine;

                var data = Encoding.UTF8.GetBytes(message);

                Stuff.NatsConnection.Publish("nats.demo.pubsub", data);

                Thread.Sleep(100);
            }
        }

        private void BtnRequestReply_Click(object sender, EventArgs e)
        {
            for (var i = 0; i <= 10; i++)
            {
                var message = $"Message {i}";
                this.WriteToTextbox($"Sending: {message}");
                var data = Encoding.UTF8.GetBytes(message);
                var response = Stuff.NatsConnection.Request("nats.demo.requestreply", data, 5000);
                var responseMsg = Encoding.UTF8.GetString(response.Data);
                this.WriteToTextbox($"Response: {responseMsg}");
                Thread.Sleep(100);
            }
        }

        private void BtnScatterGather_Click(object sender, EventArgs e)
        {
            var replySubject = "replyToThis";
            var sub = Stuff.NatsConnection.SubscribeSync(replySubject);

            Stuff.NatsConnection.Publish("nats.demo.scattergather", replySubject, Encoding.UTF8.GetBytes("Please respond"));

            var timeout = DateTime.Now.AddSeconds(2);
            while (DateTime.Now < timeout)
            {
                var msg = sub.NextMessage();
                this.WriteToTextbox(Encoding.UTF8.GetString(msg.Data));
                Thread.Sleep(10);
            }

            sub.Unsubscribe();
        }

        private void WriteToTextbox(string text)
        {
            if (this.TxtLog.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    this.TxtLog.Text += text + Environment.NewLine;
                }));
            }
            else
            {
                this.TxtLog.Text += text + Environment.NewLine;
            }
        }
    }
}
