﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'EmailQueue.cs'.
//
//     Template path: DTO.Generated.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;


using System.Collections.Generic;
 
namespace CFMData
{
    [Serializable]
    public partial class EmailQueueDTO
    {
 #region Contructor(s)

        public EmailQueueDTO()
        { /* Require use of factory methods */ }

        #endregion

public EmailQueue CopyDTO(EmailQueue obj)
		{
			 
			obj.MailingTemplateID =this.MailingTemplateID ;
			obj.SendTo =this.SendTo ;
			obj.MailingText =this.MailingText ;
			obj.MailingSubject =this.MailingSubject ;
			obj.MailingFrom =this.MailingFrom ;
			obj.RequestedDate =this.RequestedDate ;
			obj.ProcessedDate =this.ProcessedDate ;
			obj.ProcessResult =this.ProcessResult ;
			return obj;
		}
        #region Properties

        public System.Int32 EmailQueueID { get; set; }
        public System.Int32? MailingTemplateID { get; set; }
        public System.String SendTo { get; set; }
        public System.String MailingText { get; set; }
        public System.String MailingSubject { get; set; }
        public System.String MailingFrom { get; set; }
        public System.DateTime RequestedDate { get; set; }
        public System.DateTime? ProcessedDate { get; set; }
        public System.String ProcessResult { get; set; }

	
	
	
	
	
	
        private MailingTemplateDTO  _mailingTemplateProperty=null;
        public MailingTemplateDTO MailingTemplate
        {
			get
			{
				return  _mailingTemplateProperty;
			}
			set
			{
				 _mailingTemplateProperty=value;
			}
			
		}
        public void LoadMailingTemplate(EmailQueue obj)
		{
			if(obj.MailingTemplate!=null)
			{
				_mailingTemplateProperty=obj.MailingTemplate.CurrentDTO;
			}
		}
		
		
			



        #endregion

    }
}