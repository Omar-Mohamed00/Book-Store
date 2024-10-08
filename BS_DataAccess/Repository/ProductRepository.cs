﻿namespace BS_DataAccess.Repository
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		private readonly ApplicationDbContext _db;
		public ProductRepository(ApplicationDbContext db) :base(db)
		{
			_db = db;
		}

		public void Update(Product obj)
		{
			//_db.products.Update(obj);
			var objFromDb = _db.products.FirstOrDefault(u=>u.Id == obj.Id);

			objFromDb.Title = obj.Title;
			objFromDb.ISBN = obj.ISBN;
			objFromDb.Price = obj.Price;
			objFromDb.Price50 = obj.Price50;
			objFromDb.ListPrice = obj.ListPrice;
			objFromDb.Price100= obj.Price100;
			objFromDb.Description = obj.Description;
			objFromDb.CategoryId = obj.CategoryId;
			objFromDb.Author = obj.Author;

			if (obj != null)
			{
				objFromDb.ImageUrl = obj.ImageUrl;
			}
		}
	}
}
