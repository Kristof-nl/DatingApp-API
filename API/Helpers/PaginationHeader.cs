namespace API.Helpers
{
    public class PaginationHeader
    {
        public PaginationHeader(int CurrentPage, int ItemsPerPage, int TotalItems, int TotalPages)
        {
            CurrentPage = CurrentPage;  
            ItemsPerPage = ItemsPerPage;
            TotalItems = TotalItems;
            TotalPages = TotalPages;
        }

        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
    }
}
