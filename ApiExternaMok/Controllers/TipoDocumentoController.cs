using ApiExternaMok.Exceptions;
using ApiExternaMok.Models;
using APINetMok.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APINetMok.Controllers
{
    [Route("[controller]")]
    [ApiController]


    public class TipoDocumentoController : ControllerBase
    {
        private readonly ITipoDocumentoBusiness _tipoDocumentoBusiness;

        public TipoDocumentoController(ITipoDocumentoBusiness tipoDocumentoBusiness)
        {
            _tipoDocumentoBusiness = tipoDocumentoBusiness;
        }
        /// <summary>
        /// Obtiene el registro del tipo de identificación por Abreviatura
        /// </summary>
        /// <returns>Listado de empleados</returns>
        /// <response code="200">Operación finalizada exitosamente.</response>
        /// <response code="400">Se presentó un error de validación de datos.</response>
        /// <response code="500">Se presentó un error interno al consultar tipo identificación por abreviatura.</response>

        [HttpGet("{abreviatura}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<TipoIdentificacionModel>> GetTipoDocumentoByAbreviatura(string abreviatura)
        {
            try
            {
                return Ok(await _tipoDocumentoBusiness.TipoDocumentoSync(abreviatura));
            }
            catch (ValidationsException be)
            {
                return StatusCode(StatusCodes.Status400BadRequest, be.Message);
            }
            catch (BusinessException exception)
            {
                return StatusCode(StatusCodes.Status400BadRequest, exception.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, string.IsNullOrEmpty(ex.Message) ? "Error interno del servidor" : ex.Message);
            }
        }
    }
}
