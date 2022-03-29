using Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace Project.Controller
{
    class BillManagementController
    {
        public DataTable dt = new DataTable();

        public BillManagementController()
        {
            dt.Columns.Add("Id");
            dt.Columns.Add("Date");
            dt.Columns.Add("Member Id");
            dt.Columns.Add("Disk Id");
            dt.Columns.Add("Rental Date");
            dt.Columns.Add("Unit Price");
            dt.Columns.Add("Amount");

            foreach (BillModel item in Db.listBill)
            {
                var values = new object[7];
                values[0] = item.Id;
                values[1] = item.Date.ToString("d", CultureInfo.GetCultureInfo("es-ES"));
                values[2] = item.MemberId;
                values[3] = "";
                values[4] = "";
                values[5] = "";
                values[6] = "";

                foreach(BillDetails details in item.ListDetail)
                {
                    values[3] += details.DiskId + ", ";
                    values[4] += details.Date.ToString() + ", ";
                    values[5] += details.Price.ToString() + ", ";
                    values[6] += details.Amount.ToString() + ", ";
                }

                dt.Rows.Add(values);
            }
        }

        public void search(string text)
        {
            dt.Clear();

            foreach (BillModel item in Db.listBill)
            {
                if (item.MemberId != text) continue;

                var values = new object[7];
                values[0] = item.Id;
                values[1] = item.Date.ToString("d", CultureInfo.GetCultureInfo("es-ES"));
                values[2] = item.MemberId;
                values[3] = "";
                values[4] = "";
                values[5] = "";
                values[6] = "";

                foreach (BillDetails details in item.ListDetail)
                {
                    values[3] += details.DiskId + ", ";
                    values[4] += details.Date.ToString() + ", ";
                    values[5] += details.Price.ToString() + ", ";
                    values[6] += details.Amount.ToString() + ", ";
                }

                dt.Rows.Add(values);
            }
        }

        List<BillDetails> translate(string diskId, string date, string price, string amount)
        {
            List<BillDetails> result = new List<BillDetails>();
            List<string> listDiskId = new List<string>();

            for(int i = 0; i < diskId.Length; i++)
            {
                if(i == 0 || (diskId[i - 1] == ' ' && diskId[i - 2] == ','))
                {
                    string temp = "";
                    for(int j = i; j < diskId.Length; j++)
                    {
                        if (diskId[j] == ',')
                        {
                            i = j + 1;
                            break;
                        }
                        temp += diskId[j];
                    }
                    listDiskId.Add(temp);
                }
            }

            List<int> listDate = new List<int>();
            for (int i = 0; i < date.Length; i++)
            {
                if(i == 0 || (date[i - 1] == ' ' && date[i - 2] == ','))
                {
                    string temp = "";
                    for (int j = i; j < date.Length; j++)
                    {
                        if (date[j] == ',')
                        {
                            i = j + 1;
                            break;
                        }
                        temp += date[j];
                    }

                    listDate.Add(int.Parse(temp));
                }
            }

            List<int> listPrice = new List<int>();
            for (int i = 0; i < price.Length; i++)
            {
                if (i == 0 || (price[i - 1] == ' ' && price[i - 2] == ','))
                {
                    string temp = "";
                    for (int j = i; j < price.Length; j++)
                    {
                        if (price[j] == ',')
                        {
                            i = j + 1;
                            break;
                        }
                        temp += price[j];
                    }
                    listPrice.Add(int.Parse(temp));
                }
            }

            List<int> listAmount = new List<int>();
            for (int i = 0; i < amount.Length; i++)
            {
                if (i == 0 || (amount[i - 1] == ' ' && amount[i - 2] == ','))
                {
                    string temp = "";
                    for (int j = i; j < amount.Length; j++)
                    {
                        if (amount[j] == ',')
                        {
                            i = j + 1;
                            break;
                        }
                        temp += amount[j];
                    }
                    listAmount.Add(int.Parse(temp));
                }
            }

            for(int i = 0; i < listDiskId.Count; i++)
            {
                result.Add(new BillDetails(listDiskId[i], listDate[i], listPrice[i], listAmount[i]));
            }

            return result;
        }
    }
}
