//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace O_BEBUM
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_NOTICI
    {
        public int NOTI_ID { get; set; }
        public string NOTI_TITULO { get; set; }
        public string NOTI_TEXTO { get; set; }
        public System.DateTime NOTI_DATA { get; set; }
        public int PESS_ID { get; set; }
    
        public virtual TB_PESSOA TB_PESSOA { get; set; }
    }
}