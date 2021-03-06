﻿using System.ComponentModel.DataAnnotations;

namespace Infozdrav.Web.Data.Trbovlje
{
    public enum WriteOffReason
    {
        [Display(Name = "Slab lot")]
        BadLot,
        [Display(Name = "Izdelek je pretekel")]
        Expired,
        [Display(Name = "Izdelek je bil uporabljen")]
        AllUnitsUsed,
        [Display(Name = "Izdelek je bil zavrnjen")]
        Rejected,
        [Display(Name = "Drug razlog")]
        Other
    }
}