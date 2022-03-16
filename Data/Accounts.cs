using System.Collections.Generic;

namespace Microtech_WebApiTask_3.Data
{
    public class Accounts
    {
        public Accounts() => Children = new HashSet<Accounts>();

        public string Id { get; set; }
        public string Parent { get; set; }
        public decimal? Balance { get; set; }
        public decimal Total { get; set; }
        public ICollection<Accounts> Children { get; set; }
    }
}
