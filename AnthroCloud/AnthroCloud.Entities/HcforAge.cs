﻿using System;
using System.Collections.Generic;

namespace AnthroCloud.Entities
{
    public partial class HcForAge
    {
        public byte Month { get; set; }
        public byte Sex { get; set; }
        public byte? L { get; set; }
        public decimal? M { get; set; }
        public decimal? S { get; set; }
        public decimal? Sd3neg { get; set; }
        public decimal? Sd2neg { get; set; }
        public decimal? Sd1neg { get; set; }
        public decimal? Sd0 { get; set; }
        public decimal? Sd1 { get; set; }
        public decimal? Sd2 { get; set; }
        public decimal? Sd3 { get; set; }
        public decimal? P3 { get; set; }
        public decimal? P15 { get; set; }
        public decimal? P50 { get; set; }
        public decimal? P85 { get; set; }
        public decimal? P97 { get; set; }
    }
}