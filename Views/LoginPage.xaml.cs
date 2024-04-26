using System;

namespace cerazoExamen.Views;

public partial class LoginPage : ContentPage
{
    private string[,] usersData = new string[2, 2];
    
    public LoginPage()
	{
		InitializeComponent();
	}

    private void btnLogin_Clicked(object sender, EventArgs e)
    {
        usersData[0, 0] = "estudiante2024";
        usersData[0, 1] = "uisrael2024";
        usersData[1, 0] = "examen1";
        usersData[1, 1] = "parcial1";
        string username = txtUser.Text;
        string password = txtPass.Text;

        bool isAuth = false;

        for (int i = 0; i < usersData.GetLength(0); i++)
        {
            if (usersData[i, 0] == username && usersData[i, 1] == password)
            {
                isAuth = true;
                break;
            }
        }

        if (isAuth)
        {
            Preferences.Set("Username", username);
            Navigation.PushAsync(new RegisterPage());
        }
        else
        {
            DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }

    private void btnRegister_Clicked(object sender, EventArgs e)
    {

    }
}