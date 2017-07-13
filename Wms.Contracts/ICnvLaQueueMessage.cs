using System;

namespace Wms.Contracts
{
    public interface ICnvLaQueueMessage
    {
        DateTime CreateDateTime { get; set; }
        string Barcode { get; set; }
        string Chute { get; set; }
        string ErrorCode { get; set; }
        string Error { get; set; }
    }
}