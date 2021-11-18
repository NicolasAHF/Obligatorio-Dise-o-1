using BusinessLogic.Entities;
using DBStorage.Interfaces;
using DBStorage.DBAccess.EnititesDTO;
using DBStorage.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.DBAccess
{
    public class CategoryDBStorage : ICategoryStorage
    {
        private UserDBStorage userStorage;
        public void Clear()
        {
           using (BusinessLogicContext context = new BusinessLogicContext())
            {
                context.Categories.RemoveRange(context.Categories);

                context.SaveChanges();
            }
        }

        public bool Exists(Guid Id)
        {
            using(BusinessLogicContext context = new BusinessLogicContext())
            {
                return context.Categories.Any(c => c.Id == Id);
            }
        }

        public Category Get(Guid id)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                CategoryEntityDTO categoryRecord = context.Categories.Include("Owner").FirstOrDefault(c => c.Id == id);
                return ToBusinessLogicEntity(categoryRecord);
            }
        }

        public Category ToBusinessLogicEntity(CategoryEntityDTO categoryRecord)
        {
            userStorage = new UserDBStorage();
            User owner = userStorage.ToBusinessLogicEntity(categoryRecord.Owner);
            return new Category(categoryRecord.Name)
            {
                Id = categoryRecord.Id,
                Owner = owner
            };
        }

        public IEnumerable<Category> GetUserCategories(Guid userId)
        {
            using(BusinessLogicContext context = new BusinessLogicContext())
            {
                IEnumerable<CategoryEntityDTO> userCategoryRecords = context.Categories.Where(c => c.Owner.Id == userId).Include("Owner").ToList();

                List<Category> categoryRecords = new List<Category>();

                foreach(CategoryEntityDTO category in userCategoryRecords)
                {
                    categoryRecords.Add(ToBusinessLogicEntity(category));
                }

                return categoryRecords;
            }
        }

        public void Insert(Category entity)
        {
            using(BusinessLogicContext context = new BusinessLogicContext())
            {
               if(context.Categories.Any(c=> c.Name == entity.Name && c.Owner.Id == entity.Owner.Id))
                {
                    throw new CategoryDBStorageException("Category already exists in your list");
                }

                CategoryEntityDTO toAdd = ToEntityDTO(entity);
                context.Users.Attach(toAdd.Owner);
                context.Categories.Add(toAdd);

                context.SaveChanges();

            }
        }

        public CategoryEntityDTO ToEntityDTO(Category entity)
        {
            userStorage = new UserDBStorage();
            UserEntityDTO owner = userStorage.ToEntityDTO(entity.Owner);
            return new CategoryEntityDTO()
            {
                Id = entity.Id,
                Name = entity.Name,
                Owner = owner
            };
        }

        public bool IsEmpty()
        {
            using(BusinessLogicContext context = new BusinessLogicContext())
            {
                return !context.Categories.Any();
            }
        }

        public void Update(Category entity)
        {
            using (BusinessLogicContext context = new BusinessLogicContext())
            {
                CategoryEntityDTO category = context.Categories.FirstOrDefault(c => c.Id == entity.Id);
                if(category != null)
                {
                    category.Name = entity.Name;
                    context.SaveChanges();
                }

                
            }
        }    
    }
}
