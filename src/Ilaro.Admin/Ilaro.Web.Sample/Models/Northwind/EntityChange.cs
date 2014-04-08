﻿using Ilaro.Admin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ilaro.Web.Sample.Models.Northwind
{
	public class EntityChange : IEntityChange
	{
		public int EntityChangeId { get; set; }

		public string EntityName { get; set; }

		public string EntityKey { get; set; }

		public EntityChangeType ChangeType { get; set; }

		public string Description { get; set; }

		public DateTime ChangedOn { get; set; }

		public string ChangedBy { get; set; }
	}
}