using System;
using Xamarin.Forms;

namespace Actividad3
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			Label etiqueta = new Label {
				Text = "Imprime tu nombre\nen color:",
				TextColor = Color.White
			};

			Button btnNA = new Button
			{
				Text = "Agua"
			};

			btnNA.Clicked += (sender, e) => {
				etiqueta.Text = "Hernández Molina,\nJosué Eli:\n402008176";
				etiqueta.TextColor=Color.Aqua;
			};

			Button btnNO = new Button
			{
				Text = "Olivo"
			};

			btnNO.Clicked += (sender, e) => {
				etiqueta.Text = "Hernández Molina,\nJosué Eli:\n402008176";
				etiqueta.TextColor=Color.Olive;
			};

			//Stacklayout permite apilar los controles verticalmente
			StackLayout stackLayout = new StackLayout
			{
				Children =
				{
					etiqueta,
					btnNA,
					btnNO
				}
				};

			ContentPage contentPage = new ContentPage ();
			contentPage.Content = stackLayout;

			//Padding agrega un margen al contenido
			//Device.OnPlatform permite modificar este margen dependiendo de la plataforma IOS, Android y Windows Phone
			//Para saber más sobe Device.OnPlatform revisa 
			contentPage.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);

			return contentPage;
		}
	}
}

