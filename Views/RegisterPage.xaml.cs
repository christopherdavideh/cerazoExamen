namespace cerazoExamen.Views;

public partial class RegisterPage : ContentPage
{
    private double cost = 1500;
    double monthAmount = 0;
    double total = 0;

    public RegisterPage()
	{
        string username = Preferences.Get("Username", string.Empty);
		InitializeComponent();
        lblUser.Text = "Usuario conectado: " + username;
    }

    private void btnCalculate_Clicked(object sender, EventArgs e)
    {
        monthAmount = ((cost-Convert.ToDouble(txtAmount.Text))/4)+(cost*0.04);
        txtMonthAmount.Text = monthAmount.ToString();
        total = (monthAmount * 4) + Convert.ToDouble(txtAmount.Text);
    }

    private void btnShowSummary_Clicked(object sender, EventArgs e)
    {
        Preferences.Set("Name", txtName.Text);
        Preferences.Set("Lastname", txtLastname.Text);
        Preferences.Set("Age", txtAge.Text);
        Preferences.Set("Date", pckDate.Date.ToString());
        Preferences.Set("City", pckCity.Items[pckCity.SelectedIndex].ToString());
        Preferences.Set("Country", pckCountry.Items[pckCountry.SelectedIndex].ToString());
        Preferences.Set("Amount", txtAmount.Text);
        Preferences.Set("Month", monthAmount);
        Preferences.Set("Total", total);
        Navigation.PushAsync(new SummaryPage());
    }
}