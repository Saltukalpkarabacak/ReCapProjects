using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Card : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CardNo { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Cvv { get; set; }
    }
}
