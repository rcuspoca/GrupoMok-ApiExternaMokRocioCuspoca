using ApiExternaMok.Exceptions;
using ApiExternaMok.Models;
using APINetMok.Dominio.Contextos;
using APINetMok.Infraestructura.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APINetMok.Infraestructura
{
    public class TipoIdentificacionRepository : ITipoIdentificacionRepository
    {
        private readonly PersistenciaContext _dbContext;        

        public TipoIdentificacionRepository(PersistenciaContext dbContext )
        {
            _dbContext = dbContext;          
        }       

        public async Task<TipoIdentificacionModel> GetTipoIdentificacionByAbreviatura(string abreviatura)
        {
            try
            {
                TipoIdentificacionModel? dataTipoDocumento = 
                    await (from _tipo in _dbContext.TipoIdentificacionEntity  
                           where _tipo.Abreviatura == abreviatura
                           select new TipoIdentificacionModel()
                        {
                           IdTipoIdentificacion = _tipo.IdTipoIdentificacion,
                           Abreviatura = _tipo.Abreviatura,
                           Descripcion = _tipo.Descripcion,
                           Activo = _tipo.Activo
                        }).FirstOrDefaultAsync();

                if (dataTipoDocumento != null) return dataTipoDocumento;
                throw new BusinessException("No existe este tipo de documento");
            }
            catch (BusinessException ex)
            {
                throw new BusinessException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error interno de servidor", ex);
            }               
        }  
    }
}
