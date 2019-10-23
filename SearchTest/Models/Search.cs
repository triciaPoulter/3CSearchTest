using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace SearchTest.Models
{    public class Search
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Location { get; set; }
        public string Avatar { get; set; }
    }
    public class RootObject
    {
        public RootObject(List<Search> search)
        {
            Search = search;
        }

        public List<Search> Search { get; set; }
    }

}