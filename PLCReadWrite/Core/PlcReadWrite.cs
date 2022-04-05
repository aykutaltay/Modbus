using EasyModbus;
using PLCReadWrite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace PLCReadWrite.Core
{
    public static class PlcReadWrite
    {
        public static responseModel Read(requestModel request)
        {

            responseModel mdl = new responseModel();
            using (var tcpclnt = new TcpClient())
            {

                try
                {


                    List<byte> ascii = new List<byte>();
                    tcpclnt.Connect(request.IpAddress, Convert.ToInt16(request.Port));

                    string gidenveri, asciilrc, inputData;


                    mdl.ResponseStatus = "succes";
                    mdl.Error = "succes";

                    ascii = new List<byte>();
                    gidenveri = "a" + request.Station + request.BlogConst + request.DataAddress;
                    // String ASCII Dönüştürücü
                    ascii.AddRange(Encoding.ASCII.GetBytes(gidenveri));
                    ascii[0] = 0x02;
                    asciilrc = calculateLRC(ascii);
                    ascii.AddRange(Encoding.ASCII.GetBytes(asciilrc));
                    ascii.Add(0x03);
                    byte[] gidenveria = ascii.ToArray();

                    //PLC ye Data Gönder
                    Stream stm = tcpclnt.GetStream();
                    stm.Write(gidenveria, 0, gidenveria.Length);

                    //PLC den Data Al
                    byte[] bb = new byte[100];
                    int k = stm.Read(bb, 0, 100);
                    inputData = Encoding.UTF8.GetString(bb, 0, bb.Length);
                    int first = inputData.IndexOf("460") + 3;

                    //Okunan Hex Değeri İnt'e Çevir
                    int i = Int32.Parse(inputData.Substring(first, 4), System.Globalization.NumberStyles.HexNumber);
                    mdl.ResponseData = Convert.ToInt16(i).ToString();

                }
                catch (Exception e)
                {
                    mdl.Error = e.ToString();
                    mdl.ResponseStatus = "Error";

                }


                tcpclnt.Close();
            }



            return mdl;

        }
        public static responseModel Write(requestModel request)
        {

            responseModel mdl = new responseModel();
            using (var tcpclnt = new TcpClient())
            {

                try
                {


                    List<byte> ascii = new List<byte>();
                    string gidenveri, asciilrc;


                    tcpclnt.Connect(request.IpAddress, Convert.ToInt16(request.Port));




                    mdl.ResponseStatus = "succes";
                    mdl.Error = "succes";


                    ascii = new List<byte>();

                    int regdegeri = Convert.ToInt16(request.Data);
                    string a = regdegeri.ToString("X4");

                    gidenveri = "a" + request.Station + "4701" + request.DataAddress + a;

                    // String ASCII Dönüştürücü
                    ascii.AddRange(Encoding.ASCII.GetBytes(gidenveri));
                    ascii[0] = 0x02;
                    asciilrc = calculateLRC(ascii);
                    ascii.AddRange(Encoding.ASCII.GetBytes(asciilrc));
                    ascii.Add(0x03);
                    byte[] gidenveria = ascii.ToArray();

                    //PLC ye Data Gönder
                    Stream stm = tcpclnt.GetStream();
                    stm.Write(gidenveria, 0, gidenveria.Length);




                }
                catch (Exception e)
                {
                    mdl.Error = e.ToString();
                    mdl.ResponseStatus = "Error";

                }


                tcpclnt.Close();
            }



            return mdl;

        }
        private static string calculateLRC(List<byte> bytes)
        {
            int LRC = 0;
            for (int i = 0; i < bytes.Count; i++)
            {
                LRC = (byte)((LRC + bytes[i]) & 0xFF);
            }
            return LRC.ToString("X");
        }

        public static responseModel ReadModbus(requestModel request)
        {
            responseModel mdl = new responseModel();
            try
            {

                var client =  new ModbusClient(request.IpAddress, Convert.ToInt32(request.Port));

                if (client.Connected)
                {
                    mdl.Error = "Connetion  Problems";
                    mdl.ResponseStatus = "Error";
                                      

                    return mdl;
                }

                client.Connect();


                int Adress = Convert.ToInt32(request.DataAddress);


                 string result = client.ReadHoldingRegisters(Adress, 1)[0].ToString();


                mdl.ResponseData = result;

                mdl.ResponseStatus = "succes";

                client.Disconnect();
               


            }
            catch (Exception e)
            {

                mdl.Error = e.ToString();
                mdl.ResponseStatus = "Error";
            }


            return mdl;


        }

        public static responseModel WriteModbus(requestModel request)
        {
            responseModel mdl = new responseModel();
            try
            {

                var client = new ModbusClient(request.IpAddress, Convert.ToInt32(request.Port));

                if (client.Connected)
                {
                    mdl.Error = "Connetion  Problems";
                    mdl.ResponseStatus = "Error";


                    return mdl;
                }

                client.Connect();


                int Adress = Convert.ToInt32(request.DataAddress);


                //string result = client.ReadHoldingRegisters(Adress, 1)[0].ToString();

                int data = Convert.ToInt32(request.Data);
                client.WriteSingleRegister(Adress, data);


                mdl.ResponseStatus = "succes";

                client.Disconnect();



            }
            catch (Exception e)
            {

                mdl.Error = e.ToString();
                mdl.ResponseStatus = "Error";
            }


            return mdl;


        }

    }
}
