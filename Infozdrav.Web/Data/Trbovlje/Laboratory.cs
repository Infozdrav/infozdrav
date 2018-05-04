﻿using System.Collections.Generic;

namespace Infozdrav.Web.Data
{
    public class Laboratory : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Article> Articles { get; set; }
    }
}