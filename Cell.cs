namespace Solution2 {
	internal class Cell {
		private Product prod;
		private Cell prevProd;
		private Cell nextProd;

		private Student student;
		private Cell prevStudent;
		private Cell nextStudent;

		private int integer;
		private Cell prevInt;
		private Cell nextInt;

		public Cell() {
			this.prevProd = null;
			this.nextProd = null;
			this.prevInt = null;
			this.nextInt = null;
			this.prevStudent = null;
			this.nextStudent = null;
		}

		public Cell(Product prod) {
			this.prod = prod;
			this.prevProd = null;
			this.nextProd = null;
		}

		public Product getProd() {
			return prod;
		}

		public void setProd(Product prod) {
			this.prod = prod;
		}

		public Cell getPrevProd() {
			return prevProd;
		}

		public void setPrevProd(Cell prevProd) {
			this.prevProd = prevProd;
		}

		public Cell getNextProd() {
			return nextProd;
		}

		public void setNextProd(Cell nextProd) {
			this.nextProd = nextProd;
		}

		// CELULA ALUNO
		public Cell(Student student) {
			this.student = student;
			this.prevStudent = null;
			this.nextStudent = null;
		}

		public Student getStudent() {
			return this.student;
		}

		public void setStudent(Student student) {
			this.student = student;
		}

		public Cell getPrevStudent() {
			return prevStudent;
		}

		public void setPrevStudent(Cell prevStudent) {
			this.prevStudent = prevStudent;
		}

		public Cell getNextStudent() {
			return nextStudent;
		}

		public void setNextStudent(Cell nextStudent) {
			this.nextStudent = nextStudent;
		}

		// CELULA INTEIRO
		public Cell(int integer) {
			this.integer = integer;
			this.prevInt = null;
			this.nextInt = null;
		}

		public Cell getPrevInt() {
			return prevInt;
		}

		public void setPrevInt(Cell prevInt) {
			this.prevInt = prevInt;
		}

		public Cell getNextInt() {
			return nextInt;
		}

		public void setNextInt(Cell nextInt) {
			this.nextInt = nextInt;
		}

		public int getInt() {
			return this.integer;
		}

		public void setN(int integer) {
			this.integer = integer;
		}
	}
}
