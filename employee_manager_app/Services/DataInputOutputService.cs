using employee_manager_app.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_manager_app.Services
{
    internal class DataInputOutputService
    {
        private readonly string PATH;

        public DataInputOutputService(string path)
        {
            PATH = path;
        }
        public BindingList<applicant> LoadData()
        {
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<applicant>();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<applicant>>(fileText);
            }
        }

        public void SaveData(object applicantDataList)
        {
            using (StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(applicantDataList);
                writer.Write(output);

            }
        }
    }
}
