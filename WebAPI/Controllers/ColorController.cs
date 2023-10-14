using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private readonly IColorManager _colorManager;

        public ColorController(IColorManager colorManager)
        {
            _colorManager = colorManager;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _colorManager.GetAll();
            if (result.Success)
                return Ok(result.Data);

            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result = _colorManager.Delete(id);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Color color)
        {
            var result = _colorManager.Add(color);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }


        [HttpPut("update")]
        public IActionResult Update(Color color)
        {
            var result = _colorManager.Update(color);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _colorManager.GetById(id);
            if (result.Success)
                return Ok(result.Data);

            return BadRequest(result);
        }
    }
}
