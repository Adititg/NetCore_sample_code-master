﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BusinessDivisionList.cs'.
//
//     Template: EditableRootList.Generated.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
 
namespace CFMData
{
    [Serializable]
    public partial class BusinessDivisionList : List< BusinessDivision>
    {    
        private List<BusinessDivisionDTO> _currentDto =null; 
        public List<BusinessDivisionDTO> CurrentDTO
        {
            get 
            {
                if (_currentDto==null)
                {
                    _currentDto=new List<BusinessDivisionDTO>();
                    foreach (BusinessDivision entity in this)
                    {
                        _currentDto.Add(entity.CurrentDTO);
                    }
                }
                return _currentDto;
			}
            
        }
        #region Contructor(s)

        public BusinessDivisionList()
        { 
       //     AllowNew = true;
        }

        #endregion

       

        #region Synchronous Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="BusinessDivisionList"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="BusinessDivisionList"/>.</returns>
        public static BusinessDivisionList NewList()
        {
            return new BusinessDivisionList();
        }      

        /// <summary>
        /// Returns a <see cref="BusinessDivisionList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="businessDivisionID">No additional detail available.</param>
        /// <returns>A <see cref="BusinessDivisionList"/> object of the specified criteria.</returns>
        public static BusinessDivisionList GetByBusinessDivisionID(System.Int32 businessDivisionID)
        {
            var criteria = new BusinessDivisionCriteria{BusinessDivisionID = businessDivisionID};
            
            
          return  new BusinessDivisionList().DataPortal_Fetch(criteria);
        }

        /// <summary>
        /// Returns a <see cref="BusinessDivisionList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="businessEntityID">No additional detail available.</param>
        /// <returns>A <see cref="BusinessDivisionList"/> object of the specified criteria.</returns>
        public static BusinessDivisionList GetByBusinessEntityID(System.Int32 businessEntityID)
        {
            var criteria = new BusinessDivisionCriteria{BusinessEntityID = businessEntityID};
            
            
          return  new BusinessDivisionList().DataPortal_Fetch(criteria);
        }

        public static BusinessDivisionList GetByCriteria(BusinessDivisionCriteria criteria)
        {
          return  new BusinessDivisionList().DataPortal_Fetch(criteria);
//            return DataPortal.Fetch<BusinessDivisionList>(criteria);
        }

        public static BusinessDivisionList GetAll()
        {
          return  new BusinessDivisionList().DataPortal_Fetch(new BusinessDivisionCriteria());
            //return DataPortal.Fetch<BusinessDivisionList>(new BusinessDivisionCriteria());
        }

        #endregion

        #region Asynchronous Factory Methods
     

     

     
 
        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BusinessDivision"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BusinessDivisionCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(BusinessDivisionCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BusinessDivision"/> object has been fetched. 
        /// </summary>
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BusinessDivision"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BusinessDivision"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();
       // partial void OnAddNewCore(ref BusinessDivision item, ref bool cancel);

        #endregion

    }
}