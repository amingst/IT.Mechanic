using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Mechanic.Installer.Models
{
    public static class AppTheme
    {
        public enum AppThemeEnum
        {
               Default=0,
               Light=1,
               Dark=2,
        }

        public static IEnumerable<string> GetThemeNames()
        {
            return Enum.GetNames(typeof(AppThemeEnum));
        }

        public static AppThemeEnum GetThemeFromName(string name)
        {
            switch (name)
            {
                case "Default":
                    return AppThemeEnum.Default;
                case "Light":
                    return AppThemeEnum.Light;
                case "Dark":
                    return AppThemeEnum.Dark;
                default:
                    return AppThemeEnum.Default;
            }   
        }
    }
}
