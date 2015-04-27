﻿//Test model for an Entity

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WebVella.ERP.Web.Models
{
    public class Entity
    {

		public Entity() {
			Id = Guid.Empty;
			Name = String.Empty;
			Label = String.Empty;
			LabelPlural = String.Empty;
			IsSystem = false;
			Weight = 0;
		}

		[JsonProperty(PropertyName = "id")]
		public Guid Id { get; set; }

		//Unique technical name of the entity, e.g. order. Cannot be dashboard, search as they are used by the system
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		//Human readable identifier of a single instance of this entity, e.g. Order
		[JsonProperty(PropertyName = "label")]
		public string Label { get; set; }

		//Human readable identifier of two instances of this entity, e.g. Orders
		[JsonProperty(PropertyName = "labelPlural")]
		public string LabelPlural { get; set; }

		//Is the entity system- cannot be deleted
		[JsonProperty(PropertyName = "isSystem")]
		public bool IsSystem { get; set; }

		//Weight- way of sorting ares in the list, Bigger weight sinks the element down the list
		[JsonProperty(PropertyName = "weight")]
		public int Weight { get; set; }

		//Fields
		//Views
		//Forms

	}
}