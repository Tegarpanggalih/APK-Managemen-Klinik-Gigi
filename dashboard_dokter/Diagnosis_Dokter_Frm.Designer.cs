namespace Dental_Management_System.dashboard_dokter
{
    partial class Diagnosis_Dokter_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnosis_Dokter_Frm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.id_obat_cmb = new System.Windows.Forms.ComboBox();
            this.id_dokter_cmb = new System.Windows.Forms.ComboBox();
            this.id_pasien_cmb = new System.Windows.Forms.ComboBox();
            this.cetak_diagnosis_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.hapus_diagnosis_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.diagnosis_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.edit_diagnosis_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cnama_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cdiagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_diagnosis_lbl = new System.Windows.Forms.Label();
            this.id_diagnosis_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tambah_diagnosis_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cnama_dokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnama_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMedicine = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDiagnosis = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_cari = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cari_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cid_diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosis_dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosis_dgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(24, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Nama Obat";
            // 
            // id_obat_cmb
            // 
            this.id_obat_cmb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.id_obat_cmb.FormattingEnabled = true;
            this.id_obat_cmb.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.id_obat_cmb.Location = new System.Drawing.Point(25, 134);
            this.id_obat_cmb.Name = "id_obat_cmb";
            this.id_obat_cmb.Size = new System.Drawing.Size(253, 27);
            this.id_obat_cmb.TabIndex = 28;
            this.id_obat_cmb.Text = "ID Obat";
            // 
            // id_dokter_cmb
            // 
            this.id_dokter_cmb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.id_dokter_cmb.FormattingEnabled = true;
            this.id_dokter_cmb.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.id_dokter_cmb.Location = new System.Drawing.Point(645, 39);
            this.id_dokter_cmb.Name = "id_dokter_cmb";
            this.id_dokter_cmb.Size = new System.Drawing.Size(244, 27);
            this.id_dokter_cmb.TabIndex = 27;
            this.id_dokter_cmb.Text = "ID Dokter";
            // 
            // id_pasien_cmb
            // 
            this.id_pasien_cmb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.id_pasien_cmb.FormattingEnabled = true;
            this.id_pasien_cmb.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.id_pasien_cmb.Location = new System.Drawing.Point(343, 39);
            this.id_pasien_cmb.Name = "id_pasien_cmb";
            this.id_pasien_cmb.Size = new System.Drawing.Size(232, 27);
            this.id_pasien_cmb.TabIndex = 24;
            this.id_pasien_cmb.Text = "ID Pasien";
            // 
            // cetak_diagnosis_btn
            // 
            this.cetak_diagnosis_btn.AnimationHoverSpeed = 0.07F;
            this.cetak_diagnosis_btn.AnimationSpeed = 0.03F;
            this.cetak_diagnosis_btn.BackColor = System.Drawing.Color.Transparent;
            this.cetak_diagnosis_btn.BaseColor = System.Drawing.Color.RoyalBlue;
            this.cetak_diagnosis_btn.BorderColor = System.Drawing.Color.Black;
            this.cetak_diagnosis_btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.cetak_diagnosis_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.cetak_diagnosis_btn.CheckedForeColor = System.Drawing.Color.White;
            this.cetak_diagnosis_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("cetak_diagnosis_btn.CheckedImage")));
            this.cetak_diagnosis_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.cetak_diagnosis_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cetak_diagnosis_btn.FocusedColor = System.Drawing.Color.Empty;
            this.cetak_diagnosis_btn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cetak_diagnosis_btn.ForeColor = System.Drawing.Color.White;
            this.cetak_diagnosis_btn.Image = ((System.Drawing.Image)(resources.GetObject("cetak_diagnosis_btn.Image")));
            this.cetak_diagnosis_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.cetak_diagnosis_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.cetak_diagnosis_btn.Location = new System.Drawing.Point(634, 196);
            this.cetak_diagnosis_btn.Name = "cetak_diagnosis_btn";
            this.cetak_diagnosis_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.cetak_diagnosis_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cetak_diagnosis_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.cetak_diagnosis_btn.OnHoverImage = null;
            this.cetak_diagnosis_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.cetak_diagnosis_btn.OnPressedColor = System.Drawing.Color.Black;
            this.cetak_diagnosis_btn.Radius = 20;
            this.cetak_diagnosis_btn.Size = new System.Drawing.Size(125, 42);
            this.cetak_diagnosis_btn.TabIndex = 19;
            this.cetak_diagnosis_btn.Text = "Cetak";
            this.cetak_diagnosis_btn.Click += new System.EventHandler(this.cetak_diagnosis_btn_Click);
            // 
            // hapus_diagnosis_btn
            // 
            this.hapus_diagnosis_btn.AnimationHoverSpeed = 0.07F;
            this.hapus_diagnosis_btn.AnimationSpeed = 0.03F;
            this.hapus_diagnosis_btn.BackColor = System.Drawing.Color.Transparent;
            this.hapus_diagnosis_btn.BaseColor = System.Drawing.Color.RoyalBlue;
            this.hapus_diagnosis_btn.BorderColor = System.Drawing.Color.Black;
            this.hapus_diagnosis_btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.hapus_diagnosis_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.hapus_diagnosis_btn.CheckedForeColor = System.Drawing.Color.White;
            this.hapus_diagnosis_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("hapus_diagnosis_btn.CheckedImage")));
            this.hapus_diagnosis_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.hapus_diagnosis_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.hapus_diagnosis_btn.FocusedColor = System.Drawing.Color.Empty;
            this.hapus_diagnosis_btn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_diagnosis_btn.ForeColor = System.Drawing.Color.White;
            this.hapus_diagnosis_btn.Image = ((System.Drawing.Image)(resources.GetObject("hapus_diagnosis_btn.Image")));
            this.hapus_diagnosis_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.hapus_diagnosis_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.hapus_diagnosis_btn.Location = new System.Drawing.Point(503, 196);
            this.hapus_diagnosis_btn.Name = "hapus_diagnosis_btn";
            this.hapus_diagnosis_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.hapus_diagnosis_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.hapus_diagnosis_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.hapus_diagnosis_btn.OnHoverImage = null;
            this.hapus_diagnosis_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.hapus_diagnosis_btn.OnPressedColor = System.Drawing.Color.Black;
            this.hapus_diagnosis_btn.Radius = 20;
            this.hapus_diagnosis_btn.Size = new System.Drawing.Size(125, 42);
            this.hapus_diagnosis_btn.TabIndex = 18;
            this.hapus_diagnosis_btn.Text = "Hapus";
            this.hapus_diagnosis_btn.Click += new System.EventHandler(this.hapus_diagnosis_btn_Click);
            // 
            // diagnosis_txb
            // 
            this.diagnosis_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.diagnosis_txb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosis_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.diagnosis_txb.HintForeColor = System.Drawing.Color.Empty;
            this.diagnosis_txb.HintText = "Diagnosis";
            this.diagnosis_txb.isPassword = false;
            this.diagnosis_txb.LineFocusedColor = System.Drawing.Color.Blue;
            this.diagnosis_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.diagnosis_txb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.diagnosis_txb.LineThickness = 3;
            this.diagnosis_txb.Location = new System.Drawing.Point(345, 112);
            this.diagnosis_txb.Margin = new System.Windows.Forms.Padding(4);
            this.diagnosis_txb.Name = "diagnosis_txb";
            this.diagnosis_txb.Size = new System.Drawing.Size(241, 49);
            this.diagnosis_txb.TabIndex = 21;
            this.diagnosis_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // edit_diagnosis_btn
            // 
            this.edit_diagnosis_btn.AnimationHoverSpeed = 0.07F;
            this.edit_diagnosis_btn.AnimationSpeed = 0.03F;
            this.edit_diagnosis_btn.BackColor = System.Drawing.Color.Transparent;
            this.edit_diagnosis_btn.BaseColor = System.Drawing.Color.RoyalBlue;
            this.edit_diagnosis_btn.BorderColor = System.Drawing.Color.Black;
            this.edit_diagnosis_btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.edit_diagnosis_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.edit_diagnosis_btn.CheckedForeColor = System.Drawing.Color.White;
            this.edit_diagnosis_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("edit_diagnosis_btn.CheckedImage")));
            this.edit_diagnosis_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.edit_diagnosis_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.edit_diagnosis_btn.FocusedColor = System.Drawing.Color.Empty;
            this.edit_diagnosis_btn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_diagnosis_btn.ForeColor = System.Drawing.Color.White;
            this.edit_diagnosis_btn.Image = ((System.Drawing.Image)(resources.GetObject("edit_diagnosis_btn.Image")));
            this.edit_diagnosis_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.edit_diagnosis_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.edit_diagnosis_btn.Location = new System.Drawing.Point(372, 196);
            this.edit_diagnosis_btn.Name = "edit_diagnosis_btn";
            this.edit_diagnosis_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.edit_diagnosis_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.edit_diagnosis_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.edit_diagnosis_btn.OnHoverImage = null;
            this.edit_diagnosis_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.edit_diagnosis_btn.OnPressedColor = System.Drawing.Color.Black;
            this.edit_diagnosis_btn.Radius = 20;
            this.edit_diagnosis_btn.Size = new System.Drawing.Size(125, 42);
            this.edit_diagnosis_btn.TabIndex = 17;
            this.edit_diagnosis_btn.Text = "Edit";
            this.edit_diagnosis_btn.Click += new System.EventHandler(this.edit_diagnosis_btn_Click);
            // 
            // cnama_obat
            // 
            this.cnama_obat.DataPropertyName = "nama_obat";
            this.cnama_obat.HeaderText = "NAMA OBAT";
            this.cnama_obat.MinimumWidth = 140;
            this.cnama_obat.Name = "cnama_obat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(643, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Nama Dokter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(341, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nama Pasien";
            // 
            // cdiagnosis
            // 
            this.cdiagnosis.DataPropertyName = "diagnosis";
            this.cdiagnosis.HeaderText = "DIAGNOSIS";
            this.cdiagnosis.MinimumWidth = 150;
            this.cdiagnosis.Name = "cdiagnosis";
            // 
            // list_diagnosis_lbl
            // 
            this.list_diagnosis_lbl.AutoSize = true;
            this.list_diagnosis_lbl.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_diagnosis_lbl.Location = new System.Drawing.Point(290, 492);
            this.list_diagnosis_lbl.Name = "list_diagnosis_lbl";
            this.list_diagnosis_lbl.Size = new System.Drawing.Size(125, 23);
            this.list_diagnosis_lbl.TabIndex = 49;
            this.list_diagnosis_lbl.Text = "List Diagnosis";
            // 
            // id_diagnosis_txb
            // 
            this.id_diagnosis_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_diagnosis_txb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_diagnosis_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id_diagnosis_txb.HintForeColor = System.Drawing.Color.Empty;
            this.id_diagnosis_txb.HintText = "ID Diagnosis";
            this.id_diagnosis_txb.isPassword = false;
            this.id_diagnosis_txb.LineFocusedColor = System.Drawing.Color.Blue;
            this.id_diagnosis_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.id_diagnosis_txb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.id_diagnosis_txb.LineThickness = 3;
            this.id_diagnosis_txb.Location = new System.Drawing.Point(22, 19);
            this.id_diagnosis_txb.Margin = new System.Windows.Forms.Padding(4);
            this.id_diagnosis_txb.Name = "id_diagnosis_txb";
            this.id_diagnosis_txb.Size = new System.Drawing.Size(244, 49);
            this.id_diagnosis_txb.TabIndex = 20;
            this.id_diagnosis_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.id_obat_cmb);
            this.panel3.Controls.Add(this.id_dokter_cmb);
            this.panel3.Controls.Add(this.id_pasien_cmb);
            this.panel3.Controls.Add(this.cetak_diagnosis_btn);
            this.panel3.Controls.Add(this.hapus_diagnosis_btn);
            this.panel3.Controls.Add(this.diagnosis_txb);
            this.panel3.Controls.Add(this.edit_diagnosis_btn);
            this.panel3.Controls.Add(this.id_diagnosis_txb);
            this.panel3.Controls.Add(this.tambah_diagnosis_btn);
            this.panel3.Location = new System.Drawing.Point(287, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(955, 282);
            this.panel3.TabIndex = 48;
            // 
            // tambah_diagnosis_btn
            // 
            this.tambah_diagnosis_btn.AnimationHoverSpeed = 0.07F;
            this.tambah_diagnosis_btn.AnimationSpeed = 0.03F;
            this.tambah_diagnosis_btn.BackColor = System.Drawing.Color.Transparent;
            this.tambah_diagnosis_btn.BaseColor = System.Drawing.Color.RoyalBlue;
            this.tambah_diagnosis_btn.BorderColor = System.Drawing.Color.Black;
            this.tambah_diagnosis_btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.tambah_diagnosis_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.tambah_diagnosis_btn.CheckedForeColor = System.Drawing.Color.White;
            this.tambah_diagnosis_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("tambah_diagnosis_btn.CheckedImage")));
            this.tambah_diagnosis_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.tambah_diagnosis_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.tambah_diagnosis_btn.FocusedColor = System.Drawing.Color.Empty;
            this.tambah_diagnosis_btn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah_diagnosis_btn.ForeColor = System.Drawing.Color.White;
            this.tambah_diagnosis_btn.Image = ((System.Drawing.Image)(resources.GetObject("tambah_diagnosis_btn.Image")));
            this.tambah_diagnosis_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.tambah_diagnosis_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.tambah_diagnosis_btn.Location = new System.Drawing.Point(241, 196);
            this.tambah_diagnosis_btn.Name = "tambah_diagnosis_btn";
            this.tambah_diagnosis_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.tambah_diagnosis_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.tambah_diagnosis_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.tambah_diagnosis_btn.OnHoverImage = null;
            this.tambah_diagnosis_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.tambah_diagnosis_btn.OnPressedColor = System.Drawing.Color.Black;
            this.tambah_diagnosis_btn.Radius = 20;
            this.tambah_diagnosis_btn.Size = new System.Drawing.Size(125, 42);
            this.tambah_diagnosis_btn.TabIndex = 16;
            this.tambah_diagnosis_btn.Text = "Tambah";
            this.tambah_diagnosis_btn.Click += new System.EventHandler(this.tambah_diagnosis_btn_Click);
            // 
            // cnama_dokter
            // 
            this.cnama_dokter.DataPropertyName = "nama_dokter";
            this.cnama_dokter.HeaderText = "NAMA DOKTER";
            this.cnama_dokter.MinimumWidth = 140;
            this.cnama_dokter.Name = "cnama_dokter";
            // 
            // cnama_pasien
            // 
            this.cnama_pasien.DataPropertyName = "nama_pasien";
            this.cnama_pasien.HeaderText = "NAMA PASIEN";
            this.cnama_pasien.MinimumWidth = 140;
            this.cnama_pasien.Name = "cnama_pasien";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnMedicine);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnDiagnosis);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 768);
            this.panel1.TabIndex = 45;
            // 
            // btnMedicine
            // 
            this.btnMedicine.AnimationHoverSpeed = 0.07F;
            this.btnMedicine.AnimationSpeed = 0.03F;
            this.btnMedicine.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMedicine.BaseColor = System.Drawing.Color.Empty;
            this.btnMedicine.BorderColor = System.Drawing.Color.Black;
            this.btnMedicine.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnMedicine.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMedicine.CheckedForeColor = System.Drawing.Color.White;
            this.btnMedicine.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnMedicine.CheckedImage")));
            this.btnMedicine.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMedicine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMedicine.FocusedColor = System.Drawing.Color.Empty;
            this.btnMedicine.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicine.ForeColor = System.Drawing.Color.White;
            this.btnMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicine.Image")));
            this.btnMedicine.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMedicine.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMedicine.Location = new System.Drawing.Point(13, 195);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.btnMedicine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMedicine.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMedicine.OnHoverImage = null;
            this.btnMedicine.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMedicine.OnPressedColor = System.Drawing.Color.Black;
            this.btnMedicine.Size = new System.Drawing.Size(230, 49);
            this.btnMedicine.TabIndex = 33;
            this.btnMedicine.Text = "Obat";
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click_2);
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
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // btnDiagnosis
            // 
            this.btnDiagnosis.AnimationHoverSpeed = 0.07F;
            this.btnDiagnosis.AnimationSpeed = 0.03F;
            this.btnDiagnosis.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDiagnosis.BaseColor = System.Drawing.Color.Empty;
            this.btnDiagnosis.BorderColor = System.Drawing.Color.Black;
            this.btnDiagnosis.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDiagnosis.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDiagnosis.CheckedForeColor = System.Drawing.Color.White;
            this.btnDiagnosis.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDiagnosis.CheckedImage")));
            this.btnDiagnosis.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDiagnosis.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDiagnosis.FocusedColor = System.Drawing.Color.Empty;
            this.btnDiagnosis.Font = new System.Drawing.Font("Corbel", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnosis.ForeColor = System.Drawing.Color.White;
            this.btnDiagnosis.Image = ((System.Drawing.Image)(resources.GetObject("btnDiagnosis.Image")));
            this.btnDiagnosis.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDiagnosis.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDiagnosis.Location = new System.Drawing.Point(13, 147);
            this.btnDiagnosis.Name = "btnDiagnosis";
            this.btnDiagnosis.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.btnDiagnosis.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDiagnosis.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDiagnosis.OnHoverImage = null;
            this.btnDiagnosis.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDiagnosis.OnPressedColor = System.Drawing.Color.Black;
            this.btnDiagnosis.Size = new System.Drawing.Size(230, 49);
            this.btnDiagnosis.TabIndex = 27;
            this.btnDiagnosis.Text = "Diagnosis";
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
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btn_cari
            // 
            this.btn_cari.AnimationHoverSpeed = 0.07F;
            this.btn_cari.AnimationSpeed = 0.03F;
            this.btn_cari.BackColor = System.Drawing.Color.Transparent;
            this.btn_cari.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btn_cari.BorderColor = System.Drawing.Color.Black;
            this.btn_cari.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_cari.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_cari.CheckedForeColor = System.Drawing.Color.White;
            this.btn_cari.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_cari.CheckedImage")));
            this.btn_cari.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_cari.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_cari.FocusedColor = System.Drawing.Color.Empty;
            this.btn_cari.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cari.ForeColor = System.Drawing.Color.White;
            this.btn_cari.Image = ((System.Drawing.Image)(resources.GetObject("btn_cari.Image")));
            this.btn_cari.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_cari.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_cari.Location = new System.Drawing.Point(805, 444);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.btn_cari.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_cari.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_cari.OnHoverImage = null;
            this.btn_cari.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_cari.OnPressedColor = System.Drawing.Color.Black;
            this.btn_cari.Radius = 20;
            this.btn_cari.Size = new System.Drawing.Size(125, 42);
            this.btn_cari.TabIndex = 51;
            this.btn_cari.Text = "Cari";
            // 
            // cari_txb
            // 
            this.cari_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cari_txb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cari_txb.HintForeColor = System.Drawing.Color.Empty;
            this.cari_txb.HintText = "Cari data Diagnosis";
            this.cari_txb.isPassword = false;
            this.cari_txb.LineFocusedColor = System.Drawing.Color.Blue;
            this.cari_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.cari_txb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cari_txb.LineThickness = 3;
            this.cari_txb.Location = new System.Drawing.Point(287, 437);
            this.cari_txb.Margin = new System.Windows.Forms.Padding(4);
            this.cari_txb.Name = "cari_txb";
            this.cari_txb.Size = new System.Drawing.Size(498, 49);
            this.cari_txb.TabIndex = 52;
            this.cari_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cari_txb.OnValueChanged += new System.EventHandler(this.cari_txb_OnValueChanged);
            // 
            // cid_diagnosis
            // 
            this.cid_diagnosis.DataPropertyName = "id_diagnosis";
            this.cid_diagnosis.HeaderText = "ID DIAGNOSIS";
            this.cid_diagnosis.MinimumWidth = 130;
            this.cid_diagnosis.Name = "cid_diagnosis";
            // 
            // diagnosis_dgv
            // 
            this.diagnosis_dgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.diagnosis_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.diagnosis_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.diagnosis_dgv.BackgroundColor = System.Drawing.Color.White;
            this.diagnosis_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diagnosis_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.diagnosis_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.diagnosis_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.diagnosis_dgv.ColumnHeadersHeight = 21;
            this.diagnosis_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid_diagnosis,
            this.cnama_pasien,
            this.cnama_dokter,
            this.cnama_obat,
            this.cdiagnosis});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.diagnosis_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.diagnosis_dgv.EnableHeadersVisualStyles = false;
            this.diagnosis_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.diagnosis_dgv.Location = new System.Drawing.Point(287, 530);
            this.diagnosis_dgv.Name = "diagnosis_dgv";
            this.diagnosis_dgv.RowHeadersVisible = false;
            this.diagnosis_dgv.RowHeadersWidth = 62;
            this.diagnosis_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.diagnosis_dgv.Size = new System.Drawing.Size(969, 212);
            this.diagnosis_dgv.TabIndex = 50;
            this.diagnosis_dgv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.diagnosis_dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.diagnosis_dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.diagnosis_dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.diagnosis_dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.diagnosis_dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.diagnosis_dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.diagnosis_dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.diagnosis_dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.diagnosis_dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.diagnosis_dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.diagnosis_dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.diagnosis_dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.diagnosis_dgv.ThemeStyle.HeaderStyle.Height = 21;
            this.diagnosis_dgv.ThemeStyle.ReadOnly = false;
            this.diagnosis_dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.diagnosis_dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.diagnosis_dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.diagnosis_dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.diagnosis_dgv.ThemeStyle.RowsStyle.Height = 22;
            this.diagnosis_dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.diagnosis_dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.diagnosis_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.diagnosis_dgv_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 53;
            this.label3.Text = "Detail Diagnosis";
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
            this.panel2.TabIndex = 54;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(991, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 19;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(91, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Dokter";
            // 
            // Diagnosis_Dokter_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.list_diagnosis_lbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cari);
            this.Controls.Add(this.cari_txb);
            this.Controls.Add(this.diagnosis_dgv);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Diagnosis_Dokter_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosis_Dokter_Frm";
            this.Load += new System.EventHandler(this.Diagnosis_Dokter_Frm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosis_dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox id_obat_cmb;
        private System.Windows.Forms.ComboBox id_dokter_cmb;
        private System.Windows.Forms.ComboBox id_pasien_cmb;
        private Guna.UI.WinForms.GunaAdvenceButton cetak_diagnosis_btn;
        private Guna.UI.WinForms.GunaAdvenceButton hapus_diagnosis_btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox diagnosis_txb;
        private Guna.UI.WinForms.GunaAdvenceButton edit_diagnosis_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnama_obat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdiagnosis;
        private System.Windows.Forms.Label list_diagnosis_lbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id_diagnosis_txb;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaAdvenceButton tambah_diagnosis_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnama_dokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnama_pasien;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnMedicine;
        private Guna.UI.WinForms.GunaAdvenceButton btnDashboard;
        private Guna.UI.WinForms.GunaAdvenceButton btnDiagnosis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaAdvenceButton btnLogout;
        private Guna.UI.WinForms.GunaAdvenceButton btn_cari;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cari_txb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid_diagnosis;
        private Guna.UI.WinForms.GunaDataGridView diagnosis_dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}