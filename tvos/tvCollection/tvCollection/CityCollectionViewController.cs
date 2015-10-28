// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace tvCollection
{
	public partial class CityCollectionViewController : UICollectionViewController
	{
		#region Computed Properties
		public CityCollectionView Collection {
			get { return CollectionView as CityCollectionView; }
		}
		#endregion

		#region Constructors
		public CityCollectionViewController (IntPtr handle) : base (handle)
		{
		}
		#endregion

		#region Override Methods
		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();

			// Save link to controller
			Collection.ParentController = this;
		}
		#endregion
	}
}
