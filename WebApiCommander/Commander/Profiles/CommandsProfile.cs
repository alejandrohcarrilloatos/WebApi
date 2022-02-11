using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // Source to DTO
            CreateMap<Command, CommandReadDto>();

            // DTO to Source
            CreateMap<CommandCreateDto, Command>();
        }
    }
}
