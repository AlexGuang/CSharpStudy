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

namespace LinqToSQL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="XiaoguangDB")]
	public partial class LinqToSQLDaterSeterDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUniversity(University instance);
    partial void UpdateUniversity(University instance);
    partial void DeleteUniversity(University instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    #endregion
		
		public LinqToSQLDaterSeterDataContext() : 
				base(global::LinqToSQL.Properties.Settings.Default.XiaoguangDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDaterSeterDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDaterSeterDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDaterSeterDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDaterSeterDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<University> Universities
		{
			get
			{
				return this.GetTable<University>();
			}
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.University")]
	public partial class University : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Location;
		
		private string _Country;
		
		private int _RankedNum;
		
		private EntitySet<Student> _Students;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnLocationChanging(string value);
    partial void OnLocationChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnRankedNumChanging(int value);
    partial void OnRankedNumChanged();
    #endregion
		
		public University()
		{
			this._Students = new EntitySet<Student>(new Action<Student>(this.attach_Students), new Action<Student>(this.detach_Students));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.WhenChanged)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this.OnLocationChanging(value);
					this.SendPropertyChanging();
					this._Location = value;
					this.SendPropertyChanged("Location");
					this.OnLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RankedNum", DbType="Int NOT NULL")]
		public int RankedNum
		{
			get
			{
				return this._RankedNum;
			}
			set
			{
				if ((this._RankedNum != value))
				{
					this.OnRankedNumChanging(value);
					this.SendPropertyChanging();
					this._RankedNum = value;
					this.SendPropertyChanged("RankedNum");
					this.OnRankedNumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="University_Student", Storage="_Students", ThisKey="Id", OtherKey="UniversityId")]
		public EntitySet<Student> Students
		{
			get
			{
				return this._Students;
			}
			set
			{
				this._Students.Assign(value);
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
		
		private void attach_Students(Student entity)
		{
			this.SendPropertyChanging();
			entity.University = this;
		}
		
		private void detach_Students(Student entity)
		{
			this.SendPropertyChanging();
			entity.University = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Student")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private int _Age;
		
		private string _Gender;
		
		private int _UniversityId;
		
		private EntityRef<University> _University;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAgeChanging(int value);
    partial void OnAgeChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnUniversityIdChanging(int value);
    partial void OnUniversityIdChanged();
    #endregion
		
		public Student()
		{
			this._University = default(EntityRef<University>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int NOT NULL")]
		public int Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UniversityId", DbType="Int NOT NULL")]
		public int UniversityId
		{
			get
			{
				return this._UniversityId;
			}
			set
			{
				if ((this._UniversityId != value))
				{
					if (this._University.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUniversityIdChanging(value);
					this.SendPropertyChanging();
					this._UniversityId = value;
					this.SendPropertyChanged("UniversityId");
					this.OnUniversityIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="University_Student", Storage="_University", ThisKey="UniversityId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public University University
		{
			get
			{
				return this._University.Entity;
			}
			set
			{
				University previousValue = this._University.Entity;
				if (((previousValue != value) 
							|| (this._University.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._University.Entity = null;
						previousValue.Students.Remove(this);
					}
					this._University.Entity = value;
					if ((value != null))
					{
						value.Students.Add(this);
						this._UniversityId = value.Id;
					}
					else
					{
						this._UniversityId = default(int);
					}
					this.SendPropertyChanged("University");
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
