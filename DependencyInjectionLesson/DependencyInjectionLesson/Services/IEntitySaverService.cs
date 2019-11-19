using DependencyInjectionLesson.DTOs;
using System.Threading.Tasks;

namespace DependencyInjectionLesson.Services
{
    public interface IEntitySaverService
    {
        Task SaveEntity(EntityDTO entity);
    }
}
