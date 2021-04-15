using Oesia.App.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oesia.App.ViewModels.ViewModel
{
    public class GenderViewModel : ViewModelBase
    {
        #region Members Variables

        #endregion

        #region Constructor
        public GenderViewModel()
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
