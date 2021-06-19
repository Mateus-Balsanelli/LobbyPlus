﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Model
{
    public class Page
    {
        public long PageId { get; set; }

        public string MainPage { get; set; }

        public string Resume { get; set; }

        public string longDescription { get; set; }

        public string LinkYoutube { get; set; }

        public string Updates { get; set; }

        public string ReleaseNotes { get; set; }

        public Game game { get; set; }
    }
}
