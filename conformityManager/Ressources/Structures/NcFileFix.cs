using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conformityManager.Ressources.Structures
{
    public struct NcFileFix
    {
        public string cause { get; set; } // (Cause(s) probable(s))
        // public int fix_user_id { get; set; }
        public string action_description { get; set; } // (Description de l'action correction / corrective)
        public int action_type { get; set; } // (correction / corrective)
        public string fixer_full_name { get; set; } // (Etablie par)
        public string fixer_function { get; set; }
        public string fixer_structure_name { get; set; } // (La structure responsable de mise en œuvre)
        public string estimated_start_date { get; set; } // (Temps planifier pour lever la Non-conformité)
        public string estimated_end_date { get; set; }
        public string fix_date { get; set; } // (date de Réalisation)


        public NcFileFix(string cause /*, int fix_user_id*/, string action_description, int action_type, string fixer_full_name, string fixer_function, string fixer_structure_name, string estimated_start_date, string estimated_end_date, string fix_date) : this()
        {
            this.cause = cause;
            // this.fix_user_id = fix_user_id;
            this.action_description = action_description;
            this.action_type = action_type;
            this.fixer_full_name = fixer_full_name;
            this.fixer_function = fixer_function;
            this.fixer_structure_name = fixer_structure_name;
            this.estimated_start_date = estimated_start_date;
            this.estimated_end_date = estimated_end_date;
            this.fix_date = fix_date;
        }
    }
}
