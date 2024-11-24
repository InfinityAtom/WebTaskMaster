using System;
using System.Collections.Generic;

namespace WebTaskMaster.Model;

public partial class Activity
{
    public int TaskId { get; set; }

    public int UserId { get; set; }

    public string TaskTitle { get; set; } = null!;

    public string? TaskDescription { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool Completed { get; set; }

    public virtual User User { get; set; } = null!;
}
