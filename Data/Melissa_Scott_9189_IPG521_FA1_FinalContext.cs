using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Melissa_Scott_9189_IPG521_FA1_Final.Data
{
    public class Melissa_Scott_9189_IPG521_FA1_FinalContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Melissa_Scott_9189_IPG521_FA1_FinalContext() : base("name=Melissa_Scott_9189_IPG521_FA1_FinalContext")
        {
        }

        public System.Data.Entity.DbSet<Melissa_Scott_9189_IPG521_FA1_Final.Models.Facilitator> Facilitators { get; set; }
    }
}
