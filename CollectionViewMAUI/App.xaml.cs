using CollectionViewMAUI.Pages;

namespace CollectionViewMAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        //descomentar para ver primer ejemplo
        //MainPage = new NavigationPage(new SimpleCollectionViewPage());

        //descomentar para ver segundo ejemplo
        //layout en CollectionView Grid
        //MainPage = new NavigationPage(new GridCollectionViewPage());

        //descomentar para ver las acciones
        //en contexto
        MainPage = new NavigationPage(new ContextActionsCollectionViewPage());
        
    }
}

