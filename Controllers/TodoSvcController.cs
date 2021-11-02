using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TodoApi.Models;
using TodoApi.Services;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class TodoSvcController : Controller
    {
        private readonly TodoService1 _svc1;
        private readonly TodoService2 _svc2;

        public TodoSvcController(TodoService1 svc1, TodoService2 svc2)
        {
            _svc1 = svc1;
            _svc2 = svc2;
        }

        // POST: api/Todo
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        {
            return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        }
    }
}
