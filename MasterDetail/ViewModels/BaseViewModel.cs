using System.ComponentModel;

namespace MasterDetail
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		bool isBusy;
		public bool IsBusy
		{
			get { return isBusy; }
			set { isBusy = value; OnPropertyChanged("IsBusy"); }
		}
		
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}