using MessageContracts.Commands;

namespace WebApi.Models
{
    public class SubmitOrder : ISubmitOrderCommand
    {
        public int OrderId { get; set; }

        public string OrderCode { get; set; }
    }
}
