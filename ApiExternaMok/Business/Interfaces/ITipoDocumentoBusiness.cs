using ApiExternaMok.Models;

namespace APINetMok.Business.Interfaces
{
    public interface ITipoDocumentoBusiness
    {
        Task<TipoIdentificacionModel> TipoDocumentoSync(string abreviatura);     
    }
}
