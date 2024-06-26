﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Todo.Contracts;
using Todo.Models;

namespace Todo.API.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoService _todoService;
        private ApiRespones _response;
        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
            _response = new ApiRespones();
        }



        [HttpGet("{userId}")]
        public async Task<IActionResult> AllTodosOfUser([FromRoute] string userId)
        {
            var result = await _todoService.GetTodosOfUserAsync(userId);

            _response.Result = result;
            _response.IsSuccess = true;
            _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
            _response.Message = "Request completed successfully";

            return StatusCode(_response.StatusCode, _response);
        }

        [HttpGet("{userId}/ {todoId}")]
        [Authorize]
        public async Task<IActionResult> SingleTodoOfUser([FromRoute] string userId, [FromRoute] int todoId)
        {
            var result = await _todoService.GetSingleTodoByUserId(todoId, userId);

            _response.Result = result;
            _response.IsSuccess = true;
            _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
            _response.Message = "Request completed successfully";

            return StatusCode(_response.StatusCode, _response);
        }

        [HttpPost]
        public async Task<IActionResult> AddTodo([FromBody] TodoForCreatingDto model)
        {
            await _todoService.AddTodoAsync(model);

            _response.Result = model;
            _response.IsSuccess = true;
            _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
            _response.Message = "Request completed successfully";

            return StatusCode(_response.StatusCode, _response);
        }

        [HttpDelete("{todoId    }")]
        public async Task<IActionResult> DeleteTodo([FromRoute] int todoId)
        {
            await _todoService.DeleTeTodoAsync(todoId);

            _response.Result = todoId;
            _response.IsSuccess = true;
            _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
            _response.Message = "Request completed successfully";

            return StatusCode(_response.StatusCode, _response);
        }

    }
}
