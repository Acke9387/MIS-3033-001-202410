using System.ComponentModel;

namespace MyFirstMVCApplication.Models
{
    public class DeveloperInformation
    {
        [DisplayName("Developer Name")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public DeveloperInformation()
        {
            Name = "";
            Email = "";
            PhoneNumber = "";
        }
    }
}
