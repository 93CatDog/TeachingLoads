
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TeachingLoadCore.Contexts;
using TeachingLoadCore.Entities;
using TeachingLoadCore.ExcelIntegration;

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

            //ExcelReader er = new ExcelReader(ExcelPaths.DisciplinesPath);
            //this.disciplines = er.ReadSheet();

            //using (var context = new TeachingLoadContext())
            //{
            //    //context.Disciplines.UpdateRange(disciplines);
                
            //    context.Disciplines.UpdateRange(disciplines);

            //    context.SaveChangesAsync();

            //    //disciplines = context.Disciplines.ToList();
            //    //this.DataGridDisciplines.ItemsSource = disciplines;
            //}

            //using (var context = new TeachingLoadContext())
            //{
            //    disciplines = context.Disciplines.ToList();
            //    this.DataGridDisciplines.ItemsSource = disciplines;
            //    groups = context.Groups.ToList();
            //    this.DataGridGroups.ItemsSource = groups;
            //    teachers = context.Teachers.ToList();
            //    this.DataGridTeachers.ItemsSource = teachers;
            //}
        }



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
