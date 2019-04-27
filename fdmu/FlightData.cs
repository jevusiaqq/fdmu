using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//TkchJmEMUKBtIlWv

namespace addons
{


    public static class FlightData
    {

        #region Departure & Arrival Database Struct

        public struct Deparr
        {
            public string apt, lat, lon, msl, name;

            public Deparr(string aptt, string latt, string lonn, string msll, string namee)
            {
                apt = aptt;
                lat = latt;
                lon = lonn;
                msl = msll;
                name = namee;

            }
            public void downloaddata()
            {
                name = dbArp(apt)[1];
                lat = dbArp(apt)[2];
                lon = dbArp(apt)[3];
                msl = dbArp(apt)[4];
            }


        }

        #endregion

        #region Airports Database Struct

        public struct Airportsdb
        {
            public string icao, name, msl;
            public string lat, lon, srch;
            public Airportsdb(string Icao, string Name, string Lat, string Lon, string Msl, string Srch)
            {
                icao = Icao;
                name = Name;
                lat = Lat;
                lon = Lon;
                msl = Msl;
                srch = Srch;

            }


        }

        #endregion

        #region Airports Database Query

        public static string[] dbArp(string icao)
        {
            string[] list = new string[5];

            MySqlConnection sqlConn = new MySqlConnection
            {
                ConnectionString = "server=jewusiak.eu;" +
                               "database=flightdata;" +
                               "Uid=app;" +
                               "Pwd=TkchJmEMUKBtIlWv;"
            };

            try
            {
                // otwórz połączenie:
                sqlConn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM airports WHERE `icao`='" + icao + "'", sqlConn);
                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    try
                    {
                        list[0] = dataReader["icao"] + "";
                        list[1] = dataReader["name"] + "";
                        list[2] = dataReader["lat"] + "";
                        list[3] = dataReader["lon"] + "";
                        list[4] = dataReader["msl"] + "";
                    }
                    catch (Exception)
                    {
                        break;
                    }
                    break;
                }

                dataReader.Close();
                // zamknij połaczenie:
                sqlConn.Close();


                return list;
            }
            catch (MySqlException se)
            {
                MessageBox.Show("Nastąpil bląd połaczenia: " + se);
            }
            return null;
        }

        #endregion

        #region Runway Database Query

        public static string[,] dbRwy(string airport)
        {
            string[,] list = new string[20, 9];

            MySqlConnection sqlConn = new MySqlConnection
            {
                ConnectionString = "server=jewusiak.eu;" +
                               "database=flightdata;" +
                               "Uid=app;" +
                               "Pwd=TkchJmEMUKBtIlWv;"
            };

            try
            {
                // otwórz połączenie:
                sqlConn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `runways` WHERE `icao`='" + airport + "'", sqlConn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                int iss = 0;
                while (dataReader.Read())
                {
                    list[iss, 0] = dataReader["icao"] + "";
                    list[iss, 1] = dataReader["nr"] + "";
                    list[iss, 2] = dataReader["lat"] + "";
                    list[iss, 3] = dataReader["lon"] + "";
                    list[iss, 4] = dataReader["msl"] + "";
                    list[iss, 5] = dataReader["ils"] + "";
                    list[iss, 6] = dataReader["hdg"] + "";
                    list[iss, 7] = dataReader["hdg2"] + "";
                    list[iss, 8] = dataReader["length"] + "";
                    iss++;
                }

                dataReader.Close();
                // zamknij połaczenie:
                sqlConn.Close();
                return list;
            }
            catch (Exception se)
            {
                MessageBox.Show("Nastąpil bląd połaczenia: " + se);
            }
            return null;
        }


        #endregion

        #region Get Metar Query

        public static string GetMetar(string arpt)
        {
            WebClient client = new WebClient();


            string downloadString = client.DownloadString("https://www.ogimet.com/display_metars2.php?lang=en&fmt=txt&lugar=" + arpt.ToUpper());
            try
            {
                downloadString = downloadString.Substring(downloadString.IndexOf("METAR/SPECI"), downloadString.LastIndexOf("=") - downloadString.IndexOf("METAR/SPECI"));
                string metar = downloadString.Substring(downloadString.IndexOf("METAR " + arpt.ToUpper()), downloadString.IndexOf("=") - downloadString.IndexOf("METAR " + arpt.ToUpper()));
                metar += Environment.NewLine;
                metar += Environment.NewLine;
                metar += Environment.NewLine;
                metar += downloadString.Substring(downloadString.IndexOf("TAF " + arpt.ToUpper()), downloadString.IndexOf("=", downloadString.IndexOf("TAF " + arpt.ToUpper())) - downloadString.IndexOf("TAF " + arpt.ToUpper()));

                return metar;
            }
            catch (Exception)
            {
                return "NO METAR OR TAF DATA AVAILABLE";
            }

        }
        #endregion

        #region Client Object

        public struct VClient
        {



            public string Callsign;

            public string Name;

            public string Freq;

            public int VisRange;

            public string AtisInfo;

            public DateTime TimeLogon;

        }

        #endregion



    }
}
