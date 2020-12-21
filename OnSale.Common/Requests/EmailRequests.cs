using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnSale.Common.Requests
{
     public class EmailRequests
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
