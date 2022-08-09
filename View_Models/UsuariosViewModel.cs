using CommunityToolkit.Mvvm.ComponentModel;
using testbinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testbinding.View_Models
{
    public partial class UsuariosViewModel : ObservableObject
    {
        private ObservableCollection<Usuarios> _usuarios;

        public ObservableCollection<Usuarios> Usuarios
        {
            get { return _usuarios; }
            set { _usuarios = value; }
        }

        public UsuariosViewModel()
        {
            _usuarios = new ObservableCollection<Usuarios>();

            using (AppDbContext context = new AppDbContext())
            {
                List<Usuarios> listausuarios = context.Usuarios.ToList();


                foreach (var user in listausuarios)
                {
                    _usuarios.Add(user);

                }
            }
        }
    }
}
