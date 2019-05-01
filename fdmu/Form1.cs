using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using TimeZoneConverter;


using static addons.FlightData;
using Awesomium.Core;
using System.Drawing.Printing;
using System.Linq;

namespace fdmu
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            if (Screen.PrimaryScreen.Bounds.Width == 1366 && Screen.PrimaryScreen.Bounds.Height == 768)
            {
                this.FormBorderStyle = FormBorderStyle.None;

            }
            globalCfg.printFlag = false;
            globalCfg.selFunction = 0;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            tmr_time.Start();
        }

        #region Declarations

        private Deparr[] fdata = new Deparr[2];          //todo: fdata: 0 - dep, 1 - arr
        string stare1, stare2;

        private Config globalCfg = new Config();

        int ip2 = 1;
        int stary2 = 0;

        int webpdf = 0;//TODO: 0-pdf 1-web

        VClient[] vClient = new VClient[10000];

        #endregion

        #region Obsługa stron

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScrollPosition = new Point(0, ip2 * flowLayoutPanel1.Height + 18);
            //stary2 = ip2 * flowLayoutPanel1.Height + 18;
            //flowLayoutPanel1.VerticalScroll.Value = 633;
            //if (i * flowLayoutPanel1.Height + 18 == flowLayoutPanel1.)
            //    MessageBox.Show("powr");
            if (stary2 == flowLayoutPanel1.AutoScrollPosition.Y)
            {
                stary2 = 0;
                ip2 = 1;
                flowLayoutPanel1.AutoScrollPosition = new Point(0, 0);
            }
            else
            {
                stary2 = flowLayoutPanel1.AutoScrollPosition.Y;
                ip2++;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            mainPanel.SelectedTab = arptinfo;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mainPanel.SelectedTab = rtemap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainPanel.SelectedTab = init;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mainPanel.SelectedTab = filefp;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mainPanel.SelectedTab = metarcstm;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            mainPanel.SelectedTab = metararr;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            mainPanel.SelectedTab = metardep;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainPanel.SelectedTab = chdep;
            if (stare1 != fdata[0].apt)
            {
                using (var client = new WebClient())
                {
                    client.UseDefaultCredentials = true;
                    if (globalCfg.user != "" && globalCfg.password != "")
                        client.Credentials = new NetworkCredential(globalCfg.user, globalCfg.password);
                    try
                    {
                        Directory.CreateDirectory(Directory.GetCurrentDirectory().ToString() + "\\res\\");
                        client.DownloadFile(globalCfg.mainDB + fdata[0].apt.ToUpper() + ".pdf", Directory.GetCurrentDirectory().ToString() + "\\res\\" + fdata[0].apt.ToUpper() + ".pdf");
                        pdf_chdep.src = Directory.GetCurrentDirectory().ToString() + "\\res\\" + fdata[0].apt.ToUpper() + ".pdf";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                stare1 = fdata[0].apt;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainPanel.SelectedTab = charr;
            if (stare2 != fdata[1].apt)
            {
                using (var client = new WebClient())
                {
                    client.UseDefaultCredentials = true;
                    client.Credentials = new NetworkCredential(globalCfg.user, globalCfg.password);
                    try
                    {
                        Directory.CreateDirectory(Directory.GetCurrentDirectory().ToString() + "\\res\\");
                        client.DownloadFile(globalCfg.mainDB + fdata[1].apt.ToUpper() + ".pdf", Directory.GetCurrentDirectory().ToString() + "\\res\\" + fdata[1].apt.ToUpper() + ".pdf");
                        pdf_charr.src = Directory.GetCurrentDirectory().ToString() + "\\res\\" + fdata[1].apt.ToUpper() + ".pdf";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                stare2 = fdata[1].apt;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainPanel.SelectedTab = chcstm;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (webpdf == 0)
            {
                mainPanel.SelectedTab = loadsheetpdf;
            }
            else if (webpdf == 1)
            {
                mainPanel.SelectedTab = loadsheetweb;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            mainPanel.SelectedTab = vatsimtfc;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            mainPanel.SelectedTab = ivaotfc;
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }


        private void Button8_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            mainPanel.SelectedTab = atis;
            WebClient client = new WebClient();
            try
            {
                string downloadString = client.DownloadString("http://vatsim-data.hardern.net/vatsim-data.txt");

                string[] lines = downloadString.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                int counter = 0;
                foreach (var item in lines)
                {

                    if (item.IndexOf(":ATC:") != -1 && item.IndexOf(":ATC:199.998") == -1 && item.IndexOf("_OBS") == -1)
                    {
                        vClient[counter].Callsign = item.Substring(0, item.IndexOf(":"));
                        string pom = item.Substring(item.IndexOf(':') + 1).Substring(item.Substring(item.IndexOf(':') + 1).IndexOf(':') + 1);
                        vClient[counter].Name = pom.Substring(0, pom.IndexOf(':'));
                        vClient[counter].Freq = item.Substring(item.IndexOf(":ATC:") + 5, 7);
                        pom = pom.Substring(pom.IndexOf(':') + 1).Substring(pom.Substring(pom.IndexOf(':') + 1).IndexOf(':') + 1);
                        pom = pom.Substring(pom.IndexOf(':') + 1).Substring(pom.Substring(pom.IndexOf(':') + 1).IndexOf(':') + 1);
                        pom = pom.Substring(pom.IndexOf(':') + 1).Substring(pom.Substring(pom.IndexOf(':') + 1).IndexOf(':') + 1);
                        pom = pom.Substring(pom.IndexOf(':') + 1).Substring(pom.Substring(pom.IndexOf(':') + 1).IndexOf(':') + 1);
                        pom = pom.Substring(pom.IndexOf(':') + 1).Substring(pom.Substring(pom.IndexOf(':') + 1).IndexOf(':') + 1);
                        pom = pom.Substring(pom.IndexOf(':') + 1).Substring(pom.Substring(pom.IndexOf(':') + 1).IndexOf(':') + 1);
                        pom = pom.Substring(pom.IndexOf(':') + 1).Substring(pom.Substring(pom.IndexOf(':') + 1).IndexOf(':') + 1);
                        pom = pom.Substring(pom.IndexOf(':') + 1).Substring(pom.Substring(pom.IndexOf(':') + 1).IndexOf(':') + 1);
                        pom = pom.Substring(pom.IndexOf(':') + 1).Substring(pom.Substring(pom.IndexOf(':') + 1).IndexOf(':') + 1);
                        pom = pom.Substring(pom.IndexOf(':') + 1).Substring(pom.Substring(pom.IndexOf(':') + 1).IndexOf(':') + 1);
                        pom = pom.Substring(pom.IndexOf(':') + 1).Substring(pom.Substring(pom.IndexOf(':') + 1).IndexOf(':') + 1);
                        pom = pom.Substring(pom.IndexOf(':') + 1).Substring(pom.Substring(pom.IndexOf(':') + 1).IndexOf(':') + 1);
                        pom = pom.Substring(pom.IndexOf(':') + 1).Substring(pom.Substring(pom.IndexOf(':') + 1).IndexOf(':') + 1);
                        pom = pom.Substring(pom.IndexOf(':') + 1).Substring(pom.Substring(pom.IndexOf(':') + 1).IndexOf(':') + 1);
                        pom = pom.Substring(pom.IndexOf(':') + 1).Substring(pom.Substring(pom.IndexOf(':') + 1).IndexOf(':') + 1);
                        pom = pom.Substring(pom.IndexOf(':') + 1).Substring(pom.Substring(pom.IndexOf(':') + 1).IndexOf(':') + 1);
                        vClient[counter].AtisInfo = pom.Substring(1, pom.IndexOf(":2") - 1);
                        vClient[counter].AtisInfo = vClient[counter].AtisInfo.Replace("^§", " ");
                        comboBox1.Items.Add(vClient[counter].Callsign);


                    }
                    counter++;

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.ShowCenter = false;
            gMapControl1.DragButton = System.Windows.Forms.MouseButtons.Left;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to close the EFB?", "EFB message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Directory.Delete(@Directory.GetCurrentDirectory() + "\\res\\", true);
                    LogAppend("Succeeded to delete charts directory at:" + Directory.GetCurrentDirectory() + "\\res\\");

                }
                catch
                {
                    LogAppend("Failed to delete charts directory at:" + Directory.GetCurrentDirectory() + "\\res\\");

                }
            }
            else
                e.Cancel = true;
        }

        #endregion

        private void button20_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click_2(object sender, EventArgs e)
        {
            if (txt_arrival.Text.Length == 4 && txt_departure.Text.Length == 4)
            {
                try
                {
                    fdata[0].apt = txt_departure.Text;
                    fdata[1].apt = txt_arrival.Text;
                    fdata[1].downloaddata();
                    fdata[0].downloaddata();

                    gMapControl1.Overlays.Clear();
                    GMapOverlay polyOverlay = new GMapOverlay("polygons");
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(double.Parse(fdata[0].lat), double.Parse(fdata[0].lon)));
                    points.Add(new PointLatLng(double.Parse(fdata[1].lat), double.Parse(fdata[1].lon)));
                    GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
                    polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                    polygon.Stroke = new Pen(Color.Red, 3);
                    polyOverlay.Polygons.Add(polygon);
                    gMapControl1.Overlays.Add(polyOverlay);
                    gMapControl1.Position = new PointLatLng(double.Parse(fdata[0].lat), double.Parse(fdata[0].lon));
                    gMapControl1.Zoom = 11;
                    lbl_route.Text = txt_departure.Text.ToUpper() + " to " + txt_arrival.Text.ToUpper();
                    lbl_callsign.Text = txt_callsign.Text.ToUpper();
                    txt_metdep.Text = GetMetar(fdata[0].apt);
                    txt_metarr.Text = GetMetar(fdata[1].apt);
                }
                catch
                {
                    MessageBox.Show("Error while downloading airports' informations! Check input data and try again.", "EFB message");
                }
            }
            else
            {
                MessageBox.Show("Error while downloading airports' informations! Check input data and try again.", "EFB message");
            }

            txt_arrival.Text = txt_arrival.Text.ToUpper();
            txt_departure.Text = txt_departure.Text.ToUpper();
            txt_callsign.Text = txt_callsign.Text.ToUpper();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.UseDefaultCredentials = true;
                client.Credentials = new NetworkCredential(globalCfg.user, globalCfg.password);
                try
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory().ToString() + "\\res\\");
                    client.DownloadFile(globalCfg.mainDB + txt_chcstm.Text.ToUpper() + ".pdf", Directory.GetCurrentDirectory().ToString() + "\\res\\" + txt_chcstm.Text.ToUpper() + ".pdf");
                    pdf_chcstm.src = Directory.GetCurrentDirectory().ToString() + "\\res\\" + txt_chcstm.Text.ToUpper() + ".pdf";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            txt_chcstm.Text = txt_chcstm.Text.ToUpper();
        }

        private void tmr_time_Tick(object sender, EventArgs e)
        {
            lbl_z_time.Text = DateTime.UtcNow.ToString("HHmm") + "Z";
            try
            {
                lbl_dep_time.Text = fdata[0].apt.ToUpper() + " local time: " + TimeZoneInfo.ConvertTime(DateTime.UtcNow, TZConvert.GetTimeZoneInfo(
                    GeoTimeZone.TimeZoneLookup.GetTimeZone(double.Parse(fdata[0].lat), double.Parse(fdata[0].lon)).Result)).ToString("HHmm");

                lbl_arr_time.Text = fdata[1].apt.ToUpper() + " local time: " + TimeZoneInfo.ConvertTime(DateTime.UtcNow, TZConvert.GetTimeZoneInfo(
                    GeoTimeZone.TimeZoneLookup.GetTimeZone(double.Parse(fdata[1].lat), double.Parse(fdata[1].lon)).Result)).ToString("HHmm");
            }
            catch
            {
                lbl_dep_time.Text = "Waiting for airports to be added...";
                lbl_arr_time.Text = "Waiting for airports to be added...";
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (txt_metcstm_input.Text.Length == 4)
            {
                txt_metcstm.Text = GetMetar(txt_metcstm_input.Text);
                txt_metcstm_input.Text = txt_metcstm_input.Text.ToUpper();
            }

            else
            {
                MessageBox.Show("Error while downloading airports' metar! Check input data and try again.", "EFB message");
                LogAppend("Tried to download airports' metar, but failed - the ICAO a/d code isn't 4 characters long.");
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pdf_loadsheet.src = openFileDialog1.FileName;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(object sender, Awesomium.Core.ShowCreatedWebViewEventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {
            mainPanel.SelectedTab = settings;
        }



        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Button25_Click(object sender, EventArgs e)
        {


            int counter = 0;

            foreach (var item in vClient)
            {
                if (item.Callsign == comboBox1.Text)
                {
                    string s = vClient[counter].Callsign + "\r\n" + vClient[counter].Name + "\r\n" + vClient[counter].Freq + "\r\n" + vClient[counter].AtisInfo;
                    txt_atis.Text = s;
                    if (globalCfg.printFlag == true)
                    {
                        PrintDocument p = new PrintDocument();
                        p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                        {
                            e1.Graphics.DrawString(s, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
                        };
                        try
                        {
                            p.Print();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while printing. See log.", "EFB message");
                            LogAppend("Tried to print, but failed with error: " + ex.Message + "\r\nMore: " + ex.ToString());
                        }
                    }
                    break;
                }
                counter++;
            }
        }

        private void dataPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Button26_Click(object sender, EventArgs e)
        {
            if (globalCfg.printFlag == false)
            {
                globalCfg.printFlag = true;
                btn_print.Text = "PRINT";
                btn_print.BackColor = Color.Green;
            }
            else if (globalCfg.printFlag == true)
            {
                globalCfg.printFlag = false;
                btn_print.Text = "DO NOT PRINT";
                btn_print.BackColor = Color.Crimson;
            }
        }

        private void Btn_pdf_Click(object sender, EventArgs e)
        {
            btn_pdf.BackColor = Color.Green;
            btn_web.BackColor = Color.Transparent;
            globalCfg.selFunction = 0;

        }

        private void Btn_web_Click(object sender, EventArgs e)
        {
            btn_web.BackColor = Color.Green;
            btn_pdf.BackColor = Color.Transparent;
            globalCfg.selFunction = 1;
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            try
            {
                globalCfg.flightPlanLink = txt_genLink.Text;
                globalCfg.AIPLink = txt_aip.Text;
                globalCfg.filePlanLink = txt_filefp.Text;
                globalCfg.VATSIMtfc = txt_vatsim.Text;
                globalCfg.IVAOtfc = txt_ivao.Text;
                globalCfg.mainDB = txt_dbmain.Text;
                globalCfg.Exceptions = txt_excCharts.Text;
                globalCfg.user = txt_user.Text;
                globalCfg.password = txt_password.Text;

                string s =
                    "FDMU - Flight Data Management Unit\r\n" +
                "FDMU by Grzegorz Jewusiak\r\n" +
                "for guides visit: https://developer.jewusiak.eu/\r\n" +
                "or contact me: developer@jewusiak.eu \r\n" +
                "####### Configuration Files #######\r\n" +
                "WARNING: CHANGING ANY SETTINGS MAY RESULT \r\n" +
                "IN CONFIG INCOMPATIBILITY. DO IT ON YOUR OWN RISK!\r\n" +
                "########################################\r\n" +
                "@LISTBEGIN@\r\n" +
                "selectedFunction=" + globalCfg.selFunction.ToString() + "\r\n" +
                "printFlag=" + globalCfg.printFlag.ToString() + "\r\n" +
                "flightPlanLink=" + globalCfg.flightPlanLink + "\r\n" +
                "AIPLink=" + globalCfg.AIPLink + "\r\n" +
                "filePlanLink=" + globalCfg.filePlanLink + "\r\n" +
                "VATSIMtfc=" + globalCfg.VATSIMtfc + "\r\n" +
                "IVAOtfc=" + globalCfg.IVAOtfc + "\r\n" +
                "mainDB=" + globalCfg.mainDB + "\r\n" +
                "user=" + globalCfg.user + "\r\n" +
                "password=" + globalCfg.password + "\r\n" +
                "Exceptions=" + globalCfg.Exceptions + "\r\n" +
                "@EXEND@\r\n" +
                "@LISTEND@";
                File.WriteAllText(Directory.GetCurrentDirectory() + "\\fdmu.cfg", s);
                LogAppend("Config File Saved to: " + Directory.GetCurrentDirectory() + "\\fdmu.cfg");
            }
            catch (Exception ex)
            {
                LogAppend("Tried to save config to: " + Directory.GetCurrentDirectory() + "\\fdmu.cfg" + "but failed with error: " + ex.Message + "\r\nMore:" + ex.ToString());
            }
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {

                globalCfg.Load(openFileDialog2.FileName);
                txt_genLink.Text = globalCfg.flightPlanLink;
                txt_aip.Text = globalCfg.AIPLink;
                filefp.Text = globalCfg.filePlanLink;
                txt_vatsim.Text = globalCfg.VATSIMtfc;
                txt_ivao.Text = globalCfg.IVAOtfc;
                txt_dbmain.Text = globalCfg.mainDB;
                txt_excCharts.Text = globalCfg.Exceptions;
                txt_user.Text = globalCfg.user;
                txt_password.Text = globalCfg.password;

                switch (globalCfg.selFunction)
                {
                    case 0:
                        btn_pdf.BackColor = Color.Green;
                        btn_web.BackColor = Color.Transparent;

                        break;
                    case 1:
                        btn_web.BackColor = Color.Crimson;
                        btn_pdf.BackColor = Color.Transparent;
                        break;
                }
                switch (globalCfg.printFlag)
                {
                    case true:
                        btn_print.Text = "PRINT";
                        btn_print.BackColor = Color.Green;
                        break;
                    case false:
                        btn_print.Text = "DO NOT PRINT";
                        btn_print.BackColor = Color.Crimson;
                        break;

                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure, you want to close the EFB?", "EFB message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Directory.Delete(@Directory.GetCurrentDirectory() + "\\res\\", true);
                    LogAppend("Succeeded to delete charts directory at:" + Directory.GetCurrentDirectory() + "\\res\\");
                    Application.Exit();
                }
                catch
                {
                    LogAppend("Failed to delete charts directory at:" + Directory.GetCurrentDirectory() + "\\res\\");
                    Application.Exit();

                }
                Application.Exit();
            }
        }
    }
}
