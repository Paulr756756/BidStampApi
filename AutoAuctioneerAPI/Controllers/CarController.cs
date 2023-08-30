﻿using API_AutoAuctioneer.Models.CarRequestModels;
using API_AutoAuctioneer.Services.CarService;
using DataAccessLayer_AutoAuctioneer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_AutoAuctioneer.Controllers;

[ApiController, Route("api/[controller]")]
public class CarController : ControllerBase
{
    private readonly ICarService _carService;

    public CarController(ICarService carService)
    {
        _carService = carService;
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAllCars()
    {
        var response = await _carService.GetAllCars();
        return Ok(response);
    }

    [HttpGet("getowned"), Authorize(Roles = "Client")]
    public async Task<IActionResult> GetOwnedCars([FromQuery] Guid id)
    {
        var response = await _carService.GetOwnedCars(id);
        return Ok(response);
    }

    [HttpGet("getbyid")]
    public async Task<IActionResult> GetCarById( Guid guid)
    {
        var response = await _carService.GetCarById(guid);
        return Ok(response);
    }

    [HttpPost("post"), Authorize(Roles = "Client")]
    public async Task<IActionResult> PostCar([FromBody] AddCarRequest request)
    {
        var response = await _carService.StoreCar(request);
        if (response)
        {
            return Ok(response);
        }

        return BadRequest(response);
    }

    [HttpPut("update"), Authorize(Roles = "Client")]
    public async Task<IActionResult> UpdateCar([FromBody] UpdateCarRequest request)
    {
        var response = await _carService.UpdateCar(request);
        if (response)
        {
            return Ok(response);
        }

        return BadRequest(response);
    }

    [HttpDelete("delete"), Authorize(Roles = "Client")]
    public async Task<IActionResult> DeleteCar([FromBody] DeleteCarRequest request) {
        var response = await _carService.DeleteCar(request);
        if (response) {
            return Ok(response);
        }
        return BadRequest(response);
    }
}