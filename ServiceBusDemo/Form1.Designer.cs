namespace ServiceBusDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabDemo = new System.Windows.Forms.TabControl();
            this.tabQueue = new System.Windows.Forms.TabPage();
            this.txtStatus1 = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.txtConsumerMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCS = new System.Windows.Forms.TextBox();
            this.cbConnectionstring = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtProducerMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTopic = new System.Windows.Forms.TabPage();
            this.txtStatus2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSub2Count = new System.Windows.Forms.Label();
            this.lblSub1Count = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTopicRec2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTopicRec2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTopicRec1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnTopicRec1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTopicSend2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSendTopic = new System.Windows.Forms.Button();
            this.txtTopicSend1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.tabDemo.SuspendLayout();
            this.tabQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabTopic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDemo
            // 
            this.tabDemo.Controls.Add(this.tabQueue);
            this.tabDemo.Controls.Add(this.tabTopic);
            this.tabDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDemo.Location = new System.Drawing.Point(0, 0);
            this.tabDemo.Margin = new System.Windows.Forms.Padding(4);
            this.tabDemo.Multiline = true;
            this.tabDemo.Name = "tabDemo";
            this.tabDemo.SelectedIndex = 0;
            this.tabDemo.Size = new System.Drawing.Size(1531, 832);
            this.tabDemo.TabIndex = 0;
            // 
            // tabQueue
            // 
            this.tabQueue.Controls.Add(this.groupBox1);
            this.tabQueue.Controls.Add(this.txtStatus1);
            this.tabQueue.Controls.Add(this.lblCount);
            this.tabQueue.Controls.Add(this.btnRefresh);
            this.tabQueue.Controls.Add(this.pictureBox1);
            this.tabQueue.Controls.Add(this.groupBox2);
            this.tabQueue.Controls.Add(this.txtCS);
            this.tabQueue.Controls.Add(this.cbConnectionstring);
            this.tabQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQueue.Location = new System.Drawing.Point(4, 34);
            this.tabQueue.Margin = new System.Windows.Forms.Padding(4);
            this.tabQueue.Name = "tabQueue";
            this.tabQueue.Padding = new System.Windows.Forms.Padding(4);
            this.tabQueue.Size = new System.Drawing.Size(1523, 794);
            this.tabQueue.TabIndex = 0;
            this.tabQueue.Text = "Queue";
            this.tabQueue.UseVisualStyleBackColor = true;
            // 
            // txtStatus1
            // 
            this.txtStatus1.BackColor = System.Drawing.Color.Cornsilk;
            this.txtStatus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus1.Location = new System.Drawing.Point(609, 396);
            this.txtStatus1.Multiline = true;
            this.txtStatus1.Name = "txtStatus1";
            this.txtStatus1.Size = new System.Drawing.Size(203, 149);
            this.txtStatus1.TabIndex = 7;
            this.txtStatus1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(672, 179);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(27, 29);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "0";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::ServiceBusDemo.Properties.Resources.Refresh1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Location = new System.Drawing.Point(711, 90);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 47);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::ServiceBusDemo.Properties.Resources.Flow2;
            this.pictureBox1.Location = new System.Drawing.Point(407, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 320);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.btnReceive);
            this.groupBox2.Controls.Add(this.txtConsumerMessage);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(933, 324);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(398, 308);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consumer";
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(182, 170);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(92, 72);
            this.btnReceive.TabIndex = 2;
            this.btnReceive.Text = "Receive Message";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // txtConsumerMessage
            // 
            this.txtConsumerMessage.Location = new System.Drawing.Point(124, 89);
            this.txtConsumerMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsumerMessage.Name = "txtConsumerMessage";
            this.txtConsumerMessage.Size = new System.Drawing.Size(229, 26);
            this.txtConsumerMessage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Message : ";
            // 
            // txtCS
            // 
            this.txtCS.Location = new System.Drawing.Point(263, 679);
            this.txtCS.Margin = new System.Windows.Forms.Padding(4);
            this.txtCS.Multiline = true;
            this.txtCS.Name = "txtCS";
            this.txtCS.Size = new System.Drawing.Size(1032, 56);
            this.txtCS.TabIndex = 2;
            this.txtCS.Text = "Endpoint=sb://msservicebusdemo.servicebus.windows.net/;SharedAccessKeyName=RootMa" +
    "nageSharedAccessKey;SharedAccessKey=Eh6CxbvseDh8DpoK3EIYiuUb9wPdJDhDmRj8fxnlbMc=" +
    "";
            // 
            // cbConnectionstring
            // 
            this.cbConnectionstring.AutoSize = true;
            this.cbConnectionstring.Location = new System.Drawing.Point(79, 695);
            this.cbConnectionstring.Margin = new System.Windows.Forms.Padding(4);
            this.cbConnectionstring.Name = "cbConnectionstring";
            this.cbConnectionstring.Size = new System.Drawing.Size(164, 24);
            this.cbConnectionstring.TabIndex = 1;
            this.cbConnectionstring.Text = "Connection String";
            this.cbConnectionstring.UseVisualStyleBackColor = true;
            this.cbConnectionstring.CheckedChanged += new System.EventHandler(this.cbConnectionstring_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.txtProducerMessage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(92, 328);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(398, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producer";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(182, 170);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(92, 72);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send Message";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtProducerMessage
            // 
            this.txtProducerMessage.Location = new System.Drawing.Point(124, 89);
            this.txtProducerMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtProducerMessage.Name = "txtProducerMessage";
            this.txtProducerMessage.Size = new System.Drawing.Size(229, 26);
            this.txtProducerMessage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message : ";
            // 
            // tabTopic
            // 
            this.tabTopic.Controls.Add(this.txtStatus2);
            this.tabTopic.Controls.Add(this.label8);
            this.tabTopic.Controls.Add(this.label7);
            this.tabTopic.Controls.Add(this.lblSub2Count);
            this.tabTopic.Controls.Add(this.lblSub1Count);
            this.tabTopic.Controls.Add(this.button1);
            this.tabTopic.Controls.Add(this.pictureBox2);
            this.tabTopic.Controls.Add(this.groupBox3);
            this.tabTopic.Controls.Add(this.groupBox4);
            this.tabTopic.Location = new System.Drawing.Point(4, 34);
            this.tabTopic.Margin = new System.Windows.Forms.Padding(4);
            this.tabTopic.Name = "tabTopic";
            this.tabTopic.Padding = new System.Windows.Forms.Padding(4);
            this.tabTopic.Size = new System.Drawing.Size(1523, 794);
            this.tabTopic.TabIndex = 1;
            this.tabTopic.Text = "Topic";
            this.tabTopic.UseVisualStyleBackColor = true;
            // 
            // txtStatus2
            // 
            this.txtStatus2.BackColor = System.Drawing.Color.Cornsilk;
            this.txtStatus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus2.Location = new System.Drawing.Point(618, 443);
            this.txtStatus2.Multiline = true;
            this.txtStatus2.Name = "txtStatus2";
            this.txtStatus2.Size = new System.Drawing.Size(203, 149);
            this.txtStatus2.TabIndex = 15;
            this.txtStatus2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(707, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Subscription 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(566, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Subscription 1";
            // 
            // lblSub2Count
            // 
            this.lblSub2Count.AutoSize = true;
            this.lblSub2Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub2Count.Location = new System.Drawing.Point(754, 248);
            this.lblSub2Count.Name = "lblSub2Count";
            this.lblSub2Count.Size = new System.Drawing.Size(27, 29);
            this.lblSub2Count.TabIndex = 12;
            this.lblSub2Count.Text = "0";
            // 
            // lblSub1Count
            // 
            this.lblSub1Count.AutoSize = true;
            this.lblSub1Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub1Count.Location = new System.Drawing.Point(613, 248);
            this.lblSub1Count.Name = "lblSub1Count";
            this.lblSub1Count.Size = new System.Drawing.Size(27, 29);
            this.lblSub1Count.TabIndex = 11;
            this.lblSub1Count.Text = "0";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ServiceBusDemo.Properties.Resources.Refresh1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(711, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 47);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::ServiceBusDemo.Properties.Resources.Flow2;
            this.pictureBox2.Location = new System.Drawing.Point(411, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(601, 320);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.btnTopicRec2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTopicRec2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtTopicRec1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btnTopicRec1);
            this.groupBox3.Location = new System.Drawing.Point(937, 324);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(495, 364);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consumer";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnTopicRec2
            // 
            this.btnTopicRec2.Location = new System.Drawing.Point(375, 188);
            this.btnTopicRec2.Name = "btnTopicRec2";
            this.btnTopicRec2.Size = new System.Drawing.Size(92, 33);
            this.btnTopicRec2.TabIndex = 25;
            this.btnTopicRec2.Text = "Receive";
            this.btnTopicRec2.UseVisualStyleBackColor = true;
            this.btnTopicRec2.Click += new System.EventHandler(this.btnTopicRec2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Subscription 2";
            // 
            // txtTopicRec2
            // 
            this.txtTopicRec2.Location = new System.Drawing.Point(132, 191);
            this.txtTopicRec2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTopicRec2.Name = "txtTopicRec2";
            this.txtTopicRec2.Size = new System.Drawing.Size(229, 30);
            this.txtTopicRec2.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 194);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "Message : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Subscription 1";
            // 
            // txtTopicRec1
            // 
            this.txtTopicRec1.Location = new System.Drawing.Point(127, 88);
            this.txtTopicRec1.Margin = new System.Windows.Forms.Padding(4);
            this.txtTopicRec1.Name = "txtTopicRec1";
            this.txtTopicRec1.Size = new System.Drawing.Size(229, 30);
            this.txtTopicRec1.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 91);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 25);
            this.label14.TabIndex = 19;
            this.label14.Text = "Message : ";
            // 
            // btnTopicRec1
            // 
            this.btnTopicRec1.Location = new System.Drawing.Point(375, 88);
            this.btnTopicRec1.Name = "btnTopicRec1";
            this.btnTopicRec1.Size = new System.Drawing.Size(92, 34);
            this.btnTopicRec1.TabIndex = 2;
            this.btnTopicRec1.Text = "Receive";
            this.btnTopicRec1.UseVisualStyleBackColor = true;
            this.btnTopicRec1.Click += new System.EventHandler(this.btnTopicRec1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtTopicSend2);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnSendTopic);
            this.groupBox4.Controls.Add(this.txtTopicSend1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(85, 329);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(398, 364);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Producer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Type : 2";
            // 
            // txtTopicSend2
            // 
            this.txtTopicSend2.Location = new System.Drawing.Point(129, 192);
            this.txtTopicSend2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTopicSend2.Name = "txtTopicSend2";
            this.txtTopicSend2.Size = new System.Drawing.Size(229, 30);
            this.txtTopicSend2.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 195);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Message : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Type : 1";
            // 
            // btnSendTopic
            // 
            this.btnSendTopic.Location = new System.Drawing.Point(129, 251);
            this.btnSendTopic.Name = "btnSendTopic";
            this.btnSendTopic.Size = new System.Drawing.Size(113, 72);
            this.btnSendTopic.TabIndex = 2;
            this.btnSendTopic.Text = "Send Messages";
            this.btnSendTopic.UseVisualStyleBackColor = true;
            this.btnSendTopic.Click += new System.EventHandler(this.btnSendTopic_Click);
            // 
            // txtTopicSend1
            // 
            this.txtTopicSend1.Location = new System.Drawing.Point(124, 89);
            this.txtTopicSend1.Margin = new System.Windows.Forms.Padding(4);
            this.txtTopicSend1.Name = "txtTopicSend1";
            this.txtTopicSend1.Size = new System.Drawing.Size(229, 30);
            this.txtTopicSend1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Message : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 37);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Producer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 37);
            this.panel2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(7, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Consumer";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(398, 37);
            this.panel3.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(7, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Publisher";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.label16);
            this.panel4.Location = new System.Drawing.Point(0, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(495, 37);
            this.panel4.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(7, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Subscriber";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 832);
            this.Controls.Add(this.tabDemo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Azure Service Bus Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabDemo.ResumeLayout(false);
            this.tabQueue.ResumeLayout(false);
            this.tabQueue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabTopic.ResumeLayout(false);
            this.tabTopic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDemo;
        private System.Windows.Forms.TabPage tabQueue;
        private System.Windows.Forms.TabPage tabTopic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbConnectionstring;
        private System.Windows.Forms.TextBox txtCS;
        private System.Windows.Forms.TextBox txtProducerMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.TextBox txtConsumerMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblSub1Count;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTopicRec1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSendTopic;
        private System.Windows.Forms.TextBox txtTopicSend1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSub2Count;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTopicSend2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTopicRec2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTopicRec1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnTopicRec2;
        private System.Windows.Forms.TextBox txtStatus1;
        private System.Windows.Forms.TextBox txtStatus2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
    }
}

