using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for task
/// </summary>
public class task
{


    public static void ErrorLog(string mssg) {
        string FilePath = HttpContext.Current.Server.MapPath("~/log/ErrorLog.txt");

        try
        {
            if (File.Exists(FilePath))
            {
                using (StreamWriter tw = File.AppendText(FilePath))
                {
                    tw.WriteLine(DateTime.Now.ToString() + "> " + mssg);
                }  //END using

            }  //END if
            else
            {
                TextWriter tw = new StreamWriter(FilePath);
                tw.WriteLine(DateTime.Now.ToString() + "> " + mssg);
                tw.Flush();
                tw.Close();
                tw = null;
            }  //END else

        }  //END Try
        catch (Exception ex)
        { } //END Catch   

    }  // END ErrorLog



    public static string HTTPChecker(string Value)
    {

        string Checker = Value.Substring(0, 8);

        if ((Value.Substring(0, 7) != "http://") && (Value.Substring(0, 8) != "https://"))
        {
            Value = "http://" + Value;
        }

        return Value;
    }  //END HTTPChecker


}
