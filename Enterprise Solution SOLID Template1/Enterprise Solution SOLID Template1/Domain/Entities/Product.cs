using System;
using Enterprise_Solution_SOLID_Template1.Domain.Values;

namespace Enterprise_Solution_SOLID_Template1.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Money Price { get; set; }
    }
}
