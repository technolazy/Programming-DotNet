﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    public class Author
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string UserName { get; set; }

        public List<Article> Articles { get; set; }
    }
}
