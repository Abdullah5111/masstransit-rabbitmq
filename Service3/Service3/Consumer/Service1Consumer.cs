using MassTransit;
using SharedContent.Message;

namespace Service3.Consumer
{
    public class Service1Consumer : IConsumer<Tokenn>
    {
        public async Task Consume(ConsumeContext<Tokenn> context)
        {
            try
            {
                var message = context.Message;
                Console.WriteLine(message.tokenn);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error consuming message: {ex.Message}");
                Task.FromException(ex);
            }
        }
    }
}
