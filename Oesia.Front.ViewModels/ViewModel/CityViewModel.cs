using Oesia.Front.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oesia.Front.ViewModels.ViewModel
{
    public class CityViewModel : ViewModelBase
    {
        #region Members Variables

        #endregion

        #region Constructor
        public CityViewModel()
        {

        }
        #endregion

        #region Private Methods
        private async Task GetAll()
        {

            IsBusy = true;
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }
        #endregion

        #region Properties

        #endregion

        #region Commands

        #endregion
    }
}
