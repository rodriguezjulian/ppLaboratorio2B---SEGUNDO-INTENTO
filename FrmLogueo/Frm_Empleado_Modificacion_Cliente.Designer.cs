﻿namespace WF_TransporteRodriguez
{
    partial class Frm_Empleado_Modificacion_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empleado_Modificacion_Cliente));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            grp_DatosNuevoCliente = new GroupBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            cbo_Mail = new ComboBox();
            label4 = new Label();
            txt_ID = new TextBox();
            pictureBox9 = new PictureBox();
            label3 = new Label();
            cbo_Rubro = new ComboBox();
            txt_ModNombre = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            txt_ModDireccion = new TextBox();
            txt_ModMail = new TextBox();
            pictureBox5 = new PictureBox();
            dtg_ListarClientes = new DataGridView();
            pnl_PanelSup.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).BeginInit();
            panel1.SuspendLayout();
            grp_DatosNuevoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarClientes).BeginInit();
            SuspendLayout();
            // 
            // pnl_PanelSup
            // 
            pnl_PanelSup.Location = new Point(88, 33);
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            // 
            // pic_Guardar
            // 
            pic_Guardar.Click += pic_Guardar_Click;
            // 
            // pic_Cancelar
            // 
            pic_Cancelar.Click += pic_Cancelar_Click;
            // 
            // lbl_Cancelar
            // 
            lbl_Cancelar.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Cancelar.Location = new Point(-2, 324);
            lbl_Cancelar.Size = new Size(0, 13);
            lbl_Cancelar.Text = "";
            // 
            // lbl_Opcion
            // 
            lbl_Opcion.Size = new Size(219, 30);
            lbl_Opcion.Text = "MODIFICAR CLIENTE";
            // 
            // grp_DatosNuevoCliente
            // 
            grp_DatosNuevoCliente.BackColor = Color.FromArgb(255, 255, 192);
            grp_DatosNuevoCliente.Controls.Add(label2);
            grp_DatosNuevoCliente.Controls.Add(pictureBox1);
            grp_DatosNuevoCliente.Controls.Add(cbo_Mail);
            grp_DatosNuevoCliente.Controls.Add(label4);
            grp_DatosNuevoCliente.Controls.Add(txt_ID);
            grp_DatosNuevoCliente.Controls.Add(pictureBox9);
            grp_DatosNuevoCliente.Controls.Add(label3);
            grp_DatosNuevoCliente.Controls.Add(cbo_Rubro);
            grp_DatosNuevoCliente.Controls.Add(txt_ModNombre);
            grp_DatosNuevoCliente.Controls.Add(label1);
            grp_DatosNuevoCliente.Controls.Add(pictureBox3);
            grp_DatosNuevoCliente.Controls.Add(pictureBox6);
            grp_DatosNuevoCliente.Controls.Add(label6);
            grp_DatosNuevoCliente.Controls.Add(txt_ModDireccion);
            grp_DatosNuevoCliente.Controls.Add(txt_ModMail);
            grp_DatosNuevoCliente.Controls.Add(pictureBox5);
            grp_DatosNuevoCliente.Location = new Point(95, 79);
            grp_DatosNuevoCliente.Name = "grp_DatosNuevoCliente";
            grp_DatosNuevoCliente.Size = new Size(623, 155);
            grp_DatosNuevoCliente.TabIndex = 71;
            grp_DatosNuevoCliente.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 71);
            label2.Name = "label2";
            label2.Size = new Size(89, 17);
            label2.TabIndex = 59;
            label2.Text = "Mail, sin \"@\"";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // cbo_Mail
            // 
            cbo_Mail.FormattingEnabled = true;
            cbo_Mail.Items.AddRange(new object[] { "@gmail.com", "@hotmail.com", "@yahoo.com", "@transporterodriguez.com" });
            cbo_Mail.Location = new Point(61, 122);
            cbo_Mail.Name = "cbo_Mail";
            cbo_Mail.Size = new Size(181, 23);
            cbo_Mail.TabIndex = 57;
            cbo_Mail.KeyPress += cbo_Mail_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(258, 19);
            label4.Name = "label4";
            label4.Size = new Size(22, 17);
            label4.TabIndex = 56;
            label4.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.BackColor = Color.White;
            txt_ID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ID.Location = new Point(258, 38);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(51, 25);
            txt_ID.TabIndex = 55;
            txt_ID.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.fabrica;
            pictureBox9.Location = new Point(315, 80);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(48, 45);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 49;
            pictureBox9.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(364, 70);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 54;
            label3.Text = "Rubro";
            // 
            // cbo_Rubro
            // 
            cbo_Rubro.FormattingEnabled = true;
            cbo_Rubro.Items.AddRange(new object[] { "Libros", "Electrodosmesticos", "Muebles", "Ropa", "Juguetes", "Calzado", "Hogar", "Mascotas", "Computacion" });
            cbo_Rubro.Location = new Point(364, 91);
            cbo_Rubro.Name = "cbo_Rubro";
            cbo_Rubro.Size = new Size(249, 23);
            cbo_Rubro.TabIndex = 53;
            cbo_Rubro.KeyPress += cbo_Rubro_KeyPress;
            // 
            // txt_ModNombre
            // 
            txt_ModNombre.BackColor = Color.FromArgb(255, 255, 192);
            txt_ModNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ModNombre.Location = new Point(62, 38);
            txt_ModNombre.Name = "txt_ModNombre";
            txt_ModNombre.Size = new Size(180, 25);
            txt_ModNombre.TabIndex = 42;
            txt_ModNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 19);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.persona;
            pictureBox3.Location = new Point(12, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 43;
            pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(315, 28);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(44, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 50;
            pictureBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(364, 18);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 52;
            label6.Text = "Direccion";
            // 
            // txt_ModDireccion
            // 
            txt_ModDireccion.BackColor = Color.FromArgb(255, 255, 192);
            txt_ModDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ModDireccion.Location = new Point(364, 38);
            txt_ModDireccion.Name = "txt_ModDireccion";
            txt_ModDireccion.Size = new Size(249, 25);
            txt_ModDireccion.TabIndex = 51;
            txt_ModDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_ModMail
            // 
            txt_ModMail.BackColor = Color.FromArgb(255, 255, 192);
            txt_ModMail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ModMail.Location = new Point(62, 91);
            txt_ModMail.Name = "txt_ModMail";
            txt_ModMail.Size = new Size(180, 25);
            txt_ModMail.TabIndex = 48;
            txt_ModMail.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 81);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 49;
            pictureBox5.TabStop = false;
            // 
            // dtg_ListarClientes
            // 
            dtg_ListarClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtg_ListarClientes.BackgroundColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_ListarClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_ListarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ListarClientes.EnableHeadersVisualStyles = false;
            dtg_ListarClientes.GridColor = Color.FromArgb(255, 255, 192);
            dtg_ListarClientes.Location = new Point(95, 240);
            dtg_ListarClientes.Name = "dtg_ListarClientes";
            dtg_ListarClientes.ReadOnly = true;
            dtg_ListarClientes.RowHeadersVisible = false;
            dtg_ListarClientes.RowTemplate.Height = 25;
            dtg_ListarClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_ListarClientes.Size = new Size(623, 246);
            dtg_ListarClientes.TabIndex = 55;
            dtg_ListarClientes.CellClick += dtg_ListarClientes_CellClick;
            // 
            // Frm_Empleado_Modificacion_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 502);
            Controls.Add(dtg_ListarClientes);
            Controls.Add(grp_DatosNuevoCliente);
            Name = "Frm_Empleado_Modificacion_Cliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frm_Empleado_Modificacion_Cliente";
            Load += Frm_Empleado_Modificacion_Cliente_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(grp_DatosNuevoCliente, 0);
            Controls.SetChildIndex(dtg_ListarClientes, 0);
            pnl_PanelSup.ResumeLayout(false);
            pnl_PanelSup.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Cancelar).EndInit();
            panel1.ResumeLayout(false);
            grp_DatosNuevoCliente.ResumeLayout(false);
            grp_DatosNuevoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_ListarClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_DatosNuevoCliente;
        private PictureBox pictureBox9;
        private Label label3;
        private ComboBox cbo_Rubro;
        private TextBox txt_ModNombre;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private Label label6;
        private TextBox txt_ModDireccion;
        private TextBox txt_ModMail;
        private PictureBox pictureBox5;
        private DataGridView dtg_ListarClientes;
        private Label label4;
        private TextBox txt_ID;
        private ComboBox cbo_Mail;
        private PictureBox pictureBox1;
        private Label label2;
    }
}