﻿using System.Collections.Generic;

namespace Amica.Models.Features
{
    class Feature
    {
        public string Name { get; internal set; }
        public string DisplayName { get; internal set; }
        public string Tag { get; internal set; }
        public List<string> Plans { get; internal set; }
    }
}
