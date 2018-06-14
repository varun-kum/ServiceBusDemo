using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceBusDemo
{
    public partial class Form1 : Form
    {
        string _ConnectionString = "";
        string _subscription1 = "Sub1";
        string _subscription2 = "Sub2";
        public Form1()
        {
            InitializeComponent();
        }

        private void cbConnectionstring_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConnectionstring.Checked)
                txtCS.Enabled = true;
            else
                txtCS.Enabled = false;
            _ConnectionString = txtCS.Text;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                txtStatus1.Text = "";
                btnSend.Enabled = false;
                MessageHandler objMessageHandler = new MessageHandler(_ConnectionString);
                objMessageHandler.SendMesage(txtProducerMessage.Text);
                lblCount.Text = objMessageHandler.GetCount();
                txtProducerMessage.Text = "";
                txtStatus1.Text = "Message Successfully Sent!";
            }
            catch (Exception ex)
            {
                txtStatus1.Text = ex.Message;
            }
            finally
            {
                btnSend.Enabled = true;
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                txtStatus1.Text = "";
                btnReceive.Enabled = false;
                MessageHandler objMessageHandler = new MessageHandler(_ConnectionString);
                string message = objMessageHandler.RecieveMesage();
                txtConsumerMessage.Text = message;
                lblCount.Text = objMessageHandler.GetCount();
                txtStatus1.Text = "Message Successfully Received!";
            }
            catch (Exception ex)
            {
                txtStatus1.Text = ex.Message;
            }
            finally
            {
                btnReceive.Enabled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtStatus1.Text = "";
                txtProducerMessage.Text = "";
                txtConsumerMessage.Text = "";
                MessageHandler objMessageHandler = new MessageHandler(_ConnectionString);
                lblCount.Text = objMessageHandler.GetCount();
            }
            catch (Exception ex)
            {
                txtStatus1.Text = ex.Message;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSendTopic_Click(object sender, EventArgs e)
        {
            try
            {
                btnSendTopic.Enabled = false;
                txtStatus2.Text = "";
                MessageHandler objMessageHandler = new MessageHandler(_ConnectionString);
                objMessageHandler.CreateTopic();
                objMessageHandler.CreateSubscription(_subscription1, 1);
                objMessageHandler.CreateSubscription(_subscription2, 2);
                objMessageHandler.SendMesageToTopic(txtTopicSend1.Text, 1);
                objMessageHandler.SendMesageToTopic(txtTopicSend2.Text, 2);
                txtTopicSend1.Text = string.Empty;
                txtTopicSend2.Text = string.Empty;
                lblSub1Count.Text = objMessageHandler.GetCountTopic(_subscription1);
                lblSub2Count.Text = objMessageHandler.GetCountTopic(_subscription2);

                txtStatus2.Text = "Messages Successfully Sent!";
            }
            catch (Exception ex)
            {
                txtStatus1.Text = ex.Message;
            }
            finally
            {
                btnSendTopic.Enabled = true;
            }
        }

        private void btnTopicRec1_Click(object sender, EventArgs e)
        {
            try
            {
                btnTopicRec1.Enabled = false;
                txtStatus2.Text = "";
                MessageHandler objMessageHandler = new MessageHandler(_ConnectionString);
                string message = objMessageHandler.RecieveMesageFromTopic(_subscription1);
                txtTopicRec1.Text = message;
                lblSub1Count.Text = objMessageHandler.GetCountTopic(_subscription1);
                txtStatus2.Text = "Message Successfully Received!";
            }
            catch (Exception ex)
            {
                txtStatus1.Text = ex.Message;
            }
            finally
            {
                btnTopicRec1.Enabled = true;
            }
        }

        private void btnTopicRec2_Click(object sender, EventArgs e)
        {
            try
            {
                btnTopicRec2.Enabled = false;
                txtStatus2.Text = "";
                MessageHandler objMessageHandler = new MessageHandler(_ConnectionString);
                string message = objMessageHandler.RecieveMesageFromTopic(_subscription2);
                txtTopicRec2.Text = message;
                lblSub2Count.Text = objMessageHandler.GetCountTopic(_subscription2);
                txtStatus2.Text = "Message Successfully Received!";
            }
            catch (Exception ex)
            {
                txtStatus1.Text = ex.Message;
            }
            finally
            {
                btnTopicRec2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageHandler objMessageHandler = new MessageHandler(_ConnectionString);
                lblSub1Count.Text = objMessageHandler.GetCountTopic(_subscription1);
                lblSub2Count.Text = objMessageHandler.GetCountTopic(_subscription2);
                txtStatus1.Text = string.Empty;
                txtTopicRec1.Text = string.Empty;
                txtTopicRec2.Text = string.Empty;
                txtTopicSend1.Text = string.Empty;
                txtTopicSend2.Text = string.Empty;
            }
            catch (Exception ex)
            {
                txtStatus1.Text = ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _ConnectionString = txtCS.Text;
                txtCS.Enabled = false;
                txtStatus1.Text = "";
            }
            catch (Exception ex)
            {
                txtStatus1.Text = ex.Message;
            }
        }
    }
}
