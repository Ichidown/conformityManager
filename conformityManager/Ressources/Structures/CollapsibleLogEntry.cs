using System.Collections.Generic;

namespace conformityManager.Ressources.Structures
{
    public class CollapsibleLogEntry : LogEntry
    {
        public List<LogEntry> Contents { get; set; }
    }
}
