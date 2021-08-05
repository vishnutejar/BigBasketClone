using System.Collections.ObjectModel;

namespace BigBasketClone.services
{
    public class FlyoutItemsService
    {
        public static ObservableCollection<FlyoutItemsModel> flyoutItemsModels;

        public static ObservableCollection<FlyoutItemsModel> GetFlyoutItems()
        {

            flyoutItemsModels = new ObservableCollection<FlyoutItemsModel>() {
                new FlyoutItemsModel(){ FlyoutItemName="Home",IsNew=false},
                new FlyoutItemsModel(){ FlyoutItemName="MyList",IsNew=false},
                new FlyoutItemsModel(){ FlyoutItemName="Profile",IsNew=false},
                new FlyoutItemsModel(){ FlyoutItemName="More",IsNew=false}
    };
            return flyoutItemsModels;
    }

}
}
