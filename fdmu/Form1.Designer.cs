namespace fdmu
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_route = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.lbl_arr_time = new System.Windows.Forms.Label();
            this.lbl_dep_time = new System.Windows.Forms.Label();
            this.lbl_z_time = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_callsign = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.TabControl();
            this.init = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_callsign = new System.Windows.Forms.TextBox();
            this.button20 = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_arrival = new System.Windows.Forms.TextBox();
            this.txt_departure = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chdep = new System.Windows.Forms.TabPage();
            this.pdf_chdep = new AxAcroPDFLib.AxAcroPDF();
            this.charr = new System.Windows.Forms.TabPage();
            this.pdf_charr = new AxAcroPDFLib.AxAcroPDF();
            this.chcstm = new System.Windows.Forms.TabPage();
            this.txt_chcstm = new System.Windows.Forms.TextBox();
            this.button21 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pdf_chcstm = new AxAcroPDFLib.AxAcroPDF();
            this.loadsheet = new System.Windows.Forms.TabPage();
            this.button24 = new System.Windows.Forms.Button();
            this.pdf_loadsheet = new AxAcroPDFLib.AxAcroPDF();
            this.rtemap = new System.Windows.Forms.TabPage();
            this.vatsimtfc = new System.Windows.Forms.TabPage();
            this.webControl1 = new Awesomium.Windows.Forms.WebControl(this.components);
            this.ivaotfc = new System.Windows.Forms.TabPage();
            this.metardep = new System.Windows.Forms.TabPage();
            this.txt_metdep = new System.Windows.Forms.TextBox();
            this.metararr = new System.Windows.Forms.TabPage();
            this.txt_metarr = new System.Windows.Forms.TextBox();
            this.metarcstm = new System.Windows.Forms.TabPage();
            this.txt_metcstm_input = new System.Windows.Forms.TextBox();
            this.button23 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_metcstm = new System.Windows.Forms.TextBox();
            this.arptinfo = new System.Windows.Forms.TabPage();
            this.filefp = new System.Windows.Forms.TabPage();
            this.atis = new System.Windows.Forms.TabPage();
            this.button25 = new System.Windows.Forms.Button();
            this.txt_atis = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tmr_time = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.init.SuspendLayout();
            this.chdep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdf_chdep)).BeginInit();
            this.charr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdf_charr)).BeginInit();
            this.chcstm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdf_chcstm)).BeginInit();
            this.loadsheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdf_loadsheet)).BeginInit();
            this.vatsimtfc.SuspendLayout();
            this.metardep.SuspendLayout();
            this.metararr.SuspendLayout();
            this.metarcstm.SuspendLayout();
            this.atis.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPanel
            // 
            this.dataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dataPanel.Controls.Add(this.groupBox2);
            this.dataPanel.Controls.Add(this.button22);
            this.dataPanel.Controls.Add(this.lbl_arr_time);
            this.dataPanel.Controls.Add(this.lbl_dep_time);
            this.dataPanel.Controls.Add(this.lbl_z_time);
            this.dataPanel.Controls.Add(this.groupBox1);
            this.dataPanel.Location = new System.Drawing.Point(151, 650);
            this.dataPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(1208, 92);
            this.dataPanel.TabIndex = 1;
            this.dataPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dataPanel_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lbl_route);
            this.groupBox2.Location = new System.Drawing.Point(679, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 58);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Route";
            // 
            // lbl_route
            // 
            this.lbl_route.AutoSize = true;
            this.lbl_route.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lbl_route.Location = new System.Drawing.Point(4, 13);
            this.lbl_route.Name = "lbl_route";
            this.lbl_route.Size = new System.Drawing.Size(0, 39);
            this.lbl_route.TabIndex = 4;
            // 
            // button22
            // 
            this.button22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(1106, -12);
            this.button22.Margin = new System.Windows.Forms.Padding(0);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(99, 106);
            this.button22.TabIndex = 3;
            this.button22.Text = "X";
            this.button22.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // lbl_arr_time
            // 
            this.lbl_arr_time.AutoSize = true;
            this.lbl_arr_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arr_time.Location = new System.Drawing.Point(7, 68);
            this.lbl_arr_time.Name = "lbl_arr_time";
            this.lbl_arr_time.Size = new System.Drawing.Size(64, 20);
            this.lbl_arr_time.TabIndex = 2;
            this.lbl_arr_time.Text = "local arr";
            // 
            // lbl_dep_time
            // 
            this.lbl_dep_time.AutoSize = true;
            this.lbl_dep_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dep_time.Location = new System.Drawing.Point(7, 11);
            this.lbl_dep_time.Name = "lbl_dep_time";
            this.lbl_dep_time.Size = new System.Drawing.Size(72, 20);
            this.lbl_dep_time.TabIndex = 1;
            this.lbl_dep_time.Text = "local dep";
            // 
            // lbl_z_time
            // 
            this.lbl_z_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z_time.Location = new System.Drawing.Point(3, 28);
            this.lbl_z_time.Name = "lbl_z_time";
            this.lbl_z_time.Size = new System.Drawing.Size(155, 42);
            this.lbl_z_time.TabIndex = 0;
            this.lbl_z_time.Text = "HHmmZ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_callsign);
            this.groupBox1.Location = new System.Drawing.Point(316, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 58);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Callsign";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_callsign
            // 
            this.lbl_callsign.AutoSize = true;
            this.lbl_callsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lbl_callsign.Location = new System.Drawing.Point(4, 13);
            this.lbl_callsign.Name = "lbl_callsign";
            this.lbl_callsign.Size = new System.Drawing.Size(0, 39);
            this.lbl_callsign.TabIndex = 4;
            this.lbl_callsign.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("AirbusDisp2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 104);
            this.button1.TabIndex = 0;
            this.button1.Text = "CHANGE PAGE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("AirbusDisp2", 21.75F);
            this.button8.Location = new System.Drawing.Point(3, 1214);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(139, 102);
            this.button8.TabIndex = 6;
            this.button8.Text = "print online atis";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("AirbusDisp2", 21F);
            this.button9.Location = new System.Drawing.Point(3, 1104);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(139, 102);
            this.button9.TabIndex = 5;
            this.button9.Text = "FILE F/P";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("AirbusDisp2", 21.75F);
            this.button10.Location = new System.Drawing.Point(3, 994);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(139, 102);
            this.button10.TabIndex = 4;
            this.button10.Text = "ARPT INFO";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("AirbusDisp2", 21.75F);
            this.button11.Location = new System.Drawing.Point(3, 884);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(139, 102);
            this.button11.TabIndex = 3;
            this.button11.Text = "METAR CSTM";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("AirbusDisp2", 21.75F);
            this.button12.Location = new System.Drawing.Point(3, 774);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(139, 102);
            this.button12.TabIndex = 2;
            this.button12.Text = "METAR ARR";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("AirbusDisp2", 21.75F);
            this.button13.Location = new System.Drawing.Point(3, 664);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(139, 102);
            this.button13.TabIndex = 1;
            this.button13.Text = "METAR DEP";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("AirbusDisp2", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(3, 1874);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(139, 102);
            this.button14.TabIndex = 6;
            this.button14.Text = "SETTINGS";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("AirbusDisp2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(3, 1764);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(139, 102);
            this.button15.TabIndex = 5;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("AirbusDisp2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(3, 1654);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(139, 102);
            this.button16.TabIndex = 4;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("AirbusDisp2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(3, 1544);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(139, 102);
            this.button17.TabIndex = 3;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("AirbusDisp2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(3, 1324);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(139, 102);
            this.button18.TabIndex = 2;
            this.button18.Text = "IVAO TFC";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("AirbusDisp2", 21F);
            this.button19.Location = new System.Drawing.Point(3, 1434);
            this.button19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(139, 102);
            this.button19.TabIndex = 1;
            this.button19.Text = "VATSIM TFC";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.init);
            this.mainPanel.Controls.Add(this.chdep);
            this.mainPanel.Controls.Add(this.charr);
            this.mainPanel.Controls.Add(this.chcstm);
            this.mainPanel.Controls.Add(this.loadsheet);
            this.mainPanel.Controls.Add(this.rtemap);
            this.mainPanel.Controls.Add(this.vatsimtfc);
            this.mainPanel.Controls.Add(this.ivaotfc);
            this.mainPanel.Controls.Add(this.metardep);
            this.mainPanel.Controls.Add(this.metararr);
            this.mainPanel.Controls.Add(this.metarcstm);
            this.mainPanel.Controls.Add(this.arptinfo);
            this.mainPanel.Controls.Add(this.filefp);
            this.mainPanel.Controls.Add(this.atis);
            this.mainPanel.Location = new System.Drawing.Point(151, -35);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.SelectedIndex = 0;
            this.mainPanel.Size = new System.Drawing.Size(1212, 678);
            this.mainPanel.TabIndex = 6;
            // 
            // init
            // 
            this.init.Controls.Add(this.label4);
            this.init.Controls.Add(this.txt_callsign);
            this.init.Controls.Add(this.button20);
            this.init.Controls.Add(this.gMapControl1);
            this.init.Controls.Add(this.label3);
            this.init.Controls.Add(this.label2);
            this.init.Controls.Add(this.txt_arrival);
            this.init.Controls.Add(this.txt_departure);
            this.init.Controls.Add(this.label1);
            this.init.Location = new System.Drawing.Point(4, 22);
            this.init.Name = "init";
            this.init.Padding = new System.Windows.Forms.Padding(3);
            this.init.Size = new System.Drawing.Size(1204, 652);
            this.init.TabIndex = 0;
            this.init.Text = "init";
            this.init.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Callsign";
            // 
            // txt_callsign
            // 
            this.txt_callsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_callsign.Location = new System.Drawing.Point(7, 70);
            this.txt_callsign.MaxLength = 11;
            this.txt_callsign.Name = "txt_callsign";
            this.txt_callsign.Size = new System.Drawing.Size(278, 47);
            this.txt_callsign.TabIndex = 14;
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(553, 61);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(197, 62);
            this.button20.TabIndex = 13;
            this.button20.Text = "Sync Data";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click_2);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(3, 129);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 3;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1198, 520);
            this.gMapControl1.TabIndex = 12;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(771, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Arrival";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Departure";
            // 
            // txt_arrival
            // 
            this.txt_arrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_arrival.Location = new System.Drawing.Point(776, 61);
            this.txt_arrival.MaxLength = 4;
            this.txt_arrival.Name = "txt_arrival";
            this.txt_arrival.Size = new System.Drawing.Size(183, 62);
            this.txt_arrival.TabIndex = 9;
            this.txt_arrival.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_departure
            // 
            this.txt_departure.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_departure.Location = new System.Drawing.Point(343, 61);
            this.txt_departure.MaxLength = 4;
            this.txt_departure.Name = "txt_departure";
            this.txt_departure.Size = new System.Drawing.Size(183, 62);
            this.txt_departure.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-23, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10459, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // chdep
            // 
            this.chdep.Controls.Add(this.pdf_chdep);
            this.chdep.Location = new System.Drawing.Point(4, 22);
            this.chdep.Name = "chdep";
            this.chdep.Padding = new System.Windows.Forms.Padding(3);
            this.chdep.Size = new System.Drawing.Size(1204, 652);
            this.chdep.TabIndex = 1;
            this.chdep.UseVisualStyleBackColor = true;
            // 
            // pdf_chdep
            // 
            this.pdf_chdep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdf_chdep.Enabled = true;
            this.pdf_chdep.Location = new System.Drawing.Point(3, 19);
            this.pdf_chdep.Name = "pdf_chdep";
            this.pdf_chdep.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdf_chdep.OcxState")));
            this.pdf_chdep.Size = new System.Drawing.Size(1198, 649);
            this.pdf_chdep.TabIndex = 0;
            // 
            // charr
            // 
            this.charr.Controls.Add(this.pdf_charr);
            this.charr.Location = new System.Drawing.Point(4, 22);
            this.charr.Name = "charr";
            this.charr.Size = new System.Drawing.Size(1204, 652);
            this.charr.TabIndex = 2;
            this.charr.Text = "tabPage1";
            this.charr.UseVisualStyleBackColor = true;
            // 
            // pdf_charr
            // 
            this.pdf_charr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdf_charr.Enabled = true;
            this.pdf_charr.Location = new System.Drawing.Point(3, 18);
            this.pdf_charr.Name = "pdf_charr";
            this.pdf_charr.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdf_charr.OcxState")));
            this.pdf_charr.Size = new System.Drawing.Size(1198, 649);
            this.pdf_charr.TabIndex = 1;
            // 
            // chcstm
            // 
            this.chcstm.Controls.Add(this.txt_chcstm);
            this.chcstm.Controls.Add(this.button21);
            this.chcstm.Controls.Add(this.label5);
            this.chcstm.Controls.Add(this.pdf_chcstm);
            this.chcstm.Location = new System.Drawing.Point(4, 22);
            this.chcstm.Name = "chcstm";
            this.chcstm.Size = new System.Drawing.Size(1204, 652);
            this.chcstm.TabIndex = 3;
            this.chcstm.Text = "tabPage1";
            this.chcstm.UseVisualStyleBackColor = true;
            // 
            // txt_chcstm
            // 
            this.txt_chcstm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_chcstm.Location = new System.Drawing.Point(397, 19);
            this.txt_chcstm.MaxLength = 4;
            this.txt_chcstm.Name = "txt_chcstm";
            this.txt_chcstm.Size = new System.Drawing.Size(131, 20);
            this.txt_chcstm.TabIndex = 4;
            // 
            // button21
            // 
            this.button21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button21.Location = new System.Drawing.Point(534, 18);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(340, 23);
            this.button21.TabIndex = 3;
            this.button21.Text = "Load custom charts";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "ICAO:";
            // 
            // pdf_chcstm
            // 
            this.pdf_chcstm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdf_chcstm.Enabled = true;
            this.pdf_chcstm.Location = new System.Drawing.Point(3, 48);
            this.pdf_chcstm.Name = "pdf_chcstm";
            this.pdf_chcstm.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdf_chcstm.OcxState")));
            this.pdf_chcstm.Size = new System.Drawing.Size(1198, 619);
            this.pdf_chcstm.TabIndex = 2;
            // 
            // loadsheet
            // 
            this.loadsheet.Controls.Add(this.button24);
            this.loadsheet.Controls.Add(this.pdf_loadsheet);
            this.loadsheet.Location = new System.Drawing.Point(4, 22);
            this.loadsheet.Name = "loadsheet";
            this.loadsheet.Size = new System.Drawing.Size(1204, 652);
            this.loadsheet.TabIndex = 4;
            this.loadsheet.Text = "rtefind";
            this.loadsheet.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button24.Location = new System.Drawing.Point(430, 18);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(340, 23);
            this.button24.TabIndex = 7;
            this.button24.Text = "Load loadsheet and flightplan PDF";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // pdf_loadsheet
            // 
            this.pdf_loadsheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdf_loadsheet.Enabled = true;
            this.pdf_loadsheet.Location = new System.Drawing.Point(3, 47);
            this.pdf_loadsheet.Name = "pdf_loadsheet";
            this.pdf_loadsheet.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdf_loadsheet.OcxState")));
            this.pdf_loadsheet.Size = new System.Drawing.Size(1198, 619);
            this.pdf_loadsheet.TabIndex = 6;
            // 
            // rtemap
            // 
            this.rtemap.Location = new System.Drawing.Point(4, 22);
            this.rtemap.Name = "rtemap";
            this.rtemap.Size = new System.Drawing.Size(1204, 652);
            this.rtemap.TabIndex = 6;
            this.rtemap.Text = "tabPage3";
            this.rtemap.UseVisualStyleBackColor = true;
            // 
            // vatsimtfc
            // 
            this.vatsimtfc.Controls.Add(this.webControl1);
            this.vatsimtfc.Location = new System.Drawing.Point(4, 22);
            this.vatsimtfc.Name = "vatsimtfc";
            this.vatsimtfc.Size = new System.Drawing.Size(1204, 652);
            this.vatsimtfc.TabIndex = 5;
            this.vatsimtfc.Text = "b";
            this.vatsimtfc.UseVisualStyleBackColor = true;
            // 
            // webControl1
            // 
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(0, 0);
            this.webControl1.Size = new System.Drawing.Size(1204, 652);
            this.webControl1.Source = new System.Uri("https://accumap-project.com/", System.UriKind.Absolute);
            this.webControl1.TabIndex = 0;
            this.webControl1.ShowCreatedWebView += new Awesomium.Core.ShowCreatedWebViewEventHandler(this.Awesomium_Windows_Forms_WebControl_ShowCreatedWebView);
            // 
            // ivaotfc
            // 
            this.ivaotfc.Location = new System.Drawing.Point(4, 22);
            this.ivaotfc.Name = "ivaotfc";
            this.ivaotfc.Size = new System.Drawing.Size(1204, 652);
            this.ivaotfc.TabIndex = 7;
            this.ivaotfc.Text = "tabPage4";
            this.ivaotfc.UseVisualStyleBackColor = true;
            // 
            // metardep
            // 
            this.metardep.Controls.Add(this.txt_metdep);
            this.metardep.Location = new System.Drawing.Point(4, 22);
            this.metardep.Name = "metardep";
            this.metardep.Size = new System.Drawing.Size(1204, 652);
            this.metardep.TabIndex = 8;
            this.metardep.Text = "tabPage5";
            this.metardep.UseVisualStyleBackColor = true;
            // 
            // txt_metdep
            // 
            this.txt_metdep.Enabled = false;
            this.txt_metdep.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_metdep.Location = new System.Drawing.Point(3, 19);
            this.txt_metdep.Multiline = true;
            this.txt_metdep.Name = "txt_metdep";
            this.txt_metdep.Size = new System.Drawing.Size(1198, 648);
            this.txt_metdep.TabIndex = 0;
            // 
            // metararr
            // 
            this.metararr.Controls.Add(this.txt_metarr);
            this.metararr.Location = new System.Drawing.Point(4, 22);
            this.metararr.Name = "metararr";
            this.metararr.Size = new System.Drawing.Size(1204, 652);
            this.metararr.TabIndex = 9;
            this.metararr.Text = "tabPage1";
            this.metararr.UseVisualStyleBackColor = true;
            // 
            // txt_metarr
            // 
            this.txt_metarr.Enabled = false;
            this.txt_metarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_metarr.Location = new System.Drawing.Point(3, 18);
            this.txt_metarr.Multiline = true;
            this.txt_metarr.Name = "txt_metarr";
            this.txt_metarr.Size = new System.Drawing.Size(1198, 648);
            this.txt_metarr.TabIndex = 1;
            // 
            // metarcstm
            // 
            this.metarcstm.Controls.Add(this.txt_metcstm_input);
            this.metarcstm.Controls.Add(this.button23);
            this.metarcstm.Controls.Add(this.label6);
            this.metarcstm.Controls.Add(this.txt_metcstm);
            this.metarcstm.Location = new System.Drawing.Point(4, 22);
            this.metarcstm.Name = "metarcstm";
            this.metarcstm.Size = new System.Drawing.Size(1204, 652);
            this.metarcstm.TabIndex = 10;
            this.metarcstm.Text = "tabPage1";
            this.metarcstm.UseVisualStyleBackColor = true;
            // 
            // txt_metcstm_input
            // 
            this.txt_metcstm_input.Location = new System.Drawing.Point(386, 18);
            this.txt_metcstm_input.MaxLength = 4;
            this.txt_metcstm_input.Name = "txt_metcstm_input";
            this.txt_metcstm_input.Size = new System.Drawing.Size(131, 20);
            this.txt_metcstm_input.TabIndex = 7;
            this.txt_metcstm_input.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(523, 17);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(340, 23);
            this.button23.TabIndex = 6;
            this.button23.Text = "Load custom metar";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(342, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "ICAO:";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // txt_metcstm
            // 
            this.txt_metcstm.Enabled = false;
            this.txt_metcstm.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_metcstm.Location = new System.Drawing.Point(3, 44);
            this.txt_metcstm.Multiline = true;
            this.txt_metcstm.Name = "txt_metcstm";
            this.txt_metcstm.Size = new System.Drawing.Size(1198, 622);
            this.txt_metcstm.TabIndex = 1;
            // 
            // arptinfo
            // 
            this.arptinfo.Location = new System.Drawing.Point(4, 22);
            this.arptinfo.Name = "arptinfo";
            this.arptinfo.Size = new System.Drawing.Size(1204, 652);
            this.arptinfo.TabIndex = 11;
            this.arptinfo.Text = "arptinfo";
            this.arptinfo.UseVisualStyleBackColor = true;
            // 
            // filefp
            // 
            this.filefp.Location = new System.Drawing.Point(4, 22);
            this.filefp.Name = "filefp";
            this.filefp.Size = new System.Drawing.Size(1204, 652);
            this.filefp.TabIndex = 12;
            this.filefp.Text = "filefp";
            this.filefp.UseVisualStyleBackColor = true;
            // 
            // atis
            // 
            this.atis.Controls.Add(this.button25);
            this.atis.Controls.Add(this.txt_atis);
            this.atis.Controls.Add(this.comboBox1);
            this.atis.Location = new System.Drawing.Point(4, 22);
            this.atis.Name = "atis";
            this.atis.Size = new System.Drawing.Size(1204, 652);
            this.atis.TabIndex = 13;
            this.atis.Text = "tabPage1";
            this.atis.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button25.Font = new System.Drawing.Font("AirbusDisp2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(271, 546);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(247, 117);
            this.button25.TabIndex = 2;
            this.button25.Text = "check and Print";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.Button25_Click);
            // 
            // txt_atis
            // 
            this.txt_atis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_atis.Font = new System.Drawing.Font("AirbusDisp2", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_atis.Location = new System.Drawing.Point(271, 19);
            this.txt_atis.Multiline = true;
            this.txt_atis.Name = "txt_atis";
            this.txt_atis.Size = new System.Drawing.Size(928, 521);
            this.txt_atis.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.Font = new System.Drawing.Font("AirbusDisp2", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 644);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // tmr_time
            // 
            this.tmr_time.Enabled = true;
            this.tmr_time.Interval = 1000;
            this.tmr_time.Tick += new System.EventHandler(this.tmr_time_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
            this.openFileDialog1.Title = "Open loadsheet and flightplan PDF file";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button13);
            this.flowLayoutPanel1.Controls.Add(this.button12);
            this.flowLayoutPanel1.Controls.Add(this.button11);
            this.flowLayoutPanel1.Controls.Add(this.button10);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button18);
            this.flowLayoutPanel1.Controls.Add(this.button19);
            this.flowLayoutPanel1.Controls.Add(this.button17);
            this.flowLayoutPanel1.Controls.Add(this.button16);
            this.flowLayoutPanel1.Controls.Add(this.button15);
            this.flowLayoutPanel1.Controls.Add(this.button14);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 113);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(179, 629);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("AirbusDisp2", 21.75F);
            this.button2.Location = new System.Drawing.Point(3, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 102);
            this.button2.TabIndex = 1;
            this.button2.Text = "INIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("AirbusDisp2", 21.75F);
            this.button3.Location = new System.Drawing.Point(3, 114);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 102);
            this.button3.TabIndex = 2;
            this.button3.Text = "CHARTS DEP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("AirbusDisp2", 21.75F);
            this.button4.Location = new System.Drawing.Point(3, 224);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 102);
            this.button4.TabIndex = 3;
            this.button4.Text = "CHARTS ARR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("AirbusDisp2", 21.75F);
            this.button5.Location = new System.Drawing.Point(3, 334);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 102);
            this.button5.TabIndex = 4;
            this.button5.Text = "CHARTS CSTM";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("AirbusDisp2", 21.75F);
            this.button6.Location = new System.Drawing.Point(3, 444);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 102);
            this.button6.TabIndex = 5;
            this.button6.Text = "RTE, LOAD- SHEET";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("AirbusDisp2", 21.75F);
            this.button7.Location = new System.Drawing.Point(3, 554);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 102);
            this.button7.TabIndex = 6;
            this.button7.Text = "RTE MAP";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Form1";
            this.Text = "FPCCVU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.init.ResumeLayout(false);
            this.init.PerformLayout();
            this.chdep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdf_chdep)).EndInit();
            this.charr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdf_charr)).EndInit();
            this.chcstm.ResumeLayout(false);
            this.chcstm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdf_chcstm)).EndInit();
            this.loadsheet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdf_loadsheet)).EndInit();
            this.vatsimtfc.ResumeLayout(false);
            this.metardep.ResumeLayout(false);
            this.metardep.PerformLayout();
            this.metararr.ResumeLayout(false);
            this.metararr.PerformLayout();
            this.metarcstm.ResumeLayout(false);
            this.metarcstm.PerformLayout();
            this.atis.ResumeLayout(false);
            this.atis.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TabControl mainPanel;
        private System.Windows.Forms.TabPage init;
        private System.Windows.Forms.TabPage chdep;
        private System.Windows.Forms.TabPage charr;
        private System.Windows.Forms.TabPage chcstm;
        private System.Windows.Forms.TabPage loadsheet;
        private System.Windows.Forms.TabPage rtemap;
        private System.Windows.Forms.TabPage vatsimtfc;
        private System.Windows.Forms.TabPage ivaotfc;
        private System.Windows.Forms.TabPage metardep;
        private System.Windows.Forms.TabPage metararr;
        private System.Windows.Forms.TabPage metarcstm;
        private System.Windows.Forms.TabPage arptinfo;
        private System.Windows.Forms.TabPage filefp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_departure;
        private System.Windows.Forms.TextBox txt_arrival;
        private System.Windows.Forms.Button button20;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private AxAcroPDFLib.AxAcroPDF pdf_chdep;
        private AxAcroPDFLib.AxAcroPDF pdf_charr;
        private System.Windows.Forms.Label lbl_z_time;
        private AxAcroPDFLib.AxAcroPDF pdf_chcstm;
        private System.Windows.Forms.TextBox txt_chcstm;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmr_time;
        private System.Windows.Forms.Label lbl_arr_time;
        private System.Windows.Forms.Label lbl_dep_time;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_callsign;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_callsign;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_route;
        private System.Windows.Forms.TextBox txt_metdep;
        private System.Windows.Forms.TextBox txt_metarr;
        private System.Windows.Forms.TextBox txt_metcstm_input;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_metcstm;
        private System.Windows.Forms.Button button24;
        private AxAcroPDFLib.AxAcroPDF pdf_loadsheet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Awesomium.Windows.Forms.WebControl webControl1;
        private System.Windows.Forms.TabPage atis;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.TextBox txt_atis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

