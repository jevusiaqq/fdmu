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
            //Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            InitializeComponent();
            if (Screen.PrimaryScreen.Bounds.Width == 1366 && Screen.PrimaryScreen.Bounds.Height == 768)
            {
                this.FormBorderStyle = FormBorderStyle.None;

            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            tmr_time.Start();
        }

        private Deparr[] fdata =new Deparr[2];          //todo: fdata: 0 - dep, 1 - arr
        string stare1, stare2;

        #region Obsługa stron
        int ip2 = 1;
        int stary2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScrollPosition = new Point(0, ip2*flowLayoutPanel1.Height+18);
            //stary2 = ip2 * flowLayoutPanel1.Height + 18;
            //flowLayoutPanel1.VerticalScroll.Value = 633;
            //if (i * flowLayoutPanel1.Height + 18 == flowLayoutPanel1.)
            //    MessageBox.Show("powr");
            if ( stary2== flowLayoutPanel1.AutoScrollPosition.Y) 
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
                    client.Credentials = new NetworkCredential("fcom", "Grzesio117");
                    try
                    {
                        Directory.CreateDirectory(Directory.GetCurrentDirectory().ToString() + "\\res\\");
                        client.DownloadFile("https://jewusiak.eu/resources/1700/" + fdata[0].apt.ToUpper() + ".pdf", Directory.GetCurrentDirectory().ToString() + "\\res\\" + fdata[0].apt.ToUpper() + ".pdf");
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
                    client.Credentials = new NetworkCredential("fcom", "Grzesio117");
                    try
                    {
                        Directory.CreateDirectory(Directory.GetCurrentDirectory().ToString() + "\\res\\");
                        client.DownloadFile("https://jewusiak.eu/resources/1700/" + fdata[1].apt.ToUpper() + ".pdf", Directory.GetCurrentDirectory().ToString() + "\\res\\" + fdata[1].apt.ToUpper() + ".pdf");
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
            mainPanel.SelectedTab = loadsheet;
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

        VClient[] vClient = new VClient[10000];

        private void Button8_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            mainPanel.SelectedTab = atis;
            WebClient client = new WebClient();
           // VClient[] vClient = new VClient[10000];
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


                        //MessageBox.Show("dupa" + counter.ToString());
                    }
                    counter++;

                }

                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
                try{
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
                MessageBox.Show("Error while downloading airports' informations! Check input data and try again.","EFB message");
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
                client.Credentials = new NetworkCredential("fcom", "Grzesio117");
                try
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory().ToString() + "\\res\\");
                    client.DownloadFile("https://jewusiak.eu/resources/1700/" + txt_chcstm.Text.ToUpper() + ".pdf", Directory.GetCurrentDirectory().ToString() + "\\res\\" + txt_chcstm.Text.ToUpper() + ".pdf");
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
            lbl_z_time.Text = DateTime.UtcNow.ToString("HHmm")+"Z";
            try
            {
                lbl_dep_time.Text = fdata[0].apt.ToUpper()+" local time: "+TimeZoneInfo.ConvertTime(DateTime.UtcNow,TZConvert.GetTimeZoneInfo( 
                    GeoTimeZone.TimeZoneLookup.GetTimeZone(double.Parse(fdata[0].lat), double.Parse(fdata[0].lon)).Result)).ToString("HHmm");

                lbl_arr_time.Text = fdata[1].apt.ToUpper() + " local time: " + TimeZoneInfo.ConvertTime(DateTime.UtcNow, TZConvert.GetTimeZoneInfo( 
                    GeoTimeZone.TimeZoneLookup.GetTimeZone(double.Parse(fdata[1].lat), double.Parse(fdata[1].lon)).Result)).ToString("HHmm");
            }
            catch
            {
                lbl_dep_time.Text = "Waiting for airports to be added...";
                lbl_arr_time.Text = "Waiting for airports to be added...";
                //MessageBox.Show(ex.Message);
            }
            
            
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.ShowCenter = false;
            gMapControl1.DragButton = System.Windows.Forms.MouseButtons.Left;
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
                MessageBox.Show("Error while downloading airport's metar! Check input data and try again.", "EFB message");
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
            //webControl1.Source= "https://accumap-project.com/".ToUri();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
        


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void Button25_Click(object sender, EventArgs e)
        {
            //   string s = vClient[Array.IndexOf(vClient, comboBox1.Text)].AtisInfo;


            int counter = 0;
            
            foreach (var item in vClient)
            {
                if (item.Callsign == comboBox1.Text)
                {
                    string s = vClient[counter].Callsign + "\r\n" + vClient[counter].Name + "\r\n" + vClient[counter].Freq + "\r\n" + vClient[counter].AtisInfo;
                    PrintDocument p = new PrintDocument();
                    p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                    {
                        e1.Graphics.DrawString(s, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
                        // e1.Graphics.DrawString(s, new Font("Times New Roman", 10), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
                    };
                    try
                    {
                        p.Print();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Exception Occured While Printing", ex);
                    }
                    break;
                }
                counter++;
            }
            

            //    PrintDocument p = new PrintDocument();
            //    p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            //    {
            //        e1.Graphics.DrawString(s, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
            //        // e1.Graphics.DrawString(s, new Font("Times New Roman", 10), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
            //    };
            //    try
            //    {
            //        p.Print();
            //    }
            //    catch (Exception ex)
            //    {
            //        throw new Exception("Exception Occured While Printing", ex);
            //    }
        }

        private void dataPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure, you want to close the EFB?", "EFB message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Directory.Delete(@Directory.GetCurrentDirectory() + "\\res\\", true);
                }
                catch
                {
                    Application.Exit();
                }
                Application.Exit();
            }
        }




 

        }
}
