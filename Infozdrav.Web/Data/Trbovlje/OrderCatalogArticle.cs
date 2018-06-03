﻿using System;
using System.Collections.Generic;

namespace Infozdrav.Web.Data
{
    public class OrderCatalogArticle : Entity
    {
        public int? CatalogArticleId { get; set; }
        public CatalogArticle CatalogArticle { get; set; }

        public int? UrgencyDegreeId { get; set; }
        public UrgencyDegree UrgencyDegree { get; set; }

        public string Note { get; set; }

        public DateTime? ReceptionTime { get; set; }
        public User ReceptionUser { get; set; }

        public int Quantity { get; set; }

        public bool Confirmed { get; set; }
    }
}