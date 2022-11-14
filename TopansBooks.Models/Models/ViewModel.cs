using System;

namespace TopansBookStore.Models.ViewModels
{
    public class ViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
