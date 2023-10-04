using FreelancerApp.Abstract;
using FreelancerApp.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Services
{
    internal class NotepadService
    {
        public void SaveToNotepad(ICsvConvertible data)
        {
            string path = $"{FileLocations.ProjectFolder}\\Database";
            string type = data.GetType().ToString().Split(',').LastOrDefault();

            if (!File.Exists(path))
                Directory.CreateDirectory(path);

            string filepath = $"{path}\\{type}s.txt";

            File.AppendAllText(filepath, $"{data.GetValuesCSV()}\n");
        }

        public string GetOnNotepad()
        {
            string path = @$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\Database";
            string filePath = $"{path}\\Customers.txt";

            if (File.Exists(filePath))
                return File.ReadAllText(filePath);

            throw new Exception("File Path Does Not Exist!");
        }
    }
}
