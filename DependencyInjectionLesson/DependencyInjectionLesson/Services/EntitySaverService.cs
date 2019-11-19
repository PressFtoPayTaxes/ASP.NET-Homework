using DependencyInjectionLesson.DTOs;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace DependencyInjectionLesson.Services
{
    public class EntitySaverService : IEntitySaverService
    {
        public Task SaveEntity(EntityDTO entity) {
            var jsonResult = JsonConvert.SerializeObject(entity);
            return System.IO.File.WriteAllTextAsync("1.json", jsonResult);
        }
    }
}
