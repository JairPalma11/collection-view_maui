using CollectionViewMAUI.Services;
using Microsoft.Maui.Controls;

namespace CollectionViewMAUI.Pages;

public partial class TemplateCollectionViewPage : ContentPage
{
	public TemplateCollectionViewPage()
	{
		InitializeComponent();
	}

    void ContactsAdded(System.Object sender, System.EventArgs e)
    {
        collectionView.ItemsSource = ContactService.GetContacts(10);
    }
}
