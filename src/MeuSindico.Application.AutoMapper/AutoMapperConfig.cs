using AutoMapper;

namespace MeuSindico.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappings>();
                x.AddProfile<ViewModelToDomainMappings>();
            });
        }
    }
}
