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
            txt_AltaNombre = new TextBox();
            pictureBox3 = new PictureBox();
            txt_AltaMail = new TextBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            txt_AltaDireccion = new TextBox();
            label6 = new Label();
            cbo_Rubro = new ComboBox();
            label3 = new Label();
            grp_DatosNuevoCliente = new GroupBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            lbl_TipoMail = new Label();
            cbo_Mail = new ComboBox();
            pictureBox9 = new PictureBox();
            label5 = new Label();
            btn_GuardarCliente = new PictureBox();
            label8 = new Label();
            pic_Cancelar = new PictureBox();
            label9 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label11 = new Label();
            pnl_AltaCliente = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            grp_DatosNuevoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_GuardarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).BeginInit();
            panel1.SuspendLayout();
            pnl_AltaCliente.SuspendLayout();
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
            // txt_AltaNombre
            // 
            txt_AltaNombre.BackColor = Color.White;
            txt_AltaNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_AltaNombre.Location = new Point(64, 68);
            txt_AltaNombre.Name = "txt_AltaNombre";
            txt_AltaNombre.Size = new Size(250, 25);
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
            // txt_AltaMail
            // 
            txt_AltaMail.BackColor = Color.White;
            txt_AltaMail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_AltaMail.Location = new Point(67, 116);
            txt_AltaMail.Name = "txt_AltaMail";
            txt_AltaMail.Size = new Size(247, 25);
            txt_AltaMail.TabIndex = 48;
            txt_AltaMail.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(14, 114);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 49;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(18, 206);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(44, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 50;
            pictureBox6.TabStop = false;
            // 
            // txt_AltaDireccion
            // 
            txt_AltaDireccion.BackColor = Color.White;
            txt_AltaDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_AltaDireccion.Location = new Point(68, 216);
            txt_AltaDireccion.Name = "txt_AltaDireccion";
            txt_AltaDireccion.Size = new Size(249, 25);
            txt_AltaDireccion.TabIndex = 51;
            txt_AltaDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(67, 196);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 52;
            label6.Text = "Direccion";
            // 
            // cbo_Rubro
            // 
            cbo_Rubro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Rubro.FormattingEnabled = true;
            cbo_Rubro.Items.AddRange(new object[] { "Libros", "Electrodosmesticos", "Muebles", "Ropa", "Juguetes", "Calzado", "Hogar", "Mascotas", "Computacion" });
            cbo_Rubro.Location = new Point(68, 270);
            cbo_Rubro.Name = "cbo_Rubro";
            cbo_Rubro.Size = new Size(249, 23);
            cbo_Rubro.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(68, 250);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 54;
            label3.Text = "Rubro";
            // 
            // grp_DatosNuevoCliente
            // 
            grp_DatosNuevoCliente.BackColor = Color.FromArgb(255, 224, 192);
            grp_DatosNuevoCliente.Controls.Add(label7);
            grp_DatosNuevoCliente.Controls.Add(pictureBox1);
            grp_DatosNuevoCliente.Controls.Add(lbl_TipoMail);
            grp_DatosNuevoCliente.Controls.Add(cbo_Mail);
            grp_DatosNuevoCliente.Controls.Add(pictureBox9);
            grp_DatosNuevoCliente.Controls.Add(label3);
            grp_DatosNuevoCliente.Controls.Add(cbo_Rubro);
            grp_DatosNuevoCliente.Controls.Add(txt_AltaNombre);
            grp_DatosNuevoCliente.Controls.Add(label1);
            grp_DatosNuevoCliente.Controls.Add(pictureBox3);
            grp_DatosNuevoCliente.Controls.Add(pictureBox6);
            grp_DatosNuevoCliente.Controls.Add(label6);
            grp_DatosNuevoCliente.Controls.Add(txt_AltaDireccion);
            grp_DatosNuevoCliente.Controls.Add(txt_AltaMail);
            grp_DatosNuevoCliente.Controls.Add(pictureBox5);
            grp_DatosNuevoCliente.Location = new Point(240, 98);
            grp_DatosNuevoCliente.Name = "grp_DatosNuevoCliente";
            grp_DatosNuevoCliente.Size = new Size(317, 339);
            grp_DatosNuevoCliente.TabIndex = 48;
            grp_DatosNuevoCliente.TabStop = false;
            grp_DatosNuevoCliente.Text = "Datos por ingresar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(68, 96);
            label7.Name = "label7";
            label7.Size = new Size(89, 17);
            label7.TabIndex = 58;
            label7.Text = "Mail, sin \"@\"";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // lbl_TipoMail
            // 
            lbl_TipoMail.AutoSize = true;
            lbl_TipoMail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TipoMail.Location = new Point(67, 145);
            lbl_TipoMail.Name = "lbl_TipoMail";
            lbl_TipoMail.Size = new Size(86, 17);
            lbl_TipoMail.TabIndex = 56;
            lbl_TipoMail.Text = "Tipo de mail";
            // 
            // cbo_Mail
            // 
            cbo_Mail.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Mail.FormattingEnabled = true;
            cbo_Mail.Items.AddRange(new object[] { "@gmail.com", "@hotmail.com", "@yahoo.com", "@transporterodriguez.com" });
            cbo_Mail.Location = new Point(67, 162);
            cbo_Mail.Name = "cbo_Mail";
            cbo_Mail.Size = new Size(247, 23);
            cbo_Mail.TabIndex = 55;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.fabrica;
            pictureBox9.Location = new Point(14, 250);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(48, 45);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 49;
            pictureBox9.TabStop = false;
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
            // btn_GuardarCliente
            // 
            btn_GuardarCliente.Image = Properties.Resources.guardar;
            btn_GuardarCliente.Location = new Point(10, 140);
            btn_GuardarCliente.Name = "btn_GuardarCliente";
            btn_GuardarCliente.Size = new Size(66, 60);
            btn_GuardarCliente.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_GuardarCliente.TabIndex = 44;
            btn_GuardarCliente.TabStop = false;
            btn_GuardarCliente.Click += btn_GuardarCliente_Click_1;
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
            // pic_Cancelar
            // 
            pic_Cancelar.Image = (Image)resources.GetObject("pic_Cancelar.Image");
            pic_Cancelar.Location = new Point(8, 241);
            pic_Cancelar.Name = "pic_Cancelar";
            pic_Cancelar.Size = new Size(66, 60);
            pic_Cancelar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Cancelar.TabIndex = 46;
            pic_Cancelar.TabStop = false;
            pic_Cancelar.Click += pic_Cancelar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(-3, 312);
            label9.Name = "label9";
            label9.Size = new Size(95, 13);
            label9.TabIndex = 47;
            label9.Text = "Volver a pantalla ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pic_Cancelar);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btn_GuardarCliente);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(89, 469);
            panel1.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 325);
            label4.Name = "label4";
            label4.Size = new Size(52, 13);
            label4.TabIndex = 48;
            label4.Text = "principal";
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
            // pnl_AltaCliente
            // 
            pnl_AltaCliente.BackColor = Color.FromArgb(255, 128, 0);
            pnl_AltaCliente.Controls.Add(label11);
            pnl_AltaCliente.Location = new Point(86, 32);
            pnl_AltaCliente.Name = "pnl_AltaCliente";
            pnl_AltaCliente.Size = new Size(200, 33);
            pnl_AltaCliente.TabIndex = 58;
            // 
            // Frm_Empleado_Alta_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(720, 469);
            ControlBox = false;
            Controls.Add(pnl_AltaCliente);
            Controls.Add(panel1);
            Controls.Add(grp_DatosNuevoCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Empleado_Alta_Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAltaCliente";
            Load += FrmAltaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            grp_DatosNuevoCliente.ResumeLayout(false);
            grp_DatosNuevoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_GuardarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnl_AltaCliente.ResumeLayout(false);
            pnl_AltaCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txt_AltaNombre;
        private PictureBox pictureBox3;
        private TextBox txt_AltaMail;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private TextBox txt_AltaDireccion;
        private Label label6;
        private ComboBox cbo_Rubro;
        private Label label3;
        private GroupBox grp_DatosNuevoCliente;
        private PictureBox pictureBox9;
        private Label label5;
        private PictureBox btn_GuardarCliente;
        private Label label8;
        private PictureBox pic_Cancelar;
        private Label label9;
        private Panel panel1;
        private Label label11;
        private Panel pnl_AltaCliente;
        private Label label4;
        private PictureBox pictureBox1;
        private Label lbl_TipoMail;
        private ComboBox cbo_Mail;
        private Label label7;
    }
}