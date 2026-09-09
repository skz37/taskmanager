using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Common;
using TaskManager.Domain.Enums;
using TaskManager.Domain.Exceptions;


namespace TaskManager.Domain.Entities
{
    internal class TaskItem : BaseEntity
    {
        public string Title { get; private set; }
        public string? Description { get; private set; }
        public TaskStatu Status { get; private set; } = TaskStatu.ToDo;
        public TaskPriority Priority { get; private set; }
        public DateTime? DueDate { get; private set; }
        public Guid ProjectId { get; private set; }
        public Guid? AssignedUserId { get; private set; }

        private TaskItem() { } // requis par EF Core

        public TaskItem(string title, Guid projectId, TaskPriority priority)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new DomainExceptions("Le titre de la tâche est obligatoire.");
            Title = title;
            ProjectId = projectId;
            Priority = priority;
        }


        public void AssignTo(Guid userId)
        {
            AssignedUserId = userId;
        }
        public void ChangeStatus(TaskStatu newStatus)
        {
            if (newStatus == TaskStatu.Done && AssignedUserId is null)
                throw new DomainExceptions(
                "Impossible de terminer une tâche non assignée.");
            Status = newStatus;
        }
    }
        
    }
