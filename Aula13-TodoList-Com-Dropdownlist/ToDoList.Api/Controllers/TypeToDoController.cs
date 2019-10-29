using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Domain;
using ToDoList.Repositories.Interface;


namespace ToDoList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeToDoController : ControllerBase
    {
        private ITypeToDoRepository repository;
        public TypeToDoController(ITypeToDoRepository repository)
        {
            this.repository = repository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<TypeToDo>> Get()
        {
            var types = repository.GetAll();
            return types;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<TypeToDo> Get(int id)
        {
            var obj = repository.GetById(id);
            return obj;
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] TypeToDo obj)
        {
            repository.Create(obj);
            return Ok(new {
                codigo= 200,
                mensagem = "Foi cadastrado com sucesso",
                data = obj
            
            });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put([FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
