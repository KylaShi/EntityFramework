﻿using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPrac
{
	public class EFCoreDBContextFactory : IDesignTimeDbContextFactory<EFCoreDBContext>
	{
		public EFCoreDBContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<EFCoreDBContext>();
			var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
			var config = builder.Build();
			var connString = config.GetSection("DatabaseProviders")
				.GetSection("Local")["ConnectionString"];

			

			optionsBuilder.UseSqlServer(connString);
			return new EFCoreDBContext(optionsBuilder.Options);

		}


	}
}