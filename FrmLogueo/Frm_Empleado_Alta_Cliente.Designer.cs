﻿namespace WF_TransporteRodriguez
{
    partial class Frm_Empleado_Alta_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empleado_Alta_Cliente));
            label1 = new Label();
            panel5 = new Panel();
            lbl_nombreUsuario = new Label();
            pictureBox8 = new PictureBox();
            label7 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            txt_AltaNombre = new TextBox();
            pictureBox3 = new PictureBox();
            txt_AltaContraseña = new TextBox();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            txt_AltaMail = new TextBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            txt_AltaDireccion = new TextBox();
            label6 = new Label();
            cbo_Rubro = new ComboBox();
            label3 = new Label();
            pictureBox7 = new PictureBox();
            txt_AltaId = new TextBox();
            label4 = new Label();
            grp_DatosNuevoCliente = new GroupBox();
            pictureBox9 = new PictureBox();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            grp_DatosNuevoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 46);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 192, 128);
            panel5.Controls.Add(lbl_nombreUsuario);
            panel5.Controls.Add(pictureBox8);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(89, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(634, 33);
            panel5.TabIndex = 40;
            // 
            // lbl_nombreUsuario
            // 
            lbl_nombreUsuario.AutoSize = true;
            lbl_nombreUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nombreUsuario.Location = new Point(385, 10);
            lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            lbl_nombreUsuario.Size = new Size(64, 20);
            lbl_nombreUsuario.TabIndex = 59;
            lbl_nombreUsuario.Text = "Nombre";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.persona;
            pictureBox8.Location = new Point(335, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(44, 35);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 58;
            pictureBox8.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(314, 32);
            label7.TabIndex = 30;
            label7.Text = "TRANSPORTE RODRIGUEZ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(89, 468);
            panel1.TabIndex = 41;
            panel1.Paint += panel1_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 315);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 47;
            label9.Text = "Cancelar";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(89, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 33);
            panel2.TabIndex = 58;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(8, 8);
            label11.Name = "label11";
            label11.Size = new Size(136, 25);
            label11.TabIndex = 58;
            label11.Text = "ALTA CLIENTE";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 241);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 203);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 45;
            label8.Text = "Guardar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.guardar;
            pictureBox1.Location = new Point(10, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 96);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 43;
            label5.Text = "ACCIONES";
            // 
            // txt_AltaNombre
            // 
            txt_AltaNombre.BackColor = Color.FromArgb(255, 255, 192);
            txt_AltaNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_AltaNombre.Location = new Point(64, 68);
            txt_AltaNombre.Name = "txt_AltaNombre";
            txt_AltaNombre.Size = new Size(255, 25);
            txt_AltaNombre.TabIndex = 42;
            txt_AltaNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.persona;
            pictureBox3.Location = new Point(12, 58);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 43;
            pictureBox3.TabStop = false;
            // 
            // txt_AltaContraseña
            // 
            txt_AltaContraseña.BackColor = Color.FromArgb(255, 255, 192);
            txt_AltaContraseña.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_AltaContraseña.Location = new Point(62, 127);
            txt_AltaContraseña.Name = "txt_AltaContraseña";
            txt_AltaContraseña.Size = new Size(255, 25);
            txt_AltaContraseña.TabIndex = 44;
            txt_AltaContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(64, 102);
            label10.Name = "label10";
            label10.Size = new Size(77, 17);
            label10.TabIndex = 45;
            label10.Text = "Contraseña";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 117);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 46;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(67, 155);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 47;
            label2.Text = "Mail";
            // 
            // txt_AltaMail
            // 
            txt_AltaMail.BackColor = Color.FromArgb(255, 255, 192);
            txt_AltaMail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_AltaMail.Location = new Point(64, 175);
            txt_AltaMail.Name = "txt_AltaMail";
            txt_AltaMail.Size = new Size(255, 25);
            txt_AltaMail.TabIndex = 48;
            txt_AltaMail.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(14, 165);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 49;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 219);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(44, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 50;
            pictureBox6.TabStop = false;
            // 
            // txt_AltaDireccion
            // 
            txt_AltaDireccion.BackColor = Color.FromArgb(255, 255, 192);
            txt_AltaDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_AltaDireccion.Location = new Point(62, 229);
            txt_AltaDireccion.Name = "txt_AltaDireccion";
            txt_AltaDireccion.Size = new Size(255, 25);
            txt_AltaDireccion.TabIndex = 51;
            txt_AltaDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(64, 203);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 52;
            label6.Text = "Direccion";
            // 
            // cbo_Rubro
            // 
            cbo_Rubro.FormattingEnabled = true;
            cbo_Rubro.Items.AddRange(new object[] { "Libros", "Electrodosmesticos", "Muebles", "Ropa", "Juguetes", "Calzado", "Hogar", "Mascotas", "Computacion" });
            cbo_Rubro.Location = new Point(62, 273);
            cbo_Rubro.Name = "cbo_Rubro";
            cbo_Rubro.Size = new Size(255, 23);
            cbo_Rubro.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(64, 253);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 54;
            label3.Text = "Rubro";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(14, 311);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(49, 35);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 55;
            pictureBox7.TabStop = false;
            // 
            // txt_AltaId
            // 
            txt_AltaId.BackColor = Color.FromArgb(255, 255, 192);
            txt_AltaId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_AltaId.Location = new Point(64, 321);
            txt_AltaId.Name = "txt_AltaId";
            txt_AltaId.ReadOnly = true;
            txt_AltaId.Size = new Size(255, 25);
            txt_AltaId.TabIndex = 56;
            txt_AltaId.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(67, 299);
            label4.Name = "label4";
            label4.Size = new Size(22, 17);
            label4.TabIndex = 57;
            label4.Text = "ID";
            // 
            // grp_DatosNuevoCliente
            // 
            grp_DatosNuevoCliente.BackColor = Color.FromArgb(255, 192, 128);
            grp_DatosNuevoCliente.Controls.Add(pictureBox9);
            grp_DatosNuevoCliente.Controls.Add(label3);
            grp_DatosNuevoCliente.Controls.Add(label4);
            grp_DatosNuevoCliente.Controls.Add(cbo_Rubro);
            grp_DatosNuevoCliente.Controls.Add(txt_AltaNombre);
            grp_DatosNuevoCliente.Controls.Add(pictureBox7);
            grp_DatosNuevoCliente.Controls.Add(txt_AltaId);
            grp_DatosNuevoCliente.Controls.Add(label1);
            grp_DatosNuevoCliente.Controls.Add(txt_AltaContraseña);
            grp_DatosNuevoCliente.Controls.Add(pictureBox3);
            grp_DatosNuevoCliente.Controls.Add(pictureBox4);
            grp_DatosNuevoCliente.Controls.Add(pictureBox6);
            grp_DatosNuevoCliente.Controls.Add(label6);
            grp_DatosNuevoCliente.Controls.Add(label10);
            grp_DatosNuevoCliente.Controls.Add(txt_AltaDireccion);
            grp_DatosNuevoCliente.Controls.Add(txt_AltaMail);
            grp_DatosNuevoCliente.Controls.Add(label2);
            grp_DatosNuevoCliente.Controls.Add(pictureBox5);
            grp_DatosNuevoCliente.Location = new Point(242, 71);
            grp_DatosNuevoCliente.Name = "grp_DatosNuevoCliente";
            grp_DatosNuevoCliente.Size = new Size(317, 386);
            grp_DatosNuevoCliente.TabIndex = 48;
            grp_DatosNuevoCliente.TabStop = false;
            grp_DatosNuevoCliente.Text = "Datos por ingresar";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.fabrica;
            pictureBox9.Location = new Point(10, 260);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(48, 45);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 49;
            pictureBox9.TabStop = false;
            // 
            // Frm_Empleado_Alta_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(720, 469);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(grp_DatosNuevoCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Empleado_Alta_Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAltaCliente";
            Load += FrmAltaCliente_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            grp_DatosNuevoCliente.ResumeLayout(false);
            grp_DatosNuevoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel5;
        private Label label7;
        private Panel panel1;
        private Label label9;
        private PictureBox pictureBox2;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox txt_AltaNombre;
        private PictureBox pictureBox3;
        private TextBox txt_AltaContraseña;
        private Label label10;
        private PictureBox pictureBox4;
        private Label label2;
        private TextBox txt_AltaMail;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private TextBox txt_AltaDireccion;
        private Label label6;
        private ComboBox cbo_Rubro;
        private Label label3;
        private PictureBox pictureBox7;
        private TextBox txt_AltaId;
        private Label label4;
        private Label lbl_nombreUsuario;
        private PictureBox pictureBox8;
        private GroupBox grp_DatosNuevoCliente;
        private PictureBox pictureBox9;
        private Panel panel2;
        private Label label11;
    }
}