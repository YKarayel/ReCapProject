using Business.Abstract;
using Business.Concreate;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImageController : ControllerBase
    {
        private readonly ICarImageManager _carImageManager;

        public CarImageController(ICarImageManager carImageManager)
        {
            _carImageManager = carImageManager;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageManager.GetAll();
            if (result.Success)
                return Ok(result.Data);

            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result = _carImageManager.Delete(id);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm]IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _carImageManager.Add(file, carImage);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }


        [HttpPut("update")]
        public IActionResult Update([FromForm] IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _carImageManager.Update(file, carImage);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carImageManager.GetById(id);
            if (result.Success)
                return Ok(result.Data);

            return BadRequest(result);
        }
    }
}
