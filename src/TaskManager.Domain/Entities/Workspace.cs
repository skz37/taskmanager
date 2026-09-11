using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Common;

namespace TaskManager.Domain.Entities
{
    public class Workspace : BaseEntity
    {
        public string Name { get; private set; }
        public string? Description { get; private set; }

        public Guid OwnerId { get; private set; }

        public ICollection<Project> Projects { get; private set; }
            = new List<Project>();

        public ICollection<WorkspaceMember> Members { get; private set; }
            = new List<WorkspaceMember>();
    }
}
