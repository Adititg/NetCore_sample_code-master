﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//       Changes to this template will not be lost.
//
//     Template: EditableRoot.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;


namespace CFMData
{    
    /// <summary>
    /// The BudgetLineCategory class is a editable root class.
    /// </summary>
    public partial class BudgetLineCategory
    {
        #region Business Rules
    
        /// <summary>
        /// All custom rules need to be placed in this method.
        /// </summary>
        /// <returns>Return true to override the generated rules; If false generated rules will be run.</returns>
        protected bool AddBusinessValidationRules()
        {
            // TODO: add validation rules
            //BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(MyProperty));

            return false;
        }

        #endregion

 
    }
}