using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public static class Tool
    {
        /// <summary>  
        /// 获取本机MAC地址  
        /// </summary>  
        /// <returns>本机MAC地址</returns>  
        public static string GetMacAddress()
        {
            try
            {
                string strMac = string.Empty;
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["IPEnabled"] == true)
                    {
                        strMac = mo["MacAddress"].ToString();
                    }
                }
                moc = null;
                mc = null;
                return strMac;
            }
            catch
            {
                return "unknown";
            }
        }
        /// <summary>  
        /// 获取本机的物理地址  
        /// </summary>  
        /// <returns></returns>  
        public static string getMacAddr_Local()
        {
            string madAddr = null;
            try
            {
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc2 = mc.GetInstances();
                foreach (ManagementObject mo in moc2)
                {
                    if (Convert.ToBoolean(mo["IPEnabled"]) == true)
                    {
                        madAddr = mo["MacAddress"].ToString();
                        madAddr = madAddr.Replace(':', '-');
                    }
                    mo.Dispose();
                }
                if (madAddr == null)
                {
                    return "unknown";
                }
                else
                {
                    return madAddr;
                }
            }
            catch (Exception)
            {
                return "unknown";
            }
        }
    }
}
