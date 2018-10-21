using System;
using System.Collections.Generic;
using System.Text;

namespace PTM.Models
{
    public class TasksModel
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public DateTime WorkedDate { get; set; }
        public decimal TimeSpent { get; set; }
    }
}
