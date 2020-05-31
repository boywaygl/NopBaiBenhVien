using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;
using Apache.NMS.Util;
using BenhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Receiver
{
    public partial class ReceiForm : Form
    {
        string a, b, c, d;
        public ReceiForm()
        {
            InitializeComponent();
            receiver();
        }
        public void receiver()
        {

            IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
            IConnection con = factory.CreateConnection("admin", "admin");
            con.Start();
            ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);
            IDestination destination = SessionUtil.GetDestination(session, "Test");
           // ActiveMQQueue destination = new ActiveMQQueue("Nghia");
            IMessageConsumer consumer = session.CreateConsumer(destination);
            //nhận mesage - lắng nghe
            consumer.Listener += new MessageListener(Consumer_Listener);
            
        }
        private void Consumer_Listener(IMessage message)
        {
            IObjectMessage objectMessage = message as IObjectMessage;
            BenhNhan benhNhan = ((BenhNhan)(objectMessage.Body));
            tbmsbn.Invoke(new Action(() => tbmsbn.Text = benhNhan.Msbn));
            tbhoten.Invoke(new Action(() => tbhoten.Text = benhNhan.Hoten));
            tbcmnd.Invoke(new Action(() => tbcmnd.Text = benhNhan.Socmnd));
            tbdiachi.Invoke(new Action(() => tbdiachi.Text = benhNhan.Diachi));

        }

        private void ReceiForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}

