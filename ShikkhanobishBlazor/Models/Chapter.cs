﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShikkhanobishBlazor.Models
{
    public class Chapter
    {
        public int subjectID { get; set; }
        public int chapterID { get; set; }
        public int classID { get; set; }
        public string title { get; set; }
        public string name { get; set; }
        public int tuitionRequest { get; set; }
        public double avgRatting { get; set; }
        public int indexNo { get; set; }
        public string Response { get; set; }
    }
}
