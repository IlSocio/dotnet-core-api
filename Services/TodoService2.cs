using TodoApi.Models;

namespace TodoApi.Services
{
    public class TodoService2
    {
        TodoContext _ctx;

        public TodoService2(TodoContext context)
        {
            _ctx = context;
        }
    }
}
