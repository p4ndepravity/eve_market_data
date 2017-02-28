using Eve_Market_Data.IDItemInfoJsonTypes;
using log4net;
using log4net.Config;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Eve_Market_Data
{
    public partial class Main : Form
    {
        private static readonly log4net.ILog log = LogManager.GetLogger(typeof(Main));
        static string API_BASE = "https://crest-tq.eveonline.com/";
        static string ITEM_ROUTE = API_BASE + "inventory/types/";
        static string HIST_ROUTE = API_BASE + "market/10000002/history/?type=" + ITEM_ROUTE;
        static string ALL_ORDERS_ROUTE = API_BASE + "market/10000002/orders/all/";
        static int[] ITEM_ID_RANGE = { 2, 200 };
        static List<IDItemInfo> itemListPages;
        static Dictionary<int, string> itemsIDNames = new Dictionary<int, string>();

        public Main()
        {
            InitializeComponent();
            BasicConfigurator.Configure();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //TODO: implement timer to repeat the following on specific intervals

            if (!File.Exists("item_table.json"))
            {
                //TODO: create API request
                var json = Get(ITEM_ROUTE);
                itemListPages = new List<IDItemInfo>();
                IDItemInfo itemListPage = JsonConvert.DeserializeObject<IDItemInfo>(json);
                itemListPages.Add(itemListPage);
                for (int i = 0; i < itemListPage.PageCount; i++)
                {
                    if (itemListPage.Next == null) break;
                    log.Debug(InfoPrepender(string.Format("Processing item list page {0}", i + 1)));
                    json = Get(itemListPage.Next.Href);
                    itemListPage = JsonConvert.DeserializeObject<IDItemInfo>(json);
                    itemListPages.Add(itemListPage);
                }

                //TODO: implement file output of item names/ids
                using (StreamWriter sw = File.AppendText("item_table.json"))
                {
                    foreach (IDItemInfo page in itemListPages)
                    {
                        foreach (Item item in page.Items)
                        {
                            sw.WriteLine("{0}\t{1}", item.Id, item.Name);
                        }
                    }
                }
            }
            else
            {
                //TODO: implement reading items from file
            }

            foreach (IDItemInfo page in itemListPages)
            {
                int j = 0;
                for (int i = ITEM_ID_RANGE[0]; i < ITEM_ID_RANGE[1]; i++)
                {
                    while (true)
                    {
                        if (page.Items[j] != null && page.Items[j].Id == i)
                        {
                            log.Debug(InfoPrepender(string.Format("Adding ({0}){1}", i, page.Items[j].Name)));
                            itemsList.Rows.Add(i.ToString(), page.Items[j].Name, null, null);
                            j++;
                            break;
                        }
                        j++;
                    }
                }
            }

            //TODO: store API response as list of dictionaries

            //TODO: get name from TypeID

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
    }
}
