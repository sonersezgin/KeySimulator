/*
 * Created by SharpDevelop.
 * User: Ortak
 * Date: 11/19/2021
 * Time: 12:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace KeySimul
{
	partial class KeySimulator
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.serialConnect = new System.Windows.Forms.Button();
			this.portList = new System.Windows.Forms.ComboBox();
			this.infoBox = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbActive = new System.Windows.Forms.RadioButton();
			this.rbUser = new System.Windows.Forms.RadioButton();
			this.rbDefault = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 166);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(111, 66);
			this.button1.TabIndex = 0;
			this.button1.Text = "F1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(151, 166);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(105, 66);
			this.button2.TabIndex = 1;
			this.button2.Text = "F2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// serialConnect
			// 
			this.serialConnect.Location = new System.Drawing.Point(188, 11);
			this.serialConnect.Margin = new System.Windows.Forms.Padding(2);
			this.serialConnect.Name = "serialConnect";
			this.serialConnect.Size = new System.Drawing.Size(63, 23);
			this.serialConnect.TabIndex = 6;
			this.serialConnect.Text = "Connect";
			this.serialConnect.UseVisualStyleBackColor = true;
			this.serialConnect.Click += new System.EventHandler(this.SerialConnectClick);
			// 
			// portList
			// 
			this.portList.FormattingEnabled = true;
			this.portList.Location = new System.Drawing.Point(92, 11);
			this.portList.Margin = new System.Windows.Forms.Padding(2);
			this.portList.Name = "portList";
			this.portList.Size = new System.Drawing.Size(84, 21);
			this.portList.TabIndex = 5;
			// 
			// infoBox
			// 
			this.infoBox.Location = new System.Drawing.Point(0, 239);
			this.infoBox.Margin = new System.Windows.Forms.Padding(2);
			this.infoBox.Name = "infoBox";
			this.infoBox.Size = new System.Drawing.Size(265, 20);
			this.infoBox.TabIndex = 7;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(92, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(159, 20);
			this.textBox1.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(9, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Button Port";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(9, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Application";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbActive);
			this.groupBox1.Controls.Add(this.rbUser);
			this.groupBox1.Controls.Add(this.rbDefault);
			this.groupBox1.Location = new System.Drawing.Point(12, 65);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(239, 45);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Hedef";
			this.groupBox1.Enter += new System.EventHandler(this.GroupBox1Enter);
			// 
			// rbActive
			// 
			this.rbActive.Location = new System.Drawing.Point(166, 14);
			this.rbActive.Name = "rbActive";
			this.rbActive.Size = new System.Drawing.Size(68, 24);
			this.rbActive.TabIndex = 2;
			this.rbActive.Text = "Active";
			this.rbActive.UseVisualStyleBackColor = true;
			this.rbActive.CheckedChanged += new System.EventHandler(this.RbActiveCheckedChanged);
			// 
			// rbUser
			// 
			this.rbUser.Location = new System.Drawing.Point(89, 14);
			this.rbUser.Name = "rbUser";
			this.rbUser.Size = new System.Drawing.Size(104, 24);
			this.rbUser.TabIndex = 1;
			this.rbUser.Text = "User";
			this.rbUser.UseVisualStyleBackColor = true;
			this.rbUser.CheckedChanged += new System.EventHandler(this.RbUserCheckedChanged);
			// 
			// rbDefault
			// 
			this.rbDefault.Checked = true;
			this.rbDefault.Location = new System.Drawing.Point(7, 14);
			this.rbDefault.Name = "rbDefault";
			this.rbDefault.Size = new System.Drawing.Size(104, 24);
			this.rbDefault.TabIndex = 0;
			this.rbDefault.TabStop = true;
			this.rbDefault.Text = "Default";
			this.rbDefault.UseVisualStyleBackColor = true;
			this.rbDefault.CheckedChanged += new System.EventHandler(this.RbDefaultCheckedChanged);
			// 
			// KeySimulator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(266, 261);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.portList);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.infoBox);
			this.Controls.Add(this.serialConnect);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(282, 300);
			this.MinimumSize = new System.Drawing.Size(282, 300);
			this.Name = "KeySimulator";
			this.Text = "KeySimul";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RadioButton rbDefault;
		private System.Windows.Forms.RadioButton rbUser;
		private System.Windows.Forms.RadioButton rbActive;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox infoBox;
		private System.Windows.Forms.ComboBox portList;
		private System.Windows.Forms.Button serialConnect;
		private System.Windows.Forms.Timer timer1;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		
		private byte st_fetch;
		private byte f1Toggle;
		
		private System.DateTime lastRecord;
		private System.DateTime dtnow;
		private System.TimeSpan tspan;
		
		private const byte ST_IDLE = 0;
		private const byte ST_SERIAL_OK = 1;
		private const byte ST_SET_CON_OK = 2;
		private const byte ST_SET_INIT_OK = 3;
		private const byte ST_DUT_RING	= 4;
		private const byte ST_DUT_OK = 5;
		private const byte ST_FETCH_OK = 6;	
	
	}
}
