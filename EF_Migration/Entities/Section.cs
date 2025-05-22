using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Migration.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string? SectionName { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; } = null!;

        public int? InstractorId { get; set; }
        public Instractor? Instractor { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public TimeSlot TimeSlot { get; set; }

        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<Student> Students { get; set; } = new List<Student>();

    }
    public class TimeSlot
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public override string ToString()
        {
            return $" {StartTime.ToString("hh\\:mm")} - {EndTime.ToString("hh\\:mm")}";
            ;
        }
    }

}
