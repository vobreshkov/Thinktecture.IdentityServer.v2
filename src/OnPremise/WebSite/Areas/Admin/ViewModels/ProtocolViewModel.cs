﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Thinktecture.IdentityServer.Models.Configuration;

namespace Thinktecture.IdentityServer.Web.Areas.Admin.ViewModels
{
    public class ProtocolViewModel
    {
        public string ID { get; set; }
        public string DisplayName { get; set; }
        public ProtocolConfiguration Protocol { get; set; }
    }
}