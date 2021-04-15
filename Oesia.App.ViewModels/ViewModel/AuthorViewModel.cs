using Oesia.App.Models.DTOs;
using Oesia.App.Service.Interfaces;
using Oesia.App.Service.Services;
using Oesia.App.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Oesia.App.ViewModels.ViewModel
{
    public class AuthorViewModel : ViewModelBase
    {
        #region Members Variables
        private readonly IAuthorService _service;
        #endregion

        #region Constructor
        public AuthorViewModel()
        {
            _service = new AuthorService();
            CreateOrUpdateCommand = new Command(async () => await CreateOrUpdate(), () => !IsBusy);
        }
        
        #endregion	

        #region Private Methods
        private async Task CreateOrUpdate()
        {
            IsBusy = true;
            AuthorDTO = new AuthorDTO
            {
                Name = Name,
                LastName = LastName,
                Phone = Phone,
                Email = Email,
                IdGender = IdGender,
                NumberBooks = NumberBooks,
                IdCity = IdCity,
                IdState = IdState,
                IdCountry = IdCountry
            };
            try
            {
                if (AuthorDTO != null)
                {
                    var query = await _service.CreateAuthor(AuthorDTO, true);
                    if (query)
                    {
                        Msj = "Gaurdado con éxito";
                    }
                }
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
        private async Task Delete()
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

        private async Task GetById()
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
        private int id;

        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        private string name;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }
        private string lastName;

        public string LastName
        {
            get => lastName;
            set => SetProperty(ref lastName, value);
        }
        private string phone;

        public string Phone
        {
            get => phone;
            set => SetProperty(ref phone, value);
        }
        private string email;

        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }
        private int idGender;

        public int IdGender
        {
            get => idGender;
            set => SetProperty(ref idGender, value);
        }
        private int numberBooks;

        public int NumberBooks
        {
            get => numberBooks;
            set => SetProperty(ref numberBooks, value);
        }
        private int idCity;

        public int IdCity
        {
            get => idCity;
            set => SetProperty(ref idCity, value);
        }
        private int idState;

        public int IdState
        {
            get => idState;
            set => SetProperty(ref idState, value);
        }
        private int idCountry;

        public int IdCountry
        {
            get => idCountry;
            set => SetProperty(ref idCountry, value);
        }

        private AuthorDTO authorDTO;

        public AuthorDTO AuthorDTO
        {
            get => authorDTO;
            set => SetProperty(ref authorDTO, value);
        }

        private IEnumerable<AuthorDTO> authors;

        public IEnumerable<AuthorDTO> Authors
        {
            get => authors;
            set => SetProperty(ref authors, value);
        }


        #endregion

        #region Commands
        public ICommand CreateOrUpdateCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand GetAllCommand { get; }
        public ICommand GetByIdCommand { get; }
        #endregion
    }
}
