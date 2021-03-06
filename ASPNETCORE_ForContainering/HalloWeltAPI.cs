using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCORE_ForContainering
{
    [Controller]
    [Route("api/")]
    public class HalloWeltAPI
    {
        [HttpGet("hallo/{name}")]

        public async Task<string> Hallo (string name )
        {
            return await Task.FromResult($"Hallo {name}!");
        }

        [HttpGet("unhoeflich/{name}")]

        public async Task<string> unhoeflich(string name)
        {
            return await Task.FromResult($"Hallo {name} du pisser!");
        }


    }
}
