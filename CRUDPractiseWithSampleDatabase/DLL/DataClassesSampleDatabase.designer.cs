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

namespace CRUDPractiseWithSampleDatabase.DLL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SampleDatabase")]
	public partial class DataClassesSampleDatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertItemOrProduct(ItemOrProduct instance);
    partial void UpdateItemOrProduct(ItemOrProduct instance);
    partial void DeleteItemOrProduct(ItemOrProduct instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertUserDetail(UserDetail instance);
    partial void UpdateUserDetail(UserDetail instance);
    partial void DeleteUserDetail(UserDetail instance);
    partial void InsertUserType(UserType instance);
    partial void UpdateUserType(UserType instance);
    partial void DeleteUserType(UserType instance);
    #endregion
		
		public DataClassesSampleDatabaseDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SampleDatabaseConnection"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSampleDatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSampleDatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSampleDatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSampleDatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ItemOrProduct> ItemOrProducts
		{
			get
			{
				return this.GetTable<ItemOrProduct>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<UserDetail> UserDetails
		{
			get
			{
				return this.GetTable<UserDetail>();
			}
		}
		
		public System.Data.Linq.Table<UserType> UserTypes
		{
			get
			{
				return this.GetTable<UserType>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetUserDetails")]
		public ISingleResult<GetUserDetailsResult> GetUserDetails()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetUserDetailsResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ItemOrProduct")]
	public partial class ItemOrProduct : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ItemID;
		
		private string _Name;
		
		private System.Nullable<decimal> _PurchasePrice;
		
		private System.Nullable<decimal> _SalesPrice;
		
		private System.Nullable<double> _OpeningQty;
		
		private System.Nullable<System.Guid> _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<System.Guid> _ModifiedBy;
		
		private System.Nullable<System.DateTime> _ModifiedOn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItemIDChanging(System.Guid value);
    partial void OnItemIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPurchasePriceChanging(System.Nullable<decimal> value);
    partial void OnPurchasePriceChanged();
    partial void OnSalesPriceChanging(System.Nullable<decimal> value);
    partial void OnSalesPriceChanged();
    partial void OnOpeningQtyChanging(System.Nullable<double> value);
    partial void OnOpeningQtyChanged();
    partial void OnCreatedByChanging(System.Nullable<System.Guid> value);
    partial void OnCreatedByChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedByChanging(System.Nullable<System.Guid> value);
    partial void OnModifiedByChanged();
    partial void OnModifiedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnModifiedOnChanged();
    #endregion
		
		public ItemOrProduct()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ItemID
		{
			get
			{
				return this._ItemID;
			}
			set
			{
				if ((this._ItemID != value))
				{
					this.OnItemIDChanging(value);
					this.SendPropertyChanging();
					this._ItemID = value;
					this.SendPropertyChanged("ItemID");
					this.OnItemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchasePrice", DbType="Money")]
		public System.Nullable<decimal> PurchasePrice
		{
			get
			{
				return this._PurchasePrice;
			}
			set
			{
				if ((this._PurchasePrice != value))
				{
					this.OnPurchasePriceChanging(value);
					this.SendPropertyChanging();
					this._PurchasePrice = value;
					this.SendPropertyChanged("PurchasePrice");
					this.OnPurchasePriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalesPrice", DbType="Decimal(18,6)")]
		public System.Nullable<decimal> SalesPrice
		{
			get
			{
				return this._SalesPrice;
			}
			set
			{
				if ((this._SalesPrice != value))
				{
					this.OnSalesPriceChanging(value);
					this.SendPropertyChanging();
					this._SalesPrice = value;
					this.SendPropertyChanged("SalesPrice");
					this.OnSalesPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OpeningQty", DbType="Float")]
		public System.Nullable<double> OpeningQty
		{
			get
			{
				return this._OpeningQty;
			}
			set
			{
				if ((this._OpeningQty != value))
				{
					this.OnOpeningQtyChanging(value);
					this.SendPropertyChanging();
					this._OpeningQty = value;
					this.SendPropertyChanged("OpeningQty");
					this.OnOpeningQtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedBy", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedBy", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerID;
		
		private string _Name;
		
		private string _Address;
		
		private System.Nullable<System.Guid> _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<System.Guid> _ModifiedBy;
		
		private System.Nullable<System.DateTime> _ModifiedOn;
		
		private string _Gender;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCreatedByChanging(System.Nullable<System.Guid> value);
    partial void OnCreatedByChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedByChanging(System.Nullable<System.Guid> value);
    partial void OnModifiedByChanged();
    partial void OnModifiedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnModifiedOnChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    #endregion
		
		public Customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(100)")]
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
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedBy", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedBy", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(10)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserDetail")]
	public partial class UserDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _UserID;
		
		private string _UserName;
		
		private string _FullName;
		
		private string _PasswordAsHash;
		
		private System.Nullable<System.Guid> _CreatedBy;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<int> _UserTypeID;
		
		private EntityRef<UserType> _UserType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(System.Guid value);
    partial void OnUserIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    partial void OnPasswordAsHashChanging(string value);
    partial void OnPasswordAsHashChanged();
    partial void OnCreatedByChanging(System.Nullable<System.Guid> value);
    partial void OnCreatedByChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnUserTypeIDChanging(System.Nullable<int> value);
    partial void OnUserTypeIDChanged();
    #endregion
		
		public UserDetail()
		{
			this._UserType = default(EntityRef<UserType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this.OnFullNameChanging(value);
					this.SendPropertyChanging();
					this._FullName = value;
					this.SendPropertyChanged("FullName");
					this.OnFullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PasswordAsHash", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PasswordAsHash
		{
			get
			{
				return this._PasswordAsHash;
			}
			set
			{
				if ((this._PasswordAsHash != value))
				{
					this.OnPasswordAsHashChanging(value);
					this.SendPropertyChanging();
					this._PasswordAsHash = value;
					this.SendPropertyChanged("PasswordAsHash");
					this.OnPasswordAsHashChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedBy", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserTypeID", DbType="Int")]
		public System.Nullable<int> UserTypeID
		{
			get
			{
				return this._UserTypeID;
			}
			set
			{
				if ((this._UserTypeID != value))
				{
					if (this._UserType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserTypeIDChanging(value);
					this.SendPropertyChanging();
					this._UserTypeID = value;
					this.SendPropertyChanged("UserTypeID");
					this.OnUserTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserType_UserDetail", Storage="_UserType", ThisKey="UserTypeID", OtherKey="UserTypeID", IsForeignKey=true)]
		public UserType UserType
		{
			get
			{
				return this._UserType.Entity;
			}
			set
			{
				UserType previousValue = this._UserType.Entity;
				if (((previousValue != value) 
							|| (this._UserType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._UserType.Entity = null;
						previousValue.UserDetails.Remove(this);
					}
					this._UserType.Entity = value;
					if ((value != null))
					{
						value.UserDetails.Add(this);
						this._UserTypeID = value.UserTypeID;
					}
					else
					{
						this._UserTypeID = default(Nullable<int>);
					}
					this.SendPropertyChanged("UserType");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserType")]
	public partial class UserType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserTypeID;
		
		private string _UserType1;
		
		private EntitySet<UserDetail> _UserDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserTypeIDChanging(int value);
    partial void OnUserTypeIDChanged();
    partial void OnUserType1Changing(string value);
    partial void OnUserType1Changed();
    #endregion
		
		public UserType()
		{
			this._UserDetails = new EntitySet<UserDetail>(new Action<UserDetail>(this.attach_UserDetails), new Action<UserDetail>(this.detach_UserDetails));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserTypeID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserTypeID
		{
			get
			{
				return this._UserTypeID;
			}
			set
			{
				if ((this._UserTypeID != value))
				{
					this.OnUserTypeIDChanging(value);
					this.SendPropertyChanging();
					this._UserTypeID = value;
					this.SendPropertyChanged("UserTypeID");
					this.OnUserTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="UserType", Storage="_UserType1", DbType="VarChar(50)")]
		public string UserType1
		{
			get
			{
				return this._UserType1;
			}
			set
			{
				if ((this._UserType1 != value))
				{
					this.OnUserType1Changing(value);
					this.SendPropertyChanging();
					this._UserType1 = value;
					this.SendPropertyChanged("UserType1");
					this.OnUserType1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserType_UserDetail", Storage="_UserDetails", ThisKey="UserTypeID", OtherKey="UserTypeID")]
		public EntitySet<UserDetail> UserDetails
		{
			get
			{
				return this._UserDetails;
			}
			set
			{
				this._UserDetails.Assign(value);
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
		
		private void attach_UserDetails(UserDetail entity)
		{
			this.SendPropertyChanging();
			entity.UserType = this;
		}
		
		private void detach_UserDetails(UserDetail entity)
		{
			this.SendPropertyChanging();
			entity.UserType = null;
		}
	}
	
	public partial class GetUserDetailsResult
	{
		
		private System.Guid _UserID;
		
		private string _UserName;
		
		private string _FullName;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private string _UserType;
		
		public GetUserDetailsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this._FullName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this._CreatedOn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="VarChar(50)")]
		public string UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this._UserType = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
