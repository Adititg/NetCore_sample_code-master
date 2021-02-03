﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'TransactionType.cs'.
//
//     Template path: EditableRoot.Generated.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CFMData
{
    [Serializable]
    public partial class TransactionType 
    {
        #region Contructor(s)

        public TransactionType()
        { /* Require use of factory methods */ }

        #endregion

			public TransactionType  Save()
      {
        if (this.IsNew)
        {
            DataPortal_Insert();
			this.IsNew=false;
        }
        else
        {
            DataPortal_Update();
        }

        return this;
      }
	  
			public bool IsDirty=false;
			public bool IsNew=true;
			#region Properties
		
			private TransactionTypeDTO _currentDto = null;
			public TransactionTypeDTO CurrentDTO
			{
				get { return _currentDto; }
				set { _currentDto = value; }
			}

			private System.Int32 _transactionTypeIDProperty  ;
			public System.Int32 TransactionTypeID
			{
				get { return _transactionTypeIDProperty; }
				set
				{ 
                 
					if (_transactionTypeIDProperty != value){
						IsDirty = true;
					}
					_transactionTypeIDProperty=value; 
				}
			}

			private System.Int32 _originalTransactionTypeIDProperty ;
			/// <summary>
			/// Holds the original value for TransactionTypeID. This is used for non identity primary keys.
			/// </summary>
			internal System.Int32 OriginalTransactionTypeID
			{
				get { return _originalTransactionTypeIDProperty; }
				set{ _originalTransactionTypeIDProperty= value; }
			}

			private System.String _codeProperty  ;
			public System.String Code
			{
				get { return _codeProperty; }
				set
				{ 
                 
					if (_codeProperty != value){
						IsDirty = true;
					}
					_codeProperty=value; 
				}
			}

			private System.Boolean _isActiveProperty  ;
			public System.Boolean IsActive
			{
				get { return _isActiveProperty; }
				set
				{ 
                 
					if (_isActiveProperty != value){
						IsDirty = true;
					}
					_isActiveProperty=value; 
				}
			}

			private System.Int32 _createdByProperty  ;
			public System.Int32 CreatedBy
			{
				get { return _createdByProperty; }
				set
				{ 
                 
					if (_createdByProperty != value){
						IsDirty = true;
					}
					_createdByProperty=value; 
				}
			}

			private System.DateTime _createdOnProperty  ;
			public System.DateTime CreatedOn
			{
				get { return _createdOnProperty; }
				set
				{ 
                 
					if (_createdOnProperty != value){
						IsDirty = true;
					}
					_createdOnProperty=value; 
				}
			}

			private System.Int32? _updatedByProperty  = null;
			public System.Int32? UpdatedBy
			{
				get { return _updatedByProperty; }
				set
				{ 
                 
					if (_updatedByProperty != value){
						IsDirty = true;
					}
					_updatedByProperty=value; 
				}
			}

			private System.DateTime? _updatedOnProperty  = null;
			public System.DateTime? UpdatedOn
			{
				get { return _updatedOnProperty; }
				set
				{ 
                 
					if (_updatedOnProperty != value){
						IsDirty = true;
					}
					_updatedOnProperty=value; 
				}
			}

			// OneToMany
			//PropertyInfo<GlList>
			private bool _glsPropertyChecked = false;
			private GlList _glsProperty = null;
			public GlList Gls
			{
				get
				{
					if(!_glsPropertyChecked )
					{
						_glsPropertyChecked =true; 
						var criteria = new CFMData.GlCriteria {TransactionTypeID = TransactionTypeID};
						                        
						_glsProperty= CFMData.GlList.GetByTransactionTypeID(TransactionTypeID);
 
					}
					return _glsProperty;
				}
			}


        #endregion
		public bool IsChildDirty()
		{
		
		
			 
			if(_glsPropertyChecked)
			{
					if(_glsProperty != null)
					{
						foreach (Gl childObj in _glsProperty)
                        {
                            if (childObj.IsDirty || childObj.IsChildDirty())
                            {
                                return true;
                            }
                        }
					}
			}
			 
 



			return false;
		}

        #region Synchronous Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="TransactionType"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="TransactionType"/>.</returns>    
        public static TransactionType NewTransactionType()
        {
            TransactionType obj=new TransactionType();

            return obj;
        }

			public static TransactionType GetTransactionType(Func<IDataReader, TransactionType> rowParser,SqlDataReader reader)
			{
				TransactionType obj = rowParser(reader);
				obj.InitDTO();					
				obj.IsDirty = false;
				obj.IsNew = false;
				return obj;
			}
        
 

        /// <summary>
        /// Returns a <see cref="TransactionType"/> object of the specified criteria. 
        /// </summary>
        /// <param name="transactionTypeID">No additional detail available.</param>
        /// <returns>A <see cref="TransactionType"/> object of the specified criteria.</returns>
        public static TransactionType GetByTransactionTypeID(System.Int32 transactionTypeID)
        {
            var criteria = new TransactionTypeCriteria {TransactionTypeID = transactionTypeID};
            
            
          return  new TransactionType().DataPortal_Fetch(criteria);
           
        }

        public static void DeleteTransactionType(System.Int32 transactionTypeID)
        {
            var criteria = new TransactionTypeCriteria {TransactionTypeID = transactionTypeID};
            
            
             new TransactionType().DataPortal_Delete(criteria);
        }

        #endregion
 

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="TransactionType"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="TransactionTypeCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(TransactionTypeCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="TransactionType"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="TransactionType"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="TransactionType"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="TransactionType"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="TransactionType"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="TransactionTypeCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(TransactionTypeCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="TransactionType"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
        #region ChildPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="TransactionType"/> object has been created. 
        /// </summary>
        partial void OnChildCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="TransactionTypeCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnChildFetching(TransactionTypeCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="TransactionType"/> object has been fetched. 
        /// </summary>
        partial void OnChildFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="TransactionType"/> object has been mapped. 
        /// </summary>
        //partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="TransactionType"/> object has been inserted. 
        /// </summary>
        partial void OnChildInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="TransactionType"/> object. 
        /// </summary>
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="TransactionType"/> object has been updated. 
        /// </summary>
        partial void OnChildUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="TransactionType"/> object has been deleted. 
        /// </summary>
        partial void OnChildSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="TransactionTypeCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        //partial void OnDeleting(TransactionTypeCriteria criteria, ref bool cancel);
        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="TransactionType"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="TransactionTypeCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(TransactionTypeCriteria criteria, SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="TransactionType"/> object with the specified criteria has been deleted. 
        /// </summary>
        //partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
   

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the TransactionType table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="TransactionType"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static TransactionType Exists(TransactionTypeCriteria criteria)
        {
			try
			{
					
				return new TransactionType().DataPortal_Fetch(criteria);
			}
			catch(Exception ex)
			{
			}
			return null;
			
        }

        
        #endregion

    }
}