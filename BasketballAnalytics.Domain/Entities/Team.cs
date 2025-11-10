using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballAnalytics.Domain.Entities
{
    public class Team
    {
            public Guid Id { get; set;}
            public string Name { get; set;}

            public string City { get; set;}
    }
}