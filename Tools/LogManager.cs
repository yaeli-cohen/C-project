using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Tools;

public static class LogManager
{
    private static readonly string logRoute = "Log";


    public static string currentFolderRoute()
    {
        return logRoute + Path.DirectorySeparatorChar + DateTime.Now.Month + "-" + DateTime.Now.Year;
    }


    public static string currentFileRoute()
    {
        return currentFolderRoute() + Path.DirectorySeparatorChar + DateTime.Now.Day + ".txt";


    }

    public static void logWriter(string projectName, string funcName ,string massage  ) {
        if (!Directory.Exists(currentFolderRoute()))
        {
            Directory.CreateDirectory(currentFolderRoute());
        }

        using (StreamWriter writer = new StreamWriter(currentFolderRoute(), append: true))
        {
            writer.WriteLine($" {DateTime.Now}\t{projectName}.{funcName}:\t {massage}");
        }

    }

    public static void cleanLogFolders()
    {
        if (!Directory.Exists(currentFolderRoute()))
        {
            return;
        }

        // חישוב הרף: תחילת החודש לפני חודשיים
        DateTime now = DateTime.Now;
        DateTime thresholdDate = new DateTime(now.Year, now.Month, 1).AddMonths(-2);

        // מעבר על כל תיקיות המשנה תחת תיקיית הלוגים
        string[] subDirectories = Directory.GetDirectories(logRoute);

        foreach (string dir in subDirectories)
        {
            string dirName = Path.GetFileName(dir); // לדוגמה: "9-2026" או "11-2026"
            string[] parts = dirName.Split('-');

            if (parts.Length == 2 && int.TryParse(parts[0], out int month) && int.TryParse(parts[1], out int year))
            {
                try
                {
                    DateTime folderDate = new DateTime(year, month, 1);

                    // אם התיקייה ישנה יותר מהרף (כלומר מוקדמת מ-2 חודשים אחרונים)
                    if (folderDate < thresholdDate)
                    {
                        Directory.Delete(dir, true); // true מוחק את התיקייה יחד עם כל התוכן שבתוכה
                    }
                }
                catch (Exception)
                {
                    // במקרה של בעיית גישה או קובץ נעול, ניתן לטפל או להמשיך הלאה
                }
            }

        }

        }
}