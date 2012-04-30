﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace SampleApplication.Repository
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class adventureworksEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new adventureworksEntities object using the connection string found in the 'adventureworksEntities' section of the application configuration file.
        /// </summary>
        public adventureworksEntities() : base("name=adventureworksEntities", "adventureworksEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new adventureworksEntities object.
        /// </summary>
        public adventureworksEntities(string connectionString) : base(connectionString, "adventureworksEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new adventureworksEntities object.
        /// </summary>
        public adventureworksEntities(EntityConnection connection) : base(connection, "adventureworksEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Employee> Employees
        {
            get
            {
                if ((_Employees == null))
                {
                    _Employees = base.CreateObjectSet<Employee>("Employees");
                }
                return _Employees;
            }
        }
        private ObjectSet<Employee> _Employees;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<vEmployee> vEmployees
        {
            get
            {
                if ((_vEmployees == null))
                {
                    _vEmployees = base.CreateObjectSet<vEmployee>("vEmployees");
                }
                return _vEmployees;
            }
        }
        private ObjectSet<vEmployee> _vEmployees;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Employees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployees(Employee employee)
        {
            base.AddObject("Employees", employee);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the vEmployees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTovEmployees(vEmployee vEmployee)
        {
            base.AddObject("vEmployees", vEmployee);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AdventureWorksHRModel", Name="Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Employee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="businessEntityID">Initial value of the BusinessEntityID property.</param>
        /// <param name="nationalIDNumber">Initial value of the NationalIDNumber property.</param>
        /// <param name="loginID">Initial value of the LoginID property.</param>
        /// <param name="jobTitle">Initial value of the JobTitle property.</param>
        /// <param name="birthDate">Initial value of the BirthDate property.</param>
        /// <param name="maritalStatus">Initial value of the MaritalStatus property.</param>
        /// <param name="gender">Initial value of the Gender property.</param>
        /// <param name="hireDate">Initial value of the HireDate property.</param>
        /// <param name="salariedFlag">Initial value of the SalariedFlag property.</param>
        /// <param name="vacationHours">Initial value of the VacationHours property.</param>
        /// <param name="sickLeaveHours">Initial value of the SickLeaveHours property.</param>
        /// <param name="currentFlag">Initial value of the CurrentFlag property.</param>
        /// <param name="rowguid">Initial value of the rowguid property.</param>
        /// <param name="modifiedDate">Initial value of the ModifiedDate property.</param>
        public static Employee CreateEmployee(global::System.Int32 businessEntityID, global::System.String nationalIDNumber, global::System.String loginID, global::System.String jobTitle, global::System.DateTime birthDate, global::System.String maritalStatus, global::System.String gender, global::System.DateTime hireDate, global::System.Boolean salariedFlag, global::System.Int16 vacationHours, global::System.Int16 sickLeaveHours, global::System.Boolean currentFlag, global::System.Guid rowguid, global::System.DateTime modifiedDate)
        {
            Employee employee = new Employee();
            employee.BusinessEntityID = businessEntityID;
            employee.NationalIDNumber = nationalIDNumber;
            employee.LoginID = loginID;
            employee.JobTitle = jobTitle;
            employee.BirthDate = birthDate;
            employee.MaritalStatus = maritalStatus;
            employee.Gender = gender;
            employee.HireDate = hireDate;
            employee.SalariedFlag = salariedFlag;
            employee.VacationHours = vacationHours;
            employee.SickLeaveHours = sickLeaveHours;
            employee.CurrentFlag = currentFlag;
            employee.rowguid = rowguid;
            employee.ModifiedDate = modifiedDate;
            return employee;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BusinessEntityID
        {
            get
            {
                return _BusinessEntityID;
            }
            set
            {
                if (_BusinessEntityID != value)
                {
                    OnBusinessEntityIDChanging(value);
                    ReportPropertyChanging("BusinessEntityID");
                    _BusinessEntityID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("BusinessEntityID");
                    OnBusinessEntityIDChanged();
                }
            }
        }
        private global::System.Int32 _BusinessEntityID;
        partial void OnBusinessEntityIDChanging(global::System.Int32 value);
        partial void OnBusinessEntityIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NationalIDNumber
        {
            get
            {
                return _NationalIDNumber;
            }
            set
            {
                OnNationalIDNumberChanging(value);
                ReportPropertyChanging("NationalIDNumber");
                _NationalIDNumber = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("NationalIDNumber");
                OnNationalIDNumberChanged();
            }
        }
        private global::System.String _NationalIDNumber;
        partial void OnNationalIDNumberChanging(global::System.String value);
        partial void OnNationalIDNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LoginID
        {
            get
            {
                return _LoginID;
            }
            set
            {
                OnLoginIDChanging(value);
                ReportPropertyChanging("LoginID");
                _LoginID = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LoginID");
                OnLoginIDChanged();
            }
        }
        private global::System.String _LoginID;
        partial void OnLoginIDChanging(global::System.String value);
        partial void OnLoginIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> OrganizationLevel
        {
            get
            {
                return _OrganizationLevel;
            }
            set
            {
                OnOrganizationLevelChanging(value);
                ReportPropertyChanging("OrganizationLevel");
                _OrganizationLevel = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OrganizationLevel");
                OnOrganizationLevelChanged();
            }
        }
        private Nullable<global::System.Int16> _OrganizationLevel;
        partial void OnOrganizationLevelChanging(Nullable<global::System.Int16> value);
        partial void OnOrganizationLevelChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String JobTitle
        {
            get
            {
                return _JobTitle;
            }
            set
            {
                OnJobTitleChanging(value);
                ReportPropertyChanging("JobTitle");
                _JobTitle = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("JobTitle");
                OnJobTitleChanged();
            }
        }
        private global::System.String _JobTitle;
        partial void OnJobTitleChanging(global::System.String value);
        partial void OnJobTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime BirthDate
        {
            get
            {
                return _BirthDate;
            }
            set
            {
                OnBirthDateChanging(value);
                ReportPropertyChanging("BirthDate");
                _BirthDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BirthDate");
                OnBirthDateChanged();
            }
        }
        private global::System.DateTime _BirthDate;
        partial void OnBirthDateChanging(global::System.DateTime value);
        partial void OnBirthDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String MaritalStatus
        {
            get
            {
                return _MaritalStatus;
            }
            set
            {
                OnMaritalStatusChanging(value);
                ReportPropertyChanging("MaritalStatus");
                _MaritalStatus = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("MaritalStatus");
                OnMaritalStatusChanged();
            }
        }
        private global::System.String _MaritalStatus;
        partial void OnMaritalStatusChanging(global::System.String value);
        partial void OnMaritalStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                OnGenderChanging(value);
                ReportPropertyChanging("Gender");
                _Gender = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Gender");
                OnGenderChanged();
            }
        }
        private global::System.String _Gender;
        partial void OnGenderChanging(global::System.String value);
        partial void OnGenderChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime HireDate
        {
            get
            {
                return _HireDate;
            }
            set
            {
                OnHireDateChanging(value);
                ReportPropertyChanging("HireDate");
                _HireDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("HireDate");
                OnHireDateChanged();
            }
        }
        private global::System.DateTime _HireDate;
        partial void OnHireDateChanging(global::System.DateTime value);
        partial void OnHireDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean SalariedFlag
        {
            get
            {
                return _SalariedFlag;
            }
            set
            {
                OnSalariedFlagChanging(value);
                ReportPropertyChanging("SalariedFlag");
                _SalariedFlag = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SalariedFlag");
                OnSalariedFlagChanged();
            }
        }
        private global::System.Boolean _SalariedFlag;
        partial void OnSalariedFlagChanging(global::System.Boolean value);
        partial void OnSalariedFlagChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 VacationHours
        {
            get
            {
                return _VacationHours;
            }
            set
            {
                OnVacationHoursChanging(value);
                ReportPropertyChanging("VacationHours");
                _VacationHours = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("VacationHours");
                OnVacationHoursChanged();
            }
        }
        private global::System.Int16 _VacationHours;
        partial void OnVacationHoursChanging(global::System.Int16 value);
        partial void OnVacationHoursChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 SickLeaveHours
        {
            get
            {
                return _SickLeaveHours;
            }
            set
            {
                OnSickLeaveHoursChanging(value);
                ReportPropertyChanging("SickLeaveHours");
                _SickLeaveHours = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SickLeaveHours");
                OnSickLeaveHoursChanged();
            }
        }
        private global::System.Int16 _SickLeaveHours;
        partial void OnSickLeaveHoursChanging(global::System.Int16 value);
        partial void OnSickLeaveHoursChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean CurrentFlag
        {
            get
            {
                return _CurrentFlag;
            }
            set
            {
                OnCurrentFlagChanging(value);
                ReportPropertyChanging("CurrentFlag");
                _CurrentFlag = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CurrentFlag");
                OnCurrentFlagChanged();
            }
        }
        private global::System.Boolean _CurrentFlag;
        partial void OnCurrentFlagChanging(global::System.Boolean value);
        partial void OnCurrentFlagChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid rowguid
        {
            get
            {
                return _rowguid;
            }
            set
            {
                OnrowguidChanging(value);
                ReportPropertyChanging("rowguid");
                _rowguid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("rowguid");
                OnrowguidChanged();
            }
        }
        private global::System.Guid _rowguid;
        partial void OnrowguidChanging(global::System.Guid value);
        partial void OnrowguidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                OnModifiedDateChanging(value);
                ReportPropertyChanging("ModifiedDate");
                _ModifiedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ModifiedDate");
                OnModifiedDateChanged();
            }
        }
        private global::System.DateTime _ModifiedDate;
        partial void OnModifiedDateChanging(global::System.DateTime value);
        partial void OnModifiedDateChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AdventureWorksHRModel", Name="vEmployee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class vEmployee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new vEmployee object.
        /// </summary>
        /// <param name="businessEntityID">Initial value of the BusinessEntityID property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="jobTitle">Initial value of the JobTitle property.</param>
        /// <param name="emailPromotion">Initial value of the EmailPromotion property.</param>
        /// <param name="addressLine1">Initial value of the AddressLine1 property.</param>
        /// <param name="city">Initial value of the City property.</param>
        /// <param name="stateProvinceName">Initial value of the StateProvinceName property.</param>
        /// <param name="postalCode">Initial value of the PostalCode property.</param>
        /// <param name="countryRegionName">Initial value of the CountryRegionName property.</param>
        public static vEmployee CreatevEmployee(global::System.Int32 businessEntityID, global::System.String firstName, global::System.String lastName, global::System.String jobTitle, global::System.Int32 emailPromotion, global::System.String addressLine1, global::System.String city, global::System.String stateProvinceName, global::System.String postalCode, global::System.String countryRegionName)
        {
            vEmployee vEmployee = new vEmployee();
            vEmployee.BusinessEntityID = businessEntityID;
            vEmployee.FirstName = firstName;
            vEmployee.LastName = lastName;
            vEmployee.JobTitle = jobTitle;
            vEmployee.EmailPromotion = emailPromotion;
            vEmployee.AddressLine1 = addressLine1;
            vEmployee.City = city;
            vEmployee.StateProvinceName = stateProvinceName;
            vEmployee.PostalCode = postalCode;
            vEmployee.CountryRegionName = countryRegionName;
            return vEmployee;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BusinessEntityID
        {
            get
            {
                return _BusinessEntityID;
            }
            set
            {
                if (_BusinessEntityID != value)
                {
                    OnBusinessEntityIDChanging(value);
                    ReportPropertyChanging("BusinessEntityID");
                    _BusinessEntityID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("BusinessEntityID");
                    OnBusinessEntityIDChanged();
                }
            }
        }
        private global::System.Int32 _BusinessEntityID;
        partial void OnBusinessEntityIDChanging(global::System.Int32 value);
        partial void OnBusinessEntityIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                if (_FirstName != value)
                {
                    OnFirstNameChanging(value);
                    ReportPropertyChanging("FirstName");
                    _FirstName = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("FirstName");
                    OnFirstNameChanged();
                }
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MiddleName
        {
            get
            {
                return _MiddleName;
            }
            set
            {
                OnMiddleNameChanging(value);
                ReportPropertyChanging("MiddleName");
                _MiddleName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MiddleName");
                OnMiddleNameChanged();
            }
        }
        private global::System.String _MiddleName;
        partial void OnMiddleNameChanging(global::System.String value);
        partial void OnMiddleNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                if (_LastName != value)
                {
                    OnLastNameChanging(value);
                    ReportPropertyChanging("LastName");
                    _LastName = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("LastName");
                    OnLastNameChanged();
                }
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Suffix
        {
            get
            {
                return _Suffix;
            }
            set
            {
                OnSuffixChanging(value);
                ReportPropertyChanging("Suffix");
                _Suffix = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Suffix");
                OnSuffixChanged();
            }
        }
        private global::System.String _Suffix;
        partial void OnSuffixChanging(global::System.String value);
        partial void OnSuffixChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String JobTitle
        {
            get
            {
                return _JobTitle;
            }
            set
            {
                if (_JobTitle != value)
                {
                    OnJobTitleChanging(value);
                    ReportPropertyChanging("JobTitle");
                    _JobTitle = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("JobTitle");
                    OnJobTitleChanged();
                }
            }
        }
        private global::System.String _JobTitle;
        partial void OnJobTitleChanging(global::System.String value);
        partial void OnJobTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                OnPhoneNumberChanging(value);
                ReportPropertyChanging("PhoneNumber");
                _PhoneNumber = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PhoneNumber");
                OnPhoneNumberChanged();
            }
        }
        private global::System.String _PhoneNumber;
        partial void OnPhoneNumberChanging(global::System.String value);
        partial void OnPhoneNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PhoneNumberType
        {
            get
            {
                return _PhoneNumberType;
            }
            set
            {
                OnPhoneNumberTypeChanging(value);
                ReportPropertyChanging("PhoneNumberType");
                _PhoneNumberType = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PhoneNumberType");
                OnPhoneNumberTypeChanged();
            }
        }
        private global::System.String _PhoneNumberType;
        partial void OnPhoneNumberTypeChanging(global::System.String value);
        partial void OnPhoneNumberTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                OnEmailAddressChanging(value);
                ReportPropertyChanging("EmailAddress");
                _EmailAddress = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("EmailAddress");
                OnEmailAddressChanged();
            }
        }
        private global::System.String _EmailAddress;
        partial void OnEmailAddressChanging(global::System.String value);
        partial void OnEmailAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmailPromotion
        {
            get
            {
                return _EmailPromotion;
            }
            set
            {
                if (_EmailPromotion != value)
                {
                    OnEmailPromotionChanging(value);
                    ReportPropertyChanging("EmailPromotion");
                    _EmailPromotion = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EmailPromotion");
                    OnEmailPromotionChanged();
                }
            }
        }
        private global::System.Int32 _EmailPromotion;
        partial void OnEmailPromotionChanging(global::System.Int32 value);
        partial void OnEmailPromotionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String AddressLine1
        {
            get
            {
                return _AddressLine1;
            }
            set
            {
                if (_AddressLine1 != value)
                {
                    OnAddressLine1Changing(value);
                    ReportPropertyChanging("AddressLine1");
                    _AddressLine1 = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("AddressLine1");
                    OnAddressLine1Changed();
                }
            }
        }
        private global::System.String _AddressLine1;
        partial void OnAddressLine1Changing(global::System.String value);
        partial void OnAddressLine1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AddressLine2
        {
            get
            {
                return _AddressLine2;
            }
            set
            {
                OnAddressLine2Changing(value);
                ReportPropertyChanging("AddressLine2");
                _AddressLine2 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AddressLine2");
                OnAddressLine2Changed();
            }
        }
        private global::System.String _AddressLine2;
        partial void OnAddressLine2Changing(global::System.String value);
        partial void OnAddressLine2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                if (_City != value)
                {
                    OnCityChanging(value);
                    ReportPropertyChanging("City");
                    _City = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("City");
                    OnCityChanged();
                }
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String StateProvinceName
        {
            get
            {
                return _StateProvinceName;
            }
            set
            {
                if (_StateProvinceName != value)
                {
                    OnStateProvinceNameChanging(value);
                    ReportPropertyChanging("StateProvinceName");
                    _StateProvinceName = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("StateProvinceName");
                    OnStateProvinceNameChanged();
                }
            }
        }
        private global::System.String _StateProvinceName;
        partial void OnStateProvinceNameChanging(global::System.String value);
        partial void OnStateProvinceNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PostalCode
        {
            get
            {
                return _PostalCode;
            }
            set
            {
                if (_PostalCode != value)
                {
                    OnPostalCodeChanging(value);
                    ReportPropertyChanging("PostalCode");
                    _PostalCode = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("PostalCode");
                    OnPostalCodeChanged();
                }
            }
        }
        private global::System.String _PostalCode;
        partial void OnPostalCodeChanging(global::System.String value);
        partial void OnPostalCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CountryRegionName
        {
            get
            {
                return _CountryRegionName;
            }
            set
            {
                if (_CountryRegionName != value)
                {
                    OnCountryRegionNameChanging(value);
                    ReportPropertyChanging("CountryRegionName");
                    _CountryRegionName = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("CountryRegionName");
                    OnCountryRegionNameChanged();
                }
            }
        }
        private global::System.String _CountryRegionName;
        partial void OnCountryRegionNameChanging(global::System.String value);
        partial void OnCountryRegionNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AdditionalContactInfo
        {
            get
            {
                return _AdditionalContactInfo;
            }
            set
            {
                OnAdditionalContactInfoChanging(value);
                ReportPropertyChanging("AdditionalContactInfo");
                _AdditionalContactInfo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AdditionalContactInfo");
                OnAdditionalContactInfoChanged();
            }
        }
        private global::System.String _AdditionalContactInfo;
        partial void OnAdditionalContactInfoChanging(global::System.String value);
        partial void OnAdditionalContactInfoChanged();

        #endregion
    
    }

    #endregion
    
}
