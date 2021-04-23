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
        private static string _splitter = "123ImSplitter!PleaseDontTouchMe!321";
        public static void SaveFile(string path, string fileDataFroms, string fileDataArrows)
        {            
            using (StreamWriter saveSW = new StreamWriter(path, false))
            {
                saveSW.WriteLine($"{fileDataFroms}{Environment.NewLine}{_splitter}{Environment.NewLine}{fileDataArrows}");
            }
        }

        public static string[] OpenFile(string path, TypeOfData type)
        {
            string[] fileData = new string[] { String.Empty };
            using (StreamReader openSR = new StreamReader(path))
            {                
                fileData = openSR.ReadToEnd().Split(new[] { _splitter }, StringSplitOptions.None);
            }
            return fileData;
        }
    }
}

