
namespace NatsTest.Server
{
    partial class FrmServer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.BtnPubSub = new System.Windows.Forms.Button();
            this.BtnRequestReply = new System.Windows.Forms.Button();
            this.BtnScatterGather = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtLog
            // 
            this.TxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLog.Location = new System.Drawing.Point(12, 41);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLog.Size = new System.Drawing.Size(776, 397);
            this.TxtLog.TabIndex = 0;
            // 
            // BtnPubSub
            // 
            this.BtnPubSub.Location = new System.Drawing.Point(12, 12);
            this.BtnPubSub.Name = "BtnPubSub";
            this.BtnPubSub.Size = new System.Drawing.Size(75, 23);
            this.BtnPubSub.TabIndex = 1;
            this.BtnPubSub.Text = "PubSub";
            this.BtnPubSub.UseVisualStyleBackColor = true;
            this.BtnPubSub.Click += new System.EventHandler(this.BtnPubSub_Click);
            // 
            // BtnRequestReply
            // 
            this.BtnRequestReply.Location = new System.Drawing.Point(93, 12);
            this.BtnRequestReply.Name = "BtnRequestReply";
            this.BtnRequestReply.Size = new System.Drawing.Size(103, 23);
            this.BtnRequestReply.TabIndex = 2;
            this.BtnRequestReply.Text = "RequestReply";
            this.BtnRequestReply.UseVisualStyleBackColor = true;
            this.BtnRequestReply.Click += new System.EventHandler(this.BtnRequestReply_Click);
            // 
            // BtnScatterGather
            // 
            this.BtnScatterGather.Location = new System.Drawing.Point(202, 12);
            this.BtnScatterGather.Name = "BtnScatterGather";
            this.BtnScatterGather.Size = new System.Drawing.Size(109, 23);
            this.BtnScatterGather.TabIndex = 3;
            this.BtnScatterGather.Text = "ScatterGather";
            this.BtnScatterGather.UseVisualStyleBackColor = true;
            this.BtnScatterGather.Click += new System.EventHandler(this.BtnScatterGather_Click);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnScatterGather);
            this.Controls.Add(this.BtnRequestReply);
            this.Controls.Add(this.BtnPubSub);
            this.Controls.Add(this.TxtLog);
            this.Name = "FrmServer";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.Button BtnPubSub;
        private System.Windows.Forms.Button BtnRequestReply;
        private System.Windows.Forms.Button BtnScatterGather;
    }
}

