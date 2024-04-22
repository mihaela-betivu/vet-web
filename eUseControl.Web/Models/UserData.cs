using System;
using System.Collections.Generic;
using eUseControl.Domain.Entities.Enums;

namespace eUseControl.Web.Models
{
    public class UserData
    {
        public string Username { get; set; }
        
        public URole Level { get; set; }
    }
}