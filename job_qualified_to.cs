using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace JobAd
{
	[TestClass]
	public class QualifiedToJob
	{
		[TestMethod]
		public void IsQualified()
		{

			Applicant oApplicant = new Applicant() { Name = "Hans Hansen", Email = "hans@lolk-hansen.dk", Phonenumber = "+4551224168" };
			string strAdditionalMotivation = @"Jeg søger ofte 'The read pill' og er altid klar til at 'follow the white rabbit'. Dertil kommer, at jeg kan fornemme, at denne stilling kan tilbyde mig udfordringer og gode sociale relationer - på en dejlig nørdet måde.";
			List<Skill> oSkills = new List<Skill> {
				/// Required skills
				new Skill() { SkillName = "ASP.NET", SkillLevel = SkillLevel.Pro, SkillCategory = SkillCategory.Programming },
				new Skill() { SkillName = "ASP.NET MVC", SkillLevel = SkillLevel.Average, SkillCategory = SkillCategory.Programming },
				new Skill() { SkillName = "C#", SkillLevel = SkillLevel.Pro, SkillCategory = SkillCategory.Programming },
				new Skill() { SkillName = "Taler og skriver dansk", SkillLevel = SkillLevel.Pro, SkillCategory = SkillCategory.Meta },
				new Skill() { SkillName = "Relevant uddannelse fra KU, ITU eller lignende", SkillLevel = SkillLevel.Pro, SkillCategory = SkillCategory.Meta },
				new Skill() { SkillName = "Trives med at have ansvar for egne projekter fra ide til implementering", SkillLevel = SkillLevel.Average, SkillCategory = SkillCategory.Meta },
				/// Nice to have skills
				new Skill() { SkillName = "Entity Framework", SkillLevel = SkillLevel.Beginner, SkillCategory = SkillCategory.Programming },
				new Skill() { SkillName = "SQL", SkillLevel = SkillLevel.Pro, SkillCategory = SkillCategory.Programming },
				new Skill() { SkillName = "Unit testing", SkillLevel = SkillLevel.Average, SkillCategory = SkillCategory.Programming },
				new Skill() { SkillName = "Dependency Injection", SkillLevel = SkillLevel.Beginner, SkillCategory = SkillCategory.Programming },
				new Skill() { SkillName = "Agile development (Scrum)", SkillLevel = SkillLevel.Beginner, SkillCategory = SkillCategory.Programming },
				new Skill() { SkillName = "HTML/CSS", SkillLevel = SkillLevel.Average, SkillCategory = SkillCategory.Programming },
				new Skill() { SkillName = "jQuery", SkillLevel = SkillLevel.Pro, SkillCategory = SkillCategory.Programming },
				new Skill() { SkillName = "Backend", SkillLevel = SkillLevel.Pro, SkillCategory = SkillCategory.Programming },
				new Skill() { SkillName = "Frontend", SkillLevel = SkillLevel.Pro, SkillCategory = SkillCategory.Programming },
				/// Meta skills
				new Skill() { SkillName = "Trives i et ungt og dynamisk miljø", SkillLevel = SkillLevel.Pro, SkillCategory = SkillCategory.Meta },
				new Skill() { SkillName = "Nysgerrig og lærenem", SkillLevel = SkillLevel.Pro, SkillCategory = SkillCategory.Meta },
				new Skill() { SkillName = "Nyder at arbejde tæt sammen med andre udviklere og kravstillere", SkillLevel = SkillLevel.Average, SkillCategory = SkillCategory.Meta },
				new Skill() { SkillName = "Ønsker at arbejde i et lille .NET team med senior and junior developers", SkillLevel = SkillLevel.Average, SkillCategory = SkillCategory.Meta },
				new Skill() { SkillName = "Har humor og masser af godt humør", SkillLevel = SkillLevel.Pro, SkillCategory = SkillCategory.Meta },
				new Skill() { SkillName = "Foretrækker lækker mad fra en kantine fremfor kedelige madpakker", SkillLevel = SkillLevel.Beginner, SkillCategory = SkillCategory.Meta },
				new Skill() { SkillName = "Ser frem til hyggelige sociale arrangementer med kollegaerne", SkillLevel = SkillLevel.Average, SkillCategory = SkillCategory.Meta }
			};
			JobApplication oJobApplication = new JobApplication(oApplicant, strAdditionalMotivation, oSkills);
			Debug.WriteLine(oJobApplication.ApplicationAnalysis());
		}
	}
}
