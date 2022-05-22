using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext context;

        public ProductsController(StoreContext context)
        {
            this.context = context;
        }

        //create an endpoint with []
        
        // this http get request will query our database for a list of the products currently being stored
                        // this is currently being done in a synchronous fashioin with no concurrency (where one thread might block another)
                        
                                // [HttpGet("{id}")]
                            
                                // public ActionResult<Product> GetProduct(int id){
                                //     return context.Products.Find(id); 
                                // }
        [HttpGet]
        // the code has now been modified to handle asynchronous requests such that when one thread comes in and is blocked, other items/threads can still make progress while the original one is blocked
        public async Task <ActionResult<List<Product>>> GetProducts(){
            return await context.Products.ToListAsync(); 
        }
        [HttpGet("{id}")]
        // this http get request will query our database for the id being passed in and find the product with the given id
        public async Task<ActionResult<Product>> GetProduct(int id){
            return await context.Products.FindAsync(id); 
        }
        
    }
}