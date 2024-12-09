using Career.Src.Models;
using Career.Src.Protos;
using Google.Protobuf.Collections;

namespace Career.Src.Services.Interfaces
{
    public interface ICareersService
    {
        public Task<RepeatedField<Protos.Career>> GetAll();

    }
}