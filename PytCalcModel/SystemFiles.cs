using System;
using System.IO;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PytCalcModel
{
    internal static class SystemFiles
    {        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal static string[] GetXmlFiles(string path)
        {
            string[] xmlFiles = Directory.GetFiles(path, "*.xml");

            return xmlFiles;
        }
    }

    internal class IniFile
    {
        internal string path { get; set; }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string name, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public IniFile(string iniFile)
        {
            this.path = iniFile;
        }

        internal void WriteIniFile(string name, string key, string val)
        {
            WritePrivateProfileString(name, key, val, this.path);
        }

        internal string ReadIniFile(string section, string key)
        {
            StringBuilder temp = new StringBuilder(255);

            int i = GetPrivateProfileString(section, key, "", temp, 255, this.path);

            return temp.ToString();
        }
    }
}
