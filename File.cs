using AYRUZ_YATT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CommonFunctions
{
    public class File
    {
        public static bool Save(string path, string text)
        {
            try
            {
                System.IO.File.WriteAllText(path, text);
                return true;
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147024893)//{"Could not find a part of the path 'C:\\AYRUZ_YATT__\\bin\\Debug\\net8.0-windows\\Folder_Configs\\Tests\\______Steps\\TestInfo.ayruz'."}
                {
                    var path_split = path.Split(Path.DirectorySeparatorChar);
                    string a1 = "";
                    for (int i = 0; i < path_split.Length - 1; i++)
                    {
                        a1 += path_split[i] + "\\";
                        //for (int j = 0; j < path_split.Length; j++)
                        //{

                        //}
                    }
                    //Directory.CreateDirectory(path);
                    Directory.CreateDirectory(a1);
                    Save(path, text);
                }
                if (ex.HResult == -2147024891)//{"Access to the path                'C:\\AYRUZ_YATT__\\bin\\Debug\\net8.0-windows\\Folder_Configs\\Tests\\______Steps\\TestInfo.ayruz' is denied."}
                {

                }
                MessageBox.Show("Error on Saving.!");
                Logger.log.Fatal(ex + path + text);
                //throw;
            }
            return false;
        }
        public static string Open(string path)
        {
            try
            {
                return System.IO.File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                Logger.log.Fatal(ex + path);
            }
            return "NULL";
        }
    }
}
