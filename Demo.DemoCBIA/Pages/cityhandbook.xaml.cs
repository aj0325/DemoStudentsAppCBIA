using Demo.DemoCBIA.ViewModels;
using System.Net;

namespace Demo.DemoCBIA.Pages;

public partial class cityhandbook : ContentPage
{
	public cityhandbook(string pdfFileName)
	{
		InitializeComponent();
        var viewModel = BindingContext as PdfViewerViewModel;
        viewModel?.UpdatePdfFile(pdfFileName);
    }
}