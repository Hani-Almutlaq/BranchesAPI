﻿namespace BranchesAPI.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public int BranchId { get; set; }
        public string? Sunday { get; set; }
        public string? Monday { get; set; }
        public string? Tuesday { get; set; }
        public string? Wednesday { get; set; }
        public string? Thursday { get; set; }
        public string? Friday { get; set; }
        public string? Saturday { get; set; }
    }
}
