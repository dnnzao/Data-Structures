using System;

namespace Solution2 {
    internal class Stack {
		private Cell topProd;
		private Cell topInt;
		private Cell topStudent;
		private int countProd = 0;
		private int countIntegers = 0;
		private int countStudent = 0;

		public Stack() {
			this.topProd = new Cell();
			this.topInt = new Cell();
			this.topStudent = new Cell();
		}

		//--------------------------------------------------------------------//
		// STACK OF PRODUCTS
		public Boolean Stacking(Product prod) {
			Cell temp = new Cell(prod);
			if (countProd == 0) {
				topProd.setPrevProd(temp);
				Console.WriteLine(" " + topProd.getPrevProd().getProd().getCode());
				this.countProd++;
				return true;
			} else {
				temp.setPrevProd(topProd.getPrevProd());
				topProd.setPrevProd(temp);
				Console.WriteLine(" " + topProd.getPrevProd().getProd().getCode());
				this.countProd++;
				return false;
			}
		}

		public void PrintStack() {
			Cell temp = new Cell();
			temp = this.topProd.getPrevProd();

			while (temp != null) {
				Console.WriteLine("PRODUCT: Code: " + temp.getProd().getCode() + " / Quantity: "
						+ temp.getProd().getQuantity() + " / Price: " + temp.getProd().getPrice());
				temp = temp.getPrevProd();
			}
		}

		public Product Unstack() {
			if (this.countProd == 0)
				return null;
			if (this.topProd == null)
				return null;

			Cell temp = this.topProd;
			this.topProd = temp.getNextProd();
			temp.setNextProd(null);
			this.countProd--;
			return temp.getProd();
		}

		//--------------------------------------------------------------------//
		// STACK OF STUDENTS
		public Boolean Stacking(Student student) {
			Cell temp = new Cell(student);
			if (countStudent == 0) {
				topStudent.setPrevStudent(temp);
				Console.WriteLine(" " + topStudent.getPrevStudent().getStudent().getName());
				this.countStudent++;
				return true;
			} else {
				temp.setPrevStudent(topStudent.getPrevStudent());
				topStudent.setPrevStudent(temp);
				Console.WriteLine(" " + topStudent.getPrevStudent().getStudent().getName());
				this.countStudent++;
				return false;
			}
		}

		public void PrintStackStudents() {
			Cell temp = new Cell();
			temp = this.topStudent.getPrevStudent();

			while (temp != null) {
				Console.WriteLine("STUDENT: Name: " + temp.getStudent().getName() + " | Grade: " + temp.getStudent().getGrade());
				temp = temp.getPrevStudent();
			}
		}

		//--------------------------------------------------------------------//	
		// STACK OF INTEGERS
		public Boolean Stacking(int n) {
			Cell temp = new Cell(n);
			if (countIntegers == 0) {
				topInt.setPrevInt(temp);
				Console.WriteLine(" " + topInt.getInt());
				this.countIntegers++;
				return true;
			} else {
				temp.setPrevInt(topInt.getPrevInt());
				topInt.getPrevInt().setNextInt(temp);
				topInt.setPrevInt(temp);
				Console.WriteLine(" " + topInt.getInt());
				this.countIntegers++;
				return false;
			}
		}

		public void PrintStackInteger() {
			Cell temp = new Cell();
			temp = this.topInt.getPrevInt();

			while (temp != null) {
				Console.WriteLine("" + temp.getInt());
				temp = temp.getPrevInt();
			}
		}
		//--------------------------------------------------------------------//
		public Boolean isEmpty() {
			if (this.countIntegers == 0)
				return true;
			if (this.topInt.getPrevInt() == null)
				return true;
			return false;
		}
	}
}