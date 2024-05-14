using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Todo.Contracts;
using Todo.Models;
using Todo.Service.Exceptions;

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



        [HttpGet]
        public async Task<IActionResult> AllTodos()
        {
            try
            {
                var result = await _todoService.GetAllTodosAsync();

                _response.Result = result;
                _response.IsSuccess = true;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                _response.Message = "Request completed successfully";
            }
            catch (TodoNotFoundException ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                _response.Message = ex.Message;
            }
            catch (Exception ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                _response.Message = ex.Message;
            }

            return StatusCode(_response.StatusCode, _response);
        }

        [HttpGet("{userId}")]
        [Authorize]
        public async Task<IActionResult> GetUserTodosAsync(string userId)
        {
            try
            {
                var result = await _todoService.GetUserTodosAsync(userId);

                _response.Result = result;
                _response.IsSuccess = true;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                _response.Message = "Request completed successfully";
            }
            catch (TodoNotFoundException ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                _response.Message = ex.Message;
            }
            catch (Exception ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                _response.Message = ex.Message;
            }
            return StatusCode(_response.StatusCode, _response);
        }

        [HttpGet("{userId}/{id}")]
        [Authorize]
        public async Task<IActionResult> GetSingleTodoAsync(string userId, int id)
        {
            try
            {
                var result = await _todoService.GetSingleTodoAsync(userId, id);

                _response.Result = result;
                _response.IsSuccess = true;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                _response.Message = "Request completed successfully";
            }
            catch (TodoNotFoundException ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                _response.Message = ex.Message;
            }
            catch (Exception ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                _response.Message = ex.Message;
            }
            return StatusCode(_response.StatusCode, _response);
        }

        [HttpPost("{userId}/{model}")]
        [Authorize]
        public async Task<IActionResult> AddTodoAsync(TodoForCreatingDto model, string userId)
        {
            try
            {
               await _todoService.AddTodoAsync(model, userId);

                _response.Result = model;
                _response.IsSuccess = true;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                _response.Message = "Request completed successfully";
            }
            catch (TodoNotFoundException ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                _response.Message = ex.Message;
            }
            catch (Exception ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                _response.Message = ex.Message;
            }
            return StatusCode(_response.StatusCode, _response);
        }

    }
}
