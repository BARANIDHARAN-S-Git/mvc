
namespace _11thOctober2022.Models
{
    public class OperationServices:ISingletonService,ITransientService,IScopedService
    {
        Guid id;

        public OperationServices()
        {
            id = Guid.NewGuid();
        }

        public Guid GetOperationID()
        {
            
            return id;
        }
    }
}
