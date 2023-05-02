using Enfer.API.Data;
using Enfer.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Enfer.API.Controllers
{

    [ApiController]
    [Route("/api/categories")]


    public class CategoriesController : ControllerBase
    {

        private readonly DataContext _context;

        public CategoriesController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Category category)
        {
            _context.Add(category);

            try
            {
                await _context.SaveChangesAsync();
                return Ok(category);

            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe una categoria con el mismo nombre.");
                }
                else
                {
                    return BadRequest(dbUpdateException.InnerException.Message);
                }
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Categories.ToListAsync());
        }



        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (category is null)
            {
                return NotFound();
            }

            return Ok(category);
        }


        [HttpPut]
        public async Task<ActionResult> Put(Category category)
        {
            _context.Update(category);

            try
            {
                await _context.SaveChangesAsync();
                return Ok(category);

            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe un registro con el mismo nombre.");
                }
                else
                {
                    return BadRequest(dbUpdateException.InnerException.Message);
                }
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }

        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var afectedRows = await _context.Categories
                .Where(y => y.Id == id)

                .ExecuteDeleteAsync();

            if (afectedRows == 0)
            {
                return NotFound();
            }

            return NoContent();
        }


    }


}

