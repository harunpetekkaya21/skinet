using Microsoft.AspNetCore.Mvc;
using Infrastructure.Data;
using API.Errors;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly StoreContext _context;
        public BuggyController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet("notFound")]

        public ActionResult GetNotFoundRequest()
        {
            var thing = _context.Products.Find(42);
            if (thing == null)
            {
                return NotFound(new ApiResponse(404));
            }
            return Ok();
        }



        [HttpGet("serverError")]

        public ActionResult GetServerError()
        {

            var thing = _context.Products.Find(42);

            var thingToReturn = thing.ToString();
            return Ok();
        }


        [HttpGet("badRequest")]

        public ActionResult GetBadRequest()
        {
            return BadRequest(new ApiResponse(400));
        }

        [HttpGet("badRequest/{id}")]

        public ActionResult GetBadRequest(int id)
        {
            return BadRequest();
        }

    }
}