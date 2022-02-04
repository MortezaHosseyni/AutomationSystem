//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModelLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vw_Letters
    {
        public int LetterID { get; set; }
        public string LetterSubject { get; set; }
        public string LetterCaption { get; set; }
        public string LetterNo { get; set; }
        public string LetterCreatedDate { get; set; }
        public int LetterUserID { get; set; }
        public byte LetterSecurityType { get; set; }
        public byte LetterForceType { get; set; }
        public byte LetterArchiveType { get; set; }
        public byte LetterFollowingType { get; set; }
        public byte LetterAttachmentType { get; set; }
        public byte LetterType { get; set; }
        public byte LetterDraftType { get; set; }
        public string LetterAbstract { get; set; }
        public byte LetterAnswerType { get; set; }
        public string LetterAnswerDeadLine { get; set; }
        public string LetterReffrence { get; set; }
        public Nullable<int> LetterReplyID { get; set; }
        public string View_LetterSecurityType { get; set; }
        public string View_LetterForceType { get; set; }
        public string View_LetterArchiveType { get; set; }
        public string View_LetterFollowingType { get; set; }
        public string View_LetterAttachmentType { get; set; }
        public string View_LetterType { get; set; }
        public string View_LetterDraftType { get; set; }
        public string View_LetterAnswerType { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserFullName { get; set; }
        public string LetterSentDate { get; set; }
    }
}
