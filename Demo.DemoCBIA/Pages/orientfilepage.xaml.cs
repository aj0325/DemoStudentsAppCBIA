
using Demo.DemoCBIA.ViewModels;
using System.Net;
namespace Demo.DemoCBIA.Pages;

public partial class orientfilepage : ContentPage
{
	public orientfilepage(string pdfFileName)
	{
		InitializeComponent();
        var viewModel = BindingContext as PdfViewerViewModel;
        viewModel?.UpdatePdfFile(pdfFileName);

    }
}