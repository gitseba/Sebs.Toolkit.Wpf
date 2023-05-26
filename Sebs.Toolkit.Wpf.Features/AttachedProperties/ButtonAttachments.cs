using System.Windows;

namespace Sebs.Toolkit.Wpf.Features.AttachedProperties
{
    /// <summary>
    /// Purpose:  The IsBusy attached property for a anything that wants to flag if the control is busy
    /// Created by: sebde
    /// Created at: 5/19/2023 4:43:21 PM
    /// </summary>
    public class IsBusyProperty : BaseAttachedProperty<IsBusyProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            base.OnValueChanged(sender, e);
        }

        public override void OnValueUpdated(DependencyObject sender, object value)
        {
            base.OnValueUpdated(sender, value);
        }
    }
}
