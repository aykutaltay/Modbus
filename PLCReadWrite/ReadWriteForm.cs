using Newtonsoft.Json;
using PLCReadWrite.Core;
using PLCReadWrite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PLCReadWrite
{
    public partial class ReadWriteForm : Form
    {
        public ReadWriteForm()
        {
            InitializeComponent();
        }


        #region Variable

        requestModel request = new requestModel();
        responseModel Response = new responseModel();

        string sourcefile = Environment.CurrentDirectory + "\\Data\\Config.json";

        #endregion
        #region Methods

        private void jsonRead()
        {

            try
            {

                string readtext = File.ReadAllText(sourcefile, Encoding.GetEncoding("Windows-1254"));

                request = JsonConvert.DeserializeObject<requestModel>(readtext);

                txtDataAdress.Text = request.DataAddress;
                txtData.Text = request.Data.ToString();

                if (request.LocalDataAddress != 0)
                {
                    txtDataAdress.ReadOnly = false;
                    txtData.ReadOnly = false;
                }

                if (request.ReadWrite == 0)
                {
                    rdioRead.Checked = true;
                }
                else if (request.ReadWrite == 1)
                {
                    rdioWrite.Checked = true;
                }
                else
                {
                    rdioRead.Checked = true;
                }


            }
            catch (Exception e)
            {

                rcState.Text = e.ToString();
                request = new requestModel();
                rcState.BackColor = Color.Red;
            }
        }

        #endregion
        #region Events
        private void btnSend_Click(object sender, EventArgs e)
        {
            #region Control

            if (string.IsNullOrEmpty(request.IpAddress))
            {
                MessageBox.Show("Config Errors");
                return;
            }

            if (request.LocalDataAddress != 0)
            {
                if (string.IsNullOrEmpty(txtDataAdress.Text))
                {
                    MessageBox.Show("Null State");
                    txtDataAdress.Focus();

                }

                if (string.IsNullOrEmpty(txtData.Text))
                {
                    MessageBox.Show("Null State");
                    txtData.Focus();

                }
                request.DataAddress = txtDataAdress.Text;
                request.Data = Convert.ToInt32(txtData.Text);



            }

            #endregion

            rcState.Text = "";
            rcState.BackColor = Color.White;


            #region modbus

            

            if (rdioRead.Checked)
            {
                Response = PlcReadWrite.ReadModbus(request);
            }
            else if (rdioWrite.Checked)
            {
                Response = PlcReadWrite.WriteModbus(request);
                Response = PlcReadWrite.ReadModbus(request);


            }

            #endregion

            #region fatek--disable


            //if (rdioRead.Checked)
            //{
            //    if (radioFatek.Checked)
            //    {
            //        Response = PlcReadWrite.Read(request);
            //    }
            //    else
            //    {
            //        Response = PlcReadWrite.ReadModbus(request);
            //    }

            //}
            //else if (rdioWrite.Checked)
            //{

            //    if (radioFatek.Checked)
            //    {
            //        Response = PlcReadWrite.Write(request);
            //        Response = PlcReadWrite.Read(request);
            //    }
            //    else
            //    {
            //        Response = PlcReadWrite.WriteModbus(request);
            //        //Response = PlcReadWrite.Read(request);

            //    }

            //    //write 

            //    //read

            //}

            #endregion


            #region response

            
            if (Response.ResponseStatus == "succes")
            {
                rcState.Text = Response.Error;

                rcState.BackColor = Color.FromArgb(192, 255, 192);
                txtResult.Text = Response.ResponseData;
            }
            else
            {
                rcState.Text = Response.Error;
                rcState.BackColor = Color.Red;
                txtResult.Text = "0";
                rcState.BackColor = Color.Red;

            }
            #endregion

        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            var frm = new ConfigForm();
            frm.ShowDialog();
            jsonRead();
        }
        private void ReadWriteForm_Load(object sender, EventArgs e)
        {
            jsonRead();
        }

        #endregion


    }
}
