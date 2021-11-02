using TodoApi.Models;

namespace TodoApi.Services
{
    public class TodoService1
    {
        TodoContext _ctx;

        public TodoService1(TodoContext context)
        {
            _ctx = context;
        }
    }
}
