using Examen03.Models;
using Examen03.Utilitarios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Examen03.ViewModels
{
    public class ViewModelListarProductos:ViewModelBase
    {
        #region Propiedades

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                _Nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }

        private int _Precio;
        public int Precio
        {
            get { return _Precio; }
            set
            {
                _Precio = value;
                OnPropertyChanged(nameof(Precio));
            }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                _Descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
            }
        }

        #endregion

        public ObservableCollection<ProductoModel> Productos { get; }

        public ICommand AgregarCommand { get; }

        public ViewModelListarProductos() {
            AgregarCommand = new RelayCommand(Agregar);
            Productos = new ObservableCollection<ProductoModel>();
        }

        private void Agregar()
        {
            Productos.Add(new ProductoModel
            {
                Nombre = this.Nombre,
                Precio = this.Precio,
                Descripcion = this.Descripcion
            });
        }
    }

}
