using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace NBASystem.Model
{
    public partial class Team
    {
        public BitmapImage MainImage 
        {
            get 
            {

                return new BitmapImage(new Uri($"pack://application:,,,/Resources/Teams/{Logo}", UriKind.Absolute));
            }

        }
    }
}
