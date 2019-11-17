
namespace conformityManager.Ressources.Structures
{
    public struct Log
    {
        public int id { get; set; }
        public string action_type { get; set; }
        public string actor_user_name { get; set; }
        public string full_operation_detail { get; set; }
        public string action_date { get; set; }

        public Log(int id, int action_type, string actor_user_name, string full_operation_detail, string action_date) : this()
        {
            this.id = id;
            
            this.actor_user_name = actor_user_name;
            this.full_operation_detail = full_operation_detail;
            this.action_date = action_date;

            
            this.action_type = action_type==0? "PaleGreen" : action_type == 1 ? "DarkOrange" : "IndianRed";
        }
    }
}
