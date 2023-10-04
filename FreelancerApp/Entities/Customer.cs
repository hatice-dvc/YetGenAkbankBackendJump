using FreelancerApp.Abstract;
using FreelancerApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Entities
{
    internal class Customer : Person<Guid>, ICsvConvertible
    {
        public string PhoneNumber { get; set; }

        public string GetValuesCSV()
        {
            return $"{Id},{CreatedDate},{FirstName},{LastName},{PhoneNumber}";
        }

        public void SetValuesCSV(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Id = Guid.Parse(values[0]);
            CreatedDate = DateTimeOffset.Parse(values[1]);
            FirstName = values[2];
            LastName = values[3];
            PhoneNumber = values[4];
        }
    }
}
