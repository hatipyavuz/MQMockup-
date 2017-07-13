using System;
using System.Threading.Tasks;
using MassTransit;
using Wms.Contracts;

namespace Consumer.Service
{
    public class CnvConsumerService : IConsumer<ICnvLaQueueMessage>
    {
        public async Task Consume(ConsumeContext<ICnvLaQueueMessage> context)
        {

            var command = context.Message;
            await Console.Out.WriteLineAsync(command.Barcode);
            //TODO : business
        }
    }
}