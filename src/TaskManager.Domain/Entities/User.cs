using System.Collections.Generic;

namespace TaskManager.Domain.Entities
{
    public class User
    {
        public System.Guid Id { get; private set; }

        public Common.Email Email { get; private set; }

        public ICollection<TaskItem> AssignedTasks { get; private set; } = new List<TaskItem>();
    }
}
