using Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI
{
    public class PropertyController
    {
        private readonly PropertyService _propertyService;

        public PropertyController(PropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePropertyDto dto)
        {
            var id = await _propertyService.CreatePropertyAsync(dto);
            return Ok(new { Id = id });
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var properties = await _propertyService.GetAllAsync();
            return Ok(properties);
        }
    }
}
