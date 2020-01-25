using System;
using System.Collections.Generic;
using System.Text;
using static MobileHomework1._5.Enum;

namespace MobileHomework1._5.Models
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        //Guid creates a unique identifier for records
        public Guid ID { get; set; }
        public SchoolProgram Program { get; set; }

    }
}
