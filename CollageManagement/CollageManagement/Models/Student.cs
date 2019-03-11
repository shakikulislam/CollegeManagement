﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollageManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Session { get; set; }

        public Student(int id, string name, int session)
        {
            this.Id = id;
            this.Name = name;
            this.Session = session;
        }
    }
}
