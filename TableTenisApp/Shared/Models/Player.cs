using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTenisApp.Shared.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PicturePath { get; set; }
        public int Points { get; set; }
    }
}
