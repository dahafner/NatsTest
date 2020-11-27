using NATS.Client;
using NatsTest.Shared;
using System;
using System.Text;
using System.Windows.Forms;

namespace NatsTest.Client
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            this.InitializeComponent();
        }

        private void BtnPubSub_Click(object sender, EventArgs e)
        {
            var sub = Stuff.NatsConnection.SubscribeAsync("nats.demo.pubsub", (sender, args) =>
            {
                this.PubSub(sender, args);
            });
            this.TxtLog.Text += "Subscribed to nats.demo.pubsub" + Environment.NewLine;
        }

        private void PubSub(object sender, MsgHandlerEventArgs args)
        {
            this.WriteToTextbox(Encoding.UTF8.GetString(args.Message.Data));
        }

        private void BtnRequestReply_Click(object sender, EventArgs e)
        {
            var sub = Stuff.NatsConnection.SubscribeAsync("nats.demo.requestreply", (sender, args) => { this.RequestReply(sender, args); });
        }

        private void RequestReply(object sender, MsgHandlerEventArgs args)
        {
            var data = Encoding.UTF8.GetString(args.Message.Data);
            this.WriteToTextbox(data);

            var replySubject = args.Message.Reply;
            this.WriteToTextbox($"Reply subject: {replySubject}");
            if (replySubject != null)
            {
                var responseData = Encoding.UTF8.GetBytes($"ACK for {data}");
                Stuff.NatsConnection.Publish(replySubject, responseData);
            }
        }        

        private void BtnScatterGather_Click(object sender, EventArgs e)
        {
            var sub = Stuff.NatsConnection.SubscribeAsync("nats.demo.scattergather", (sender, args) => { this.ScatterGather(sender, args); });
        }

        private void ScatterGather(object sender, MsgHandlerEventArgs args)
        {
            var data = Encoding.UTF8.GetString(args.Message.Data);
            this.WriteToTextbox(data);

            var replySubject = args.Message.Reply;
            this.WriteToTextbox($"Reply subject: {replySubject}");
            if (replySubject != null)
            {
                var responseData = Encoding.UTF8.GetBytes($"ACK for {data}");
                Stuff.NatsConnection.Publish(replySubject, responseData);
            }
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
