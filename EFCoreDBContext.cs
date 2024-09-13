using EFPrac.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPrac
{
	public class EFCoreDBContext : DbContext
	{

		public EFCoreDBContext(DbContextOptions<EFCoreDBContext> options) : base(options)
		{

		}

		public EFCoreDBContext(){
		}
		public DbSet<Student> Students { get; set; }
	}
}