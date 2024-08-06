namespace Dental_Management_System.dashboard_resepsionis
{
    partial class Pasien_Resepsionis_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pasien_Resepsionis_Frm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tl_pasien = new Guna.UI.WinForms.GunaDateTimePicker();
            this.goldar_cmb = new System.Windows.Forms.ComboBox();
            this.pasien_penyakit_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.alamat_pasien_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.jk_cmb = new System.Windows.Forms.ComboBox();
            this.pasien_nohp_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cetak_pasien_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.hapus_pasien_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.nama_pasien_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.edit_pasien_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.id_pasien_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tambah_pasien_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pasien_dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.cid_dokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnama_dokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cjk_dokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnohp_dokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctanggal_lahir_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cjk_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgoldar_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckeluhan_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cari_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnLayanan = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdminLogin = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPatient = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_refresh = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_hapus = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_edit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pasien_dgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tl_pasien);
            this.panel3.Controls.Add(this.goldar_cmb);
            this.panel3.Controls.Add(this.pasien_penyakit_txb);
            this.panel3.Controls.Add(this.alamat_pasien_txb);
            this.panel3.Controls.Add(this.jk_cmb);
            this.panel3.Controls.Add(this.pasien_nohp_txb);
            this.panel3.Controls.Add(this.cetak_pasien_btn);
            this.panel3.Controls.Add(this.hapus_pasien_btn);
            this.panel3.Controls.Add(this.nama_pasien_txb);
            this.panel3.Controls.Add(this.edit_pasien_btn);
            this.panel3.Controls.Add(this.id_pasien_txb);
            this.panel3.Controls.Add(this.tambah_pasien_btn);
            this.panel3.Location = new System.Drawing.Point(281, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(969, 277);
            this.panel3.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tanggal Lahir";
            // 
            // tl_pasien
            // 
            this.tl_pasien.BaseColor = System.Drawing.Color.White;
            this.tl_pasien.BorderColor = System.Drawing.Color.Silver;
            this.tl_pasien.CustomFormat = "dd MMM yyyy";
            this.tl_pasien.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.tl_pasien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tl_pasien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tl_pasien.ForeColor = System.Drawing.Color.Black;
            this.tl_pasien.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tl_pasien.Location = new System.Drawing.Point(36, 147);
            this.tl_pasien.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tl_pasien.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tl_pasien.Name = "tl_pasien";
            this.tl_pasien.OnHoverBaseColor = System.Drawing.Color.White;
            this.tl_pasien.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tl_pasien.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tl_pasien.OnPressedColor = System.Drawing.Color.Black;
            this.tl_pasien.Size = new System.Drawing.Size(200, 30);
            this.tl_pasien.TabIndex = 29;
            this.tl_pasien.Text = "29 Mei 2024";
            this.tl_pasien.Value = new System.DateTime(2024, 5, 29, 15, 18, 18, 869);
            // 
            // goldar_cmb
            // 
            this.goldar_cmb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.goldar_cmb.FormattingEnabled = true;
            this.goldar_cmb.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "A-",
            "B-",
            "AB-",
            "O-",
            "Other"});
            this.goldar_cmb.Location = new System.Drawing.Point(492, 147);
            this.goldar_cmb.Name = "goldar_cmb";
            this.goldar_cmb.Size = new System.Drawing.Size(200, 27);
            this.goldar_cmb.TabIndex = 28;
            this.goldar_cmb.Text = "Gol Darah";
            // 
            // pasien_penyakit_txb
            // 
            this.pasien_penyakit_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pasien_penyakit_txb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasien_penyakit_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pasien_penyakit_txb.HintForeColor = System.Drawing.Color.Empty;
            this.pasien_penyakit_txb.HintText = "Keluhan";
            this.pasien_penyakit_txb.isPassword = false;
            this.pasien_penyakit_txb.LineFocusedColor = System.Drawing.Color.Blue;
            this.pasien_penyakit_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.pasien_penyakit_txb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pasien_penyakit_txb.LineThickness = 3;
            this.pasien_penyakit_txb.Location = new System.Drawing.Point(721, 125);
            this.pasien_penyakit_txb.Margin = new System.Windows.Forms.Padding(4);
            this.pasien_penyakit_txb.Name = "pasien_penyakit_txb";
            this.pasien_penyakit_txb.Size = new System.Drawing.Size(200, 49);
            this.pasien_penyakit_txb.TabIndex = 27;
            this.pasien_penyakit_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // alamat_pasien_txb
            // 
            this.alamat_pasien_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alamat_pasien_txb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat_pasien_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.alamat_pasien_txb.HintForeColor = System.Drawing.Color.Empty;
            this.alamat_pasien_txb.HintText = "Alamat Pasien";
            this.alamat_pasien_txb.isPassword = false;
            this.alamat_pasien_txb.LineFocusedColor = System.Drawing.Color.Blue;
            this.alamat_pasien_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.alamat_pasien_txb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.alamat_pasien_txb.LineThickness = 3;
            this.alamat_pasien_txb.Location = new System.Drawing.Point(492, 22);
            this.alamat_pasien_txb.Margin = new System.Windows.Forms.Padding(4);
            this.alamat_pasien_txb.Name = "alamat_pasien_txb";
            this.alamat_pasien_txb.Size = new System.Drawing.Size(200, 49);
            this.alamat_pasien_txb.TabIndex = 25;
            this.alamat_pasien_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // jk_cmb
            // 
            this.jk_cmb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.jk_cmb.FormattingEnabled = true;
            this.jk_cmb.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.jk_cmb.Location = new System.Drawing.Point(264, 147);
            this.jk_cmb.Name = "jk_cmb";
            this.jk_cmb.Size = new System.Drawing.Size(200, 27);
            this.jk_cmb.TabIndex = 24;
            this.jk_cmb.Text = "Jenis Kelamin";
            // 
            // pasien_nohp_txb
            // 
            this.pasien_nohp_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pasien_nohp_txb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasien_nohp_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pasien_nohp_txb.HintForeColor = System.Drawing.Color.Empty;
            this.pasien_nohp_txb.HintText = "No. HP";
            this.pasien_nohp_txb.isPassword = false;
            this.pasien_nohp_txb.LineFocusedColor = System.Drawing.Color.Blue;
            this.pasien_nohp_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.pasien_nohp_txb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pasien_nohp_txb.LineThickness = 3;
            this.pasien_nohp_txb.Location = new System.Drawing.Point(721, 22);
            this.pasien_nohp_txb.Margin = new System.Windows.Forms.Padding(4);
            this.pasien_nohp_txb.Name = "pasien_nohp_txb";
            this.pasien_nohp_txb.Size = new System.Drawing.Size(200, 49);
            this.pasien_nohp_txb.TabIndex = 23;
            this.pasien_nohp_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cetak_pasien_btn
            // 
            this.cetak_pasien_btn.AnimationHoverSpeed = 0.07F;
            this.cetak_pasien_btn.AnimationSpeed = 0.03F;
            this.cetak_pasien_btn.BackColor = System.Drawing.Color.Transparent;
            this.cetak_pasien_btn.BaseColor = System.Drawing.Color.RoyalBlue;
            this.cetak_pasien_btn.BorderColor = System.Drawing.Color.Black;
            this.cetak_pasien_btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.cetak_pasien_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.cetak_pasien_btn.CheckedForeColor = System.Drawing.Color.White;
            this.cetak_pasien_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("cetak_pasien_btn.CheckedImage")));
            this.cetak_pasien_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.cetak_pasien_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cetak_pasien_btn.FocusedColor = System.Drawing.Color.Empty;
            this.cetak_pasien_btn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cetak_pasien_btn.ForeColor = System.Drawing.Color.White;
            this.cetak_pasien_btn.Image = ((System.Drawing.Image)(resources.GetObject("cetak_pasien_btn.Image")));
            this.cetak_pasien_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.cetak_pasien_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.cetak_pasien_btn.Location = new System.Drawing.Point(623, 219);
            this.cetak_pasien_btn.Name = "cetak_pasien_btn";
            this.cetak_pasien_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.cetak_pasien_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cetak_pasien_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.cetak_pasien_btn.OnHoverImage = null;
            this.cetak_pasien_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.cetak_pasien_btn.OnPressedColor = System.Drawing.Color.Black;
            this.cetak_pasien_btn.Radius = 20;
            this.cetak_pasien_btn.Size = new System.Drawing.Size(125, 42);
            this.cetak_pasien_btn.TabIndex = 19;
            this.cetak_pasien_btn.Text = "Cetak";
            this.cetak_pasien_btn.Click += new System.EventHandler(this.cetak_pasien_btn_Click);
            // 
            // hapus_pasien_btn
            // 
            this.hapus_pasien_btn.AnimationHoverSpeed = 0.07F;
            this.hapus_pasien_btn.AnimationSpeed = 0.03F;
            this.hapus_pasien_btn.BackColor = System.Drawing.Color.Transparent;
            this.hapus_pasien_btn.BaseColor = System.Drawing.Color.RoyalBlue;
            this.hapus_pasien_btn.BorderColor = System.Drawing.Color.Black;
            this.hapus_pasien_btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.hapus_pasien_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.hapus_pasien_btn.CheckedForeColor = System.Drawing.Color.White;
            this.hapus_pasien_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("hapus_pasien_btn.CheckedImage")));
            this.hapus_pasien_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.hapus_pasien_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.hapus_pasien_btn.FocusedColor = System.Drawing.Color.Empty;
            this.hapus_pasien_btn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_pasien_btn.ForeColor = System.Drawing.Color.White;
            this.hapus_pasien_btn.Image = ((System.Drawing.Image)(resources.GetObject("hapus_pasien_btn.Image")));
            this.hapus_pasien_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.hapus_pasien_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.hapus_pasien_btn.Location = new System.Drawing.Point(492, 219);
            this.hapus_pasien_btn.Name = "hapus_pasien_btn";
            this.hapus_pasien_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.hapus_pasien_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.hapus_pasien_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.hapus_pasien_btn.OnHoverImage = null;
            this.hapus_pasien_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.hapus_pasien_btn.OnPressedColor = System.Drawing.Color.Black;
            this.hapus_pasien_btn.Radius = 20;
            this.hapus_pasien_btn.Size = new System.Drawing.Size(125, 42);
            this.hapus_pasien_btn.TabIndex = 18;
            this.hapus_pasien_btn.Text = "Hapus";
            this.hapus_pasien_btn.Click += new System.EventHandler(this.hapus_pasien_btn_Click);
            // 
            // nama_pasien_txb
            // 
            this.nama_pasien_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nama_pasien_txb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_pasien_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nama_pasien_txb.HintForeColor = System.Drawing.Color.Empty;
            this.nama_pasien_txb.HintText = "Nama Pasien";
            this.nama_pasien_txb.isPassword = false;
            this.nama_pasien_txb.LineFocusedColor = System.Drawing.Color.Blue;
            this.nama_pasien_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.nama_pasien_txb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nama_pasien_txb.LineThickness = 3;
            this.nama_pasien_txb.Location = new System.Drawing.Point(264, 22);
            this.nama_pasien_txb.Margin = new System.Windows.Forms.Padding(4);
            this.nama_pasien_txb.Name = "nama_pasien_txb";
            this.nama_pasien_txb.Size = new System.Drawing.Size(200, 49);
            this.nama_pasien_txb.TabIndex = 21;
            this.nama_pasien_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // edit_pasien_btn
            // 
            this.edit_pasien_btn.AnimationHoverSpeed = 0.07F;
            this.edit_pasien_btn.AnimationSpeed = 0.03F;
            this.edit_pasien_btn.BackColor = System.Drawing.Color.Transparent;
            this.edit_pasien_btn.BaseColor = System.Drawing.Color.RoyalBlue;
            this.edit_pasien_btn.BorderColor = System.Drawing.Color.Black;
            this.edit_pasien_btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.edit_pasien_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.edit_pasien_btn.CheckedForeColor = System.Drawing.Color.White;
            this.edit_pasien_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("edit_pasien_btn.CheckedImage")));
            this.edit_pasien_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.edit_pasien_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.edit_pasien_btn.FocusedColor = System.Drawing.Color.Empty;
            this.edit_pasien_btn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_pasien_btn.ForeColor = System.Drawing.Color.White;
            this.edit_pasien_btn.Image = ((System.Drawing.Image)(resources.GetObject("edit_pasien_btn.Image")));
            this.edit_pasien_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.edit_pasien_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.edit_pasien_btn.Location = new System.Drawing.Point(361, 219);
            this.edit_pasien_btn.Name = "edit_pasien_btn";
            this.edit_pasien_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.edit_pasien_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.edit_pasien_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.edit_pasien_btn.OnHoverImage = null;
            this.edit_pasien_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.edit_pasien_btn.OnPressedColor = System.Drawing.Color.Black;
            this.edit_pasien_btn.Radius = 20;
            this.edit_pasien_btn.Size = new System.Drawing.Size(125, 42);
            this.edit_pasien_btn.TabIndex = 17;
            this.edit_pasien_btn.Text = "Edit";
            this.edit_pasien_btn.Click += new System.EventHandler(this.edit_pasien_btn_Click);
            // 
            // id_pasien_txb
            // 
            this.id_pasien_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_pasien_txb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_pasien_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id_pasien_txb.HintForeColor = System.Drawing.Color.Empty;
            this.id_pasien_txb.HintText = "ID Pasien";
            this.id_pasien_txb.isPassword = false;
            this.id_pasien_txb.LineFocusedColor = System.Drawing.Color.Blue;
            this.id_pasien_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.id_pasien_txb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.id_pasien_txb.LineThickness = 3;
            this.id_pasien_txb.Location = new System.Drawing.Point(36, 22);
            this.id_pasien_txb.Margin = new System.Windows.Forms.Padding(4);
            this.id_pasien_txb.Name = "id_pasien_txb";
            this.id_pasien_txb.Size = new System.Drawing.Size(200, 49);
            this.id_pasien_txb.TabIndex = 20;
            this.id_pasien_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tambah_pasien_btn
            // 
            this.tambah_pasien_btn.AnimationHoverSpeed = 0.07F;
            this.tambah_pasien_btn.AnimationSpeed = 0.03F;
            this.tambah_pasien_btn.BackColor = System.Drawing.Color.Transparent;
            this.tambah_pasien_btn.BaseColor = System.Drawing.Color.RoyalBlue;
            this.tambah_pasien_btn.BorderColor = System.Drawing.Color.Black;
            this.tambah_pasien_btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.tambah_pasien_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.tambah_pasien_btn.CheckedForeColor = System.Drawing.Color.White;
            this.tambah_pasien_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("tambah_pasien_btn.CheckedImage")));
            this.tambah_pasien_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.tambah_pasien_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.tambah_pasien_btn.FocusedColor = System.Drawing.Color.Empty;
            this.tambah_pasien_btn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah_pasien_btn.ForeColor = System.Drawing.Color.White;
            this.tambah_pasien_btn.Image = ((System.Drawing.Image)(resources.GetObject("tambah_pasien_btn.Image")));
            this.tambah_pasien_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.tambah_pasien_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.tambah_pasien_btn.Location = new System.Drawing.Point(230, 219);
            this.tambah_pasien_btn.Name = "tambah_pasien_btn";
            this.tambah_pasien_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.tambah_pasien_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.tambah_pasien_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.tambah_pasien_btn.OnHoverImage = null;
            this.tambah_pasien_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.tambah_pasien_btn.OnPressedColor = System.Drawing.Color.Black;
            this.tambah_pasien_btn.Radius = 20;
            this.tambah_pasien_btn.Size = new System.Drawing.Size(125, 42);
            this.tambah_pasien_btn.TabIndex = 16;
            this.tambah_pasien_btn.Text = "Tambah";
            this.tambah_pasien_btn.Click += new System.EventHandler(this.tambah_pasien_btn_Click);
            // 
            // pasien_dgv
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.pasien_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.pasien_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pasien_dgv.BackgroundColor = System.Drawing.Color.White;
            this.pasien_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pasien_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.pasien_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pasien_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.pasien_dgv.ColumnHeadersHeight = 21;
            this.pasien_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid_dokter,
            this.cnama_dokter,
            this.cjk_dokter,
            this.cnohp_dokter,
            this.ctanggal_lahir_pasien,
            this.cjk_pasien,
            this.cgoldar_pasien,
            this.ckeluhan_pasien});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pasien_dgv.DefaultCellStyle = dataGridViewCellStyle15;
            this.pasien_dgv.EnableHeadersVisualStyles = false;
            this.pasien_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.pasien_dgv.Location = new System.Drawing.Point(281, 507);
            this.pasien_dgv.Name = "pasien_dgv";
            this.pasien_dgv.RowHeadersVisible = false;
            this.pasien_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pasien_dgv.Size = new System.Drawing.Size(969, 212);
            this.pasien_dgv.TabIndex = 53;
            this.pasien_dgv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.pasien_dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.pasien_dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.pasien_dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.pasien_dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.pasien_dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.pasien_dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.pasien_dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.pasien_dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pasien_dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.pasien_dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.pasien_dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.pasien_dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.pasien_dgv.ThemeStyle.HeaderStyle.Height = 21;
            this.pasien_dgv.ThemeStyle.ReadOnly = false;
            this.pasien_dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.pasien_dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.pasien_dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.pasien_dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.pasien_dgv.ThemeStyle.RowsStyle.Height = 22;
            this.pasien_dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.pasien_dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.pasien_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pasien_dgv_CellContentClick);
            // 
            // cid_dokter
            // 
            this.cid_dokter.DataPropertyName = "id_pasien";
            this.cid_dokter.FillWeight = 50F;
            this.cid_dokter.HeaderText = "ID";
            this.cid_dokter.Name = "cid_dokter";
            // 
            // cnama_dokter
            // 
            this.cnama_dokter.DataPropertyName = "nama_pasien";
            this.cnama_dokter.HeaderText = "NAMA";
            this.cnama_dokter.Name = "cnama_dokter";
            // 
            // cjk_dokter
            // 
            this.cjk_dokter.DataPropertyName = "alamat_pasien";
            this.cjk_dokter.FillWeight = 120F;
            this.cjk_dokter.HeaderText = "ALAMAT";
            this.cjk_dokter.Name = "cjk_dokter";
            // 
            // cnohp_dokter
            // 
            this.cnohp_dokter.DataPropertyName = "nohp_pasien";
            this.cnohp_dokter.HeaderText = "NO HP";
            this.cnohp_dokter.Name = "cnohp_dokter";
            // 
            // ctanggal_lahir_pasien
            // 
            this.ctanggal_lahir_pasien.DataPropertyName = "tanggal_lahir_pasien";
            this.ctanggal_lahir_pasien.HeaderText = "TANGGAL LAHIR";
            this.ctanggal_lahir_pasien.Name = "ctanggal_lahir_pasien";
            // 
            // cjk_pasien
            // 
            this.cjk_pasien.DataPropertyName = "jk_pasien";
            this.cjk_pasien.HeaderText = "JENIS KELAMIN";
            this.cjk_pasien.Name = "cjk_pasien";
            // 
            // cgoldar_pasien
            // 
            this.cgoldar_pasien.DataPropertyName = "goldar_pasien";
            this.cgoldar_pasien.FillWeight = 50F;
            this.cgoldar_pasien.HeaderText = "GOL DARAH";
            this.cgoldar_pasien.Name = "cgoldar_pasien";
            // 
            // ckeluhan_pasien
            // 
            this.ckeluhan_pasien.DataPropertyName = "keluhan_pasien";
            this.ckeluhan_pasien.HeaderText = "KELUHAN";
            this.ckeluhan_pasien.Name = "ckeluhan_pasien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 52;
            this.label4.Text = "List Pasien";
            // 
            // cari_txb
            // 
            this.cari_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cari_txb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cari_txb.HintForeColor = System.Drawing.Color.Empty;
            this.cari_txb.HintText = "Cari Data Pasien";
            this.cari_txb.isPassword = false;
            this.cari_txb.LineFocusedColor = System.Drawing.Color.Blue;
            this.cari_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.cari_txb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cari_txb.LineThickness = 3;
            this.cari_txb.Location = new System.Drawing.Point(281, 406);
            this.cari_txb.Margin = new System.Windows.Forms.Padding(4);
            this.cari_txb.Name = "cari_txb";
            this.cari_txb.Size = new System.Drawing.Size(498, 49);
            this.cari_txb.TabIndex = 55;
            this.cari_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cari_txb.OnValueChanged += new System.EventHandler(this.cari_txb_OnValueChanged);
            // 
            // btnLayanan
            // 
            this.btnLayanan.AnimationHoverSpeed = 0.07F;
            this.btnLayanan.AnimationSpeed = 0.03F;
            this.btnLayanan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLayanan.BaseColor = System.Drawing.Color.Empty;
            this.btnLayanan.BorderColor = System.Drawing.Color.Black;
            this.btnLayanan.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLayanan.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLayanan.CheckedForeColor = System.Drawing.Color.White;
            this.btnLayanan.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLayanan.CheckedImage")));
            this.btnLayanan.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnLayanan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLayanan.FocusedColor = System.Drawing.Color.Empty;
            this.btnLayanan.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayanan.ForeColor = System.Drawing.Color.White;
            this.btnLayanan.Image = ((System.Drawing.Image)(resources.GetObject("btnLayanan.Image")));
            this.btnLayanan.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLayanan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLayanan.Location = new System.Drawing.Point(13, 213);
            this.btnLayanan.Name = "btnLayanan";
            this.btnLayanan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.btnLayanan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLayanan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLayanan.OnHoverImage = null;
            this.btnLayanan.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLayanan.OnPressedColor = System.Drawing.Color.Black;
            this.btnLayanan.Size = new System.Drawing.Size(230, 49);
            this.btnLayanan.TabIndex = 34;
            this.btnLayanan.Text = "Layanan";
            this.btnLayanan.Click += new System.EventHandler(this.btnLayanan_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDashboard.BaseColor = System.Drawing.Color.Empty;
            this.btnDashboard.BorderColor = System.Drawing.Color.Black;
            this.btnDashboard.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDashboard.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.CheckedForeColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.CheckedImage")));
            this.btnDashboard.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDashboard.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDashboard.Location = new System.Drawing.Point(12, 105);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnHoverImage = null;
            this.btnDashboard.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDashboard.OnPressedColor = System.Drawing.Color.Black;
            this.btnDashboard.Size = new System.Drawing.Size(230, 49);
            this.btnDashboard.TabIndex = 24;
            this.btnDashboard.Text = "Beranda";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Klinik Gigi";
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.AnimationHoverSpeed = 0.07F;
            this.btnAdminLogin.AnimationSpeed = 0.03F;
            this.btnAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminLogin.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btnAdminLogin.BorderColor = System.Drawing.Color.Black;
            this.btnAdminLogin.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAdminLogin.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAdminLogin.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdminLogin.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAdminLogin.CheckedImage")));
            this.btnAdminLogin.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAdminLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdminLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdminLogin.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminLogin.Image")));
            this.btnAdminLogin.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAdminLogin.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdminLogin.Location = new System.Drawing.Point(529, 329);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAdminLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdminLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdminLogin.OnHoverImage = null;
            this.btnAdminLogin.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdminLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdminLogin.Radius = 20;
            this.btnAdminLogin.Size = new System.Drawing.Size(125, 42);
            this.btnAdminLogin.TabIndex = 44;
            this.btnAdminLogin.Text = "Tambah";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnLayanan);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnPatient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 768);
            this.panel1.TabIndex = 48;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.BaseColor = System.Drawing.Color.Empty;
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLogout.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogout.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.CheckedImage")));
            this.btnLogout.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogout.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogout.Location = new System.Drawing.Point(13, 710);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(230, 49);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.AnimationHoverSpeed = 0.07F;
            this.btnPatient.AnimationSpeed = 0.03F;
            this.btnPatient.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPatient.BaseColor = System.Drawing.Color.Empty;
            this.btnPatient.BorderColor = System.Drawing.Color.Black;
            this.btnPatient.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPatient.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPatient.CheckedForeColor = System.Drawing.Color.White;
            this.btnPatient.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPatient.CheckedImage")));
            this.btnPatient.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPatient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPatient.FocusedColor = System.Drawing.Color.Empty;
            this.btnPatient.Font = new System.Drawing.Font("Corbel", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.White;
            this.btnPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnPatient.Image")));
            this.btnPatient.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPatient.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPatient.Location = new System.Drawing.Point(13, 159);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.btnPatient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPatient.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPatient.OnHoverImage = null;
            this.btnPatient.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPatient.OnPressedColor = System.Drawing.Color.Black;
            this.btnPatient.Size = new System.Drawing.Size(230, 49);
            this.btnPatient.TabIndex = 3;
            this.btnPatient.Text = "Pasien";
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.AnimationHoverSpeed = 0.07F;
            this.btn_refresh.AnimationSpeed = 0.03F;
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btn_refresh.BorderColor = System.Drawing.Color.Black;
            this.btn_refresh.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_refresh.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_refresh.CheckedForeColor = System.Drawing.Color.White;
            this.btn_refresh.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_refresh.CheckedImage")));
            this.btn_refresh.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_refresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_refresh.FocusedColor = System.Drawing.Color.Empty;
            this.btn_refresh.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_refresh.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_refresh.Location = new System.Drawing.Point(922, 329);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_refresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_refresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_refresh.OnHoverImage = null;
            this.btn_refresh.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_refresh.OnPressedColor = System.Drawing.Color.Black;
            this.btn_refresh.Radius = 20;
            this.btn_refresh.Size = new System.Drawing.Size(125, 42);
            this.btn_refresh.TabIndex = 47;
            this.btn_refresh.Text = "Refresh";
            // 
            // btn_hapus
            // 
            this.btn_hapus.AnimationHoverSpeed = 0.07F;
            this.btn_hapus.AnimationSpeed = 0.03F;
            this.btn_hapus.BackColor = System.Drawing.Color.Transparent;
            this.btn_hapus.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btn_hapus.BorderColor = System.Drawing.Color.Black;
            this.btn_hapus.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_hapus.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_hapus.CheckedForeColor = System.Drawing.Color.White;
            this.btn_hapus.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_hapus.CheckedImage")));
            this.btn_hapus.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_hapus.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_hapus.FocusedColor = System.Drawing.Color.Empty;
            this.btn_hapus.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.ForeColor = System.Drawing.Color.White;
            this.btn_hapus.Image = ((System.Drawing.Image)(resources.GetObject("btn_hapus.Image")));
            this.btn_hapus.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_hapus.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_hapus.Location = new System.Drawing.Point(791, 329);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_hapus.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_hapus.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_hapus.OnHoverImage = null;
            this.btn_hapus.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_hapus.OnPressedColor = System.Drawing.Color.Black;
            this.btn_hapus.Radius = 20;
            this.btn_hapus.Size = new System.Drawing.Size(125, 42);
            this.btn_hapus.TabIndex = 46;
            this.btn_hapus.Text = "Hapus";
            // 
            // btn_edit
            // 
            this.btn_edit.AnimationHoverSpeed = 0.07F;
            this.btn_edit.AnimationSpeed = 0.03F;
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btn_edit.BorderColor = System.Drawing.Color.Black;
            this.btn_edit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_edit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_edit.CheckedForeColor = System.Drawing.Color.White;
            this.btn_edit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_edit.CheckedImage")));
            this.btn_edit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_edit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_edit.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_edit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_edit.Location = new System.Drawing.Point(660, 329);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_edit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_edit.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_edit.OnHoverImage = null;
            this.btn_edit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_edit.OnPressedColor = System.Drawing.Color.Black;
            this.btn_edit.Radius = 20;
            this.btn_edit.Size = new System.Drawing.Size(125, 42);
            this.btn_edit.TabIndex = 45;
            this.btn_edit.Text = "Edit";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(958, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 19;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(318, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistem Manajemen Klinik";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(257, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 100);
            this.panel2.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(93, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "Resepsionis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 26);
            this.label3.TabIndex = 57;
            this.label3.Text = "Detail Pasien";
            // 
            // Pasien_Resepsionis_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pasien_dgv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cari_txb);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pasien_Resepsionis_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasien_Resepsionis_Frm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pasien_dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaDateTimePicker tl_pasien;
        private System.Windows.Forms.ComboBox goldar_cmb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pasien_penyakit_txb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox alamat_pasien_txb;
        private System.Windows.Forms.ComboBox jk_cmb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pasien_nohp_txb;
        private Guna.UI.WinForms.GunaAdvenceButton cetak_pasien_btn;
        private Guna.UI.WinForms.GunaAdvenceButton hapus_pasien_btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nama_pasien_txb;
        private Guna.UI.WinForms.GunaAdvenceButton edit_pasien_btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id_pasien_txb;
        private Guna.UI.WinForms.GunaAdvenceButton tambah_pasien_btn;
        private Guna.UI.WinForms.GunaDataGridView pasien_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid_dokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnama_dokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cjk_dokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnohp_dokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctanggal_lahir_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cjk_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgoldar_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckeluhan_pasien;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cari_txb;
        private Guna.UI.WinForms.GunaAdvenceButton btnLayanan;
        private Guna.UI.WinForms.GunaAdvenceButton btnDashboard;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdminLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaAdvenceButton btnLogout;
        private Guna.UI.WinForms.GunaAdvenceButton btnPatient;
        private Guna.UI.WinForms.GunaAdvenceButton btn_refresh;
        private Guna.UI.WinForms.GunaAdvenceButton btn_hapus;
        private Guna.UI.WinForms.GunaAdvenceButton btn_edit;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}