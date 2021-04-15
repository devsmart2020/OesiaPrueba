using Oesia.Front.Models.DTOs;
using Oesia.Front.Service.Interfaces;
using Oesia.Front.Service.Services;
using Oesia.Front.ViewModels.Base;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;


namespace Oesia.Front.ViewModels.ViewModel
{
    public class AuthorViewModel : ViewModelBase
    {
        #region Members Variables
        private readonly IAuthorService _service;
        private readonly IGenericService<CountryDTO> _countrySvc;
        private readonly IGenericService<GenderDTO> _genderSvc;
        private readonly IGenericService<StateDTO> _stateSvc;
        private readonly IGenericService<CityDTO> _citySvc;
        private readonly IGenericService<AuthorDTO> _authorSvc;
        private readonly IGenericService<AuthorListDTO> _authorlistSvc;
        #endregion

        #region Constructor
        public AuthorViewModel()
        {
            _service = new AuthorService();
            _countrySvc = new GenericService<CountryDTO>();
            _genderSvc = new GenericService<GenderDTO>();
            _stateSvc = new GenericService<StateDTO>();
            _citySvc = new GenericService<CityDTO>();
            _authorSvc = new GenericService<AuthorDTO>();
            _authorlistSvc = new GenericService<AuthorListDTO>();
            CreateOrUpdateCommand = new RelayCommand(async () => await CreateOrUpdate());
            UpdateCommand = new RelayCommand(async () => await Update());
            DeleteCommand = new RelayCommand(async () => await Delete());

            GetCountries().ConfigureAwait(true);
            GetGenders().ConfigureAwait(true);
            GetAll().ConfigureAwait(true);
            IsEnabledUpdate = false;
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
                    if (ValidateFields())
                    {
                        var query = await _authorSvc.Create(AuthorDTO, true, "api/Authors/Create");
                        if (query != null)
                        {
                            Msj = "Datos registrados con éxito";
                            await GetAll();
                            ClearFields();
                        }
                        else
                            Msj = "Error al guardar los datos, por favor verifique que esté todo diligenciado";

                    }

                }
            }
            catch (Exception ex)
            {
                Msj = ex.Message;
            }
            finally
            {
                IsBusy = false;
            }
        }
        private async Task Update()
        {
            IsBusy = true;
            AuthorDTO = new AuthorDTO
            {
                Id = Id,
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
                    if (ValidateFields())
                    {
                        var query = await _authorSvc.Create(AuthorDTO, false, "api/Authors/Update");
                        if (query != null)
                        {
                            Msj = "Datos actualizados con éxito";
                            IsEnabledUpdate = false;
                            IsEnabled = true;
                            await GetAll();
                            ClearFields();
                        }
                        else
                            Msj = "Error al actualizar los datos, por favor verifique que esté todo diligenciado";

                    }

                }
            }
            catch (Exception ex)
            {
                Msj = ex.Message;
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
                var query = await _authorSvc.Delete($"api/Authors/{Id}");
                if (query != null)
                {
                    Msj = "Datos eliminados con éxito";
                    IsEnabledUpdate = false;
                    IsEnabled = true;
                    await GetAll();
                    ClearFields();
                }
                else
                {
                    Msj = "Autor con libros asociados no se puede eliminar";
                    IsEnabled = true;
                    IsEnabledUpdate = false;
                    ClearFields();
                }



            }
            catch (Exception ex)
            {
                Msj = ex.Message;
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
                Authors = new ObservableCollection<AuthorListDTO>(await _authorlistSvc.GetAll("api/Authors"));
            }
            catch (Exception ex)
            {
                Msj = ex.Message;
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
                var author = await _authorSvc.GetById($"api/Authors/GetById/{Id}");
                if (author != null)
                {
                    Id = author.Id;
                    Name = author.Name;
                    LastName = author.LastName;
                    Phone = author.Phone;
                    Email = author.Email;
                    IdGender = author.IdGender;
                    NumberBooks = (int)author.NumberBooks;
                    IdCountry = (int)author.IdCountry;
                    IdCity = author.IdCity;
                    IdState = (int)author.IdState;

                    IsEnabled = false;
                    IsEnabledUpdate = true;

                }
                else
                {
                    IsEnabled = true;
                    IsEnabledUpdate = false;
                }
            }
            catch (Exception ex)
            {
                Msj = ex.Message;
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task GetCountries()
        {
            try
            {
                Countries = new ObservableCollection<CountryDTO>(await _countrySvc.GetAll("api/Countries"));
            }
            catch (Exception ex)
            {
                Msj = ex.Message;
            }
        }
        private async Task GetStates()
        {
            try
            {
                var listStates = new ObservableCollection<StateDTO>(await _stateSvc.GetAll("api/States"));
                if (listStates.Any())
                {
                    States = new ObservableCollection<StateDTO>(listStates.Where(x => x.IdCountry.Equals(IdCountry)).ToList());
                }

            }
            catch (Exception ex)
            {
                Msj = ex.Message;

            }
        }
        private async Task GetCities()
        {
            try
            {
                var listcities = new ObservableCollection<CityDTO>(await _citySvc.GetAll("api/Cities"));
                if (listcities.Any())
                {
                    Cities = new ObservableCollection<CityDTO>(listcities.Where(x => x.IdState.Equals(IdState)).ToList());
                }

            }
            catch (Exception ex)
            {
                Msj = ex.Message;
            }
        }
        private async Task GetGenders()
        {
            try
            {
                Genders = new ObservableCollection<GenderDTO>(await _genderSvc.GetAll("api/Genders"));
            }
            catch (Exception ex)
            {
                Msj = ex.Message;
            }
        }

        private async void ClearFields()
        {
            Name = string.Empty;
            LastName = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            NumberBooks = 0;
            await Task.Delay(3500);
            Msj = string.Empty;
        }
        private bool ValidateFields()
        {
            bool validate = true;

            if (string.IsNullOrEmpty(Name))
            {
                Msj = "Nombre requerido *";
                validate = false;
            }
            else if (string.IsNullOrEmpty(LastName))
            {
                Msj = "Nombre requerido *";
                validate = false;
            }
            else if (IdGender == default)
            {
                Msj = "Género requerido *";
                validate = false;
            }
            else if (IdCity == default)
            {
                Msj = "Ciudad requerido *";
                validate = false;
            }
            else
            {
                validate = true;
            }
            return validate;
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
            set
            {
                SetProperty(ref idState, value);
                if (Cities != null)
                {
                    Cities.Clear();
                }
                GetCities().ConfigureAwait(true);
            }

        }
        private int idCountry;

        public int IdCountry
        {
            get => idCountry;
            set
            {
                SetProperty(ref idCountry, value);
                if (States != null)
                {
                    States.Clear();
                }
                if (Cities != null)
                {
                    Cities.Clear();
                }
                GetStates().ConfigureAwait(true);
            }

        }

        private AuthorDTO authorDTO;

        public AuthorDTO AuthorDTO
        {
            get => authorDTO;
            set => SetProperty(ref authorDTO, value);
        }

        private ObservableCollection<AuthorListDTO> authors;

        public ObservableCollection<AuthorListDTO> Authors
        {
            get => authors;
            set => SetProperty(ref authors, value);
        }

        private ObservableCollection<GenderDTO> genders;

        public ObservableCollection<GenderDTO> Genders
        {
            get => genders;
            set => SetProperty(ref genders, value);
        }

        private ObservableCollection<CountryDTO> countries;

        public ObservableCollection<CountryDTO> Countries
        {
            get => countries;
            set => SetProperty(ref countries, value);
        }

        private ObservableCollection<StateDTO> states;

        public ObservableCollection<StateDTO> States
        {
            get => states;
            set => SetProperty(ref states, value);
        }

        private ObservableCollection<CityDTO> cities;

        public ObservableCollection<CityDTO> Cities
        {
            get => cities;
            set => SetProperty(ref cities, value);
        }

        private object selectedAuthor;

        public object SelectedAuthor
        {
            get => selectedAuthor;
            set
            {
                SetProperty(ref selectedAuthor, value);
                if (selectedAuthor != null)
                {
                    Id = Convert.ToInt32(selectedAuthor.GetType().GetProperty("Id").GetValue(selectedAuthor, null));
                    GetById().ConfigureAwait(true);
                }
            }

        }

        private bool isEnabledUpdate;

        public bool IsEnabledUpdate
        {
            get => isEnabledUpdate;
            set => SetProperty(ref isEnabledUpdate, value);
        }



        #endregion

        #region Commands
        public ICommand CreateOrUpdateCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand GetAllCommand { get; }
        public ICommand GetByIdCommand { get; }
        #endregion
    }
}
