using ApiTesteCandidato.Models;
using Domain.Interfaces;
using EntitiesTesteCandidato;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiTesteCandidato.Controllers
{
    public class MotoristaController : Controller
    {
        private readonly IMotorista _ICep;

        public MotoristaController(IMotorista ICep)
        {
            _ICep = ICep;
        }

        [HttpPost("/api/Cadastrar")]
        public async Task<IActionResult> Cadastrar([FromBody] Motorista cep)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {                
                await _ICep.Add(cep);

                return Ok(new ApiResposta<DateTime>(DateTime.Now, true, 200, "Ok"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResposta<DateTime>(DateTime.Now, false, 400, "Ocorreu um erro"));
            }
        }
        [HttpGet("/api/BuscarLista")]
        public async Task<IActionResult> BuscarLista()
        {     
            try
            {
                return Ok(await _ICep.List());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResposta<DateTime>(DateTime.Now, false, 400, "Ocorreu um erro"));
            }
        }
        [HttpGet("/api/BuscarMotorista")]
        public async Task<IActionResult> BuscarMotorista(int id)
        {
            try
            {
                return Ok(await _ICep.GetEntityById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResposta<DateTime>(DateTime.Now, false, 400, "Ocorreu um erro"));
            }
        }
        [HttpPost("/api/Atualizar")]
        public async Task<IActionResult> Atualizar([FromBody] Motorista motorista)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                await _ICep.Update(motorista);

                return Ok(new ApiResposta<DateTime>(DateTime.Now, true, 200, "Ok"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResposta<DateTime>(DateTime.Now, false, 400, "Ocorreu um erro"));
            }
        }
        [HttpDelete("/api/Delete")]
        public async Task<IActionResult> Delete([FromBody] Motorista motorista)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                await _ICep.Delete(motorista);

                return Ok(new ApiResposta<DateTime>(DateTime.Now, true, 200, "Ok"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResposta<DateTime>(DateTime.Now, false, 400, "Ocorreu um erro"));
            }
        }
    }
}
