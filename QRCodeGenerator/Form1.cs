using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; //Include this namespace 

namespace QRCodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            txtTime.Text = now.ToShortTimeString();
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
           /* DateTime now = DateTime.Now;
            txtTime.Text = now.ToShortTimeString();*/
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {


            QR_Generator();
            //string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
            //// Console.WriteLine(hostName);
            //// Get the IP  
            //string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();

            //txtIP.Text = myIP;
            //QRCoder.QRCodeGenerator QRGenerator = new QRCoder.QRCodeGenerator();
            //DateTime now = DateTime.Now;
            //dateTimePickerDate.Text = now.ToLongDateString();
            //txtTime.Text = now.ToShortTimeString();

            //var qrText = cmbSubject.Text + "\n" + txtSection.Text + "\n" + dateTimePickerDate.Text + "\n" + txtTime.Text +"\n";
            //var MyData = QRGenerator.CreateQrCode(cmbSubject.Text + ",\n" + txtSection.Text + ", \n" + dateTimePickerDate.Text + ",\n" + txtTime.Text + ",\n" + txtIP.Text + ",\n", QRCoder.QRCodeGenerator.ECCLevel.H);
            //var code = new QRCoder.QRCode(MyData);
            //pcQRImage.Image = code.GetGraphic(50);
        }
        public void QR_Generator() {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
            // Console.WriteLine(hostName);
            // Get the IP  
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();

            txtIP.Text = myIP;
            QRCoder.QRCodeGenerator QRGenerator = new QRCoder.QRCodeGenerator();
            DateTime now = DateTime.Now;
            dateTimePickerDate.Text = now.ToLongDateString();
            txtTime.Text = now.ToShortTimeString();

            //var qrText = cmbSubject.Text + "\n" + txtSection.Text + "\n" + dateTimePickerDate.Text + "\n" + txtTime.Text + "\n";
            var MyData = QRGenerator.CreateQrCode(cmbSubject.Text + ",\n" + txtSection.Text + ", \n" + dateTimePickerDate.Text + ",\n" + txtTime.Text + ",\n" + txtIP.Text + ",\n", QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pcQRImage.Image = code.GetGraphic(50);
        }
      
    }
}
