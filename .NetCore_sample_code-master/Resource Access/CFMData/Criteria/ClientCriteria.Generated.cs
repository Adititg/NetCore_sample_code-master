﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Client.cs'.
//
//     Template: Criteria.Generated.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


 

namespace CFMData
{
    [Serializable]
    public partial class ClientCriteria 
    {
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #region Constructors

        public ClientCriteria(){}

        public ClientCriteria(System.Int32 clientID)
        {
            ClientID = clientID;
        }

        #endregion

        #region Public Properties

        #region Read-Write

        public System.Int32 ClientID
        {
            get { return GetValue<System.Int32>("ClientID"); }
            set { _bag["ClientID"] = value; }
        }

        public System.Int32 GLEntityID
        {
            get { return GetValue<System.Int32>("GLEntityID"); }
            set { _bag["GLEntityID"] = value; }
        }

        public System.String RefCode
        {
            get { return GetValue<System.String>("RefCode"); }
            set { _bag["RefCode"] = value; }
        }

        public System.String NDISNumber
        {
            get { return GetValue<System.String>("NDISNumber"); }
            set { _bag["NDISNumber"] = value; }
        }

        public System.String FirstName
        {
            get { return GetValue<System.String>("FirstName"); }
            set { _bag["FirstName"] = value; }
        }

        public System.String LastName
        {
            get { return GetValue<System.String>("LastName"); }
            set { _bag["LastName"] = value; }
        }

        public System.DateTime Dob
        {
            get { return GetValue<System.DateTime>("DOB"); }
            set { _bag["DOB"] = value; }
        }

        public System.String Email
        {
            get { return GetValue<System.String>("Email"); }
            set { _bag["Email"] = value; }
        }

        public System.Int32? AddressID
        {
            get { return GetValue<System.Int32?>("AddressID"); }
            set { _bag["AddressID"] = value; }
        }

        public System.Boolean IsHomeAddress
        {
            get { return GetValue<System.Boolean>("IsHomeAddress"); }
            set { _bag["IsHomeAddress"] = value; }
        }

        public System.Int32 StatementDelOptID
        {
            get { return GetValue<System.Int32>("StatementDelOptID"); }
            set { _bag["StatementDelOptID"] = value; }
        }

        public System.Boolean IsActive
        {
            get { return GetValue<System.Boolean>("IsActive"); }
            set { _bag["IsActive"] = value; }
        }

        public System.Int32 CreatedBy
        {
            get { return GetValue<System.Int32>("CreatedBy"); }
            set { _bag["CreatedBy"] = value; }
        }

        public System.DateTime CreatedOn
        {
            get { return GetValue<System.DateTime>("CreatedOn"); }
            set { _bag["CreatedOn"] = value; }
        }

        public System.Int32? UpdatedBy
        {
            get { return GetValue<System.Int32?>("UpdatedBy"); }
            set { _bag["UpdatedBy"] = value; }
        }

        public System.DateTime? UpdatedOn
        {
            get { return GetValue<System.DateTime?>("UpdatedOn"); }
            set { _bag["UpdatedOn"] = value; }
        }

        #endregion
        
        #region Read-Only

        public bool NDISNumberHasValue
        {
            get { return _bag.ContainsKey("NDISNumber"); }
        }

        public bool EmailHasValue
        {
            get { return _bag.ContainsKey("Email"); }
        }

        public bool AddressIDHasValue
        {
            get { return _bag.ContainsKey("AddressID"); }
        }

        public bool UpdatedByHasValue
        {
            get { return _bag.ContainsKey("UpdatedBy"); }
        }

        public bool UpdatedOnHasValue
        {
            get { return _bag.ContainsKey("UpdatedOn"); }
        }

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public Dictionary<string, object> StateBag
        {
            get
            {
                return _bag;
            }
        }

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public string TableFullName
        {
            get
            {
                return "[dbo].[Client]";
            }
        }

        #endregion

        #endregion

        #region Overrides
        
        public  string ToString()
        {
            var result = String.Empty;
            var cancel = false;
            
            OnToString(ref result, ref cancel);
            if(cancel && !String.IsNullOrEmpty(result))
                return result;
            
            if (_bag.Count == 0)
                return "No criterion was specified.";

            foreach (KeyValuePair<string, object> key in _bag)
            {
                result += String.Format("[{0}] = '{1}' AND ", key.Key, key.Value);
            }

            return result.Remove(result.Length - 5, 5);
        }

        #endregion

        #region Private Methods
        private T GetValue<T>(string name)
        {
            object value;
            if (_bag.TryGetValue(name, out value))
                return (T) value;
        
            return default(T);
        }
        
        #endregion
        
        #region Partial Methods
        
        partial void OnToString(ref string result, ref bool cancel);
        
        #endregion
        
    }
}