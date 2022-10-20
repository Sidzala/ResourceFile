using System.Globalization;
using System.Linq;
using System.Threading;
using ResourceFile.Resources;
using Xamarin.Forms;

namespace ResourceFile
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        void ChangeLanguage1_Clicked(System.Object sender, System.EventArgs e)
        {
            if (picker.SelectedItem != null)
            {
                var language = CultureInfo.GetCultures(CultureTypes.NeutralCultures).ToList().First(element => element.EnglishName.Contains(picker.SelectedItem.ToString())); ;
                Thread.CurrentThread.CurrentUICulture = language;
                AppResources.Culture = language;
                new NavigationPage(new MainPage());
            }
        }
    }
}

