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
using TeachingLoadLib.Helpers;

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
                //groups = context.Groups.ToList();
                //this.DataGridGroups.ItemsSource = groups;
                //teachers = context.Teachers.ToList();
                //this.DataGridTeachers.ItemsSource = teachers;


                //this.DataGridDisciplines.Columns.RemoveAt(0);
                //for (int i = 0; i < DataGridHeaders.DisciplinesHeaders.Count; i++)
                //{
                //    this.DataGridDisciplines.Columns[i].Header = DataGridHeaders.DisciplinesHeaders[i];
                //}
                //this.DataGridGroups.Columns.RemoveAt(0);
                //for (int i = 0; i < DataGridHeaders.GroupsHeaders.Count; i++)
                //{
                //    this.DataGridGroups.Columns[i].Header = DataGridHeaders.GroupsHeaders[i];
                //}
                //this.DataGridTeachers.Columns.RemoveAt(0);
                //for (int i = 0; i < DataGridHeaders.TeachersHeaders.Count; i++)
                //{
                //    this.DataGridTeachers.Columns[i].Header = DataGridHeaders.TeachersHeaders[i];
                //}
            }

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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.DataGridDisciplines.Columns.Count.ToString());
        }

       
        
    }
}
