using System;
using Inspe.Common.Messages;
using Newtonsoft.Json;

namespace STM.Services.Federations.Messages.Commands
{
    public class CreateFederation: ICommand
    {
        public Guid Id { get; }
        public string Name { get; }

        [JsonConstructor]
        public CreateFederation(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}