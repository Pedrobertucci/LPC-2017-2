using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TodoList.WebApi.Models
{
    public class TodoRepository : ITodoRepository
    {

        private TodoContext context;
        public TodoRepository(TodoContext context)
        {           
            this.context = context;
        }
        public void Create(Todo todo)
        {
            context.Todo.Add(todo);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Todo.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Todo> GetAll()
        {
            return context.Todo.ToList();
        }

        public Todo GetById(int id)
        {
            return context.Todo.SingleOrDefault(x=>x.Id == id);
        }

        public void Update(Todo todo)
        {
            context.Entry(todo).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}