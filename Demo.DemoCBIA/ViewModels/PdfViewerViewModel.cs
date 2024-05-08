using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DemoCBIA.ViewModels
{
    internal class PdfViewerViewModel : INotifyPropertyChanged
    {
        public Stream? m_pdfDocumentStream;
        public event PropertyChangedEventHandler PropertyChanged;   
        public Stream PdfDocumentStream
        {
            get => m_pdfDocumentStream;
            set
            {
                m_pdfDocumentStream = value;
                OnPropertyChanged("PdfDocumentStream");
            }
        }

        public PdfViewerViewModel()
        {
            //m_pdfDocumentStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("Demo.DemoCBIA.Assets.Orientation-Guide.pdf");
        }

        public void UpdatePdfFile(string pdfFileName)
        {
            var resourcePath = $"Demo.DemoCBIA.Assets.{pdfFileName}";
            PdfDocumentStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream(resourcePath);
            OnPropertyChanged(nameof(PdfDocumentStream));
        }

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
