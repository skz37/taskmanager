using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Domain.Enums
{
    internal enum TaskStatu
    {
        ToDo,
        InProgress,
        Done,
        InReview
    }
    public enum TaskPriority
    {
        Low,
        Medium,
        High,
        Urgent
    }
    public enum WorkspaceRole
    {
        Owner,
        ProjectManager,
        Member
    }
    public enum ProjectStatus
    {
        NotStarted,
        InProgress,
        Completed,
        OnHold,
        Cancelled
    }
    public enum NotificationType
    {
        TaskAssigned,
        TaskSubmitted,
        TaskApproved,
        TaskRejected,
        TaskDueSoon,
        ProjectCreated,
        ProjectMemberAdded
    }


}
