using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TeachingLoad.Models;
using TeachingLoadLib.Entities;

namespace TeachingLoad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Teacher> teachers { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            this.Expander.Expanded += Expander_Expanded;

            //using (var context = new TeachingLoadContext())
            //{

            //    List<Teacher> teachers = new List<Teacher>
            //    {
            //    new Teacher(5,"Олександр", "Степанець", "Васильович"),
            //    new Teacher(6,"Валерій", "Бунь", "Павлович"),
            //    new Teacher(7,"Ігор", "Поліщук", "Анатолійович"),
            //    new Teacher(8,"Тарас", "Баган", "Григорович")
            //    };

            //    context.Teachers.UpdateRange(teachers);

            //Teacher t = new Teacher(4, "Тарас", "Баган", "Григорович");
            //context.Teachers.Add(t);

            //context.SaveChanges();


            //List<Teacher> teachers = context.Teachers.ToList();

            //foreach(var teacher in teachers)
            //{

            //}

            //}



        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            if (this.Expander.IsExpanded)
            {
                this.ContainerColumn2.Margin = new Thickness(0);
            }
            else
            {
                this.ContainerColumn2.Margin = new Thickness(-150, 0, 0, 0);

            }
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.Expander.Margin = new Thickness(5, -347, 0, 0);
            else
                this.Expander.Margin = new Thickness(5, -27, 0, 0);
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            using(var context = new TeachingLoadContext())
            {
                teachers = context.Teachers.ToList();
                this.DataGridView.ItemsSource = teachers;
            }

        }

        private void DataGridView_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction != DataGridEditAction.Cancel)
            {
                MessageBox.Show("MUST COMMIT");
            }
            //Teacher t = (Teacher)e.Row.DataContext;
            //using (var context = new TeachingLoadContext())
            //{
            //    //teachers = context.Teachers.ToList().Re
            //    this.DataGridView.ItemsSource = teachers;
            //}
        }
    }
}
