using CollectionViewMAUI.Models;
using CollectionViewMAUI.Services;

namespace CollectionViewMAUI.Pages;

public partial class ContextActionsCollectionViewPage : ContentPage
{
	public ContextActionsCollectionViewPage()
	{
		InitializeComponent();
	}

    void ContactsAdded(System.Object sender, System.EventArgs e)
    {
        collectionView.ItemsSource = ContactService.GetContacts(10);
    }

    async void OnDelete(System.Object sender, System.EventArgs e)
    {
        //obtenemos el SwipeItem
        //que es el elemento que tiene el evento click
        var swipeItem = sender as SwipeItem;
        //obtenemos el comandParameter que
        //vinculamos usando el {Binding .}
        //donde . = al objecto actual de la lista
        var contact = swipeItem?.CommandParameter as MyContact;
        await DisplayAlert("Eliminando...", $"{contact?.FirstName}", "OK");
    }

    async void OnCall(System.Object sender, System.EventArgs e)
    {
        //obtenemos el SwipeItem
        //que es el elemento que tiene el evento click
        var swipeItem = sender as SwipeItem;
        //obtenemos el comandParameter que
        //vinculamos usando el {Binding .}
        //donde . = al objecto actual de la lista
        var contact = swipeItem?.CommandParameter as MyContact;
        await DisplayAlert("Llamando...", $"{contact?.FirstName} {contact?.PhoneNumber}", "OK");
    }
}
