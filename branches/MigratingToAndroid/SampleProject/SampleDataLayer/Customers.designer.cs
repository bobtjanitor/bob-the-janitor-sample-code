﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3082
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleDataLayer
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="WebApp")]
	public partial class CustomersDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public CustomersDataContext() : 
				base(global::SampleDataLayer.Properties.Settings.Default.WebAppConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CustomersDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CustomersDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CustomersDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CustomersDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Customer_To_Email> Customer_To_Emails
		{
			get
			{
				return this.GetTable<Customer_To_Email>();
			}
		}
		
		public System.Data.Linq.Table<Email> Emails
		{
			get
			{
				return this.GetTable<Email>();
			}
		}
		
		public System.Data.Linq.Table<Email_Type> Email_Types
		{
			get
			{
				return this.GetTable<Email_Type>();
			}
		}
	}
	
	[Table(Name="dbo.Customers")]
	public partial class Customer
	{
		
		private int _ID;
		
		private string _User_Name;
		
		private string _Password;
		
		private string _Fist_Name;
		
		private string _Last_Name;
		
		public Customer()
		{
		}
		
		[Column(Storage="_ID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[Column(Storage="_User_Name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string User_Name
		{
			get
			{
				return this._User_Name;
			}
			set
			{
				if ((this._User_Name != value))
				{
					this._User_Name = value;
				}
			}
		}
		
		[Column(Storage="_Password", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this._Password = value;
				}
			}
		}
		
		[Column(Storage="_Fist_Name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Fist_Name
		{
			get
			{
				return this._Fist_Name;
			}
			set
			{
				if ((this._Fist_Name != value))
				{
					this._Fist_Name = value;
				}
			}
		}
		
		[Column(Storage="_Last_Name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this._Last_Name = value;
				}
			}
		}
	}
	
	[Table(Name="dbo.Customer_To_Email")]
	public partial class Customer_To_Email
	{
		
		private int _ID;
		
		private int _Customer_ID;
		
		private int _Email_ID;
		
		public Customer_To_Email()
		{
		}
		
		[Column(Storage="_ID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[Column(Storage="_Customer_ID", DbType="Int NOT NULL")]
		public int Customer_ID
		{
			get
			{
				return this._Customer_ID;
			}
			set
			{
				if ((this._Customer_ID != value))
				{
					this._Customer_ID = value;
				}
			}
		}
		
		[Column(Storage="_Email_ID", DbType="Int NOT NULL")]
		public int Email_ID
		{
			get
			{
				return this._Email_ID;
			}
			set
			{
				if ((this._Email_ID != value))
				{
					this._Email_ID = value;
				}
			}
		}
	}
	
	[Table(Name="dbo.Email")]
	public partial class Email
	{
		
		private int _ID;
		
		private string _Address;
		
		private int _Type_ID;
		
		public Email()
		{
		}
		
		[Column(Storage="_ID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[Column(Storage="_Address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[Column(Storage="_Type_ID", DbType="Int NOT NULL")]
		public int Type_ID
		{
			get
			{
				return this._Type_ID;
			}
			set
			{
				if ((this._Type_ID != value))
				{
					this._Type_ID = value;
				}
			}
		}
	}
	
	[Table(Name="dbo.Email_Type")]
	public partial class Email_Type
	{
		
		private int _ID;
		
		private string _Description;
		
		public Email_Type()
		{
		}
		
		[Column(Storage="_ID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[Column(Storage="_Description", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
	}
}
#pragma warning restore 1591