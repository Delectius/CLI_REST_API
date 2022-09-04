using AutoMapper;
using CLI_REST_API.Dtos;
using CLI_REST_API.Models;

namespace CLI_REST_API.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // Source -> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}