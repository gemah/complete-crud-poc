using Microsoft.AspNetCore.Mvc;
using PatchPoC.Models;
using System.Collections.Generic;

namespace PatchPoC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "OK" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public SampleEntity Get(int id)
        {
            if (!MemoryRepository.repository.ContainsKey(id))
            {
                return null;
            }
            else
            {
                return MemoryRepository.repository[id] ?? null;
            }
        }

        // POST api/<controller>
        [HttpPost]
        public SampleEntity Post([FromBody]SampleEntity value)
        {
            MemoryRepository.repository.Add(value.Id, value);
            return MemoryRepository.repository[value.Id];
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public SampleEntity Put(int id, [FromBody]SampleEntity value)
        {
            MemoryRepository.repository[id].Nome = value.Nome;
            MemoryRepository.repository[id].Endereco = value.Endereco;
            return MemoryRepository.repository[id];
        }

        // PUT api/<controller>/5
        [HttpPatch("{id}")]
        public SampleEntity Patch(int id, [FromBody]SampleEntity value)
        {
            MemoryRepository.repository[id].Nome = value.Nome ?? MemoryRepository.repository[id].Nome;
            MemoryRepository.repository[id].Endereco = value.Endereco ?? MemoryRepository.repository[id].Endereco;
            return MemoryRepository.repository[id];
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            if (MemoryRepository.repository.Count > 0 || MemoryRepository.repository.ContainsKey(id))
            {
                MemoryRepository.repository.Remove(id);
                return "Entity " + id + " was deleted.";
            }
            return "Entity not found.";
        }
    }
}
