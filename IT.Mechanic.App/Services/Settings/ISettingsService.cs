using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.App.Services.Settings
{
    public interface ISettingsService
    {
        public MechanicSettings Settings { get; set; }
        public void InitializeSync();
        public void SaveSettingsSync();
    }
}
