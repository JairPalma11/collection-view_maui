using CollectionViewMAUI.Services;

namespace CollectionViewMAUI.Pages;
public partial class SimpleCollectionViewPage : ContentPage
{
	public SimpleCollectionViewPage()
	{
		InitializeComponent();
    }

    void ContactsAdded(System.Object sender, System.EventArgs e)
    {
        collectionView.ItemsSource = ContactService.GetContacts(10);
    }
}
