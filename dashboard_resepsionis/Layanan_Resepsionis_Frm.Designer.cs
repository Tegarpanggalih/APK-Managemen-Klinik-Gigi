namespace Dental_Management_System.dashboard_resepsionis
{
    partial class Layanan_Resepsionis_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layanan_Resepsionis_Frm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cid_diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctindakan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cari_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.list_diagnosis_lbl = new System.Windows.Forms.Label();
            this.detail_medicine_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tl_layanan = new Guna.UI.WinForms.GunaDateTimePicker();
            this.id_diagnosis_cmb = new System.Windows.Forms.ComboBox();
            this.btnCetak = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnHapus = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tindakan_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnEdit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.id_layanan_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnTambah = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ctanggal_layanan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid_layanan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashboard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPatient = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_refresh = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_hapus = new Guna.UI.WinForms.GunaAdvenceButton();
            this.layanan_dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLayanan = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layanan_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cid_diagnosis
            // 
            this.cid_diagnosis.DataPropertyName = "id_diagnosis";
            this.cid_diagnosis.HeaderText = "DIAGNOSIS";
            this.cid_diagnosis.Name = "cid_diagnosis";
            // 
            // ctindakan
            // 
            this.ctindakan.DataPropertyName = "tindakan_layanan";
            this.ctindakan.HeaderText = "TINDAKAN";
            this.ctindakan.Name = "ctindakan";
            // 
            // cari_txb
            // 
            this.cari_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cari_txb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cari_txb.HintForeColor = System.Drawing.Color.Empty;
            this.cari_txb.HintText = "Cari data Layanan";
            this.cari_txb.isPassword = false;
            this.cari_txb.LineFocusedColor = System.Drawing.Color.Blue;
            this.cari_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.cari_txb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cari_txb.LineThickness = 3;
            this.cari_txb.Location = new System.Drawing.Point(292, 427);
            this.cari_txb.Margin = new System.Windows.Forms.Padding(4);
            this.cari_txb.Name = "cari_txb";
            this.cari_txb.Size = new System.Drawing.Size(498, 49);
            this.cari_txb.TabIndex = 50;
            this.cari_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cari_txb.OnValueChanged += new System.EventHandler(this.cari_txb_OnValueChanged);
            // 
            // list_diagnosis_lbl
            // 
            this.list_diagnosis_lbl.AutoSize = true;
            this.list_diagnosis_lbl.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_diagnosis_lbl.Location = new System.Drawing.Point(292, 487);
            this.list_diagnosis_lbl.Name = "list_diagnosis_lbl";
            this.list_diagnosis_lbl.Size = new System.Drawing.Size(128, 26);
            this.list_diagnosis_lbl.TabIndex = 49;
            this.list_diagnosis_lbl.Text = "List Layanan";
            // 
            // detail_medicine_lbl
            // 
            this.detail_medicine_lbl.AutoSize = true;
            this.detail_medicine_lbl.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail_medicine_lbl.Location = new System.Drawing.Point(310, 118);
            this.detail_medicine_lbl.Name = "detail_medicine_lbl";
            this.detail_medicine_lbl.Size = new System.Drawing.Size(149, 26);
            this.detail_medicine_lbl.TabIndex = 47;
            this.detail_medicine_lbl.Text = "Detail Layanan";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tl_layanan);
            this.panel3.Controls.Add(this.id_diagnosis_cmb);
            this.panel3.Controls.Add(this.btnCetak);
            this.panel3.Controls.Add(this.btnHapus);
            this.panel3.Controls.Add(this.tindakan_txb);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.id_layanan_txb);
            this.panel3.Controls.Add(this.btnTambah);
            this.panel3.Location = new System.Drawing.Point(292, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(955, 282);
            this.panel3.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tanggal Layanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "ID Diagnosis";
            // 
            // tl_layanan
            // 
            this.tl_layanan.BaseColor = System.Drawing.Color.White;
            this.tl_layanan.BorderColor = System.Drawing.Color.Silver;
            this.tl_layanan.CustomFormat = null;
            this.tl_layanan.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.tl_layanan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tl_layanan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tl_layanan.ForeColor = System.Drawing.Color.Black;
            this.tl_layanan.Location = new System.Drawing.Point(447, 67);
            this.tl_layanan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tl_layanan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tl_layanan.Name = "tl_layanan";
            this.tl_layanan.OnHoverBaseColor = System.Drawing.Color.White;
            this.tl_layanan.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tl_layanan.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tl_layanan.OnPressedColor = System.Drawing.Color.Black;
            this.tl_layanan.Size = new System.Drawing.Size(200, 30);
            this.tl_layanan.TabIndex = 38;
            this.tl_layanan.Text = "Rabu, 29 Mei 2024";
            this.tl_layanan.Value = new System.DateTime(2024, 5, 29, 15, 18, 18, 869);
            // 
            // id_diagnosis_cmb
            // 
            this.id_diagnosis_cmb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_diagnosis_cmb.FormattingEnabled = true;
            this.id_diagnosis_cmb.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.id_diagnosis_cmb.Location = new System.Drawing.Point(22, 139);
            this.id_diagnosis_cmb.Name = "id_diagnosis_cmb";
            this.id_diagnosis_cmb.Size = new System.Drawing.Size(312, 27);
            this.id_diagnosis_cmb.TabIndex = 25;
            this.id_diagnosis_cmb.Text = "ID Diagnosis";
            // 
            // btnCetak
            // 
            this.btnCetak.AnimationHoverSpeed = 0.07F;
            this.btnCetak.AnimationSpeed = 0.03F;
            this.btnCetak.BackColor = System.Drawing.Color.Transparent;
            this.btnCetak.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btnCetak.BorderColor = System.Drawing.Color.Black;
            this.btnCetak.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCetak.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCetak.CheckedForeColor = System.Drawing.Color.White;
            this.btnCetak.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCetak.CheckedImage")));
            this.btnCetak.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCetak.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCetak.FocusedColor = System.Drawing.Color.Empty;
            this.btnCetak.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.ForeColor = System.Drawing.Color.White;
            this.btnCetak.Image = ((System.Drawing.Image)(resources.GetObject("btnCetak.Image")));
            this.btnCetak.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCetak.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCetak.Location = new System.Drawing.Point(634, 203);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.btnCetak.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCetak.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCetak.OnHoverImage = null;
            this.btnCetak.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCetak.OnPressedColor = System.Drawing.Color.Black;
            this.btnCetak.Radius = 20;
            this.btnCetak.Size = new System.Drawing.Size(125, 42);
            this.btnCetak.TabIndex = 19;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click_1);
            // 
            // btnHapus
            // 
            this.btnHapus.AnimationHoverSpeed = 0.07F;
            this.btnHapus.AnimationSpeed = 0.03F;
            this.btnHapus.BackColor = System.Drawing.Color.Transparent;
            this.btnHapus.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btnHapus.BorderColor = System.Drawing.Color.Black;
            this.btnHapus.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnHapus.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnHapus.CheckedForeColor = System.Drawing.Color.White;
            this.btnHapus.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnHapus.CheckedImage")));
            this.btnHapus.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnHapus.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHapus.FocusedColor = System.Drawing.Color.Empty;
            this.btnHapus.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Image = ((System.Drawing.Image)(resources.GetObject("btnHapus.Image")));
            this.btnHapus.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHapus.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHapus.Location = new System.Drawing.Point(503, 203);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.btnHapus.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHapus.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHapus.OnHoverImage = null;
            this.btnHapus.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHapus.OnPressedColor = System.Drawing.Color.Black;
            this.btnHapus.Radius = 20;
            this.btnHapus.Size = new System.Drawing.Size(125, 42);
            this.btnHapus.TabIndex = 18;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click_1);
            // 
            // tindakan_txb
            // 
            this.tindakan_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tindakan_txb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tindakan_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tindakan_txb.HintForeColor = System.Drawing.Color.Empty;
            this.tindakan_txb.HintText = "Tindakan";
            this.tindakan_txb.isPassword = false;
            this.tindakan_txb.LineFocusedColor = System.Drawing.Color.Blue;
            this.tindakan_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.tindakan_txb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tindakan_txb.LineThickness = 3;
            this.tindakan_txb.Location = new System.Drawing.Point(447, 117);
            this.tindakan_txb.Margin = new System.Windows.Forms.Padding(4);
            this.tindakan_txb.Name = "tindakan_txb";
            this.tindakan_txb.Size = new System.Drawing.Size(373, 49);
            this.tindakan_txb.TabIndex = 21;
            this.tindakan_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnEdit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEdit.CheckedForeColor = System.Drawing.Color.White;
            this.btnEdit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.CheckedImage")));
            this.btnEdit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEdit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEdit.Location = new System.Drawing.Point(372, 203);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 20;
            this.btnEdit.Size = new System.Drawing.Size(125, 42);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // id_layanan_txb
            // 
            this.id_layanan_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_layanan_txb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_layanan_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id_layanan_txb.HintForeColor = System.Drawing.Color.Empty;
            this.id_layanan_txb.HintText = "ID Layanan";
            this.id_layanan_txb.isPassword = false;
            this.id_layanan_txb.LineFocusedColor = System.Drawing.Color.Blue;
            this.id_layanan_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.id_layanan_txb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.id_layanan_txb.LineThickness = 3;
            this.id_layanan_txb.Location = new System.Drawing.Point(22, 34);
            this.id_layanan_txb.Margin = new System.Windows.Forms.Padding(4);
            this.id_layanan_txb.Name = "id_layanan_txb";
            this.id_layanan_txb.Size = new System.Drawing.Size(312, 49);
            this.id_layanan_txb.TabIndex = 20;
            this.id_layanan_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnTambah
            // 
            this.btnTambah.AnimationHoverSpeed = 0.07F;
            this.btnTambah.AnimationSpeed = 0.03F;
            this.btnTambah.BackColor = System.Drawing.Color.Transparent;
            this.btnTambah.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btnTambah.BorderColor = System.Drawing.Color.Black;
            this.btnTambah.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnTambah.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnTambah.CheckedForeColor = System.Drawing.Color.White;
            this.btnTambah.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnTambah.CheckedImage")));
            this.btnTambah.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnTambah.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTambah.FocusedColor = System.Drawing.Color.Empty;
            this.btnTambah.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Image = ((System.Drawing.Image)(resources.GetObject("btnTambah.Image")));
            this.btnTambah.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTambah.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTambah.Location = new System.Drawing.Point(241, 203);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.btnTambah.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTambah.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTambah.OnHoverImage = null;
            this.btnTambah.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTambah.OnPressedColor = System.Drawing.Color.Black;
            this.btnTambah.Radius = 20;
            this.btnTambah.Size = new System.Drawing.Size(125, 42);
            this.btnTambah.TabIndex = 16;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // ctanggal_layanan
            // 
            this.ctanggal_layanan.DataPropertyName = "tanggal_layanan";
            this.ctanggal_layanan.HeaderText = "TANGGAL LAYANAN";
            this.ctanggal_layanan.Name = "ctanggal_layanan";
            // 
            // cid_layanan
            // 
            this.cid_layanan.DataPropertyName = "id_layanan";
            this.cid_layanan.HeaderText = "ID LAYANAN";
            this.cid_layanan.Name = "cid_layanan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnLayanan);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnPatient);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btn_hapus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 768);
            this.panel1.TabIndex = 45;
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
            this.btnDashboard.TabIndex = 29;
            this.btnDashboard.Text = "Beranda";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
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
            this.btnPatient.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.White;
            this.btnPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnPatient.Image")));
            this.btnPatient.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPatient.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPatient.Location = new System.Drawing.Point(13, 154);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.btnPatient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPatient.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPatient.OnHoverImage = null;
            this.btnPatient.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPatient.OnPressedColor = System.Drawing.Color.Black;
            this.btnPatient.Size = new System.Drawing.Size(230, 49);
            this.btnPatient.TabIndex = 26;
            this.btnPatient.Text = "Pasien";
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click_1);
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
            this.btn_refresh.Location = new System.Drawing.Point(394, 77);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_refresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_refresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_refresh.OnHoverImage = null;
            this.btn_refresh.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_refresh.OnPressedColor = System.Drawing.Color.Black;
            this.btn_refresh.Radius = 20;
            this.btn_refresh.Size = new System.Drawing.Size(125, 42);
            this.btn_refresh.TabIndex = 23;
            this.btn_refresh.Text = "Refresh";
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
            this.btn_hapus.Location = new System.Drawing.Point(263, 77);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_hapus.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_hapus.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_hapus.OnHoverImage = null;
            this.btn_hapus.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_hapus.OnPressedColor = System.Drawing.Color.Black;
            this.btn_hapus.Radius = 20;
            this.btn_hapus.Size = new System.Drawing.Size(125, 42);
            this.btn_hapus.TabIndex = 22;
            this.btn_hapus.Text = "Hapus";
            // 
            // layanan_dgv
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.layanan_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.layanan_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.layanan_dgv.BackgroundColor = System.Drawing.Color.White;
            this.layanan_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.layanan_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.layanan_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.layanan_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.layanan_dgv.ColumnHeadersHeight = 21;
            this.layanan_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid_layanan,
            this.cid_diagnosis,
            this.ctanggal_layanan,
            this.ctindakan});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.layanan_dgv.DefaultCellStyle = dataGridViewCellStyle18;
            this.layanan_dgv.EnableHeadersVisualStyles = false;
            this.layanan_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.layanan_dgv.Location = new System.Drawing.Point(292, 521);
            this.layanan_dgv.Name = "layanan_dgv";
            this.layanan_dgv.RowHeadersVisible = false;
            this.layanan_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.layanan_dgv.Size = new System.Drawing.Size(955, 178);
            this.layanan_dgv.TabIndex = 51;
            this.layanan_dgv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.layanan_dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.layanan_dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.layanan_dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.layanan_dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.layanan_dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.layanan_dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.layanan_dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.layanan_dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.layanan_dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.layanan_dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.layanan_dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.layanan_dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.layanan_dgv.ThemeStyle.HeaderStyle.Height = 21;
            this.layanan_dgv.ThemeStyle.ReadOnly = false;
            this.layanan_dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.layanan_dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.layanan_dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.layanan_dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.layanan_dgv.ThemeStyle.RowsStyle.Height = 22;
            this.layanan_dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.layanan_dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.layanan_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.layanan_dgv_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(988, 4);
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
            this.panel2.TabIndex = 53;
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
            this.btnLayanan.Font = new System.Drawing.Font("Corbel", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayanan.ForeColor = System.Drawing.Color.White;
            this.btnLayanan.Image = ((System.Drawing.Image)(resources.GetObject("btnLayanan.Image")));
            this.btnLayanan.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLayanan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLayanan.Location = new System.Drawing.Point(13, 199);
            this.btnLayanan.Name = "btnLayanan";
            this.btnLayanan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.btnLayanan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLayanan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLayanan.OnHoverImage = null;
            this.btnLayanan.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLayanan.OnPressedColor = System.Drawing.Color.Black;
            this.btnLayanan.Size = new System.Drawing.Size(230, 49);
            this.btnLayanan.TabIndex = 30;
            this.btnLayanan.Text = "Layanan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(92, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Resepsionis";
            // 
            // Layanan_Resepsionis_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cari_txb);
            this.Controls.Add(this.list_diagnosis_lbl);
            this.Controls.Add(this.detail_medicine_lbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.layanan_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Layanan_Resepsionis_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Layanan_Resepsionis_Frm";
            this.Load += new System.EventHandler(this.Layanan_Resepsionis_Frm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layanan_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn cid_diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctindakan;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cari_txb;
        private System.Windows.Forms.Label list_diagnosis_lbl;
        private System.Windows.Forms.Label detail_medicine_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaDateTimePicker tl_layanan;
        private System.Windows.Forms.ComboBox id_diagnosis_cmb;
        private Guna.UI.WinForms.GunaAdvenceButton btnCetak;
        private Guna.UI.WinForms.GunaAdvenceButton btnHapus;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tindakan_txb;
        private Guna.UI.WinForms.GunaAdvenceButton btnEdit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id_layanan_txb;
        private Guna.UI.WinForms.GunaAdvenceButton btnTambah;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctanggal_layanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid_layanan;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnDashboard;
        private Guna.UI.WinForms.GunaAdvenceButton btnPatient;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaAdvenceButton btn_refresh;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaAdvenceButton btnLogout;
        private Guna.UI.WinForms.GunaAdvenceButton btn_hapus;
        private Guna.UI.WinForms.GunaDataGridView layanan_dgv;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnLayanan;
        private System.Windows.Forms.Label label4;
    }
}