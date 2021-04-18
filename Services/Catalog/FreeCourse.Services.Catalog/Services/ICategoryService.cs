﻿using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Services.Catalog.Model;
using FreeCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Services
{
    interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetResponseAsync();
        Task<Response<CategoryDto>> CreataAsync(Category category);
        Task<Response<CategoryDto>> GetById(string id);
    }
}