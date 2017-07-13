using System;
using System.Threading.Tasks;
using MassTransit;
using Wms.Contracts;

namespace Consumer.Service
{
    public class LaConsumerService : IConsumer<ILaCnvQueueMessage>

    {
        public async Task Consume(ConsumeContext<ILaCnvQueueMessage> context)
        { 
            var command = context.Message;
            await Console.Out.WriteLineAsync(command.Barcode);
            //TODO : business
        }
    }
}