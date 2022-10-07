using System;

namespace Solution2 {
	internal class Product {
		private int code;
		private int quantity;
		private double price;
		private double discount;
		private int countProducts;

		public Product() {
			this.code = 0;
			this.quantity = 0;
			this.price = 0.0;
			this.countProducts = 0;
		}

		public Product(int code, int quantity, double price) {
			setCode(code);
			if (!setQuantity(quantity)) {
				Console.WriteLine("ERROR: Invalid quantity.");
			}
			if (!setPrice(price)) {
				Console.WriteLine("ERROR: Invalid price!");			}
			countProducts++;
		}

		public int getCode() {
			return code;
		}

		public void setCode(int code) {
			this.code = code++;
		}

		public int getQuantity() {
			return quantity;
		}

		public Boolean setQuantity(int quantity) {
			if (quantity < 0) return false;
			this.quantity = quantity;
			return true;
		}

		public double getPrice() {
			return price;
		}

		public Boolean setPrice(double price) {
			if (price <= 0) return false;
			this.price = price;
			return true;
		}

		public int getCountProducts() {
			return countProducts;
		}

		public void setCountProducts(int countProducts) {
			this.countProducts = countProducts++;
		}

		public Boolean getDiscount(double price, double discount) {
			if (discount <= 0 || discount > 100) return false;
			Console.WriteLine("Price before discount: " + this.price);
			this.discount = this.price * (discount / 100);
			this.price = this.price - this.discount;
			Console.WriteLine("Price after discount: " + this.price);
			return true;
		}
	}
}