using CV_st10021259.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CV_st10021259.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var myCV = new CvModel
            {
                Name = "Ethan Hunt",
                Age = 20,
                Gender = "Male",
                DriverLicense = "Code B",
                OwnTransport = true,
                Race = "White",
                Languages = new List<string> { "English" },

                AboutMe = "I am an energetic and sociable individual with a strong work ethic and a genuine passion for challenges — both in and out of the workplace. Sport has always been a central part of my life, and I carry that same discipline and drive into everything I do. Outside of work I enjoy the gym, music, gaming, and anything related to cars and engineering. I thrive equally in team environments and when working independently. My proudest achievements include completing the Midmar Mile, finishing two marathons in a single week, and crossing the finish line at the Two Oceans Ultra Marathon. I am currently training for the Comrades Marathon and a full Ironman — a testament to my commitment and resilience.",

                Experiences = new List<Experience>
                {
                    new Experience {
                        Period = "Aug 2025 – Present",
                        Role = "Brand Coach — Adidas",
                        Description = "Represent the Adidas brand through in-store sales, product knowledge, and customer engagement. Responsibilities include driving footwear and apparel sales, gathering and reporting customer feedback on product performance, and representing the brand at promotional events to deliver an exceptional brand experience.",
                        ReasonForLeaving = ""
                    },
                    new Experience {
                        Period = "Jun 2024 – Jul 2025",
                        Role = "Vending Operations Technician",
                        Description = "Managed the restocking and maintenance of vending machines across multiple sites. Monitored stock levels, identified customer purchasing trends, and ensured machines were consistently presentable and fully operational.",
                        ReasonForLeaving = "Resigned to pursue the opportunity with Adidas."
                    },
                    new Experience {
                        Period = "Nov 2023 – Jan 2024",
                        Role = "CV Specialist — Lemon Inc Recruitment",
                        Description = "Reviewed and reformatted candidate CVs to align with professional company templates, ensuring consistency, clarity, and a polished presentation for recruitment submissions.",
                        ReasonForLeaving = "Contract concluded as client volume decreased."
                    },
                    new Experience {
                        Period = "Feb 2022 – May 2022",
                        Role = "Automotive Technician Assistant — Monument Toyota",
                        Description = "Assisted with minor vehicle services and maintenance, parts collection, and pre-delivery inspections. Responsibilities included diagnosing vehicle faults, preparing new vehicles for customer handover, and quality-checking used vehicles prior to sale.",
                        ReasonForLeaving = "Could not continue due to study commitments."
                    }
                },

                EducationList = new List<Education>
                {
                    new Education { Year = "2010 – 2021", Institution = "Trinity House Randpark Ridge", Qualification = "National Senior Certificate (Matric)" },
                    new Education { Year = "2022",         Institution = "Abbotts College",              Qualification = "Matric Upgrade" },
                    new Education { Year = "2023 – Present", Institution = "IIE MSA",                  Qualification = "BSc Engineering / Computer Science" }
                },

                Skills = new List<string>
                {
                    "Analytical problem solving",
                    "Independent thinking",
                    "Strong interpersonal skills",
                    "Fast learner",
                    "Performs well under pressure",
                    "Attention to detail"
                },

                ComputerSkills = new List<string>
                {
                    "Microsoft Word",
                    "Microsoft Excel",
                    "Microsoft PowerPoint",
                    "Outlook",
                    "Microsoft Teams",
                    "Java",
                    "C#",
                    "Kotlin",
                    "HTML",
                    "Cloud Services (Azure)",
                    "Network Engineering Fundamentals"
                },

                Address = "13 During Road, Honeydew Manor, Johannesburg, South Africa",
                Phone = "065 962 4621",
                Email = "Ehunt2309@gmail.com"
            };

            return View(myCV);
        }
    }
}