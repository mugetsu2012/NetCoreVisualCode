using System.Collections.Generic;

namespace NetCoreVisualCode.Models {

    public interface IRepository
    {
        IEnumerable<GuestResponse> Responses {get;}

        void AddResponse(GuestResponse response);

    }
}