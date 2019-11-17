using System;

namespace conformityManager.Ressources.Structures
{
    public struct NonConformityCase
    {
        public int id{ get; set; }
        public int type{ get; set; }  // (qualite / hse)
        public int state{ get; set; } // (Non entamée / En cours / Réalisée)
        public int nc_user_id{ get; set; }
        public string client{ get; set; }
        public string caseTitle{ get; set; } // (Affaire)
        public int source{ get; set; } // (Constat NC interne / Constat NC client)
        public int n_plan{ get; set; } // (N° de plan)
        public string partial_set{ get; set; } // (Ensemble partiel)
        public string structure_name{ get; set; }
        public string description{ get; set; } // (Description de la NC constatée)
        public DateTime creation_date{ get; set; }

        public string cause{ get; set; } // (Cause(s) probable(s))
        public int fix_user_id{ get; set; }
        public string action_description{ get; set; } // (Description de l'action correction / corrective)
        public int action_type{ get; set; } // (correction / corrective)
        public string fixer_full_name{ get; set; } // (Etablie par)
        public string fixer_function{ get; set; }
        public string fixer_structure_name{ get; set; } // (La structure responsable de mise en œuvre)
        public DateTime estimated_start_date{ get; set; } // (Temps planifier pour lever la Non-conformité)
        public DateTime estimated_end_date{ get; set; }
        public DateTime fix_date{ get; set; } // (date de Réalisation)
        public bool is_valid{ get; set; } // (validation R SMI)



        public NonConformityCase(int id, int type, int state, int nc_user_id, string client, string caseTitle, int source, int n_plan, string partial_set, string structure_name, string description, DateTime creation_date, string cause, int fix_user_id, string action_description, int action_type, string fixer_full_name, string fixer_function, string fixer_structure_name, DateTime estimated_start_date, DateTime estimated_end_date, DateTime fix_date, bool is_valid)
        {
            this.id = id;
            this.type = type;
            this.state = state;
            this.nc_user_id = nc_user_id;
            this.client = client;
            this.caseTitle = caseTitle;
            this.source = source;
            this.n_plan = n_plan;
            this.partial_set = partial_set;
            this.structure_name = structure_name;
            this.description = description;
            this.creation_date = creation_date;
            this.cause = cause;
            this.fix_user_id = fix_user_id;
            this.action_description = action_description;
            this.action_type = action_type;
            this.fixer_full_name = fixer_full_name;
            this.fixer_function = fixer_function;
            this.fixer_structure_name = fixer_structure_name;
            this.estimated_start_date = estimated_start_date;
            this.estimated_end_date = estimated_end_date;
            this.fix_date = fix_date;
            this.is_valid = is_valid;
        }
    }
}
