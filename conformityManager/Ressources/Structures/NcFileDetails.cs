
namespace conformityManager.Ressources.Structures
{
    public struct NcFileDetails
    {
        public string n_plan { get; set; } // (N° de plan)
        public string partial_set { get; set; } // (Ensemble partiel)
        public string description { get; set; } // (Description de la NC constatée)

        public NcFileDetails(string n_plan="", string partial_set = "", string description = "") : this()
        {
            this.n_plan = n_plan;
            this.partial_set = partial_set;
            this.description = description;
        }
    }
}
