﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Owasp.SQL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="OwaspExample")]
	public partial class OwaspExampleDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCar(Car instance);
    partial void UpdateCar(Car instance);
    partial void DeleteCar(Car instance);
    partial void InsertPrivateData(PrivateData instance);
    partial void UpdatePrivateData(PrivateData instance);
    partial void DeletePrivateData(PrivateData instance);
    #endregion
		
		public OwaspExampleDataContext() : 
				base(global::Owasp.SQL.Properties.Settings.Default.OwaspExampleConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public OwaspExampleDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OwaspExampleDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OwaspExampleDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OwaspExampleDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Car> Cars
		{
			get
			{
				return this.GetTable<Car>();
			}
		}
		
		public System.Data.Linq.Table<PrivateData> PrivateDatas
		{
			get
			{
				return this.GetTable<PrivateData>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cars")]
	public partial class Car : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CarID;
		
		private string _CarName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCarIDChanging(int value);
    partial void OnCarIDChanged();
    partial void OnCarNameChanging(string value);
    partial void OnCarNameChanged();
    #endregion
		
		public Car()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CarID
		{
			get
			{
				return this._CarID;
			}
			set
			{
				if ((this._CarID != value))
				{
					this.OnCarIDChanging(value);
					this.SendPropertyChanging();
					this._CarID = value;
					this.SendPropertyChanged("CarID");
					this.OnCarIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CarName
		{
			get
			{
				return this._CarName;
			}
			set
			{
				if ((this._CarName != value))
				{
					this.OnCarNameChanging(value);
					this.SendPropertyChanging();
					this._CarName = value;
					this.SendPropertyChanged("CarName");
					this.OnCarNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PrivateData")]
	public partial class PrivateData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Username;
		
		private int _PrivateDataId;
		
		private string _Secret;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPrivateDataIdChanging(int value);
    partial void OnPrivateDataIdChanged();
    partial void OnSecretChanging(string value);
    partial void OnSecretChanged();
    #endregion
		
		public PrivateData()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrivateDataId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PrivateDataId
		{
			get
			{
				return this._PrivateDataId;
			}
			set
			{
				if ((this._PrivateDataId != value))
				{
					this.OnPrivateDataIdChanging(value);
					this.SendPropertyChanging();
					this._PrivateDataId = value;
					this.SendPropertyChanged("PrivateDataId");
					this.OnPrivateDataIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Secret", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Secret
		{
			get
			{
				return this._Secret;
			}
			set
			{
				if ((this._Secret != value))
				{
					this.OnSecretChanging(value);
					this.SendPropertyChanging();
					this._Secret = value;
					this.SendPropertyChanged("Secret");
					this.OnSecretChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
