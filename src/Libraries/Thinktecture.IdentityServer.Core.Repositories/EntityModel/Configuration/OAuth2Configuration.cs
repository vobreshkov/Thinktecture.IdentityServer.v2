﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IdentityServer.Repositories.Sql.Configuration
{
    public class OAuth2Configuration
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool Enabled { get; set; }

        public bool EnableConsent { get; set; }
        public bool EnableResourceOwnerFlow { get; set; }
        public bool EnableImplicitFlow { get; set; }        
    }
}
