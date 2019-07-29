using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace FXOrder.Class
{
    public class Order
    {
        public static string GetLatestOrder() {
            string value = "";
            string templatePath = ConfigurationManager.AppSettings["PATH_LATEST_ORDER"];

            string[] lines = System.IO.File.ReadAllLines(templatePath);
            char[] trimChars = new char[] { '\r', '\n', '\0', '\t' };
            foreach (string line in lines)
            {
                value += line;
                value = value.Trim(trimChars);
            }
            return value;
        }
         
        public static string GetOrdersHistory() {
            string value = "";
            string templatePath = ConfigurationManager.AppSettings["PATH_ORDERS_HISTORY"];

            string[] lines = System.IO.File.ReadAllLines(templatePath);
            char[] trimChars = new char[] { '\r', '\n', '\0', '\t' };
            foreach (string line in lines)
            {
                value += line;
                value = value.Trim(trimChars);
            }
            return value;
        }

        public static string GetOrders()
        {
            string value = "";
            string templatePath = ConfigurationManager.AppSettings["PATH_ORDERS"];

            string[] lines = System.IO.File.ReadAllLines(templatePath); 
            char[] trimChars = new char[] { '\r', '\n', '\0', '\t' };
            foreach (string line in lines)
            {
                value += line;
                value = value.Trim(trimChars);
            } 
            return value;
        }




        public static string GetAccount()
        {
            string value = "";
            string templatePath = ConfigurationManager.AppSettings["PATH_ACCOUNT"];

            string[] lines = System.IO.File.ReadAllLines(templatePath);
            char[] trimChars = new char[] { '\r', '\n', '\0', '\t' };
            foreach (string line in lines)
            {
                value += line;
                value = value.Trim(trimChars);
            }
            return value;
        }
    }
} 