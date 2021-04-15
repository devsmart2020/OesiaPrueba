using Oesia.Front.ViewModels.Base;
using System;
using System.Threading.Tasks;

namespace Oesia.Front.ViewModels.ViewModel
{
    public class StateViewModel : ViewModelBase
    {
        #region Members Variables

        #endregion

        #region Constructor
        public StateViewModel()
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
