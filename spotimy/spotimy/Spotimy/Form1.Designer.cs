using System;

namespace media_player
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.pnlDragkontrol = new System.Windows.Forms.Panel();
            this.btnGenisekran = new ns1.BunifuFlatButton();
            this.btnKucult = new ns1.BunifuFlatButton();
            this.lblSpotimy = new ns1.BunifuCustomLabel();
            this.bunifuImageButton10 = new ns1.BunifuImageButton();
            this.btnExit = new ns1.BunifuFlatButton();
            this.pnlAlt = new ns1.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbarSes = new ns1.BunifuTrackbar();
            this.lblZaman2 = new ns1.BunifuCustomLabel();
            this.lblZaman1 = new ns1.BunifuCustomLabel();
            this.lblSarkiadi = new ns1.BunifuCustomLabel();
            this.pBarMedya = new ns1.BunifuProgressBar();
            this.btnGorsel = new ns1.BunifuImageButton();
            this.btnSes = new ns1.BunifuImageButton();
            this.btnGeri = new ns1.BunifuImageButton();
            this.btnIleri = new ns1.BunifuImageButton();
            this.btnPlay = new ns1.BunifuImageButton();
            this.btnPause = new ns1.BunifuImageButton();
            this.btnSeskapat = new ns1.BunifuImageButton();
            this.pnlSol = new ns1.BunifuGradientPanel();
            this.btnDosyaekle = new ns1.BunifuImageButton();
            this.pnlSol2 = new ns1.BunifuGradientPanel();
            this.lbOynatmaListesi = new System.Windows.Forms.ListBox();
            this.btnOynatmaListesi = new ns1.BunifuFlatButton();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlDragkontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).BeginInit();
            this.pnlAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGorsel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeskapat)).BeginInit();
            this.pnlSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDosyaekle)).BeginInit();
            this.pnlSol2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlDragkontrol
            // 
            this.pnlDragkontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlDragkontrol.Controls.Add(this.btnGenisekran);
            this.pnlDragkontrol.Controls.Add(this.btnKucult);
            this.pnlDragkontrol.Controls.Add(this.lblSpotimy);
            this.pnlDragkontrol.Controls.Add(this.bunifuImageButton10);
            this.pnlDragkontrol.Controls.Add(this.btnExit);
            this.pnlDragkontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDragkontrol.Location = new System.Drawing.Point(0, 0);
            this.pnlDragkontrol.Name = "pnlDragkontrol";
            this.pnlDragkontrol.Size = new System.Drawing.Size(1313, 94);
            this.pnlDragkontrol.TabIndex = 0;
            // 
            // btnGenisekran
            // 
            this.btnGenisekran.Activecolor = System.Drawing.Color.Transparent;
            this.btnGenisekran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenisekran.BackColor = System.Drawing.Color.Transparent;
            this.btnGenisekran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenisekran.BorderRadius = 0;
            this.btnGenisekran.ButtonText = "□";
            this.btnGenisekran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenisekran.DisabledColor = System.Drawing.Color.Gray;
            this.btnGenisekran.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenisekran.Iconimage = null;
            this.btnGenisekran.Iconimage_right = null;
            this.btnGenisekran.Iconimage_right_Selected = null;
            this.btnGenisekran.Iconimage_Selected = null;
            this.btnGenisekran.IconMarginLeft = 0;
            this.btnGenisekran.IconMarginRight = 0;
            this.btnGenisekran.IconRightVisible = true;
            this.btnGenisekran.IconRightZoom = 0D;
            this.btnGenisekran.IconVisible = true;
            this.btnGenisekran.IconZoom = 90D;
            this.btnGenisekran.IsTab = false;
            this.btnGenisekran.Location = new System.Drawing.Point(1238, 0);
            this.btnGenisekran.Name = "btnGenisekran";
            this.btnGenisekran.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGenisekran.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnGenisekran.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGenisekran.selected = false;
            this.btnGenisekran.Size = new System.Drawing.Size(33, 29);
            this.btnGenisekran.TabIndex = 21;
            this.btnGenisekran.Text = "□";
            this.btnGenisekran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenisekran.Textcolor = System.Drawing.Color.White;
            this.btnGenisekran.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenisekran.Click += new System.EventHandler(this.btnGenisekran_Click);
            // 
            // btnKucult
            // 
            this.btnKucult.Activecolor = System.Drawing.Color.DimGray;
            this.btnKucult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKucult.BackColor = System.Drawing.Color.Transparent;
            this.btnKucult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKucult.BorderRadius = 0;
            this.btnKucult.ButtonText = "–";
            this.btnKucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKucult.DisabledColor = System.Drawing.Color.Gray;
            this.btnKucult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKucult.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKucult.Iconimage = null;
            this.btnKucult.Iconimage_right = null;
            this.btnKucult.Iconimage_right_Selected = null;
            this.btnKucult.Iconimage_Selected = null;
            this.btnKucult.IconMarginLeft = 0;
            this.btnKucult.IconMarginRight = 0;
            this.btnKucult.IconRightVisible = true;
            this.btnKucult.IconRightZoom = 0D;
            this.btnKucult.IconVisible = true;
            this.btnKucult.IconZoom = 90D;
            this.btnKucult.IsTab = false;
            this.btnKucult.Location = new System.Drawing.Point(1197, 0);
            this.btnKucult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Normalcolor = System.Drawing.Color.Transparent;
            this.btnKucult.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnKucult.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKucult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKucult.selected = false;
            this.btnKucult.Size = new System.Drawing.Size(37, 29);
            this.btnKucult.TabIndex = 3;
            this.btnKucult.Text = "–";
            this.btnKucult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKucult.Textcolor = System.Drawing.Color.White;
            this.btnKucult.TextFont = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // lblSpotimy
            // 
            this.lblSpotimy.AutoSize = true;
            this.lblSpotimy.BackColor = System.Drawing.Color.Transparent;
            this.lblSpotimy.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSpotimy.ForeColor = System.Drawing.Color.White;
            this.lblSpotimy.Location = new System.Drawing.Point(102, 38);
            this.lblSpotimy.Name = "lblSpotimy";
            this.lblSpotimy.Size = new System.Drawing.Size(107, 34);
            this.lblSpotimy.TabIndex = 2;
            this.lblSpotimy.Text = "Spotimy";
            // 
            // bunifuImageButton10
            // 
            this.bunifuImageButton10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton10.Enabled = false;
            this.bunifuImageButton10.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton10.Image")));
            this.bunifuImageButton10.ImageActive = null;
            this.bunifuImageButton10.Location = new System.Drawing.Point(23, 25);
            this.bunifuImageButton10.Name = "bunifuImageButton10";
            this.bunifuImageButton10.Size = new System.Drawing.Size(48, 46);
            this.bunifuImageButton10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton10.TabIndex = 1;
            this.bunifuImageButton10.TabStop = false;
            this.bunifuImageButton10.Zoom = 10;
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "x";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = null;
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 90D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(1274, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnExit.OnHovercolor = System.Drawing.Color.Red;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(39, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "x";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.White;
            this.btnExit.TextFont = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAlt.BackgroundImage")));
            this.pnlAlt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAlt.Controls.Add(this.label1);
            this.pnlAlt.Controls.Add(this.tbarSes);
            this.pnlAlt.Controls.Add(this.lblZaman2);
            this.pnlAlt.Controls.Add(this.lblZaman1);
            this.pnlAlt.Controls.Add(this.lblSarkiadi);
            this.pnlAlt.Controls.Add(this.pBarMedya);
            this.pnlAlt.Controls.Add(this.btnGorsel);
            this.pnlAlt.Controls.Add(this.btnSes);
            this.pnlAlt.Controls.Add(this.btnGeri);
            this.pnlAlt.Controls.Add(this.btnIleri);
            this.pnlAlt.Controls.Add(this.btnPlay);
            this.pnlAlt.Controls.Add(this.btnPause);
            this.pnlAlt.Controls.Add(this.btnSeskapat);
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(100)))));
            this.pnlAlt.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlAlt.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlAlt.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlAlt.Location = new System.Drawing.Point(0, 639);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Quality = 10;
            this.pnlAlt.Size = new System.Drawing.Size(1313, 91);
            this.pnlAlt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(83, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 19;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbarSes
            // 
            this.tbarSes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarSes.BackColor = System.Drawing.Color.Transparent;
            this.tbarSes.BackgroudColor = System.Drawing.Color.DarkGray;
            this.tbarSes.BorderRadius = 6;
            this.tbarSes.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(100)))));
            this.tbarSes.Location = new System.Drawing.Point(1144, 29);
            this.tbarSes.MaximumValue = 100;
            this.tbarSes.Name = "tbarSes";
            this.tbarSes.Size = new System.Drawing.Size(121, 30);
            this.tbarSes.SliderRadius = 100;
            this.tbarSes.TabIndex = 17;
            this.tbarSes.Value = 20;
            this.tbarSes.ValueChanged += new System.EventHandler(this.tbarSes_ValueChanged);
            // 
            // lblZaman2
            // 
            this.lblZaman2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblZaman2.AutoSize = true;
            this.lblZaman2.BackColor = System.Drawing.Color.Transparent;
            this.lblZaman2.ForeColor = System.Drawing.Color.White;
            this.lblZaman2.Location = new System.Drawing.Point(878, 66);
            this.lblZaman2.Name = "lblZaman2";
            this.lblZaman2.Size = new System.Drawing.Size(34, 13);
            this.lblZaman2.TabIndex = 16;
            this.lblZaman2.Text = "00:00";
            // 
            // lblZaman1
            // 
            this.lblZaman1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblZaman1.AutoSize = true;
            this.lblZaman1.BackColor = System.Drawing.Color.Transparent;
            this.lblZaman1.ForeColor = System.Drawing.Color.White;
            this.lblZaman1.Location = new System.Drawing.Point(465, 66);
            this.lblZaman1.Name = "lblZaman1";
            this.lblZaman1.Size = new System.Drawing.Size(34, 13);
            this.lblZaman1.TabIndex = 15;
            this.lblZaman1.Text = "00:00";
            // 
            // lblSarkiadi
            // 
            this.lblSarkiadi.AutoSize = true;
            this.lblSarkiadi.BackColor = System.Drawing.Color.Transparent;
            this.lblSarkiadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSarkiadi.ForeColor = System.Drawing.Color.White;
            this.lblSarkiadi.Location = new System.Drawing.Point(97, 43);
            this.lblSarkiadi.Name = "lblSarkiadi";
            this.lblSarkiadi.Size = new System.Drawing.Size(0, 16);
            this.lblSarkiadi.TabIndex = 14;
            // 
            // pBarMedya
            // 
            this.pBarMedya.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pBarMedya.BackColor = System.Drawing.Color.Silver;
            this.pBarMedya.BorderRadius = 5;
            this.pBarMedya.Location = new System.Drawing.Point(503, 69);
            this.pBarMedya.MaximumValue = 100;
            this.pBarMedya.Name = "pBarMedya";
            this.pBarMedya.ProgressColor = System.Drawing.Color.Gray;
            this.pBarMedya.Size = new System.Drawing.Size(372, 10);
            this.pBarMedya.TabIndex = 11;
            this.pBarMedya.Value = 0;
            this.pBarMedya.progressChanged += new System.EventHandler(this.pBarMedya_progressChanged);
            // 
            // btnGorsel
            // 
            this.btnGorsel.BackColor = System.Drawing.Color.Transparent;
            this.btnGorsel.Enabled = false;
            this.btnGorsel.ErrorImage = null;
            this.btnGorsel.Image = ((System.Drawing.Image)(resources.GetObject("btnGorsel.Image")));
            this.btnGorsel.ImageActive = null;
            this.btnGorsel.InitialImage = null;
            this.btnGorsel.Location = new System.Drawing.Point(23, 18);
            this.btnGorsel.Name = "btnGorsel";
            this.btnGorsel.Size = new System.Drawing.Size(48, 46);
            this.btnGorsel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGorsel.TabIndex = 9;
            this.btnGorsel.TabStop = false;
            this.btnGorsel.Zoom = 10;
            // 
            // btnSes
            // 
            this.btnSes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSes.BackColor = System.Drawing.Color.Transparent;
            this.btnSes.Image = ((System.Drawing.Image)(resources.GetObject("btnSes.Image")));
            this.btnSes.ImageActive = null;
            this.btnSes.Location = new System.Drawing.Point(1115, 27);
            this.btnSes.Name = "btnSes";
            this.btnSes.Size = new System.Drawing.Size(23, 27);
            this.btnSes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSes.TabIndex = 5;
            this.btnSes.TabStop = false;
            this.btnSes.Zoom = 10;
            this.btnSes.Click += new System.EventHandler(this.btnSes_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.ImageActive = null;
            this.btnGeri.Location = new System.Drawing.Point(634, 27);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(23, 27);
            this.btnGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGeri.TabIndex = 2;
            this.btnGeri.TabStop = false;
            this.btnGeri.Zoom = 10;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnIleri
            // 
            this.btnIleri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIleri.BackColor = System.Drawing.Color.Transparent;
            this.btnIleri.Image = ((System.Drawing.Image)(resources.GetObject("btnIleri.Image")));
            this.btnIleri.ImageActive = null;
            this.btnIleri.Location = new System.Drawing.Point(712, 27);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(23, 27);
            this.btnIleri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnIleri.TabIndex = 1;
            this.btnIleri.TabStop = false;
            this.btnIleri.Zoom = 10;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageActive = null;
            this.btnPlay.Location = new System.Drawing.Point(672, 27);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(23, 27);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Zoom = 10;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageActive = null;
            this.btnPause.Location = new System.Drawing.Point(672, 27);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(23, 27);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPause.TabIndex = 7;
            this.btnPause.TabStop = false;
            this.btnPause.Zoom = 10;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSeskapat
            // 
            this.btnSeskapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeskapat.BackColor = System.Drawing.Color.Transparent;
            this.btnSeskapat.Image = ((System.Drawing.Image)(resources.GetObject("btnSeskapat.Image")));
            this.btnSeskapat.ImageActive = null;
            this.btnSeskapat.Location = new System.Drawing.Point(1115, 27);
            this.btnSeskapat.Name = "btnSeskapat";
            this.btnSeskapat.Size = new System.Drawing.Size(23, 27);
            this.btnSeskapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSeskapat.TabIndex = 18;
            this.btnSeskapat.TabStop = false;
            this.btnSeskapat.Zoom = 10;
            this.btnSeskapat.Click += new System.EventHandler(this.btnSeskapat_Click);
            // 
            // pnlSol
            // 
            this.pnlSol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSol.BackgroundImage")));
            this.pnlSol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSol.Controls.Add(this.btnDosyaekle);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(100)))));
            this.pnlSol.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlSol.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlSol.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlSol.Location = new System.Drawing.Point(0, 94);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Quality = 10;
            this.pnlSol.Size = new System.Drawing.Size(86, 545);
            this.pnlSol.TabIndex = 2;
            // 
            // btnDosyaekle
            // 
            this.btnDosyaekle.BackColor = System.Drawing.Color.Transparent;
            this.btnDosyaekle.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaekle.Image")));
            this.btnDosyaekle.ImageActive = null;
            this.btnDosyaekle.Location = new System.Drawing.Point(23, 18);
            this.btnDosyaekle.Name = "btnDosyaekle";
            this.btnDosyaekle.Size = new System.Drawing.Size(48, 46);
            this.btnDosyaekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDosyaekle.TabIndex = 15;
            this.btnDosyaekle.TabStop = false;
            this.btnDosyaekle.Zoom = 10;
            this.btnDosyaekle.Click += new System.EventHandler(this.btnDosyaekle_Click);
            // 
            // pnlSol2
            // 
            this.pnlSol2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSol2.BackgroundImage")));
            this.pnlSol2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSol2.Controls.Add(this.lbOynatmaListesi);
            this.pnlSol2.Controls.Add(this.btnOynatmaListesi);
            this.pnlSol2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlSol2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlSol2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlSol2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlSol2.Location = new System.Drawing.Point(86, 94);
            this.pnlSol2.Name = "pnlSol2";
            this.pnlSol2.Quality = 10;
            this.pnlSol2.Size = new System.Drawing.Size(245, 545);
            this.pnlSol2.TabIndex = 3;
            // 
            // lbOynatmaListesi
            // 
            this.lbOynatmaListesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lbOynatmaListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbOynatmaListesi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbOynatmaListesi.ForeColor = System.Drawing.Color.White;
            this.lbOynatmaListesi.FormattingEnabled = true;
            this.lbOynatmaListesi.ItemHeight = 17;
            this.lbOynatmaListesi.Location = new System.Drawing.Point(0, 83);
            this.lbOynatmaListesi.Name = "lbOynatmaListesi";
            this.lbOynatmaListesi.Size = new System.Drawing.Size(245, 442);
            this.lbOynatmaListesi.TabIndex = 3;
            this.lbOynatmaListesi.SelectedIndexChanged += new System.EventHandler(this.lbOynatmaListesi_SelectedIndexChanged);
            // 
            // btnOynatmaListesi
            // 
            this.btnOynatmaListesi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOynatmaListesi.BackColor = System.Drawing.Color.Transparent;
            this.btnOynatmaListesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOynatmaListesi.BorderRadius = 0;
            this.btnOynatmaListesi.ButtonText = "Oynatma Listesi";
            this.btnOynatmaListesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOynatmaListesi.DisabledColor = System.Drawing.Color.Gray;
            this.btnOynatmaListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOynatmaListesi.ForeColor = System.Drawing.Color.White;
            this.btnOynatmaListesi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOynatmaListesi.Iconimage = null;
            this.btnOynatmaListesi.Iconimage_right = null;
            this.btnOynatmaListesi.Iconimage_right_Selected = null;
            this.btnOynatmaListesi.Iconimage_Selected = null;
            this.btnOynatmaListesi.IconMarginLeft = 0;
            this.btnOynatmaListesi.IconMarginRight = 0;
            this.btnOynatmaListesi.IconRightVisible = true;
            this.btnOynatmaListesi.IconRightZoom = 0D;
            this.btnOynatmaListesi.IconVisible = true;
            this.btnOynatmaListesi.IconZoom = 90D;
            this.btnOynatmaListesi.IsTab = false;
            this.btnOynatmaListesi.Location = new System.Drawing.Point(0, 0);
            this.btnOynatmaListesi.Name = "btnOynatmaListesi";
            this.btnOynatmaListesi.Normalcolor = System.Drawing.Color.Transparent;
            this.btnOynatmaListesi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOynatmaListesi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOynatmaListesi.selected = false;
            this.btnOynatmaListesi.Size = new System.Drawing.Size(245, 74);
            this.btnOynatmaListesi.TabIndex = 0;
            this.btnOynatmaListesi.Text = "Oynatma Listesi";
            this.btnOynatmaListesi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOynatmaListesi.Textcolor = System.Drawing.Color.White;
            this.btnOynatmaListesi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOynatmaListesi.Click += new System.EventHandler(this.btnOynatmaListesi_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlDragkontrol;
            this.bunifuDragControl1.Vertical = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(330, 94);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(983, 545);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 730);
            this.Controls.Add(this.pnlSol2);
            this.Controls.Add(this.pnlSol);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlDragkontrol);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlDragkontrol.ResumeLayout(false);
            this.pnlDragkontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).EndInit();
            this.pnlAlt.ResumeLayout(false);
            this.pnlAlt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGorsel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeskapat)).EndInit();
            this.pnlSol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDosyaekle)).EndInit();
            this.pnlSol2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuGradientPanel pnlSol2;
        private ns1.BunifuGradientPanel pnlSol;
        private ns1.BunifuGradientPanel pnlAlt;
        private System.Windows.Forms.Panel pnlDragkontrol;
        private ns1.BunifuFlatButton btnExit;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ns1.BunifuImageButton btnGeri;
        private ns1.BunifuImageButton btnIleri;
        private ns1.BunifuImageButton btnPlay;
        private ns1.BunifuImageButton btnSes;
        private ns1.BunifuImageButton btnPause;
        private ns1.BunifuCustomLabel lblSarkiadi;
        private ns1.BunifuProgressBar pBarMedya;
        private ns1.BunifuImageButton btnGorsel;
        private ns1.BunifuCustomLabel lblSpotimy;
        private ns1.BunifuImageButton bunifuImageButton10;
        private ns1.BunifuFlatButton btnOynatmaListesi;
        private ns1.BunifuImageButton btnDosyaekle;
        private ns1.BunifuCustomLabel lblZaman2;
        private ns1.BunifuCustomLabel lblZaman1;
        private System.Windows.Forms.ListBox lbOynatmaListesi;
        private ns1.BunifuTrackbar tbarSes;
        private ns1.BunifuFlatButton btnKucult;
        private ns1.BunifuImageButton btnSeskapat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuFlatButton btnGenisekran;
    }
}

