//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProcCore.Business.DB0
{
    using System;
    using System.Collections.Generic;
    public partial class m_Menu :BaseEntityTable {
    public int menu_id { get; set; }
    public int parent_menu_id { get; set; }
    public string menu_name { get; set; }
    public string description { get; set; }
    public string area { get; set; }
    public string controller { get; set; }
    public string action { get; set; }
    public string icon_class { get; set; }
    public int sort { get; set; }
    public bool is_folder { get; set; }
    public bool is_use { get; set; }
    public bool is_on_tablet { get; set; }
    public bool is_only_tablet { get; set; }
    }
}

