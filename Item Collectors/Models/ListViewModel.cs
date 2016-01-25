using System;
using System.Collections.ObjectModel;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace Item_Containers
{
    class ListViewModel
    {
        public static ObservableCollection<ListViewItem> ListViewItems { get; set; }
        private static Random random;

        public ListViewModel()
        {
            ListViewItems = new ObservableCollection<ListViewItem>();
            random = new Random();
            AddItem();
        }

        public static void AddItem()
        {
            ListViewItems.Add(new ListViewItem() {
                firstName = "Contact",
                lastName = (ListViewItems.Count + 1).ToString(),
                mobileNumber = "+355-" + random.Next(10, 100) + "-" + random.Next(10,100) + "-" + random.Next(10,100) + "-" + +random.Next(100, 1000),
                color = new SolidColorBrush(new Color() {
                    A = 255,
                    R = (byte)random.Next(255),
                    G = (byte)random.Next(255),
                    B = (byte)random.Next(255),
                })
            });
        }

        public static void RemoveItem(ListViewItem item)
        {
            ListViewItems.Remove(item);
        }
    }
}