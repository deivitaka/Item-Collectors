namespace Item_Containers
{
    class ViewModel
    {
        public ListViewModel listViewModel { get; set; }
		public GridViewModel gridViewModel { get; set; }

        public ViewModel()
        {
            listViewModel = new ListViewModel();
            ListViewModel.AddItem();
            gridViewModel = new GridViewModel();
        }
    }
}