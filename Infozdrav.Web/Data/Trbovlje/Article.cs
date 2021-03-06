﻿using System;
using System.Collections.Generic;
using Infozdrav.Web.Data.Manage;

namespace Infozdrav.Web.Data.Trbovlje
{
    public class Article : Entity
    {
        public string ReadArticleCode { get; set; }
        public int CatalogArticleId { get; set; }
        public CatalogArticle CatalogArticle { get; set; }

        public string Lot { get; set; }
        public DateTime? UseByDate { get; set; }
        public int NumberOfUnits { get; set; }
        public decimal DeliveryCost { get; set; }

        public bool Rejected { get; set; }
        public string Note { get; set; }

        public int? StorageTypeId { get; set; }
        public StorageType StorageType { get; set; }
        public int? StorageLocationId { get; set; }
        public StorageLocation StorageLocation { get; set; }
        public int? WorkLocationId { get; set; }
        public WorkLocation WorkLocation { get; set; }
        public int? AnalyserId { get; set; }
        public Analyser Analyser { get; set; }

        public DataFile Certificate { get; set; }
        public DataFile SafteyList { get; set; }

        public DateTime? ReceptionTime { get; set; }
        public User ReceptionUser { get; set; }

        public IEnumerable<ArticleUse> ArticleUses { get; set; }
        public IEnumerable<Lend> Lends { get; set; }

        public DateTime? WriteOffTime { get; set; }
        public User WriteOfUser { get; set; }
        public WriteOffReason? WriteOffReason { get; set; }
        public string WriteOffNote { get; set; }
    }
}