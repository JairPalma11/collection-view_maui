using CollectionViewMAUI.Services;

namespace CollectionViewMAUI.Pages;

public partial class GridCollectionViewPage : ContentPage
{
	public GridCollectionViewPage()
	{
		InitializeComponent();
	}

    void ContactsAdded(System.Object sender, System.EventArgs e)
    {
        collectionView.ItemsSource = ContactService.GetContacts(50);
    }
}
