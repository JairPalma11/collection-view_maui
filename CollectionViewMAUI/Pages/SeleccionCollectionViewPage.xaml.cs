using CollectionViewMAUI.Models;
using CollectionViewMAUI.Services;

namespace CollectionViewMAUI.Pages;

public partial class SeleccionCollectionViewPage : ContentPage
{
	public SeleccionCollectionViewPage()
	{
		InitializeComponent();
	}

    void ContactsAdded(System.Object sender, System.EventArgs e)
    {
        collectionView.ItemsSource = ContactService.GetContacts(10);
    }


    async void OnSelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        string title = string.Empty;
        MyContact? contact = null;

        switch (collectionView.SelectionMode)
        {
            //si la seleccion es de un
            //solo elemento
            case SelectionMode.Single:
                contact = e.CurrentSelection.FirstOrDefault() as MyContact;
                title = $"{contact?.FirstName} {contact?.LastName}";
                await DisplayAlert(title, $"{contact?.PhoneNumber}", "OK");
                break;

            case SelectionMode.Multiple:
                title = $"Contactos seleccionados {e.CurrentSelection.Count}";
                //convertimos la lista de contactos
                var contacts = e.CurrentSelection.Cast<MyContact>().ToList();
                //hacemos un solo string
                var names = contacts.Select(c => c.FirstName).ToList();
                var message = string.Join(",", names);
                await DisplayAlert(title, message, "OK");
                break;
        }
    }
}
