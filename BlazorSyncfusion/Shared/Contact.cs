using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorSyncfusion.Shared
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Place { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; } 
        public DateTime? DateDeleted { get; set; } 
        [JsonIgnore]
        public List<Note>  Notes { get; set; } = new List<Note>();
    }
}
