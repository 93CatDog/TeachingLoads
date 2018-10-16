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
        public bool IsChanged { get; set; }

        public List<Discipline> disciplines { get; set; }
        public List<Teacher> teachers { get; set; }
        public List<Group> groups { get; set; }


        public MainWindow()
        {
            InitializeComponent();

            using (var context = new TeachingLoadContext())
            {
                disciplines = context.Disciplines.ToList();
                this.DataGridDisciplines.ItemsSource = disciplines;
                groups = context.Groups.ToList();
                this.DataGridGroups.ItemsSource = groups;
                teachers = context.Teachers.ToList();
                this.DataGridTeachers.ItemsSource = teachers;

                
            }

            MessageBox.Show(Discipline.Count + " " + Group.Count + " " + Teacher.Count);

            //this.Expander.Expanded += Expander_Expanded;

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

            //context.SaveChanges();



            //second stage



            //Group t = new Group("ТА-81");

            //Discipline d = new Discipline("Контролери");

            //context.Groups.Add(t);
            //context.Disciplines.Add(d);

            //context.SaveChanges();




        }

        /*private void TabTeachers_Click(object sender, RoutedEventArgs e)
        {
            using(var context = new TeachingLoadContext())
            {
                teachers = context.Teachers.ToList();
                this.DataGridTeachers.ItemsSource = teachers;
            }

        }*/

        private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction != DataGridEditAction.Cancel)
            {
                this.IsChanged = true;
            }
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Teacher t = (Teacher)e.Row.DataContext;
            //using (var context = new TeachingLoadContext())
            //{
            //    //teachers = context.Teachers.ToList().Re
            //    //this.DataGridView.ItemsSource = teachers;
                
            //}
        }
    }
}
