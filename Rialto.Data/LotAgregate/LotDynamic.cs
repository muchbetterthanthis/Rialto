﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rialto.Data.Interfaces;


namespace Rialto.Data.LotAgregate
{
    
        public class LotDynamic
        {
            public int ID { get; set; }
            public DateTime DateOfChange { get; set; }
            public double Delta { get; set; }
        public Lot Lot { get; set; }
            public LotDynamic(DateTime DateOfChange, double Delta)
            {
                this.DateOfChange = DateOfChange;
                this.Delta = Delta;
            }
        }
}
