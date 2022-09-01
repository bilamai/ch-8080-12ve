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

namespace aspnet.Services.shares
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ELDB")]
	public partial class masDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDivision(Division instance);
    partial void UpdateDivision(Division instance);
    partial void DeleteDivision(Division instance);
    partial void InsertEmp(Emp instance);
    partial void UpdateEmp(Emp instance);
    partial void DeleteEmp(Emp instance);
    partial void Insertappoint(appoint instance);
    partial void Updateappoint(appoint instance);
    partial void Deleteappoint(appoint instance);
    #endregion
		
		public masDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ELDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public masDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public masDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public masDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public masDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Division> Divisions
		{
			get
			{
				return this.GetTable<Division>();
			}
		}
		
		public System.Data.Linq.Table<Emp> Emps
		{
			get
			{
				return this.GetTable<Emp>();
			}
		}
		
		public System.Data.Linq.Table<appoint> appoints
		{
			get
			{
				return this.GetTable<appoint>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Division")]
	public partial class Division : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Division_code;
		
		private string _Division_name;
		
		private char _Division_status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDivision_codeChanging(string value);
    partial void OnDivision_codeChanged();
    partial void OnDivision_nameChanging(string value);
    partial void OnDivision_nameChanged();
    partial void OnDivision_statusChanging(char value);
    partial void OnDivision_statusChanged();
    #endregion
		
		public Division()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Division_code", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Division_code
		{
			get
			{
				return this._Division_code;
			}
			set
			{
				if ((this._Division_code != value))
				{
					this.OnDivision_codeChanging(value);
					this.SendPropertyChanging();
					this._Division_code = value;
					this.SendPropertyChanged("Division_code");
					this.OnDivision_codeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Division_name", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Division_name
		{
			get
			{
				return this._Division_name;
			}
			set
			{
				if ((this._Division_name != value))
				{
					this.OnDivision_nameChanging(value);
					this.SendPropertyChanging();
					this._Division_name = value;
					this.SendPropertyChanged("Division_name");
					this.OnDivision_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Division_status", DbType="Char(1) NOT NULL")]
		public char Division_status
		{
			get
			{
				return this._Division_status;
			}
			set
			{
				if ((this._Division_status != value))
				{
					this.OnDivision_statusChanging(value);
					this.SendPropertyChanging();
					this._Division_status = value;
					this.SendPropertyChanged("Division_status");
					this.OnDivision_statusChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Emp")]
	public partial class Emp : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Emp_code;
		
		private string _Division_code;
		
		private string _Emp_name;
		
		private char _Emp_status;
		
		private double _Emp_salary;
		
		private System.DateTime _Emp_start;
		
		private System.DateTime _Emp_birth;
		
		private int _Emp_group;
		
		private char _Emp_state;
		
		private char _Emp_entry;
		
		private char _Emp_query;
		
		private string _Division_name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmp_codeChanging(string value);
    partial void OnEmp_codeChanged();
    partial void OnDivision_codeChanging(string value);
    partial void OnDivision_codeChanged();
    partial void OnEmp_nameChanging(string value);
    partial void OnEmp_nameChanged();
    partial void OnEmp_statusChanging(char value);
    partial void OnEmp_statusChanged();
    partial void OnEmp_salaryChanging(double value);
    partial void OnEmp_salaryChanged();
    partial void OnEmp_startChanging(System.DateTime value);
    partial void OnEmp_startChanged();
    partial void OnEmp_birthChanging(System.DateTime value);
    partial void OnEmp_birthChanged();
    partial void OnEmp_groupChanging(int value);
    partial void OnEmp_groupChanged();
    partial void OnEmp_stateChanging(char value);
    partial void OnEmp_stateChanged();
    partial void OnEmp_entryChanging(char value);
    partial void OnEmp_entryChanged();
    partial void OnEmp_queryChanging(char value);
    partial void OnEmp_queryChanged();
    partial void OnDivision_nameChanging(string value);
    partial void OnDivision_nameChanged();
    #endregion
		
		public Emp()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Emp_code", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Emp_code
		{
			get
			{
				return this._Emp_code;
			}
			set
			{
				if ((this._Emp_code != value))
				{
					this.OnEmp_codeChanging(value);
					this.SendPropertyChanging();
					this._Emp_code = value;
					this.SendPropertyChanged("Emp_code");
					this.OnEmp_codeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Division_code", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string Division_code
		{
			get
			{
				return this._Division_code;
			}
			set
			{
				if ((this._Division_code != value))
				{
					this.OnDivision_codeChanging(value);
					this.SendPropertyChanging();
					this._Division_code = value;
					this.SendPropertyChanged("Division_code");
					this.OnDivision_codeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Emp_name", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Emp_name
		{
			get
			{
				return this._Emp_name;
			}
			set
			{
				if ((this._Emp_name != value))
				{
					this.OnEmp_nameChanging(value);
					this.SendPropertyChanging();
					this._Emp_name = value;
					this.SendPropertyChanged("Emp_name");
					this.OnEmp_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Emp_status", DbType="Char(1) NOT NULL")]
		public char Emp_status
		{
			get
			{
				return this._Emp_status;
			}
			set
			{
				if ((this._Emp_status != value))
				{
					this.OnEmp_statusChanging(value);
					this.SendPropertyChanging();
					this._Emp_status = value;
					this.SendPropertyChanged("Emp_status");
					this.OnEmp_statusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Emp_salary", DbType="Float NOT NULL")]
		public double Emp_salary
		{
			get
			{
				return this._Emp_salary;
			}
			set
			{
				if ((this._Emp_salary != value))
				{
					this.OnEmp_salaryChanging(value);
					this.SendPropertyChanging();
					this._Emp_salary = value;
					this.SendPropertyChanged("Emp_salary");
					this.OnEmp_salaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Emp_start", DbType="Date NOT NULL")]
		public System.DateTime Emp_start
		{
			get
			{
				return this._Emp_start;
			}
			set
			{
				if ((this._Emp_start != value))
				{
					this.OnEmp_startChanging(value);
					this.SendPropertyChanging();
					this._Emp_start = value;
					this.SendPropertyChanged("Emp_start");
					this.OnEmp_startChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Emp_birth", DbType="Date NOT NULL")]
		public System.DateTime Emp_birth
		{
			get
			{
				return this._Emp_birth;
			}
			set
			{
				if ((this._Emp_birth != value))
				{
					this.OnEmp_birthChanging(value);
					this.SendPropertyChanging();
					this._Emp_birth = value;
					this.SendPropertyChanged("Emp_birth");
					this.OnEmp_birthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Emp_group", DbType="Int NOT NULL")]
		public int Emp_group
		{
			get
			{
				return this._Emp_group;
			}
			set
			{
				if ((this._Emp_group != value))
				{
					this.OnEmp_groupChanging(value);
					this.SendPropertyChanging();
					this._Emp_group = value;
					this.SendPropertyChanged("Emp_group");
					this.OnEmp_groupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Emp_state", DbType="Char(1) NOT NULL")]
		public char Emp_state
		{
			get
			{
				return this._Emp_state;
			}
			set
			{
				if ((this._Emp_state != value))
				{
					this.OnEmp_stateChanging(value);
					this.SendPropertyChanging();
					this._Emp_state = value;
					this.SendPropertyChanged("Emp_state");
					this.OnEmp_stateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Emp_entry", DbType="Char(1) NOT NULL")]
		public char Emp_entry
		{
			get
			{
				return this._Emp_entry;
			}
			set
			{
				if ((this._Emp_entry != value))
				{
					this.OnEmp_entryChanging(value);
					this.SendPropertyChanging();
					this._Emp_entry = value;
					this.SendPropertyChanged("Emp_entry");
					this.OnEmp_entryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Emp_query", DbType="Char(1) NOT NULL")]
		public char Emp_query
		{
			get
			{
				return this._Emp_query;
			}
			set
			{
				if ((this._Emp_query != value))
				{
					this.OnEmp_queryChanging(value);
					this.SendPropertyChanging();
					this._Emp_query = value;
					this.SendPropertyChanged("Emp_query");
					this.OnEmp_queryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Division_name", DbType="VarChar(30)")]
		public string Division_name
		{
			get
			{
				return this._Division_name;
			}
			set
			{
				if ((this._Division_name != value))
				{
					this.OnDivision_nameChanging(value);
					this.SendPropertyChanging();
					this._Division_name = value;
					this.SendPropertyChanged("Division_name");
					this.OnDivision_nameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.appoint")]
	public partial class appoint : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _user_id;
		
		private string _id_key;
		
		private string _subject;
		
		private System.DateTime _start_date;
		
		private System.DateTime _end_date;
		
		private string _appoint_desc;
		
		private int _appoint_alldays;
		
		private char _appoint_status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser_idChanging(string value);
    partial void Onuser_idChanged();
    partial void Onid_keyChanging(string value);
    partial void Onid_keyChanged();
    partial void OnsubjectChanging(string value);
    partial void OnsubjectChanged();
    partial void Onstart_dateChanging(System.DateTime value);
    partial void Onstart_dateChanged();
    partial void Onend_dateChanging(System.DateTime value);
    partial void Onend_dateChanged();
    partial void Onappoint_descChanging(string value);
    partial void Onappoint_descChanged();
    partial void Onappoint_alldaysChanging(int value);
    partial void Onappoint_alldaysChanged();
    partial void Onappoint_statusChanging(char value);
    partial void Onappoint_statusChanged();
    #endregion
		
		public appoint()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="VarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_key", DbType="Char(23) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id_key
		{
			get
			{
				return this._id_key;
			}
			set
			{
				if ((this._id_key != value))
				{
					this.Onid_keyChanging(value);
					this.SendPropertyChanging();
					this._id_key = value;
					this.SendPropertyChanged("id_key");
					this.Onid_keyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subject", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string subject
		{
			get
			{
				return this._subject;
			}
			set
			{
				if ((this._subject != value))
				{
					this.OnsubjectChanging(value);
					this.SendPropertyChanging();
					this._subject = value;
					this.SendPropertyChanged("subject");
					this.OnsubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_start_date", DbType="DateTime NOT NULL")]
		public System.DateTime start_date
		{
			get
			{
				return this._start_date;
			}
			set
			{
				if ((this._start_date != value))
				{
					this.Onstart_dateChanging(value);
					this.SendPropertyChanging();
					this._start_date = value;
					this.SendPropertyChanged("start_date");
					this.Onstart_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_end_date", DbType="DateTime NOT NULL")]
		public System.DateTime end_date
		{
			get
			{
				return this._end_date;
			}
			set
			{
				if ((this._end_date != value))
				{
					this.Onend_dateChanging(value);
					this.SendPropertyChanging();
					this._end_date = value;
					this.SendPropertyChanged("end_date");
					this.Onend_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appoint_desc", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string appoint_desc
		{
			get
			{
				return this._appoint_desc;
			}
			set
			{
				if ((this._appoint_desc != value))
				{
					this.Onappoint_descChanging(value);
					this.SendPropertyChanging();
					this._appoint_desc = value;
					this.SendPropertyChanged("appoint_desc");
					this.Onappoint_descChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appoint_alldays", DbType="Int NOT NULL")]
		public int appoint_alldays
		{
			get
			{
				return this._appoint_alldays;
			}
			set
			{
				if ((this._appoint_alldays != value))
				{
					this.Onappoint_alldaysChanging(value);
					this.SendPropertyChanging();
					this._appoint_alldays = value;
					this.SendPropertyChanged("appoint_alldays");
					this.Onappoint_alldaysChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appoint_status", DbType="Char(1) NOT NULL")]
		public char appoint_status
		{
			get
			{
				return this._appoint_status;
			}
			set
			{
				if ((this._appoint_status != value))
				{
					this.Onappoint_statusChanging(value);
					this.SendPropertyChanging();
					this._appoint_status = value;
					this.SendPropertyChanged("appoint_status");
					this.Onappoint_statusChanged();
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