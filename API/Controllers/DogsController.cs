using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Queries.Dogs;
using Application.Queries.Dogs.GetDogById;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        internal readonly IMediator _mediatR;

        public DogsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }


        //Detta är API endpoint där vi hämtar alla hundar från MockDatabase
        // url är api/v1/Dogs/getAllDogs
        // GET: api/<DogsController>
        [HttpGet]
        [Route("getAllDogs")]
        public async Task<IActionResult> GetAllDogs()
        {
            return Ok(await _mediatR.Send(new GetAllDogsQuery()));
        }


        [HttpGet]
        [Route("GetDogById/{dogId}")]
        public async Task<IActionResult> GetDogById(Guid dogId)
        {
            return Ok(await _mediatR.Send(new GetDogByIdQuery(dogId)));
        }





        //        // GET api/<DogsController>/5
        //        [HttpGet("{id}")]
        //        public string Get(int id)
        //        {
        //            return "value";
        //        }

        //        // POST api/<DogsController>
        //        [HttpPost]
        //        public void Post([FromBody] string value)
        //        {
        //        }

        //        // PUT api/<DogsController>/5
        //        [HttpPut("{id}")]
        //        public void Put(int id, [FromBody] string value)
        //        {
        //        }

        //        // DELETE api/<DogsController>/5
        //        [HttpDelete("{id}")]
        //        public void Delete(int id)
        //        {
        //        }
        //    }
    }
}
