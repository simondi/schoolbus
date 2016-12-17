﻿/*
 * REST API Documentation for Schoolbus
 *
 * This project is to replace the existing permitting and inspection scheduling functionality in AVIS  such that the mainframe application can be retired. 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolBusAPI.Models;
using SchoolBusAPI.Services;
using Newtonsoft.Json;

namespace SchoolBusAPI.Services.Impl
{
    /// <summary>
    /// 
    /// </summary>
    public class RegionApiService : IRegionApiService
    {
        private readonly DbAppContext _context;

        /// <summary>
        /// Create a service and set the database context
        /// </summary>
        public RegionApiService(DbAppContext context)
        {
            _context = context;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual IActionResult RegionsIdSchooldistrictsGetAsync(int id)
        {
            string exampleJson = null;

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SchoolBus>(exampleJson)
            : default(SchoolBus);
            return new ObjectResult(example);
        }
        
    }
}

