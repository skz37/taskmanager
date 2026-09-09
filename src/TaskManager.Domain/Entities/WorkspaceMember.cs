using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Enums;

namespace TaskManager.Domain.Entities
{
    internal public class WorkspaceMember
    {
        public Guid WorkspaceId { get; private set; }

        public Guid UserId { get; private set; }

        public WorkspaceRole Role { get; private set; }
    }
}
