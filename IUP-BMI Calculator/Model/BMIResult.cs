using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUP_BMI_Calculator.Model
{
    [Table("BMIResult")]
    public class BMIResult
    {
        [PrimaryKey, AutoIncrement]
        public int id {get; set;}
        public string name { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public double BMIScore { get; set; }
        public string result { get; set; }
            
    }
}
