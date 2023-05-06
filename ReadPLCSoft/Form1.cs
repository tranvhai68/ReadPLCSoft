using System;
using System.Data;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using EasyModbus;
using Microsoft.Win32;
using Modbus;

namespace ReadPLCSoft
{
    public partial class Form1 : Form
    {
        System.Data.DataTable dt_data = new System.Data.DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dt_data.Clear();
            dt_data.Columns.Add(new DataColumn("Col1", typeof(String)));
            dt_data.Columns.Add(new DataColumn("Col2", typeof(String)));
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Fsetting fset = new Fsetting();
            fset.ShowDialog();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            try
            {
                int[] data = new int[10];
                int quantity = 10;
                int startingAddress = 0;
                float floatValue = 0;
                                 
                dt_data.Clear();
                dgv_main.DataSource = dt_data;
           
                String _COM = Properties.Settings.Default.COM;
                int _Baud = Convert.ToInt16(Properties.Settings.Default.Baud);
                Parity _parity = (Parity)Enum.Parse(typeof(Parity), Properties.Settings.Default.Parity);
                int _Databits = Convert.ToInt16(Properties.Settings.Default.Databit);
                StopBits _Stopbits = (StopBits)Enum.Parse(typeof(StopBits), Properties.Settings.Default.Stopbit);

                SerialPort serial_port = new SerialPort(_COM, _Baud, _parity, _Databits, _Stopbits);
               
              

           
                if (Properties.Settings.Default.Connection == "Modbus TCP/IP")
                {
                    string g_ipAddress = Properties.Settings.Default.IP.ToString();
                    int g_port = Convert.ToInt16(Properties.Settings.Default.Port.ToString());
                    ModbusClient modbusClient_TCPIP = new ModbusClient(g_ipAddress, g_port);
                    modbusClient_TCPIP = new ModbusClient(g_ipAddress, g_port);
                    modbusClient_TCPIP.Connect();                            
                   // data = modbusClient_TCPIP.ReadHoldingRegisters(startingAddress, quantity);                   
                   // floatValue = ModbusClient.ConvertRegistersToFloat(data); //Lấy kiểu float 
                   
                }
                else
                {
                    ModbusClient modbusClient_RTU = new ModbusClient(serial_port.PortName);
                    modbusClient_RTU = new ModbusClient(serial_port.PortName);
                    modbusClient_RTU.UnitIdentifier = 1;
                    modbusClient_RTU.Baudrate = _Baud;
                    modbusClient_RTU.Parity = _parity;
                    modbusClient_RTU.StopBits = _Stopbits;
                    modbusClient_RTU.ConnectionTimeout = 1000;
                    modbusClient_RTU.Connect();
                    MessageBox.Show("Kết nối thành công");

                    // Đọc giá trị từ PLC


                    data = modbusClient_RTU.ReadHoldingRegisters(80, 1);
                    txt_NguoiTT80.Text = data[0].ToString();
                    data = modbusClient_RTU.ReadHoldingRegisters(83, 1);
                    txt_NguoiTT83.Text = data[0].ToString();
                    data = modbusClient_RTU.ReadHoldingRegisters(87, 1);
                    txt_NguoiTT87.Text = data[0].ToString();
                    data = modbusClient_RTU.ReadHoldingRegisters(20, 1);
                    txt_quycach20.Text = data[0].ToString();
                    data = modbusClient_RTU.ReadHoldingRegisters(23, 1);
                    txt_quycach23.Text = data[0].ToString();
                    data = modbusClient_RTU.ReadHoldingRegisters(52, 1);
                    address52.Text = data[0].ToString();
                    data = modbusClient_RTU.ReadHoldingRegisters(54, 1);
                    address54.Text = data[0].ToString();
                   // data = modbusClient_RTU.ReadHoldingRegisters(startingAddress, quantity);
                }

                //if (data.Length != quantity)
                //{
                //    MessageBox.Show("Lỗi đọc dữ liệu từ thiết bị");
                //    return;
                //}

                // In ra giá trị của các thanh ghi
                //for (int i = 0; i < quantity; i++)
                //{
                //    //Console.WriteLine("Giá trị thanh ghi " + (startingAddress + i) + ": " + data[i]);
                //    DataRow row = dt_data.NewRow();
                //    row["Col1"] = startingAddress + i;
                //    row["Col2"] = data[i];
                //    dt_data.Rows.Add(row);
                //}

                dt_data.DefaultView.Sort = "Col1";
                dgv_main.DataSource = dt_data.DefaultView.ToTable();
            }
            catch (Exception ex)
            {
               
                    MessageBox.Show(ex.ToString());
            }
            finally
            {
                // Đóng kết nối với thiết bị
                //modbusClient_RTU.Disconnect();
                //modbusClient_TCPIP.Disconnect();
            }



        }
    }
}
