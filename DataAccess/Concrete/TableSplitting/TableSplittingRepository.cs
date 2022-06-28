using Entities.TableSpliting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.TableSplitting
{
    public class TableSplittingRepository
    {
        private TestContext testContext;

        public TableSplittingRepository()
        {
            testContext = new TestContext();    
        }

        public void AddTableSplitting(Order ord)
        {
            testContext.Add(ord);
            testContext.SaveChanges();
        }

        public List<Order> GetOrders()
        {
            return testContext.Orders.ToList();
        }
    }
}
