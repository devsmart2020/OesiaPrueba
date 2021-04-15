using Oesia.Front.Models.DTOs;
using Oesia.Front.Service.Interfaces;
using Oesia.Front.Service.Services;
using Oesia.Front.ViewModels.Base;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Oesia.Front.ViewModels.ViewModel
{
    public class BookViewModel : ViewModelBase
    {
        #region Members Variables
        private readonly IGenericService<AuthorListDTO> _authorSvc;
        private readonly IGenericService<EditorialDTO> _editorialSvc;
        private readonly IGenericService<BookDTO> _bookSvc;
        private readonly IGenericService<BookListDTO> _booklistSvc;

        #endregion

        #region Constructor
        public BookViewModel()
        {
            _authorSvc = new GenericService<AuthorListDTO>();
            _editorialSvc = new GenericService<EditorialDTO>();
            _bookSvc = new GenericService<BookDTO>();
            _booklistSvc = new GenericService<BookListDTO>();
            CreateOrUpdateCommand = new RelayCommand(async () => await CreateOrUpdate());
            GetEditorials().ConfigureAwait(true);
            GetAuthors().ConfigureAwait(true);
            GetAll().ConfigureAwait(true);
            WriteDate = DateTime.Today;
            LaunchDate = DateTime.Today;
        }
        #endregion

        #region Private Methods
        private async Task CreateOrUpdate()
        {
            IsBusy = true;
            BookDTO book = new BookDTO
            {
                Name = NameBook,
                WriteDate = WriteDate,
                LaunchDate = LaunchDate,
                Price = Price,
                IdAuthor = IdAuthor,
                IdEditorial = IdEditorial,
                Remarks = Remarks
            };
            try
            {
                if (book != null)
                {
                    if (ValidateFields())
                    {
                        var query = await _bookSvc.Create(book, true, "api/Books/Create");
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
                BookList = new ObservableCollection<BookListDTO>(await _booklistSvc.GetAll("api/Books"));
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
        private async Task GetEditorials()
        {
            try
            {
                Editorials = new ObservableCollection<EditorialDTO>(await _editorialSvc.GetAll("api/Editorials"));
            }
            catch (Exception ex)
            {
                Msj = ex.Message;
            }
        }

        private async Task GetAuthors()
        {
            try
            {
                Authors = new ObservableCollection<AuthorListDTO>(await _authorSvc.GetAll("api/Authors"));
            }
            catch (Exception ex)
            {
                Msj = ex.Message;
            }
        }

        private bool ValidateFields()
        {
            bool validate = true;

            if (string.IsNullOrEmpty(NameBook))
            {
                Msj = "Nombre requerido *";
                validate = false;
            }
            else if (WriteDate == default)
            {
                Msj = "Fecha de escritura requierida *";
                validate = false;
            }
            else if (Price == decimal.Zero)
            {
                Msj = "Precio requerido *";
                validate = false;
            }
            else if (IdAuthor == default)
            {
                Msj = "Autor requerido *";
                validate = false;
            }
            else
            {
                validate = true;
            }
            return validate;
        }
        private async void ClearFields()
        {
            NameBook = string.Empty;
            Price = decimal.Zero;
            Remarks = string.Empty;
            await Task.Delay(3500);
            Msj = string.Empty;
            
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

        public string NameBook
        {
            get => name;
            set => SetProperty(ref name, value);
        }
        private DateTime writeDate;

        public DateTime WriteDate
        {
            get => writeDate;
            set => SetProperty(ref writeDate, value);
        }
        private DateTime launchDate;

        public DateTime LaunchDate
        {
            get => launchDate;
            set => SetProperty(ref launchDate, value);
        }

        private decimal price;

        public decimal Price
        {
            get => price;
            set => SetProperty(ref price, value);
        }

        private int idAuthor;

        public int IdAuthor
        {
            get => idAuthor;
            set => SetProperty(ref idAuthor, value);
        }

        private int idEditorial;

        public int IdEditorial
        {
            get => idEditorial;
            set => SetProperty(ref idEditorial, value);
        }

        private string remarks;

        public string Remarks
        {
            get => remarks;
            set => SetProperty(ref remarks, value);
        }

        private ObservableCollection<BookListDTO> bookList;

        public ObservableCollection<BookListDTO> BookList
        {
            get => bookList;
            set => SetProperty(ref bookList, value);
        }


        private ObservableCollection<AuthorListDTO> authors;

        public ObservableCollection<AuthorListDTO> Authors
        {
            get => authors;
            set => SetProperty(ref authors, value);
        }

        private ObservableCollection<EditorialDTO> editorials;

        public ObservableCollection<EditorialDTO> Editorials
        {
            get => editorials;
            set => SetProperty(ref editorials, value);
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
