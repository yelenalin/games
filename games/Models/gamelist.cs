//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace games.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class gamelist
    {
        public int id { get; set; }
        public string game_no { get; set; }
        public string game_name { get; set; }
        public string game_type { get; set; }
        public string game_publisher { get; set; }
        public Nullable<System.DateTime> game_data { get; set; }
        public string game_remark { get; set; }
        public Nullable<decimal> price { get; set; }
        public string game_image { get; set; }
    }
}