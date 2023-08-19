using ApiExternaMok.Models;
using APINetMok.Business.Interfaces;
using APINetMok.Infraestructura.Interfaces;

namespace APINetMok.Business
{
    public class TipoDocumentoBusiness : ITipoDocumentoBusiness
    {
        private readonly ITipoIdentificacionRepository _tipoIdentificacionRepository;

        public TipoDocumentoBusiness(ITipoIdentificacionRepository tipoIdentificacionRepository)
        {
            _tipoIdentificacionRepository = tipoIdentificacionRepository;
        }

        public async Task<TipoIdentificacionModel> TipoDocumentoSync(string abreviatura) 
            => await _tipoIdentificacionRepository.GetTipoIdentificacionByAbreviatura(abreviatura);       
    }
}
