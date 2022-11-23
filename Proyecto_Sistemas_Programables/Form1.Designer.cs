namespace Proyecto_Sistemas_Programables
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbConfig = new System.Windows.Forms.TabPage();
            this.btnConexion = new System.Windows.Forms.Button();
            this.lblPortDesc = new System.Windows.Forms.Label();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDer = new System.Windows.Forms.Button();
            this.btnIzqVent = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblSensFoto = new System.Windows.Forms.Label();
            this.lblSenseSoil = new System.Windows.Forms.Label();
            this.lblSenseRain = new System.Windows.Forms.Label();
            this.lblSenseGas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbConfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbConfig);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(677, 390);
            this.tabControl1.TabIndex = 0;
            // 
            // tbConfig
            // 
            this.tbConfig.Controls.Add(this.btnConexion);
            this.tbConfig.Controls.Add(this.lblPortDesc);
            this.tbConfig.Controls.Add(this.cboPorts);
            this.tbConfig.Location = new System.Drawing.Point(4, 22);
            this.tbConfig.Name = "tbConfig";
            this.tbConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tbConfig.Size = new System.Drawing.Size(669, 364);
            this.tbConfig.TabIndex = 2;
            this.tbConfig.Text = "Configuración";
            this.tbConfig.UseVisualStyleBackColor = true;
            // 
            // btnConexion
            // 
            this.btnConexion.Location = new System.Drawing.Point(207, 25);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(126, 23);
            this.btnConexion.TabIndex = 2;
            this.btnConexion.Text = "Probar conexion";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // lblPortDesc
            // 
            this.lblPortDesc.AutoSize = true;
            this.lblPortDesc.Location = new System.Drawing.Point(20, 59);
            this.lblPortDesc.Name = "lblPortDesc";
            this.lblPortDesc.Size = new System.Drawing.Size(0, 13);
            this.lblPortDesc.TabIndex = 1;
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(23, 25);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(167, 21);
            this.cboPorts.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cboPorts, "Seleccione el puerto correspondiente a su Arduino");
            this.cboPorts.SelectedIndexChanged += new System.EventHandler(this.cboPorts_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.trackBar2);
            this.tabPage1.Controls.Add(this.btnEnviar);
            this.tabPage1.Controls.Add(this.txtMostrar);
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btnDer);
            this.tabPage1.Controls.Add(this.btnIzqVent);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(669, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Actuadores y Sensores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(147, 212);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(322, 45);
            this.trackBar2.TabIndex = 13;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(572, 56);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(406, 30);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(241, 20);
            this.txtMostrar.TabIndex = 11;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(147, 152);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(322, 45);
            this.trackBar1.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(147, 108);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(236, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnDer
            // 
            this.btnDer.Location = new System.Drawing.Point(88, 44);
            this.btnDer.Name = "btnDer";
            this.btnDer.Size = new System.Drawing.Size(75, 23);
            this.btnDer.TabIndex = 5;
            this.btnDer.Text = "Derecha";
            this.btnDer.UseVisualStyleBackColor = true;
            // 
            // btnIzqVent
            // 
            this.btnIzqVent.Location = new System.Drawing.Point(88, 15);
            this.btnIzqVent.Name = "btnIzqVent";
            this.btnIzqVent.Size = new System.Drawing.Size(75, 23);
            this.btnIzqVent.TabIndex = 4;
            this.btnIzqVent.Text = "Izquierda";
            this.btnIzqVent.UseVisualStyleBackColor = true;
            this.btnIzqVent.Click += new System.EventHandler(this.btnIzqVent_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(359, 287);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(147, 287);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(15, 233);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(15, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Sistemas_Programables.Properties.Resources.ventilador6_3870285687;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lblSenseGas);
            this.tabPage2.Controls.Add(this.lblSenseRain);
            this.tabPage2.Controls.Add(this.lblSenseSoil);
            this.tabPage2.Controls.Add(this.lblSensFoto);
            this.tabPage2.Controls.Add(this.lblLevel);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.iconPictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(669, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Valores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(98, 37);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(25, 13);
            this.lblLevel.TabIndex = 6;
            this.lblLevel.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sensor de Precencia";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Cloud;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 55;
            this.iconPictureBox1.Location = new System.Drawing.Point(24, 17);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(68, 55);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // lblSensFoto
            // 
            this.lblSensFoto.AutoSize = true;
            this.lblSensFoto.Location = new System.Drawing.Point(100, 124);
            this.lblSensFoto.Name = "lblSensFoto";
            this.lblSensFoto.Size = new System.Drawing.Size(25, 13);
            this.lblSensFoto.TabIndex = 7;
            this.lblSensFoto.Text = "000";
            // 
            // lblSenseSoil
            // 
            this.lblSenseSoil.AutoSize = true;
            this.lblSenseSoil.Location = new System.Drawing.Point(264, 124);
            this.lblSenseSoil.Name = "lblSenseSoil";
            this.lblSenseSoil.Size = new System.Drawing.Size(25, 13);
            this.lblSenseSoil.TabIndex = 8;
            this.lblSenseSoil.Text = "000";
            // 
            // lblSenseRain
            // 
            this.lblSenseRain.AutoSize = true;
            this.lblSenseRain.Location = new System.Drawing.Point(464, 101);
            this.lblSenseRain.Name = "lblSenseRain";
            this.lblSenseRain.Size = new System.Drawing.Size(25, 13);
            this.lblSenseRain.TabIndex = 9;
            this.lblSenseRain.Text = "000";
            // 
            // lblSenseGas
            // 
            this.lblSenseGas.AutoSize = true;
            this.lblSenseGas.Location = new System.Drawing.Point(271, 209);
            this.lblSenseGas.Name = "lblSenseGas";
            this.lblSenseGas.Size = new System.Drawing.Size(25, 13);
            this.lblSenseGas.TabIndex = 10;
            this.lblSenseGas.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nivel de Luz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Humedad en la Tierra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Humedad en el Ambiente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nivel de Gas";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 414);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbConfig.ResumeLayout(false);
            this.tbConfig.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDer;
        private System.Windows.Forms.Button btnIzqVent;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tbConfig;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblPortDesc;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblSensFoto;
        private System.Windows.Forms.Label lblSenseSoil;
        private System.Windows.Forms.Label lblSenseRain;
        private System.Windows.Forms.Label lblSenseGas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

