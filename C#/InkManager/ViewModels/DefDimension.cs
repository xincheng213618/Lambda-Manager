using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace InkManager.ViewModels
{
    public class DefDimension : INotifyPropertyChanged
    {
		private Color color = Color.FromArgb(240, 240, 0, 0);
		private Color textcolor = Colors.White;
		private double length = 100;
		private string _dimPos = "下右";

		/// <summary>
		/// Gets/sets the currently selected color.
		/// </summary>
		public Color DimColor
		{
			get { return color; }
			set
			{
				if (color != value)
				{
					color = value;
					NotifyPropertyChanged(nameof(DimColor));
				}
			}
		}
		public Color TextColor
		{
			get { return textcolor; }
			set
			{
				if (textcolor != value)
				{
					textcolor = value;
					NotifyPropertyChanged(nameof(TextColor));
				}
			}
		}



		public double DimLength
		{
			get { return length; }
			set
			{
				if (length != value)
				{
					length = value;
					NotifyPropertyChanged(nameof(DimLength));
				}
			}
		}




		public string DimPos
		{
			get { return _dimPos; }
			set
			{
				if (_dimPos != value)
				{
					_dimPos = value;
					NotifyPropertyChanged(nameof(DimPos));
				}
			}
		}

		#region INotifyPropertyChanged Members
		public event PropertyChangedEventHandler? PropertyChanged;
		//public event PropertyChangedEventHandler PropertyChanged;

		#endregion

		#region Private Helpers

		private void NotifyPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion


		//protected virtual void RaisePropertyChanged(string propertyName)
		//{
		//	// Cache the handler to make this thread safe
		//	var handler = PropertyChanged;

		//	if (handler != null)
		//		handler(this, new PropertyChangedEventArgs(propertyName));
		//}


		//public void RaisePropertyChanged<TProperty>(Expression<Func<TProperty>> property)
		//{
		//	var lambda = (LambdaExpression)property;
		//	MemberExpression memberExpression;

		//	if (lambda.Body is UnaryExpression)
		//	{
		//		var unaryExpression = (UnaryExpression)lambda.Body;
		//		memberExpression = (MemberExpression)unaryExpression.Operand;
		//	}
		//	else
		//		memberExpression = (MemberExpression)lambda.Body;

		//	RaisePropertyChanged(memberExpression.Member.Name);
		//}
		//#endregion







	}




}
