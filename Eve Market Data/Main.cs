﻿using Eve_Market_Data.IDItemInfoJsonTypes;
using log4net;
using log4net.Config;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Eve_Market_Data
{
    public partial class Main : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Main));
        static string API_BASE = "https://crest-tq.eveonline.com/";
        static string ITEM_ROUTE = API_BASE + "inventory/types/";
        static string HIST_ROUTE = API_BASE + "market/10000002/history/?type=" + ITEM_ROUTE;
        static string ALL_ORDERS_ROUTE = API_BASE + "market/10000002/orders/all/";
        static int[] ITEM_ID_RANGE = { 2, 200 };
        static Dictionary<int, string> itemsIDNames = new Dictionary<int, string>();

        public Main()
        {
            InitializeComponent();
            BasicConfigurator.Configure();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //TODO: implement timer to repeat the following on specific intervals

            progressBarBGW.RunWorkerAsync();

            //TODO: get buy orders for item

            //TODO: find highest buy order by price

            //TODO: get sell orders for item

            //TODO: get lowest sell order by price

            //TODO: calculate margin, output to data grid

            //TODO: get volume for item, output to data grid

        }

        private void itemsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO: implement secondary form for item details with order history
        }

        /// <summary>
        /// Returns a json string from the supplied API url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private string Get(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
            }
        }

        public string InfoPrepender(string message, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null)
        {
            return string.Format("({2})[{1}] {0}", message, lineNumber, caller);
        }

        private void ReadItemList(object sender)
        {
            using (TextFieldParser parser = new TextFieldParser("eve_market_items.csv"))
            {
                uiProgressBar.Value = 0;
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData && itemsList.Rows.Count < 2500)
                {
                    string[] fields = parser.ReadFields();
                    if (fields[0] == "typeID") continue;
                    object[] data = { int.Parse(fields[0]), fields[2] };
                    Invoke((MethodInvoker)delegate { itemsList.Rows.Add(data); });
                    log.Debug(InfoPrepender(string.Format("Adding ({0}){1} to data grid in row {2}", fields[0], fields[2], itemsList.Rows.Count)));
                    progressBarBGW.ReportProgress((int)((itemsList.Rows.Count / 8490.0) * 100.0));
                }
            }
        }

        private void marginThread_Tick(object sender, EventArgs e)
        {
            if (marginThread.Enabled) marginThread.Enabled = false;
            if (marginThread.Enabled) marginThread.Enabled = true;
        }

        private void volumeThread_Tick(object sender, EventArgs e)
        {
            if (volumeThread.Enabled) volumeThread.Enabled = false;
            if (volumeThread.Enabled) volumeThread.Enabled = true;
        }

        private void uiThread_Tick(object sender, EventArgs e)
        {
            if (uiThread.Enabled) uiThread.Enabled = false;
            if (uiThread.Enabled) uiThread.Enabled = true;
        }

        private void progressBarBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            ReadItemList(sender);
        }

        private void progressBarBGW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            uiProgressBar.Value = e.ProgressPercentage;
        }

        private void progressBarBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            uiProgressBar.Visible = false;
            uiProgressBarStatusLabel.Visible = false;
        }
    }
}
