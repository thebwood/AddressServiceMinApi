using AddressServiceMinApi.ClassLibrary.ViewModels;

namespace AddressServiceMinApi.ClassLibrary.DTOs
{
    public class GetAddressesResponseDTO
    {
        public GetAddressesResponseDTO()
        {
            AddressList = new List<AddressViewModel>();
        }

        public List<AddressViewModel> AddressList { get; set; }

    }
}
