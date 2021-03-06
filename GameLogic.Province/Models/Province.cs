﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Provinces.Models
{
    public enum ProductionResource { Grain, Iron, Diamond, Gold, Wine, Salt}

    public class Province
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int TaxIncome { get; set; }
        public Resource Resource { get; set; }
        public int PopulationSize { get; set; }

        public float CalculateIncomePerTick() {
            return PopulationSize / Resource.ResourceValue;
        }
       
    }

    public class Resource {
        public ProductionResource ProductionResource { get; set; }
        public float ResourceValue {get; set;}

        public void IncreaseResourceValue(int percentIncrease) {
            ResourceValue += (ResourceValue * ((float)percentIncrease / 100)); 
        }
    }
}
