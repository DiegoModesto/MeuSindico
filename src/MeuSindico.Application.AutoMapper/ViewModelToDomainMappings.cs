using AutoMapper;

namespace MeuSindico.Application.AutoMapper
{
    public class ViewModelToDomainMappings : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappings";
            }
        }

        protected override void Configure()
        {
            //On this section, use this model to Map the Domain into ViewModel
            //Mapper.CreateMap<DOMAIN-CLASS, VIEW-MODEL-CLASS>();
        }
    }
}
