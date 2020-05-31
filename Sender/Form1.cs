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

namespace Sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Btnluu_Click_1(object sender, EventArgs e)
        {
            IObjectMessage objectMessage;
            BenhNhan benhNhan = new BenhNhan();
            benhNhan.Msbn = tbmsbn.Text.ToString();
            benhNhan.Hoten = tbhoten.Text.ToString();
            benhNhan.Socmnd = tbcmnd.Text.ToString();
            benhNhan.Diachi = tbdiachi.Text.ToString();

            IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
            //tạo connection
            IConnection con = factory.CreateConnection("admin", "admin");
            con.Start();//nối tới MOM
                        //tạo session
            ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);
            //tạo producer
            IDestination queuedestination = SessionUtil.GetDestination(session, "Test");
           // ActiveMQQueue destination = new ActiveMQQueue("Nghia");
            IMessageProducer producer = session.CreateProducer(queuedestination);
            objectMessage = session.CreateObjectMessage(benhNhan);
            //string xml = genXML(p).ToLower();
            //  string xml = new XMLObjectConverter<BenhNhan>().object2XML(p);
            //  Console.WriteLine(xml.ToLower());
            //  IMessage msg = new ActiveMQTextMessage("Hola mondo");
            producer.Send(objectMessage);
            //shutdown
            session.Close();
            con.Close();
        }
    }
}
