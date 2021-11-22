using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ThAmCo.Events.DTOs;
using ThAmCo.Events.Models;

namespace ThAmCo.Events.ViewModels
{
    public class EventTitleViewModel
    {

        public int EventId { get; set; }
        public DateTime EventDateTime { get; set; }

        [Required]
        public string EventTitle { get; set; }

        [Required]
        public string EventTypeTitle { get; set; }
        public string EventTypeId { get; set; }

    }
}
