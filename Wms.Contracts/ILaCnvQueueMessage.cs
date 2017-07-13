using System;

namespace Wms.Contracts
{
    public interface ILaCnvQueueMessage
    {
        DateTime CreateDateTime { get; set; }
        string Barcode { get; set; }
        string Chute { get; set; } 
    }
}