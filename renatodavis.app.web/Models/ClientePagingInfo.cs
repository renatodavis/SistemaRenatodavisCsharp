using renatodavis.app.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace renatodavis.app.web.Models
{
    public class ClientePagingInfo
    {
        public int? pageSize;
        public int sortBy;
        public string Search;
        public bool isAsc { get; set; }
        public StaticPagedList<Cliente> Clientes { get; set; }
    }
}
