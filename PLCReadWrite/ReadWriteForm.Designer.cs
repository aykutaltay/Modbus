
namespace PLCReadWrite
{
    partial class ReadWriteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gProcess = new System.Windows.Forms.GroupBox();
            this.rdioWrite = new System.Windows.Forms.RadioButton();
            this.rdioRead = new System.Windows.Forms.RadioButton();
            this.rcState = new System.Windows.Forms.RichTextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataAdress = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 517);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnConfig);
            this.panel3.Controls.Add(this.txtResult);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.gProcess);
            this.panel3.Controls.Add(this.rcState);
            this.panel3.Controls.Add(this.txtData);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtDataAdress);
            this.panel3.Controls.Add(this.btnSend);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 517);
            this.panel3.TabIndex = 1;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfig.Location = new System.Drawing.Point(443, 31);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(63, 26);
            this.btnConfig.TabIndex = 8;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResult.Location = new System.Drawing.Point(157, 106);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(280, 26);
            this.txtResult.TabIndex = 7;
            this.txtResult.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(57, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Result";
            // 
            // gProcess
            // 
            this.gProcess.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gProcess.Controls.Add(this.rdioWrite);
            this.gProcess.Controls.Add(this.rdioRead);
            this.gProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gProcess.Location = new System.Drawing.Point(157, 142);
            this.gProcess.Name = "gProcess";
            this.gProcess.Size = new System.Drawing.Size(280, 57);
            this.gProcess.TabIndex = 5;
            this.gProcess.TabStop = false;
            this.gProcess.Text = "Process";
            // 
            // rdioWrite
            // 
            this.rdioWrite.AutoSize = true;
            this.rdioWrite.Location = new System.Drawing.Point(133, 26);
            this.rdioWrite.Name = "rdioWrite";
            this.rdioWrite.Size = new System.Drawing.Size(69, 24);
            this.rdioWrite.TabIndex = 1;
            this.rdioWrite.Text = "Write";
            this.rdioWrite.UseVisualStyleBackColor = true;
            // 
            // rdioRead
            // 
            this.rdioRead.AutoSize = true;
            this.rdioRead.Checked = true;
            this.rdioRead.Location = new System.Drawing.Point(16, 26);
            this.rdioRead.Name = "rdioRead";
            this.rdioRead.Size = new System.Drawing.Size(70, 24);
            this.rdioRead.TabIndex = 0;
            this.rdioRead.TabStop = true;
            this.rdioRead.Text = "Read";
            this.rdioRead.UseVisualStyleBackColor = true;
            // 
            // rcState
            // 
            this.rcState.Location = new System.Drawing.Point(157, 284);
            this.rcState.Name = "rcState";
            this.rcState.Size = new System.Drawing.Size(280, 160);
            this.rcState.TabIndex = 4;
            this.rcState.Text = "";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtData.Location = new System.Drawing.Point(157, 69);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(280, 26);
            this.txtData.TabIndex = 3;
            this.txtData.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Send";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(103, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "State";
            // 
            // txtDataAdress
            // 
            this.txtDataAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDataAdress.Location = new System.Drawing.Point(157, 31);
            this.txtDataAdress.Name = "txtDataAdress";
            this.txtDataAdress.ReadOnly = true;
            this.txtDataAdress.Size = new System.Drawing.Size(280, 26);
            this.txtDataAdress.TabIndex = 1;
            this.txtDataAdress.Text = "10";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSend.Location = new System.Drawing.Point(157, 216);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(280, 52);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Address";
            // 
            // ReadWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(634, 568);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ReadWriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read Write";
            this.Load += new System.EventHandler(this.ReadWriteForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gProcess.ResumeLayout(false);
            this.gProcess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rcState;
        private System.Windows.Forms.GroupBox gProcess;
        private System.Windows.Forms.RadioButton rdioWrite;
        private System.Windows.Forms.RadioButton rdioRead;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfig;
    }
}

