using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TableSpliting
{
    public class Order
    {
        public int Id { get; set; }

        public OrderStatus? Status { get; set; }

        public DetailedOrder DetailedOrder { get; set; }

        public override string ToString()
        {
            return $"{Id} {Status}";
        }

    }
}
