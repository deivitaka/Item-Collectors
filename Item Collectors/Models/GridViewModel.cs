using System;
using System.Collections.ObjectModel;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace Item_Containers
{
    class GridViewModel
    {
        public static ObservableCollection<GridViewItem> GridViewItems { get; set; }
        private static Random random;

        public GridViewModel()
        {
            GridViewItems = new ObservableCollection<GridViewItem>();
            random = new Random();
        }

        public static void AddItem()
        {
            GridViewItems.Add(new GridViewItem()
            {
                name = "APP NAME " + (GridViewItems.Count + 1),
                price = "free",
                rate = AddStars(random.Next(1,6)),
                color = new SolidColorBrush(new Color()
                {
                    A = 255,
                    R = (byte)random.Next(255),
                    G = (byte)random.Next(255),
                    B = (byte)random.Next(255),
                })
            });
        }

        private static string AddStars(int v)
        {
            string s = "";
            for (int i = 0; i < v; i++)
                s += "✰";

            return s;
        }
    }
}