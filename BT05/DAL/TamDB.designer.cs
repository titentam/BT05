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

namespace BT05.DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BT04")]
	public partial class TamDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSV(SV instance);
    partial void UpdateSV(SV instance);
    partial void DeleteSV(SV instance);
    #endregion
		
		public TamDBDataContext() : 
				base(global::BT05.Properties.Settings.Default.BT04ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TamDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TamDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TamDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TamDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SV> SVs
		{
			get
			{
				return this.GetTable<SV>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SV")]
	public partial class SV : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _Name;
		
		private string _Class;
		
		private System.Nullable<bool> _Gender;
		
		private System.Nullable<System.DateTime> _Dob;
		
		private System.Nullable<double> _GPA;
		
		private System.Nullable<bool> _Picture;
		
		private System.Nullable<bool> _School_report;
		
		private System.Nullable<bool> _CCCD;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnClassChanging(string value);
    partial void OnClassChanged();
    partial void OnGenderChanging(System.Nullable<bool> value);
    partial void OnGenderChanged();
    partial void OnDobChanging(System.Nullable<System.DateTime> value);
    partial void OnDobChanged();
    partial void OnGPAChanging(System.Nullable<double> value);
    partial void OnGPAChanged();
    partial void OnPictureChanging(System.Nullable<bool> value);
    partial void OnPictureChanged();
    partial void OnSchool_reportChanging(System.Nullable<bool> value);
    partial void OnSchool_reportChanged();
    partial void OnCCCDChanging(System.Nullable<bool> value);
    partial void OnCCCDChanged();
    #endregion
		
		public SV()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Char(8) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class", DbType="VarChar(50)")]
		public string Class
		{
			get
			{
				return this._Class;
			}
			set
			{
				if ((this._Class != value))
				{
					this.OnClassChanging(value);
					this.SendPropertyChanging();
					this._Class = value;
					this.SendPropertyChanged("Class");
					this.OnClassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="Bit")]
		public System.Nullable<bool> Gender
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dob", DbType="DateTime")]
		public System.Nullable<System.DateTime> Dob
		{
			get
			{
				return this._Dob;
			}
			set
			{
				if ((this._Dob != value))
				{
					this.OnDobChanging(value);
					this.SendPropertyChanging();
					this._Dob = value;
					this.SendPropertyChanged("Dob");
					this.OnDobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GPA", DbType="Float")]
		public System.Nullable<double> GPA
		{
			get
			{
				return this._GPA;
			}
			set
			{
				if ((this._GPA != value))
				{
					this.OnGPAChanging(value);
					this.SendPropertyChanging();
					this._GPA = value;
					this.SendPropertyChanged("GPA");
					this.OnGPAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="Bit")]
		public System.Nullable<bool> Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._Picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_School_report", DbType="Bit")]
		public System.Nullable<bool> School_report
		{
			get
			{
				return this._School_report;
			}
			set
			{
				if ((this._School_report != value))
				{
					this.OnSchool_reportChanging(value);
					this.SendPropertyChanging();
					this._School_report = value;
					this.SendPropertyChanged("School_report");
					this.OnSchool_reportChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CCCD", DbType="Bit")]
		public System.Nullable<bool> CCCD
		{
			get
			{
				return this._CCCD;
			}
			set
			{
				if ((this._CCCD != value))
				{
					this.OnCCCDChanging(value);
					this.SendPropertyChanging();
					this._CCCD = value;
					this.SendPropertyChanged("CCCD");
					this.OnCCCDChanged();
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
