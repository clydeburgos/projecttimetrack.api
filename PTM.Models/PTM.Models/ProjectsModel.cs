using System;
using System.Collections.Generic;
using System.Text;

namespace PTM.Models
{
    public class ProjectsModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateEnded { get; set; }
    }
}
