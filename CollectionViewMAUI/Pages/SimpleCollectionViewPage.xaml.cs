using CollectionViewMAUI.Services;

namespace CollectionViewMAUI.Pages;
public partial class SimpleCollectionViewPage : ContentPage
{
	public SimpleCollectionViewPage()
	{
		InitializeComponent();
		collectionView.ItemsSource = ContactService.GetContacts(10);
    }
}
