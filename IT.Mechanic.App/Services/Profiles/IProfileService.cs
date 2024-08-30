using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.App.Services.Profiles
{
    public interface IProfileService
    {
        public IEnumerable<MainModel> Profiles { get; set; }
        public Task<MainModel?> GetProfileByIdAsync(string id);

        public Task SaveModelAsync(MainModel model);
    }
}
