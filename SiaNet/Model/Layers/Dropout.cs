﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaNet.Model.Layers
{
    public class Dropout : LayerConfig
    {
        public Dropout()
        {
            base.Name = "Dropout";
            base.Params = new ExpandoObject();
        }

        public Dropout(float rate)
            : this()
        {
            Rate = rate;
        }

        [Newtonsoft.Json.JsonIgnore]
        public float Rate
        {
            get
            {
                return base.Params.Rate;
            }

            set
            {
                base.Params.Rate = value;
            }
        }

    }
}