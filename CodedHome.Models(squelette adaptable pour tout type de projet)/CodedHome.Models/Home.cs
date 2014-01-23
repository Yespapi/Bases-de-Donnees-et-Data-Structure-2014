﻿using System;
using CodedHome.Models;


namespace CodedHomes.Models
{
    public class Home : IAuditInfo
    {
        
        public int Id { get; set; }

        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
       
        public string City { get; set; }
      
        public int ZipCode { get; set; }
      
        public int Bathrooms { get; set; }
       
        public int Bedrooms { get; set; }
       
        public int SquareFeet { get; set; }
       
        public int Price { get; set; }
       
        public string Description { get; set; }
        public string ImageName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}