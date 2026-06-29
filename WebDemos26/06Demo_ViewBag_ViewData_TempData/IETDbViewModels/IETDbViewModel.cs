using _06Demo_ViewBag_ViewData_TempData.Models;

namespace _06Demo_ViewBag_ViewData_TempData.IETDbViewModels
{
    // MVVM Design Pattern : Model - View - ViewModel
    // ViewModel : it represents collection of Buissness entities from your application / Database: POCO entities
    public class IETDbViewModel
    {
        public List<Emp> allEmployees { get; set; }
        public List<Customer> allCustomers { get; set; }
    }
}
