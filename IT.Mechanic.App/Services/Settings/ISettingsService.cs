using IT.Mechanic.Models.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IT.Mechanic.App.Services.Settings
{
    public interface ISettingsService
    {
        public MechanicSettings Settings {get; set;}
        public void InitializeSync();
    }
}
