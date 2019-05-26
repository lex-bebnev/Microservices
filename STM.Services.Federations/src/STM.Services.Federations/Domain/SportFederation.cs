using System;
using Inspe.Common.Types;
using STM.Services.Federations.Exceptions;

namespace STM.Services.Federations.Domain
{
    public class SportFederation: IIdentifiable
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        private SportFederation()
        {
        }

        public SportFederation(Guid id, string name)
        {
            if (id == Guid.Empty)
            {
                throw new InspeException(ExceptionCodes.INVALID_FEDERATION_ID, ExceptionMessages.INVALID_FEDERATION_ID);
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new InspeException(ExceptionCodes.INVALID_FEDERATION_NAME, ExceptionMessages.INVALID_FEDERATION_NAME);
            }
            
            Id = id;
            Name = name;
        }
    }
}