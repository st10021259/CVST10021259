using System.Collections.Generic;
namespace CV_st10021259.Models
{
    public class CvModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string DriverLicense { get; set; }
        public bool OwnTransport { get; set; }
        public string Race { get; set; }
        public List<string> Languages { get; set; }
        public string AboutMe { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Education> EducationList { get; set; }
        public List<string> Skills { get; set; }
        public List<string> ComputerSkills { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
    public class Experience
    {
        public string Period { get; set; }
        public string Role { get; set; }
        public string Description { get; set; }
        public string ReasonForLeaving { get; set; }
    }
    public class Education
    {
        public string Year { get; set; }
        public string Institution { get; set; }
        public string Qualification { get; set; }
    }
}