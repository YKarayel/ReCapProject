using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandManager _brandManager;

        public BrandController(IBrandManager brandManager)
        {
            _brandManager = brandManager;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandManager.GetAll();
            if(result.Success)
                return Ok(result.Data);

            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result = _brandManager.Delete(id);
            if(result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Brand brand) 
        {
            var result = _brandManager.Add(brand);
            if(result.Success)
                return Ok(result);

            return BadRequest(result);
        }


        [HttpPut("update")]
        public IActionResult Update(Brand brand)
        {
            var result = _brandManager.Update(brand);
            if (result.Success)
                return Ok(result);

            return BadRequest(result); 
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _brandManager.GetById(id);
            if(result.Success)
                return Ok(result.Data);

            return BadRequest(result); 
        }

        [HttpGet("getcarsbybrandid")]
        public IActionResult GetCarByBrandId(int id) 
        {
            var result = _brandManager.GetCarsByBrandId(id);
            if(result.Success)
                return Ok(result.Data);

            return BadRequest(result.Message);
        }

    }
}
