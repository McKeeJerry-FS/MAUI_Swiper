using MAUI_Swiper.Controls;

namespace MAUI_Swiper
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		private int _likeCount;
		private int _denyCount;
		

		public MainPage()
		{
			InitializeComponent();
			AddInitialPhotos();
		}

		private void AddInitialPhotos()
		{
			for (int i = 0; i < 10; i++) {
				InsertPhoto();
			}
		}

		private void InsertPhoto()
		{
			var photo = new SwiperControl();
			photo.OnDeny += Handle_OnDeny;
			photo.OnLike += Handle_OnLike;
			this.MainGrid.Children.Insert(0, photo);
		}

		private void UpdateGui()
		{
			likeLabel.Text = _likeCount.ToString();
			denyLabel.Text = _denyCount.ToString();
		}

		private void Handle_OnLike(object sender, EventArgs e)
		{
			_likeCount++;
			InsertPhoto();
			UpdateGui();
		}

		private void Handle_OnDeny(object sender, EventArgs e)
		{
			_denyCount++;
			InsertPhoto();
			UpdateGui();
		}

		//private void OnCounterClicked(object sender, EventArgs e)
		//{
		//	count++;

		//	if (count == 1)
		//		CounterBtn.Text = $"Clicked {count} time";
		//	else
		//		CounterBtn.Text = $"Clicked {count} times";

		//	SemanticScreenReader.Announce(CounterBtn.Text);
		//}
	}

}
