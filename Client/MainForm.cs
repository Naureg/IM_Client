using System;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client {
    public partial class MainForm : Form{
        //keep the server's time locally instead of sending an 8 byte serialized DateTime object with each message
        public Socket ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public MainForm(){
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }
        public void AppendMessage(String message, DateTime time, String sender){
            MessagesBox.SelectionStart = MessagesBox.TextLength;
            MessagesBox.SelectionLength = 0;
            MessagesBox.SelectionColor = Color.FromArgb(58, 144, 229);
            MessagesBox.AppendText("[" + time.ToString("HH:mm:ss tt") + "] " + sender + ": ");
            MessagesBox.SelectionColor = MessagesBox.ForeColor;
            MessagesBox.AppendText(message + Environment.NewLine);
        }
        public void AppendErrorMessage(String message, Color color){
            MessagesBox.SelectionStart = MessagesBox.TextLength;
            MessagesBox.SelectionLength = 0;
            MessagesBox.SelectionColor = color;
            MessagesBox.AppendText(message);
        }
    }
}
