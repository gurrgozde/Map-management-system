using System;
using System.Collections.Generic;

namespace DrawMap.Models.DB
{
    public partial class TblKapı
    {
        public int KapıId { get; set; }
        public string MahalleCode { get; set; }
        public string Koordinat { get; set; }
    }
}
