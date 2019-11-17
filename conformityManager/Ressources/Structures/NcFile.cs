using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conformityManager.Ressources.Structures
{
    public struct NcFile
    {
        public int id { get; set; }
        //public int type { get; set; }  // (qualite / hse)
        public int nc_user_id { get; set; }
        public int state { get; set; } // (Non entamée / En cours / Réalisée)
        public string nc_user_full_Name { get; set; } // auteur
        public string client { get; set; }
        public string case_title { get; set; } // (Affaire)
        public bool source { get; set; } // (Constat NC interne / Constat NC client)
        //public int n_plan { get; set; } // (N° de plan)
        //public string partial_set { get; set; } // (Ensemble partiel)
        public string structure_name { get; set; }
        //public string description { get; set; } // (Description de la NC constatée)
        public string creation_date { get; set; }

        //public string cause { get; set; } // (Cause(s) probable(s))
        //public int fix_user_id { get; set; }
        //public string action_description { get; set; } // (Description de l'action correction / corrective)
        //public int action_type { get; set; } // (correction / corrective)
        //public string fixer_full_name { get; set; } // (Etablie par)
        //public string fixer_function { get; set; }
        //public string fixer_structure_name { get; set; } // (La structure responsable de mise en œuvre)
        public string estimated_start_date { get; set; } // (Temps planifier pour lever la Non-conformité)
        public string estimated_end_date { get; set; }
        public string fix_date { get; set; } // (date de Réalisation)
        public bool is_valid { get; set; } // (validation R SMI)

        public int fix_user_id { get; set; }



        public NcFile(int id, int nc_user_id, int state, string nc_user_full_Name, string client, string case_title, bool source, string structure_name, string creation_date, string estimated_start_date, string estimated_end_date, string fix_date, bool is_valid, int fix_user_id)
        {
            this.id = id;
            this.nc_user_id = nc_user_id;
            this.state = state;
            this.nc_user_full_Name = nc_user_full_Name;
            this.client = client;
            this.case_title = case_title;
            this.source = source;
            this.structure_name = structure_name;
            this.creation_date = creation_date;
            this.estimated_start_date = estimated_start_date;
            this.estimated_end_date = estimated_end_date;
            this.fix_date = fix_date;
            this.is_valid = is_valid;
            this.fix_user_id = fix_user_id;
        }
    }

}
