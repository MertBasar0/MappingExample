using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TableSpliting
{
    public class DetailedOrder
    {
        public int Id { get; set; }

        public OrderStatus? Status { get; set; }

        public string Adi { get; set; }

        public string Tarih { get; set; }

        public string lokasyon { get; set; }

        public override string ToString()
        {
            return $"{Adi} {Tarih} {lokasyon}";
        }

    }
}
