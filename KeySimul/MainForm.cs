/*
 * Created by SharpDevelop.
 * User: Ortak
 * Date: 11/19/2021
 * Time: 12:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Threading;

namespace KeySimul
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class KeySimulator : Form
	{
		public KeySimulator()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			f1Toggle = 0;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		[DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
		
		[DllImport("USER32.DLL")]
		public static extern bool SetForegroundWindow(IntPtr hWnd);	
		
		void Button1Click(object sender, EventArgs e)	//KeySimul - SharpDevelop
		{
			if(f1Toggle == 0) {
				send2App(1);
				f1Toggle = 1;
			}
			else{
				send2App(3);
				f1Toggle = 0;
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			send2App(2);
			
		}
		
		void send2App(uint key){
			string str;
			str = textBox1.Text;
			
			if(textBox1.Text != ""){
				IntPtr appWindow = FindWindow(null, str);
				if (SetForegroundWindow(appWindow));
			}
			
			if(key == 1){
				SendKeys.Send("{F1}");
			}
			else if(key == 2){
				SendKeys.Send("{F2}");				
			}
			else if(key == 3){
				SendKeys.Send(" ");				
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			list_Ports();
			appName();
			timer1.Enabled = true;
		}
		
		public int appName(){
			int ret = 0;
			if(rbDefault.Checked){
				textBox1.Text = "EzCad2.12.1 - Adsız";
				textBox1.Enabled = false;
			}
			else if(rbUser.Checked){
				textBox1.Text = "";
				textBox1.Enabled = true;
			}
			else if (rbActive.Checked) {
				textBox1.Text = "";
				textBox1.Enabled = false;
			}
			return ret;
		}
		
		public int list_Ports()
        {
            int ret = 0;
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length < 1) ret = -1;
            else
            {
                portList.Items.Clear();
                // Display each port name to the console.
                foreach (string port in ports)
                {
                    portList.Items.Add(port);
                }
            }
            return ret;
        }
		
		     private int openPort(string portname)
        {
         
            if (serialConnect.Text.CompareTo("Bağlan") == 0)
            {
                if (serialPort1.IsOpen == true)
                {
                    serialPort1.Close();

                }
                try
                {
                    serialPort1.PortName = portname;
                    serialPort1.BaudRate = 115200;
                    serialPort1.Open();
                }
                catch (Exception ex)
                {
                    if (ex is UnauthorizedAccessException)
                    {
                        //                        MessageBox.Show("Port Erişimi Sağlanamadı", "Uyarı");
                        infoBox.Text = "err_PortCannotOpen";
                    }
                    return -2;
                }

                if (serialPort1.IsOpen) serialConnect.Text = "Kapat";
            }
            else
            {
                serialPort1.Close();
                serialConnect.Text = "Bağlan";
            }
            return 0;
        }
		
		void SerialConnectClick(object sender, EventArgs e)
		{
			
			 if (portList.SelectedItem != null)
            {
                openPort(portList.Text);
                if (serialPort1.IsOpen)
                {
                	st_fetch = ST_SERIAL_OK;
                	infoBox.Text = "";
                }
            }
            else infoBox.Text = "Select Port";
			
		}
		
		
		void GroupBox1Enter(object sender, EventArgs e)
		{
			appName();
		}
		
		void RbUserCheckedChanged(object sender, EventArgs e)
		{
			appName();
		}
		
		void RbActiveCheckedChanged(object sender, EventArgs e)
		{
			appName();
		}
		
		void RbDefaultCheckedChanged(object sender, EventArgs e)
		{
			appName();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			string res;
			if(!serialPort1.IsOpen){
				infoBox.Text = "Port Closed";
				return;
			}
			else if(serialPort1.BytesToRead>0){
				res = serialPort1.ReadExisting();
				char[] inBuf = res.ToCharArray();
				if(inBuf[0] == 0x01) {
					if(f1Toggle == 0) {
						send2App(1);
						f1Toggle = 1;
					}
					else{
						send2App(3);
						f1Toggle = 0;
					}
				}
				else if(inBuf[0] == 0x02) send2App(2);
			}				
		}
	}
}
