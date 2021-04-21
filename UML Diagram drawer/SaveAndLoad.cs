using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UML_Diagram_drawer.Forms;
using UML_Diagram_drawer.Arrows;
using Form = System.Windows.Forms.Form;
using UML_Diagram_drawer.Factory;

namespace UML_Diagram_drawer
{
    public static class SaveAndLoad
    {
        public static void SaveFile(string path, string fileData)
        {
            StreamWriter saveSW = new StreamWriter(path, false);

            using (saveSW)
            {
                saveSW.WriteLine();
            }
        }

        public static string OpenFile(string path, TypeOfData type)
        {
            StreamReader openSR = new StreamReader(path);
            string fileDataForms = String.Empty;
            string fileDataArrows = String.Empty;

            using (openSR)
            {                
                fileDataForms = openSR.ReadLine();
                fileDataArrows = openSR.ReadLine();
            }
            if(type == TypeOfData.Forms)
            {
                return fileDataForms;
            }
            else if(type == TypeOfData.Arrows)
            {
                return fileDataArrows;
            }
            throw new Exception();
        }
    }
}

