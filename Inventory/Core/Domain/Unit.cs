﻿using System;
using System.Collections.Generic;

namespace Inventory.Core.Domain
{
    public class Unit
    {
        public Unit()
        {
            Licences = new HashSet<Licence>();
        }
        public Guid ID { get; set; }
        public int MyProperty { get; set; }
        public virtual Model Model { get; set; }
        public virtual ICollection<Licence> Licences { get; set; }
    }
}