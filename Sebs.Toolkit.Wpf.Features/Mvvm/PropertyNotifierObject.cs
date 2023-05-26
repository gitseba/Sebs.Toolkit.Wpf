using System.ComponentModel;

namespace Sebs.Toolkit.Wpf.Features.Mvvm
{
    /// <summary>
    /// Purpose: Notify Ui if any of the model/view model property changes.
    /// Created by: sebde
    /// Created at: 5/26/2023 4:18:01 PM
    /// </summary>
    public class PropertyNotifierObject : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Call this to fire a <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}