using System;

namespace Solution2 {
	internal class Student {
		private string name;
		private double grade;

		public Student() {
			this.grade = 0;
			this.name = "";
		}

		public Student(String name, double grade) {
			if (!setName(name)) {
				Console.WriteLine("ERROR: Invalid name!	");
			}
			if (!setGrade(grade)) {
				Console.WriteLine("ERROR: Invalid grade!");
			}
		}

		public string getName() {
			return name;
		}

		public Boolean setName(string name) {
			if (name.Equals(null)) return false;
			this.name = name;
			return true;
		}

		public double getGrade() {
			return grade;
		}

		public Boolean setGrade(double grade) {
			if (grade < 0 || grade > 100) return false;
			this.grade = grade;
			return true;
		}
	}
}