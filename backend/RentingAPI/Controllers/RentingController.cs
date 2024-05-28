﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentingAPI.Extensions;
using RentingAPI.Models;
using RentingAPI.Models.InventoryAPI;
using RentingAPI.Services;
using RentingAPI.Services.Data;

namespace RentingAPI.Controllers
{
    [Route("api/renting"), ApiController]
    public class RentingController : ControllerBase
    {

        //[Route("api/resources"), ApiController]//I think this class def should not be here
        //public class ResourcesController : ControllerBase
        //{
        //    [HttpGet("list")]
        //    public ActionResult List([FromServices] RentingDbContext rentingDbContext)
        //    {
        //        var rents = rentingDbContext.Rents.AsNoTracking();
        //        return Ok(new { items = rents.Select(r => r.ToRentResponse()).ToArray(), count = rents.Count() });
        //    }

        //    [HttpGet("list/{clientId}")]
        //    public async Task<ActionResult<RentResponse[]>> ListByClientId([FromRoute] Guid clientId, [FromServices] RentingDbContext rentingDbContext, [FromServices] ResourcesAPIClient resourcesAPIClient, [FromQuery] bool returned = false)
        //    {
        //        var rents = rentingDbContext.Rents.Where(r => r.ClientId == clientId && r.Returned == returned).AsNoTracking();
        //        var response = new List<RentResponse>();
        //        foreach (var r in rents)
        //        {
        //            var rr = r.ToRentResponse();
        //            var resourceResponse = await resourcesAPIClient.GetResourceByIdAsync(r.ResourceId);
        //            rr.ResourceName = resourceResponse?.Name;

        //        }
        //        return Ok(new { items = response.ToArray(), count = response.Count() });
        //    }

        //    [HttpPost("register")]
        //    public async Task<ActionResult> Register([FromBody] RegisterRentRequest registerRentRequest, [FromServices] InventoryAPIClient inventoryAPIClient, [FromServices] RentingDbContext rentingDbContext)
        //    {
        //        var items = await inventoryAPIClient.ListResourceAvailabilityAsync(registerRentRequest.ResourceId);
        //        if (items.Length <= 0) return Ok(new { Message = "The resource is not available." });
        //        var rent = new Models.Data.Rent
        //        {
        //            CopyId = items[0].Id,
        //            ResourceId = registerRentRequest.ResourceId,
        //            ClientId = registerRentRequest.ClientId,
        //            RegistrationDate = registerRentRequest.RegistrationDate,
        //            ReturnDate = registerRentRequest.ReturnDate
        //        };
        //        rentingDbContext.Add(rent);
        //        await rentingDbContext.SaveChangesAsync();
        //        var updateItemRequest = new UpdateItemRequest
        //        {
        //            ItemId = rent.CopyId,
        //            Available = false
        //        };
        //        await inventoryAPIClient.UpdateItemAvailabilityAsync(updateItemRequest);
        //        return Ok(rent.ToRentResponse());
        //    }

        //    [HttpPut("return")]
        //    public async Task<ActionResult> Return([FromBody] ReturnRent returnRent, RentingDbContext rentingDbContext, [FromServices] InventoryAPIClient inventoryAPIClient)
        //    {

        //        var rent = await rentingDbContext.Rents.FindAsync(returnRent.Id);
        //        if (rent == null) return NotFound();
        //        rent.ReturnDate = returnRent.ReturnDate;
        //        rent.Returned = true;
        //        await rentingDbContext.SaveChangesAsync();

        //        // Set copy availability to true in the inventory
        //        var updateItemRequest = new UpdateItemRequest
        //        {
        //            ItemId = rent.CopyId,
        //            Available = true
        //        };
        //        await inventoryAPIClient.UpdateItemAvailabilityAsync(updateItemRequest);

        //        return Ok(new { message = $"The copy with ID {rent.CopyId} has been returned." });
        //    }
        //}
    }
}
