
using System;

namespace Course{
	class Program {
		static void Main(String[]args){
		

			List<Product> list = new List<Product>();
			list.add(new Product("TV", 900.00));
			//add + products

			//Expressao lambda como param de função -> Predicate

			list.RemoveAll(p => p.Price >= 100.00);

		
		}

	}



}
