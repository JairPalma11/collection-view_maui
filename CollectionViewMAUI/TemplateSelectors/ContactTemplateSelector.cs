using System;
using CollectionViewMAUI.Models;

namespace CollectionViewMAUI.TemplateSelectors
{
    /// <summary>
    /// El trabajo principal de un DataTemplateSelector
    /// es determinar que template mostrar de acuerdo
    /// a la necesidad
    /// </summary>
    public class ContactTemplateSelector : DataTemplateSelector
    {
        /// <summary>
        /// al tener las propiedades como set/get
        /// podemos definir diferentes template para cada caso
        /// aunque podemos simplemente asignarlos.
        /// </summary>
        public DataTemplate? FavoriteContactTemplate { get; set; }

        public DataTemplate? ContactTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var contact = item as MyContact;
            //verificamos si el contacto
            //es favorito, si es mostramos
            //la informacion de manera diferent
            //como se nos indique a traves de la propiedad
            //FavoriteContactTemplate
            if (contact.IsFavorite)
            {
                return FavoriteContactTemplate;
            }
            else
            {
                return ContactTemplate;
            }
        }
    }
}

