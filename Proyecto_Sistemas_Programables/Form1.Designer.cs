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
            this.btnBienvenido = new System.Windows.Forms.Button();
            this.btnAlerta = new System.Windows.Forms.Button();
            this.btnCumpleaños = new System.Windows.Forms.Button();
            this.btnDer = new System.Windows.Forms.Button();
            this.btnIzqVent = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblPortDesc = new System.Windows.Forms.Label();
            this.btnConexion = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbConfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbConfig);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 390);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.PicBoxVentiladorOff);
            this.tabPage1.Controls.Add(this.trackBar2);
            this.tabPage1.Controls.Add(this.btnEnviar);
            this.tabPage1.Controls.Add(this.txtMostrar);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Controls.Add(this.btnBienvenido);
            this.tabPage1.Controls.Add(this.btnAlerta);
            this.tabPage1.Controls.Add(this.btnCumpleaños);
            this.tabPage1.Controls.Add(this.btnDer);
            this.tabPage1.Controls.Add(this.btnIzqVent);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.PicBoxVentiladorOn);
            this.tabPage1.Controls.Add(this.PicBoxPuertaAbierta);
            this.tabPage1.Controls.Add(this.PicBoxVentanaCerrada);
            this.tabPage1.Controls.Add(this.PicBoxVentanaAbierta);
            this.tabPage1.Controls.Add(this.PicBoxFocoApagado);
            this.tabPage1.Controls.Add(this.PicBoxLedEncendido);
            this.tabPage1.Controls.Add(this.PicBoxFocoApagadoAmarillo);
            this.tabPage1.Controls.Add(this.PicBoxEncendidoAmarillo);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(593, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Actuadores y Sensores";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(158, 211);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(322, 45);
            this.trackBar2.TabIndex = 13;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Location = new System.Drawing.Point(434, 307);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(63, 281);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(446, 20);
            this.txtMostrar.TabIndex = 11;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(158, 141);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(322, 45);
            this.trackBar1.TabIndex = 9;
            // 
            // btnBienvenido
            // 
            this.button5.Location = new System.Drawing.Point(147, 108);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnAlerta
            // 
            this.btnAlerta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAlerta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlerta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlerta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAlerta.Location = new System.Drawing.Point(279, 46);
            this.btnAlerta.Name = "btnAlerta";
            this.btnAlerta.Size = new System.Drawing.Size(87, 23);
            this.btnAlerta.TabIndex = 7;
            this.btnAlerta.Text = "Alerta";
            this.btnAlerta.UseVisualStyleBackColor = false;
            // 
            // btnCumpleaños
            // 
            this.btnCumpleaños.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCumpleaños.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCumpleaños.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCumpleaños.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCumpleaños.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCumpleaños.Location = new System.Drawing.Point(279, 79);
            this.btnCumpleaños.Name = "btnCumpleaños";
            this.btnCumpleaños.Size = new System.Drawing.Size(87, 23);
            this.btnCumpleaños.TabIndex = 6;
            this.btnCumpleaños.Text = "Cumpleaños";
            this.btnCumpleaños.UseVisualStyleBackColor = false;
            // 
            // btnDer
            // 
            this.btnDer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDer.Location = new System.Drawing.Point(95, 46);
            this.btnDer.Name = "btnDer";
            this.btnDer.Size = new System.Drawing.Size(75, 23);
            this.btnDer.TabIndex = 5;
            this.btnDer.Text = "Derecha";
            this.btnDer.UseVisualStyleBackColor = false;
            // 
            // btnIzqVent
            // 
            this.btnIzqVent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIzqVent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzqVent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzqVent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzqVent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnIzqVent.Location = new System.Drawing.Point(95, 17);
            this.btnIzqVent.Name = "btnIzqVent";
            this.btnIzqVent.Size = new System.Drawing.Size(75, 23);
            this.btnIzqVent.TabIndex = 4;
            this.btnIzqVent.Text = "Izquierda";
            this.btnIzqVent.UseVisualStyleBackColor = false;
            this.btnIzqVent.Click += new System.EventHandler(this.btnIzqVent_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = global::Proyecto_Sistemas_Programables.Properties.Resources.hogar_sostenible;
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // PicBoxBarra
            // 
            this.PicBoxBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PicBoxBarra.Location = new System.Drawing.Point(-2, 0);
            this.PicBoxBarra.Name = "PicBoxBarra";
            this.PicBoxBarra.Size = new System.Drawing.Size(641, 31);
            this.PicBoxBarra.TabIndex = 13;
            this.PicBoxBarra.TabStop = false;
            this.PicBoxBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicBoxBarra_MouseDown);
            this.PicBoxBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicBoxBarra_MouseMove);
            this.PicBoxBarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicBoxBarra_MouseUp);
            // 
            // PicBoxFocoApagadoAmarillo
            // 
            this.PicBoxFocoApagadoAmarillo.Image = global::Proyecto_Sistemas_Programables.Properties.Resources.foco_amarillo_apagado;
            this.PicBoxFocoApagadoAmarillo.Location = new System.Drawing.Point(109, 197);
            this.PicBoxFocoApagadoAmarillo.Name = "PicBoxFocoApagadoAmarillo";
            this.PicBoxFocoApagadoAmarillo.Size = new System.Drawing.Size(29, 59);
            this.PicBoxFocoApagadoAmarillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxFocoApagadoAmarillo.TabIndex = 23;
            this.PicBoxFocoApagadoAmarillo.TabStop = false;
            this.PicBoxFocoApagadoAmarillo.Click += new System.EventHandler(this.PicBoxFocoApagadoAmarillo_Click);
            // 
            // PicBoxEncendidoAmarillo
            // 
            this.PicBoxEncendidoAmarillo.Image = global::Proyecto_Sistemas_Programables.Properties.Resources.foco_amarillo_encendido;
            this.PicBoxEncendidoAmarillo.Location = new System.Drawing.Point(109, 197);
            this.PicBoxEncendidoAmarillo.Name = "PicBoxEncendidoAmarillo";
            this.PicBoxEncendidoAmarillo.Size = new System.Drawing.Size(29, 59);
            this.PicBoxEncendidoAmarillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxEncendidoAmarillo.TabIndex = 22;
            this.PicBoxEncendidoAmarillo.TabStop = false;
            this.PicBoxEncendidoAmarillo.Click += new System.EventHandler(this.PicBoxEncendidoAmarillo_Click);
            // 
            // PicBoxVentiladorOff
            // 
            this.PicBoxVentiladorOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBoxVentiladorOff.Image = global::Proyecto_Sistemas_Programables.Properties.Resources.Imagen1;
            this.PicBoxVentiladorOff.Location = new System.Drawing.Point(15, 15);
            this.PicBoxVentiladorOff.Name = "PicBoxVentiladorOff";
            this.PicBoxVentiladorOff.Size = new System.Drawing.Size(67, 90);
            this.PicBoxVentiladorOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicBoxVentiladorOff.TabIndex = 14;
            this.PicBoxVentiladorOff.TabStop = false;
            this.PicBoxVentiladorOff.Click += new System.EventHandler(this.PicBoxVentiladorOff_Click);
            // 
            // PicBoxPuertaCerrada
            // 
            this.PicBoxPuertaCerrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBoxPuertaCerrada.Image = global::Proyecto_Sistemas_Programables.Properties.Resources.Imagen6;
            this.PicBoxPuertaCerrada.Location = new System.Drawing.Point(497, 17);
            this.PicBoxPuertaCerrada.Name = "PicBoxPuertaCerrada";
            this.PicBoxPuertaCerrada.Size = new System.Drawing.Size(75, 94);
            this.PicBoxPuertaCerrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxPuertaCerrada.TabIndex = 10;
            this.PicBoxPuertaCerrada.TabStop = false;
            this.PicBoxPuertaCerrada.Click += new System.EventHandler(this.PicBoxPuertaCerrada_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(187, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 87);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // PicBoxVentiladorOn
            // 
            this.PicBoxVentiladorOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBoxVentiladorOn.Image = global::Proyecto_Sistemas_Programables.Properties.Resources.ventilador6_3870285687;
            this.PicBoxVentiladorOn.Location = new System.Drawing.Point(15, 15);
            this.PicBoxVentiladorOn.Name = "PicBoxVentiladorOn";
            this.PicBoxVentiladorOn.Size = new System.Drawing.Size(67, 90);
            this.PicBoxVentiladorOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicBoxVentiladorOn.TabIndex = 0;
            this.PicBoxVentiladorOn.TabStop = false;
            this.PicBoxVentiladorOn.Click += new System.EventHandler(this.PicBoxVentiladorOn_Click);
            // 
            // PicBoxPuertaAbierta
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(669, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Valores";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // lblPortDesc
            // 
            this.lblPortDesc.AutoSize = true;
            this.lblPortDesc.Location = new System.Drawing.Point(20, 59);
            this.lblPortDesc.Name = "lblPortDesc";
            this.lblPortDesc.Size = new System.Drawing.Size(0, 13);
            this.lblPortDesc.TabIndex = 1;
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(619, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.PicBoxBarra);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbConfig.ResumeLayout(false);
            this.tbConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.PictureBox PicBoxPuertaCerrada;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnBienvenido;
        private System.Windows.Forms.Button btnAlerta;
        private System.Windows.Forms.Button btnCumpleaños;
        private System.Windows.Forms.Button btnDer;
        private System.Windows.Forms.Button btnIzqVent;
        private System.Windows.Forms.PictureBox PicBoxLedEncendido;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PicBoxVentiladorOn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tbConfig;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblPortDesc;
        private System.Windows.Forms.Button btnConexion;
    }
}

