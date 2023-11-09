using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace McDonalds_API.Controllers;

[ApiController]
[Route("order")]
public class OrderController : ControllerBase
{
    [HttpPost("create")]
    public async Task<ActionResult> CreaterOrder(int storeId,
        [FromServices]IOrderRepository repo)
    {
        try
        {
            var orderId = await repo.CreateOrder(storeId);
            return Ok(orderId);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // [HttpGet("GetOrder")]
    // public async Task<ActionResult> GetOrder()
    // {
        
    // }
}