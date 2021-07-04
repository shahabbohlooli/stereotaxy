using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Drawing.Text;
//using WindowsFormsApplication1;
using System.Management;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using Linearstar.Windows.RawInput;
using System.Windows.Forms;

namespace Stereotaxy
{


    public partial class Main : Form
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimer_1 = new System.Windows.Forms.Timer();
        public string port_name;
        public SerialPort port;
        // private static Controller controller;
        //private State stateOld;
        Single x_axis_var = 0;
        Single y_axis_var = 0;
        Single z_axis_var = 0;
        Single axis_speed;
        int joy_x;
        int joy_y;
        int joy_z;
        int drill_count = 0;
        int force_sensor;
        int low_limit_value;
        int up_limit_value;
        int timeInterval, drill_speed;
        int timeInterval_1 = 1000;
        bool drill_state=false;
        bool auto_drill = false;
        bool en_force_sensor = false;
        Single drill_xoffset, drill_yoffset, drill_zoffset, drill_length;

        RawInputReceiverWindow window1 = new RawInputReceiverWindow();
        RawInputData data;
        RawInputHidData data_1;
        private float x, y, z;
        string sensor="";
        int passed_drill_up_limit = 0;
        private void timerEvent_Tick(object sender, EventArgs e)
        {

            if (port != null && port.IsOpen && drill_count % 2 != 0 && drill_count > 0)
            {


                if (en_force_sensor == true)
                {
                    port.WriteLine("M31");

                    if (force_sensor > low_limit_value && drill_count > 0)
                    {
                        if (auto_drill==true) { 
                        if (drill_state == false)
                        {

                            port.WriteLine("M106 S255");
                            drill_state = true;
                        }

                        }


                    }
                    if (force_sensor > up_limit_value)
                    {

                        passed_drill_up_limit = 1;

                    }
                    if (force_sensor < up_limit_value && drill_state == true && passed_drill_up_limit == 1)
                    {


                        if (auto_drill == true)
                        {
                            port.WriteLine("M106 S0");
                            port.WriteLine("M106 S0");
                        }
                    }
                    if (force_sensor < low_limit_value)
                    {
                        drill_state = false;
                        passed_drill_up_limit = 0;
                    }
                }
            }
        }
        private void timerEvent_1_Tick(object sender, EventArgs e)
        {

            if (port != null && port.IsOpen)
            {



                //if (drill_count > 0 && drill_count % 2 != 0)
                //{
                    if (force_sensor > up_limit_value)
                    {
                    Single travel_step = -drill_length;
                    port.WriteLine("G91");
                    port.WriteLine("G0 Z" + travel_step + "F100");
                    z_axis_var += travel_step;
                    Z_axis.Text = z_axis_var.ToString("F3");

                }
                    




               // }
            }
        }



        public static string[] GetBluetoothPort()
        {
            Regex regexPortName = new Regex(@"(COM\d+)");

            List<string> portList = new List<string>();

            ManagementObjectSearcher searchSerial = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity");

            foreach (ManagementObject obj in searchSerial.Get())
            {
                string name = obj["Name"] as string;
                string classGuid = obj["ClassGuid"] as string;
                string deviceID = obj["DeviceID"] as string;

                if (classGuid != null && deviceID != null)
                {
                    if (String.Equals(classGuid, "{4d36e978-e325-11ce-bfc1-08002be10318}", StringComparison.InvariantCulture))
                    {
                        string[] tokens = deviceID.Split('&');

                        if (tokens.Length >= 4)
                        {
                            string[] addressToken = tokens[4].Split('_');
                            string bluetoothAddress = addressToken[0];

                            Match m = regexPortName.Match(name);
                            string comPortNumber = "";
                            if (m.Success)
                            {
                                comPortNumber = m.Groups[1].ToString();
                            }

                            if (Convert.ToUInt64(bluetoothAddress, 16) > 0)
                            {
                                string bluetoothName = GetBluetoothRegistryName(bluetoothAddress);
                                //portList.Add(String.Format("{0} {1} ({2})", bluetoothName, bluetoothAddress, comPortNumber));
                                portList.Add(String.Format("{0} {1} ({2})", comPortNumber, bluetoothName, bluetoothAddress));
                            }
                        }
                    }
                }
            }

            return portList.ToArray();
        }

        private static string GetBluetoothRegistryName(string address)
        {
            string deviceName = "";

            string registryPath = @"SYSTEM\CurrentControlSet\Services\BTHPORT\Parameters\Devices";
            string devicePath = String.Format(@"{0}\{1}", registryPath, address);

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(devicePath))
            {
                if (key != null)
                {
                    Object o = key.GetValue("Name");

                    byte[] raw = o as byte[];

                    if (raw != null)
                    {
                        deviceName = Encoding.ASCII.GetString(raw);
                    }
                }
            }

            return deviceName;
        }

        public void UpdatePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comboPort.Items.Clear();
            //comboPort.Items.Add("Virtual Printer");

            //foreach (string p in SerialPort.GetPortNames())
            //{
            //    comboPort.Items.Add(p);
            //}
            //foreach (string p in GetBluetoothPort())
            foreach (string port in ports)
            {
                comboPort.Items.Add(port);

            }


        }
        public Main()
        {
            InitializeComponent();
            UpdatePorts();
            Setup();
            /* Adds the event and the event handler for the method that will 
          process the timer event to the timer. */
            myTimer.Tick += new EventHandler(timerEvent_Tick);
            myTimer_1.Tick += new EventHandler(timerEvent_1_Tick);
            // Sets the timer interval to 5 seconds.

        }

        private void buttonRefreshPorts_Click(object sender, EventArgs e)
        {
            UpdatePorts();
        }

        private void comboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            String port_ids = (string)comboPort.SelectedItem;
            String[] ports = port_ids.Split(' ');
            port_name = ports[0];
            //  messageBx.Text = port_name;
        }

        private void Conn_Click(object sender, EventArgs e)
        {
            //[2400, 9600, 19200, 38400, 57600, 115200, 250000, 500000, 1000000]
            port = new SerialPort(port_name, 19200, Parity.None, 8, StopBits.One);
            port.ReadTimeout = 2000;
            try
            {
                if (!(port.IsOpen))
                    port.Open();
                port.Write("\r\n");

                port.WriteLine("M115");
                //port.WriteLine("G1 F250");
                //Enable Event Handler
                port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

            }
            catch (Exception ex)
            {
                messageBx.Text += "Error opening/writing to serial port :: " + ex.Message + "Error!";
            }
            RawInputDevice.RegisterDevice(HidUsageAndPage.Joystick, RawInputDeviceFlags.ExInputSink, window1.Handle);
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (port != null && port.IsOpen) {
            int intBuffer;
            intBuffer = port.BytesToRead;
            byte[] byteBuffer = new byte[intBuffer];
            //port.Read(byteBuffer, 0, intBuffer);
            this.Invoke(new EventHandler(DoUpDate));
        }
        }
            
        private void DoUpDate(object s, EventArgs e)
        {
            //port.WriteLine("M31");
            sensor = port.ReadLine();
            if (sensor.Contains("Sensor"))
            {
                string text_value = sensor.Substring(13);
                

                force_sensor = int.Parse(text_value);
                
            }
            
           
            messageBx.Text += sensor;
            messageBx.Text += "\r\n";

        }
        

        private void Disconn_Click(object sender, EventArgs e)
        {
            try
            {
                if (port.IsOpen && port != null)
                {
                    port.WriteLine("M106 S0");
                    port.WriteLine("M18");
                    port.Close();
                    messageBx.Text += "com port sucessfully closed";
                }
            }
            catch (Exception ex)
            {
                messageBx.Text += "Error Closing serial port :: " + ex.Message + "Error!";
            }
            RawInputDevice.UnregisterDevice(HidUsageAndPage.Joystick);
        }
        private void sendBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send_Click(this, new EventArgs());
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {

            port.WriteLine("G91");
            messageBx.Text += "G91 \r\n";
            port.WriteLine("G1 " + sendBx.Text + "F" + fBox.Text);
            messageBx.Text += "G1 " + sendBx.Text + "\r\n";
            port.WriteLine("G90");
            messageBx.Text += "G90 \r\n";

            if (sendBx.Text.Substring(0, 1) == "X") {
                x_axis_var += (Single)Convert.ToSingle(sendBx.Text.Remove(0, 1));
                X_axis.Text = x_axis_var.ToString("F3"); }
            if (sendBx.Text.Substring(0, 1) == "Y")
            {
                y_axis_var += (Single)Convert.ToSingle(sendBx.Text.Remove(0, 1));
                Y_axis.Text = y_axis_var.ToString("F3");
            }
            if (sendBx.Text.Substring(0, 1) == "Z")
            {
                z_axis_var += (Single)Convert.ToSingle(sendBx.Text.Remove(0, 1));
                Z_axis.Text = z_axis_var.ToString("F3");
            }

        }

        private void enSteppers_Click(object sender, EventArgs e)
        {
            port.WriteLine("M17");
        }

        private void disSteppers_Click(object sender, EventArgs e)
        {
            port.WriteLine("M18");
        }





        private void Main_Load(object sender, EventArgs e)
        {
            var sr = new StreamReader("Settings.txt");
            low_limit_value = int.Parse(sr.ReadLine().ToString());
            up_limit_value = int.Parse(sr.ReadLine().ToString());
            timeInterval = int.Parse(sr.ReadLine().ToString());
            drill_xoffset= Single.Parse(sr.ReadLine().ToString());
            drill_yoffset= Single.Parse(sr.ReadLine().ToString());
            drill_zoffset= Single.Parse(sr.ReadLine().ToString());
            drill_length= Single.Parse(sr.ReadLine().ToString());
            drill_speed= int.Parse(sr.ReadLine().ToString());
            auto_drill= bool.Parse(sr.ReadLine().ToString());
            en_force_sensor = bool.Parse(sr.ReadLine().ToString()); 
            sr.Close();
            if (timeInterval > 0)
            {
                myTimer.Interval = timeInterval;
                myTimer.Start();
            }
            if (drill_speed > 0)
            {
                myTimer_1.Interval = drill_speed;
                myTimer_1.Start();
            }
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();
            Z_axis.Text = "0.000";
            Y_axis.Text = "0.000";
            X_axis.Text = "0.000";

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.sendBx, "Use coordinates as Y or X or Z and the length you wants to go e.g. Y10.1 or Y-10.1 and clik send button.(unit is mm)");
            toolTip1.SetToolTip(this.enSteppers, "Enables all X,Y and Z motors. it means that all axes will freeze in the coordinates they aleardy have.");
            toolTip1.SetToolTip(this.disSteppers, "Disables all X,Y and Z motors. it means that all axes will be loose and movable freely.");
            toolTip1.SetToolTip(this.comboPort, "Choose the serial port for connecting ... ");
            toolTip1.SetToolTip(this.Send, "Click to send coordinates to device!");
            foreach (Control control in this.Controls)
            {
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(control_PreviewKeyDown);
            }
        }
        void control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp || e.KeyCode == Keys.PageDown || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Shift)
            {
                e.IsInputKey = true;
                float move;
                // MessageBox.Show("this is it!");
                if (port.IsOpen && port != null)
                {
                    move = 0.1F;
                    if ((e.KeyCode == Keys.PageUp || e.KeyCode == Keys.PageDown || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right) && e.Modifiers == Keys.Shift)
                        move = 1.0F;

                    if (e.KeyCode == Keys.Right)
                    {

                        //x = speed_xy * x;
                        port.WriteLine("G91");
                        port.WriteLine("G0 X" + move.ToString("F3") + "F" + fBox.Text);
                        //port.WriteLine("G90");
                        x_axis_var += move;
                        X_axis.Text = x_axis_var.ToString("F3");
                    }
                    if (e.KeyCode == Keys.Left)
                    {

                        move = -move;
                        //x = speed_xy * x;
                        port.WriteLine("G91");
                        port.WriteLine("G0 X" + move.ToString("F3") + "F" + fBox.Text);
                        //port.WriteLine("G90");
                        x_axis_var += move;
                        X_axis.Text = x_axis_var.ToString("F3");
                    }
                    if (e.KeyCode == Keys.Up)
                    {

                        //x = speed_xy * x;
                        port.WriteLine("G91");
                        port.WriteLine("G0 Y" + move.ToString("F3") + "F" + fBox.Text);
                        //port.WriteLine("G90");
                        y_axis_var += move;
                        Y_axis.Text = y_axis_var.ToString("F3");
                    }
                    if (e.KeyCode == Keys.Down)
                    {

                        move = -move;
                        //x = speed_xy * x;
                        port.WriteLine("G91");
                        port.WriteLine("G0 Y" + move.ToString("F3") + "F" + fBox.Text);
                        //port.WriteLine("G90");
                        y_axis_var += move;
                        Y_axis.Text = y_axis_var.ToString("F3");
                    }
                    if (e.KeyCode == Keys.PageUp)
                    {

                        //x = speed_xy * x;
                        port.WriteLine("G91");
                        port.WriteLine("G0 Z" + move.ToString("F3") + "F" + fBox.Text);
                        //port.WriteLine("G90");
                        z_axis_var += move;
                        Z_axis.Text = z_axis_var.ToString("F3");
                    }
                    if (e.KeyCode == Keys.PageDown)
                    {

                        move = -move;
                        //x = speed_xy * x;
                        port.WriteLine("G91");
                        port.WriteLine("G0 Z" + move.ToString("F3") + "F" + fBox.Text);
                        //port.WriteLine("G90");
                        z_axis_var += move;
                        Z_axis.Text = z_axis_var.ToString("F3");
                    }
                }

            }
        }


        private void fBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {




        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            RawInputDevice.UnregisterDevice(HidUsageAndPage.Joystick);
            //RawInputDevice.UnregisterDevice(HidUsageAndPage.GamePad);
            if (port.IsOpen && port != null)
            {
                port.WriteLine("M106 S0");
                port.WriteLine("M18");
                port.Close();
            }
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void drill_Click(object sender, EventArgs e)
        {
            drill_count++;
            if (port.IsOpen && port != null )
            {
                if (drill_count % 2 != 0 && drill_count > 0)
                {
                    drill.BackColor = Color.CadetBlue;
                    //drill_zoffset = 20;
                    //drill_length = 2.000F;
                    //drill_speed = 50;
                    port.WriteLine("G91");
                    port.WriteLine("G0 Z" + drill_zoffset + "F" + fBox.Text);
                    z_axis_var += drill_zoffset;
                    Z_axis.Text = z_axis_var.ToString("F3");
                    port.WriteLine("G91");
                    port.WriteLine("G0 X" + drill_xoffset + "F" + fBox.Text);
                    x_axis_var += drill_xoffset;
                    X_axis.Text = x_axis_var.ToString("F3");
                    port.WriteLine("G91");
                    port.WriteLine("G0 Y" + drill_yoffset + "F" + fBox.Text);
                    y_axis_var += drill_yoffset;
                    Y_axis.Text = y_axis_var.ToString("F3");
                    port.WriteLine("G0 Z" + -drill_zoffset + "F" + fBox.Text);
                    z_axis_var += drill_zoffset;
                    Z_axis.Text = z_axis_var.ToString("F3");
                    if (auto_drill == false)
                    {
                        port.WriteLine("M106 S255");
                        drill_state = true;

                    }
                    
                }
                if (drill_count % 2 == 0 && drill_count > 0)
                {
                    drill.BackColor = Color.IndianRed;
                    if (auto_drill == false)
                    {
                        port.WriteLine("M106 S0");
                        drill_state = false;

                    }

                }


            }
            else { MessageBox.Show("Please check the system is connected!"); }
        }

        private void messageBx_TextChanged(object sender, EventArgs e)
        {
            messageBx.SelectionStart = messageBx.Text.Length;
            messageBx.ScrollToCaret();
        }

        private void SenosorRead_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void setHome_Click_1(object sender, EventArgs e)
        {
            Z_axis.Text = "0.000";
            Y_axis.Text = "0.000";
            X_axis.Text = "0.000";
            z_axis_var = 0;
            y_axis_var = 0;
            x_axis_var = 0;

        }

        
     public void Setup()
        {

            var devices = RawInputDevice.GetDevices();
            var hid = devices.OfType<RawInputHid>();
            var keyboards = devices.OfType<RawInputKeyboard>();
           //RawInputKeyboard keyboard1=keyboards.ElementAt(0);
           
           
          // var window1 = new RawInputReceiverWindow();
            var window2 = new RawInputReceiverWindow();
            
           
           window2.Input += (sender, e) =>
         {
                // Catch your input here!
               var data1 = e.Data;
            
               RawInputKeyboardData data_2 = (RawInputKeyboardData)data1;
             // messageBx.Text = data_2.Device.DeviceType.ToString();
            // X_axis.Text = data_2.Keyboard.ScanCode.ToString();
            // messageBx.Text = data.ToString();

            };
            // Register the HidUsageAndPage to watch any device.
            window1.Input += (sender, e) =>
            {
                
                // Catch your input here!
                 data = e.Data;
                 data_1 = (RawInputHidData)data;
                joy_x = data_1.Hid.RawData.ElementAt(4) - 128;
                joy_y = data_1.Hid.RawData.ElementAt(5) - 128;
                joy_z = data_1.Hid.RawData.ElementAt(2) - 128;
                axis_speed = 0.05f;
                if (data_1.Hid.RawData.ElementAt(7) == 4 || data_1.Hid.RawData.ElementAt(7) == 8)
                {
                    axis_speed = 0.1f;
                }
                
               // if (data_1.Hid.RawData.ElementAt(4) != 128)
                   // x_axis_var += joy_x * axis_speed;


                //port.WriteLine("G1 " + "X" + (joy_x * axis_speed) + "F" + fBox.Text);
               // if (data_1.Hid.RawData.ElementAt(5) != 128)
                  //  y_axis_var += joy_y * axis_speed;
                //Y_axis.Text = y_axis_var.ToString("F3");
               // if (data_1.Hid.RawData.ElementAt(2) != 128)
                 //   z_axis_var += joy_z * axis_speed;
               // Z_axis.Text = z_axis_var.ToString("F3");
                //Z_axis.Text = data_1.Hid.RawData.ElementAt(6).ToString();
                if (port != null && port.IsOpen)
                {

                    int z_max = 50;
                    int y_max = 50;
                    int x_max = 50;

                    //MessageBox.Show("Joystick is online!");
                    //v.LeftMotorSpeed = (ushort)(controller.GetState().Gamepad.LeftTrigger * 255);
                    // v.RightMotorSpeed = (ushort)(controller.GetState().Gamepad.RightTrigger * 255);

                    if (joy_x != 0)
                    {

                        if (x_axis_var < x_max)
                        {
                            if (joy_x < 0)
                                axis_speed = -axis_speed;
                            //X_axis.Text = x_axis_var.ToString("F3");
                            //x_axis_var += joy_x * axis_speed;
                            x =  axis_speed;
                            //x = speed_xy * x;
                            port.WriteLine("G91");
                            port.WriteLine("G0 X" + x.ToString("F3") + "F" + fBox.Text);
                            //port.WriteLine("G90");
                            x_axis_var += x;
                            X_axis.Text = x_axis_var.ToString("F3");
                        }
                     }

                    if (joy_y != 0)
                    {
                        if (y_axis_var < y_max)
                        {
                            if (joy_y > 0)
                                axis_speed = -axis_speed;
                            //y = speed_xy * y;
                            y =  axis_speed;
                            port.WriteLine("G91");
                            port.WriteLine("G0 Y" + y.ToString() + "F" + fBox.Text);
                            //port.WriteLine("G90");
                            y_axis_var += y;
                            Y_axis.Text = y_axis_var.ToString("F3");
                        }
                     }

                    if (joy_z != 0)
                    {
                        if (z_axis_var < z_max)
                        {
                            // z = speed_z * z;
                            if (joy_z > 0)
                                axis_speed = -axis_speed;
                            z =  axis_speed;
                            port.WriteLine("G91");
                            port.WriteLine("G0 Z" + z.ToString() + "F" + fBox.Text);
                            //port.WriteLine("G90");
                            z_axis_var += z;
                            Z_axis.Text = z_axis_var.ToString("F3");
                        }
                    }
                    // controller.SetVibration(v);
                    if (data_1.Hid.RawData.ElementAt(6) == 143) //X buttun

                    {
                        //messageBx.Text = controller.GetState().Gamepad.Buttons + "\r\n";
                        x_axis_var = 0;
                        X_axis.Text = x_axis_var.ToString("F3");
                        port.WriteLine("G92 X0");
                    }
                    if (data_1.Hid.RawData.ElementAt(6) == 31) //Y buttun

                    {
                        //messageBx.Text = controller.GetState().Gamepad.Buttons + "\r\n";
                        y_axis_var = 0;
                        Y_axis.Text = y_axis_var.ToString("F3");
                        port.WriteLine("G92 Y0");
                    }

                    if (data_1.Hid.RawData.ElementAt(6) == 47) //Z buttun
                     {
                            //  messageBx.Text = controller.GetState().Gamepad.Buttons + "\r\n";
                            z_axis_var = 0;
                            Z_axis.Text = z_axis_var.ToString("F3");
                            port.WriteLine("G92 Z0");
                     }

                      
                        if (data_1.Hid.RawData.ElementAt(6) == 79) //A buttun
                    
                        {
                            // messageBx.Text = controller.GetState().Gamepad.Buttons + "\r\n";
                            x_axis_var = 0;
                            X_axis.Text = x_axis_var.ToString("F3");
                            y_axis_var = 0;
                            Y_axis.Text = y_axis_var.ToString("F3");
                            z_axis_var = 0;
                            Z_axis.Text = z_axis_var.ToString("F3");
                            port.WriteLine("G92 X0 Y0 Z0");

                        }
                    


                }


                // set ports
                //port.WriteLine("G91");
                //messageBx.Text += "G91 \r\n";
                //port.WriteLine("G1 " + sendBx.Text + "F" + fBox.Text);
                // messageBx.Text += "G1 " + sendBx.Text + "\r\n";
                //port.WriteLine("G90");
                //messageBx.Text += "G90 \r\n";
                // move the axis


            };


           // RawInputDevice.RegisterDevice(HidUsageAndPage.Keyboard,  RawInputDeviceFlags.ExInputSink | RawInputDeviceFlags.NoLegacy, window2.Handle);
            //RawInputDevice.RegisterDevice(HidUsageAndPage.Joystick, RawInputDeviceFlags.ExInputSink, window1.Handle);


            //RawInputDevice.UnregisterDevice(HidUsageAndPage.Joystick);
            //RawInputDevice.UnregisterDevice(HidUsageAndPage.Keyboard);

            foreach (var device in hid) 
                {
                    if (device.UsageAndPage.Usage == 0x04 || device.UsageAndPage.Usage == 0x05)
                    { 
                        string productid = device.ProductId.ToString("X4");
                        string vendorid = device.VendorId.ToString("X4");
                       // messageBx.Text += device.ProductName + " ::" + productid + "::" + vendorid + "\r\n";// +device.VendorId:X4+device.ProductId:X4+device.ProductName+device.ManufacturerName;
                        
                }
                    }
            }   
    }
}
