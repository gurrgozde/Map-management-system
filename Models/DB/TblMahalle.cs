using System;
using System.Collections.Generic;

namespace DrawMap.Models.DB
{
    public partial class TblMahalle
    {
        public int MahalleId { get; set; }
        public string MahalleName { get; set; }
        public string MahalleCode { get; set; }
    }
}
