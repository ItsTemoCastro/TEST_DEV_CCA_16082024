using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TEST_DEV_CCA_14082024.Dtos;

namespace TEST_DEV_CCA_14082024.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonaFisicaController : Controller
    {
        [HttpGet]
        public async Task<PersonaFisicaDto> GetAllPersonasFisica()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<PersonaFisicaDto>GetPersonaFisica(int IdPersonaFisica)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeletePersonaFisica(int IdPersonaFisica)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<PersonaFisicaDto> AddPersonaFisica(AddPersonaFisicaDto personaFisica)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<bool> UpdatePersonaFisica(PersonaFisicaDto personaFisica)
        {
            throw new NotImplementedException();
        }
    }
}
