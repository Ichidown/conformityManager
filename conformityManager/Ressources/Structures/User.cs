
namespace conformityManager.Ressources.Structures
{
    public struct User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string full_name { get; set; }
        public string function { get; set; }
        public bool user_type { get; set; }

        public User(int id = -1, string username="", string full_name="", string function="", bool user_type=false)
        {
            this.id = id;
            this.username = username;
            this.full_name = full_name;
            this.function = function;
            this.user_type = user_type;
        }
    }
}
