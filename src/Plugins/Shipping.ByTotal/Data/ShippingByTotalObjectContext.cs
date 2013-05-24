﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SmartStore.Core;
using SmartStore.Data;

namespace SmartStore.Plugin.Shipping.ByTotal.Data
{
    /// <summary>
    /// Object context
    /// </summary>
    public class ShippingByTotalObjectContext : ObjectContextBase
    {
        //public const string ALIASKEY = "sm_object_context_tax_country_state_zip";
        public const string ALIASKEY = "sm_object_context_shipping_by_total"; 
        
        public ShippingByTotalObjectContext(string nameOrConnectionString)
            : base(nameOrConnectionString, ALIASKEY)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ShippingByTotalRecordMap());

            //disable EdmMetadata generation
            //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// Install
        /// </summary>
        public void Install()
        {
            //It's required to set initializer to null (for SQL Server Compact).
            //otherwise, you'll get something like "The model backing the 'your context name' context has changed since the database was created. Consider using Code First Migrations to update the database"            
            Database.SetInitializer<ShippingByTotalObjectContext>(null);

            //create table
            var dbScript = CreateDatabaseScript();
            Database.ExecuteSqlCommand(dbScript);
            SaveChanges();
        }

        /// <summary>
        /// Uninstall
        /// </summary>
        public void Uninstall()
        {
            var dbScript = "DROP TABLE ShippingByTotal";
            Database.ExecuteSqlCommand(dbScript);
            SaveChanges();
        }

    }
}