﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace newconsoleapp
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EYdatabase")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::newconsoleapp.Properties.Settings.Default.EYdatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<subject2> subject2s
		{
			get
			{
				return this.GetTable<subject2>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.subject2")]
	public partial class subject2
	{
		
		private int _studid;
		
		private string _sub_name;
		
		private int _marks;
		
		public subject2()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studid", DbType="Int NOT NULL")]
		public int studid
		{
			get
			{
				return this._studid;
			}
			set
			{
				if ((this._studid != value))
				{
					this._studid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sub_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string sub_name
		{
			get
			{
				return this._sub_name;
			}
			set
			{
				if ((this._sub_name != value))
				{
					this._sub_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_marks", DbType="Int NOT NULL")]
		public int marks
		{
			get
			{
				return this._marks;
			}
			set
			{
				if ((this._marks != value))
				{
					this._marks = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
