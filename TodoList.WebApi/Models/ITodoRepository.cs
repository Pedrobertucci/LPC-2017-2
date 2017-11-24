using System.Collections.Generic;

namespace TodoList.WebApi.Models
{
    public interface ITodoRepository
    {
         void Create(Todo person);
         void Update(Todo person);
         void Delete(int id);
         List<Todo>GetAll();
         Todo GetById(int id);
    }
}