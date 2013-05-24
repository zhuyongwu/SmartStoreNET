﻿using SmartStore.Web.Framework;
using SmartStore.Web.Framework.Mvc;

namespace SmartStore.Admin.Models.Orders
{
    public class NeverSoldReportLineModel : ModelBase
    {
        public int ProductVariantId { get; set; }
        [SmartResourceDisplayName("Admin.SalesReport.NeverSold.Fields.Name")]
        public string ProductVariantFullName { get; set; }
    }
}