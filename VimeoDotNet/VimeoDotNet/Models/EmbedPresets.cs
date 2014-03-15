﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VimeoDotNet.Helpers;

namespace VimeoDotNet.Models
{
    [Serializable]
    public class EmbedPresets
    {
        public long? id
        {
            get { return ModelHelpers.ParseModelUriId(uri); }
        }

        public string uri { get; set; }
        public string name { get; set; }
        public PresetSettings settings { get; set; }
    }
}
