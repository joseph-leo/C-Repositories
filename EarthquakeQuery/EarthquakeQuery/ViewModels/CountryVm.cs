using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EarthquakeQuery.ViewModels
{
    public class CountryVm
    {

        public string Name { get; set; }
        public IEnumerable<SelectListItem> Items { get; set; }
    }
}