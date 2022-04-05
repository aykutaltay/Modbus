using Newtonsoft.Json;
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
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        requestModel request = new requestModel();
        string sourcefile = Environment.CurrentDirectory + "\\Data\\Config.json";
        

        private void jsonRead()
        {

            try
            {
                string readtext = File.ReadAllText(sourcefile, Encoding.GetEncoding("Windows-1254"));
                request = JsonConvert.DeserializeObject<requestModel>(readtext);

                txtDataAdress.Text = request.DataAddress;
                txtData.Text = request.Data.ToString();
                txtIpAdress.Text = request.IpAddress.ToString();
                txtPort.Text = request.Port.ToString();
                txtStation.Text = request.Station.ToString();
                txtDataBlog.Text = request.BlogConst.ToString();


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

                if (request.LocalDataAddress != 0)
                {
                    chkSceenInput.Checked = true;
                }


               
                
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());


            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            try
            {
                

                string destinationFile = Environment.CurrentDirectory + "\\Data\\" + DateTime.Now.ToString("fffffff") + "Config.json";
                string readtext = File.ReadAllText(sourcefile, Encoding.GetEncoding("Windows-1254"));
                request = JsonConvert.DeserializeObject<requestModel>(readtext);

                foreach (Control x in this.Controls)
                {
                    if (x is TextBox)
                    {
                        if (string.IsNullOrEmpty(x.Text))
                        {
                            MessageBox.Show("Null Errors");
                            x.Focus();
                            continue;

                        }
                    }
                }

                request.DataAddress = txtDataAdress.Text;
                request.Data = Convert.ToInt32(txtData.Text);
                request.IpAddress = txtIpAdress.Text;
                request.Port = txtPort.Text;
                request.Station = txtStation.Text;
                request.BlogConst = txtDataBlog.Text;


                if (rdioRead.Checked)
                {
                    request.ReadWrite = 0;
                }
                else if (rdioWrite.Checked)
                {
                    request.ReadWrite = 1;
                }
                else
                {
                    request.ReadWrite = 0;
                }

                if (chkSceenInput.Checked)
                {

                    request.LocalDataAddress = 1;
                }
                else
                {
                    request.LocalDataAddress = 0;
                }

                //File.Copy(sourcefile, destinationFile, true);
                File.WriteAllText(destinationFile, readtext);
                File.WriteAllText(sourcefile, JsonConvert.SerializeObject(request));
              


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            jsonRead();
        }
    }
}
