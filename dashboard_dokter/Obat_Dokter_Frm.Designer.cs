namespace Dental_Management_System.dashboard_dokter
{
    partial class Obat_Dokter_Frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Obat_Dokter_Frm));
            this.cariobat_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cjk_dokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnama_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_obat_lbl = new System.Windows.Forms.Label();
            this.obat_dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.jenis_obat_cmb = new System.Windows.Forms.ComboBox();
            this.btnCetak = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnHapus = new Guna.UI.WinForms.GunaAdvenceButton();
            this.nama_obat_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnEdit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.id_obat_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnTambah = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_cariobat = new Guna.UI.WinForms.GunaAdvenceButton();
            this.detail_medicine_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMedicine = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDiagnosis = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.obat_dgv)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cariobat_txb
            // 
            this.cariobat_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cariobat_txb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariobat_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cariobat_txb.HintForeColor = System.Drawing.Color.Empty;
            this.cariobat_txb.HintText = "Cari data Obat";
            this.cariobat_txb.isPassword = false;
            this.cariobat_txb.LineFocusedColor = System.Drawing.Color.Blue;
            this.cariobat_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.cariobat_txb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cariobat_txb.LineThickness = 3;
            this.cariobat_txb.Location = new System.Drawing.Point(293, 438);
            this.cariobat_txb.Margin = new System.Windows.Forms.Padding(4);
            this.cariobat_txb.Name = "cariobat_txb";
            this.cariobat_txb.Size = new System.Drawing.Size(498, 49);
            this.cariobat_txb.TabIndex = 53;
            this.cariobat_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cariobat_txb.OnValueChanged += new System.EventHandler(this.cariobat_txb_OnValueChanged);
            // 
            // cjk_dokter
            // 
            this.cjk_dokter.DataPropertyName = "jenis_obat";
            this.cjk_dokter.FillWeight = 125.4637F;
            this.cjk_dokter.HeaderText = "JENIS OBAT";
            this.cjk_dokter.MinimumWidth = 8;
            this.cjk_dokter.Name = "cjk_dokter";
            // 
            // cnama_obat
            // 
            this.cnama_obat.DataPropertyName = "nama_obat";
            this.cnama_obat.FillWeight = 89.30898F;
            this.cnama_obat.HeaderText = "NAMA OBAT";
            this.cnama_obat.MinimumWidth = 8;
            this.cnama_obat.Name = "cnama_obat";
            // 
            // cid_obat
            // 
            this.cid_obat.DataPropertyName = "id_obat";
            this.cid_obat.FillWeight = 85.22727F;
            this.cid_obat.HeaderText = "ID OBAT";
            this.cid_obat.MinimumWidth = 8;
            this.cid_obat.Name = "cid_obat";
            // 
            // list_obat_lbl
            // 
            this.list_obat_lbl.AutoSize = true;
            this.list_obat_lbl.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_obat_lbl.Location = new System.Drawing.Point(291, 506);
            this.list_obat_lbl.Name = "list_obat_lbl";
            this.list_obat_lbl.Size = new System.Drawing.Size(94, 26);
            this.list_obat_lbl.TabIndex = 54;
            this.list_obat_lbl.Text = "List Obat";
            // 
            // obat_dgv
            // 
            this.obat_dgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.obat_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.obat_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.obat_dgv.BackgroundColor = System.Drawing.Color.White;
            this.obat_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.obat_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.obat_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.obat_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.obat_dgv.ColumnHeadersHeight = 21;
            this.obat_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid_obat,
            this.cnama_obat,
            this.cjk_dokter});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.obat_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.obat_dgv.EnableHeadersVisualStyles = false;
            this.obat_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.obat_dgv.Location = new System.Drawing.Point(296, 535);
            this.obat_dgv.Name = "obat_dgv";
            this.obat_dgv.RowHeadersVisible = false;
            this.obat_dgv.RowHeadersWidth = 62;
            this.obat_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.obat_dgv.Size = new System.Drawing.Size(969, 221);
            this.obat_dgv.TabIndex = 55;
            this.obat_dgv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.obat_dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.obat_dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.obat_dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.obat_dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.obat_dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.obat_dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.obat_dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.obat_dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.obat_dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.obat_dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.obat_dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.obat_dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.obat_dgv.ThemeStyle.HeaderStyle.Height = 21;
            this.obat_dgv.ThemeStyle.ReadOnly = false;
            this.obat_dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.obat_dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.obat_dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.obat_dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.obat_dgv.ThemeStyle.RowsStyle.Height = 22;
            this.obat_dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.obat_dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.obat_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.obat_dgv_CellContentClick);
            // 
            // jenis_obat_cmb
            // 
            this.jenis_obat_cmb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenis_obat_cmb.FormattingEnabled = true;
            this.jenis_obat_cmb.Items.AddRange(new object[] {
            "Kapsul",
            "Tablet",
            "Sirup"});
            this.jenis_obat_cmb.Location = new System.Drawing.Point(22, 117);
            this.jenis_obat_cmb.Name = "jenis_obat_cmb";
            this.jenis_obat_cmb.Size = new System.Drawing.Size(239, 27);
            this.jenis_obat_cmb.TabIndex = 25;
            this.jenis_obat_cmb.Text = "Jenis Obat";
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
            this.btnCetak.Location = new System.Drawing.Point(634, 196);
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
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
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
            this.btnHapus.Location = new System.Drawing.Point(503, 196);
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
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // nama_obat_txb
            // 
            this.nama_obat_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nama_obat_txb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_obat_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nama_obat_txb.HintForeColor = System.Drawing.Color.Empty;
            this.nama_obat_txb.HintText = "Nama Obat";
            this.nama_obat_txb.isPassword = false;
            this.nama_obat_txb.LineFocusedColor = System.Drawing.Color.Blue;
            this.nama_obat_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.nama_obat_txb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nama_obat_txb.LineThickness = 3;
            this.nama_obat_txb.Location = new System.Drawing.Point(438, 34);
            this.nama_obat_txb.Margin = new System.Windows.Forms.Padding(4);
            this.nama_obat_txb.Name = "nama_obat_txb";
            this.nama_obat_txb.Size = new System.Drawing.Size(373, 49);
            this.nama_obat_txb.TabIndex = 21;
            this.nama_obat_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnEdit.Location = new System.Drawing.Point(372, 196);
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // id_obat_txb
            // 
            this.id_obat_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_obat_txb.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_obat_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id_obat_txb.HintForeColor = System.Drawing.Color.Empty;
            this.id_obat_txb.HintText = "ID Obat";
            this.id_obat_txb.isPassword = false;
            this.id_obat_txb.LineFocusedColor = System.Drawing.Color.Blue;
            this.id_obat_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.id_obat_txb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.id_obat_txb.LineThickness = 3;
            this.id_obat_txb.Location = new System.Drawing.Point(22, 34);
            this.id_obat_txb.Margin = new System.Windows.Forms.Padding(4);
            this.id_obat_txb.Name = "id_obat_txb";
            this.id_obat_txb.Size = new System.Drawing.Size(352, 49);
            this.id_obat_txb.TabIndex = 20;
            this.id_obat_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnTambah.Location = new System.Drawing.Point(241, 196);
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
            // btn_cariobat
            // 
            this.btn_cariobat.AnimationHoverSpeed = 0.07F;
            this.btn_cariobat.AnimationSpeed = 0.03F;
            this.btn_cariobat.BackColor = System.Drawing.Color.Transparent;
            this.btn_cariobat.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btn_cariobat.BorderColor = System.Drawing.Color.Black;
            this.btn_cariobat.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_cariobat.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_cariobat.CheckedForeColor = System.Drawing.Color.White;
            this.btn_cariobat.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_cariobat.CheckedImage")));
            this.btn_cariobat.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_cariobat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_cariobat.FocusedColor = System.Drawing.Color.Empty;
            this.btn_cariobat.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cariobat.ForeColor = System.Drawing.Color.White;
            this.btn_cariobat.Image = ((System.Drawing.Image)(resources.GetObject("btn_cariobat.Image")));
            this.btn_cariobat.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_cariobat.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_cariobat.Location = new System.Drawing.Point(811, 445);
            this.btn_cariobat.Name = "btn_cariobat";
            this.btn_cariobat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(239)))));
            this.btn_cariobat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_cariobat.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_cariobat.OnHoverImage = null;
            this.btn_cariobat.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_cariobat.OnPressedColor = System.Drawing.Color.Black;
            this.btn_cariobat.Radius = 20;
            this.btn_cariobat.Size = new System.Drawing.Size(125, 42);
            this.btn_cariobat.TabIndex = 52;
            this.btn_cariobat.Text = "Cari";
            // 
            // detail_medicine_lbl
            // 
            this.detail_medicine_lbl.AutoSize = true;
            this.detail_medicine_lbl.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail_medicine_lbl.Location = new System.Drawing.Point(314, 121);
            this.detail_medicine_lbl.Name = "detail_medicine_lbl";
            this.detail_medicine_lbl.Size = new System.Drawing.Size(115, 26);
            this.detail_medicine_lbl.TabIndex = 50;
            this.detail_medicine_lbl.Text = "Detail Obat";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.jenis_obat_cmb);
            this.panel3.Controls.Add(this.btnCetak);
            this.panel3.Controls.Add(this.btnHapus);
            this.panel3.Controls.Add(this.nama_obat_txb);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.id_obat_txb);
            this.panel3.Controls.Add(this.btnTambah);
            this.panel3.Location = new System.Drawing.Point(296, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(955, 282);
            this.panel3.TabIndex = 51;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(990, 4);
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
            this.panel2.TabIndex = 49;
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
            this.btnMedicine.Font = new System.Drawing.Font("Corbel", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicine.ForeColor = System.Drawing.Color.White;
            this.btnMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicine.Image")));
            this.btnMedicine.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMedicine.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMedicine.Location = new System.Drawing.Point(13, 197);
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
            this.btnDiagnosis.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnosis.ForeColor = System.Drawing.Color.White;
            this.btnDiagnosis.Image = ((System.Drawing.Image)(resources.GetObject("btnDiagnosis.Image")));
            this.btnDiagnosis.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDiagnosis.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDiagnosis.Location = new System.Drawing.Point(13, 149);
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
            this.btnDiagnosis.Click += new System.EventHandler(this.btnDiagnosis_Click);
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
            this.panel1.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(91, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "Dokter";
            // 
            // Obat_Dokter_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.cariobat_txb);
            this.Controls.Add(this.list_obat_lbl);
            this.Controls.Add(this.obat_dgv);
            this.Controls.Add(this.btn_cariobat);
            this.Controls.Add(this.detail_medicine_lbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Obat_Dokter_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obat_Dokter_Frm";
            ((System.ComponentModel.ISupportInitialize)(this.obat_dgv)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox cariobat_txb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cjk_dokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnama_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid_obat;
        private System.Windows.Forms.Label list_obat_lbl;
        private Guna.UI.WinForms.GunaDataGridView obat_dgv;
        private System.Windows.Forms.ComboBox jenis_obat_cmb;
        private Guna.UI.WinForms.GunaAdvenceButton btnCetak;
        private Guna.UI.WinForms.GunaAdvenceButton btnHapus;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nama_obat_txb;
        private Guna.UI.WinForms.GunaAdvenceButton btnEdit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id_obat_txb;
        private Guna.UI.WinForms.GunaAdvenceButton btnTambah;
        private Guna.UI.WinForms.GunaAdvenceButton btn_cariobat;
        private System.Windows.Forms.Label detail_medicine_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton btnMedicine;
        private Guna.UI.WinForms.GunaAdvenceButton btnDashboard;
        private Guna.UI.WinForms.GunaAdvenceButton btnDiagnosis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaAdvenceButton btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}