using CommunityToolkit.Maui.Views;
using Data.Core.Models;
using Data.Core.Services.Interfaces;

namespace MobileApp.Pages.HiveList.Views;

public partial class ChangeQueenPopup : Popup
{
    private DateTime _date;
    public DateTime Date { get => _date; set { _date = value; OnPropertyChanged(nameof(Date)); } }
    public BeeQueen _beeQueen;
    public BeeQueen BeeQueen { get => _beeQueen; set { _beeQueen = value; OnPropertyChanged(nameof(BeeQueen)); } }
    private List<BeeQueen> _availableQueens;
    public List<BeeQueen> AvailableQueens { get => _availableQueens; set { _availableQueens = value; OnPropertyChanged(nameof(AvailableQueens)); } }

    private readonly IBeeService _beeService;
    public ChangeQueenPopup(IBeeService beeService)
    {
        _beeService = beeService;
        InitializeComponent();
        InitilizeData();
    }

    private void InitilizeData()
    {
        Date = DateTime.Now.Date;
        BeeQueen = null;
        AvailableQueens = _beeService.GetAllQueensWithoutHive();
    }

    private void OnOkClicked(object sender, EventArgs e)
    {

        Close(new Tuple<DateTime, BeeQueen>(Date, BeeQueen));
    }

    private void OnCancelClicked(object sender, EventArgs e)
    {
        // Zamkni�cie okienka bez zwracania danych
        Close(null);
    }
}