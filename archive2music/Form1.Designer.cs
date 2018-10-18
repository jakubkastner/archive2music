namespace alba
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonZobrazeniArchivu_Rozbalit = new System.Windows.Forms.Button();
            this.buttonNastaveni_SlozkaOpusVybrat = new System.Windows.Forms.Button();
            this.buttonPridaniUpravaArchivu_ArchivVybrat = new System.Windows.Forms.Button();
            this.textBoxPridaniUpravaArchivu_Interpret = new System.Windows.Forms.TextBox();
            this.textBoxPridaniUpravaArchivu_Album = new System.Windows.Forms.TextBox();
            this.textBoxPridaniUpravaArchivu_Zanr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPridaniUpravaArchivu_SlozkaStat = new System.Windows.Forms.ComboBox();
            this.comboBoxPridaniUpravaArchivu_SlozkaZanr = new System.Windows.Forms.ComboBox();
            this.buttonZobrazeniArchivu_Mp3TagMp3 = new System.Windows.Forms.Button();
            this.buttonNastaveni_Mp3TagVybrat = new System.Windows.Forms.Button();
            this.buttonNastaveni_AlbumArtVybrat = new System.Windows.Forms.Button();
            this.buttonNastaveni_OpusEnkoderVybrat = new System.Windows.Forms.Button();
            this.buttonPridaniUpravaArchivu_CoverZiskat = new System.Windows.Forms.Button();
            this.buttonZobrazeniArchivu_PrevestNaOpus = new System.Windows.Forms.Button();
            this.backgroundWorkerPrevodNaOpus = new System.ComponentModel.BackgroundWorker();
            this.buttonNastaveni_SlozkaMp3Vybrat = new System.Windows.Forms.Button();
            this.buttonZobrazeniArchivu_PresunDoKnihoven = new System.Windows.Forms.Button();
            this.buttonZobrazeniArchivu_Mp3TagOpus = new System.Windows.Forms.Button();
            this.buttonZobrazeniArchivu_Mp3TagVse = new System.Windows.Forms.Button();
            this.labelNastaveni_Mp3TagStav = new System.Windows.Forms.Label();
            this.labelNastaveni_AlbumArtStav = new System.Windows.Forms.Label();
            this.labelNastaveni_OpusEnkoderStav = new System.Windows.Forms.Label();
            this.labelPridaniUpravaArchivu_ArchivStav = new System.Windows.Forms.Label();
            this.labelNastaveni_SlozkaMp3Stav = new System.Windows.Forms.Label();
            this.labelNastaveni_SlozkaOpusStav = new System.Windows.Forms.Label();
            this.comboBoxNastaveni_Mp3Tag = new System.Windows.Forms.ComboBox();
            this.comboBoxNastaveni_AlbumArt = new System.Windows.Forms.ComboBox();
            this.comboBoxPridaniUpravaArchivu_Archiv = new System.Windows.Forms.ComboBox();
            this.comboBoxNastaveni_SlozkaOpus = new System.Windows.Forms.ComboBox();
            this.comboBoxNastaveni_SlozkaMp3 = new System.Windows.Forms.ComboBox();
            this.comboBoxNastaveni_OpusEnkoder = new System.Windows.Forms.ComboBox();
            this.labelNastaveni_SlozkaOpusOtevrit = new System.Windows.Forms.Label();
            this.labelNastaveni_SlozkaMp3Otevrit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownPridaniUpravaArchivu_Rok = new System.Windows.Forms.NumericUpDown();
            this.checkBoxPridaniUpravaArchivu_ZanrMenit = new System.Windows.Forms.CheckBox();
            this.labelPridaniUpravaArchivu_SlozkaOpusCestaStav = new System.Windows.Forms.Label();
            this.labelPridaniUpravaArchivu_SlozkaMp3CestaStav = new System.Windows.Forms.Label();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxPridaniUpravaArchivu_Cover = new System.Windows.Forms.PictureBox();
            this.buttonPridaniUpravaArchivu_CoverVybrat = new System.Windows.Forms.Button();
            this.checkBoxPridaniUpravaArchivu_PrepsatSoubory = new System.Windows.Forms.CheckBox();
            this.buttonZobrazeniArchivu_SpustitVse = new System.Windows.Forms.Button();
            this.labelPridaniUpravaArchivu_SlozkaOpusCesta = new System.Windows.Forms.Label();
            this.labelPridaniUpravaArchivu_SlozkaMp3Cesta = new System.Windows.Forms.Label();
            this.buttonPridaniUpravaArchivu_CoverSmazat = new System.Windows.Forms.Button();
            this.panelPridaniUpravaArchivu = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonPridaniUpravaArchivu_Nasledujici = new System.Windows.Forms.Button();
            this.buttonPridaniUpravaArchivu_PridatPredchozi = new System.Windows.Forms.Button();
            this.checkBoxPridaniUpravaArchivu_ArchivHesloZobrazit = new System.Windows.Forms.CheckBox();
            this.checkBoxPridaniUpravaArchivu_UkladatAutomaticky = new System.Windows.Forms.CheckBox();
            this.textBoxPridaniUpravaArchivu_ArchivHeslo = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPridaniUpravaArchivu_CoverInfo = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxPridaniUpravaArchivu_Archiv = new System.Windows.Forms.TextBox();
            this.panelNastaveni = new System.Windows.Forms.Panel();
            this.textBoxNastaveni_RozbaleniParametry = new System.Windows.Forms.TextBox();
            this.textBoxNastaveni_AlbumArtParametry = new System.Windows.Forms.TextBox();
            this.checkBoxNastaveni_ZobrazovatPodrobnostiStavu = new System.Windows.Forms.CheckBox();
            this.textBoxNastaveni_Mp3EnkoderParametry = new System.Windows.Forms.TextBox();
            this.textBoxNastaveni_OpusEnkoderParametry = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelNastaveni_RozbaleniStav = new System.Windows.Forms.Label();
            this.labelNastaveni_Mp3EnkoderStav = new System.Windows.Forms.Label();
            this.buttonNastaveni_RozbaleniVybrat = new System.Windows.Forms.Button();
            this.buttonNastaveni_Mp3EnkoderVybrat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNastaveni_Rozbaleni = new System.Windows.Forms.ComboBox();
            this.comboBoxNastaveni_Mp3Enkoder = new System.Windows.Forms.ComboBox();
            this.listViewStav = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonMenuPridaniArchivu = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonMenuZobrazeniArchivu = new System.Windows.Forms.Button();
            this.buttonMenuPridaniSlozky = new System.Windows.Forms.Button();
            this.buttonMenuNastaveni = new System.Windows.Forms.Button();
            this.buttonMenuUpravaArchivu = new System.Windows.Forms.Button();
            this.buttonZobrazeniArchivu_PrevestNaMp3 = new System.Windows.Forms.Button();
            this.backgroundWorkerPrevodNaMp3 = new System.ComponentModel.BackgroundWorker();
            this.panelPridaniSlozky = new System.Windows.Forms.Panel();
            this.checkBoxPridaniSlozky_odstranitNacteneArchivy = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.listViewPridaniSlozky_SeznamArchivu = new System.Windows.Forms.ListView();
            this.columnHeaderPridaniSlozky_SeznamArchivu_Nazev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPridaniSlozky_SeznamArchivu_Slozka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPridaniSlozky_SeznamArchivu_Typ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPridaniSlozky_SeznamArchivu_Cesta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonPridaniSlozky_NacistArchivy = new System.Windows.Forms.Button();
            this.labelPridaniSlozky_Stav = new System.Windows.Forms.Label();
            this.buttonPridaniSlozky_PridatArchivy = new System.Windows.Forms.Button();
            this.buttonPridaniSlozky_VybratSlozku = new System.Windows.Forms.Button();
            this.checkBoxPridaniSlozky_NacistPodslozky = new System.Windows.Forms.CheckBox();
            this.checkBoxPridaniSlozky_SmazatDrivePridane = new System.Windows.Forms.CheckBox();
            this.comboBoxPridaniSlozky_Slozka = new System.Windows.Forms.ComboBox();
            this.labelPridaniSlozky_VybraneArchivy = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panelZobrazeniArchivu = new System.Windows.Forms.Panel();
            this.labelZobrazeniArchivu_VybraneArchivy = new System.Windows.Forms.Label();
            this.labelZobrazeniArchivu_Kontrola = new System.Windows.Forms.Label();
            this.checkBoxZobrazeniArchivu_ZobrazitSkrytHesla = new System.Windows.Forms.CheckBox();
            this.listViewZobrazeniArchivu_SeznamArchivu = new System.Windows.Forms.ListView();
            this.columnHeaderZobrazeniArchivu_Nazev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZobrazeniArchivu_Stav = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZobrazeniArchivu_HesloSkryte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZobrazeniArchivu_Interpret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZobrazeniArchivu_Rok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZobrazeniArchivu_Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZobrazeniArchivu_Zanr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZobrazeniArchivu_SlozkaOpus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZobrazeniArchivu_SlozkaMp3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZobrazeniArchivu_Cover = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonZobrazeniArchivu_VyberZrusit = new System.Windows.Forms.Button();
            this.buttonZobrazeniArchivu_VyberVse = new System.Windows.Forms.Button();
            this.buttonZobrazeniArchivu_Odstranit = new System.Windows.Forms.Button();
            this.buttonZobrazeniArchivu_PrevestNaOpusMp3 = new System.Windows.Forms.Button();
            this.buttonZobrazeniArchivu_Mp3TagRozbalene = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.backgroundWorkerPresunDoKnihoven = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPridaniUpravaArchivu_Rok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPridaniUpravaArchivu_Cover)).BeginInit();
            this.panelPridaniUpravaArchivu.SuspendLayout();
            this.panelNastaveni.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelPridaniSlozky.SuspendLayout();
            this.panelZobrazeniArchivu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonZobrazeniArchivu_Rozbalit
            // 
            this.buttonZobrazeniArchivu_Rozbalit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZobrazeniArchivu_Rozbalit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonZobrazeniArchivu_Rozbalit.FlatAppearance.BorderSize = 0;
            this.buttonZobrazeniArchivu_Rozbalit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonZobrazeniArchivu_Rozbalit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonZobrazeniArchivu_Rozbalit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZobrazeniArchivu_Rozbalit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonZobrazeniArchivu_Rozbalit.Location = new System.Drawing.Point(267, 536);
            this.buttonZobrazeniArchivu_Rozbalit.Name = "buttonZobrazeniArchivu_Rozbalit";
            this.buttonZobrazeniArchivu_Rozbalit.Size = new System.Drawing.Size(139, 23);
            this.buttonZobrazeniArchivu_Rozbalit.TabIndex = 18;
            this.buttonZobrazeniArchivu_Rozbalit.Text = "Rozbalit archiv(y)";
            this.buttonZobrazeniArchivu_Rozbalit.UseVisualStyleBackColor = false;
            this.buttonZobrazeniArchivu_Rozbalit.Click += new System.EventHandler(this.buttonZobrazeniArchivu_Rozbalit_Click);
            // 
            // buttonNastaveni_SlozkaOpusVybrat
            // 
            this.buttonNastaveni_SlozkaOpusVybrat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNastaveni_SlozkaOpusVybrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonNastaveni_SlozkaOpusVybrat.FlatAppearance.BorderSize = 0;
            this.buttonNastaveni_SlozkaOpusVybrat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonNastaveni_SlozkaOpusVybrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonNastaveni_SlozkaOpusVybrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNastaveni_SlozkaOpusVybrat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNastaveni_SlozkaOpusVybrat.Location = new System.Drawing.Point(687, 42);
            this.buttonNastaveni_SlozkaOpusVybrat.Name = "buttonNastaveni_SlozkaOpusVybrat";
            this.buttonNastaveni_SlozkaOpusVybrat.Size = new System.Drawing.Size(110, 22);
            this.buttonNastaveni_SlozkaOpusVybrat.TabIndex = 1;
            this.buttonNastaveni_SlozkaOpusVybrat.Text = "Vybrat složku...";
            this.buttonNastaveni_SlozkaOpusVybrat.UseVisualStyleBackColor = false;
            this.buttonNastaveni_SlozkaOpusVybrat.Click += new System.EventHandler(this.buttonNastaveni_SlozkaOpusVybrat_Click);
            // 
            // buttonPridaniUpravaArchivu_ArchivVybrat
            // 
            this.buttonPridaniUpravaArchivu_ArchivVybrat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPridaniUpravaArchivu_ArchivVybrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonPridaniUpravaArchivu_ArchivVybrat.FlatAppearance.BorderSize = 0;
            this.buttonPridaniUpravaArchivu_ArchivVybrat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonPridaniUpravaArchivu_ArchivVybrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonPridaniUpravaArchivu_ArchivVybrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPridaniUpravaArchivu_ArchivVybrat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPridaniUpravaArchivu_ArchivVybrat.Location = new System.Drawing.Point(687, 42);
            this.buttonPridaniUpravaArchivu_ArchivVybrat.Name = "buttonPridaniUpravaArchivu_ArchivVybrat";
            this.buttonPridaniUpravaArchivu_ArchivVybrat.Size = new System.Drawing.Size(110, 22);
            this.buttonPridaniUpravaArchivu_ArchivVybrat.TabIndex = 1;
            this.buttonPridaniUpravaArchivu_ArchivVybrat.Text = "Vybrat soubor...";
            this.buttonPridaniUpravaArchivu_ArchivVybrat.UseVisualStyleBackColor = false;
            this.buttonPridaniUpravaArchivu_ArchivVybrat.Click += new System.EventHandler(this.buttonPridaniUpravaArchivu_ArchivVybrat_Click);
            // 
            // textBoxPridaniUpravaArchivu_Interpret
            // 
            this.textBoxPridaniUpravaArchivu_Interpret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBoxPridaniUpravaArchivu_Interpret.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPridaniUpravaArchivu_Interpret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.textBoxPridaniUpravaArchivu_Interpret.Location = new System.Drawing.Point(136, 158);
            this.textBoxPridaniUpravaArchivu_Interpret.Name = "textBoxPridaniUpravaArchivu_Interpret";
            this.textBoxPridaniUpravaArchivu_Interpret.Size = new System.Drawing.Size(208, 22);
            this.textBoxPridaniUpravaArchivu_Interpret.TabIndex = 8;
            this.textBoxPridaniUpravaArchivu_Interpret.Leave += new System.EventHandler(this.textBoxPridaniUpravaArchivu_Interpret_Leave);
            // 
            // textBoxPridaniUpravaArchivu_Album
            // 
            this.textBoxPridaniUpravaArchivu_Album.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBoxPridaniUpravaArchivu_Album.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPridaniUpravaArchivu_Album.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.textBoxPridaniUpravaArchivu_Album.Location = new System.Drawing.Point(136, 184);
            this.textBoxPridaniUpravaArchivu_Album.Name = "textBoxPridaniUpravaArchivu_Album";
            this.textBoxPridaniUpravaArchivu_Album.Size = new System.Drawing.Size(208, 22);
            this.textBoxPridaniUpravaArchivu_Album.TabIndex = 9;
            this.textBoxPridaniUpravaArchivu_Album.Leave += new System.EventHandler(this.textBoxPridaniUpravaArchivu_Album_Leave);
            // 
            // textBoxPridaniUpravaArchivu_Zanr
            // 
            this.textBoxPridaniUpravaArchivu_Zanr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBoxPridaniUpravaArchivu_Zanr.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPridaniUpravaArchivu_Zanr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.textBoxPridaniUpravaArchivu_Zanr.Location = new System.Drawing.Point(494, 184);
            this.textBoxPridaniUpravaArchivu_Zanr.Name = "textBoxPridaniUpravaArchivu_Zanr";
            this.textBoxPridaniUpravaArchivu_Zanr.Size = new System.Drawing.Size(187, 22);
            this.textBoxPridaniUpravaArchivu_Zanr.TabIndex = 11;
            this.textBoxPridaniUpravaArchivu_Zanr.Leave += new System.EventHandler(this.textBoxPridaniUpravaArchivu_Zanr_Leave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(0, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Opus";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxPridaniUpravaArchivu_SlozkaStat
            // 
            this.comboBoxPridaniUpravaArchivu_SlozkaStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.comboBoxPridaniUpravaArchivu_SlozkaStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPridaniUpravaArchivu_SlozkaStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPridaniUpravaArchivu_SlozkaStat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPridaniUpravaArchivu_SlozkaStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.comboBoxPridaniUpravaArchivu_SlozkaStat.FormattingEnabled = true;
            this.comboBoxPridaniUpravaArchivu_SlozkaStat.Items.AddRange(new object[] {
            "CZ & SK",
            "Ostatní země"});
            this.comboBoxPridaniUpravaArchivu_SlozkaStat.Location = new System.Drawing.Point(251, 97);
            this.comboBoxPridaniUpravaArchivu_SlozkaStat.Name = "comboBoxPridaniUpravaArchivu_SlozkaStat";
            this.comboBoxPridaniUpravaArchivu_SlozkaStat.Size = new System.Drawing.Size(111, 22);
            this.comboBoxPridaniUpravaArchivu_SlozkaStat.TabIndex = 7;
            this.comboBoxPridaniUpravaArchivu_SlozkaStat.SelectedIndexChanged += new System.EventHandler(this.comboBoxPridaniUpravaArchivu_SlozkaStat_SelectedIndexChanged);
            // 
            // comboBoxPridaniUpravaArchivu_SlozkaZanr
            // 
            this.comboBoxPridaniUpravaArchivu_SlozkaZanr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.comboBoxPridaniUpravaArchivu_SlozkaZanr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPridaniUpravaArchivu_SlozkaZanr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPridaniUpravaArchivu_SlozkaZanr.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPridaniUpravaArchivu_SlozkaZanr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.comboBoxPridaniUpravaArchivu_SlozkaZanr.FormattingEnabled = true;
            this.comboBoxPridaniUpravaArchivu_SlozkaZanr.Items.AddRange(new object[] {
            "Rap & Hip-Hop",
            "Ostatní žánry"});
            this.comboBoxPridaniUpravaArchivu_SlozkaZanr.Location = new System.Drawing.Point(136, 97);
            this.comboBoxPridaniUpravaArchivu_SlozkaZanr.Name = "comboBoxPridaniUpravaArchivu_SlozkaZanr";
            this.comboBoxPridaniUpravaArchivu_SlozkaZanr.Size = new System.Drawing.Size(111, 22);
            this.comboBoxPridaniUpravaArchivu_SlozkaZanr.TabIndex = 6;
            this.comboBoxPridaniUpravaArchivu_SlozkaZanr.SelectedIndexChanged += new System.EventHandler(this.comboBoxPridaniUpravaArchivu_SlozkaZanr_SelectedIndexChanged);
            // 
            // buttonZobrazeniArchivu_Mp3TagMp3
            // 
            this.buttonZobrazeniArchivu_Mp3TagMp3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZobrazeniArchivu_Mp3TagMp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonZobrazeniArchivu_Mp3TagMp3.FlatAppearance.BorderSize = 0;
            this.buttonZobrazeniArchivu_Mp3TagMp3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonZobrazeniArchivu_Mp3TagMp3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonZobrazeniArchivu_Mp3TagMp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZobrazeniArchivu_Mp3TagMp3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonZobrazeniArchivu_Mp3TagMp3.Location = new System.Drawing.Point(557, 564);
            this.buttonZobrazeniArchivu_Mp3TagMp3.Name = "buttonZobrazeniArchivu_Mp3TagMp3";
            this.buttonZobrazeniArchivu_Mp3TagMp3.Size = new System.Drawing.Size(139, 23);
            this.buttonZobrazeniArchivu_Mp3TagMp3.TabIndex = 21;
            this.buttonZobrazeniArchivu_Mp3TagMp3.Text = "Otevřít mp3 v mp3tagu";
            this.buttonZobrazeniArchivu_Mp3TagMp3.UseVisualStyleBackColor = false;
            this.buttonZobrazeniArchivu_Mp3TagMp3.Click += new System.EventHandler(this.buttonZobrazeniArchivu_Mp3TagMp3_Click);
            // 
            // buttonNastaveni_Mp3TagVybrat
            // 
            this.buttonNastaveni_Mp3TagVybrat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNastaveni_Mp3TagVybrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonNastaveni_Mp3TagVybrat.FlatAppearance.BorderSize = 0;
            this.buttonNastaveni_Mp3TagVybrat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonNastaveni_Mp3TagVybrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonNastaveni_Mp3TagVybrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNastaveni_Mp3TagVybrat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNastaveni_Mp3TagVybrat.Location = new System.Drawing.Point(687, 189);
            this.buttonNastaveni_Mp3TagVybrat.Name = "buttonNastaveni_Mp3TagVybrat";
            this.buttonNastaveni_Mp3TagVybrat.Size = new System.Drawing.Size(110, 22);
            this.buttonNastaveni_Mp3TagVybrat.TabIndex = 8;
            this.buttonNastaveni_Mp3TagVybrat.Text = "Vybrat soubor...";
            this.buttonNastaveni_Mp3TagVybrat.UseVisualStyleBackColor = false;
            this.buttonNastaveni_Mp3TagVybrat.Click += new System.EventHandler(this.buttonNastaveni_Mp3TagVybrat_Click);
            // 
            // buttonNastaveni_AlbumArtVybrat
            // 
            this.buttonNastaveni_AlbumArtVybrat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNastaveni_AlbumArtVybrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonNastaveni_AlbumArtVybrat.FlatAppearance.BorderSize = 0;
            this.buttonNastaveni_AlbumArtVybrat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonNastaveni_AlbumArtVybrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonNastaveni_AlbumArtVybrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNastaveni_AlbumArtVybrat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNastaveni_AlbumArtVybrat.Location = new System.Drawing.Point(687, 218);
            this.buttonNastaveni_AlbumArtVybrat.Name = "buttonNastaveni_AlbumArtVybrat";
            this.buttonNastaveni_AlbumArtVybrat.Size = new System.Drawing.Size(110, 22);
            this.buttonNastaveni_AlbumArtVybrat.TabIndex = 10;
            this.buttonNastaveni_AlbumArtVybrat.Text = "Vybrat soubor...";
            this.buttonNastaveni_AlbumArtVybrat.UseVisualStyleBackColor = false;
            this.buttonNastaveni_AlbumArtVybrat.Click += new System.EventHandler(this.buttonNastaveni_AlbumArtVybrat_Click);
            // 
            // buttonNastaveni_OpusEnkoderVybrat
            // 
            this.buttonNastaveni_OpusEnkoderVybrat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNastaveni_OpusEnkoderVybrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonNastaveni_OpusEnkoderVybrat.FlatAppearance.BorderSize = 0;
            this.buttonNastaveni_OpusEnkoderVybrat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonNastaveni_OpusEnkoderVybrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonNastaveni_OpusEnkoderVybrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNastaveni_OpusEnkoderVybrat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNastaveni_OpusEnkoderVybrat.Location = new System.Drawing.Point(687, 272);
            this.buttonNastaveni_OpusEnkoderVybrat.Name = "buttonNastaveni_OpusEnkoderVybrat";
            this.buttonNastaveni_OpusEnkoderVybrat.Size = new System.Drawing.Size(110, 22);
            this.buttonNastaveni_OpusEnkoderVybrat.TabIndex = 12;
            this.buttonNastaveni_OpusEnkoderVybrat.Text = "Vybrat soubor...";
            this.buttonNastaveni_OpusEnkoderVybrat.UseVisualStyleBackColor = false;
            this.buttonNastaveni_OpusEnkoderVybrat.Click += new System.EventHandler(this.buttonNastaveni_OpusEnkoderVybrat_Click);
            // 
            // buttonPridaniUpravaArchivu_CoverZiskat
            // 
            this.buttonPridaniUpravaArchivu_CoverZiskat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonPridaniUpravaArchivu_CoverZiskat.FlatAppearance.BorderSize = 0;
            this.buttonPridaniUpravaArchivu_CoverZiskat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonPridaniUpravaArchivu_CoverZiskat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonPridaniUpravaArchivu_CoverZiskat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPridaniUpravaArchivu_CoverZiskat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPridaniUpravaArchivu_CoverZiskat.Location = new System.Drawing.Point(7, 387);
            this.buttonPridaniUpravaArchivu_CoverZiskat.Name = "buttonPridaniUpravaArchivu_CoverZiskat";
            this.buttonPridaniUpravaArchivu_CoverZiskat.Size = new System.Drawing.Size(125, 22);
            this.buttonPridaniUpravaArchivu_CoverZiskat.TabIndex = 19;
            this.buttonPridaniUpravaArchivu_CoverZiskat.Text = "Získej cover";
            this.buttonPridaniUpravaArchivu_CoverZiskat.UseVisualStyleBackColor = false;
            this.buttonPridaniUpravaArchivu_CoverZiskat.Click += new System.EventHandler(this.buttonPridaniUpravaArchivu_CoverZiskat_Click);
            // 
            // buttonZobrazeniArchivu_PrevestNaOpus
            // 
            this.buttonZobrazeniArchivu_PrevestNaOpus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZobrazeniArchivu_PrevestNaOpus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonZobrazeniArchivu_PrevestNaOpus.FlatAppearance.BorderSize = 0;
            this.buttonZobrazeniArchivu_PrevestNaOpus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonZobrazeniArchivu_PrevestNaOpus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonZobrazeniArchivu_PrevestNaOpus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZobrazeniArchivu_PrevestNaOpus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonZobrazeniArchivu_PrevestNaOpus.Location = new System.Drawing.Point(412, 536);
            this.buttonZobrazeniArchivu_PrevestNaOpus.Name = "buttonZobrazeniArchivu_PrevestNaOpus";
            this.buttonZobrazeniArchivu_PrevestNaOpus.Size = new System.Drawing.Size(139, 23);
            this.buttonZobrazeniArchivu_PrevestNaOpus.TabIndex = 20;
            this.buttonZobrazeniArchivu_PrevestNaOpus.Text = "Převést na opus";
            this.buttonZobrazeniArchivu_PrevestNaOpus.UseVisualStyleBackColor = false;
            this.buttonZobrazeniArchivu_PrevestNaOpus.Click += new System.EventHandler(this.buttonZobrazeniArchivu_PrevestNaOpus_Click);
            // 
            // backgroundWorkerPrevodNaOpus
            // 
            this.backgroundWorkerPrevodNaOpus.WorkerReportsProgress = true;
            this.backgroundWorkerPrevodNaOpus.WorkerSupportsCancellation = true;
            this.backgroundWorkerPrevodNaOpus.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerPrevodNaOpus_DoWork);
            this.backgroundWorkerPrevodNaOpus.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerPrevod_ProgressChanged);
            this.backgroundWorkerPrevodNaOpus.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerPrevodNaOpus_RunWorkerCompleted);
            // 
            // buttonNastaveni_SlozkaMp3Vybrat
            // 
            this.buttonNastaveni_SlozkaMp3Vybrat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNastaveni_SlozkaMp3Vybrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonNastaveni_SlozkaMp3Vybrat.FlatAppearance.BorderSize = 0;
            this.buttonNastaveni_SlozkaMp3Vybrat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonNastaveni_SlozkaMp3Vybrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonNastaveni_SlozkaMp3Vybrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNastaveni_SlozkaMp3Vybrat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNastaveni_SlozkaMp3Vybrat.Location = new System.Drawing.Point(687, 71);
            this.buttonNastaveni_SlozkaMp3Vybrat.Name = "buttonNastaveni_SlozkaMp3Vybrat";
            this.buttonNastaveni_SlozkaMp3Vybrat.Size = new System.Drawing.Size(110, 22);
            this.buttonNastaveni_SlozkaMp3Vybrat.TabIndex = 3;
            this.buttonNastaveni_SlozkaMp3Vybrat.Text = "Vybrat složku...";
            this.buttonNastaveni_SlozkaMp3Vybrat.UseVisualStyleBackColor = false;
            this.buttonNastaveni_SlozkaMp3Vybrat.Click += new System.EventHandler(this.buttonNastaveni_SlozkaMp3Vybrat_Click);
            // 
            // buttonZobrazeniArchivu_PresunDoKnihoven
            // 
            this.buttonZobrazeniArchivu_PresunDoKnihoven.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZobrazeniArchivu_PresunDoKnihoven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonZobrazeniArchivu_PresunDoKnihoven.FlatAppearance.BorderSize = 0;
            this.buttonZobrazeniArchivu_PresunDoKnihoven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonZobrazeniArchivu_PresunDoKnihoven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonZobrazeniArchivu_PresunDoKnihoven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZobrazeniArchivu_PresunDoKnihoven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonZobrazeniArchivu_PresunDoKnihoven.Location = new System.Drawing.Point(702, 536);
            this.buttonZobrazeniArchivu_PresunDoKnihoven.Name = "buttonZobrazeniArchivu_PresunDoKnihoven";
            this.buttonZobrazeniArchivu_PresunDoKnihoven.Size = new System.Drawing.Size(139, 23);
            this.buttonZobrazeniArchivu_PresunDoKnihoven.TabIndex = 24;
            this.buttonZobrazeniArchivu_PresunDoKnihoven.Text = "Přesunout do knihoven";
            this.buttonZobrazeniArchivu_PresunDoKnihoven.UseVisualStyleBackColor = false;
            this.buttonZobrazeniArchivu_PresunDoKnihoven.Click += new System.EventHandler(this.buttonZobrazeniArchivu_PresunDoKnihoven_Click);
            // 
            // buttonZobrazeniArchivu_Mp3TagOpus
            // 
            this.buttonZobrazeniArchivu_Mp3TagOpus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZobrazeniArchivu_Mp3TagOpus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonZobrazeniArchivu_Mp3TagOpus.FlatAppearance.BorderSize = 0;
            this.buttonZobrazeniArchivu_Mp3TagOpus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonZobrazeniArchivu_Mp3TagOpus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonZobrazeniArchivu_Mp3TagOpus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZobrazeniArchivu_Mp3TagOpus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonZobrazeniArchivu_Mp3TagOpus.Location = new System.Drawing.Point(557, 536);
            this.buttonZobrazeniArchivu_Mp3TagOpus.Name = "buttonZobrazeniArchivu_Mp3TagOpus";
            this.buttonZobrazeniArchivu_Mp3TagOpus.Size = new System.Drawing.Size(139, 23);
            this.buttonZobrazeniArchivu_Mp3TagOpus.TabIndex = 22;
            this.buttonZobrazeniArchivu_Mp3TagOpus.Text = "Otevřít opus v mp3tagu";
            this.buttonZobrazeniArchivu_Mp3TagOpus.UseVisualStyleBackColor = false;
            this.buttonZobrazeniArchivu_Mp3TagOpus.Click += new System.EventHandler(this.buttonZobrazeniArchivu_Mp3TagOpus_Click);
            // 
            // buttonZobrazeniArchivu_Mp3TagVse
            // 
            this.buttonZobrazeniArchivu_Mp3TagVse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZobrazeniArchivu_Mp3TagVse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonZobrazeniArchivu_Mp3TagVse.FlatAppearance.BorderSize = 0;
            this.buttonZobrazeniArchivu_Mp3TagVse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonZobrazeniArchivu_Mp3TagVse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonZobrazeniArchivu_Mp3TagVse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZobrazeniArchivu_Mp3TagVse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonZobrazeniArchivu_Mp3TagVse.Location = new System.Drawing.Point(557, 592);
            this.buttonZobrazeniArchivu_Mp3TagVse.Name = "buttonZobrazeniArchivu_Mp3TagVse";
            this.buttonZobrazeniArchivu_Mp3TagVse.Size = new System.Drawing.Size(160, 23);
            this.buttonZobrazeniArchivu_Mp3TagVse.TabIndex = 23;
            this.buttonZobrazeniArchivu_Mp3TagVse.Text = "Otevřít opus a mp3 v mp3tagu";
            this.buttonZobrazeniArchivu_Mp3TagVse.UseVisualStyleBackColor = false;
            this.buttonZobrazeniArchivu_Mp3TagVse.Click += new System.EventHandler(this.buttonZobrazeniArchivu_Mp3TagVse_Click);
            // 
            // labelNastaveni_Mp3TagStav
            // 
            this.labelNastaveni_Mp3TagStav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNastaveni_Mp3TagStav.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNastaveni_Mp3TagStav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.labelNastaveni_Mp3TagStav.Location = new System.Drawing.Point(804, 189);
            this.labelNastaveni_Mp3TagStav.Name = "labelNastaveni_Mp3TagStav";
            this.labelNastaveni_Mp3TagStav.Size = new System.Drawing.Size(278, 22);
            this.labelNastaveni_Mp3TagStav.TabIndex = 28;
            this.labelNastaveni_Mp3TagStav.Text = "stav";
            this.labelNastaveni_Mp3TagStav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNastaveni_AlbumArtStav
            // 
            this.labelNastaveni_AlbumArtStav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNastaveni_AlbumArtStav.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNastaveni_AlbumArtStav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.labelNastaveni_AlbumArtStav.Location = new System.Drawing.Point(804, 218);
            this.labelNastaveni_AlbumArtStav.Name = "labelNastaveni_AlbumArtStav";
            this.labelNastaveni_AlbumArtStav.Size = new System.Drawing.Size(278, 22);
            this.labelNastaveni_AlbumArtStav.TabIndex = 29;
            this.labelNastaveni_AlbumArtStav.Text = "stav";
            this.labelNastaveni_AlbumArtStav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNastaveni_OpusEnkoderStav
            // 
            this.labelNastaveni_OpusEnkoderStav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNastaveni_OpusEnkoderStav.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNastaveni_OpusEnkoderStav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.labelNastaveni_OpusEnkoderStav.Location = new System.Drawing.Point(804, 272);
            this.labelNastaveni_OpusEnkoderStav.Name = "labelNastaveni_OpusEnkoderStav";
            this.labelNastaveni_OpusEnkoderStav.Size = new System.Drawing.Size(278, 22);
            this.labelNastaveni_OpusEnkoderStav.TabIndex = 30;
            this.labelNastaveni_OpusEnkoderStav.Text = "stav";
            this.labelNastaveni_OpusEnkoderStav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPridaniUpravaArchivu_ArchivStav
            // 
            this.labelPridaniUpravaArchivu_ArchivStav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPridaniUpravaArchivu_ArchivStav.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPridaniUpravaArchivu_ArchivStav.Location = new System.Drawing.Point(804, 42);
            this.labelPridaniUpravaArchivu_ArchivStav.Name = "labelPridaniUpravaArchivu_ArchivStav";
            this.labelPridaniUpravaArchivu_ArchivStav.Size = new System.Drawing.Size(278, 21);
            this.labelPridaniUpravaArchivu_ArchivStav.TabIndex = 25;
            this.labelPridaniUpravaArchivu_ArchivStav.Text = "stav";
            this.labelPridaniUpravaArchivu_ArchivStav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNastaveni_SlozkaMp3Stav
            // 
            this.labelNastaveni_SlozkaMp3Stav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNastaveni_SlozkaMp3Stav.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNastaveni_SlozkaMp3Stav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.labelNastaveni_SlozkaMp3Stav.Location = new System.Drawing.Point(804, 71);
            this.labelNastaveni_SlozkaMp3Stav.Name = "labelNastaveni_SlozkaMp3Stav";
            this.labelNastaveni_SlozkaMp3Stav.Size = new System.Drawing.Size(278, 22);
            this.labelNastaveni_SlozkaMp3Stav.TabIndex = 27;
            this.labelNastaveni_SlozkaMp3Stav.Text = "stav";
            this.labelNastaveni_SlozkaMp3Stav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNastaveni_SlozkaOpusStav
            // 
            this.labelNastaveni_SlozkaOpusStav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNastaveni_SlozkaOpusStav.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNastaveni_SlozkaOpusStav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.labelNastaveni_SlozkaOpusStav.Location = new System.Drawing.Point(804, 42);
            this.labelNastaveni_SlozkaOpusStav.Name = "labelNastaveni_SlozkaOpusStav";
            this.labelNastaveni_SlozkaOpusStav.Size = new System.Drawing.Size(278, 22);
            this.labelNastaveni_SlozkaOpusStav.TabIndex = 26;
            this.labelNastaveni_SlozkaOpusStav.Text = "stav";
            this.labelNastaveni_SlozkaOpusStav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxNastaveni_Mp3Tag
            // 
            this.comboBoxNastaveni_Mp3Tag.AllowDrop = true;
            this.comboBoxNastaveni_Mp3Tag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNastaveni_Mp3Tag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.comboBoxNastaveni_Mp3Tag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNastaveni_Mp3Tag.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxNastaveni_Mp3Tag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.comboBoxNastaveni_Mp3Tag.FormattingEnabled = true;
            this.comboBoxNastaveni_Mp3Tag.Location = new System.Drawing.Point(136, 189);
            this.comboBoxNastaveni_Mp3Tag.Name = "comboBoxNastaveni_Mp3Tag";
            this.comboBoxNastaveni_Mp3Tag.Size = new System.Drawing.Size(545, 22);
            this.comboBoxNastaveni_Mp3Tag.TabIndex = 7;
            this.comboBoxNastaveni_Mp3Tag.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxSoubor_DragDrop);
            this.comboBoxNastaveni_Mp3Tag.DragEnter += new System.Windows.Forms.DragEventHandler(this.prvek_DragEnter);
            this.comboBoxNastaveni_Mp3Tag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.comboBoxNastaveni_Mp3Tag.Leave += new System.EventHandler(this.comboBoxNastaveni_Mp3Tag_Leave);
            // 
            // comboBoxNastaveni_AlbumArt
            // 
            this.comboBoxNastaveni_AlbumArt.AllowDrop = true;
            this.comboBoxNastaveni_AlbumArt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNastaveni_AlbumArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.comboBoxNastaveni_AlbumArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNastaveni_AlbumArt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxNastaveni_AlbumArt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.comboBoxNastaveni_AlbumArt.FormattingEnabled = true;
            this.comboBoxNastaveni_AlbumArt.Location = new System.Drawing.Point(136, 218);
            this.comboBoxNastaveni_AlbumArt.Name = "comboBoxNastaveni_AlbumArt";
            this.comboBoxNastaveni_AlbumArt.Size = new System.Drawing.Size(545, 22);
            this.comboBoxNastaveni_AlbumArt.TabIndex = 9;
            this.comboBoxNastaveni_AlbumArt.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxSoubor_DragDrop);
            this.comboBoxNastaveni_AlbumArt.DragEnter += new System.Windows.Forms.DragEventHandler(this.prvek_DragEnter);
            this.comboBoxNastaveni_AlbumArt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.comboBoxNastaveni_AlbumArt.Leave += new System.EventHandler(this.comboBoxNastaveni_AlbumArt_Leave);
            // 
            // comboBoxPridaniUpravaArchivu_Archiv
            // 
            this.comboBoxPridaniUpravaArchivu_Archiv.AllowDrop = true;
            this.comboBoxPridaniUpravaArchivu_Archiv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPridaniUpravaArchivu_Archiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.comboBoxPridaniUpravaArchivu_Archiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPridaniUpravaArchivu_Archiv.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPridaniUpravaArchivu_Archiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.comboBoxPridaniUpravaArchivu_Archiv.FormattingEnabled = true;
            this.comboBoxPridaniUpravaArchivu_Archiv.Location = new System.Drawing.Point(136, 42);
            this.comboBoxPridaniUpravaArchivu_Archiv.Name = "comboBoxPridaniUpravaArchivu_Archiv";
            this.comboBoxPridaniUpravaArchivu_Archiv.Size = new System.Drawing.Size(545, 22);
            this.comboBoxPridaniUpravaArchivu_Archiv.TabIndex = 0;
            this.comboBoxPridaniUpravaArchivu_Archiv.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxSoubor_DragDrop);
            this.comboBoxPridaniUpravaArchivu_Archiv.DragEnter += new System.Windows.Forms.DragEventHandler(this.prvek_DragEnter);
            this.comboBoxPridaniUpravaArchivu_Archiv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.comboBoxPridaniUpravaArchivu_Archiv.Leave += new System.EventHandler(this.comboBoxPridaniUpravaArchivu_Archiv_Leave);
            // 
            // comboBoxNastaveni_SlozkaOpus
            // 
            this.comboBoxNastaveni_SlozkaOpus.AllowDrop = true;
            this.comboBoxNastaveni_SlozkaOpus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNastaveni_SlozkaOpus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.comboBoxNastaveni_SlozkaOpus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxNastaveni_SlozkaOpus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxNastaveni_SlozkaOpus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.comboBoxNastaveni_SlozkaOpus.FormattingEnabled = true;
            this.comboBoxNastaveni_SlozkaOpus.Location = new System.Drawing.Point(136, 42);
            this.comboBoxNastaveni_SlozkaOpus.Name = "comboBoxNastaveni_SlozkaOpus";
            this.comboBoxNastaveni_SlozkaOpus.Size = new System.Drawing.Size(545, 22);
            this.comboBoxNastaveni_SlozkaOpus.TabIndex = 0;
            this.comboBoxNastaveni_SlozkaOpus.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxSlozka_DragDrop);
            this.comboBoxNastaveni_SlozkaOpus.DragEnter += new System.Windows.Forms.DragEventHandler(this.prvek_DragEnter);
            this.comboBoxNastaveni_SlozkaOpus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.comboBoxNastaveni_SlozkaOpus.Leave += new System.EventHandler(this.comboBoxNastaveni_SlozkaOpus_Leave);
            // 
            // comboBoxNastaveni_SlozkaMp3
            // 
            this.comboBoxNastaveni_SlozkaMp3.AllowDrop = true;
            this.comboBoxNastaveni_SlozkaMp3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNastaveni_SlozkaMp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.comboBoxNastaveni_SlozkaMp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNastaveni_SlozkaMp3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxNastaveni_SlozkaMp3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.comboBoxNastaveni_SlozkaMp3.FormattingEnabled = true;
            this.comboBoxNastaveni_SlozkaMp3.Location = new System.Drawing.Point(136, 71);
            this.comboBoxNastaveni_SlozkaMp3.Name = "comboBoxNastaveni_SlozkaMp3";
            this.comboBoxNastaveni_SlozkaMp3.Size = new System.Drawing.Size(545, 22);
            this.comboBoxNastaveni_SlozkaMp3.TabIndex = 2;
            this.comboBoxNastaveni_SlozkaMp3.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxSlozka_DragDrop);
            this.comboBoxNastaveni_SlozkaMp3.DragEnter += new System.Windows.Forms.DragEventHandler(this.prvek_DragEnter);
            this.comboBoxNastaveni_SlozkaMp3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.comboBoxNastaveni_SlozkaMp3.Leave += new System.EventHandler(this.comboBoxNastaveni_SlozkaMp3_Leave);
            // 
            // comboBoxNastaveni_OpusEnkoder
            // 
            this.comboBoxNastaveni_OpusEnkoder.AllowDrop = true;
            this.comboBoxNastaveni_OpusEnkoder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNastaveni_OpusEnkoder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.comboBoxNastaveni_OpusEnkoder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNastaveni_OpusEnkoder.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxNastaveni_OpusEnkoder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.comboBoxNastaveni_OpusEnkoder.FormattingEnabled = true;
            this.comboBoxNastaveni_OpusEnkoder.Location = new System.Drawing.Point(136, 272);
            this.comboBoxNastaveni_OpusEnkoder.Name = "comboBoxNastaveni_OpusEnkoder";
            this.comboBoxNastaveni_OpusEnkoder.Size = new System.Drawing.Size(545, 22);
            this.comboBoxNastaveni_OpusEnkoder.TabIndex = 11;
            this.comboBoxNastaveni_OpusEnkoder.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxSoubor_DragDrop);
            this.comboBoxNastaveni_OpusEnkoder.DragEnter += new System.Windows.Forms.DragEventHandler(this.prvek_DragEnter);
            this.comboBoxNastaveni_OpusEnkoder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.comboBoxNastaveni_OpusEnkoder.Leave += new System.EventHandler(this.comboBoxNastaveni_OpusEnkoder_Leave);
            // 
            // labelNastaveni_SlozkaOpusOtevrit
            // 
            this.labelNastaveni_SlozkaOpusOtevrit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNastaveni_SlozkaOpusOtevrit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.labelNastaveni_SlozkaOpusOtevrit.Location = new System.Drawing.Point(0, 42);
            this.labelNastaveni_SlozkaOpusOtevrit.Name = "labelNastaveni_SlozkaOpusOtevrit";
            this.labelNastaveni_SlozkaOpusOtevrit.Size = new System.Drawing.Size(130, 22);
            this.labelNastaveni_SlozkaOpusOtevrit.TabIndex = 32;
            this.labelNastaveni_SlozkaOpusOtevrit.Text = "Složka opus";
            this.labelNastaveni_SlozkaOpusOtevrit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelNastaveni_SlozkaOpusOtevrit.Click += new System.EventHandler(this.labelNastaveni_SlozkaOpusOtevrit_Click);
            // 
            // labelNastaveni_SlozkaMp3Otevrit
            // 
            this.labelNastaveni_SlozkaMp3Otevrit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNastaveni_SlozkaMp3Otevrit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.labelNastaveni_SlozkaMp3Otevrit.Location = new System.Drawing.Point(0, 71);
            this.labelNastaveni_SlozkaMp3Otevrit.Name = "labelNastaveni_SlozkaMp3Otevrit";
            this.labelNastaveni_SlozkaMp3Otevrit.Size = new System.Drawing.Size(130, 22);
            this.labelNastaveni_SlozkaMp3Otevrit.TabIndex = 33;
            this.labelNastaveni_SlozkaMp3Otevrit.Text = "Složka mp3";
            this.labelNastaveni_SlozkaMp3Otevrit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelNastaveni_SlozkaMp3Otevrit.Click += new System.EventHandler(this.labelNastaveni_SlozkaMp3Otevrit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "Interpret";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(0, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mp3";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(0, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 36;
            this.label7.Text = "Album";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(350, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 22);
            this.label9.TabIndex = 41;
            this.label9.Text = "Rok";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(350, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 22);
            this.label10.TabIndex = 42;
            this.label10.Text = "Žánr";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.label11.Location = new System.Drawing.Point(0, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 22);
            this.label11.TabIndex = 37;
            this.label11.Text = "Mp3tag";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.label12.Location = new System.Drawing.Point(0, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 22);
            this.label12.TabIndex = 38;
            this.label12.Text = "AlbumArtDownloader";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.label13.Location = new System.Drawing.Point(0, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 22);
            this.label13.TabIndex = 39;
            this.label13.Text = "Opus Enkoder";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownPridaniUpravaArchivu_Rok
            // 
            this.numericUpDownPridaniUpravaArchivu_Rok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.numericUpDownPridaniUpravaArchivu_Rok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownPridaniUpravaArchivu_Rok.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownPridaniUpravaArchivu_Rok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.numericUpDownPridaniUpravaArchivu_Rok.Location = new System.Drawing.Point(494, 160);
            this.numericUpDownPridaniUpravaArchivu_Rok.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownPridaniUpravaArchivu_Rok.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownPridaniUpravaArchivu_Rok.Name = "numericUpDownPridaniUpravaArchivu_Rok";
            this.numericUpDownPridaniUpravaArchivu_Rok.Size = new System.Drawing.Size(187, 22);
            this.numericUpDownPridaniUpravaArchivu_Rok.TabIndex = 9;
            this.numericUpDownPridaniUpravaArchivu_Rok.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownPridaniUpravaArchivu_Rok.Leave += new System.EventHandler(this.numericUpDownPridaniUpravaArchivu_Rok_Leave);
            // 
            // checkBoxPridaniUpravaArchivu_ZanrMenit
            // 
            this.checkBoxPridaniUpravaArchivu_ZanrMenit.Checked = true;
            this.checkBoxPridaniUpravaArchivu_ZanrMenit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPridaniUpravaArchivu_ZanrMenit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPridaniUpravaArchivu_ZanrMenit.Location = new System.Drawing.Point(368, 97);
            this.checkBoxPridaniUpravaArchivu_ZanrMenit.Name = "checkBoxPridaniUpravaArchivu_ZanrMenit";
            this.checkBoxPridaniUpravaArchivu_ZanrMenit.Size = new System.Drawing.Size(153, 22);
            this.checkBoxPridaniUpravaArchivu_ZanrMenit.TabIndex = 44;
            this.checkBoxPridaniUpravaArchivu_ZanrMenit.Text = "Automaticky měnit žánr";
            this.checkBoxPridaniUpravaArchivu_ZanrMenit.UseVisualStyleBackColor = true;
            this.checkBoxPridaniUpravaArchivu_ZanrMenit.CheckedChanged += new System.EventHandler(this.checkBoxPridaniUpravaArchivu_ZanrMenit_CheckedChanged);
            // 
            // labelPridaniUpravaArchivu_SlozkaOpusCestaStav
            // 
            this.labelPridaniUpravaArchivu_SlozkaOpusCestaStav.AccessibleDescription = "";
            this.labelPridaniUpravaArchivu_SlozkaOpusCestaStav.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPridaniUpravaArchivu_SlozkaOpusCestaStav.Location = new System.Drawing.Point(133, 273);
            this.labelPridaniUpravaArchivu_SlozkaOpusCestaStav.Name = "labelPridaniUpravaArchivu_SlozkaOpusCestaStav";
            this.labelPridaniUpravaArchivu_SlozkaOpusCestaStav.Size = new System.Drawing.Size(387, 22);
            this.labelPridaniUpravaArchivu_SlozkaOpusCestaStav.TabIndex = 45;
            this.labelPridaniUpravaArchivu_SlozkaOpusCestaStav.Text = "složka opus";
            this.labelPridaniUpravaArchivu_SlozkaOpusCestaStav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPridaniUpravaArchivu_SlozkaOpusCestaStav.UseMnemonic = false;
            this.labelPridaniUpravaArchivu_SlozkaOpusCestaStav.Click += new System.EventHandler(this.labelPridaniUpravaArchivu_SlozkaOpusCesta_Click);
            // 
            // labelPridaniUpravaArchivu_SlozkaMp3CestaStav
            // 
            this.labelPridaniUpravaArchivu_SlozkaMp3CestaStav.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPridaniUpravaArchivu_SlozkaMp3CestaStav.Location = new System.Drawing.Point(133, 323);
            this.labelPridaniUpravaArchivu_SlozkaMp3CestaStav.Name = "labelPridaniUpravaArchivu_SlozkaMp3CestaStav";
            this.labelPridaniUpravaArchivu_SlozkaMp3CestaStav.Size = new System.Drawing.Size(387, 22);
            this.labelPridaniUpravaArchivu_SlozkaMp3CestaStav.TabIndex = 46;
            this.labelPridaniUpravaArchivu_SlozkaMp3CestaStav.Text = "složka mp3";
            this.labelPridaniUpravaArchivu_SlozkaMp3CestaStav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPridaniUpravaArchivu_SlozkaMp3CestaStav.UseMnemonic = false;
            this.labelPridaniUpravaArchivu_SlozkaMp3CestaStav.Click += new System.EventHandler(this.labelPridaniUpravaArchivu_SlozkaMp3Cesta_Click);
            // 
            // pictureBoxPridaniUpravaArchivu_Cover
            // 
            this.pictureBoxPridaniUpravaArchivu_Cover.Location = new System.Drawing.Point(139, 387);
            this.pictureBoxPridaniUpravaArchivu_Cover.Name = "pictureBoxPridaniUpravaArchivu_Cover";
            this.pictureBoxPridaniUpravaArchivu_Cover.Size = new System.Drawing.Size(233, 233);
            this.pictureBoxPridaniUpravaArchivu_Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPridaniUpravaArchivu_Cover.TabIndex = 47;
            this.pictureBoxPridaniUpravaArchivu_Cover.TabStop = false;
            this.pictureBoxPridaniUpravaArchivu_Cover.Click += new System.EventHandler(this.pictureBoxPridaniUpravaArchivu_Cover_Click);
            // 
            // buttonPridaniUpravaArchivu_CoverVybrat
            // 
            this.buttonPridaniUpravaArchivu_CoverVybrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonPridaniUpravaArchivu_CoverVybrat.FlatAppearance.BorderSize = 0;
            this.buttonPridaniUpravaArchivu_CoverVybrat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonPridaniUpravaArchivu_CoverVybrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonPridaniUpravaArchivu_CoverVybrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPridaniUpravaArchivu_CoverVybrat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPridaniUpravaArchivu_CoverVybrat.Location = new System.Drawing.Point(7, 416);
            this.buttonPridaniUpravaArchivu_CoverVybrat.Name = "buttonPridaniUpravaArchivu_CoverVybrat";
            this.buttonPridaniUpravaArchivu_CoverVybrat.Size = new System.Drawing.Size(125, 22);
            this.buttonPridaniUpravaArchivu_CoverVybrat.TabIndex = 48;
            this.buttonPridaniUpravaArchivu_CoverVybrat.Text = "Vybrat vlastní cover";
            this.buttonPridaniUpravaArchivu_CoverVybrat.UseVisualStyleBackColor = false;
            this.buttonPridaniUpravaArchivu_CoverVybrat.Click += new System.EventHandler(this.buttonPridaniUpravaArchivu_CoverVybrat_Click);
            // 
            // checkBoxPridaniUpravaArchivu_PrepsatSoubory
            // 
            this.checkBoxPridaniUpravaArchivu_PrepsatSoubory.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPridaniUpravaArchivu_PrepsatSoubory.Location = new System.Drawing.Point(527, 97);
            this.checkBoxPridaniUpravaArchivu_PrepsatSoubory.Name = "checkBoxPridaniUpravaArchivu_PrepsatSoubory";
            this.checkBoxPridaniUpravaArchivu_PrepsatSoubory.Size = new System.Drawing.Size(160, 22);
            this.checkBoxPridaniUpravaArchivu_PrepsatSoubory.TabIndex = 50;
            this.checkBoxPridaniUpravaArchivu_PrepsatSoubory.Text = "Přepsat stávající soubory";
            this.checkBoxPridaniUpravaArchivu_PrepsatSoubory.UseVisualStyleBackColor = true;
            // 
            // buttonZobrazeniArchivu_SpustitVse
            // 
            this.buttonZobrazeniArchivu_SpustitVse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZobrazeniArchivu_SpustitVse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonZobrazeniArchivu_SpustitVse.FlatAppearance.BorderSize = 0;
            this.buttonZobrazeniArchivu_SpustitVse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonZobrazeniArchivu_SpustitVse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonZobrazeniArchivu_SpustitVse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZobrazeniArchivu_SpustitVse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonZobrazeniArchivu_SpustitVse.Location = new System.Drawing.Point(847, 536);
            this.buttonZobrazeniArchivu_SpustitVse.Name = "buttonZobrazeniArchivu_SpustitVse";
            this.buttonZobrazeniArchivu_SpustitVse.Size = new System.Drawing.Size(139, 23);
            this.buttonZobrazeniArchivu_SpustitVse.TabIndex = 51;
            this.buttonZobrazeniArchivu_SpustitVse.Text = "Spustit vše";
            this.buttonZobrazeniArchivu_SpustitVse.UseVisualStyleBackColor = false;
            // 
            // labelPridaniUpravaArchivu_SlozkaOpusCesta
            // 
            this.labelPridaniUpravaArchivu_SlozkaOpusCesta.AccessibleDescription = "";
            this.labelPridaniUpravaArchivu_SlozkaOpusCesta.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPridaniUpravaArchivu_SlozkaOpusCesta.Location = new System.Drawing.Point(133, 248);
            this.labelPridaniUpravaArchivu_SlozkaOpusCesta.Name = "labelPridaniUpravaArchivu_SlozkaOpusCesta";
            this.labelPridaniUpravaArchivu_SlozkaOpusCesta.Size = new System.Drawing.Size(952, 22);
            this.labelPridaniUpravaArchivu_SlozkaOpusCesta.TabIndex = 45;
            this.labelPridaniUpravaArchivu_SlozkaOpusCesta.Text = "složka opus";
            this.labelPridaniUpravaArchivu_SlozkaOpusCesta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPridaniUpravaArchivu_SlozkaOpusCesta.UseMnemonic = false;
            this.labelPridaniUpravaArchivu_SlozkaOpusCesta.Click += new System.EventHandler(this.labelPridaniUpravaArchivu_SlozkaOpusCesta_Click);
            // 
            // labelPridaniUpravaArchivu_SlozkaMp3Cesta
            // 
            this.labelPridaniUpravaArchivu_SlozkaMp3Cesta.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPridaniUpravaArchivu_SlozkaMp3Cesta.Location = new System.Drawing.Point(133, 298);
            this.labelPridaniUpravaArchivu_SlozkaMp3Cesta.Name = "labelPridaniUpravaArchivu_SlozkaMp3Cesta";
            this.labelPridaniUpravaArchivu_SlozkaMp3Cesta.Size = new System.Drawing.Size(952, 22);
            this.labelPridaniUpravaArchivu_SlozkaMp3Cesta.TabIndex = 46;
            this.labelPridaniUpravaArchivu_SlozkaMp3Cesta.Text = "složka mp3";
            this.labelPridaniUpravaArchivu_SlozkaMp3Cesta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPridaniUpravaArchivu_SlozkaMp3Cesta.UseMnemonic = false;
            this.labelPridaniUpravaArchivu_SlozkaMp3Cesta.Click += new System.EventHandler(this.labelPridaniUpravaArchivu_SlozkaMp3Cesta_Click);
            // 
            // buttonPridaniUpravaArchivu_CoverSmazat
            // 
            this.buttonPridaniUpravaArchivu_CoverSmazat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonPridaniUpravaArchivu_CoverSmazat.FlatAppearance.BorderSize = 0;
            this.buttonPridaniUpravaArchivu_CoverSmazat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonPridaniUpravaArchivu_CoverSmazat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonPridaniUpravaArchivu_CoverSmazat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPridaniUpravaArchivu_CoverSmazat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPridaniUpravaArchivu_CoverSmazat.Location = new System.Drawing.Point(7, 445);
            this.buttonPridaniUpravaArchivu_CoverSmazat.Name = "buttonPridaniUpravaArchivu_CoverSmazat";
            this.buttonPridaniUpravaArchivu_CoverSmazat.Size = new System.Drawing.Size(125, 22);
            this.buttonPridaniUpravaArchivu_CoverSmazat.TabIndex = 52;
            this.buttonPridaniUpravaArchivu_CoverSmazat.Text = "Smazat cover";
            this.buttonPridaniUpravaArchivu_CoverSmazat.UseVisualStyleBackColor = false;
            this.buttonPridaniUpravaArchivu_CoverSmazat.Click += new System.EventHandler(this.buttonPridaniUpravaArchivu_CoverSmazat_Click);
            // 
            // panelPridaniUpravaArchivu
            // 
            this.panelPridaniUpravaArchivu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPridaniUpravaArchivu.Controls.Add(this.label5);
            this.panelPridaniUpravaArchivu.Controls.Add(this.label18);
            this.panelPridaniUpravaArchivu.Controls.Add(this.label17);
            this.panelPridaniUpravaArchivu.Controls.Add(this.label15);
            this.panelPridaniUpravaArchivu.Controls.Add(this.labelPridaniUpravaArchivu_ArchivStav);
            this.panelPridaniUpravaArchivu.Controls.Add(this.buttonPridaniUpravaArchivu_Nasledujici);
            this.panelPridaniUpravaArchivu.Controls.Add(this.buttonPridaniUpravaArchivu_PridatPredchozi);
            this.panelPridaniUpravaArchivu.Controls.Add(this.buttonPridaniUpravaArchivu_CoverSmazat);
            this.panelPridaniUpravaArchivu.Controls.Add(this.buttonPridaniUpravaArchivu_ArchivVybrat);
            this.panelPridaniUpravaArchivu.Controls.Add(this.comboBoxPridaniUpravaArchivu_SlozkaStat);
            this.panelPridaniUpravaArchivu.Controls.Add(this.label3);
            this.panelPridaniUpravaArchivu.Controls.Add(this.label2);
            this.panelPridaniUpravaArchivu.Controls.Add(this.checkBoxPridaniUpravaArchivu_PrepsatSoubory);
            this.panelPridaniUpravaArchivu.Controls.Add(this.numericUpDownPridaniUpravaArchivu_Rok);
            this.panelPridaniUpravaArchivu.Controls.Add(this.buttonPridaniUpravaArchivu_CoverVybrat);
            this.panelPridaniUpravaArchivu.Controls.Add(this.label10);
            this.panelPridaniUpravaArchivu.Controls.Add(this.checkBoxPridaniUpravaArchivu_ArchivHesloZobrazit);
            this.panelPridaniUpravaArchivu.Controls.Add(this.checkBoxPridaniUpravaArchivu_UkladatAutomaticky);
            this.panelPridaniUpravaArchivu.Controls.Add(this.checkBoxPridaniUpravaArchivu_ZanrMenit);
            this.panelPridaniUpravaArchivu.Controls.Add(this.pictureBoxPridaniUpravaArchivu_Cover);
            this.panelPridaniUpravaArchivu.Controls.Add(this.label9);
            this.panelPridaniUpravaArchivu.Controls.Add(this.comboBoxPridaniUpravaArchivu_SlozkaZanr);
            this.panelPridaniUpravaArchivu.Controls.Add(this.labelPridaniUpravaArchivu_SlozkaOpusCestaStav);
            this.panelPridaniUpravaArchivu.Controls.Add(this.textBoxPridaniUpravaArchivu_ArchivHeslo);
            this.panelPridaniUpravaArchivu.Controls.Add(this.textBoxPridaniUpravaArchivu_Interpret);
            this.panelPridaniUpravaArchivu.Controls.Add(this.label7);
            this.panelPridaniUpravaArchivu.Controls.Add(this.textBoxPridaniUpravaArchivu_Album);
            this.panelPridaniUpravaArchivu.Controls.Add(this.labelPridaniUpravaArchivu_SlozkaOpusCesta);
            this.panelPridaniUpravaArchivu.Controls.Add(this.label25);
            this.panelPridaniUpravaArchivu.Controls.Add(this.label20);
            this.panelPridaniUpravaArchivu.Controls.Add(this.label8);
            this.panelPridaniUpravaArchivu.Controls.Add(this.label1);
            this.panelPridaniUpravaArchivu.Controls.Add(this.textBoxPridaniUpravaArchivu_Zanr);
            this.panelPridaniUpravaArchivu.Controls.Add(this.labelPridaniUpravaArchivu_SlozkaMp3CestaStav);
            this.panelPridaniUpravaArchivu.Controls.Add(this.buttonPridaniUpravaArchivu_CoverZiskat);
            this.panelPridaniUpravaArchivu.Controls.Add(this.labelPridaniUpravaArchivu_SlozkaMp3Cesta);
            this.panelPridaniUpravaArchivu.Controls.Add(this.labelPridaniUpravaArchivu_CoverInfo);
            this.panelPridaniUpravaArchivu.Controls.Add(this.comboBoxPridaniUpravaArchivu_Archiv);
            this.panelPridaniUpravaArchivu.Controls.Add(this.textBoxPridaniUpravaArchivu_Archiv);
            this.panelPridaniUpravaArchivu.Controls.Add(this.label16);
            this.panelPridaniUpravaArchivu.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelPridaniUpravaArchivu.Location = new System.Drawing.Point(0, 26);
            this.panelPridaniUpravaArchivu.Name = "panelPridaniUpravaArchivu";
            this.panelPridaniUpravaArchivu.Size = new System.Drawing.Size(1083, 625);
            this.panelPridaniUpravaArchivu.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(685, 379);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(25, 246);
            this.label5.TabIndex = 53;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label18.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(0, 214);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label18.Size = new System.Drawing.Size(1085, 25);
            this.label18.TabIndex = 41;
            this.label18.Text = "SLOŽKY";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label17.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(-3, 126);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label17.Size = new System.Drawing.Size(1085, 25);
            this.label17.TabIndex = 41;
            this.label17.Text = "INFORMACE O ALBU";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label15.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(0, 354);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label15.Size = new System.Drawing.Size(1085, 25);
            this.label15.TabIndex = 41;
            this.label15.Text = "COVER";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonPridaniUpravaArchivu_Nasledujici
            // 
            this.buttonPridaniUpravaArchivu_Nasledujici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonPridaniUpravaArchivu_Nasledujici.FlatAppearance.BorderSize = 0;
            this.buttonPridaniUpravaArchivu_Nasledujici.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonPridaniUpravaArchivu_Nasledujici.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonPridaniUpravaArchivu_Nasledujici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPridaniUpravaArchivu_Nasledujici.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPridaniUpravaArchivu_Nasledujici.Location = new System.Drawing.Point(720, 445);
            this.buttonPridaniUpravaArchivu_Nasledujici.Name = "buttonPridaniUpravaArchivu_Nasledujici";
            this.buttonPridaniUpravaArchivu_Nasledujici.Size = new System.Drawing.Size(125, 22);
            this.buttonPridaniUpravaArchivu_Nasledujici.TabIndex = 52;
            this.buttonPridaniUpravaArchivu_Nasledujici.Text = "Následující";
            this.buttonPridaniUpravaArchivu_Nasledujici.UseVisualStyleBackColor = false;
            this.buttonPridaniUpravaArchivu_Nasledujici.Click += new System.EventHandler(this.buttonPridaniUpravaArchivu_Nasledujici_Click);
            // 
            // buttonPridaniUpravaArchivu_PridatPredchozi
            // 
            this.buttonPridaniUpravaArchivu_PridatPredchozi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonPridaniUpravaArchivu_PridatPredchozi.FlatAppearance.BorderSize = 0;
            this.buttonPridaniUpravaArchivu_PridatPredchozi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonPridaniUpravaArchivu_PridatPredchozi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonPridaniUpravaArchivu_PridatPredchozi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPridaniUpravaArchivu_PridatPredchozi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPridaniUpravaArchivu_PridatPredchozi.Location = new System.Drawing.Point(720, 416);
            this.buttonPridaniUpravaArchivu_PridatPredchozi.Name = "buttonPridaniUpravaArchivu_PridatPredchozi";
            this.buttonPridaniUpravaArchivu_PridatPredchozi.Size = new System.Drawing.Size(125, 22);
            this.buttonPridaniUpravaArchivu_PridatPredchozi.TabIndex = 52;
            this.buttonPridaniUpravaArchivu_PridatPredchozi.Text = "Přidat / předchozí";
            this.buttonPridaniUpravaArchivu_PridatPredchozi.UseVisualStyleBackColor = false;
            this.buttonPridaniUpravaArchivu_PridatPredchozi.Click += new System.EventHandler(this.buttonPridaniUpravaArchivu_PridatPredchozi_Click);
            // 
            // checkBoxPridaniUpravaArchivu_ArchivHesloZobrazit
            // 
            this.checkBoxPridaniUpravaArchivu_ArchivHesloZobrazit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPridaniUpravaArchivu_ArchivHesloZobrazit.Location = new System.Drawing.Point(368, 69);
            this.checkBoxPridaniUpravaArchivu_ArchivHesloZobrazit.Name = "checkBoxPridaniUpravaArchivu_ArchivHesloZobrazit";
            this.checkBoxPridaniUpravaArchivu_ArchivHesloZobrazit.Size = new System.Drawing.Size(153, 22);
            this.checkBoxPridaniUpravaArchivu_ArchivHesloZobrazit.TabIndex = 44;
            this.checkBoxPridaniUpravaArchivu_ArchivHesloZobrazit.Text = "Zobrazit heslo";
            this.checkBoxPridaniUpravaArchivu_ArchivHesloZobrazit.UseVisualStyleBackColor = true;
            this.checkBoxPridaniUpravaArchivu_ArchivHesloZobrazit.CheckedChanged += new System.EventHandler(this.checkBoxPridaniUpravaArchivu_ArchivHesloZobrazit_CheckedChanged);
            // 
            // checkBoxPridaniUpravaArchivu_UkladatAutomaticky
            // 
            this.checkBoxPridaniUpravaArchivu_UkladatAutomaticky.Checked = true;
            this.checkBoxPridaniUpravaArchivu_UkladatAutomaticky.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPridaniUpravaArchivu_UkladatAutomaticky.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPridaniUpravaArchivu_UkladatAutomaticky.Location = new System.Drawing.Point(721, 387);
            this.checkBoxPridaniUpravaArchivu_UkladatAutomaticky.Name = "checkBoxPridaniUpravaArchivu_UkladatAutomaticky";
            this.checkBoxPridaniUpravaArchivu_UkladatAutomaticky.Size = new System.Drawing.Size(138, 22);
            this.checkBoxPridaniUpravaArchivu_UkladatAutomaticky.TabIndex = 44;
            this.checkBoxPridaniUpravaArchivu_UkladatAutomaticky.Text = "Ukládat automaticky";
            this.checkBoxPridaniUpravaArchivu_UkladatAutomaticky.UseVisualStyleBackColor = true;
            // 
            // textBoxPridaniUpravaArchivu_ArchivHeslo
            // 
            this.textBoxPridaniUpravaArchivu_ArchivHeslo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBoxPridaniUpravaArchivu_ArchivHeslo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPridaniUpravaArchivu_ArchivHeslo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.textBoxPridaniUpravaArchivu_ArchivHeslo.Location = new System.Drawing.Point(136, 69);
            this.textBoxPridaniUpravaArchivu_ArchivHeslo.Name = "textBoxPridaniUpravaArchivu_ArchivHeslo";
            this.textBoxPridaniUpravaArchivu_ArchivHeslo.PasswordChar = '*';
            this.textBoxPridaniUpravaArchivu_ArchivHeslo.Size = new System.Drawing.Size(226, 22);
            this.textBoxPridaniUpravaArchivu_ArchivHeslo.TabIndex = 8;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(4, 96);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(130, 22);
            this.label25.TabIndex = 35;
            this.label25.Text = "Upřesnění složek";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(3, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(130, 22);
            this.label20.TabIndex = 35;
            this.label20.Text = "Heslo archivu";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(2, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 22);
            this.label8.TabIndex = 35;
            this.label8.Text = "Cesta archivu";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPridaniUpravaArchivu_CoverInfo
            // 
            this.labelPridaniUpravaArchivu_CoverInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPridaniUpravaArchivu_CoverInfo.Location = new System.Drawing.Point(378, 387);
            this.labelPridaniUpravaArchivu_CoverInfo.Name = "labelPridaniUpravaArchivu_CoverInfo";
            this.labelPridaniUpravaArchivu_CoverInfo.Size = new System.Drawing.Size(303, 233);
            this.labelPridaniUpravaArchivu_CoverInfo.TabIndex = 34;
            this.labelPridaniUpravaArchivu_CoverInfo.Text = "obrázek info";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label16.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(0, 10);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label16.Size = new System.Drawing.Size(1085, 25);
            this.label16.TabIndex = 41;
            this.label16.Text = "ARCHIV A SLOŽKY";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPridaniUpravaArchivu_Archiv
            // 
            this.textBoxPridaniUpravaArchivu_Archiv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPridaniUpravaArchivu_Archiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBoxPridaniUpravaArchivu_Archiv.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPridaniUpravaArchivu_Archiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.textBoxPridaniUpravaArchivu_Archiv.Location = new System.Drawing.Point(135, 42);
            this.textBoxPridaniUpravaArchivu_Archiv.Name = "textBoxPridaniUpravaArchivu_Archiv";
            this.textBoxPridaniUpravaArchivu_Archiv.ReadOnly = true;
            this.textBoxPridaniUpravaArchivu_Archiv.Size = new System.Drawing.Size(546, 22);
            this.textBoxPridaniUpravaArchivu_Archiv.TabIndex = 11;
            this.textBoxPridaniUpravaArchivu_Archiv.Leave += new System.EventHandler(this.textBoxPridaniUpravaArchivu_Zanr_Leave);
            // 
            // panelNastaveni
            // 
            this.panelNastaveni.AllowDrop = true;
            this.panelNastaveni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNastaveni.Controls.Add(this.labelNastaveni_SlozkaOpusOtevrit);
            this.panelNastaveni.Controls.Add(this.textBoxNastaveni_RozbaleniParametry);
            this.panelNastaveni.Controls.Add(this.textBoxNastaveni_AlbumArtParametry);
            this.panelNastaveni.Controls.Add(this.checkBoxNastaveni_ZobrazovatPodrobnostiStavu);
            this.panelNastaveni.Controls.Add(this.textBoxNastaveni_Mp3EnkoderParametry);
            this.panelNastaveni.Controls.Add(this.textBoxNastaveni_OpusEnkoderParametry);
            this.panelNastaveni.Controls.Add(this.label14);
            this.panelNastaveni.Controls.Add(this.buttonNastaveni_SlozkaOpusVybrat);
            this.panelNastaveni.Controls.Add(this.labelNastaveni_SlozkaOpusStav);
            this.panelNastaveni.Controls.Add(this.labelNastaveni_SlozkaMp3Otevrit);
            this.panelNastaveni.Controls.Add(this.comboBoxNastaveni_SlozkaOpus);
            this.panelNastaveni.Controls.Add(this.label11);
            this.panelNastaveni.Controls.Add(this.labelNastaveni_SlozkaMp3Stav);
            this.panelNastaveni.Controls.Add(this.label12);
            this.panelNastaveni.Controls.Add(this.comboBoxNastaveni_SlozkaMp3);
            this.panelNastaveni.Controls.Add(this.label6);
            this.panelNastaveni.Controls.Add(this.label24);
            this.panelNastaveni.Controls.Add(this.label22);
            this.panelNastaveni.Controls.Add(this.label19);
            this.panelNastaveni.Controls.Add(this.label23);
            this.panelNastaveni.Controls.Add(this.label21);
            this.panelNastaveni.Controls.Add(this.label13);
            this.panelNastaveni.Controls.Add(this.labelNastaveni_RozbaleniStav);
            this.panelNastaveni.Controls.Add(this.labelNastaveni_Mp3EnkoderStav);
            this.panelNastaveni.Controls.Add(this.labelNastaveni_OpusEnkoderStav);
            this.panelNastaveni.Controls.Add(this.buttonNastaveni_Mp3TagVybrat);
            this.panelNastaveni.Controls.Add(this.buttonNastaveni_AlbumArtVybrat);
            this.panelNastaveni.Controls.Add(this.buttonNastaveni_RozbaleniVybrat);
            this.panelNastaveni.Controls.Add(this.buttonNastaveni_Mp3EnkoderVybrat);
            this.panelNastaveni.Controls.Add(this.buttonNastaveni_OpusEnkoderVybrat);
            this.panelNastaveni.Controls.Add(this.labelNastaveni_Mp3TagStav);
            this.panelNastaveni.Controls.Add(this.buttonNastaveni_SlozkaMp3Vybrat);
            this.panelNastaveni.Controls.Add(this.label4);
            this.panelNastaveni.Controls.Add(this.labelNastaveni_AlbumArtStav);
            this.panelNastaveni.Controls.Add(this.comboBoxNastaveni_Mp3Tag);
            this.panelNastaveni.Controls.Add(this.comboBoxNastaveni_AlbumArt);
            this.panelNastaveni.Controls.Add(this.comboBoxNastaveni_Rozbaleni);
            this.panelNastaveni.Controls.Add(this.comboBoxNastaveni_Mp3Enkoder);
            this.panelNastaveni.Controls.Add(this.comboBoxNastaveni_OpusEnkoder);
            this.panelNastaveni.Location = new System.Drawing.Point(0, 26);
            this.panelNastaveni.Name = "panelNastaveni";
            this.panelNastaveni.Size = new System.Drawing.Size(1083, 625);
            this.panelNastaveni.TabIndex = 53;
            this.panelNastaveni.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxSoubor_DragDrop);
            this.panelNastaveni.DragEnter += new System.Windows.Forms.DragEventHandler(this.prvek_DragEnter);
            // 
            // textBoxNastaveni_RozbaleniParametry
            // 
            this.textBoxNastaveni_RozbaleniParametry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNastaveni_RozbaleniParametry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBoxNastaveni_RozbaleniParametry.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNastaveni_RozbaleniParametry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.textBoxNastaveni_RozbaleniParametry.Location = new System.Drawing.Point(137, 163);
            this.textBoxNastaveni_RozbaleniParametry.Name = "textBoxNastaveni_RozbaleniParametry";
            this.textBoxNastaveni_RozbaleniParametry.Size = new System.Drawing.Size(545, 22);
            this.textBoxNastaveni_RozbaleniParametry.TabIndex = 6;
            this.textBoxNastaveni_RozbaleniParametry.Leave += new System.EventHandler(this.textBoxNastaveni_RozbaleniParametry_Leave);
            // 
            // textBoxNastaveni_AlbumArtParametry
            // 
            this.textBoxNastaveni_AlbumArtParametry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNastaveni_AlbumArtParametry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBoxNastaveni_AlbumArtParametry.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNastaveni_AlbumArtParametry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.textBoxNastaveni_AlbumArtParametry.Location = new System.Drawing.Point(137, 246);
            this.textBoxNastaveni_AlbumArtParametry.Name = "textBoxNastaveni_AlbumArtParametry";
            this.textBoxNastaveni_AlbumArtParametry.Size = new System.Drawing.Size(545, 22);
            this.textBoxNastaveni_AlbumArtParametry.TabIndex = 16;
            this.textBoxNastaveni_AlbumArtParametry.Leave += new System.EventHandler(this.textBoxNastaveni_AlbumArtParametry_Leave);
            // 
            // checkBoxNastaveni_ZobrazovatPodrobnostiStavu
            // 
            this.checkBoxNastaveni_ZobrazovatPodrobnostiStavu.Checked = true;
            this.checkBoxNastaveni_ZobrazovatPodrobnostiStavu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNastaveni_ZobrazovatPodrobnostiStavu.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxNastaveni_ZobrazovatPodrobnostiStavu.Location = new System.Drawing.Point(135, 388);
            this.checkBoxNastaveni_ZobrazovatPodrobnostiStavu.Name = "checkBoxNastaveni_ZobrazovatPodrobnostiStavu";
            this.checkBoxNastaveni_ZobrazovatPodrobnostiStavu.Size = new System.Drawing.Size(220, 22);
            this.checkBoxNastaveni_ZobrazovatPodrobnostiStavu.TabIndex = 44;
            this.checkBoxNastaveni_ZobrazovatPodrobnostiStavu.Text = "Zobrazovat pouze úspěšné operace\r\n";
            this.checkBoxNastaveni_ZobrazovatPodrobnostiStavu.UseVisualStyleBackColor = true;
            // 
            // textBoxNastaveni_Mp3EnkoderParametry
            // 
            this.textBoxNastaveni_Mp3EnkoderParametry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNastaveni_Mp3EnkoderParametry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBoxNastaveni_Mp3EnkoderParametry.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNastaveni_Mp3EnkoderParametry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.textBoxNastaveni_Mp3EnkoderParametry.Location = new System.Drawing.Point(136, 356);
            this.textBoxNastaveni_Mp3EnkoderParametry.Name = "textBoxNastaveni_Mp3EnkoderParametry";
            this.textBoxNastaveni_Mp3EnkoderParametry.Size = new System.Drawing.Size(545, 22);
            this.textBoxNastaveni_Mp3EnkoderParametry.TabIndex = 16;
            this.textBoxNastaveni_Mp3EnkoderParametry.Leave += new System.EventHandler(this.textBoxNastaveni_Mp3EnkoderParametry_Leave);
            // 
            // textBoxNastaveni_OpusEnkoderParametry
            // 
            this.textBoxNastaveni_OpusEnkoderParametry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNastaveni_OpusEnkoderParametry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBoxNastaveni_OpusEnkoderParametry.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNastaveni_OpusEnkoderParametry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.textBoxNastaveni_OpusEnkoderParametry.Location = new System.Drawing.Point(136, 300);
            this.textBoxNastaveni_OpusEnkoderParametry.Name = "textBoxNastaveni_OpusEnkoderParametry";
            this.textBoxNastaveni_OpusEnkoderParametry.Size = new System.Drawing.Size(545, 22);
            this.textBoxNastaveni_OpusEnkoderParametry.TabIndex = 13;
            this.textBoxNastaveni_OpusEnkoderParametry.Leave += new System.EventHandler(this.textBoxNastaveni_OpusEnkoderParametry_Leave);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label14.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(0, 100);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label14.Size = new System.Drawing.Size(1085, 25);
            this.label14.TabIndex = 40;
            this.label14.Text = "PROGRAMY";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.label6.Location = new System.Drawing.Point(1, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "Parametry AlbumArt";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.label24.Location = new System.Drawing.Point(1, 163);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(130, 22);
            this.label24.TabIndex = 39;
            this.label24.Text = "Parametry rozbalení";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.label22.Location = new System.Drawing.Point(0, 356);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(130, 22);
            this.label22.TabIndex = 39;
            this.label22.Text = "Parametry mp3";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.label19.Location = new System.Drawing.Point(0, 300);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 22);
            this.label19.TabIndex = 39;
            this.label19.Text = "Parametry opus";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.label23.Location = new System.Drawing.Point(1, 135);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(130, 22);
            this.label23.TabIndex = 39;
            this.label23.Text = "Rozbalení souborů";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.label21.Location = new System.Drawing.Point(0, 328);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(130, 22);
            this.label21.TabIndex = 39;
            this.label21.Text = "Mp3 Enkoder";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNastaveni_RozbaleniStav
            // 
            this.labelNastaveni_RozbaleniStav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNastaveni_RozbaleniStav.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNastaveni_RozbaleniStav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.labelNastaveni_RozbaleniStav.Location = new System.Drawing.Point(805, 135);
            this.labelNastaveni_RozbaleniStav.Name = "labelNastaveni_RozbaleniStav";
            this.labelNastaveni_RozbaleniStav.Size = new System.Drawing.Size(278, 22);
            this.labelNastaveni_RozbaleniStav.TabIndex = 30;
            this.labelNastaveni_RozbaleniStav.Text = "stav";
            this.labelNastaveni_RozbaleniStav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNastaveni_Mp3EnkoderStav
            // 
            this.labelNastaveni_Mp3EnkoderStav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNastaveni_Mp3EnkoderStav.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNastaveni_Mp3EnkoderStav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.labelNastaveni_Mp3EnkoderStav.Location = new System.Drawing.Point(804, 328);
            this.labelNastaveni_Mp3EnkoderStav.Name = "labelNastaveni_Mp3EnkoderStav";
            this.labelNastaveni_Mp3EnkoderStav.Size = new System.Drawing.Size(278, 22);
            this.labelNastaveni_Mp3EnkoderStav.TabIndex = 30;
            this.labelNastaveni_Mp3EnkoderStav.Text = "stav";
            this.labelNastaveni_Mp3EnkoderStav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonNastaveni_RozbaleniVybrat
            // 
            this.buttonNastaveni_RozbaleniVybrat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNastaveni_RozbaleniVybrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonNastaveni_RozbaleniVybrat.FlatAppearance.BorderSize = 0;
            this.buttonNastaveni_RozbaleniVybrat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonNastaveni_RozbaleniVybrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonNastaveni_RozbaleniVybrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNastaveni_RozbaleniVybrat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNastaveni_RozbaleniVybrat.Location = new System.Drawing.Point(688, 135);
            this.buttonNastaveni_RozbaleniVybrat.Name = "buttonNastaveni_RozbaleniVybrat";
            this.buttonNastaveni_RozbaleniVybrat.Size = new System.Drawing.Size(110, 22);
            this.buttonNastaveni_RozbaleniVybrat.TabIndex = 5;
            this.buttonNastaveni_RozbaleniVybrat.Text = "Vybrat soubor...";
            this.buttonNastaveni_RozbaleniVybrat.UseVisualStyleBackColor = false;
            this.buttonNastaveni_RozbaleniVybrat.Click += new System.EventHandler(this.buttonNastaveni_RozbaleniVybrat_Click);
            // 
            // buttonNastaveni_Mp3EnkoderVybrat
            // 
            this.buttonNastaveni_Mp3EnkoderVybrat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNastaveni_Mp3EnkoderVybrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonNastaveni_Mp3EnkoderVybrat.FlatAppearance.BorderSize = 0;
            this.buttonNastaveni_Mp3EnkoderVybrat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonNastaveni_Mp3EnkoderVybrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonNastaveni_Mp3EnkoderVybrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNastaveni_Mp3EnkoderVybrat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNastaveni_Mp3EnkoderVybrat.Location = new System.Drawing.Point(687, 328);
            this.buttonNastaveni_Mp3EnkoderVybrat.Name = "buttonNastaveni_Mp3EnkoderVybrat";
            this.buttonNastaveni_Mp3EnkoderVybrat.Size = new System.Drawing.Size(110, 22);
            this.buttonNastaveni_Mp3EnkoderVybrat.TabIndex = 15;
            this.buttonNastaveni_Mp3EnkoderVybrat.Text = "Vybrat soubor...";
            this.buttonNastaveni_Mp3EnkoderVybrat.UseVisualStyleBackColor = false;
            this.buttonNastaveni_Mp3EnkoderVybrat.Click += new System.EventHandler(this.buttonNastaveni_Mp3EnkoderVybrat_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(0, 10);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(1085, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "HUDEBNÍ SLOŽKY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxNastaveni_Rozbaleni
            // 
            this.comboBoxNastaveni_Rozbaleni.AllowDrop = true;
            this.comboBoxNastaveni_Rozbaleni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNastaveni_Rozbaleni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.comboBoxNastaveni_Rozbaleni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNastaveni_Rozbaleni.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxNastaveni_Rozbaleni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.comboBoxNastaveni_Rozbaleni.FormattingEnabled = true;
            this.comboBoxNastaveni_Rozbaleni.Location = new System.Drawing.Point(137, 135);
            this.comboBoxNastaveni_Rozbaleni.Name = "comboBoxNastaveni_Rozbaleni";
            this.comboBoxNastaveni_Rozbaleni.Size = new System.Drawing.Size(545, 22);
            this.comboBoxNastaveni_Rozbaleni.TabIndex = 4;
            this.comboBoxNastaveni_Rozbaleni.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxSoubor_DragDrop);
            this.comboBoxNastaveni_Rozbaleni.DragEnter += new System.Windows.Forms.DragEventHandler(this.prvek_DragEnter);
            this.comboBoxNastaveni_Rozbaleni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.comboBoxNastaveni_Rozbaleni.Leave += new System.EventHandler(this.comboBoxNastaveni_Rozbaleni_Leave);
            // 
            // comboBoxNastaveni_Mp3Enkoder
            // 
            this.comboBoxNastaveni_Mp3Enkoder.AllowDrop = true;
            this.comboBoxNastaveni_Mp3Enkoder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNastaveni_Mp3Enkoder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.comboBoxNastaveni_Mp3Enkoder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNastaveni_Mp3Enkoder.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxNastaveni_Mp3Enkoder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.comboBoxNastaveni_Mp3Enkoder.FormattingEnabled = true;
            this.comboBoxNastaveni_Mp3Enkoder.Location = new System.Drawing.Point(136, 328);
            this.comboBoxNastaveni_Mp3Enkoder.Name = "comboBoxNastaveni_Mp3Enkoder";
            this.comboBoxNastaveni_Mp3Enkoder.Size = new System.Drawing.Size(545, 22);
            this.comboBoxNastaveni_Mp3Enkoder.TabIndex = 14;
            this.comboBoxNastaveni_Mp3Enkoder.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxSoubor_DragDrop);
            this.comboBoxNastaveni_Mp3Enkoder.DragEnter += new System.Windows.Forms.DragEventHandler(this.prvek_DragEnter);
            this.comboBoxNastaveni_Mp3Enkoder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.comboBoxNastaveni_Mp3Enkoder.Leave += new System.EventHandler(this.comboBoxNastaveni_Mp3Enkoder_Leave);
            // 
            // listViewStav
            // 
            this.listViewStav.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewStav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.listViewStav.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewStav.ForeColor = System.Drawing.Color.White;
            this.listViewStav.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewStav.Location = new System.Drawing.Point(12, 658);
            this.listViewStav.MultiSelect = false;
            this.listViewStav.Name = "listViewStav";
            this.listViewStav.ShowGroups = false;
            this.listViewStav.ShowItemToolTips = true;
            this.listViewStav.Size = new System.Drawing.Size(859, 102);
            this.listViewStav.TabIndex = 50;
            this.listViewStav.TileSize = new System.Drawing.Size(50, 3);
            this.listViewStav.UseCompatibleStateImageBehavior = false;
            this.listViewStav.View = System.Windows.Forms.View.Details;
            this.listViewStav.SizeChanged += new System.EventHandler(this.listViewStav_SizeChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 334;
            // 
            // buttonMenuPridaniArchivu
            // 
            this.buttonMenuPridaniArchivu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonMenuPridaniArchivu.FlatAppearance.BorderSize = 0;
            this.buttonMenuPridaniArchivu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonMenuPridaniArchivu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuPridaniArchivu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenuPridaniArchivu.Location = new System.Drawing.Point(150, 0);
            this.buttonMenuPridaniArchivu.Name = "buttonMenuPridaniArchivu";
            this.buttonMenuPridaniArchivu.Size = new System.Drawing.Size(150, 25);
            this.buttonMenuPridaniArchivu.TabIndex = 54;
            this.buttonMenuPridaniArchivu.Text = "PŘIDÁNÍ ARCHIVU";
            this.buttonMenuPridaniArchivu.UseVisualStyleBackColor = false;
            this.buttonMenuPridaniArchivu.Click += new System.EventHandler(this.buttonMenuPridaniArchivu_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.buttonMenuZobrazeniArchivu);
            this.panelMenu.Controls.Add(this.buttonMenuPridaniSlozky);
            this.panelMenu.Controls.Add(this.buttonMenuNastaveni);
            this.panelMenu.Controls.Add(this.buttonMenuPridaniArchivu);
            this.panelMenu.Controls.Add(this.buttonMenuUpravaArchivu);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1082, 25);
            this.panelMenu.TabIndex = 55;
            // 
            // buttonMenuZobrazeniArchivu
            // 
            this.buttonMenuZobrazeniArchivu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonMenuZobrazeniArchivu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonMenuZobrazeniArchivu.FlatAppearance.BorderSize = 0;
            this.buttonMenuZobrazeniArchivu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonMenuZobrazeniArchivu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuZobrazeniArchivu.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenuZobrazeniArchivu.Location = new System.Drawing.Point(300, 0);
            this.buttonMenuZobrazeniArchivu.Name = "buttonMenuZobrazeniArchivu";
            this.buttonMenuZobrazeniArchivu.Size = new System.Drawing.Size(150, 25);
            this.buttonMenuZobrazeniArchivu.TabIndex = 56;
            this.buttonMenuZobrazeniArchivu.Text = "ZOBRAZENÍ ARCHIVŮ";
            this.buttonMenuZobrazeniArchivu.UseVisualStyleBackColor = false;
            this.buttonMenuZobrazeniArchivu.Click += new System.EventHandler(this.buttonMenuZobrazeniArchivu_Click);
            // 
            // buttonMenuPridaniSlozky
            // 
            this.buttonMenuPridaniSlozky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonMenuPridaniSlozky.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonMenuPridaniSlozky.FlatAppearance.BorderSize = 0;
            this.buttonMenuPridaniSlozky.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonMenuPridaniSlozky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuPridaniSlozky.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenuPridaniSlozky.Location = new System.Drawing.Point(0, 0);
            this.buttonMenuPridaniSlozky.Name = "buttonMenuPridaniSlozky";
            this.buttonMenuPridaniSlozky.Size = new System.Drawing.Size(150, 25);
            this.buttonMenuPridaniSlozky.TabIndex = 55;
            this.buttonMenuPridaniSlozky.Text = "PŘIDÁNÍ SLOŽKY";
            this.buttonMenuPridaniSlozky.UseVisualStyleBackColor = false;
            this.buttonMenuPridaniSlozky.Click += new System.EventHandler(this.buttonMenuPridaniSlozky_Click);
            // 
            // buttonMenuNastaveni
            // 
            this.buttonMenuNastaveni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonMenuNastaveni.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonMenuNastaveni.FlatAppearance.BorderSize = 0;
            this.buttonMenuNastaveni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonMenuNastaveni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuNastaveni.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenuNastaveni.Location = new System.Drawing.Point(600, 0);
            this.buttonMenuNastaveni.Name = "buttonMenuNastaveni";
            this.buttonMenuNastaveni.Size = new System.Drawing.Size(150, 25);
            this.buttonMenuNastaveni.TabIndex = 54;
            this.buttonMenuNastaveni.Text = "NASTAVENÍ";
            this.buttonMenuNastaveni.UseVisualStyleBackColor = false;
            this.buttonMenuNastaveni.Click += new System.EventHandler(this.buttonMenuNastaveni_Click);
            // 
            // buttonMenuUpravaArchivu
            // 
            this.buttonMenuUpravaArchivu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonMenuUpravaArchivu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonMenuUpravaArchivu.FlatAppearance.BorderSize = 0;
            this.buttonMenuUpravaArchivu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonMenuUpravaArchivu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuUpravaArchivu.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenuUpravaArchivu.Location = new System.Drawing.Point(450, 0);
            this.buttonMenuUpravaArchivu.Name = "buttonMenuUpravaArchivu";
            this.buttonMenuUpravaArchivu.Size = new System.Drawing.Size(150, 25);
            this.buttonMenuUpravaArchivu.TabIndex = 57;
            this.buttonMenuUpravaArchivu.Text = "ÚPRAVA ARCHIVŮ";
            this.buttonMenuUpravaArchivu.UseVisualStyleBackColor = false;
            this.buttonMenuUpravaArchivu.Click += new System.EventHandler(this.buttonMenuUpravaArchivu_Click);
            // 
            // buttonZobrazeniArchivu_PrevestNaMp3
            // 
            this.buttonZobrazeniArchivu_PrevestNaMp3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZobrazeniArchivu_PrevestNaMp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonZobrazeniArchivu_PrevestNaMp3.FlatAppearance.BorderSize = 0;
            this.buttonZobrazeniArchivu_PrevestNaMp3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonZobrazeniArchivu_PrevestNaMp3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonZobrazeniArchivu_PrevestNaMp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZobrazeniArchivu_PrevestNaMp3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonZobrazeniArchivu_PrevestNaMp3.Location = new System.Drawing.Point(412, 564);
            this.buttonZobrazeniArchivu_PrevestNaMp3.Name = "buttonZobrazeniArchivu_PrevestNaMp3";
            this.buttonZobrazeniArchivu_PrevestNaMp3.Size = new System.Drawing.Size(139, 23);
            this.buttonZobrazeniArchivu_PrevestNaMp3.TabIndex = 20;
            this.buttonZobrazeniArchivu_PrevestNaMp3.Text = "Převést na mp3";
            this.buttonZobrazeniArchivu_PrevestNaMp3.UseVisualStyleBackColor = false;
            this.buttonZobrazeniArchivu_PrevestNaMp3.Click += new System.EventHandler(this.buttonZobrazeniArchivu_PrevestNaMp3_Click);
            // 
            // backgroundWorkerPrevodNaMp3
            // 
            this.backgroundWorkerPrevodNaMp3.WorkerReportsProgress = true;
            this.backgroundWorkerPrevodNaMp3.WorkerSupportsCancellation = true;
            this.backgroundWorkerPrevodNaMp3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerPrevodNaMp3_DoWork);
            this.backgroundWorkerPrevodNaMp3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerPrevod_ProgressChanged);
            this.backgroundWorkerPrevodNaMp3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerPrevodNaMp3_RunWorkerCompleted);
            // 
            // panelPridaniSlozky
            // 
            this.panelPridaniSlozky.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPridaniSlozky.Controls.Add(this.checkBoxPridaniSlozky_odstranitNacteneArchivy);
            this.panelPridaniSlozky.Controls.Add(this.label28);
            this.panelPridaniSlozky.Controls.Add(this.label27);
            this.panelPridaniSlozky.Controls.Add(this.listViewPridaniSlozky_SeznamArchivu);
            this.panelPridaniSlozky.Controls.Add(this.buttonPridaniSlozky_NacistArchivy);
            this.panelPridaniSlozky.Controls.Add(this.labelPridaniSlozky_Stav);
            this.panelPridaniSlozky.Controls.Add(this.buttonPridaniSlozky_PridatArchivy);
            this.panelPridaniSlozky.Controls.Add(this.buttonPridaniSlozky_VybratSlozku);
            this.panelPridaniSlozky.Controls.Add(this.checkBoxPridaniSlozky_NacistPodslozky);
            this.panelPridaniSlozky.Controls.Add(this.checkBoxPridaniSlozky_SmazatDrivePridane);
            this.panelPridaniSlozky.Controls.Add(this.comboBoxPridaniSlozky_Slozka);
            this.panelPridaniSlozky.Controls.Add(this.labelPridaniSlozky_VybraneArchivy);
            this.panelPridaniSlozky.Controls.Add(this.label40);
            this.panelPridaniSlozky.Controls.Add(this.label26);
            this.panelPridaniSlozky.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelPridaniSlozky.Location = new System.Drawing.Point(0, 26);
            this.panelPridaniSlozky.Name = "panelPridaniSlozky";
            this.panelPridaniSlozky.Size = new System.Drawing.Size(1083, 625);
            this.panelPridaniSlozky.TabIndex = 54;
            // 
            // checkBoxPridaniSlozky_odstranitNacteneArchivy
            // 
            this.checkBoxPridaniSlozky_odstranitNacteneArchivy.Checked = true;
            this.checkBoxPridaniSlozky_odstranitNacteneArchivy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPridaniSlozky_odstranitNacteneArchivy.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPridaniSlozky_odstranitNacteneArchivy.Location = new System.Drawing.Point(136, 69);
            this.checkBoxPridaniSlozky_odstranitNacteneArchivy.Name = "checkBoxPridaniSlozky_odstranitNacteneArchivy";
            this.checkBoxPridaniSlozky_odstranitNacteneArchivy.Size = new System.Drawing.Size(231, 22);
            this.checkBoxPridaniSlozky_odstranitNacteneArchivy.TabIndex = 57;
            this.checkBoxPridaniSlozky_odstranitNacteneArchivy.Text = "Odstranit načtené archivy ze seznamu";
            this.checkBoxPridaniSlozky_odstranitNacteneArchivy.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label28.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label28.Location = new System.Drawing.Point(133, -417);
            this.label28.Name = "label28";
            this.label28.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label28.Size = new System.Drawing.Size(1085, 25);
            this.label28.TabIndex = 41;
            this.label28.Text = "ARCHIVY VE SLOŽCE";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label27.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.Location = new System.Drawing.Point(1, 97);
            this.label27.Name = "label27";
            this.label27.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label27.Size = new System.Drawing.Size(1085, 25);
            this.label27.TabIndex = 41;
            this.label27.Text = "ARCHIVY VE SLOŽCE";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listViewPridaniSlozky_SeznamArchivu
            // 
            this.listViewPridaniSlozky_SeznamArchivu.AllowDrop = true;
            this.listViewPridaniSlozky_SeznamArchivu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPridaniSlozky_SeznamArchivu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.listViewPridaniSlozky_SeznamArchivu.CheckBoxes = true;
            this.listViewPridaniSlozky_SeznamArchivu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPridaniSlozky_SeznamArchivu_Nazev,
            this.columnHeaderPridaniSlozky_SeznamArchivu_Slozka,
            this.columnHeaderPridaniSlozky_SeznamArchivu_Typ,
            this.columnHeaderPridaniSlozky_SeznamArchivu_Cesta});
            this.listViewPridaniSlozky_SeznamArchivu.ForeColor = System.Drawing.Color.White;
            this.listViewPridaniSlozky_SeznamArchivu.FullRowSelect = true;
            this.listViewPridaniSlozky_SeznamArchivu.Location = new System.Drawing.Point(4, 128);
            this.listViewPridaniSlozky_SeznamArchivu.MultiSelect = false;
            this.listViewPridaniSlozky_SeznamArchivu.Name = "listViewPridaniSlozky_SeznamArchivu";
            this.listViewPridaniSlozky_SeznamArchivu.ShowGroups = false;
            this.listViewPridaniSlozky_SeznamArchivu.ShowItemToolTips = true;
            this.listViewPridaniSlozky_SeznamArchivu.Size = new System.Drawing.Size(1082, 439);
            this.listViewPridaniSlozky_SeznamArchivu.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewPridaniSlozky_SeznamArchivu.TabIndex = 56;
            this.listViewPridaniSlozky_SeznamArchivu.UseCompatibleStateImageBehavior = false;
            this.listViewPridaniSlozky_SeznamArchivu.View = System.Windows.Forms.View.Details;
            this.listViewPridaniSlozky_SeznamArchivu.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewPridaniSlozky_SeznamArchivu_ItemChecked);
            this.listViewPridaniSlozky_SeznamArchivu.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewPridaniSlozky_SeznamArchivu_DragDrop);
            this.listViewPridaniSlozky_SeznamArchivu.DragEnter += new System.Windows.Forms.DragEventHandler(this.prvek_DragEnter);
            // 
            // columnHeaderPridaniSlozky_SeznamArchivu_Nazev
            // 
            this.columnHeaderPridaniSlozky_SeznamArchivu_Nazev.Text = "Název archivu";
            this.columnHeaderPridaniSlozky_SeznamArchivu_Nazev.Width = 258;
            // 
            // columnHeaderPridaniSlozky_SeznamArchivu_Slozka
            // 
            this.columnHeaderPridaniSlozky_SeznamArchivu_Slozka.Text = "Název složky";
            this.columnHeaderPridaniSlozky_SeznamArchivu_Slozka.Width = 86;
            // 
            // columnHeaderPridaniSlozky_SeznamArchivu_Typ
            // 
            this.columnHeaderPridaniSlozky_SeznamArchivu_Typ.Text = "Typ archivu";
            this.columnHeaderPridaniSlozky_SeznamArchivu_Typ.Width = 78;
            // 
            // columnHeaderPridaniSlozky_SeznamArchivu_Cesta
            // 
            this.columnHeaderPridaniSlozky_SeznamArchivu_Cesta.Text = "Cesta archivu";
            this.columnHeaderPridaniSlozky_SeznamArchivu_Cesta.Width = 634;
            // 
            // buttonPridaniSlozky_NacistArchivy
            // 
            this.buttonPridaniSlozky_NacistArchivy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPridaniSlozky_NacistArchivy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonPridaniSlozky_NacistArchivy.FlatAppearance.BorderSize = 0;
            this.buttonPridaniSlozky_NacistArchivy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonPridaniSlozky_NacistArchivy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonPridaniSlozky_NacistArchivy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPridaniSlozky_NacistArchivy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonPridaniSlozky_NacistArchivy.Location = new System.Drawing.Point(542, 69);
            this.buttonPridaniSlozky_NacistArchivy.Name = "buttonPridaniSlozky_NacistArchivy";
            this.buttonPridaniSlozky_NacistArchivy.Size = new System.Drawing.Size(139, 23);
            this.buttonPridaniSlozky_NacistArchivy.TabIndex = 51;
            this.buttonPridaniSlozky_NacistArchivy.Text = "Načíst archivy ze složky";
            this.buttonPridaniSlozky_NacistArchivy.UseVisualStyleBackColor = false;
            this.buttonPridaniSlozky_NacistArchivy.Click += new System.EventHandler(this.buttonPridaniSlozky_NacistArchivy_Click);
            // 
            // labelPridaniSlozky_Stav
            // 
            this.labelPridaniSlozky_Stav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPridaniSlozky_Stav.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPridaniSlozky_Stav.Location = new System.Drawing.Point(804, 44);
            this.labelPridaniSlozky_Stav.Name = "labelPridaniSlozky_Stav";
            this.labelPridaniSlozky_Stav.Size = new System.Drawing.Size(278, 21);
            this.labelPridaniSlozky_Stav.TabIndex = 25;
            this.labelPridaniSlozky_Stav.Text = "stav";
            this.labelPridaniSlozky_Stav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonPridaniSlozky_PridatArchivy
            // 
            this.buttonPridaniSlozky_PridatArchivy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPridaniSlozky_PridatArchivy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonPridaniSlozky_PridatArchivy.FlatAppearance.BorderSize = 0;
            this.buttonPridaniSlozky_PridatArchivy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonPridaniSlozky_PridatArchivy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonPridaniSlozky_PridatArchivy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPridaniSlozky_PridatArchivy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonPridaniSlozky_PridatArchivy.Location = new System.Drawing.Point(11, 595);
            this.buttonPridaniSlozky_PridatArchivy.Name = "buttonPridaniSlozky_PridatArchivy";
            this.buttonPridaniSlozky_PridatArchivy.Size = new System.Drawing.Size(139, 23);
            this.buttonPridaniSlozky_PridatArchivy.TabIndex = 51;
            this.buttonPridaniSlozky_PridatArchivy.Text = "Přidat vybrané";
            this.buttonPridaniSlozky_PridatArchivy.UseVisualStyleBackColor = false;
            this.buttonPridaniSlozky_PridatArchivy.Click += new System.EventHandler(this.buttonPridaniSlozky_PridatArchivy_Click);
            // 
            // buttonPridaniSlozky_VybratSlozku
            // 
            this.buttonPridaniSlozky_VybratSlozku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPridaniSlozky_VybratSlozku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonPridaniSlozky_VybratSlozku.FlatAppearance.BorderSize = 0;
            this.buttonPridaniSlozky_VybratSlozku.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonPridaniSlozky_VybratSlozku.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonPridaniSlozky_VybratSlozku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPridaniSlozky_VybratSlozku.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPridaniSlozky_VybratSlozku.Location = new System.Drawing.Point(687, 41);
            this.buttonPridaniSlozky_VybratSlozku.Name = "buttonPridaniSlozky_VybratSlozku";
            this.buttonPridaniSlozky_VybratSlozku.Size = new System.Drawing.Size(110, 22);
            this.buttonPridaniSlozky_VybratSlozku.TabIndex = 1;
            this.buttonPridaniSlozky_VybratSlozku.Text = "Vybrat složku...";
            this.buttonPridaniSlozky_VybratSlozku.UseVisualStyleBackColor = false;
            this.buttonPridaniSlozky_VybratSlozku.Click += new System.EventHandler(this.buttonPridaniSlozky_VybratSlozku_Click);
            // 
            // checkBoxPridaniSlozky_NacistPodslozky
            // 
            this.checkBoxPridaniSlozky_NacistPodslozky.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPridaniSlozky_NacistPodslozky.Location = new System.Drawing.Point(366, 69);
            this.checkBoxPridaniSlozky_NacistPodslozky.Name = "checkBoxPridaniSlozky_NacistPodslozky";
            this.checkBoxPridaniSlozky_NacistPodslozky.Size = new System.Drawing.Size(173, 22);
            this.checkBoxPridaniSlozky_NacistPodslozky.TabIndex = 44;
            this.checkBoxPridaniSlozky_NacistPodslozky.Text = "Načíst archivy i z podsložek";
            this.checkBoxPridaniSlozky_NacistPodslozky.UseVisualStyleBackColor = true;
            // 
            // checkBoxPridaniSlozky_SmazatDrivePridane
            // 
            this.checkBoxPridaniSlozky_SmazatDrivePridane.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPridaniSlozky_SmazatDrivePridane.Location = new System.Drawing.Point(156, 595);
            this.checkBoxPridaniSlozky_SmazatDrivePridane.Name = "checkBoxPridaniSlozky_SmazatDrivePridane";
            this.checkBoxPridaniSlozky_SmazatDrivePridane.Size = new System.Drawing.Size(270, 22);
            this.checkBoxPridaniSlozky_SmazatDrivePridane.TabIndex = 44;
            this.checkBoxPridaniSlozky_SmazatDrivePridane.Text = "Při přidávání smazat již dříve přidané archivy";
            this.checkBoxPridaniSlozky_SmazatDrivePridane.UseVisualStyleBackColor = true;
            // 
            // comboBoxPridaniSlozky_Slozka
            // 
            this.comboBoxPridaniSlozky_Slozka.AllowDrop = true;
            this.comboBoxPridaniSlozky_Slozka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPridaniSlozky_Slozka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.comboBoxPridaniSlozky_Slozka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPridaniSlozky_Slozka.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPridaniSlozky_Slozka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.comboBoxPridaniSlozky_Slozka.FormattingEnabled = true;
            this.comboBoxPridaniSlozky_Slozka.Location = new System.Drawing.Point(136, 41);
            this.comboBoxPridaniSlozky_Slozka.Name = "comboBoxPridaniSlozky_Slozka";
            this.comboBoxPridaniSlozky_Slozka.Size = new System.Drawing.Size(545, 22);
            this.comboBoxPridaniSlozky_Slozka.TabIndex = 0;
            this.comboBoxPridaniSlozky_Slozka.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxSlozka_DragDrop);
            this.comboBoxPridaniSlozky_Slozka.DragEnter += new System.Windows.Forms.DragEventHandler(this.prvek_DragEnter);
            this.comboBoxPridaniSlozky_Slozka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.comboBoxPridaniSlozky_Slozka.Leave += new System.EventHandler(this.comboBoxPridaniSlozky_Slozka_Leave);
            // 
            // labelPridaniSlozky_VybraneArchivy
            // 
            this.labelPridaniSlozky_VybraneArchivy.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPridaniSlozky_VybraneArchivy.Location = new System.Drawing.Point(4, 570);
            this.labelPridaniSlozky_VybraneArchivy.Name = "labelPridaniSlozky_VybraneArchivy";
            this.labelPridaniSlozky_VybraneArchivy.Size = new System.Drawing.Size(395, 22);
            this.labelPridaniSlozky_VybraneArchivy.TabIndex = 35;
            this.labelPridaniSlozky_VybraneArchivy.Text = "Načtěte složku s archivy nebo ji přetáhněte na seznam archivů";
            this.labelPridaniSlozky_VybraneArchivy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label40
            // 
            this.label40.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label40.Location = new System.Drawing.Point(2, 41);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(130, 22);
            this.label40.TabIndex = 35;
            this.label40.Text = "Cesta složky";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label26.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.Location = new System.Drawing.Point(0, 10);
            this.label26.Name = "label26";
            this.label26.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label26.Size = new System.Drawing.Size(1085, 25);
            this.label26.TabIndex = 41;
            this.label26.Text = "SLOŽKA K PŘIDÁNÍ";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelZobrazeniArchivu
            // 
            this.panelZobrazeniArchivu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelZobrazeniArchivu.Controls.Add(this.labelZobrazeniArchivu_VybraneArchivy);
            this.panelZobrazeniArchivu.Controls.Add(this.labelZobrazeniArchivu_Kontrola);
            this.panelZobrazeniArchivu.Controls.Add(this.buttonZobrazeniArchivu_PrevestNaMp3);
            this.panelZobrazeniArchivu.Controls.Add(this.buttonZobrazeniArchivu_PrevestNaOpus);
            this.panelZobrazeniArchivu.Controls.Add(this.buttonZobrazeniArchivu_SpustitVse);
            this.panelZobrazeniArchivu.Controls.Add(this.checkBoxZobrazeniArchivu_ZobrazitSkrytHesla);
            this.panelZobrazeniArchivu.Controls.Add(this.buttonZobrazeniArchivu_PresunDoKnihoven);
            this.panelZobrazeniArchivu.Controls.Add(this.listViewZobrazeniArchivu_SeznamArchivu);
            this.panelZobrazeniArchivu.Controls.Add(this.buttonZobrazeniArchivu_VyberZrusit);
            this.panelZobrazeniArchivu.Controls.Add(this.buttonZobrazeniArchivu_VyberVse);
            this.panelZobrazeniArchivu.Controls.Add(this.buttonZobrazeniArchivu_Odstranit);
            this.panelZobrazeniArchivu.Controls.Add(this.buttonZobrazeniArchivu_PrevestNaOpusMp3);
            this.panelZobrazeniArchivu.Controls.Add(this.buttonZobrazeniArchivu_Mp3TagVse);
            this.panelZobrazeniArchivu.Controls.Add(this.buttonZobrazeniArchivu_Rozbalit);
            this.panelZobrazeniArchivu.Controls.Add(this.buttonZobrazeniArchivu_Mp3TagOpus);
            this.panelZobrazeniArchivu.Controls.Add(this.buttonZobrazeniArchivu_Mp3TagRozbalene);
            this.panelZobrazeniArchivu.Controls.Add(this.buttonZobrazeniArchivu_Mp3TagMp3);
            this.panelZobrazeniArchivu.Controls.Add(this.label49);
            this.panelZobrazeniArchivu.Location = new System.Drawing.Point(0, 26);
            this.panelZobrazeniArchivu.Name = "panelZobrazeniArchivu";
            this.panelZobrazeniArchivu.Size = new System.Drawing.Size(1083, 625);
            this.panelZobrazeniArchivu.TabIndex = 54;
            // 
            // labelZobrazeniArchivu_VybraneArchivy
            // 
            this.labelZobrazeniArchivu_VybraneArchivy.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZobrazeniArchivu_VybraneArchivy.Location = new System.Drawing.Point(4, 510);
            this.labelZobrazeniArchivu_VybraneArchivy.Name = "labelZobrazeniArchivu_VybraneArchivy";
            this.labelZobrazeniArchivu_VybraneArchivy.Size = new System.Drawing.Size(395, 22);
            this.labelZobrazeniArchivu_VybraneArchivy.TabIndex = 57;
            this.labelZobrazeniArchivu_VybraneArchivy.Text = "Přidejte nějaký archiv";
            this.labelZobrazeniArchivu_VybraneArchivy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelZobrazeniArchivu_Kontrola
            // 
            this.labelZobrazeniArchivu_Kontrola.AutoSize = true;
            this.labelZobrazeniArchivu_Kontrola.Location = new System.Drawing.Point(123, 592);
            this.labelZobrazeniArchivu_Kontrola.Name = "labelZobrazeniArchivu_Kontrola";
            this.labelZobrazeniArchivu_Kontrola.Size = new System.Drawing.Size(47, 13);
            this.labelZobrazeniArchivu_Kontrola.TabIndex = 58;
            this.labelZobrazeniArchivu_Kontrola.Text = "kontrola";
            // 
            // checkBoxZobrazeniArchivu_ZobrazitSkrytHesla
            // 
            this.checkBoxZobrazeniArchivu_ZobrazitSkrytHesla.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxZobrazeniArchivu_ZobrazitSkrytHesla.Location = new System.Drawing.Point(123, 537);
            this.checkBoxZobrazeniArchivu_ZobrazitSkrytHesla.Name = "checkBoxZobrazeniArchivu_ZobrazitSkrytHesla";
            this.checkBoxZobrazeniArchivu_ZobrazitSkrytHesla.Size = new System.Drawing.Size(138, 22);
            this.checkBoxZobrazeniArchivu_ZobrazitSkrytHesla.TabIndex = 44;
            this.checkBoxZobrazeniArchivu_ZobrazitSkrytHesla.Text = "Zobrazit hesla";
            this.checkBoxZobrazeniArchivu_ZobrazitSkrytHesla.UseVisualStyleBackColor = true;
            this.checkBoxZobrazeniArchivu_ZobrazitSkrytHesla.CheckedChanged += new System.EventHandler(this.checkBoxZobrazeniArchivu_ZobrazitSkrytHesla_CheckedChanged);
            // 
            // listViewZobrazeniArchivu_SeznamArchivu
            // 
            this.listViewZobrazeniArchivu_SeznamArchivu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewZobrazeniArchivu_SeznamArchivu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.listViewZobrazeniArchivu_SeznamArchivu.CheckBoxes = true;
            this.listViewZobrazeniArchivu_SeznamArchivu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderZobrazeniArchivu_Nazev,
            this.columnHeaderZobrazeniArchivu_Stav,
            this.columnHeaderZobrazeniArchivu_HesloSkryte,
            this.columnHeaderZobrazeniArchivu_Interpret,
            this.columnHeaderZobrazeniArchivu_Rok,
            this.columnHeaderZobrazeniArchivu_Album,
            this.columnHeaderZobrazeniArchivu_Zanr,
            this.columnHeaderZobrazeniArchivu_SlozkaOpus,
            this.columnHeaderZobrazeniArchivu_SlozkaMp3,
            this.columnHeaderZobrazeniArchivu_Cover});
            this.listViewZobrazeniArchivu_SeznamArchivu.ForeColor = System.Drawing.Color.White;
            this.listViewZobrazeniArchivu_SeznamArchivu.FullRowSelect = true;
            this.listViewZobrazeniArchivu_SeznamArchivu.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewZobrazeniArchivu_SeznamArchivu.Location = new System.Drawing.Point(3, 38);
            this.listViewZobrazeniArchivu_SeznamArchivu.MultiSelect = false;
            this.listViewZobrazeniArchivu_SeznamArchivu.Name = "listViewZobrazeniArchivu_SeznamArchivu";
            this.listViewZobrazeniArchivu_SeznamArchivu.ShowGroups = false;
            this.listViewZobrazeniArchivu_SeznamArchivu.ShowItemToolTips = true;
            this.listViewZobrazeniArchivu_SeznamArchivu.Size = new System.Drawing.Size(1079, 472);
            this.listViewZobrazeniArchivu_SeznamArchivu.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewZobrazeniArchivu_SeznamArchivu.TabIndex = 57;
            this.listViewZobrazeniArchivu_SeznamArchivu.UseCompatibleStateImageBehavior = false;
            this.listViewZobrazeniArchivu_SeznamArchivu.View = System.Windows.Forms.View.Details;
            this.listViewZobrazeniArchivu_SeznamArchivu.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewZobrazeniArchivu_SeznamArchivu_ItemChecked);
            // 
            // columnHeaderZobrazeniArchivu_Nazev
            // 
            this.columnHeaderZobrazeniArchivu_Nazev.Text = "Název archivu";
            this.columnHeaderZobrazeniArchivu_Nazev.Width = 179;
            // 
            // columnHeaderZobrazeniArchivu_Stav
            // 
            this.columnHeaderZobrazeniArchivu_Stav.Text = "Stav";
            this.columnHeaderZobrazeniArchivu_Stav.Width = 37;
            // 
            // columnHeaderZobrazeniArchivu_HesloSkryte
            // 
            this.columnHeaderZobrazeniArchivu_HesloSkryte.Text = "Heslo archivu";
            this.columnHeaderZobrazeniArchivu_HesloSkryte.Width = 82;
            // 
            // columnHeaderZobrazeniArchivu_Interpret
            // 
            this.columnHeaderZobrazeniArchivu_Interpret.Text = "Interpret";
            this.columnHeaderZobrazeniArchivu_Interpret.Width = 131;
            // 
            // columnHeaderZobrazeniArchivu_Rok
            // 
            this.columnHeaderZobrazeniArchivu_Rok.Text = "Rok";
            // 
            // columnHeaderZobrazeniArchivu_Album
            // 
            this.columnHeaderZobrazeniArchivu_Album.Text = "Album";
            this.columnHeaderZobrazeniArchivu_Album.Width = 161;
            // 
            // columnHeaderZobrazeniArchivu_Zanr
            // 
            this.columnHeaderZobrazeniArchivu_Zanr.Text = "Žánr";
            this.columnHeaderZobrazeniArchivu_Zanr.Width = 77;
            // 
            // columnHeaderZobrazeniArchivu_SlozkaOpus
            // 
            this.columnHeaderZobrazeniArchivu_SlozkaOpus.Text = "Složka opus";
            this.columnHeaderZobrazeniArchivu_SlozkaOpus.Width = 138;
            // 
            // columnHeaderZobrazeniArchivu_SlozkaMp3
            // 
            this.columnHeaderZobrazeniArchivu_SlozkaMp3.Text = "Složka mp3";
            this.columnHeaderZobrazeniArchivu_SlozkaMp3.Width = 143;
            // 
            // columnHeaderZobrazeniArchivu_Cover
            // 
            this.columnHeaderZobrazeniArchivu_Cover.Text = "Cover";
            this.columnHeaderZobrazeniArchivu_Cover.Width = 57;
            // 
            // buttonZobrazeniArchivu_VyberZrusit
            // 
            this.buttonZobrazeniArchivu_VyberZrusit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonZobrazeniArchivu_VyberZrusit.FlatAppearance.BorderSize = 0;
            this.buttonZobrazeniArchivu_VyberZrusit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonZobrazeniArchivu_VyberZrusit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonZobrazeniArchivu_VyberZrusit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZobrazeniArchivu_VyberZrusit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZobrazeniArchivu_VyberZrusit.Location = new System.Drawing.Point(7, 592);
            this.buttonZobrazeniArchivu_VyberZrusit.Name = "buttonZobrazeniArchivu_VyberZrusit";
            this.buttonZobrazeniArchivu_VyberZrusit.Size = new System.Drawing.Size(110, 22);
            this.buttonZobrazeniArchivu_VyberZrusit.TabIndex = 1;
            this.buttonZobrazeniArchivu_VyberZrusit.Text = "Zrušit výběr";
            this.buttonZobrazeniArchivu_VyberZrusit.UseVisualStyleBackColor = false;
            this.buttonZobrazeniArchivu_VyberZrusit.Click += new System.EventHandler(this.buttonZobrazeniArchivu_VyberZrusit_Click);
            // 
            // buttonZobrazeniArchivu_VyberVse
            // 
            this.buttonZobrazeniArchivu_VyberVse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonZobrazeniArchivu_VyberVse.FlatAppearance.BorderSize = 0;
            this.buttonZobrazeniArchivu_VyberVse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonZobrazeniArchivu_VyberVse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonZobrazeniArchivu_VyberVse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZobrazeniArchivu_VyberVse.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZobrazeniArchivu_VyberVse.Location = new System.Drawing.Point(7, 564);
            this.buttonZobrazeniArchivu_VyberVse.Name = "buttonZobrazeniArchivu_VyberVse";
            this.buttonZobrazeniArchivu_VyberVse.Size = new System.Drawing.Size(110, 22);
            this.buttonZobrazeniArchivu_VyberVse.TabIndex = 1;
            this.buttonZobrazeniArchivu_VyberVse.Text = "Vybrat vše";
            this.buttonZobrazeniArchivu_VyberVse.UseVisualStyleBackColor = false;
            this.buttonZobrazeniArchivu_VyberVse.Click += new System.EventHandler(this.buttonZobrazeniArchivu_VyberVse_Click);
            // 
            // buttonZobrazeniArchivu_Odstranit
            // 
            this.buttonZobrazeniArchivu_Odstranit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonZobrazeniArchivu_Odstranit.FlatAppearance.BorderSize = 0;
            this.buttonZobrazeniArchivu_Odstranit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonZobrazeniArchivu_Odstranit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonZobrazeniArchivu_Odstranit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZobrazeniArchivu_Odstranit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZobrazeniArchivu_Odstranit.Location = new System.Drawing.Point(7, 536);
            this.buttonZobrazeniArchivu_Odstranit.Name = "buttonZobrazeniArchivu_Odstranit";
            this.buttonZobrazeniArchivu_Odstranit.Size = new System.Drawing.Size(110, 22);
            this.buttonZobrazeniArchivu_Odstranit.TabIndex = 1;
            this.buttonZobrazeniArchivu_Odstranit.Text = "Odstranit";
            this.buttonZobrazeniArchivu_Odstranit.UseVisualStyleBackColor = false;
            this.buttonZobrazeniArchivu_Odstranit.Click += new System.EventHandler(this.buttonZobrazeniArchivu_Odstranit_Click);
            // 
            // buttonZobrazeniArchivu_PrevestNaOpusMp3
            // 
            this.buttonZobrazeniArchivu_PrevestNaOpusMp3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZobrazeniArchivu_PrevestNaOpusMp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonZobrazeniArchivu_PrevestNaOpusMp3.FlatAppearance.BorderSize = 0;
            this.buttonZobrazeniArchivu_PrevestNaOpusMp3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonZobrazeniArchivu_PrevestNaOpusMp3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonZobrazeniArchivu_PrevestNaOpusMp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZobrazeniArchivu_PrevestNaOpusMp3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonZobrazeniArchivu_PrevestNaOpusMp3.Location = new System.Drawing.Point(412, 592);
            this.buttonZobrazeniArchivu_PrevestNaOpusMp3.Name = "buttonZobrazeniArchivu_PrevestNaOpusMp3";
            this.buttonZobrazeniArchivu_PrevestNaOpusMp3.Size = new System.Drawing.Size(139, 23);
            this.buttonZobrazeniArchivu_PrevestNaOpusMp3.TabIndex = 23;
            this.buttonZobrazeniArchivu_PrevestNaOpusMp3.Text = "Převést na opus a mp3";
            this.buttonZobrazeniArchivu_PrevestNaOpusMp3.UseVisualStyleBackColor = false;
            this.buttonZobrazeniArchivu_PrevestNaOpusMp3.Click += new System.EventHandler(this.buttonZobrazeniArchivu_PrevestNaOpusMp3_Click);
            // 
            // buttonZobrazeniArchivu_Mp3TagRozbalene
            // 
            this.buttonZobrazeniArchivu_Mp3TagRozbalene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZobrazeniArchivu_Mp3TagRozbalene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.buttonZobrazeniArchivu_Mp3TagRozbalene.FlatAppearance.BorderSize = 0;
            this.buttonZobrazeniArchivu_Mp3TagRozbalene.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonZobrazeniArchivu_Mp3TagRozbalene.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonZobrazeniArchivu_Mp3TagRozbalene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZobrazeniArchivu_Mp3TagRozbalene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonZobrazeniArchivu_Mp3TagRozbalene.Location = new System.Drawing.Point(267, 563);
            this.buttonZobrazeniArchivu_Mp3TagRozbalene.Name = "buttonZobrazeniArchivu_Mp3TagRozbalene";
            this.buttonZobrazeniArchivu_Mp3TagRozbalene.Size = new System.Drawing.Size(139, 42);
            this.buttonZobrazeniArchivu_Mp3TagRozbalene.TabIndex = 21;
            this.buttonZobrazeniArchivu_Mp3TagRozbalene.Text = "Otevřít rozbalené soubory v mp3tagu";
            this.buttonZobrazeniArchivu_Mp3TagRozbalene.UseVisualStyleBackColor = false;
            this.buttonZobrazeniArchivu_Mp3TagRozbalene.Click += new System.EventHandler(this.buttonZobrazeniArchivu_Mp3TagRozbalene_Click);
            // 
            // label49
            // 
            this.label49.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label49.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label49.Location = new System.Drawing.Point(0, 10);
            this.label49.Name = "label49";
            this.label49.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label49.Size = new System.Drawing.Size(1085, 25);
            this.label49.TabIndex = 40;
            this.label49.Text = "ARCHIVY";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundWorkerPresunDoKnihoven
            // 
            this.backgroundWorkerPresunDoKnihoven.WorkerReportsProgress = true;
            this.backgroundWorkerPresunDoKnihoven.WorkerSupportsCancellation = true;
            this.backgroundWorkerPresunDoKnihoven.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerPresunDoKnihoven_DoWork);
            this.backgroundWorkerPresunDoKnihoven.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerPresunDoKnihoven_ProgressChanged);
            this.backgroundWorkerPresunDoKnihoven.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerPresunDoKnihoven_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1084, 772);
            this.Controls.Add(this.listViewStav);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelPridaniSlozky);
            this.Controls.Add(this.panelPridaniUpravaArchivu);
            this.Controls.Add(this.panelZobrazeniArchivu);
            this.Controls.Add(this.panelNastaveni);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Archive2Music 0.8 Beta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPridaniUpravaArchivu_Rok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPridaniUpravaArchivu_Cover)).EndInit();
            this.panelPridaniUpravaArchivu.ResumeLayout(false);
            this.panelPridaniUpravaArchivu.PerformLayout();
            this.panelNastaveni.ResumeLayout(false);
            this.panelNastaveni.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelPridaniSlozky.ResumeLayout(false);
            this.panelZobrazeniArchivu.ResumeLayout(false);
            this.panelZobrazeniArchivu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonZobrazeniArchivu_Rozbalit;
        private System.Windows.Forms.Button buttonNastaveni_SlozkaOpusVybrat;
        private System.Windows.Forms.Button buttonPridaniUpravaArchivu_ArchivVybrat;
        private System.Windows.Forms.TextBox textBoxPridaniUpravaArchivu_Interpret;
        private System.Windows.Forms.TextBox textBoxPridaniUpravaArchivu_Album;
        private System.Windows.Forms.TextBox textBoxPridaniUpravaArchivu_Zanr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPridaniUpravaArchivu_SlozkaStat;
        private System.Windows.Forms.ComboBox comboBoxPridaniUpravaArchivu_SlozkaZanr;
        private System.Windows.Forms.Button buttonZobrazeniArchivu_Mp3TagMp3;
        private System.Windows.Forms.Button buttonNastaveni_Mp3TagVybrat;
        private System.Windows.Forms.Button buttonNastaveni_AlbumArtVybrat;
        private System.Windows.Forms.Button buttonNastaveni_OpusEnkoderVybrat;
        private System.Windows.Forms.Button buttonPridaniUpravaArchivu_CoverZiskat;
        private System.Windows.Forms.Button buttonZobrazeniArchivu_PrevestNaOpus;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPrevodNaOpus;
        private System.Windows.Forms.Button buttonNastaveni_SlozkaMp3Vybrat;
        private System.Windows.Forms.Button buttonZobrazeniArchivu_PresunDoKnihoven;
        private System.Windows.Forms.Button buttonZobrazeniArchivu_Mp3TagOpus;
        private System.Windows.Forms.Button buttonZobrazeniArchivu_Mp3TagVse;
        private System.Windows.Forms.Label labelNastaveni_Mp3TagStav;
        private System.Windows.Forms.Label labelNastaveni_AlbumArtStav;
        private System.Windows.Forms.Label labelNastaveni_OpusEnkoderStav;
        private System.Windows.Forms.Label labelPridaniUpravaArchivu_ArchivStav;
        private System.Windows.Forms.Label labelNastaveni_SlozkaMp3Stav;
        private System.Windows.Forms.Label labelNastaveni_SlozkaOpusStav;
        private System.Windows.Forms.ComboBox comboBoxNastaveni_Mp3Tag;
        private System.Windows.Forms.ComboBox comboBoxNastaveni_AlbumArt;
        private System.Windows.Forms.ComboBox comboBoxPridaniUpravaArchivu_Archiv;
        private System.Windows.Forms.ComboBox comboBoxNastaveni_SlozkaOpus;
        private System.Windows.Forms.ComboBox comboBoxNastaveni_SlozkaMp3;
        private System.Windows.Forms.ComboBox comboBoxNastaveni_OpusEnkoder;
        private System.Windows.Forms.Label labelNastaveni_SlozkaOpusOtevrit;
        private System.Windows.Forms.Label labelNastaveni_SlozkaMp3Otevrit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownPridaniUpravaArchivu_Rok;
        private System.Windows.Forms.CheckBox checkBoxPridaniUpravaArchivu_ZanrMenit;
        private System.Windows.Forms.Label labelPridaniUpravaArchivu_SlozkaOpusCestaStav;
        private System.Windows.Forms.Label labelPridaniUpravaArchivu_SlozkaMp3CestaStav;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.PictureBox pictureBoxPridaniUpravaArchivu_Cover;
        private System.Windows.Forms.Button buttonPridaniUpravaArchivu_CoverVybrat;
        private System.Windows.Forms.CheckBox checkBoxPridaniUpravaArchivu_PrepsatSoubory;
        private System.Windows.Forms.Button buttonZobrazeniArchivu_SpustitVse;
        private System.Windows.Forms.Label labelPridaniUpravaArchivu_SlozkaOpusCesta;
        private System.Windows.Forms.Label labelPridaniUpravaArchivu_SlozkaMp3Cesta;
        private System.Windows.Forms.Button buttonPridaniUpravaArchivu_CoverSmazat;
        private System.Windows.Forms.Panel panelPridaniUpravaArchivu;
        private System.Windows.Forms.Panel panelNastaveni;
        private System.Windows.Forms.Button buttonMenuPridaniArchivu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonMenuNastaveni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelPridaniUpravaArchivu_CoverInfo;
        private System.Windows.Forms.TextBox textBoxNastaveni_Mp3EnkoderParametry;
        private System.Windows.Forms.TextBox textBoxNastaveni_OpusEnkoderParametry;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labelNastaveni_Mp3EnkoderStav;
        private System.Windows.Forms.ComboBox comboBoxNastaveni_Mp3Enkoder;
        private System.Windows.Forms.Button buttonNastaveni_Mp3EnkoderVybrat;
        private System.Windows.Forms.TextBox textBoxNastaveni_RozbaleniParametry;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelNastaveni_RozbaleniStav;
        private System.Windows.Forms.ComboBox comboBoxNastaveni_Rozbaleni;
        private System.Windows.Forms.Button buttonNastaveni_RozbaleniVybrat;
        private System.Windows.Forms.TextBox textBoxNastaveni_AlbumArtParametry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxPridaniUpravaArchivu_ArchivHesloZobrazit;
        private System.Windows.Forms.TextBox textBoxPridaniUpravaArchivu_ArchivHeslo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonZobrazeniArchivu_PrevestNaMp3;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPrevodNaMp3;
        private System.Windows.Forms.ListView listViewStav;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panelPridaniSlozky;
        private System.Windows.Forms.ListView listViewPridaniSlozky_SeznamArchivu;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label labelPridaniSlozky_Stav;
        private System.Windows.Forms.Button buttonPridaniSlozky_PridatArchivy;
        private System.Windows.Forms.Button buttonPridaniSlozky_VybratSlozku;
        private System.Windows.Forms.ComboBox comboBoxPridaniSlozky_Slozka;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button buttonMenuPridaniSlozky;
        private System.Windows.Forms.Button buttonMenuZobrazeniArchivu;
        private System.Windows.Forms.Panel panelZobrazeniArchivu;
        private System.Windows.Forms.ListView listViewZobrazeniArchivu_SeznamArchivu;
        private System.Windows.Forms.ColumnHeader columnHeaderZobrazeniArchivu_Nazev;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.ColumnHeader columnHeaderZobrazeniArchivu_HesloSkryte;
        private System.Windows.Forms.ColumnHeader columnHeaderZobrazeniArchivu_Interpret;
        private System.Windows.Forms.ColumnHeader columnHeaderZobrazeniArchivu_Rok;
        private System.Windows.Forms.ColumnHeader columnHeaderZobrazeniArchivu_Album;
        private System.Windows.Forms.ColumnHeader columnHeaderZobrazeniArchivu_Zanr;
        private System.Windows.Forms.ColumnHeader columnHeaderZobrazeniArchivu_SlozkaOpus;
        private System.Windows.Forms.ColumnHeader columnHeaderZobrazeniArchivu_SlozkaMp3;
        private System.Windows.Forms.ColumnHeader columnHeaderZobrazeniArchivu_Cover;
        private System.Windows.Forms.ColumnHeader columnHeaderPridaniSlozky_SeznamArchivu_Cesta;
        private System.Windows.Forms.ColumnHeader columnHeaderPridaniSlozky_SeznamArchivu_Nazev;
        private System.Windows.Forms.ColumnHeader columnHeaderPridaniSlozky_SeznamArchivu_Slozka;
        private System.Windows.Forms.ColumnHeader columnHeaderPridaniSlozky_SeznamArchivu_Typ;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button buttonPridaniSlozky_NacistArchivy;
        private System.Windows.Forms.Button buttonZobrazeniArchivu_Odstranit;
        private System.Windows.Forms.Button buttonPridaniUpravaArchivu_PridatPredchozi;
        private System.Windows.Forms.Label labelPridaniSlozky_VybraneArchivy;
        private System.Windows.Forms.Button buttonMenuUpravaArchivu;
        private System.Windows.Forms.CheckBox checkBoxPridaniUpravaArchivu_UkladatAutomaticky;
        private System.Windows.Forms.Button buttonPridaniUpravaArchivu_Nasledujici;
        private System.Windows.Forms.Button buttonZobrazeniArchivu_VyberZrusit;
        private System.Windows.Forms.Button buttonZobrazeniArchivu_VyberVse;
        private System.Windows.Forms.Label labelZobrazeniArchivu_Kontrola;
        private System.Windows.Forms.CheckBox checkBoxPridaniSlozky_SmazatDrivePridane;
        private System.Windows.Forms.Label labelZobrazeniArchivu_VybraneArchivy;
        private System.Windows.Forms.ColumnHeader columnHeaderZobrazeniArchivu_Stav;
        private System.Windows.Forms.CheckBox checkBoxZobrazeniArchivu_ZobrazitSkrytHesla;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPresunDoKnihoven;
        private System.Windows.Forms.Button buttonZobrazeniArchivu_Mp3TagRozbalene;
        private System.Windows.Forms.Button buttonZobrazeniArchivu_PrevestNaOpusMp3;
        private System.Windows.Forms.TextBox textBoxPridaniUpravaArchivu_Archiv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxPridaniSlozky_NacistPodslozky;
        private System.Windows.Forms.CheckBox checkBoxNastaveni_ZobrazovatPodrobnostiStavu;
        private System.Windows.Forms.CheckBox checkBoxPridaniSlozky_odstranitNacteneArchivy;
    }
}

