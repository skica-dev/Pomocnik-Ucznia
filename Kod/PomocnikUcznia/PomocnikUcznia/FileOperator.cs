using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PomocnikUcznia
{
    class FileOperator
    {

        private string path = null;

        public FileOperator()
        {
            // Konstruktor
            path = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"));
        }
        public string[] getDataFromFile(string dayOfWeek)
        {
            // Zmienne 
            string[] tableData = new string[9];

            for (int i = 0; i < 9; i++)
            {
                tableData[i] = "";
            }

            try
            {
               
                string plik = path + "\\" + dayOfWeek + ".xml";
                XmlTextReader reader = new XmlTextReader(plik);
                bool isHour = false;
                bool isLesson = false;
                int count = 0;
                while (reader.Read())
                {

                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element: // XML w zapisie jest elementem.
                            isHour = String.Equals(reader.Name, "hour", StringComparison.Ordinal);
                            isLesson = String.Equals(reader.Name, "lesson", StringComparison.Ordinal);
                            if (isLesson)
                            {
                                count = count + 1;
                            }
                            break;
                        case XmlNodeType.Text: // Text
                            if (isHour)
                            {
                                tableData[0] = reader.Value;
                                isHour = false;
                            }
                            if (isLesson)
                            {
                                //count = count + 1;
                                tableData[count] = reader.Value;
                            }
                            break;
                    }
                }
                reader.Close();
            } catch (Exception e) {
                e.ToString();
            }
            return tableData;
        }
        
        public void saveData(string dayOfWeek, string[] tableData)
        {
            if (tableData != null)
            {

                string plik = path + "\\" + dayOfWeek + ".xml";
                Encoding kodowanie = Encoding.GetEncoding("iso-8859-2");

                using (XmlTextWriter tw = new XmlTextWriter(plik, kodowanie))
                {
                    tw.WriteStartDocument();
                    tw.WriteWhitespace("\n");
                    tw.WriteStartElement("plan");
                    tw.WriteWhitespace("\n");

                    tw.WriteStartElement("hour");
                    tw.WriteString("" + tableData[0]);
                    tw.WriteEndElement();
                    tw.WriteWhitespace("\n");

                    for (int i = 0; i < tableData.Length-1 ; i++)
                    {
                        tw.WriteStartElement("lesson");
                        tw.WriteString("" + tableData[i+1]);
                        tw.WriteEndElement();
                        tw.WriteWhitespace("\n");

                    }
                    tw.WriteEndElement();
                    tw.WriteWhitespace("\n");
                    tw.WriteEndDocument();
                    tw.Close();
                }
            }
        }
    }

}
