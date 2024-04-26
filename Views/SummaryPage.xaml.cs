using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace cerazoExamen.Views;

public partial class SummaryPage : ContentPage
{
	public SummaryPage()
	{
        string username = Preferences.Get("Username", string.Empty);
        string name = Preferences.Get("Name", string.Empty);
        string lastname = Preferences.Get("Lastname", string.Empty);
        string age = Preferences.Get("Age", string.Empty);
        string date = Preferences.Get("Date", string.Empty);
        string city = Preferences.Get("City", string.Empty);
        string country = Preferences.Get("Country", string.Empty);
        string amount = Preferences.Get("Amount", string.Empty);
        string month = Preferences.Get("Month", string.Empty);
        string total = Preferences.Get("Total", string.Empty);
        InitializeComponent();
        lblName.Text = name;
        lblLastname.Text = lastname;
        lblAge.Text = age;
        lblDate.Text = date;
        lblCity.Text = city;
        lblCountry.Text =country;
        lblAmount.Text = amount;
        lblMonth.Text = month;
        lblTotal.Text = total;
    }
}