using System;
namespace Solution2 {
    class Program {
        static void Main(string[] args) {
			List list = new List();
			Stack stack = new Stack();


			Product prod1 = new Product(11, 150, 22.2);
			Product prod2 = new Product(16, 250, 2222.2);
			Product prod3 = new Product(10, 1, 10000);
			Product prod4 = new Product(12, 3, 1.1);
			Product prod5 = new Product(1, 1150, 33.2);
			Product prod6 = new Product(100, 1150, 33.2);


			list.InsertBeginning(prod1);
			list.InsertBeginning(prod2);
			list.InsertBeginning(prod3);
			list.InsertBeginning(prod4);
			list.InsertBeginning(prod5);
			list.InsertBeginning(prod6);
			Console.WriteLine("PRINTING LIST OF PRODUCTS:");
			list.PrintListProduct();
			Console.WriteLine("PRINTING LIST (PROCUCTS OVER 500):");
			list.PrintProductOver500();

			stack.Stacking(prod1);
			stack.Stacking(prod2);
			stack.Stacking(prod3);
			stack.Stacking(prod4);
			stack.Stacking(prod5);
			Console.WriteLine("TESTING THE STACK OF PRODUCTS: ");
			stack.PrintStack();



			Student a1 = new Student("Lucas", 70);
			Student a2 = new Student("Pedro", 70);
			Student a3 = new Student("Iara", 80);
			Student a4 = new Student("Rafael", 90);
			Student a5 = new Student("Peruano", 60);
			Student a6 = new Student("Zandor", 50);
			Student a7 = new Student("Retardado de Arapongas", 40);
			Student a8 = new Student("Heitor", 75);
			Student a9 = new Student("Fred Jose", 50);
			Student a10 = new Student("Batata", 100);
			Student a11 = new Student("Mario", 80);
			Student a12 = new Student("Netball Jejbj I J", 80);
			Student a13 = new Student("Relógio", 96);
			Student a14 = new Student("Vazio", 0);
			Student a15 = new Student("Paçoca", 70);
			stack.Stacking(a1);
			stack.Stacking(a2);
			stack.Stacking(a3);
			stack.Stacking(a4);
			stack.Stacking(a5);
			stack.Stacking(a6);
			stack.Stacking(a7);
			stack.Stacking(a8);
			stack.Stacking(a9);
			stack.Stacking(a10);
			stack.Stacking(a11);
			stack.Stacking(a12);
			stack.Stacking(a13);
			stack.Stacking(a14);
			stack.Stacking(a15);
			Console.WriteLine("TESTING THE STACK OF STUDENTS: ");
			stack.PrintStackStudents();

			Console.WriteLine("TESTING THE LIST OF STUDENTS: ");
			list.InsertBeginning(a1);
			list.InsertBeginning(a2);
			list.InsertBeginning(a3);
			list.InsertBeginning(a4);
			list.InsertBeginning(a5);
			list.InsertBeginning(a6);
			list.InsertBeginning(a7);
			list.InsertBeginning(a8);
			list.InsertBeginning(a9);
			list.InsertBeginning(a10);
			list.InsertBeginning(a11);
			list.InsertBeginning(a12);
			list.InsertBeginning(a13);
			list.InsertBeginning(a14);
			list.InsertBeginning(a15);
			list.PrintListStudents();
			Console.WriteLine("PRINTING THE LIST OF STUDENTS:");
			list.PrintStudentsApproved();

			int a = 10;
			int b = 15;
			int c = 20;
			int d = 13;
			stack.Stacking(a);
			stack.Stacking(b);
			stack.Stacking(c);
			stack.Stacking(d);
			Console.WriteLine("TESTING THE STACK OF INTEGERS: ");
			stack.PrintStackInteger();
		}
    }
}
