﻿using System;
using System.Collections.Generic;
using SmartStore.Core.Domain.Catalog;
using SmartStore.Core.Domain.Orders;
using SmartStore.Core.Domain.Payments;
using SmartStore.Core.Domain.Shipping;

namespace SmartStore.Core.Domain.DataExchange
{
	[Serializable]
	public class ExportFilter
	{
		/// <summary>
		/// Store identifier; 0 to load all records
		/// </summary>
		public int StoreId { get; set; }

		/// <summary>
		/// Entity created from
		/// </summary>
		public DateTime? CreatedFrom { get; set; }

		/// <summary>
		/// Entity created to
		/// </summary>
		public DateTime? CreatedTo { get; set; }

		#region Product

		/// <summary>
		/// Minimum price
		/// </summary>
		public decimal? PriceMinimum { get; set; }

		/// <summary>
		/// Maximum price
		/// </summary>
		public decimal? PriceMaximum { get; set; }

		/// <summary>
		/// Minimum product availability
		/// </summary>
		public int? AvailabilityMinimum { get; set; }

		/// <summary>
		/// Maximum product availability
		/// </summary>
		public int? AvailabilityMaximum { get; set; }

		/// <summary>
		/// A value indicating whether to load only published or non published products
		/// </summary>
		public bool? IsPublished { get; set; }

		/// <summary>
		/// Category identifiers
		/// </summary>
		public int[] CategoryIds { get; set; }

		/// <summary>
		/// A value indicating whether to load products without any catgory mapping
		/// </summary>
		public bool? WithoutCategories { get; set; }

		/// <summary>
		/// Manufacturer identifiers
		/// </summary>
		public int[] ManufacturerIds { get; set; }

		/// <summary>
		/// A value indicating whether to load products without any manufacturer mapping
		/// </summary>
		public bool? WithoutManufacturers { get; set; }

		/// <summary>
		/// Identifiers of product tags
		/// </summary>
		public int[] ProductTagIds { get; set; }

		/// <summary>
		/// A value indicating whether to load products that are marked as featured (relates only to categories and manufacturers)
		/// </summary>
		public bool? FeaturedProducts { get; set; }

		/// <summary>
		/// Filter by product type
		/// </summary>
		public ProductType? ProductType { get; set; }

		#endregion

		#region Order

		/// <summary>
		/// Filter by order status
		/// </summary>
		public OrderStatus[] OrderStatus { get; set; }

		/// <summary>
		/// Filter by payment status
		/// </summary>
		public PaymentStatus[] PaymentStatus { get; set; }

		/// <summary>
		/// Filter by shipping status
		/// </summary>
		public ShippingStatus[] ShippingStatus { get; set; }

		/// <summary>
		/// Identifiers of customer roles
		/// </summary>
		public int[] CustomerRoleIds { get; set; }

		#endregion
	}
}
