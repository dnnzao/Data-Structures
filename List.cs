using System;

namespace Solution2 {
    internal class List {
		private Cell first;
		private Cell last;
		private int countProducts;
		private int countStudents;

		public List() {
			this.first = new Cell();
			this.last = this.first;
			this.countProducts = 0;
			this.countStudents = 0;
		}

		public Boolean InsertBeginning(Product produto) {
			if (this.countProducts == 5) {
				Console.WriteLine("LIST FULL!");
				return false;
			}
			Cell temp = new Cell(produto);
			temp.setNextProd(this.first.getNextProd());
			this.first.setNextProd(temp);
			this.last.setPrevProd(temp);
			this.countProducts++;
			return true;
		}

		public void PrintListProduct() {
			Cell temp = new Cell();
			temp = this.first.getNextProd();
			for (int i = 0; i < this.countProducts; i++) {
				Console.WriteLine("PRODUCT: Code: " + temp.getProd().getCode());
				Console.WriteLine(" / Quantity: " + temp.getProd().getQuantity());
				Console.WriteLine(" / Price: " + temp.getProd().getPrice());
				Console.WriteLine("");
				temp = temp.getNextProd();
			}
		}

		public void PrintProductOver500() {
			Cell temp = new Cell();
			temp = this.first.getNextProd();
			for (int i = 0; i < this.countProducts; i++) {
				if (temp.getProd().getQuantity() > 500) {
					Console.WriteLine("PRODUCT: Code: " + temp.getProd().getCode());
					Console.WriteLine(" / Quantity: " + temp.getProd().getQuantity());
					Console.WriteLine(" / Price: " + temp.getProd().getPrice());
					Console.WriteLine("");
					temp = temp.getNextProd();
				}
			}
		}

		// LISTA COM ALUNOS

		public Boolean InsertBeginning(Student aluno) {
			if (this.countStudents == 15) {
				Console.WriteLine("LIST FULL!");
				return false;
			}
			Cell temp = new Cell(aluno);
			temp.setNextStudent(this.first.getNextStudent());
			this.first.setNextStudent(temp);
			this.last.setPrevStudent(temp);
			this.countStudents++;
			return true;
		}

		public void PrintListStudents() {
			Cell temp = new Cell();
			temp = this.first.getNextStudent();
			for (int i = 0; i < this.countStudents; i++) {
				Console.WriteLine("Student name: " + temp.getStudent().getName());
				Console.WriteLine(" / Grade: " + temp.getStudent().getGrade());
				Console.WriteLine("");
				temp = temp.getNextStudent();
			}
		}

		public void PrintStudentsApproved() {
			Cell temp = new Cell();
			temp = this.first.getNextStudent();
			do {
				if (temp.getStudent().getGrade() >= 70) {
					Console.WriteLine("Name do aluno: " + temp.getStudent().getName());
					Console.WriteLine(" / Grade: " + temp.getStudent().getGrade());
					Console.WriteLine("");
					temp = temp.getNextStudent();
				} else {
					temp = temp.getNextStudent();
				}
			} while (temp.getNextStudent() != null);
		}
	}
}