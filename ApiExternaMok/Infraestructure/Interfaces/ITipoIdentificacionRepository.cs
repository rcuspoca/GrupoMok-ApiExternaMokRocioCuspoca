using ApiExternaMok.Models;

namespace APINetMok.Infraestructura.Interfaces
{
    public interface ITipoIdentificacionRepository
    {
        Task<TipoIdentificacionModel> GetTipoIdentificacionByAbreviatura(string abreviatura);        
    }
}
