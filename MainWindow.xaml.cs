using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System;
using System.ComponentModel;
using System.Drawing;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateTable();
        }

        public void CreateTable()
        {
            List<Person> personsList = new List<Person>(3);
            personsList.Add(new Person (1,"Иванов","Иван" ));
            personsList.Add(new Person (2, "Сидоров", "Сидор"));
            personsList.Add(new Person (3, "Петров", "Петр"));
            personGrid.ItemsSource = personsList;
        }
        public void CreateFileName(object sender, TextChangedEventArgs e)
        {
            fileName.Content = textBox.Text;
        }
        private void PrintButtonClick(object sender, RoutedEventArgs e)
        {
            using (PdfDocument document = new PdfDocument())
            {
                PdfPage page = document.Pages.Add();
                PdfGraphics graphics = page.Graphics;
                PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 14);
                graphics.DrawString(fileName.Content.ToString(), font, PdfBrushes.Black, new PointF(0, 0));
                document.Save(fileName.Content.ToString()+".pdf");
            }
            MessageBox.Show("Файл создан");
        }
    }
}