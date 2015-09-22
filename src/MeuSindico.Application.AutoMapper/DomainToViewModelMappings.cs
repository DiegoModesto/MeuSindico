using AutoMapper;

namespace MeuSindico.Application.AutoMapper
{
    public class DomainToViewModelMappings : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }

        protected override void Configure()
        {
            //On this section, use this model to Map the Domain into ViewModel
            //Mapper.CreateMap<DOMAIN-CLASS, VIEW-MODEL-CLASS>();
        }
    }
}
